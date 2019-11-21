using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.WinForm
{
    public static class TextBoxExtension
    {
        public static bool NotNullOrWhiteSpace<TTextBox>(TTextBox textBox, string message)
            where TTextBox : TextBox
        {
            bool isNotNullOrWhiteSpace = true;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                isNotNullOrWhiteSpace = false;
                MessageBox.Show(message);
            }
            return isNotNullOrWhiteSpace;
        }
    }
}
