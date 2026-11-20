using CinemaAutomation.DataAccess;
using CinemaAutomation.DataAccess.Services;
using CinemaAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCinemaAutomation.Forms.CustomerForms
{
    public partial class FrmCustomerList : Form
    {
        private readonly CustomerService _customerService;
        public FrmCustomerList()
        {
            InitializeComponent();
            _customerService = new CustomerService(new CinemaEFContext());
        }

        private void LoadCustomers()
        {
            try
            {
                List<Customer> customers = _customerService.GetAllCustomers();
                grdCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the customers: {ex.Message}");
            }
        }
        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}







