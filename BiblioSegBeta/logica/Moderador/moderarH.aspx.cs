using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Moderador_moderarH : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "aprobar")
           {
              
               string rowindex = e.CommandArgument.ToString();
               int index = int.Parse(rowindex);

               if (index != null)
               {

                   EDHerramienta objetos = new EDHerramienta();
                   DAOHerramienta datos = new DAOHerramienta();


                   DataTable table = datos.aprobada(index);
                   Boolean resultado = Boolean.Parse(table.Rows[0][0].ToString());
                   Response.Redirect("/Vista/Roles/Admin/moderar.aspx");

               }
           
            }

           else{
               if (e.CommandName == "desaprobar")
               {
                   string rowindex = e.CommandArgument.ToString();
                   int index = int.Parse(rowindex);

                   if (index != null)
                   {

                       EDHerramienta objetos = new EDHerramienta();
                       DAOHerramienta datos = new DAOHerramienta();


                       DataTable table = datos.desaprobar(index);
                       Boolean resultado = Boolean.Parse(table.Rows[0][0].ToString());
                       Response.Redirect("/Vista/Roles/Admin/moderar.aspx");

                   }


               }
           }
            

   }


}