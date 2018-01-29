using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSample.Domain;
using UnitTestSample.Domain.FakeRepository;

namespace UnitTestSample
{
    [TestClass]
    public class DadaUmaNovaSala
    {
        private const string TestCategory = "Nova Sala";

        [TestMethod]
        [TestCategory(TestCategory)]
        public void O_nome_deve_ser_sala_1()
        {
            var room = new Room("Sala 1");
            Assert.AreEqual("Sala 1", room.Name);
        }

        [TestMethod]
        [TestCategory(TestCategory)]
        [ExpectedException(typeof(Exception))]
        public void O_nome_deve_ser_fornecido()
        {
            var room = new Room(null);
        }
        
    }

    [TestClass]
    public class DadaUmaNovaReserva
    {

        [TestMethod]
        [TestCategory("Reserva de Sala")]
        [ExpectedException(typeof(Exception))]
        public void A_sala_deve_estar_disponivel()
        {
            var startDAte = DateTime.Now.AddHours(1);
            var endDate = DateTime.Now.AddHours(3);
            var rep = new BookFakeRepository();
            var room = new Room("Sala 1");
            room.Book(startDAte, endDate, rep.GetByDate(startDAte, endDate));
        }


        [TestMethod]
        [TestCategory("Reserva de Sala")]
        public void A_sala_deve_ser_reservada_com_sucesso()
        {
            var startDAte = DateTime.Now.AddHours(1);
            var endDate = DateTime.Now.AddHours(3);
            var rep = new BookFakeRepository();
            var room = new Room("Sala 1");
            room.Book(startDAte, endDate,new List<DateTime>());
        }
    }
}
