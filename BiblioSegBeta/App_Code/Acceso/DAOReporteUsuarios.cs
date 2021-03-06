﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOReporteUsuarios
/// </summary>
public class DAOReporteUsuarios
{
	public DAOReporteUsuarios()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    //public DataTable obtenerUsuarios()
    //{
       // DataTable departamentos = new DataTable();
        //NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);

        //try
        //{
            //NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("biblioseg.f_obtener_usuarios", conection);
            //dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            //conection.Open();
            //dataAdapter.Fill(departamentos);
        //}
        //catch (Exception Ex)
        //{
           // throw Ex;
        //}
        //finally
        //{
            //if (conection != null)
            //{
                //conection.Close();
            //}
        //}
        //return departamentos;
    //}

    public DataTable obtenerHerramientas()
    {
        DataTable departamentos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("herramienta.obtener_Herramientas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(departamentos);
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
        return departamentos;
    }
}