using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entities.Exchange;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExchangeRate_Currency_ConstructorWorks()
        {
            Currency currencyHRK = new Currency("HRK", "Croatia");
            ExchangeRate rate = new ExchangeRate(currencyHRK, 21);

            Assert.AreEqual("HRK", rate.Currency.Code);
            Assert.AreEqual("Croatia", rate.Currency.Country);
            Assert.AreEqual(21, rate.Rate);
        }
    }
}
