using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entidades;

namespace Ingelagj.Controllers
{
    public class EnviarNotificacionController : ApiController
    {
        public Boolean verificarDocumento (string documento)
        {
            return true;
        }

        public Usuario generarUsuario (string documento)
        {
            Usuario usuario = new Usuario();

            return usuario;
        }

        public string generarContraseña (Usuario usuario, string documento)
        {
            string contraseña = " ";
            return contraseña;
        }

        public string generarCorreo(Usuario usuario, string documento)
        {
            string correo = " ";
            return correo;
        }

        public string enviarNotificacion (String CorreoElectronico)
        {
            Console.WriteLine("Estoy enviando Notificación simulación a: " + CorreoElectronico);
        }

    }
}