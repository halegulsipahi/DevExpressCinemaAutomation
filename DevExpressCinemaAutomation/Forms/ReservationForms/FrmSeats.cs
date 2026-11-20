using CinemaAutomation.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCinemaAutomation.Forms.ReservationForms
{
    public partial class FrmSeats : Form
    {
        public FrmSeats()
        {
            InitializeComponent();

            using (var context = new CinemaEFContext())
            {
                new DatabaseSeeder(context).SeedSeats();
            }
        }

        private void FrmSeats_Load(object sender, EventArgs e)
        {
            pnlSeats.Controls.Clear();
            using (var context = new CinemaEFContext())
            {
                var seats = context.Seats.ToList();
                foreach (var seat in seats)
                {
                    // Create and configure seat buttons
                    Button btnSeat = new Button();
                    btnSeat.Text = $" Seat: {seat.SeatNumber}";
                    btnSeat.Width = 60;
                    btnSeat.Height = 60;
                    btnSeat.Tag = seat.Id; // Store the seat object in the button's Tag property
                    btnSeat.BackColor = seat.IsOccupied ? Color.Red : Color.Green;
                    btnSeat.ForeColor = Color.White;

                    pnlSeats.Controls.Add(btnSeat);

                }
            }
        }
    }
}

