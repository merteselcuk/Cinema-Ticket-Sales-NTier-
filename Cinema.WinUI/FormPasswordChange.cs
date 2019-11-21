using Cinema.BLL;
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
    public partial class FormPasswordChange : Form
    {
        UserController _uc;
        public FormPasswordChange()
        {
            InitializeComponent();
            _uc = new UserController();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtOldPass.Text.Trim() ==string.Empty || txtNewPass.Text.Trim() == string.Empty || txtNewPass2.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Eski şifre ve yeni şifre alanları boş geçilemez.");
                return;
            }
            else if (txtOldPass.Text != SessionHelper.CurrentUser.Password.ToString())
            {
                MessageBox.Show("Eski şifre hatalı..");
                return;
            }
            else if (txtNewPass.Text != txtNewPass2.Text)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor.");
                return;
            }

            #endregion
            SessionHelper.CurrentUser.Password = txtNewPass.Text;
            SessionHelper.CurrentUser.IsActive = true;
            var result = _uc.UpdatePassword(SessionHelper.CurrentUser);
            result.NotificationShow();
            if(result.State == ResultState.Success)
            {
                txtOldPass.Text = "";
                txtNewPass.Text = "";
                txtNewPass2.Text = "";
            }

        }
    }
}
