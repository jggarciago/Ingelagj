using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface Contexto
    {
        

        /**
         * Modificaciones
         */
        bool UpdateDocente(Docente oldDocente, Docente newDocente);
        bool UpdateFuncionario(FuncionarioDesarollo oldFuncionarioDesarollo, FuncionarioDesarollo newFuncionarioDesarollo);
        bool UpdateParEvaluador(ParEvaluador oldParEvaluador, ParEvaluador newParEvaluador);
        bool UpdateProyecto(Proyecto oldProyecto, Proyecto newProyecto);
        bool UpdateUsuario(Usuario oldUsuario, Usuario newUsuario);

        /**
         * Adiciones
         */
        void AddDocente(Docente newDocente);
        void AddFuncionario(FuncionarioDesarollo newFuncionario);
        void AddParEvaluador(ParEvaluador newParEvaluador);
        void AddProyecto(Proyecto newProyecto);
        void AddUsuario(Usuario newUsuario);
        /**
         * Eliminaciones
         */
        bool DeleteDocente(Docente oldDocente);
        bool DeleteFuncionario(FuncionarioDesarollo oldFuncionarioDesarollo);
        bool DeleteParEvaluador(ParEvaluador oldParEvaluador);
        bool DeleteProyecto(Proyecto oldProyecto);
        bool DeleteUsuario(Usuario oldUsuario);


    }
}
