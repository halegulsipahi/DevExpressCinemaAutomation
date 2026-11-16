using CinemaAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.DataAccess.Mappings
{
    public class ReservationMap : EntityTypeConfiguration<Reservation>
    {
        public ReservationMap()
        {
            ToTable("Reservations");
            HasKey(r => r.Id);
            Property(r => r.MovieId).IsRequired();
            Property(r => r.CustomerId).IsRequired();
            Property(r => r.SeatId).IsRequired();         
            Property(r => r.ReservationDate).HasColumnType("datetime").IsRequired();
           
            HasRequired(r => r.Movie).WithMany(m => m.Reservations).HasForeignKey(r => r.MovieId).WillCascadeOnDelete(false);
            HasRequired(r => r.Customer).WithMany(c => c.Reservations).HasForeignKey(r => r.CustomerId).WillCascadeOnDelete(false);
            HasRequired(r => r.Seat).WithMany(s => s.Reservations).HasForeignKey(r => r.SeatId).WillCascadeOnDelete(false);
        }
    }
}
