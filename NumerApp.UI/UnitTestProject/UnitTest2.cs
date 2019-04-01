using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerApp.DataAccess;
using NumerApp.Entities;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethodGetGerencias()
        {
            var lista = new List<Gerencia>();

            var da = new GerenciaDA();

            lista = da.GetAll().ToList();

            Assert.AreEqual(3, lista.Count);
        }

        [TestMethod]
        public void TestMethodGetCartas()
        {
            var lista = new List<Carta>();

            var da = new CartaDA();

            lista = da.GetAll().ToList();

            Assert.AreEqual(1, lista.Count);
        }
    }
}
