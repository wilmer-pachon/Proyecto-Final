using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_agregarCategoria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void guardar_Click(object sender, EventArgs e)
    {
        EDatos categoria = new EDatos();

        categoria.Nombre_cat = txtnombre_cat.Text.ToString();
        

        DAOAdmin daoCategoria = new DAOAdmin();

        daoCategoria.registrar_categoria(categoria);
        //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('CATEGORIA AGREGADA');</script>");
        Response.Redirect("cat_agregada.aspx");

    }
}