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
using Datos;

namespace Datos
{
    public class DataRegistrar
    {
        public DataTable registrar_usuario(Enca_Datos user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(" biblioseg.f_registrar_usuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = 3;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = user.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Varchar).Value = user.Correo;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar).Value = user.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_sitio_web", NpgsqlDbType.Varchar).Value = user.Sitio_web;
                dataAdapter.SelectCommand.Parameters.Add("_nom_user", NpgsqlDbType.Varchar).Value = user.Nom_user;
                dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Text).Value = user.Foto;
                dataAdapter.SelectCommand.Parameters.Add("_puntos", NpgsqlDbType.Integer).Value = 10;

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

        public DataTable registrar_usuario1(Enca_Datos user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(" biblioseg.f_registrar_usuario", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = user.Id_rol;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = user.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Varchar).Value = user.Correo;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar).Value = user.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_sitio_web", NpgsqlDbType.Varchar).Value = user.Sitio_web;
                dataAdapter.SelectCommand.Parameters.Add("_nom_user", NpgsqlDbType.Varchar).Value = user.Nom_user;
                dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Text).Value = user.Foto;
                dataAdapter.SelectCommand.Parameters.Add("_puntos", NpgsqlDbType.Integer).Value = 10;

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



        public DataTable enviar_usuario(Enca_Datos user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("biblioseg.f_muestra_usuarios", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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


        public DataTable inicia_perfil(int id_user)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("biblioseg.f_muestra_usuario", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_id_user", NpgsqlDbType.Integer).Value = id_user;

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


        public DataTable editar_usuario(int id_user, String nombre, string correo, String sitio_web, String nom_user, string foto)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("biblioseg.f_modificar_usuarios", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_user", NpgsqlDbType.Integer).Value = id_user;
                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = nombre;
                dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Varchar).Value = correo;
                dataAdapter.SelectCommand.Parameters.Add("_sitio_web", NpgsqlDbType.Varchar).Value = sitio_web;
                dataAdapter.SelectCommand.Parameters.Add("_nom_user", NpgsqlDbType.Varchar).Value = nom_user;
                dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Text).Value = foto;
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

        public DataTable eliminaUsuario(int id_user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("biblioseg.elimina_usuario", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_user", NpgsqlDbType.Integer).Value = id_user;

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
