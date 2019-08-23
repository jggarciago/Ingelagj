using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class GestionUsuariosController : ApiController
    {
        Contexto contexto;
        
        public IEnumerable<Docente> Get(string documento)
        {
            return contexto.Docentes;
        }

        public void Post([contexto]string documento)
        {
            Docente docente = new Docente("Docente", documento);
            contexto.AddDocente(docente);
        }

        public void Put(Docente docente,[contexto] string documento)
        {   
            contexto.UpdateDocente(docente);
        }

        public void Delete(string documento)
        {
            contexto.DeleteDocente(docente);
        }
        //------------------------------------------------//
        public IEnumerable<FuncionarioDesarollo> Get(string documento)
        {
            return contexto.Funcionarios;
        }

        public void Post([contexto]string documento)
        {
            FuncionarioDesarrollo funcionario = new FuncionarioDesarrollo("Funcionario", documento);
            contexto.AddFuncionario(funcionario);
        }

        public void Put(FuncionarioDesarollo funcionario, [contexto] string documento)
        {
            contexto.UpdateFuncionario(funcionario);
        }

        public void Delete(string documento)
        {
            contexto.DeleteFuncionario(funcionario);
        }
        //---------------------------------------------------//
        public IEnumerable<ParEvaluador> Get(string documento)
        {
            return contexto.ParEvaluador;
        }

        public void Post([contexto]string documento)
        {
            ParEvaluador par = new ParEvaluador("Par", documento);
            contexto.AddParEvaluador(par);
        }

        public void Put(ParEvaluador par, [contexto] string documento)
        {
            contexto.UpdateParEvaluador(par);
        }

        public void Delete(string documento)
        {
            contexto.DeleteParEvaluador(par);
        }
        //---------------------------------------------------------//
        public IEnumerable<Proyecto> Get(string id)
        {
            return contexto.Proyectos;
        }

        public void Post([contexto]string id)
        {
            Proyecto proyecto = new Proyecto("Proyecto", id);
            contexto.AddProyecto(proyecto);
        }

        public void Put(Proyecto proyecto, [contexto] string id)
        {
            contexto.UpdateProyecto(proyecto);
        }

        public void Delete(string id)
        {
            contexto.DeleteProyecto(proyecto);
        }
        //-------------------------------------------//
        public IEnumerable<Usuario> Get(string documento)
        {
            return contexto.Usuarios;
        }

        public void Post([contexto]string documento)
        {
            Usuario usuario = new Usuario("Usuario", documento);
            contexto.AddUsuario(usuario);
        }

        public void Put(Usuario usuario, [contexto] string documento)
        {
            contexto.UpdateUsuario(usuario);
        }

        public void Delete(string documento)
        {
            contexto.DeleteUsuario(usuario);
        }

    }
}
