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
    public class OpenTimeHandlerTests
    {
        [TestMethod()]
        public void GetOpeningTimesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCurrentTimesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCurrentOpenCloseTimesTest()
        {
            //Arrange And Act
            OpenTimeHandler openTimeHandler = new OpenTimeHandler();
            var r = openTimeHandler.GetCurrentOpenCloseTimes();
            //Assert
            Assert.AreEqual(4, r.Count);
        }

        [TestMethod()]
        public void GetCurrentOpenCloseTimesTypeTest()
        {
            //Arrange And Act
            OpenTimeHandler openTimeHandler = new OpenTimeHandler();
            var r = openTimeHandler.GetCurrentOpenCloseTimes();
            //Assert
            Assert.AreEqual(typeof(List<DateTime>), r.GetType());
        }

        [TestMethod()]
        public void DropdownSetterWeekdayTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DropdownSetterWeekendTest()
        {
            Assert.Fail();
        }
    }
}