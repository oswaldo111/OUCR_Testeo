using Microsoft.VisualStudio.TestTools.UnitTesting;
using OUCR.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUCR.Temperatura.Tests
{
    [TestClass()]
    public class TemperaturaConverterTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            TemperaturaConverter converter = new TemperaturaConverter();

            double resultado = converter.CelsiusToFahrenheit(12);
            Assert.AreEqual(53.6, resultado );
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            TemperaturaConverter converter = new TemperaturaConverter();

            double resultado = converter.FahrenheitToCelsius(53.6);
            Assert.AreEqual(12, resultado);
        }
    }
}