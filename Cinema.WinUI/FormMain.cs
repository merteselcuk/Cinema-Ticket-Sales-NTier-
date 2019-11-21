using Cinema.WinUI;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        
        private void biletKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormTicketAdd>();
        }

        private void filmListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormMovieAdd>();
        }

        private void filmListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormMovieList>();
        }

        private void oyuncuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormCastAdd>();
        }

        private void oyuncuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormCastList>();
        }

        private void yönetmenEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormDirectorAdd>();
        }

        private void seansEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormSeanceAdd>();
        }

        private void TsbChangeUser_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }

        private void TsbQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormUserAdd>();
        }

        private void KullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormUserList>();
        }

        private void ŞifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormPasswordChange>();
        }

        private void seansListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormSeanceList>();
        }

        private void yönetmenListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormDirectorList>();
        }

        private void SalonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormTheaterAdd>();
        }

        private void SalonlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormTheaterList>();
        }

        private void OturumEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormSessionAdd>();
        }

        private void OturumListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormSessionList>();
        }

        private void filmAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFormChild<FormCinemaHomePage>();
        }
    }
}
