using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Vista_Roles_Registrado_EditarPerfil : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        /*int index = int.Parse(Session["user_id"].ToString());
        DAORegistrar user = new DAORegistrar();
        user.inicia_perfil(index);
        */
        

      
            //EDHerramienta buscar = new EDHerramienta();
            //DAOHerramienta herra = new DAOHerramienta();
            //buscar.Busca = Txt_Buscar.Text;
        DAORegistrar user = new DAORegistrar();
       

             int index = int.Parse(Session["user_id"].ToString());
            lb_id.Text = index.ToString();
            gb_perfil.DataSourceID = null;
            gb_perfil.DataSource = user.inicia_perfil(index);
            gb_perfil.DataBind();
            


           //this.gb_perfil.DataSource =  user.inicia_perfil(index);
             

             //   gb_perfil.DataBind();
        
        //EDatos datos = new EDatos();
        //DAORegistrar res = new DAORegistrar();


      //DataTable tab = res.inicia_perfil(index);

       // Response.Redirect("EditarPerfil.aspx");
    }



   
    protected void gb_perfil_RowEditing(object sender, GridViewEditEventArgs e)
    {

        gb_perfil.EditIndex = e.NewEditIndex;
        DataBind();
    }
    protected void gb_perfil_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        //int rowindex = e.RowIndex;

        //GridViewRow row = gb_perfil.Rows[rowindex];
        //int id_user = Convert.ToInt32((row.FindControl("BoundField") as DataBoundControl).ToString);



        /*DataTable dt = (DataTable)Session["user_id"];
        GridViewRow row = gb_perfil.Rows[e.RowIndex];
        dt.Rows[row.DataItemIndex]["id_user"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
        dt.Rows[row.DataItemIndex]["nom_user"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
        dt.Rows[row.DataItemIndex]["clave"] = ((TextBox)(row.Cells[1].Controls[0])).Text;

        gb_perfil.EditIndex = -1;

        DataBind();*/
    }


    protected void gb_perfil_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gb_perfil.EditIndex = -1;
        DataBind();
    }
}