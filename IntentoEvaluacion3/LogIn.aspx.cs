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
    public partial class LogIn : System.Web.UI.Page
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dtr;
        SqlDataAdapter dat;
        DataSet dts;
        string cadena = "Data Source=DESKTOP-HE2UTAP\\SQLEXPRESS;Initial Catalog=MiPega;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cadena);
        }

        protected void btn_logIn_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_pass.Text;

            if(username.Equals("") || password.Equals(""))
            {
                lbl_msjLogIn.Text = "Ingrese sus datos, porfavor";
            }
            else
            {
                cnn.Open();
                cmd = new SqlCommand("SELECT * FROM Trabajador WHERE username = @vusuario AND clave = @vclave", cnn);
                cmd.Parameters.AddWithValue("@vusuario", txt_username.Text);
                cmd.Parameters.AddWithValue("@vclave", txt_pass.Text);

                SqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    string trabajadorId = lector["trabajadorId"].ToString();
                    string trabajadorUser = lector["username"].ToString();
                    string trabajadorPass = lector["clave"].ToString();
                    string trabajadorNombre = lector["nombre"].ToString();
                    string trabajadorRut = lector["rut"].ToString();
                    string trabajadorEmail = lector["email"].ToString();
                    string trabajadorTelefono = lector["telefono"].ToString();
                    string trabajadorProfesion = lector["profesion"].ToString();
                    string trabajadorCv = lector["cv"].ToString();
                    string tipoUsuario= lector["tipoUsuario"].ToString();
                    Trabajador usuarioSesion = new Trabajador(trabajadorId, trabajadorUser, trabajadorPass, trabajadorNombre, trabajadorRut, trabajadorEmail, trabajadorTelefono, trabajadorProfesion, trabajadorCv, tipoUsuario);
                    
                    Session["userSession"] = usuarioSesion;
                    Response.Redirect("/Perfil.aspx?user=" + trabajadorUser);
                }
                else {
                    lbl_msjLogIn.Text = "Las credenciales no son correctas";
                }




            }
        }
    }
}