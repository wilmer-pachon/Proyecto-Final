using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Normal_muestra_herramienta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.QueryString["Name"] != null)
            {
                String no_user = Request.QueryString["user_id"];
            }

            if (Request.QueryString["usuario"] != null)
            {
                String rol = Request.QueryString["id_rol"];
            }

        }
    }

    protected void comentar_Click(object sender, EventArgs e)
    {
           //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Debe Registrarse Para Comentar')</script>");
            comentar.Attributes["onclick"] = "alert('Debe Registrarse Para Comentar'); return false;";
            Response.Redirect("login.aspx");
            //Response.Redirect("/Vista/Roles/Normal/registro.aspx");
    }
    protected void puntospositivos_Click1(object sender, ImageClickEventArgs e)
    {

            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Debe registrarse para dar puntos');</script>");
 


    }
    protected void puntosnegativos_Click(object sender, ImageClickEventArgs e)
    {
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Debe registrarse para dar puntos');</script>");
        
    }
}