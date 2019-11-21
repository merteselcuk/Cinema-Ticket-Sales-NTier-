using Framework.Core;
using Framework.WinForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public static class NotificationExtension
    {
        public static void NotificationShow(this ServiceResult result)
        {
            FormNotification frm = new FormNotification(result);
            frm.Show();
        }
    }
}