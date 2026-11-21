using CinemaAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.DataAccess.Services
{
    public class ReservationService
    {
        private readonly CinemaEFContext _context;

        public ReservationService(CinemaEFContext context)
        {
            _context = context;
        }

        public void AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }
    }
}
