using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAHO.KlarupSportsBooking.DateAccessLayer.EF;

namespace DAHO.KlarupSportsBooking.BusinessLayer
{
    public class BaseHandler
    {
        private KlarupHalBookingDBModel model = new KlarupHalBookingDBModel();

        protected KlarupHalBookingDBModel Model { get => model; set => model = value; }

        public bool SaveChanges()
        {
            int rowsAffected = Model.SaveChanges();

            if(rowsAffected > 0)
            {
                return true;
            } return false;
        }
    }
}
