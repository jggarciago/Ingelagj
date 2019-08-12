using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class FuncionarioDesarollo
    {
        string usuario;
        string contraseña;

        /*
         * Constructor clase FuncionarioDesarrollo 
         * @param usuario usuario con el que ingresa el funcionario al sistema
         * @contraseña es la contraseña de acceso al sistema por parte del usuario
         */

        public FuncionarioDesarollo(string usuario, string contraseña)
        {
            this.Usuario = usuario;
            this.Contraseña = contraseña;
        }

        /*
         * Metodos get y set
         */
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
