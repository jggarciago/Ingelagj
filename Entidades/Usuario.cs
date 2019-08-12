using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Usuario
    {
        string nombre;
        string contraseña;
        string tipo;
        string correoElectronico;

        public Usuario(string nombre, string contraseña, string tipo, string correoElectronico)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Tipo = tipo;
            this.CorreoElectronico = correoElectronico;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
    }
}
