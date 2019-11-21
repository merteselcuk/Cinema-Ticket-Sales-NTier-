using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    public delegate void Event1();
    public delegate void Event2(object sender);

    public static class EventManager
    {
        public static void Raise(this Event1 e)
        {
            try
            {
                e();
            }
            catch (Exception)
            {

            }
        }

        public static void Raise(this Event2 e, object sender)
        {
            try
            {
                e(sender);
            }
            catch (Exception)
            {

            }
        }
    }

}
