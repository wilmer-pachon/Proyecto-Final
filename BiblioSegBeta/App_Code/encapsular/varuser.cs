using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de varuser
/// </summary>
public class varuser
{
	public varuser()
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
    private String correo;

    public String Correo
    {
        get { return correo; }
        set { correo = value; }
    }
    private String clave;

    public String Clave
    {
        get { return clave; }
        set { clave = value; }
    }
    private String sweb;

    public String Sweb
    {
        get { return sweb; }
        set { sweb = value; }
    }
  
    private String foto;
 
    private String url;

    public String Url
    {
        get { return url; }
        set { url = value; }
    }
  
}