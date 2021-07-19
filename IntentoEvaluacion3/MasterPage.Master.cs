using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace IntentoEvaluacion3
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["logIn"]) != null)
            {
                link_registrar.Style.Add("display", "none");
                link_logIn.Style.Add("display", "none");
                cerrarSesionDiv.Style.Remove("display");
            }
            else
            {
                cerrarSesionDiv.Style.Add("display", "none");
            }

            if((Session["tipoSesion"]) != null)
            {
                if ((Session["tipoSesion"].ToString()) == "empresa")
                {
                    agregarEmpleoDiv.Style.Add("display", "block");
                }
                else
                {
                    agregarEmpleoDiv.Style.Remove("display");
                    agregarEmpleoDiv.Style.Add("display", "none");
                }
            }
            else
            {
                agregarEmpleoDiv.Style.Add("display", "none");
            }
            
            

        }

        protected void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            if ((Session["logIn"]) != null)
            {
                Session["logIn"] = null;
                Session["tipoSesion"] = null;
                Response.Redirect("~/Index.aspx");
                agregarEmpleoDiv.Style.Remove("display");
                agregarEmpleoDiv.Style.Add("display", "none");
            }
        }

        protected void btn_agregarEmpleo_Click(object sender, EventArgs e)
        {
            Response.Redirect("PublicarEmpleo.aspx");
        }
    }
}