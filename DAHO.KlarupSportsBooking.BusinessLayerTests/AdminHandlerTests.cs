using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAHO.KlarupSportsBooking.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHO.KlarupSportsBooking.BusinessLayer.Tests
{
    [TestClass()]
    public class AdminHandlerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LoginTest()
        {
            //Arrange
            AdminHandler adminHandler = new AdminHandler();
            string username = "Johannes";
            string password = "control";
            //Act
            adminHandler.Login(username, password);
            Assert.Fail();
        }
    }
}