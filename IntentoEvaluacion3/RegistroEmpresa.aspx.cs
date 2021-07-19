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
    public partial class RegistroEmpresa : System.Web.UI.Page
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

        protected void btn_registrarme_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cadena);
            string username = txt_usernameEmpresa.Text;
            string clave = txt_claveEmpresa.Text;
            string nombre = txt_nombreEmpresa.Text;
            string rut = txt_rutEmpresa.Text;
            string email = txt_emailEmpresa.Text;
            string telefono = txt_telefonoEmpresa.Text;
            string descripcion = txt_descripcionEmpresa.Text;
            string error = "Uno o más datos estan vacios";


            if (username.Equals("") || clave.Equals(""))
            {
                lbl_msjErrorForm.Text = "" + error;
            }
            else
            {
                if (nombre.Equals("") || rut.Equals(""))
                {
                    lbl_msjErrorForm.Text = "" + error;
                }
                else
                {
                    if (email.Equals("") || telefono.Equals(""))
                    {
                        lbl_msjErrorForm.Text = "" + error;
                    }
                    else
                    {
                        if (descripcion.Equals(""))
                        {
                            lbl_msjErrorForm.Text = "" + error;
                        }
                        else
                        {
                            try
                            {
                                lbl_msjErrorForm.Text = "Holi";
                                cnn.Open();

                                cmd = new SqlCommand("SELECT * FROM Empresa WHERE username = @vusername OR rut = @vrut", cnn);
                                cmd.Parameters.AddWithValue("@vusername", username);
                                cmd.Parameters.AddWithValue("@vrut", rut);
                                SqlDataReader lector = cmd.ExecuteReader();

                                if (lector.Read())
                                {
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ya existe un usuario con este username o rut')", true);

                                }
                                else
                                {
                                    cnn.Close();
                                    cnn.Open();

                                    cmd = new SqlCommand("INSERT INTO Empresa(username, clave, nombre, rut, email, telefono, descripcion, tipoUsuario)" +
                                        "VALUES(@vusername, @vclave, @vnombre, @vrut, @vemail, @vtelefono, @vdescripcion, 'empresa')", cnn);
                                    cmd.Parameters.AddWithValue("@vusername", username);
                                    cmd.Parameters.AddWithValue("@vclave", clave);
                                    cmd.Parameters.AddWithValue("@vnombre", nombre);
                                    cmd.Parameters.AddWithValue("@vrut", rut);
                                    cmd.Parameters.AddWithValue("@vemail", email);
                                    cmd.Parameters.AddWithValue("@vtelefono", telefono);
                                    cmd.Parameters.AddWithValue("@vdescripcion", descripcion);
                                    cmd.ExecuteNonQuery();
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Te has creado una cuenta, has Log in para comenzar a usar la plataforma!')", true);
                                    cnn.Close();
                                    Response.Redirect("Index.aspx");
                                }
                            }
                            catch
                            {
                                Console.WriteLine(e);
                            }

                        }
                    }
                }
            }
        }
    }
}