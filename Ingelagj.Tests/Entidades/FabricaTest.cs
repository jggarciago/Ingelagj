using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Ingelagj.Tests.Entidades
{
    [TestClass]
    public class FabricaTest
    {
        [TestMethod]
        public void TestMismaLista()
        {
            Contexto listaContext = FabricaContextos.fabricarContexto("lista");
            Assert.AreEqual(listaContext, FabricaContextos.fabricarContexto("lista"));
        }
    }
}
