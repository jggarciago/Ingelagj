using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class RecuperarContraseñaController : ApiController
    {
        Contexto contexto;
        public RecuperarContraseñaController()
        {
            contexto = FabricarContextos.fabricarContexto("lista");
        }
        /**
         * Envía el correo al Usuario que solicitó la recuperación de contraseña.
         * @Param string CorreoElectronico, verifica y envía el correo electrónico al usuario que solicitó la recuperación
         */
        public void enviarCorreo(string CorreoElectronico)
        {
            if (VerificarCorreoElectronico(CorreoElectronico))
            {
                Console.WriteLine("Estoy enviando el Correo Electrónico simulación a: " + CorreoElectronico);
            }
           
        }
        /**
         * verifica que el correo electrónico exista entre los usuarios encontrados hasta el momento en la base de 
         * datos.
         * @Param string CorreoElectronico, representa el correo electrónico a buscar
         */
        public void VerificarCorreoElectronico(string CorreoElectronico)
        {
            List<Usuarios> User = this.contexto.getUsuarios();


            foreach (Usuarios u in User)
            {
                if (u.getCorreoElectronico().equals(CorreoElectronico))
                {
                    return true;
                }

            }

            return false;
        }

        

    }
}
