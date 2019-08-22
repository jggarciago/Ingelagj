using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente
    {
        string nombre;
        string documento;

        /*
         * Constructor clase Docente 
         *@param nombre nombre del docente
         *@param documento numero del documento de identificacion del docente
         */
        public Docente(string nombre, string documento)
        {
            this.Nombre = nombre;
            this.Documento = documento;
        }

        /*
         * Metodos get y set de los atributos de clase
         */
        public string Nombre { get => nombre; set => nombre = value; }
        public string Documento { get => documento; set => documento = value; }
    }
}
