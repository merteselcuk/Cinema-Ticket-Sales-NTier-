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
    public partial class FormUserUpdate : Form
    {
        UserDTO _dto;
        UserController _uc;
        public static Event1 UserUpdated;
        public FormUserUpdate(UserDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            _uc = new UserController();

        }

        private void FormUserUpdate_Load(object sender, EventArgs e)
        {
            LoadComboboxRoles();
            txtUserName.Text = _dto.UserName;
            txtPassword.Text = _dto.Password;
            chbActive.Checked = _dto.IsActive;
            cmbRole.SelectedValue = _dto.Roles.SingleOrDefault().Id;
            
        }
        private void LoadComboboxRoles()
        {
            List<RoleDTO> dtos = _uc.GetAllRoles();
            cmbRole.DataSource = null;
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "Id";
            cmbRole.DataSource = dtos;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtUserName.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş girilemez.");
                return;
            }
            #endregion
            _dto.UserName = txtUserName.Text.Trim();
            _dto.Password = txtPassword.Text.Trim();
            _dto.IsActive = chbActive.Checked;
            _dto.Roles.Clear();
            _dto.Roles.Add(cmbRole.SelectedItem as RoleDTO);
            var result = _uc.UpdatedUser(_dto);
            result.NotificationShow();
            if (result.State==ResultState.Success)
            {
                
                UserUpdated.Raise();
            }
        }
    }
}
