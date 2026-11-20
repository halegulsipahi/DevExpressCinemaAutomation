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
    public partial class FrmCustomerAdd : Form
    {
        private readonly CustomerService _customerService;
        public FrmCustomerAdd()
        {
            InitializeComponent();
            _customerService = new CustomerService(new CinemaEFContext());
        }

      

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };
            _customerService.AddCustomer(newCustomer);
            XtraMessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCustomerAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
