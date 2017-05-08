using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form02.UI.Login.Pages
{
    public partial class Frame_Forgotpwd : UserControl
    {
        public event EventHandler OnSendClick;
        public event EventHandler OnGoBackClick;

        public Frame_Forgotpwd()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            OnSendClick?.Invoke(sender, e);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            OnGoBackClick?.Invoke(sender, e);
            text_userid.Text = "";
        }
    }
}


