using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        string nombre;
        string contraseña;
        string tipo;
        string correoElectronico;

        /*
         * Constructor de la clase Usuario
         * @param nombre nombre del usuario 
         * @param contraseña del usuario
         * @param tipo se refiere al tipo de usuario que está ingresando al sistema (Par Evaluador, Funcionario)
         * @param correoElectronico es el correo electronico del usuario
         */

        public Usuario ()
        {
        }


        public Usuario(string nombre, string contraseña, string tipo, string correoElectronico)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Tipo = tipo;
            this.CorreoElectronico = correoElectronico;
        }

        /*
         * Metodos get y set
         */

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
    }
}
