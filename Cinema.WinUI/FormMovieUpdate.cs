using Cinema.BLL;
using Cinema.DTO;
using Cinema.Enums;
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

namespace Cinema.WinUI
{
    public partial class FormMovieUpdate : Form
    {
        public static Event1 MovieUpdated;
        MovieDTO _dto;
        MovieController _mc;
        CastController _cc;
        DirectorController _dc;
        public FormMovieUpdate(MovieDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            _mc = new MovieController();
            _cc = new CastController();
            _dc = new DirectorController();
        }

        private void FormMovieUpdate_Load(object sender, EventArgs e)
        {
            LoadComboListBoxes();
            LoadUpdatedMovie();

        }

        private void LoadUpdatedMovie()
        {
            txtMovieName.Text = _dto.MovieName;
            cmbMovieType.SelectedItem = _dto.MovieTypeNo;
            nudMovieTime.Value = _dto.MovieTime;
            txtMovieYear.Text = _dto.Year.ToString();
            chb3D.Checked = _dto.TD;
            chbIsActive.Checked = _dto.IsActive;
            lstMovieCasts.DataSourceMember<List<CastDTO>>("FullName", "Id", _dto.Casts);
            lstMovieDirectors.DataSourceMember<List<DirectorDTO>>("FullName", "Id", _dto.Directors);
        }

        private void LoadComboListBoxes()
        {
            cmbMovieType.FillComboBox<MovieTypeEnum>();
            List<CastDTO> dtoCasts = _cc.GetAllCasts();
            lstAllCasts.DataSourceMember<List<CastDTO>>("FullName", "Id", dtoCasts);
            List<DirectorDTO> dtoDirectors = _dc.SelectAllDirectors();
            lstAllDirectors.DataSourceMember<List<DirectorDTO>>("FullName", "Id", dtoDirectors);
        }

        private void BtnCastAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            foreach (var item in lstAllCasts.SelectedItems)
            {
                if (SearchCast((CastDTO)item))
                {
                    MessageBox.Show("Oyuncu zaten film kadrosunda var tekrar eklenemez.");
                    return;
                }
            }
            #endregion
            foreach (var item in lstAllCasts.SelectedItems)
            {
                _dto.Casts.Add((CastDTO)item);
            }
            lstMovieCasts.DataSourceMember<List<CastDTO>>("FullName", "Id", _dto.Casts);
        }
        private bool SearchCast(CastDTO dto)
        {
            foreach (var item in lstMovieCasts.Items)
            {
                CastDTO cast = new CastDTO();
                cast = (CastDTO)item;
                if (cast.Id == dto.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnRemoveCast_Click(object sender, EventArgs e)
        {
            foreach (var item in lstMovieCasts.SelectedItems)
            {
                _dto.Casts.Remove((CastDTO)item);
            }
            lstMovieCasts.DataSourceMember<List<CastDTO>>("FullName", "Id", _dto.Casts);
        }

        private void BtnDirectorAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            foreach (var item in lstAllDirectors.SelectedItems)
            {
                if (SearchDirector((DirectorDTO)item))
                {
                    MessageBox.Show("Yönetmen zaten film kadrosunda var tekrar eklenemez.");
                    return;
                }

            }
            #endregion
            foreach (var item in lstAllDirectors.SelectedItems)
            {
                _dto.Directors.Add((DirectorDTO)item);
            }
            lstMovieDirectors.DataSourceMember<List<DirectorDTO>>("FullName", "Id", _dto.Directors);
        }
        private bool SearchDirector(DirectorDTO dto)
        {
            foreach (var item in lstMovieDirectors.Items)
            {
                DirectorDTO director = new DirectorDTO();
                director = (DirectorDTO)item;
                if (director.Id == dto.Id)
                {
                    return true;
                }
            }
            return false;
        }
        private void BtnRemoveDirector_Click(object sender, EventArgs e)
        {
            foreach (var item in lstMovieDirectors.SelectedItems)
            {
                _dto.Directors.Remove((DirectorDTO)item);
            }
            lstMovieDirectors.DataSourceMember<List<DirectorDTO>>("FullName", "Id", _dto.Directors);
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtMovieName.Text.Trim() == string.Empty || txtMovieYear.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Film adı veya yılı boş geçilemez.");
                return;
            }
            else if (lstMovieCasts.SelectedItem == null || lstMovieDirectors.SelectedItem == null)
            {
                MessageBox.Show("Oyuncu ve yönetmen seçimi zorunludur.");
                return;
            }
            else if (nudMovieTime.Value <= 0)
            {
                MessageBox.Show("Film süresi 0 dan büyük olmalıdır.");
                return;
            }
            #endregion
            _dto.MovieName = txtMovieName.Text;
            _dto.MovieTypeNo = (MovieTypeEnum)cmbMovieType.SelectedItem;
            _dto.MovieTime = int.Parse(nudMovieTime.Value.ToString());
            _dto.Year = int.Parse(txtMovieYear.Text);
            _dto.TD = chb3D.Checked;
            _dto.IsActive = chbIsActive.Checked;
            var result = _mc.UpdateMovie(_dto);
            result.NotificationShow();
            if (result.State==ResultState.Success)
            {
                MovieUpdated.Raise();
            }
        }

    }
}
