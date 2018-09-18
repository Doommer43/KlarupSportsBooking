namespace DAHO.KlarupSportsBooking.DateAccessLayer.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            Unions = new HashSet<Union>();
        }

        public int Id { get; set; }

        public int CityId { get; set; }

        public int StreetId { get; set; }

        public int Nr { get; set; }

        public virtual City City { get; set; }

        public virtual Street Street { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Union> Unions { get; set; }
    }
}
