using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_editarUsuario : System.Web.UI.Page
{



    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "activo")
        {
            string rowindex = e.CommandArgument.ToString();
            int index = int.Parse(rowindex);

            if (index != null)
            {
                EDatos objetos = new EDatos();
                DAORegistrado datos = new DAORegistrado();

                DataTable table = datos.activos(index);
                Boolean resultado = Boolean.Parse(table.Rows[0][0].ToString());
                Response.Redirect("/Vista/Roles/Admin/editarUsuario.aspx");
            }
        }
            else
            {
                if (e.CommandName == "bloqueado")
                {
                    string rowindex = e.CommandArgument.ToString();
                    int index = int.Parse(rowindex);

                    if (index != null)
                    {
                        EDatos objetos = new EDatos();
                        DAORegistrado datos = new DAORegistrado();

                        DataTable table = datos.bloqueados(index);
                        Boolean resultado = Boolean.Parse(table.Rows[0][0].ToString());
                        Response.Redirect("/Vista/Roles/Admin/editarUsuario.aspx");
                    }
                }
            }

        }

}