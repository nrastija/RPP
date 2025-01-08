using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
    }
}
