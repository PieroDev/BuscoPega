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
    public partial class RegistroUsuario : System.Web.UI.Page
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

            string username = txt_usernameTrabajador.Text;
            string clave = txt_claveTrabajador.Text;
            string nombre = txt_nombreTrabajador.Text;
            string rut = txt_rutTrabajador.Text;
            string email = txt_emailTrabajador.Text;
            string telefono = txt_telefonoTrabajador.Text;
            string profesion = txt_profesionTrabajador.Text;
            string cv = txt_curriculumTrabajador.Text;
            string error = "Uno o más datos estan vacios";

            if (username.Equals("") || clave.Equals(""))
            {
                lbl_msjErrorForm.Text = "" + error;
            }
            else { 
                if(nombre.Equals("") || rut.Equals(""))
                {
                    lbl_msjErrorForm.Text = "" + error;
                }
                else
                {
                    if (email.Equals("") || telefono.Equals(""))
                    {
                        lbl_msjErrorForm.Text = "" + error;
                    }
                    else {
                        if (profesion.Equals("") || cv.Equals(""))
                        {
                            lbl_msjErrorForm.Text = ""+error;
                        }
                        else
                        {
                            try
                            {
                                lbl_msjErrorForm.Text = "Holi";
                                cnn.Open();

                                cmd = new SqlCommand("SELECT * FROM Trabajador WHERE username = @vusername OR rut = @vrut", cnn);
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

                                    cmd = new SqlCommand("INSERT INTO Trabajador(username, clave, nombre, rut, email, telefono, profesion, cv, tipoUsuario)" +
                                        "VALUES(@vusername, @vclave, @vnombre, @vrut, @vemail, @vtelefono, @vprofesion, @vcv, 'trabajador')", cnn);
                                    cmd.Parameters.AddWithValue("@vusername", username);
                                    cmd.Parameters.AddWithValue("@vclave", clave);
                                    cmd.Parameters.AddWithValue("@vnombre", nombre);
                                    cmd.Parameters.AddWithValue("@vrut", rut);
                                    cmd.Parameters.AddWithValue("@vemail", email);
                                    cmd.Parameters.AddWithValue("@vtelefono", telefono);
                                    cmd.Parameters.AddWithValue("@vprofesion", profesion);
                                    cmd.Parameters.AddWithValue("@vcv", cv);
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