using DAHO.KlarupSportsBooking.DateAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHO.KlarupSportsBooking.BusinessLayer
{
    public class AcceptedReservationHandler : BaseHandler
    {
        public bool Add(AcceptedReservation ares)
        {
            Model.AcceptedReservations.Add(ares);
            return SaveChanges();
        }
    }
}
