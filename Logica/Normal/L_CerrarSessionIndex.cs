using Datos;
using Encapsular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Normal
{
    public class L_CerrarSessionIndex
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Enca_Usuario user = new Enca_Usuario();
            //user.Id_rol = int.Parse(Session["id_rol"]);
            user.Id_rol = Session["user_id"].ToString();
            DataUsuario datos = new DataUsuario();
            datos.loginUsuarios_out(user);
            Session["id_user"] = null;
            Session["id_rol"] = null;
            Session["nom_user"] = null;


            Response.Redirect("/Vista/Roles/Normal/login.aspx");
        }
    }
}
