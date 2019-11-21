using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public static class FormExtension
    {
        public static void ShowFormChild<TForm>(this Form thisFrm)
            where TForm : Form, new()
        {
            TForm frm = new TForm();
            frm.MdiParent = thisFrm;
            frm.Show();
        }
        public static void ShowFormBro<TForm>(this Form thisFrm)
            where TForm : Form, new()
        {
            TForm frm = new TForm();
            frm.MdiParent = thisFrm.MdiParent;
            frm.Show();
        }

        public static void MdiBroShow<TForm, T>(this Form thisFrm, T entity)
            where TForm : Form where T : class, new()
        {
            TForm frm = (TForm)Activator.CreateInstance(typeof(TForm), entity);
            frm.MdiParent = thisFrm.MdiParent;
            frm.Show();
        }
    }
}
