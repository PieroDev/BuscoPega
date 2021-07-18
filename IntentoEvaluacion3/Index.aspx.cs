using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using IntentoEvaluacion3.App_Code;

namespace IntentoEvaluacion3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dtr;
        SqlDataAdapter dat;
        DataSet dts;
        string cadena = "Data Source=DESKTOP-HE2UTAP\\SQLEXPRESS;" +
            "Initial Catalog=BuscoPega;" +
            "Persist Security Info=True;" +
            "User ID=piero;" +
            "Password=123456";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            //probando2.InnerHtml = "<p>Holiwi</p>";
            //for (int i = 0; i < 5; i++)
            //{
            //    probando2.InnerHtml = "<p>Hola" + i + "</p>";
            //}

            //string[] nombres = new string[] { "Claudio", "Maria", "Roberto", "Lucia", "Sergio" };
            //int J = 0;
            //foreach (string nombre in nombres){
            //    J++;
            //    probando2.InnerHtml = "<p>Hola" + nombre + "</p>";
            //    System.Web.UI.HtmlControls.HtmlGenericControl NewDiv = 
            //    new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            //    NewDiv.ID = "divCreado";
            //    NewDiv.InnerHtml = "Soy el div numero "+J;
            //    probando2.Controls.Add(NewDiv);
            //}

            //DBMaster dbm = new DBMaster();
           

            //try
            //{
            //    string id = txt_buscar.Text;
            //    SqlDataReader reader = dbm.GetReader("SELECT [empresaId], [nombre], [email], [descripcion] FROM [dbo].[empresa] WHERE [empresaId] >'"+id+"'");
                
            //    string temp3 = "";

            //    while (reader.Read()) {
            //        temp3 += "<div class='empresa-container' id='"+reader["empresaId"].ToString()+"'>";
            //        temp3 += "<h2 class='nombreEmpresa'>" + reader["nombre"].ToString() + "</h2>";
            //        temp3 += "<p>" + reader["email"].ToString() + "</p>";
            //        //temp3 += "</br>";
            //        temp3 += "<p>" + reader["descripcion"].ToString() + "</p>";
            //        temp3 += "<button type='button' class='btn-buscar btn-"+ reader["empresaId"].ToString() + "' asp-action='check'>Ver trabajos</button>";
            //        temp3 += "<a href='/empresa/"+ reader["empresaId"].ToString() + "'>";
            //        temp3 += "</div>";
                    
            //    }

            //    dbm.closeConnection();

            //    lbl_test3.Text = temp3;
            //    //SqlConnection cnn = new SqlConnection(cadena);
            //    //cnn.Open();
            //    //cmd = new SqlCommand();
            //    //cmd.Connection = cnn;

            //    //string id = txt_buscar.Text;
            //    //Session["queryBusqueda"] = id;
            //    //cmd.CommandText = "select * from Empresa where empresaId >'" + id +"'";
            //    //dtr = cmd.ExecuteReader();
            //    //if (dtr.Read())
            //    //{
            //    //    //Response.Write("si hay datos en este query");
            //    //    //probando.Text = "";
            //    //    //.InnerHtml =
            //    //    //for (int i = 0; i < 5; i++)
            //    //    //{
            //    //    //    probando2.InnerHtml = "<p>Hola" + i + "</p>";

            //    //    //}



            //    //}
            //    //else {
            //    //    Response.Write("No hay datos en este query");
            //    //}



            //}
            //catch(SqlException error) {
            //    Response.Write("El error fue:" + error.Message);
            //}
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }


    }
}