using Cinema.BLL;
using Cinema.DTO;
using CinemaSeans.UI;
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
    public partial class FormSessionList : Form
    {
        SessionController _sc;
        public static Event1 SessionDeleted;
        public FormSessionList()
        {
            InitializeComponent();
            _sc = new SessionController();
            FormSessionAdd.SessionAddded += ListLoad;
            FormSessionUpdate.SessionUpdated += ListLoad;
            FormSessionList.SessionDeleted += ListLoad;
        }

        private void FormSessionList_Load(object sender, EventArgs e)
        {
            ListLoad();
        }
        private void ListLoad()
        {
            
            ListBoxExtension.DataSourceMember<List<SessionDTO>>(lstSession, "SessionInformation", "Id", _sc.GetAllSession());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var session = (SessionDTO)lstSession.SelectedItem;
            var result = _sc.SessionDelete(session);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                ListLoad();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstSession.SelectedIndex == -1)
            {
                MessageBox.Show("Bir oturum seçmelisiniz.");
            }
            var session = (SessionDTO)lstSession.SelectedItem;
            FormExtension.MdiBroShow<FormSessionUpdate, SessionDTO>(this, session);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.ShowFormBro<FormSessionAdd>();
        }
    }
}
