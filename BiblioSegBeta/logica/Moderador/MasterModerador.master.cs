using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Moderador_MasterModerador : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nom_user"] == null)
        {
            Response.Redirect("/Vista/Roles/Normal/Login.aspx");
        }
        if (Session["id_rol"].ToString() == "2")
        {

            string id_user = Session["user_id"].ToString();
            DAOUsuario puntos = new DAOUsuario();
            EUsuario user = new EUsuario();
            user.Id = short.Parse(Session["user_id"].ToString());

            DataTable datos = puntos.total_Puntos(user);
            int pu = int.Parse(Session["t_puntos"].ToString());
            int puntosTotales = pu;
            if (datos.Rows.Count > 0)
            {
                //Session["puntos_u"] = 0;
                datos.Rows[0]["sum"].ToString();
                Session["puntos_u"] = int.Parse(datos.Rows[0]["sum"].ToString());

                puntosTotales = int.Parse(datos.Rows[0]["sum"].ToString()) + pu;
                lb_puntos.Text = puntosTotales.ToString();

            }
            else
                lb_puntos.Text = puntosTotales.ToString();

            lblUser.Text = Session["nom_user"].ToString();  
            imgPerfil.ImageUrl = Session["foto"].ToString();
            if (imgPerfil.ImageUrl == "")
            {
                imgPerfil.ImageUrl = "/Vista/images/perfil/default.jpg";
            }

            if (puntosTotales < 10)
            {
                lb_karma.Text = "Troll";
            }
            if (puntosTotales >= 10)
            {
                lb_karma.Text = "Inexperto";
            }
            if (puntosTotales >= 20)
            {
                lb_karma.Text = "Iniciado";
            }
            if (puntosTotales >= 30)
            {
                lb_karma.Text = "Aprendiz";
            }
            if (puntosTotales >= 40)
            {
                lb_karma.Text = "Amateur";
            }
            if (puntosTotales >= 50)
            {
                lb_karma.Text = "Regular";
            }
            if (puntosTotales >= 60)
            {
                lb_karma.Text = "Junior";
            }
            if (puntosTotales >= 70)
            {
                lb_karma.Text = "Experto";
            }
            if (puntosTotales >= 80)
            {
                lb_karma.Text = "Avanzado";
            }
            if (puntosTotales >= 90)
            {
                lb_karma.Text = "Elite";
            }
            if (puntosTotales >= 100)
            {
                lb_karma.Text = "Root";
            }

        }
        else
            Response.Redirect("/Vista/Roles/Normal/Login.aspx");

    }
}
