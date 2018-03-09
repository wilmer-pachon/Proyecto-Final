using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_ReporteCategorias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CRS_Categorias.ReportDocument.SetDataSource(listarCategorias());
        CRV_Categorias.ReportSource = CRS_Categorias;
    }

    protected Categorias listarCategorias()
    {
        Categorias categorias = new Categorias();
        DAOReportesCategorias datos = new DAOReportesCategorias();

        DataTable datosCategorias = datos.obtenerCategorias();
        DataTable datosFinal = categorias.Categoria;
        DataRow fila;


        for (int i = 0; i < datosCategorias.Rows.Count; i++)
        {
            fila = datosFinal.NewRow();

            fila["id_cat"] = int.Parse(datosCategorias.Rows[i]["id_cat"].ToString());
            fila["nombre"] = datosCategorias.Rows[i]["nombre"].ToString();



            datosFinal.Rows.Add(fila);
        }

        return categorias;
    }

}