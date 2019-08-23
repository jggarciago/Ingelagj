using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ingelagj.Tests.Entidades
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void TestAdd()
        {
            ListaContext lista = new ListaContext();
            Docente docente = new Docente("Carlos","123");
            lista.AddDocente(docente);
            Assert.IsTrue(lista.Docentes.Contains(docente));
        }

        [TestMethod]
        public void TestUpdate()
        {
            ListaContext lista = new ListaContext();
            Docente docente1 = new Docente("Carlos", "123");
            lista.Docentes.Add(docente1);
            Docente docente2 = new Docente("Carlos Fernan", "123");
            lista.UpdateDocente(docente1, docente2);
            Assert.IsFalse(lista.Docentes.Contains(docente1));
            Assert.IsTrue(lista.Docentes.Contains(docente2));
        }

        [TestMethod]
        public void TestDelete()
        {
            ListaContext lista = new ListaContext();
            Docente docente = new Docente("Carlos", "123");
            lista.Docentes.Add(docente);
            lista.DeleteDocente(docente);
            Assert.IsFalse(lista.Docentes.Contains(docente));
        }

    }
}
