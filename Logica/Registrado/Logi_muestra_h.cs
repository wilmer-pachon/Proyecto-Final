using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Utilitarios;
using Encapsular;
using System.Data;

namespace Logica.Registrado
{
    public class Logi_muestra_h
    {

        public DataTable mostra_comentario_reistrado()
        {
            Mensajes men = new Mensajes();
            DataHerramienta data = new DataHerramienta();
            DataComenta com = new DataComenta();
            Enca_Comenta e_comen = new Enca_Comenta();

            DataTable listar_comentario = new DataTable();

            listar_comentario = com.insertarComentario(e_comen);

            men.Url = "muestra_h.aspx";

            return listar_comentario;

        }

        public DataTable muestra_respuesta_registrado()
        {

            Enca_Usuario user = new Enca_Usuario();
            DataUsuario dat = new DataUsuario();

            DataTable envia = dat.registrarUsuario(user);

            if (envia.Rows.Count == 3)
            {

                Mensajes men = new Mensajes();

                DataComenta com = new DataComenta();
                Enca_Comenta e_resp = new Enca_Comenta();

                DataTable listar_respuesta = new DataTable();

                listar_respuesta = com.insertarRespuesta(e_resp);

                men.Url = "muestra_h.aspx";

                return listar_respuesta;
            }
            return envia;
        }
        //  public DataTable grid_link(String recibe, String envia, String detalle1, String detalle 2)
        // {

        //  }
    }
}
