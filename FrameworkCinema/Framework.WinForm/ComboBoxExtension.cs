using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public static class ComboBoxExtension
    {
        public static void FillComboBox<TEnum>(this ComboBox comboBox)
        {
            comboBox.Items.Clear();
            if (!typeof(TEnum).IsEnum)
            {
                throw new Exception("Bu metod ile ComboBox'ı sadece enum tipindeki öğelerle doldurabilirsiniz!");
            }

            var enums = (TEnum[])Enum.GetValues(typeof(TEnum));

            foreach (var item in enums)
            {
                comboBox.Items.Add(item);
            }
        }

        public static bool NotNullOrWhiteSpace<TComboBox>(TComboBox comboBox, string message)
            where TComboBox : ComboBox
        {
            bool isNotNullOrWhiteSpace = true;
            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                isNotNullOrWhiteSpace = false;
                MessageBox.Show(message);
            }
            return isNotNullOrWhiteSpace;
        }
    }
}
