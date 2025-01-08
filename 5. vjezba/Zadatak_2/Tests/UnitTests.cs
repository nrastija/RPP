using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        
    }
}
