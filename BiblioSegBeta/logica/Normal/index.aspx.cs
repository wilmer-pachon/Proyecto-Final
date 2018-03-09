using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Normal_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (Session["rol"] == null)
            Response.Redirect("login.aspx");
        else
        {
            if (int.Parse(Session["rol"].ToString()) != 1)

                Response.Redirect("login.aspx");
        }*/
    }

   
    protected void bt_buscar_Click(object sender, EventArgs e)
    {
        try
        {
            EDHerramienta buscar = new EDHerramienta();
            DAOHerramienta herra = new DAOHerramienta();
            buscar.Busca = Txt_Buscar.Text;

            this.Gv_busqueda.DataSource = herra.buscar(buscar.Busca);
            Gv_busqueda.DataBind();

          
        }
        catch (Exception ex)
        {
            throw ex; 
        }
        
 
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("registro.aspx");
    }


    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {


            e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
            e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
            this.GridView1.RowStyle.BackColor = Color.Azure;
            e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView1, "Select$" + e.Row.RowIndex.ToString());

            e.Row.Style.Add("cursor", "hand");

        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {


        switch (e.CommandName.ToString())
        {
            case "Select":

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridView1.Rows[index];

                String valor = ((Label)row.FindControl("Label2")).Text;


                if (valor != null)
                {
                    Session["id_herramienta"] = valor;
                    Response.Redirect("muestra_herramienta.aspx");
                }
                break;
        }
    }
}