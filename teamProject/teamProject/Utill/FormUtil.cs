using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamProject.Utill
{
    internal class FormUtil
    {
        internal static void setRowColor(ListView list, Color odd, Color even)
        {
            foreach (ListViewItem item in list.Items)
            {
                if (item.Index % 2 == 0)
                {
                    item.BackColor = even;
                }
                else
                {
                    item.BackColor = odd;
                }
            }
        }
    }
}
