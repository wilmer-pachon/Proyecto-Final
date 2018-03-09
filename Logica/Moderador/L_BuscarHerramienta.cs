using Datos;
using Encapsular;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Moderador
{
    public class L_BuscarHerramienta
    {
        public Enca_Herramienta busca(String buscar)
        {
            DataHerramienta data = new DataHerramienta();
            DataTable datos = new DataTable();
            Enca_Herramienta herr = new Enca_Herramienta();

            datos = data.buscar(buscar);

            return herr;
        }
    }
}
