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
    public class DataAdmin
    {
        public DataTable insertarHerramienta(String info)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("f_insertar_herramientas", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_herramienta", NpgsqlTypes.NpgsqlDbType.Text).Value = info;
                conection.Open();
                dataAdapter.Fill(Usuario); //abra el pgadmin no si
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

        public DataTable registrar_categoria(Enca_Datos categoria)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_registrar_categoria", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_nombre_cat", NpgsqlDbType.Varchar).Value = categoria.Nombre_cat;

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

        public DataTable mostrar_categorias()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.muestra_categoria", conection);
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

        public DataTable editar_usuario(int id_user, String nombre, string correo, String sitio_web, String nom_user, string foto)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(" biblioseg.f_modificar_usuarios", conection);
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

        public DataTable bloqueado(Enca_Datos user)//llamar usuarios bloqueados
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("biblioseg.f_bloqueados", conectar);
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


        public DataTable bloqueadoss(Enca_Datos user)//usuarios bloqueadoss
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("biblioseg.f_bloqueadoss", conectar);
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

        public DataTable editar_categoria(string nombre, int id_cat)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.edita_categoria", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = nombre;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id_cat;

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



        public DataTable eliminar_categoria(int id_cat)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.elimina_categoria", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id_cat;

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


        public DataTable muestra_linux(int id_cat)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_linux", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id_cat;

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

        public DataTable muestra_Windows(int id_cat)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_Windows", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id_cat;

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



        public DataTable aprobar(int id_comenta)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.apro", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_id_herramienta", NpgsqlDbType.Integer).Value = id_comenta;

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


        public DataTable desa(int id_comenta)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.des", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_id_herramienta", NpgsqlDbType.Integer).Value = id_comenta;

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
