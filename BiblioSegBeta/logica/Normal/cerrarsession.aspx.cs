using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Normal_cerrarsession : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        EUsuario user = new EUsuario();
        //user.Id_rol = int.Parse(Session["id_rol"]);
        user.Id_rol = Session["user_id"].ToString();
        DAOUsuario datos = new DAOUsuario();
        datos.loginUsuarios_out(user);
        Session["id_user"] = null;
        Session["id_rol"] = null;
        Session["nom_user"] = null;
    

        Response.Redirect("/Vista/Roles/Normal/login.aspx");
    }
}