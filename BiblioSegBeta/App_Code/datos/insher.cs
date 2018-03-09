using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de insher
/// </summary>
public class insher
{
	public insher()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    public DataTable insertarHerramienta(varherr user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("f_insertar_herramienta", conectar);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            dataAdapter.SelectCommand.Parameters.Add("nombre", NpgsqlDbType.Varchar).Value = user.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("autor", NpgsqlDbType.Varchar).Value = user.Autor;
            dataAdapter.SelectCommand.Parameters.Add("sitioweb", NpgsqlDbType.Varchar).Value = user.Sweb;
            dataAdapter.SelectCommand.Parameters.Add("descripcion", NpgsqlDbType.Varchar).Value = user.Descripcion;
            dataAdapter.SelectCommand.Parameters.Add("categoria", NpgsqlDbType.Integer).Value = user.Categoria;
            dataAdapter.SelectCommand.Parameters.Add("lenguaje", NpgsqlDbType.Integer).Value = user.Lenguaje;

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


    public DataTable muestraHerramienta(varherr user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conectar = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("f_muestra_herr", conectar);
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

}