using CinemaAutomation.DataAccess;
using CinemaAutomation.DataAccess.Services;
using CinemaAutomation.Entities.Models;
using DevExpress.Security;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCinemaAutomation.Forms.ReservationForms
{
    public partial class FrmReservation : Form
    {
        public const decimal TicketPrice = 12m; // Set the ticket price here. Constant!
        private readonly List<int> selectedSeatIds = new List<int>(); // Store selected seat IDs

        SeatService seatService;
        CashRegisterService cashRegisterService;

        ReservationService reservationService;
        public FrmReservation()
        {
            InitializeComponent();
            using (var context = new CinemaEFContext())
            {
                new DatabaseSeeder(context).SeedSeats();

            }
            seatService = new SeatService(new CinemaEFContext());
            cashRegisterService = new CashRegisterService(new CinemaEFContext());
            reservationService = new ReservationService(new CinemaEFContext());
        }

        void listSeats()
        {
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
                    btnSeat.Click += SeatButton_Click; // Add click event handler

                    pnlSeats.Controls.Add(btnSeat);
                }
            }
        }
        private void FrmReservation_Load(object sender, EventArgs e)
        {

            pnlSeats.Controls.Clear();
            using (var context = new CinemaEFContext())
            {
                listSeats();
                var movieList = context.Movies.ToList();
                cmbMovies.DataSource = movieList;
                cmbMovies.DisplayMember = "Title";
                cmbMovies.ValueMember = "Id";

                var customerList = context.Customers.ToList();
                cmbCustomers.DataSource = customerList;
                cmbCustomers.DisplayMember = "FirstName";
                cmbCustomers.ValueMember = "Id";

                var movies = context.Movies.ToList();
                foreach (var movie in movies)
                {
                    GroupBox groupBox = new GroupBox();
                    groupBox.Width = 125;
                    groupBox.Height = 125;
                    groupBox.Text = movie.Title;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    string posterPath = System.IO.Path.Combine(Application.StartupPath, "Posters", $"{movie.Id}.jpg");
                    if(System.IO.File.Exists(posterPath))
                    {
                        pictureBox.Image = Image.FromFile(posterPath);
                    }

                    groupBox.Controls.Add(pictureBox);
                    pnlNowShowing.Controls.Add(groupBox);
                }

            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            int seatId = (int)btnSeat.Tag;
            using (var context = new CinemaEFContext())
            {
                var seat = context.Seats.Find(seatId);

                if (seat.IsOccupied)
                {
                    // Handle the case when the seat is occupied
                    XtraMessageBox.Show($"Seat {seat.SeatNumber} is already occupied. Please select another seat.", "Seat Occupied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedSeatIds.Contains(seatId))
                {
                    selectedSeatIds.Remove(seatId);
                    btnSeat.BackColor = Color.Green;
                   btnSeat.ForeColor = Color.White;

                }
                else
                {
                    selectedSeatIds.Add(seatId);
                    btnSeat.BackColor = Color.Gold;
                    btnSeat.ForeColor = Color.Black;
                }
                lblSelectedSeats.Text = string.Join(", ", selectedSeatIds.Select(ss => context.Seats.Find(ss).SeatNumber));
                CalculateTotalPrice();
            }
        }


        private void CalculateTotalPrice()
        {
            decimal totalPrice = selectedSeatIds.Count * TicketPrice;
            lblTotalPrice.Text = "$" + totalPrice.ToString("0.00");
        }

        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            if (selectedSeatIds.Count == 0)
            {
                XtraMessageBox.Show("Please select at least one seat.", "No Seats Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new CinemaEFContext())
            {

                foreach (var seat in selectedSeatIds)
                {
                    var reservation = new Reservation
                    {

                        MovieId = (int)cmbMovies.SelectedValue,
                        CustomerId = (int)cmbCustomers.SelectedValue,
                        SeatId = seat,
                        ReservationDate = DateTime.Now
                    };
                    reservationService.AddReservation(reservation);
                }

                foreach (var seat in selectedSeatIds)
                {
                    var Dbseat = context.Seats.FirstOrDefault(s => s.Id == seat);
                    Dbseat.IsOccupied = true; // Mark the seat as occupied
                                              // 
                    seatService.UpdateSeat(Dbseat);
                }

                Decimal totalPrice = selectedSeatIds.Count * TicketPrice;
                var cashRegisterRecord = new CashRegister
                {
                    Amount = totalPrice,
                    TransactionDate = DateTime.Now,
                    Description = $"Movie:{cmbMovies.Text}|Customer:{cmbCustomers.Text}|Tickets:{selectedSeatIds.Count}"
                };

                cashRegisterService.AddCashRegister(cashRegisterRecord);
                XtraMessageBox.Show($"Ticket(s) issued successfully! Total Price: ${totalPrice:0.00}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                selectedSeatIds.Clear();
                pnlSeats.Controls.Clear();
                lblTotalPrice.Text = "$0.00";
                lblSelectedSeats.Text ="";

                listSeats();
                

            }
        }


    }
}
