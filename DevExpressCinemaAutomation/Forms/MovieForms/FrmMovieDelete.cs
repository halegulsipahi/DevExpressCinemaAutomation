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
    public partial class FrmMovieDelete : Form
    {
        private readonly MovieService _movieService;
        public FrmMovieDelete()
        {
            _movieService = new MovieService(new CinemaEFContext());
            InitializeComponent();
        }
        private void LoadMovies()
        {
            try
            {
                List<Movie> movies = _movieService.GetAllMovies();
                gridMovies.DataSource = movies;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the films: {ex.Message}");
            }
        }
        private void FrmMovieDelete_Load(object sender, EventArgs e)
        {
            LoadMovies();
            gridMovies.Columns["Reservations"].Visible = false;
        }

        private void gridMovies_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = gridMovies.CurrentRow;
            int value = Convert.ToInt32(selectedRow.Cells[0].Value);



            DialogResult result = XtraMessageBox.Show("Are you sure you want to delete the movie?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _movieService.DeleteMovie(value);
                LoadMovies();

                XtraMessageBox.Show("Movie deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
