﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
            return Usuario;
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

        public string enviarNotificacion (Usuario usuario, string documento)
        {
            string notificacion = " ";

            return notificacion;
        }

    }
}