using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Form02.UI.Components;
using Form02.Api;
using Form02.Api.ResponseModels;
using Newtonsoft.Json;
using Form02.Helpers;
using Form02.Xmpp;
using System.Threading;

namespace Form02.UI.Login.Pages
{
    public partial class Frame_Login : UserControl
    {
        public static string TAG = "PAGE_LOGIN";

        public event EventHandler OnLoginClick;
        public event EventHandler OnGoRegisterClick;
        public event EventHandler OnGoForgotClick;
        
        public Frame_Login()
        {
            InitializeComponent();
        }
        

        async private void btn_signin_Click(object sender, EventArgs e)
        {
            /*
            using (WaitingDialog waitingDlg = new WaitingDialog(working))
            {
                waitingDlg.ShowDialog(this);
            }
            return;
            */

            var res_body = await ApiManager.api_user_signin(text_userid.Text.Trim(), text_pwd.Text);

            try
            {
                CallResponse callres = JsonConvert.DeserializeObject<CallResponse>(res_body);
                LogHelper.LogConsole(TAG, callres.result + " " + callres.msg + " " + callres.data);

                //XmClient xmConn = XmClient.Instance();
                //xmConn.ConnectXm(text_userid.Text.Trim(), text_pwd.Text);

                if (callres.result == "success")
                {
                    OnLoginClick?.Invoke(callres.result, e);
                }
                else
                {
                    MessageBox.Show(callres.msg, "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                LogHelper.LogConsole(TAG, "parsing response error : " + res_body);
            }
            
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            OnGoRegisterClick?.Invoke(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnGoForgotClick?.Invoke(sender, e);
        }
    }
}

