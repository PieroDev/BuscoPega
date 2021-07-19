using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntentoEvaluacion3
{
    public partial class EliminarEmpleo : System.Web.UI.Page
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dtr;
        SqlDataAdapter dat;
        DataSet dts;

        string cadena = "Data Source=DESKTOP-HE2UTAP\\SQLEXPRESS;Initial Catalog=MiPega;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["empleoId"];
            int intId = Convert.ToInt32(id);

            cnn = new SqlConnection(cadena);

            cnn.Open();
            cmd = new SqlCommand("DELETE Empleo WHERE empleoId = " + intId + "", cnn);
            cmd.ExecuteNonQuery();
            Response.Redirect("PerfilEmpresa.aspx");
            cnn.Close();
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("PerfilEmpresa.aspx");
        }
    }
}