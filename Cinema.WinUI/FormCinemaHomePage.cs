using Cinema.BLL;
using Cinema.DTO;
using Cinema.Enums;
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
    public partial class FormCinemaHomePage : Form
    {
        MovieController _mc;
        CastController _cc;
        DirectorController _dd;
        CastDTO cast;
        DirectorDTO director;
        ICollection<MovieTypeEnum> movieTypes;
        
        public FormCinemaHomePage()
        {
            InitializeComponent();
            _mc = new MovieController();
            _cc = new CastController();
            _dd = new DirectorController();
            cast = new CastDTO();
            
        }
        
        private void FormCinemaHomePage_Load(object sender, EventArgs e)
        {
            MovieTypeListLoad();
            CastListLoad();
            DirectorListLoad();
            cmbType.SelectedIndex = 0;
        }

        private void MovieTypeListLoad()
        {
            cmbType.FillComboBox<MovieTypeEnum>();
        }

        private void CastListLoad()
        {
            List<CastDTO> casts = _cc.GetAllCasts();
            cmbCast.DataSource = null;
            cmbCast.DisplayMember = "FullName";
            cmbCast.ValueMember = "Id";
            cmbCast.DataSource = casts;
        }

        private void DirectorListLoad()
        {
            List<DirectorDTO> directors = _dd.SelectAllDirectors();
            cmbDirector.DataSource = null;
            cmbDirector.DisplayMember = "FullName";
            cmbDirector.ValueMember = "Id";
            cmbDirector.DataSource = directors;
        }

        private void MovieListLoad()
        {
            
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
