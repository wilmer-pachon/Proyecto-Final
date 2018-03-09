using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Normal_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {/*
        Session["user"] = null;
        Session["id_rol"] = null;
        Session["id_user"] = null;*/
        Response.Cache.SetNoStore();
        Session["nombre"] = null;
        Session["id_rol"] = null;
        Session["user_id"] = null;
       
    }

   

    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        EDatos user1 = new EDatos();
        user1.Nom_user = loggin.UserName.ToString(); /////text box usuario
        DAONormal daoUser = new DAONormal();
        DataTable datos = daoUser.correoUsuario(user1);
        if (datos.Rows.Count > 0)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
            mail.From = new MailAddress("biblioseg@gmail.com", "BiblioSeg", Encoding.UTF8);
            //Aquí ponemos el asunto del correo
            mail.Subject = "Datos de la cuenta de BiblioSeg";
            //Aquí ponemos el mensaje que incluirá el correo
            mail.Body = "Tu nombre de usuario es: ";
            mail.Body += datos.Rows[0]["nom_user"].ToString() + "\n";
            mail.Body += "Tu clave es: ";
            mail.Body += datos.Rows[0]["clave"].ToString();

            //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
            //Enviar a todos los usuarios.
            mail.To.Add(datos.Rows[0]["correo"].ToString());
            //Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran
            //mail.Attachments.Add(new Attachment(@"C:\Documentos\carta.docx"));

            //Configuracion del SMTP
            SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios
            //Especificamos las credenciales con las que enviaremos el mail
            SmtpServer.Credentials = new System.Net.NetworkCredential("biblioseg@gmail.com", "wilmer123");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Se ha enviado un mensaje al correo: " + datos.Rows[0]["correo"].ToString() + "');</script>");
        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El usuario especificado no existe en nuestra base de datos.');</script>");
        }
    }


    protected void LoginButton_Click(object sender, EventArgs e)
    {
        //EDatos encapsular = new EDatos();

        EUsuario encapsular = new EUsuario();
        encapsular.User_name = loggin.UserName.ToString();
        encapsular.Clave = loggin.Password.ToString();

        MAC m = new MAC();
        // string ipAddress = HttpContext.Current.Request.UserHostAddress;

        encapsular.Mac = m.mac();

        encapsular.Ip = m.ip();

        DAOUsuario datos = new DAOUsuario();
        DataTable users = datos.loginUsuarios(encapsular);

        if (users.Rows.Count > 0)
        {
            Session["nom_user"] = users.Rows[0]["nom_user"].ToString();
            Session["id_rol"] = users.Rows[0]["id_rol"].ToString();
            Session["user_id"] = users.Rows[0]["id_user"].ToString();
            Session["foto"] = users.Rows[0]["foto"].ToString();
            Session["t_puntos"] = users.Rows[0]["t_puntos"].ToString();

            if (Session["id_rol"].ToString().Equals("1"))
            {
                Response.Redirect("/Vista/Roles/Admin/index.aspx");
            }
            else
            {
                if (Session["id_rol"].ToString().Equals("2"))
                {
                    Response.Redirect("/Vista/Roles/Moderador/index.aspx");
                }
                else
                {
                    if (Session["id_rol"].ToString().Equals("3"))
                    {
                        Response.Redirect("/Vista/Roles/Registrado/index.aspx");
                    }
                    else
                    {
                        Session["user_id"] = null;
                        Session["id_rol"] = null;
                        Session["nom_user"] = null;
                    }

                }
            }

        }
    }
}