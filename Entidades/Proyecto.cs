using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proyecto
    {
        string nombre;
        string estado;
        string modalidad;
        string fechaAprobacion;
        string fechaRadicacion;
        string codigo;
        string comite;
        string pdfProyecto;
        int puntaje; 

        /*
         * Constructor clase Proyecto
         * @param nombre es el nombre del proyecto
         * @param estado es el estado del proyecto (aprobado, recibido, en revisión)
         * @param modalidad es la modalidad en la que es presentado el proyecto
         * @param fechaAprobación para el proyecto de cada docente
         * @param fechaRadicacion momento calendario en el que se recibe y radica el proyecto
         * @param codigo codigo que será asignado a cada proyecto
         * @param comite es el comite para el proyecto
         * @param pdfProyecto es el archivo pdf en el que se presenta el proyecto
         */ 
         public Proyecto()
        {

        }
        public Proyecto(string nombre, string estado, string modalidad, string fechaAprobacion, string fechaRadicacion, string codigo, string comite, string pdfProyecto, int puntaje)
        {
            this.Nombre = nombre;
            this.Estado = estado;
            this.Modalidad = modalidad;
            this.FechaAprobacion = fechaAprobacion;
            this.FechaRadicacion = fechaRadicacion;
            this.Codigo = codigo;
            this.Comite = comite;
            this.PdfProyecto = pdfProyecto;
            this.Puntaje = puntaje;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Modalidad { get => modalidad; set => modalidad = value; }
        public string FechaAprobacion { get => fechaAprobacion; set => fechaAprobacion = value; }
        public string FechaRadicacion { get => fechaRadicacion; set => fechaRadicacion = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Comite { get => comite; set => comite = value; }
        public string PdfProyecto { get => pdfProyecto; set => pdfProyecto = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }

        /*
         * Metodos get y set para cada uno de los atributos 
         */

    }

    
}
