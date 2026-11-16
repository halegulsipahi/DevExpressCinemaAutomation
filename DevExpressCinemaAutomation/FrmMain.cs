using CinemaAutomation.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpressCinemaAutomation
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
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
    }
}
