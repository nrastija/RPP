using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BusinessLayer;
using BusinessLayer.Exceptions;
using Entities.Accounts;
using Entities.Clients;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void PremiumClient_Type_EqualsClientTypePremium()
        {
            //Arrange
            PremiumClient client = new PremiumClient("1111", "temp", "test", "test");

            //Assert
            Assert.IsTrue(client.Type == ClientType.Premium);
            
        }

        [TestMethod]
        public void ForeignAccount_Balance_BalanceRemovedByWithdraw()
        {
            //Arrange
            ForeignAccount account = new ForeignAccount("555", 1000, null, null);

            //Act
            account.Withdraw(250);

            //Assert
            Assert.AreEqual(750, account.Balance, "Balance has not been withdrawn");
        }

        [TestMethod]
        public void ClientService_UpdateBasicClient_OIBLengthExceptionThrown()
        {
            /*
            try
            {
                //Arrange
                ClientService clientService = new ClientService();
                BasicClient client = new BasicClient("941", "test", "test");
                
                //Act
                clientService.UpdateBasicClient(client, "444", "test", "test");
            }
            //Assert
            catch (ClientException ex)
            {
                Assert.AreEqual("OIB needs to have 11 characters!", ex.Message, "Message is not correct.");
            }

            */

            // Arrange
            ClientService clientService = new ClientService();
            BasicClient client = new BasicClient("941", "test", "test");

            // Act & Assert
            var ex = Assert.ThrowsException<ClientException>(() =>
                clientService.UpdateBasicClient(client, "444", "test", "test"));

            Assert.AreEqual("OIB needs to have 11 characters!", ex.Message);

        }

        [TestMethod]
        public void IbanGenerator_GenerateIBAN_15CharacterStringWithFirstTwoLettersHR()
        {
            //Arrange && Act
            var service = IbanGenerator.GenerateIBAN();

            //Assert
            Assert.AreEqual(15, service.Length, "String is not 15 characters long.");
            Assert.IsTrue(service.StartsWith("HR"), "Service does not start with HR.");
            
        }
    }

}
