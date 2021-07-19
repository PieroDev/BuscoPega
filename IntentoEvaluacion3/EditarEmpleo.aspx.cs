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
    public partial class EditarEmpleo : System.Web.UI.Page
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dtr;
        SqlDataAdapter dat;
        DataSet dts;

        string cadena = "Data Source=DESKTOP-HE2UTAP\\SQLEXPRESS;Initial Catalog=MiPega;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            //cnn = new SqlConnection(cadena);

            //string id = Request.QueryString["empleoId"];
            //lbl_empleoId.Text = id;

            //try
            //{
            //    cnn.Open();
            //    cmd = new SqlCommand("Select * FROM Empleo WHERE empleoId = @vempleoId", cnn);
            //    cmd.Parameters.AddWithValue("@vempleoId", id);

            //    SqlDataReader lector = cmd.ExecuteReader();

            //    if (lector.Read())
            //    {
            //        lbl_msjErrorForm.Text = "sim se logro";
                    
            //        txt_nombreEmpleo.Text = lector["nombre"].ToString();
            //        dd_cargo.Text = lector["cargo"].ToString();
            //        dd_contrato.Text = lector["contrato"].ToString();
            //        txt_descripcionEmpleo.Text = lector["descripcion"].ToString();
            //        string sueldo = lector["sueldo"].ToString();
            //        txt_sueldoEmpleo.Text = sueldo;
            //    }
            //    cnn.Close();
            //}
            //catch
            //{

            //}

        }

        protected void btn_publicarEmpleo_Click(object sender, EventArgs e)
        {
            Empresa usuario = (Empresa)Session["userSession"];

            cnn = new SqlConnection(cadena);

            string titulo = txt_nombreEmpleo.Text;
            string cargo = dd_cargo.Text;
            string contrato = dd_contrato.Text;
            string sueldo = txt_sueldoEmpleo.Text;
            string descripcion = txt_descripcionEmpleo.Text;
            int empresaId = usuario.EmpresaId;
            string id = Request.QueryString["empleoId"];
            lbl_empleoId.Text = id ;

            int intId = Convert.ToInt32(id);

            string error = "Uno o más datos estan vacios";

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
                            cmd = new SqlCommand("UPDATE Empleo SET nombre = @vnombre, cargo = @vcargo, contrato = @vcontrato, sueldo = @vsueldo, descripcion = @vdescripcion WHERE empleoId = "+intId+"", cnn);
                            cmd.Parameters.AddWithValue("@vnombre", titulo);
                            cmd.Parameters.AddWithValue("@vcargo", cargo);
                            cmd.Parameters.AddWithValue("@vcontrato", contrato);
                            cmd.Parameters.AddWithValue("@vsueldo", sueldo);
                            cmd.Parameters.AddWithValue("@vdescripcion", descripcion);
                            cmd.Parameters.AddWithValue("@vempleoId", intId);
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha actualizado tu empleo!')", true);
                        }
                        catch
                        {


                        }
                    }
                }
            }
        }
    }
}