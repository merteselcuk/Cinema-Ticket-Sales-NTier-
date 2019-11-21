using Cinema.BLL;
using Cinema.DTO;
using Framework.Core;
using Framework.WinForm;
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
    public partial class FormDirectorUpdate : Form
    {
        public static Event1 DirectorUpdated;
        DirectorDTO _director;
        DirectorController _dc;
        //public static event Event1 DirectorUpdated;
        public FormDirectorUpdate(DirectorDTO director)
        {
            InitializeComponent();
            _director = director;
            _dc = new DirectorController();
        }

        private void FormDirectorUpdate_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = _director.FirstName;
            txtLastName.Text = _director.LastName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (!TextBoxExtension.NotNullOrWhiteSpace(txtFirstName, "Yönetmen ad bilgisi boş geçilemez!"))
            {
                return;
            }

            if (!TextBoxExtension.NotNullOrWhiteSpace(txtLastName, "Yönetmen soyad bilgisi boş geçilemez!"))
            {
                return;
            }
            #endregion

            _director.FirstName = txtFirstName.Text;
            _director.LastName = txtLastName.Text;

            var result = _dc.DirectorUpdate(_director);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                DirectorUpdated.Raise();
                this.Close();
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                            && !char.IsSeparator(e.KeyChar);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                            && !char.IsSeparator(e.KeyChar);
        }
    }
}
