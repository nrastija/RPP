using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Entities.Accounts;
using Entities.Clients;
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

        [TestMethod]
        public void ForeignAccount_Deposit_ValueIsAdded()
        {
            //Arrange
            ForeignAccount account = new ForeignAccount("HR99999999", 1000, null, null);

            //Act
            account.Deposit(250);

            //Assert
            Assert.AreEqual(1250, account.Balance, "Nije dobar iznos");
        }

    }
}
