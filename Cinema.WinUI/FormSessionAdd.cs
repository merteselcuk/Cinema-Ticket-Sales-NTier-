using Cinema.BLL;
using Cinema.DTO;
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
    public partial class FormSessionAdd : Form
    {
        MovieController _mc;
        SeanceController _sc;
        TheaterController _tc;
        SessionController _ssc;
        public static Event1 SessionAddded;
        public FormSessionAdd()
        {
            InitializeComponent();
            _mc = new MovieController();
            _sc = new SeanceController();
            _tc = new TheaterController();
            _ssc = new SessionController();
        }
        private void ComboBoxLoad()
        {
            ListBoxExtension.DataSourceMember<List<MovieDTO>>(cmbMovie, "MovieName", "Id", _mc.GetAllMovies());

            List<SeanceDTO> listSeances = new List<SeanceDTO>();
            List<SeanceDTO> seances = _sc.GetAllSeance();
            foreach (var item in seances)
            {
                TimeSpan intermission = new TimeSpan(0,30,0);
                TimeSpan sessionTime = item.FinishTime - item.StartTime;
                MovieDTO mdto = cmbMovie.SelectedItem as MovieDTO;
                int movieTime = mdto.MovieTime;
                int movieHour = movieTime / 60;
                int movieMinute = movieTime % 60;
                TimeSpan movieTimeSpan = new TimeSpan(movieHour, movieMinute, 0);
                if (movieTimeSpan+intermission <= sessionTime)
                {
                    listSeances.Add(item);
                }
            }
            ListBoxExtension.DataSourceMember<List<SeanceDTO>>(cmbSeance, "SeanceInformation", "Id", listSeances);
            ListBoxExtension.DataSourceMember<List<TheaterDTO>>(cmbTheater, "TheaterName", "Id", _tc.GetAllTheaters());
        }
        private void FormSessionAdd_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();
            cmbMovie.SelectedIndex = -1;
            cmbSeance.SelectedIndex= - 1;
            cmbTheater.SelectedIndex = -1;
            dtpShowDate.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dto = new SessionDTO();
            MovieDTO mdto = cmbMovie.SelectedItem as MovieDTO;
            SeanceDTO sdto = cmbSeance.SelectedItem as SeanceDTO;
            TheaterDTO tdto = cmbTheater.SelectedItem as TheaterDTO;
            
            dto.MovieId = mdto.Id;
            dto.SeanceId = sdto.Id;
            dto.TheaterId = tdto.Id;
            DateTime showDate = dtpShowDate.Value.Date;
            dto.ShowDate = showDate;
            dto.StartTime = sdto.StartTime; 
            dto.FinishTime = sdto.FinishTime;
            dto.TheaterName = tdto.TheaterName;
            dto.MovieName = mdto.MovieName;
            var result = _ssc.SessionAdd(dto);
            result.NotificationShow();
            SessionAddded.Raise();
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieDTO mdto = cmbMovie.SelectedItem as MovieDTO;

        }
    }
}
