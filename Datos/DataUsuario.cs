using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Configuration;
using Encapsular;
using Npgsql;
using NpgsqlTypes;

namespace Datos
{
    public class DataUsuario
    {
        public DataTable registrarUsuario(Enca_Usuario user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("f_registrar_usuarios", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = user.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Varchar).Value = user.Apellido;
                dataAdapter.SelectCommand.Parameters.Add("_coreo", NpgsqlDbType.Integer).Value = user.Correo;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = user.User_name;


                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar).Value = user.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = 2;


                conectar.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
            return Usuario;
        }


        public DataTable loginUsuarios(Enca_Usuario usuario)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("biblioseg.f_login", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand.Parameters.Add("_nom_user", NpgsqlDbType.Varchar).Value = usuario.User_name;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar).Value = usuario.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_ip", NpgsqlDbType.Varchar).Value = usuario.Ip;
                dataAdapter.SelectCommand.Parameters.Add("_mac", NpgsqlDbType.Varchar).Value = usuario.Mac;
                dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Varchar).Value = usuario.Foto;


                conection.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario;
        }

        public DataTable obtenerRol(String nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("biblioseg.f_obtener_rol", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                conectar.Open();
                dataAdapter.Fill(Usuario);

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
            return Usuario;

        }


        public DataTable correoUsuario(Enca_Usuario user)
        {
            DataTable Usuario_Login = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["bdPrueba"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("f_correo_usuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = user.User_name;

                conection.Open();
                dataAdapter.Fill(Usuario_Login);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
            return Usuario_Login;
        }

        public void loginUsuarios_out(Enca_Usuario user)
        {

            DataTable loginUser = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);

            try
            {

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_modifica_session", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_user", NpgsqlDbType.Varchar).Value = user.Id_rol;

                conection.Open();
                dataAdapter.Fill(loginUser);

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }

        public DataTable aprobarPuntos(Enca_Herramienta user)//herramientas pendientess
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_aprobar_puntos", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_herramienta", NpgsqlDbType.Integer).Value = user.Id_herramienta;
                dataAdapter.SelectCommand.Parameters.Add("_id_user", NpgsqlDbType.Integer).Value = user.Id_user;

                conectar.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
            return Usuario;
        }





        public DataTable total_Puntos(Enca_Usuario user)//herramientas pendientess
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_total_puntos", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_user", NpgsqlDbType.Integer).Value = user.Id;

                conectar.Open();
                dataAdapter.Fill(Usuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
            return Usuario;
        }  
    }
}
