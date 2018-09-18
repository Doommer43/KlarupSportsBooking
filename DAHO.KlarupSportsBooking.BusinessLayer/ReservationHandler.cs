using DAHO.KlarupSportsBooking.DateAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHO.KlarupSportsBooking.BusinessLayer
{
    public class ReservationHandler : BaseHandler
    {
        public bool Add(Reservation res)
        {
            Model.Reservations.Add(res);
            return SaveChanges();
        }
    }
}
