using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.Entities.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public string HallName { get; set; }     // SalonAdi
        public int RowNumber { get; set; }       // SiraNo
        public int SeatNumber { get; set; }      //KoltukNo
        public bool IsOccupied { get; set; }     // Dolu mu / Rezerve mi? (true = Dolu, false = Boş)

        public virtual ICollection<Reservation> Reservations { get; set; }    // İlgili Rezervasyon varlıkları için gezinme özelliği
    }
}
