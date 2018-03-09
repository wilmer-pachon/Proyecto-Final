using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EDcomenta
/// </summary>
public class EDcomenta
{
	public EDcomenta()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    private String textarea;

    public String Textarea
    {
        get { return textarea; }
        set { textarea = value; }
    }

    private String respuesta;

    public String Respuesta
    {
        get { return respuesta; }
        set { respuesta = value; }
    }

    private int user;

    public int User
    {
        get { return user; }
        set { user = value; }
    }

    private int herramienta;

    public int Herramienta
    {
        get { return herramienta; }
        set { herramienta = value; }
    }

    private int valor;

    public int Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    private int user_resp;

    public int User_resp
    {
        get { return user_resp; }
        set { user_resp = value; }
    } 

}