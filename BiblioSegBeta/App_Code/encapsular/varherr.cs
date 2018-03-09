using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de varherr
/// </summary>
public class varherr
{
	public varherr()
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
    private String sweb;

    public String Sweb
    {
        get { return sweb; }
        set { sweb = value; }
    }
    private String descripcion;

    public String Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }
    private Int32 categoria;

    public Int32 Categoria
    {
        get { return categoria; }
        set { categoria = value; }
    }
    private Int32 lenguaje;

    public Int32 Lenguaje
    {
        get { return lenguaje; }
        set { lenguaje = value; }
    }
}