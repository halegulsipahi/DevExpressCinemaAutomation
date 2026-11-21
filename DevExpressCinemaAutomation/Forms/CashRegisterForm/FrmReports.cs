using CinemaAutomation.DataAccess;
using CinemaAutomation.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCinemaAutomation.Forms.CashRegisterForm
{
    public partial class FrmReports : Form
    {
        private readonly CashRegisterService _cashRegisterService;
        public FrmReports()
        {
            InitializeComponent();
            _cashRegisterService = new CashRegisterService(new CinemaEFContext());
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            LoadCashHistory();
        }

        private void LoadCashHistory() 
        {
           var cashHistory = _cashRegisterService.GetAllCashRegisters();
            grdReports.DataSource = cashHistory;
        }
    }
}
