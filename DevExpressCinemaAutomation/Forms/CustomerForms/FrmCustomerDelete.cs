using CinemaAutomation.DataAccess;
using CinemaAutomation.DataAccess.Services;
using CinemaAutomation.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCinemaAutomation.Forms.CustomerForms
{
    public partial class FrmCustomerDelete : Form
    {
        private readonly CustomerService _customerService;
        public FrmCustomerDelete()
        {
            InitializeComponent();
            _customerService = new CustomerService(new CinemaEFContext());
        }

        private void LoadCustomers()
        {
            try
            {
                List<Customer> customers = _customerService.GetAllCustomers();
                dgvCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the customers: {ex.Message}");
            }
        }
        private void FrmCustomerDelete_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvCustomers.CurrentRow;
            int value = Convert.ToInt32(selectedRow.Cells[0].Value);

            DialogResult result = XtraMessageBox.Show("Are you sure you want to delete the customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _customerService.DeleteCustomer(value);
                LoadCustomers();

                XtraMessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
