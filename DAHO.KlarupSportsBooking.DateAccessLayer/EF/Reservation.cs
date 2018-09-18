namespace DAHO.KlarupSportsBooking.DateAccessLayer.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            AcceptedReservations = new HashSet<AcceptedReservation>();
            ReservationTimes = new HashSet<ReservationTime>();
        }

        public int Id { get; set; }

        public int ActivityId { get; set; }

        public bool Accepted { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AcceptedReservation> AcceptedReservations { get; set; }

        public virtual Activity Activity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationTime> ReservationTimes { get; set; }
    }
}
