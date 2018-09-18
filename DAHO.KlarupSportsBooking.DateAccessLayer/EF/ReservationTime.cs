namespace DAHO.KlarupSportsBooking.DateAccessLayer.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReservationTime
    {
        public int Id { get; set; }

        public int ReservationsId { get; set; }

        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public virtual Reservation Reservation { get; set; }
    }
}
