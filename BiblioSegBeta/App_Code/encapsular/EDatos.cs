using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EDatos
/// </summary>
public class EDatos
{
	public EDatos()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    


    private int id_user;

    public int Id_user
    {
        get { return id_user; }
        set { id_user = value; }
    }

   
    /*private String id_rol;

    public String Id_rol
    {
        get { return id_rol; }
        set { id_rol = value; }
    }*/

    private int id_rol;

    public int Id_rol
    {
        get { return id_rol; }
        set { id_rol = value; }
    }
    private String nombre;

    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    private String nom_user;

    public String Nom_user
    {
        get { return nom_user; }
        set { nom_user = value; }
    }
    private String correo;

    public String Correo
    {
        get { return correo; }
        set { correo = value; }
    }
    private String sitio_web;

    public String Sitio_web
    {
        get { return sitio_web; }
        set { sitio_web = value; }
    }
    private String clave;

    public String Clave
    {
        get { return clave; }
        set { clave = value; }
    }

    private String foto;

    public String Foto
    {
        get { return foto; }
        set { foto = value; }
    }

    private Int16 userId;

    public Int16 UserId
    {
        get { return userId; }
        set { userId = value; }
    }
    private String session;

    public String Session
    {
        get { return session; }
        set { session = value; }
    }
    private String ip;

    public String Ip
    {
        get { return ip; }
        set { ip = value; }
    }
    private String mac;

    public String Mac
    {
        get { return mac; }
        set { mac = value; }
    }

    private String nombre_cat;

    public String Nombre_cat
    {
        get { return nombre_cat; }
        set { nombre_cat = value; }
    }

    private String estado;

    public String Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    private int puntos;

    public int Puntos
    {
        get { return puntos; }
        set { puntos = value; }
    }

}