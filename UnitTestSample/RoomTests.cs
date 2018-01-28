using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSample.Domain;

namespace UnitTestSample
{
    [TestClass]
    public class DadaUmaNovaSala
    {
        [TestMethod]
        [TestCategory("Nova Sala")]
        public void O_nome_deve_ser_sala_1()
        {
            var room = new Room("Sala 1");
            Assert.AreEqual("Sala 1", room.Name);
        }

        [TestMethod]
        [TestCategory("Nova Sala")]
        [ExpectedException(typeof(Exception))]
        public void O_nome_deve_ser_fornecido()
        {
            var room = new Room(null);
        }
    }
}
