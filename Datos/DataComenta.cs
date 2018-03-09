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
    public class DataComenta
    {
        public DataTable insertarComentario(Enca_Comenta user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                Enca_Datos user1 = new Enca_Datos();
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.insertar_comentario", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand.Parameters.Add("_comenta", NpgsqlDbType.Varchar, 50).Value = user.Textarea;
                dataAdapter.SelectCommand.Parameters.Add("_iduser", NpgsqlDbType.Integer, 50).Value = user.User;
                dataAdapter.SelectCommand.Parameters.Add("_idh", NpgsqlDbType.Integer, 50).Value = user.Herramienta;
                dataAdapter.SelectCommand.Parameters.Add("_idd", NpgsqlDbType.Integer, 50).Value = 3;
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


        public DataTable muestra_herramienta_registrado()
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
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.muestra_post", conectar);
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


        public DataTable extrae_comentario(int id_herramienta)
        {

            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.muestra_comentarioos", conectar);
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


        public DataTable muestra_respuestas(Enca_Comenta user)//comentarios realizados
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.mostro_respuestas", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                //dataAdapter.SelectCommand.Parameters.Add("_id_resp", NpgsqlDbType.Integer).Value = id_comenta;


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


        public DataTable muestra_usuarios(Enca_Datos user)//comentarios realizados
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




        public DataTable insertarRespuesta(Enca_Comenta user)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                Enca_Datos user1 = new Enca_Datos();
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.insertar_respuesta", conectar);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand.Parameters.Add("_comen", NpgsqlDbType.Varchar, 50).Value = user.Respuesta;
                dataAdapter.SelectCommand.Parameters.Add("_iduser", NpgsqlDbType.Integer, 50).Value = user.User_resp;
                dataAdapter.SelectCommand.Parameters.Add("_idc", NpgsqlDbType.Integer, 50).Value = user.Valor;

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
