using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using Datos;
using System.Data;
using System.Configuration;
using Encapsular;


namespace Datos
{
   public class DataHerramienta
    {
        public DataTable insertarHerramienta(Enca_Herramienta user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                Enca_Usuario user1 = new Enca_Usuario();
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_insertar_herramienta", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar, 50).Value = user.Nombre;
                dataAdapter.SelectCommand.Parameters.Add("_sitio", NpgsqlDbType.Varchar).Value = user.Sitio;
                dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = user.Fecha;
                dataAdapter.SelectCommand.Parameters.Add("_descripcion", NpgsqlDbType.Varchar).Value = user.Descripcion;
                dataAdapter.SelectCommand.Parameters.Add("_cat", NpgsqlDbType.Integer).Value = user.Cat;
                dataAdapter.SelectCommand.Parameters.Add("_len", NpgsqlDbType.Integer).Value = user.Len;
                dataAdapter.SelectCommand.Parameters.Add("_os", NpgsqlDbType.Varchar).Value = user.Os;
                dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Text).Value = user.Fu_foto;
                dataAdapter.SelectCommand.Parameters.Add("_id_estado", NpgsqlDbType.Integer).Value = 2;
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


        public DataTable muestraHerramienta(Enca_Herramienta user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.muestra_herramienta_usuario", conectar);
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


        public DataTable muestraCategoria()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.muestra_categoria", conectar);
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


        public DataTable muestraLenguaje()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.muestra_lenguaje", conectar);
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

        public DataTable editarHerramienta(String nombre, String url_sitio, DateTime fecha, String descripcion, int id_cat, int id_lenguaje, String id_so, String foto, int id_herramienta)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.edita_herramienta", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = nombre;
                dataAdapter.SelectCommand.Parameters.Add("_sitio", NpgsqlDbType.Varchar).Value = url_sitio;
                dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = fecha;
                dataAdapter.SelectCommand.Parameters.Add("_descripcion", NpgsqlDbType.Varchar).Value = descripcion;
                dataAdapter.SelectCommand.Parameters.Add("_cat", NpgsqlDbType.Integer).Value = id_cat;
                dataAdapter.SelectCommand.Parameters.Add("_leng", NpgsqlDbType.Integer).Value = id_lenguaje;
                dataAdapter.SelectCommand.Parameters.Add("_os", NpgsqlDbType.Varchar).Value = id_so;
                dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Text).Value = foto;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id_herramienta;


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

        public DataTable aprobada(int id_herramienta)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.selecciona_herramienta", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_id_herramienta", NpgsqlDbType.Integer).Value = id_herramienta;

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

        public DataTable eliminaHerramienta(int id_herramienta)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.elimina_herramienta", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id_herramienta;

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

        public DataTable obtenerHerramienta(String Nombre)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_obtener_herramienta", conectar);
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

        public DataTable aprobadas(Enca_Herramienta user)//llamar herramientas aprobadas
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_aprobadas", conectar);
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

        public DataTable pendientes(Enca_Herramienta user)//herramientas pendientess
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_pendientes", conectar);
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
        public DataTable desaprobar(int id_herramienta)//herramientas pendientess
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_desaprobadas", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id_herramienta;

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


        public DataTable muestra_herramientas_normal()
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.muestra_herramienta", conectar);
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


        public DataTable muestra_herramienta_normal(int id_herramienta)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.muestra_herramienta_normal", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("_id_herramienta", NpgsqlDbType.Integer).Value = id_herramienta;

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

        public DataTable buscar(string busca)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.buscar", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dataAdapter.SelectCommand.Parameters.Add("busca", NpgsqlDbType.Varchar).Value = busca;

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


        public DataTable agregarPuntos(Enca_Herramienta user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                Enca_Usuario user1 = new Enca_Usuario();
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_agregar_puntos", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_user", NpgsqlDbType.Integer).Value = user.Id_user;
                dataAdapter.SelectCommand.Parameters.Add("_id_herramienta", NpgsqlDbType.Integer).Value = user.Id_herramienta;
                dataAdapter.SelectCommand.Parameters.Add("_puntos", NpgsqlDbType.Integer).Value = user.Puntos;

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

        public DataTable traerPuntos(Int64 id_h)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                Enca_Usuario user1 = new Enca_Usuario();
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.f_t_puntos", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_herramienta", NpgsqlDbType.Numeric).Value = id_h;
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
