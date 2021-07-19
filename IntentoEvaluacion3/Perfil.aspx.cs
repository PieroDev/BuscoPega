using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntentoEvaluacion3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["logIn"]) != null)
            {
                if ((Session["tipoSesion"]).ToString() == "empresa")
                {
                    Response.Redirect("PerfilEmpresa.aspx");

                }
                else
                {
                    Trabajador usuario = (Trabajador)Session["userSession"];

                    lbl_perfilNombre.Text = usuario.NombreTrabajador;
                    lbl_perfilProfesion.Text = usuario.Profesion;
                    lbl_perfilRut.Text = usuario.Rut;
                    lbl_perfilEmail.Text = usuario.Email;
                    lbl_perfilTelefono.Text = usuario.Telefono;
                    lbl_trabajadorId.Text = usuario.TrabajadorId;
                }
                
            }
            else
            {
                //
                perfil_container_handler.Style.Add("display", "none");
                lbl_mensajeNoSesion.Text = "No tienes una sesion abierta, por favor has Log in o registrate";
            }


            
            



            
        }
    }
}