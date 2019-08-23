using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ingelagj.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingelagj.Controllers.Tests
{
    [TestClass()]
    public class AsigarPuntosControllerTests
    {
        [TestMethod()]
        public void verificarDocumentoIncorrectoTest()
        {
            AsigarPuntosController asigarPuntosController = new AsigarPuntosController();
            //Assert.IsFalse(asigarPuntosController.verificarDocumento());
            Assert.IsFalse(asigarPuntosController.verificarDocumento("1"));
        }
    }
}