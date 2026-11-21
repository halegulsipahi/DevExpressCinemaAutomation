using CinemaAutomation.DataAccess;
using CinemaAutomation.DataAccess.Services;
using CinemaAutomation.Entities.Models;
using DevExpressCinemaAutomation.Forms;
using DevExpressCinemaAutomation.Forms.CashRegisterForm;
using DevExpressCinemaAutomation.Forms.CustomerForms;
using DevExpressCinemaAutomation.Forms.ReservationForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace DevExpressCinemaAutomation
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        private readonly MovieService _movieService;
       

        public FrmMain()
        {
            _movieService = new MovieService(new CinemaEFContext());
            InitializeComponent();
        }
      
       
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CinemaEFContext>());
            using (var db = new CinemaEFContext())
            {
                if(!db.Database.Exists())
                {
                    db.Database.Initialize(force: true);

                    MessageBox.Show("Veritabanı Oluşturuldu!");
                }
             

            }
           
        }
        //Movie Forms
        private void btnListMovie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMovieList frm = new FrmMovieList();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnAddMovie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMovieAdd frm = new FrmMovieAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEditMovie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMovieUpdate frm = new FrmMovieUpdate();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRemoveMovie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMovieDelete frm = new FrmMovieDelete();
            frm.MdiParent = this;
            frm.Show();
        }


        //Customer Forms
        private void btnListCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCustomerList frm = new FrmCustomerList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCustomerAdd frm = new FrmCustomerAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEditCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCustomerUpdate frm = new FrmCustomerUpdate();
            frm.MdiParent = this;
            frm.Show();
        }
        
   

        private void btnDeleteCustomer_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCustomerDelete frm = new FrmCustomerDelete();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnShowSeat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSeats frm = new FrmSeats();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMakeReservation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReservation frm = new FrmReservation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReports frm = new FrmReports();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
