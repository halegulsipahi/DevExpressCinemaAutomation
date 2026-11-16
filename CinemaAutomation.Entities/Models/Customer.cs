using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.Entities.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }          
        public string Email { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }    // İlgili Rezervasyon varlıkları için gezinme özelliği

    }
}
