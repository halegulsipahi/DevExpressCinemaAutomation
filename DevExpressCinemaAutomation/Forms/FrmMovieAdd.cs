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

namespace DevExpressCinemaAutomation.Forms
{
    public partial class FrmMovieAdd : Form
    {
        private MovieService _movieService;
        public FrmMovieAdd()
        {
            _movieService = new MovieService(new CinemaAutomation.DataAccess.CinemaEFContext());
            InitializeComponent();
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                var newMovie = new Movie
                {
                    Title = txtTitle.Text,
                    Genre = txtGenre.Text,
                    Director = txtDirector.Text,
                    Duration =Convert.ToInt32(numericDuration.Value),
                    ReleaseDate =dateReleaseDate.DateTime,
                    Reservations = new List<Reservation>()

                };
               _movieService.AddMovie(newMovie);
                XtraMessageBox.Show("Movie saved successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch(Exception ex) 
            {
                XtraMessageBox.Show("An error occurred while saving the movie!" +ex.Message);
                throw;  
            }
        }
    }
}
