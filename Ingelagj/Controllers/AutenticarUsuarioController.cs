using System;
using Entidades;
namespace Ingelagj.Controllers
{
    public class AutenticarUsuarioController : ApiController
    {
        Contexto contexto;
        public AutenticarUsuarioController()
        {
            contexto = FabricarContextos.fabricarContexto("lista");
        }
        public Boolean VerificarDatos(string CorreoElectronico, string Contraseña)
        {
            DbSet<Usuario> Usuarios = new DbSet<Usuario>();

            return true;
        }
    }
}

