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

namespace CinemaSeans.UI
{
    public partial class FormUserAdd : Form
    {
        public static Event1 UserAdded;
        UserController _uc;
        public FormUserAdd()
        {
            InitializeComponent();
            _uc = new UserController();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtUserName.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş girilemez.");
                return;
            }
            #endregion
            UserDTO dto = new UserDTO()
            {
                UserName = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            var result = _uc.UserAdd(dto, cmbRole.SelectedItem as RoleDTO);
            result.NotificationShow();
            if (result.State==ResultState.Success)
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                UserAdded.Raise();
            }
            
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            LoadComboboxRoles();
        }
        private void LoadComboboxRoles()
        {
            List<RoleDTO> dtos = _uc.GetAllRoles();
            cmbRole.DataSource = null;
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "Id";
            cmbRole.DataSource = dtos;
        }
    }
}
