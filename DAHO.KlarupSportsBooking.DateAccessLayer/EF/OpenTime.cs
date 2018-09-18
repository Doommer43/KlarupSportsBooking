namespace DAHO.KlarupSportsBooking.DateAccessLayer.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OpenTime
    {
        public int Id { get; set; }

        public DateTime WeekdayStart { get; set; }

        public DateTime WeekdayEnd { get; set; }

        public DateTime WeekendStart { get; set; }

        public DateTime WeekendEnd { get; set; }
    }
}
