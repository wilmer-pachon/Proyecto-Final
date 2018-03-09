using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    public class Enca_Usuario
    {
        private Int16 id;

        public Int16 Id
        {
            get { return id; }
            set { id = value; }
        }

        private String id_rol;

        public String Id_rol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }



        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private String correo;

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private String user_name;

        public String User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        private String clave;

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private String ip;

        public String Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        private String mac;

        public String Mac
        {
            get { return mac; }
            set { mac = value; }
        }
        private String foto;

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }
}
