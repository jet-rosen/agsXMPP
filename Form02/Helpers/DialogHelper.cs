using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Form02.Helpers
{
    class DialogHelper
    {

        public static void showMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }


    }
}
