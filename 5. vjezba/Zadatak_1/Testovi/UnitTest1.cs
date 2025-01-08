using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using BusinessLayer;
using BusinessLayer.Exceptions;
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

        [TestMethod]
        public void ClientService_UpdatePremiumClient_ClientExceptionTriggeredWhenClientNull()
        {
            //Arrange
            ClientService clientService = new ClientService();

            /*try
            {
                clientService.UpdatePremiumClient(null, "0941924921", "test", "test", "test");
            }
            catch (ClientException ex)
            {
                Assert.AreEqual("Client is not provided!", ex.Message);
            }*/

            //Act
            var ex = Assert.ThrowsException<ClientException>(() =>
                clientService.UpdatePremiumClient(null, "09123", "test", "test", "test")); 
            
            //Assert
            Assert.AreEqual("Client is not provided!", ex.Message);
        }
    }
}
