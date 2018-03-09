using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_ReporteUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CRS_Herramienta.ReportDocument.SetDataSource(listarHerramientas());
        CRV_Herramienta.ReportSource = CRS_Herramienta;

    }

  

    protected Usuarios listarHerramientas()
    {
        Usuarios usuarios = new Usuarios();
        DAOReporteUsuarios datos = new DAOReporteUsuarios();

        DataTable datosHerramientas = datos.obtenerHerramientas();
        DataTable datosFinal = usuarios.Herramientas;
        DataRow fila;


        for (int i = 0; i < datosHerramientas.Rows.Count; i++)
        {
            fila = datosFinal.NewRow();

            fila["id_herramienta"] = int.Parse(datosHerramientas.Rows[i]["id_herramienta"].ToString());
            fila["nombre"] = datosHerramientas.Rows[i]["nombre"].ToString();
            fila["url_sitio"] = datosHerramientas.Rows[i]["url_sitio"].ToString();
            fila["id_herramienta"] = int.Parse(datosHerramientas.Rows[i]["id_herramienta"].ToString());
            fila["fecha"] = datosHerramientas.Rows[i]["fecha"].ToString();
            fila["descripcion"] = datosHerramientas.Rows[i]["descripcion"].ToString();
       
           
            datosFinal.Rows.Add(fila);
        }

        return usuarios;
    }

 
}