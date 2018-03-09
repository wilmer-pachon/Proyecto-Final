using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_agregarUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

    
           if (DropDownRol.SelectedItem.ToString() == "admin"){
               usuario.Id_rol = 1;    
                }
          if (DropDownRol.SelectedItem.ToString() == "moderador"){
               usuario.Id_rol = 2;    
               }
           if (DropDownRol.SelectedItem.ToString() == "normal"){
               usuario.Id_rol = 3;    
               }
               
        DAORegistrar daoUsuario = new DAORegistrar();

        daoUsuario.registrar_usuario1(usuario);

        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Registro exitoso');window.location=\"agregarUsuario.aspx\"</script>");

        
            
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}