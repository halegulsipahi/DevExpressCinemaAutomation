using CinemaAutomation.DataAccess;
using CinemaAutomation.DataAccess.Services;
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

namespace DevExpressCinemaAutomation
{
    public partial class FrmMovieList : Form
    {
  
        private readonly MovieService _movieService;
        public FrmMovieList()
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

        private void FrmFilmList_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }
    }
}
