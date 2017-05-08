using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Form02.Helpers;
using Form02.Api;
using Form02.Api.ResponseModels;
using Newtonsoft.Json;


namespace Form02.UI.Login.Pages
{
    public partial class Frame_Register : UserControl
    {
        public static string TAG = "PAGE_SIGNUP";

        public event EventHandler OnSignupClick;
        public event EventHandler OnGoBackClick;

        public Frame_Register()
        {
            InitializeComponent();
            
        }

        void clearFields()
        {
            text_username.Text = "";
            text_userid.Text = "";
            text_pwd.Text = "";
            text_password2.Text = "";
        }

        async private void btn_signup_Click(object sender, EventArgs e)
        {
            if (text_username.Text.Length == 0)
            {
                DialogHelper.showMessage("Please enter your name", "Notice");
                return;
            }
            string idType = EmailPhoneHelper.getProfileType(text_userid.Text);
            if (idType == "0")
            {
                DialogHelper.showMessage("EmailAddress or Phone number format is invalid.", "Notice");
                return;
            }
            if (text_pwd.Text.Length == 0)
            {
                DialogHelper.showMessage("Please enter your password", "Notice");
                return;
            }
            if (text_pwd.Text != text_password2.Text)
            {
                DialogHelper.showMessage("Password does not match", "Notice");
                return;
            }

            var res_body = await ApiManager.api_user_signup(text_username.Text, text_userid.Text, text_pwd.Text, idType);

            try
            {
                CallResponse callres = JsonConvert.DeserializeObject<CallResponse>(res_body);
                LogHelper.LogConsole(TAG, callres.result + " " + callres.msg + " " + callres.data);

                //XmClient xmConn = XmClient.Instance();
                //xmConn.ConnectXm(text_userid.Text.Trim(), text_pwd.Text);

                if (callres.result == "success")
                {
                    MessageBox.Show(callres.msg, "SignUp Success");
                    OnSignupClick?.Invoke(callres.result, e);
                    clearFields();
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            OnGoBackClick?.Invoke(sender, e);
            clearFields();
        }
    }
}
