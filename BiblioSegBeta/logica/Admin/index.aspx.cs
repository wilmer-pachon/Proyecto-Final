using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {


            e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
            e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

            e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView2, "Select$" + e.Row.RowIndex.ToString());

            e.Row.Style.Add("cursor", "hand");
            
        }
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName.ToString())
        {
            case "Select":

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridView2.Rows[index];

                String valor = ((Label)row.FindControl("Label1")).Text;


                if (valor != null)
                {
                    Session["id_herramienta"] = valor;
                    Response.Redirect("muestra_herramienta.aspx");
                }
                break;
        }
    }
    /*protected void bt_buscar_Click(object sender, EventArgs e)
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
        
 
    }*/


}