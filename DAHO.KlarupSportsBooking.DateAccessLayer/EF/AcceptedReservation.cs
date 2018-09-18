namespace DAHO.KlarupSportsBooking.DateAccessLayer.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AcceptedReservation
    {
        public int Id { get; set; }

        public int ReservationsId { get; set; }

        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Reservation Reservation { get; set; }
    }
}
