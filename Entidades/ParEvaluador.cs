using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ParEvaluador
    {
        string nombre;
        string correoElectronico;
        string cedula;
        string telefono;

        public ParEvaluador(string nombre, string correoElectronico, string cedula, string telefono)
        {
            this.Nombre = nombre;
            this.CorreoElectronico = correoElectronico;
            this.Cedula = cedula;
            this.Telefono = telefono;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
