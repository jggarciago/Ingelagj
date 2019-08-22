using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ListaContext : Contexto
    {
        public List<Docente> Docentes { get; set; }
        public List<FuncionarioDesarollo> Funcionarios { get; set; }
        public List<ParEvaluador> Pares { get; set; }
        public List<Proyecto> Proyectos { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
