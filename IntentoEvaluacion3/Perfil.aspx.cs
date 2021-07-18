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
            Trabajador usuario = (Trabajador)Session["userSession"];

            lbl_perfilNombre.Text = usuario.NombreTrabajador;
            lbl_perfilProfesion.Text = usuario.Profesion;
            lbl_perfilRut.Text = usuario.Rut;
            lbl_perfilEmail.Text = usuario.Email;
            lbl_perfilTelefono.Text = usuario.Telefono;
        }
    }
}