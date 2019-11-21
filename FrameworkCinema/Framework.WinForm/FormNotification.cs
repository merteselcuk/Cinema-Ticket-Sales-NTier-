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

namespace Framework.WinForm
{
    public partial class FormNotification : Form
    {
        public FormNotification(ServiceResult result)
        {
            InitializeComponent();

            lblNotification.Text = result.Message;

            switch (result.State)
            {
                case ResultState.Success:
                    BackColor = Color.LightGreen;
                    lblNotification.ForeColor = Color.Blue;
                    break;
                case ResultState.Warning:
                    BackColor = Color.LightYellow;
                    lblNotification.ForeColor = Color.Black;
                    break;
                case ResultState.Error:
                    BackColor = Color.DarkGray;
                    lblNotification.ForeColor = Color.DarkRed;
                    break;
                default:
                    break;
            }
        }

        private void FormNotification_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
