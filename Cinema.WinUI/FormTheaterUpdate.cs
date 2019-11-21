using Cinema.BLL;
using Cinema.DTO;
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
    public partial class FormTheaterUpdate : Form
    {
        TheaterDTO _dto;
        TheaterController _tc;
        public static Event1 TheaterUpdated;
        public FormTheaterUpdate(TheaterDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            _tc = new TheaterController();
        }

        private void FormTheaterUpdate_Load(object sender, EventArgs e)
        {
            txtTheaterName.Text = _dto.TheaterName;
            chbActive.Checked = _dto.IsActive;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(txtTheaterName.Text))
            {
                MessageBox.Show("Salon adı alanı boş bırakılamaz.");
                return;
            }
            #endregion
            _dto.TheaterName = txtTheaterName.Text.Trim();
            _dto.IsActive = chbActive.Checked;
            var result = _tc.UpdateTheater(_dto);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                TheaterUpdated.Raise();
            }
        }
    }
}
