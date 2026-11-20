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
    public partial class FrmCustomerUpdate : Form
    {
        private readonly CustomerService _customerService;
        public FrmCustomerUpdate()
        {
            InitializeComponent();
            _customerService = new CustomerService(new CinemaEFContext());
        }

        private void FrmCustomerUpdate_Load(object sender, EventArgs e)
        {
            var customers = _customerService.GetAllCustomers();


            cmbCustomers.DataSource = customers;
            cmbCustomers.DisplayMember = "FirstName";
            cmbCustomers.ValueMember = "Id";
        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedItem == null)
            {
                return;
            }
            Customer selectedCustomer = (Customer)cmbCustomers.SelectedItem;
            txtName.Text = selectedCustomer.FirstName;
            txtSurname.Text = selectedCustomer.LastName;
            txtEmail.Text = selectedCustomer.Email;
            txtPhone.Text = selectedCustomer.Phone;
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)cmbCustomers.SelectedItem;

            if (selectedCustomer != null)
            {
                selectedCustomer.FirstName = txtName.Text;
                selectedCustomer.LastName = txtSurname.Text;
                selectedCustomer.Email = txtEmail.Text;
                selectedCustomer.Phone = txtPhone.Text;
                _customerService.UpdateCustomer(selectedCustomer);
                XtraMessageBox.Show("Customer updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

   
