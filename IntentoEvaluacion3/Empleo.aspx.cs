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
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dtr;
        SqlDataAdapter dat;
        DataSet dts;
        string cadena = "Data Source=DESKTOP-HE2UTAP\\SQLEXPRESS;Initial Catalog=MiPega;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["empleoId"];
            lbl_empleoId.Text = id;
        }

        protected void btn_postular_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cadena);



            if ((Session["logIn"]) != null)
            {
                if((Session["tipoSesion"]).ToString() == "trabajador")
                {
                    Trabajador usuario = (Trabajador)Session["userSession"];
                    string empleoIdString = lbl_empleoId.Text;
                    int empleoId = Convert.ToInt32(empleoIdString);
                    int usuarioId = Convert.ToInt32(usuario.TrabajadorId);

                    try
                    {
                        cnn.Open();
                        cmd = new SqlCommand("SELECT * FROM Postulacion WHERE empleoId = @vempleoId AND trabajadorId = @vtrabajadorId", cnn);
                        cmd.Parameters.AddWithValue("@vempleoId", empleoId);
                        cmd.Parameters.AddWithValue("@vtrabajadorId", usuarioId);
                        SqlDataReader lector = cmd.ExecuteReader();

                        if (lector.Read())
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ya postulaste a esta pega!')", true);
                        }
                        else
                        {
                            cnn.Close();
                            cnn.Open();

                            cmd = new SqlCommand(
                                "INSERT INTO Postulacion (empleoId, trabajadorId, fechaPostulacion)" +
                                "VALUES(@vempleoId, @vtrabajadorId, GETDATE())", cnn);
                            cmd.Parameters.AddWithValue("@vempleoId", empleoId);
                            cmd.Parameters.AddWithValue("@vtrabajadorId", usuarioId);

                            cmd.ExecuteNonQuery();
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Acabas de postular a la pega!')", true);
                        }
                    }
                    catch
                    {
                        Response.Redirect("/Error.aspx");
                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No puedes postular como empresa!')", true);
                }
                
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Uy, inicia sesion o crea una nueva cuenta')", true);
                
            }
        }
    }
}