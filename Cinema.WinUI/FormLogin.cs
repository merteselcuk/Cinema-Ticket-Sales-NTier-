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
    public partial class FormLogin : Form
    {
        UserController _uc;
        public FormLogin()
        {
            InitializeComponent();
            _uc = new UserController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtUserName.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı Adı ve Parola Alanları Bos Bırakılamaz");
                return;
            }
            #endregion
            UserDTO dto = new UserDTO()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            UserDTO result = _uc.SearchUser(dto);
            if (result!=null)
            {
                FormMain frm = new FormMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı.");
            }
        }
    }
}
