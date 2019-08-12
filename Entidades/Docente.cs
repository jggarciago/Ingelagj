using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Docente
    {
        string nombre;
        string documento;

        public Docente(string nombre, string documento)
        {
            this.Nombre = nombre;
            this.Documento = documento;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Documento { get => documento; set => documento = value; }
    }
}
