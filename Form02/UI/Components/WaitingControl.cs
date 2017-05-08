using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form02.UI.Components
{
    public partial class WaitingControl : UserControl
    {
        public WaitingControl()
        {
            InitializeComponent();
        }

        public WaitingControl(string label)
        {
            InitializeComponent();
            label1.Text = label;
        }


    }
}
