using CinemaAutomation.DataAccess;
using CinemaAutomation.DataAccess.Services;
using DevExpress.Data.Linq.Helpers;
using DevExpressCinemaAutomation.Forms.ReservationForms;
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

namespace DevExpressCinemaAutomation.Forms.CashRegisterForm
{
    public partial class FrmReports : Form
    {
        private readonly CashRegisterService _cashRegisterService;
        private readonly CinemaEFContext _cinemaEFContext;
        public FrmReports()
        {
            InitializeComponent();
            _cashRegisterService = new CashRegisterService(new CinemaEFContext());
            _cinemaEFContext = new CinemaEFContext();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            LoadCashHistory();
            LoadTotalSales();
            LoadDailySales();
        }

        private void LoadCashHistory()
        {
            var cashHistory = _cashRegisterService.GetAllCashRegisters();
            grdReports.DataSource = cashHistory;
        }

        private void LoadTotalSales()
        {
            int totalMovieSales = _cashRegisterService.GetAllCashRegisters().Count();
            lblTotalOrders.Text = totalMovieSales.ToString();

            int totalSeatSales = _cinemaEFContext.Reservations.Where(r => r.SeatId != 0).Count();
            lblTotalSeatsSold.Text = totalSeatSales.ToString();

            decimal totalRevenue = _cinemaEFContext.Reservations.Count() * FrmReservation.TicketPrice;
            lblTotalRevenue.Text = "$" + totalRevenue.ToString("0.00");
        }

        private void LoadDailySales() 
        {
            var todayDate = DateTime.Today;
            var startOfDay = todayDate.Date;

            var endOfDay = todayDate.Date; // This will give you the end of the day (23:59:59)
            endOfDay = todayDate.Date.AddDays(1).AddTicks(-1); // Set to the end of the day

            // Get the daily movie sales (cash register transactions)
            int dailyMovieSales = _cashRegisterService.GetAllCashRegisters()
                .Where(r => r.TransactionDate >= startOfDay && r.TransactionDate <= endOfDay) //this will filter the transactions for today
                .Count();
            lblTodayOrders.Text = dailyMovieSales.ToString();

            // Get the daily seat sales (reservations)
            int dailySeatSales = _cinemaEFContext.Reservations.Where(r => r.ReservationDate >=startOfDay && r.ReservationDate<=endOfDay).Count();  //this will filter the reservations for today
            lblTodaySeatsSold.Text = dailySeatSales.ToString();

            // Calculate the daily revenue based on the number of reservations and ticket price
            decimal dailyRevenue = dailySeatSales * FrmReservation.TicketPrice;
            lblTodayRevenue.Text = "$" + dailyRevenue.ToString("0.00");
        }
    
    }
}
