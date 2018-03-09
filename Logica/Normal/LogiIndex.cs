using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Encapsular;
using Utilitarios;

namespace Logica.Normal
{
   public class LogiIndex
    {
       
        public DataTable mostra_herramienta_index()
            {
                Mensajes men = new Mensajes();
                DataHerramienta data = new DataHerramienta();
                Enca_Herramienta muestraHerramienta = new Enca_Herramienta();
                
                DataTable listarherramienta = new DataTable();
                
                listarherramienta = data.muestraHerramienta(muestraHerramienta);

                men.Url = "muestra_herramienta.aspx";
                
                return listarherramienta;
                
            }
    
        public DataTable editar_Herramienta_index(String nombre, String url_sitio, DateTime fecha, String descripcion, int id_cat, int id_lenguaje, String id_so, String foto, int id_herramienta) 
            {
                Mensajes men = new Mensajes();
                DataHerramienta data = new DataHerramienta();
                Enca_Herramienta editarHerramienta = new Enca_Herramienta();

                DataTable listarherramienta = new DataTable();
                
                listarherramienta = data.editarHerramienta(nombre, url_sitio, fecha, descripcion, id_cat, id_lenguaje, id_so, foto, id_herramienta);

                men.Url = "muestra_herramienta.aspx";
                
                return listarherramienta;
                
            }
          public DataTable eliminar_herramienta_index(int id_herramienta)
                {
                    Mensajes men = new Mensajes();
                    DataHerramienta data = new DataHerramienta();
                    Enca_Herramienta eliminarHerramienta = new Enca_Herramienta();
                    
                    DataTable listarherramienta = new DataTable();
                
                    listarherramienta = data.eliminaHerramienta(id_herramienta);

                    men.Url = "muestra_herramienta.aspx";

                    return listarherramienta;
                    
                }
          public void Button1_Click(object sender, EventArgs e)
          {
              Mensajes men = new Mensajes();
              men.Url="registro.aspx";
          }
      
    }
}
