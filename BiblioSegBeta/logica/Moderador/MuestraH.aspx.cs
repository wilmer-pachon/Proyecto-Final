using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Moderador_MuestraH : System.Web.UI.Page
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
            Response.Cache.SetNoStore();
        }



        DAOcomenta men = new DAOcomenta();
        EDcomenta usuario = new EDcomenta();

        int index = int.Parse(Session["id_herramienta"].ToString());
        DataTable table = men.extrae_comentario(index);
        Int64 he = Int64.Parse(this.Session["id_herramienta"].ToString());

        DAOHerramienta puntos = new DAOHerramienta();
        lb_puntos.Text = he.ToString();
    }

    protected void comentar_Click(object sender, EventArgs e)
    {
        if (int.Parse(Session["id_rol"].ToString()) == 2)
        {

            EDcomenta com = new EDcomenta();
            DAOcomenta men = new DAOcomenta();

            int val = int.Parse(Session["id_herramienta"].ToString());

            com.Textarea = tarea.InnerText;
            com.User = int.Parse(Session["user_id"].ToString());
            com.Herramienta = val;


            men.insertarComentario(com);
            Response.Redirect("MuestraH.aspx");

        }
    }



    protected void respuesta_Click(object sender, EventArgs e)
    {

        EDcomenta com = new EDcomenta();
        DAOcomenta men = new DAOcomenta();



        com.User_resp = int.Parse(Session["user_id"].ToString());


        int val = 0;
        do
        {
            foreach (GridViewRow row in gridcomentarios.Rows)
            {
                TextBox txtresp = ((TextBox)gridcomentarios.Rows[row.RowIndex].FindControl("resp"));
                Label idcomen = ((Label)gridcomentarios.Rows[row.RowIndex].FindControl("Label1"));

                idcomen.Text = idcomen.Text;
                Session["idcomen"] = idcomen;

                string valor = txtresp.Text;
                com.Valor = int.Parse(idcomen.Text);
                com.Respuesta = valor;


                if (valor != "")
                {
                    val = 1;
                    men.insertarRespuesta(com);
                    Response.Redirect("MuestraH.aspx");
                }



            }

        } while (val < 0);

    }

    protected void puntospositivos_Click1(object sender, ImageClickEventArgs e)
    {
        int index_he = int.Parse(Session["id_herramienta"].ToString());
        int index_user = int.Parse(Session["user_id"].ToString());

        EDHerramienta her = new EDHerramienta();
        DAOHerramienta puntos = new DAOHerramienta();
        DAOUsuario punt = new DAOUsuario();



        her.Id_herramienta = index_he;
        her.Id_user = index_user;
        her.Puntos = 2;


        punt.aprobarPuntos(her);
        if (punt.aprobarPuntos(her).Rows.Count > 0)
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ya dio puntos');</script>");
        }
        else
        {
            puntos.agregarPuntos(her);
            Response.Redirect("MuestraH.aspx");

        }


    }
    protected void puntosnegativos_Click(object sender, ImageClickEventArgs e)
    {
        int index_he = int.Parse(Session["id_herramienta"].ToString());
        int index_user = int.Parse(Session["user_id"].ToString());

        EDHerramienta her = new EDHerramienta();
        DAOHerramienta puntos = new DAOHerramienta();
        DAOUsuario punt = new DAOUsuario();

        her.Id_herramienta = index_he;
        her.Id_user = index_user;
        her.Puntos = -2;

        punt.aprobarPuntos(her);
        if (punt.aprobarPuntos(her).Rows.Count > 0)
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ya dio puntos');</script>");
        }
        else
        {
            puntos.agregarPuntos(her);
            Response.Redirect("MuestraH.aspx");
        }
    }


}