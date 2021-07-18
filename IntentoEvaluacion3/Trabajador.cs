using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntentoEvaluacion3
{
    public class Trabajador
    {
        private string trabajadorId;
        private string username;
        private string password;
        private string nombreTrabajador;
        private string rut;
        private string email;
        private string telefono;
        private string profesion;
        private string cv;
        private string tipoUsuario;

        public Trabajador(string trabajadorId, string username, string password, string nombreTrabajador, string rut, string email, string telefono, string profesion, string cv, string tipoUsuario)
        {
            this.trabajadorId = trabajadorId;
            this.username = username;
            this.password = password;
            this.nombreTrabajador = nombreTrabajador;
            this.rut = rut;
            this.email = email;
            this.telefono = telefono;
            this.profesion = profesion;
            this.cv = cv;
            this.tipoUsuario = tipoUsuario;
        }

        public Trabajador()
        {
        }

        public string TrabajadorId { get => trabajadorId; set => trabajadorId = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string NombreTrabajador { get => nombreTrabajador; set => nombreTrabajador = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public string Cv { get => cv; set => cv = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
    }
}