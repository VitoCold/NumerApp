using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerApp.DataAccess;
using NumerApp.Entities;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethodGetGerencia3()
        {

            var gere = new Gerencia();

            var da = new GerenciaDA();

            gere = da.Get(3);

            Assert.AreEqual("GCO", gere.Abreviatura);

        }

        [TestMethod]
        public void TestMethodGetCarta1()
        {

            var cart = new Carta();

            var da = new CartaDA();

            cart = da.Get(1);

            Assert.AreEqual(1, cart.CartaId);

        }
    }
}
