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
    public class ReservationHandlerTests
    {
        [TestMethod()]
        public void GetAllReservationsTest()
        {
            //Arrange and Act
            ReservationHandler reservationHandler = new ReservationHandler();
            var a = reservationHandler.GetAllReservations();
            //Assert
            Assert.AreEqual(3, a.Count);
        }
    }
}