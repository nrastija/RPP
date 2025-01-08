using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Entities.Exchange;

namespace Testovi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Currrency_Constructor_CodeCountryIsCorrect()
        {
            //Arrange
            Currency currency = new Currency("CZK", "Češka");


            //Assert
            Assert.IsTrue(currency.Code == "CZK");
            Assert.IsTrue(currency.Country == "Češka");
        }

    }
}
