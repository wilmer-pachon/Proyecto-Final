using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EAdmin
/// </summary>
public class EAdmin
{
	public EAdmin()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    private String nombre;
    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    private String autor;

    public String Autor
    {
        get { return autor; }
        set { autor = value; }
    }
    
    private String sitio;

    public String Sitio
    {
        get { return sitio; }
        set { sitio = value; }
    }
    private DateTime fecha;

    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }
    private String descripcion;

    public String Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }
    private String categoria;

    public String Categoria
    {
        get { return categoria; }
        set { categoria = value; }
    }
    private String lenguaje;

    public String Lenguaje
    {
        get { return lenguaje; }
        set { lenguaje = value; }
    }
    private String os;

    public String Os
    {
        get { return os; }
        set { os = value; }
    }

    private String foto;

    public String Foto
    {
        get { return foto; }
        set { foto = value; }
    }
}