using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    public class Enca_Comenta
    {
        private String textarea;

        public String Textarea
        {
            get { return textarea; }
            set { textarea = value; }
        }

        private String respuesta;

        public String Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }

        private int user;

        public int User
        {
            get { return user; }
            set { user = value; }
        }

        private int herramienta;

        public int Herramienta
        {
            get { return herramienta; }
            set { herramienta = value; }
        }

        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private int user_resp;

        public int User_resp
        {
            get { return user_resp; }
            set { user_resp = value; }
        } 
    }
}
