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
    public partial class PublicarEmpleo : System.Web.UI.Page
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

        protected void btn_publicarEmpleo_Click(object sender, EventArgs e)
        {
            if((Session["logIn"]) != null)
            {
                if ((Session["tipoSesion"].ToString()) == "empresa")
                {
                    Empresa usuario = (Empresa)Session["userSession"];

                    cnn = new SqlConnection(cadena);

                    string titulo = txt_nombreEmpleo.Text;
                    string cargo = dd_cargo.Text;
                    string contrato = dd_contrato.Text;
                    string sueldo = txt_sueldoEmpleo.Text;
                    string descripcion = txt_descripcionEmpleo.Text;
                    int empresaId = usuario.EmpresaId;

                    string error = "Uno o más datos estan vacios";
                    lbl_msjErrorForm.Text = cargo;

                    if (titulo.Equals("") || cargo.Equals(""))
                    {
                        lbl_msjErrorForm.Text = "" + error;
                    }
                    else
                    {
                        if (contrato.Equals("") || sueldo.Equals(""))
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
                                    cnn.Open();
                                    cmd = new SqlCommand("INSERT INTO Empleo (nombre, cargo, contrato, sueldo, descripcion, empresaId)" +
                                        "VALUES(@vnombre, @vcargo, @vcontrato, @vsueldo, @vdescripcion, @vempresaId)", cnn);
                                    cmd.Parameters.AddWithValue("@vnombre", titulo);
                                    cmd.Parameters.AddWithValue("@vcargo", cargo);
                                    cmd.Parameters.AddWithValue("@vcontrato", contrato);
                                    cmd.Parameters.AddWithValue("@vsueldo", sueldo);
                                    cmd.Parameters.AddWithValue("@vdescripcion", descripcion);
                                    cmd.Parameters.AddWithValue("@vempresaId", empresaId);
                                    cmd.ExecuteNonQuery();
                                    cnn.Close();
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha publicado tu empleo!')", true);
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
}