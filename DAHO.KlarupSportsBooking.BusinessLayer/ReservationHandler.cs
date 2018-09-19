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
        /// <summary>
        /// Returns all reservations in the database
        /// </summary>
        /// <returns></returns>
        public List<Reservation> GetAllReservations()
        {
            return Model.Reservations.ToList();
        }

        public bool Add(Reservation res)
        {
            Model.Reservations.Add(res);
            return SaveChanges();
        }

        public bool Update(Reservation res)
        {
            var result = Model.Reservations.Find(res.Id);
            result = res;
            return SaveChanges();
        }

        public bool Remove(Reservation res)
        {
            Model.Reservations.Remove(res);
            return SaveChanges();
        }
    }
}
