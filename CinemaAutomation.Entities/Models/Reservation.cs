using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.Entities.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int MovieId { get; set; }              // FilmId
        public int CustomerId { get; set; }           // MusteriId
        public int SeatId { get; set; }               // KoltukId
        public DateTime ReservationDate { get; set; } // RezervasyonTarihi / SeansTarihi

        public virtual Movie Movie { get; set; }            // Film bilgisi
        public virtual Customer Customer { get; set; }      // Musteri bilgisi
        public virtual Seat Seat { get; set; }            // Koltuk bilgisi


    }
}
