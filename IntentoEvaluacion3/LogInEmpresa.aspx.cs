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
    public partial class LogInEmpresa : System.Web.UI.Page
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
            if (username.Equals("") || password.Equals(""))
            {
                lbl_msjLogIn.Text = "Ingrese sus datos, porfavor";
            }
            else
            {
                try
                {
                    cnn.Open();
                    cmd = new SqlCommand("SELECT * FROM Empresa WHERE username = @vusuario AND clave = @vclave", cnn);
                    cmd.Parameters.AddWithValue("@vusuario", txt_username.Text);
                    cmd.Parameters.AddWithValue("@vclave", txt_pass.Text);

                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.Read())
                    {
                        int empresaId = Convert.ToInt32((lector["empresaId"])) ;
                        string empresaUser = lector["username"].ToString();
                        string empresaPass = lector["clave"].ToString();
                        string empresaNombre = lector["nombre"].ToString();
                        string empresaRut = lector["rut"].ToString();
                        string empresaEmail = lector["email"].ToString();
                        string empresaTelefono = lector["telefono"].ToString();
                        string empresaDescripcion = lector["descripcion"].ToString();
                        string tipoUsuario = lector["tipoUsuario"].ToString();
                        Empresa usuarioSesion = new Empresa(empresaId, empresaUser, empresaPass, empresaNombre, empresaRut, empresaEmail, empresaTelefono, empresaDescripcion, tipoUsuario);

                        Session["userSession"] = usuarioSesion;
                        Session["logIn"] = true;
                        Session["tipoSesion"] = "empresa";
                        cnn.Close();



                        Response.Redirect("/PerfilEmpresa.aspx?user=" + empresaId);

                    }

                    else
                    {
                        lbl_msjLogIn.Text = "Las credenciales no son correctas";
                    }
                }
                catch
                {
                    Response.Write(e);
                }
            }



        }
    }
}