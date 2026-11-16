using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.Entities.Models
{
    public class CashRegister
    {
        public int Id { get; set; }      
        public decimal Amount { get; set; }            // Tutar
        public string Description { get; set; }        // Aciklama (Örn: "Ticket Sale - Seat A1")
        public DateTime TransactionDate { get; set; }  // Tarih / IslemTarihi
      
    
    }
}
