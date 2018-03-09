using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOcomenta
/// </summary>
public class DAOcomenta
{
	public DAOcomenta()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    public DataTable insertarComentario(EDcomenta user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            EDatos user1 = new EDatos();
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


    public DataTable muestra_respuestas(EDcomenta user)//comentarios realizados
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


    public DataTable muestra_usuarios(EDatos user)//comentarios realizados
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




    public DataTable insertarRespuesta(EDcomenta user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            EDatos user1 = new EDatos();
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