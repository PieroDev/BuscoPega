using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntentoEvaluacion3
{
    public class Empresa
    {
        private int empresaId;
        private string username;
        private string password;
        private string nombreEmpresa;
        private string rut;
        private string email;
        private string telefono;
        private string descripcion;
        private string tipoUsuario;

        public int EmpresaId { get => empresaId; set => empresaId = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public Empresa(int empresaId, string username, string password, string nombreEmpresa, string rut, string email, string telefono, string descripcion, string tipoUsuario)
        {
            this.EmpresaId = empresaId;
            this.Username = username;
            this.Password = password;
            this.NombreEmpresa = nombreEmpresa;
            this.Rut = rut;
            this.Email = email;
            this.Telefono = telefono;
            this.Descripcion = descripcion;
            this.TipoUsuario = tipoUsuario;
        }

        public Empresa()
        {
        }


    }
}