using Cinema.BLL;
using Cinema.DTO;
using Cinema.WinUI;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSeans.UI
{
    public partial class FormMovieList : Form
    {
        MovieController _mc;
        public FormMovieList()
        {
            InitializeComponent();
            _mc = new MovieController();
            FormMovieAdd.MovieAdded += LoadMovies;
            FormMovieUpdate.MovieUpdated += LoadMovies;
        }

        private void FormMovieList_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            List<MovieDTO> dtos = _mc.GetAllMovies();
            lstMovies.DataSourceMember<List<MovieDTO>>("MovieName", "Id", dtos);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.ShowFormBro<FormMovieAdd>();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MovieDTO dto = lstMovies.SelectedItem as MovieDTO;
            this.MdiBroShow<FormMovieUpdate, MovieDTO>(dto);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MovieDTO dto = lstMovies.SelectedItem as MovieDTO;
            var result = _mc.DeleteMovie(dto);
            result.NotificationShow();
            if (result.State==ResultState.Success)
            {
                LoadMovies();
            }

        }
    }
}
