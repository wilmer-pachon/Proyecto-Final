using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_ReportesGraficas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CRS_Graficas.ReportDocument.SetDataSource(listarUsuarios());
        CRV_Graficas.ReportSource = CRS_Graficas;
       
    }

    protected Graficas listarUsuarios()
    {
        Graficas usuarios = new Graficas();
        DAOReportesGraficas datos = new DAOReportesGraficas();

        DataTable datosUsuario = datos.obtenerUsuarios();
        DataTable datosFinal = usuarios.Registrados;
        DataRow fila;


        for (int i = 0; i < datosUsuario.Rows.Count; i++)
        {
            fila = datosFinal.NewRow();

            fila["id_user"] = int.Parse(datosUsuario.Rows[i]["id_user"].ToString());
            fila["nombre"] = datosUsuario.Rows[i]["nombre"].ToString();
            fila["correo"] = datosUsuario.Rows[i]["correo"].ToString();
            fila["nom_user"] = datosUsuario.Rows[i]["nom_user"].ToString();
            fila["sitio_web"] = datosUsuario.Rows[i]["sitio_web"].ToString();


            datosFinal.Rows.Add(fila);
        }

        return usuarios;
    }

  

}