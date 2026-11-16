using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.Entities.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }        
        public string Genre { get; set; }        
        public string Director { get; set; }    
        public int Duration { get; set; }        
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }    // İlgili Rezervasyon varlıkları için gezinme özelliği
     

     
    }
}
