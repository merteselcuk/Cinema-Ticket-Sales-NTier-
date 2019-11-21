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

namespace Cinema.WinUI
{
    public partial class FormSessionUpdate : Form
    {
        MovieController _mc;
        SeanceController _sc;
        TheaterController _tc;
        SessionController _ssc;
        SessionDTO _session;
        public static Event1 SessionUpdated;
        public FormSessionUpdate(SessionDTO session)
        {
            InitializeComponent();
            _mc = new MovieController();
            _sc = new SeanceController();
            _tc = new TheaterController();
            _ssc = new SessionController();
            _session = session;
        }
        private void ComboBoxLoad()
        {
            ListBoxExtension.DataSourceMember<List<MovieDTO>>(cmbMovie, "MovieName", "Id", _mc.GetAllMovies());
            ListBoxExtension.DataSourceMember<List<SeanceDTO>>(cmbSeance, "SeanceInformation", "Id", _sc.GetAllSeance());
            ListBoxExtension.DataSourceMember<List<TheaterDTO>>(cmbTheater, "TheaterName", "Id", _tc.GetAllTheaters());
            
        }
        private void FormSessionUpdate_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();

            cmbMovie.SelectedIndex = cmbMovie.FindStringExact(_session.MovieName);
            cmbTheater.SelectedIndex = cmbTheater.FindStringExact(_session.TheaterName);
            cmbSeance.SelectedIndex = cmbSeance.FindStringExact(_session.SeanceInformation);
            dtpShowDate.Value = _session.ShowDate;
            chbIsActive.Checked = _session.IsActive;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MovieDTO mdto = cmbMovie.SelectedItem as MovieDTO;
            SeanceDTO sdto = cmbSeance.SelectedItem as SeanceDTO;
            TheaterDTO tdto = cmbTheater.SelectedItem as TheaterDTO;

            _session.MovieId = mdto.Id;
            _session.SeanceId = sdto.Id;
            _session.TheaterId = tdto.Id;
            DateTime showDate = dtpShowDate.Value.Date;
            _session.ShowDate = showDate;
            _session.StartTime = sdto.StartTime;
            _session.FinishTime = sdto.FinishTime;
            _session.TheaterName = tdto.TheaterName;
            _session.MovieName = mdto.MovieName;
            _session.IsActive = chbIsActive.Checked;

            var result = _ssc.SessionUpdate(_session);
            result.NotificationShow();
            SessionUpdated.Raise();
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
