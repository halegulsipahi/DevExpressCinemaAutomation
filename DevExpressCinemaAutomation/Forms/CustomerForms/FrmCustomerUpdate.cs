using CinemaAutomation.Entities.Models;
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
        public FrmCustomerUpdate()
        {
            InitializeComponent();
        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedItem == null)
            {
                return;
            }
            Customer selectedCustomer = (Customer)cmbCustomers.SelectedItem;
            txtName.Text = selectedCustomer.Name;
            txtSurname.Text = selectedCustomer.Surname;
            txtPhone.Text = selectedCustomer.Phone;
            txtEmail.Text = selectedCustomer.Email;

        }
    }
}
