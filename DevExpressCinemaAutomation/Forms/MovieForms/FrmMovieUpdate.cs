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

namespace DevExpressCinemaAutomation.Forms
{
    public partial class FrmMovieUpdate : Form
    {
        private readonly MovieService _movieService;
        public FrmMovieUpdate()
        {
            InitializeComponent();
            _movieService = new MovieService(new CinemaEFContext());
        }

        private void FrmMovieUpdate_Load(object sender, EventArgs e)
        {
            var movies = _movieService.GetAllMovies();


            cmbMovies.DataSource = movies;
            cmbMovies.DisplayMember = "Title";
            cmbMovies.ValueMember = "Id";


        }

        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedItem == null)
            {
                return;
            }
            Movie selectedMovie = (Movie)cmbMovies.SelectedItem;
            txtTitle.Text = selectedMovie.Title;
            txtGenre.Text = selectedMovie.Genre;
            txtDirector.Text = selectedMovie.Director;
            numericDuration.Value = selectedMovie.Duration;
            dateReleaseDate.DateTime = selectedMovie.ReleaseDate;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Movie selectedMovie = (Movie)cmbMovies.SelectedItem;

            if (selectedMovie != null)
            {
                selectedMovie.Title = txtTitle.Text;
                selectedMovie.Genre = txtGenre.Text;
                selectedMovie.Director = txtDirector.Text;
                selectedMovie.Duration = (int)numericDuration.Value;
                selectedMovie.ReleaseDate = dateReleaseDate.DateTime;
                _movieService.UpdateMovie(selectedMovie);
                XtraMessageBox.Show("Movie updated successfully!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
    }
}
