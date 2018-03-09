using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_MasterAdmin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["nom_user"] == null)
        {
            Response.Redirect("/Vista/Roles/Normal/Login.aspx");
        }
        if (Session["id_rol"].ToString() == "1")
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
        /*if (Session["nom_user"] == null)
             {
                 Response.Redirect("/Vista/Roles/Normal/Login.aspx");
             }
             if (Session["id_rol"].ToString() == "1")
             {

                 lblUser.Text = Session["nom_user"].ToString();

                 DAOUsuario user_poins = new DAOUsuario();
                 /*DAOUsuario user_poins = new DAOUsuario();
                 int id_user = int.Parse(Session["user_id"].ToString());
                 DataTable puntostra = user_poins.total_Puntos(id_user);
                 int puntost = 0;
                 int puntos = int.Parse(Session["t_puntos"].ToString());
                 puntost = puntost + puntos;
                 if (puntostra.Rows.Count > 0)
                 {
                     int sum = int.Parse(puntostra.Rows[0]["sum"].ToString());                
                     puntost = puntos + sum;
                     lb_puntos.Text = puntost.ToString();

                 }
                 //int puntost = 10;
                 lb_puntos.Text = puntost.ToString();   
            
                 imgPerfil.ImageUrl = Session["foto"].ToString();
                 if (imgPerfil.ImageUrl == "")
                 {
                     imgPerfil.ImageUrl = "/Vista/images/perfil/default.jpg";
                 }

                 if (puntost < 10)
                 {
                     lb_karma.Text = "Troll";
                 }
                 if (puntost >= 10)
                 {
                     lb_karma.Text = "Inexperto";
                 }
                 if (puntost >= 20)
                 {
                     lb_karma.Text = "Iniciado";
                 }
                 if (puntost >= 30)
                 {
                     lb_karma.Text = "Aprendiz";
                 }
                 if (puntost >= 40)
                 {
                     lb_karma.Text = "Amateur";
                 }
                 if (puntost >= 50)
                 {
                     lb_karma.Text = "Regular";
                 }
                 if (puntost >= 60)
                 {
                     lb_karma.Text = "Junior";
                 }
                 if (puntost >= 70)
                 {
                     lb_karma.Text = "Experto";
                 }
                 if (puntost >= 80)
                 {
                     lb_karma.Text = "Avanzado";
                 }
                 if (puntost >= 90)
                 {
                     lb_karma.Text = "Elite";
                 }
                 if (puntost >= 100)
                 {
                     lb_karma.Text = "Root";
                 }

             }
             else
                 Response.Redirect("/Vista/Roles/Normal/Login.aspx");*/

    }

    
   
}
       
