using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntentoEvaluacion3
{
    public partial class PerfilEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["logIn"]) != null)
            {
                Empresa usuario = (Empresa)Session["userSession"];

                lbl_perfilNombre.Text = usuario.NombreEmpresa;
                lbl_perfilDescripcion.Text = usuario.Descripcion;
                lbl_perfilRut.Text = usuario.Rut;
                lbl_perfilEmail.Text = usuario.Email;
                lbl_perfilTelefono.Text = usuario.Telefono;
                lbl_trabajadorId.Text = usuario.EmpresaId.ToString();

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