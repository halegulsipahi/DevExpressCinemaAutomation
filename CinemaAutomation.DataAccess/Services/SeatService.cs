using CinemaAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.DataAccess.Services
{
    public class SeatService
    {
        private readonly CinemaEFContext _context;

        public SeatService(CinemaEFContext context)
        {
            _context = context;
        }
        public void UpdateSeat(Seat seat)
        {
            var existingSeat = _context.Seats.FirstOrDefault(s => s.Id == seat.Id);
            if (existingSeat != null)
            {
                existingSeat.HallName = seat.HallName;
                existingSeat.RowNumber = seat.RowNumber;
                existingSeat.SeatNumber = seat.SeatNumber;
                existingSeat.IsOccupied = seat.IsOccupied;
                _context.SaveChanges();
            }
        }
    }
}

               