using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BusinessLayer;
using BusinessLayer.Exceptions;
using Entities.Accounts;
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

        [TestMethod]
        public void ForeignAccount_Balance_WithdrawReducesBalance()
        {
            //Arrange
            Currency currencyHRK = new Currency("HRK", "Croatia");
            ForeignAccount account = new ForeignAccount("1111", 800, currencyHRK, null);

            //Act
            account.Withdraw(250);

            //Assert
            Assert.AreEqual(550, account.Balance);
        }

        [TestMethod]
        public void ClientService_UpdatePremiumClient_ClientExceptionThrown()
        {
            try
            {
                ClientService service = new ClientService();

                service.UpdatePremiumClient(null, "1111", "aa", "aa", "aa");
            }
            catch (ClientException ex)
            {
                Assert.AreEqual("Client is not provided!", ex.Message);
            }
        }
    }
}
