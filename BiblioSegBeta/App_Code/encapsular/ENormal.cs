﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ENormal
/// </summary>
public class ENormal
{
	public ENormal()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    private Int16 id;

    public Int16 Id
    {
        get { return id; }
        set { id = value; }
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

}