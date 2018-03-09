using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vista_Roles_Admin_EditarHerramienta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        int index = e.RowIndex;
        FileUpload uploadControl = GridView1.Rows[index].FindControl("foto") as FileUpload;

        if (uploadControl.HasFile)
        {
            uploadControl.SaveAs(Server.MapPath("~/Vista/images/") + uploadControl.FileName);
            e.NewValues.Add("foto", ("~/Vista/images/") + uploadControl.FileName);
        }

    }
   
}