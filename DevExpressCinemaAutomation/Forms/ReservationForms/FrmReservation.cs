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
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
            using (var context = new CinemaEFContext())
            {
                new DatabaseSeeder(context).SeedSeats();
            }
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            pnlSeats.Controls.Clear();
            using (var context = new CinemaEFContext())
            {
                var seats = context.Seats.ToList();
                foreach (var seat in seats)
                {
                    // Create and configure seat buttons
                    Button btnSeat = new Button();
                    btnSeat.Text = $" NO: {seat.SeatNumber}";
                    btnSeat.Width = 50;
                    btnSeat.Height = 50;
                    btnSeat.Tag = seat.Id; 
                    btnSeat.BackColor = seat.IsOccupied ? Color.Red : Color.Green;
                    btnSeat.ForeColor = Color.White;

                    pnlSeats.Controls.Add(btnSeat);

                }
            }
        }
    }
}

