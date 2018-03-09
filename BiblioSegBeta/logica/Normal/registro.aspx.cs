using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Normal_registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Btn_Ingresar_Click(object sender, EventArgs e)
    {
        /* ENormal usuario = new ENormal();
         usuario.Nombre = Txt_Nombre.Text.ToString();
         usuario.Apellido = Txt_Apellido.Text.ToString();
         usuario.Correo = Txt_Correo.Text.ToString();
         usuario.User_name = Txt_NombreUsuario.Text.ToString();
         usuario.Clave = Txt_Clave.Text.ToString();

         DAONormal daoUsuario = new DAONormal();

         daoUsuario.insertarUsuario (usuario);

        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Registro exitoso');window.location=\"login.aspx\"</script>");*/
    }

    protected void bt_registrarse_Click(object sender, EventArgs e)
    {
        EDatos usuario = new EDatos();
        usuario.Nombre = txt_nombre.Text.ToString();
        usuario.Nom_user = txt_nomuser.Text.ToString();
        usuario.Correo = txt_correo.Text.ToString();
        usuario.Sitio_web = txt_sitio.Text.ToString();
        usuario.Clave = txt_clave.Text.ToString();
        ClientScriptManager cm = this.ClientScript;
        String nombreArchivo = System.IO.Path.GetFileName(fuPerfil.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(fuPerfil.PostedFile.FileName);
        // arre
        string saveLocation = (Server.MapPath("/Vista/images/perfil") + "/" + "pic".ToString()) + "_" + DateTime.Now.ToFileTime().ToString() + extension;

        if (!(extension.Equals(".jpg") || extension.Equals(".gif") || extension.Equals(".jpeg") || extension.Equals(".png")))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido');</script>");
            return;
        }

        if (System.IO.File.Exists(saveLocation))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
            return;
        }

        try
        {
            usuario.Foto = "/Vista/images/perfil" + "/" + "pic" + "_" + DateTime.Now.ToFileTime().ToString() + extension;
            fuPerfil.PostedFile.SaveAs(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Registrado');</script>");
        }
        catch (Exception ex)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error: ');</script>");
        }


        DAORegistrar daoUsuario = new DAORegistrar();

        daoUsuario.registrar_usuario(usuario);

        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Registro exitoso');window.location=\"login.aspx\"</script>");

    }
}