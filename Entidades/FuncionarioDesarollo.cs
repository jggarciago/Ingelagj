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

        public FuncionarioDesarollo(string usuario, string contraseña)
        {
            this.Usuario = usuario;
            this.Contraseña = contraseña;
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
