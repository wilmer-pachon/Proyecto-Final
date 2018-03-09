﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Registrado_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {


            e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
            e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
            this.GridView1.RowStyle.BackColor = Color.Azure;
            e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView1, "Select$" + e.Row.RowIndex.ToString());

            e.Row.Style.Add("cursor", "hand");

        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
        switch (e.CommandName.ToString())
        {
            case "Select":

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridView1.Rows[index];

                String valor = ((Label)row.FindControl("Label1")).Text;


                if (valor != null)
                {
                    Session["id_herramienta"] = valor;

                    Response.Redirect("muestra_h.aspx");

                }
                break;
        }
    }
   



}