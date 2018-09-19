using DAHO.KlarupSportsBooking.DateAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHO.KlarupSportsBooking.BusinessLayer
{
    public class StatisticHandler : BaseHandler
    {
        public List<Reservation> GetAllAcceptedReservations()
        {
            return Model.Reservations.Where(r => r.Accepted == true).ToList();
        }
    }
}
