using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public static class ListBoxExtension
    {
        public static void SelectedControl(this ListBox listBox)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Öncelikle bir kayıt seçmelisiniz!");
                return;
            }
        }

        public static void DataSourceMember<TList>(this ListControl control, string displayMember, string valueMember, TList dto)
            where TList : IList
        {
            control.DataSource = null;
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = dto;
        }
    }
}
