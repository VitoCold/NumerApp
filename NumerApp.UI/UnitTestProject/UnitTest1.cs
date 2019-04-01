using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerApp.Common;
using NumerApp.Entities;
using NumerApp.DataAccess;
using Dapper;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodInsertCarta()
        {
            var da = new CartaDA();

            var cantidad = da.GetAll().ToList().Count(q=>q.GerenciaId==2)+1;

            var carta = new Carta
            {
                Codigo = CurrentCode.Codigo("GCO",cantidad),
               GerenciaId = 2,
               Asunto = "Este es otro asunto",
               Destinatario = "Señor de Osinergmin",
               Usuario = CurrentUser.GetUser(),
               FechaCreacion = DateTime.Now
                };

            Assert.AreEqual(1, da.AddCarta(carta));
        }

        [TestMethod]
        public void TestMethodInsertGerencia()
        {
            var gere = new Gerencia
            {
                Apoderado = "Alvaro Ruiz",
                Activo = true,
                NombreGerencia = "Gerencia Comercial",
                Abreviatura = "GCO",
                FechaIngreso = new DateTime(2017, 1, 1)
            };

            var da = new GerenciaDA();

            Assert.AreEqual(1, da.AddGerencia(gere));
        }

    }
}
