using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParEvaluador
    {
        string nombre;
        string correoElectronico;
        string cedula;
        string telefono;

        /*
         * Constructor clase ParEvaluador
         * @param nombre nombre del usuario que será el encargado de evaluar un proyecto docente
         * @param correoElectronico es el correo del ParEvaluador
         * @param cedula es el documento de identificacion del ParEvaluador
         * @param telefono es el numero telefonico de contacto para el ParEvaluador 
         */


        public ParEvaluador(string nombre, string correoElectronico, string cedula, string telefono)
        {
            this.Nombre = nombre;
            this.CorreoElectronico = correoElectronico;
            this.Cedula = cedula;
            this.Telefono = telefono;
        }

        /*
         * Metodos get y set para los atributos de la clase
         */

        public string Nombre { get => nombre; set => nombre = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
