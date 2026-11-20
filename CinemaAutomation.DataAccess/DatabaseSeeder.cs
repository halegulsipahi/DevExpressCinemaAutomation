using CinemaAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.DataAccess
{
    public class DatabaseSeeder
    {
        private readonly CinemaEFContext _context;

        public DatabaseSeeder(CinemaEFContext context)
        {
            _context = context;
        }

        public void SeedSeats()
        { 
          if(!_context.Seats.Any())
          {
              for(int i = 1; i <= 50; i++)
              {
                  _context.Seats.Add(new Seat
                  {
                      HallName = "Hall 1",
                      RowNumber = (i - 1) / 10 + 1, // Assuming 10 seats per row
                      SeatNumber = i,
                      IsOccupied = false

                  }
                  );
              }
              _context.SaveChanges();
          }
        }
    }
}
