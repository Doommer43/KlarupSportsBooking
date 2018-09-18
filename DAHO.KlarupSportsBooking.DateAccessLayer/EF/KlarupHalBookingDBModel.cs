namespace DAHO.KlarupSportsBooking.DateAccessLayer.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KlarupHalBookingDBModel : DbContext
    {
        public KlarupHalBookingDBModel()
            : base("name=KlarupHalBookingDBModelConnectionString")
        {
        }

        public virtual DbSet<AcceptedReservation> AcceptedReservations { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<OpenTime> OpenTimes { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationTime> ReservationTimes { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<UnionLeader> UnionLeaders { get; set; }
        public virtual DbSet<Union> Unions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Unions)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Admin>()
                .HasMany(e => e.AcceptedReservations)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservation>()
                .HasMany(e => e.AcceptedReservations)
                .WithRequired(e => e.Reservation)
                .HasForeignKey(e => e.ReservationsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservation>()
                .HasMany(e => e.ReservationTimes)
                .WithRequired(e => e.Reservation)
                .HasForeignKey(e => e.ReservationsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Street>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.Street)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Union>()
                .HasMany(e => e.UnionLeaders)
                .WithRequired(e => e.Union)
                .WillCascadeOnDelete(false);
        }
    }
}
