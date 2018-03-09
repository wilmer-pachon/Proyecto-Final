using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EDHerramienta
/// </summary>
public class EDHerramienta
{
    public EDHerramienta()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    private int id_herramienta;

    public int Id_herramienta
    {
        get { return id_herramienta; }
        set { id_herramienta = value; }
    }

    private String nombre;

    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
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

    private String busca;

    public String Busca
    {
        get { return busca; }
        set { busca = value; }
    }

    /*private String Cat;

    public String Cat1
    {
        get { return Cat; }
        set { Cat = value; }
    }

    private String len;

    public String Len
    {
        get { return len; }
        set { len = value; }
    }

    private String os;

    public String Os
    {
        get { return os; }
        set { os = value; }
    }*/
    private int cat;

    public int Cat
    {
        get { return cat; }
        set { cat = value; }
    }
    private int len;

    public int Len
    {
        get { return len; }
        set { len = value; }
    }
    private String os;

    public String Os
    {
        get { return os; }
        set { os = value; }
    }

    private String fu_foto;

    public String Fu_foto
    {
        get { return fu_foto; }
        set { fu_foto = value; }
    }

    private String estado;

    public String Estado
    {
        get { return estado; }
        set { estado = value; }
    }
    private int id_user;

    public int Id_user
    {
        get { return id_user; }
        set { id_user = value; }
    }
    private int puntos;
    public int Puntos
    {
        get { return puntos; }
        set { puntos = value; }
    }


    private int t_puntos;

    public int T_puntos
    {
        get { return t_puntos; }
        set { t_puntos = value; }
    }
}


    
