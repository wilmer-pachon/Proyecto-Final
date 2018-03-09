using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_buscar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bt_buscar_Click(object sender, EventArgs e)
    {
        try
        {
            EDHerramienta buscar = new EDHerramienta();
            DAOHerramienta herra = new DAOHerramienta();
            buscar.Busca = Txt_Buscar.Text;
            

            this.Gv_busqueda.DataSource = herra.buscar(buscar.Busca);
            if (herra.buscar(buscar.Busca).Rows.Count>0)
            {
                Gv_busqueda.DataBind();

            }
            else { 
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('NO HAY RESULTADOS');</script>");
            } 


        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}