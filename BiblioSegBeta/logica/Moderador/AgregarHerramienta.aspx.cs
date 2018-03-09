using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Moderador_AgregarHerramienta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (fecha.Visible)
        {
            fecha.Visible = false;
        }
        else
        {
            fecha.Visible = true;
        }

    }
    protected void fecha_SelectionChanged(object sender, EventArgs e)
    {
        txtfecha.Text = fecha.SelectedDate.ToLongDateString();
        fecha.Visible = false;
    }
    protected void guardar_Click(object sender, EventArgs e)
    {

        EDHerramienta user = new EDHerramienta();
        DAOHerramienta daoUser = new DAOHerramienta();


        //txtfecha = fecha.SelectedDate;
        user.Nombre = txtnombre.Text;
        user.Sitio = txtsitio.Text;
        user.Fecha = DateTime.Parse(txtfecha.Text.ToString());
        user.Descripcion = txtdescripcion.Text;
        //user.Cat1 = DropDownCat.Text.ToString();
        //user.Len = DropDownLen.Text.ToString();
        user.Cat = Int32.Parse(DropDownCat.SelectedValue.ToString());
        user.Len = Int32.Parse(DropDownLen.SelectedValue.ToString());
        user.Os = DropDownOS.Text.ToString();
        user.Fu_foto = cargarImagen();
        user.Id_user = int.Parse(Session["user_id"].ToString());

        //usar.Txtdescripcion = (JsonConvert.SerializeObject(txtdescripcion));

        daoUser.insertarHerramienta(user);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Enviado a aprobacion.');</script>");
        //Response.Redirect("/Vista/Roles/Admin/moderar.aspx");

    }


    protected String cargarImagen()
    {
        String fu_foto = "";
        ClientScriptManager cm = this.ClientScript;
        string nombreArchivo = System.IO.Path.GetFileName(foto.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(foto.PostedFile.FileName);


        string saveLocation = Server.MapPath("~\\Vista\\images") + "\\" + nombreArchivo;
        fu_foto = "~\\Vista\\images" + "\\" + nombreArchivo;
        if (!(extension.Equals(".jpg") || extension.Equals(".gif") || extension.Equals(".jpge") || extension.Equals(".png")))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido');</script>");
        }

        if (System.IO.File.Exists(saveLocation))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
        }

        try
        {
            foto.PostedFile.SaveAs(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");

        }

        catch (Exception exc)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error: ');</script>");

        }
        return fu_foto;

    }

}