using CinemaAutomation.DataAccess;
using CinemaAutomation.DataAccess.Services;
using CinemaAutomation.Entities.Models;
using DevExpressCinemaAutomation.Forms;
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

        private void RE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
    }
}
