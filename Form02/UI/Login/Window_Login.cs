using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Form02.UI.Components;
using Form02.UI.Main;
using Form02.Helpers;
using Form02.Global;
using System.Threading;

namespace Form02.UI.Login
{
    public partial class Window_Login : Form
    {
        enum PAGE_TYPE {
            PAGE_SIGNIN = 0,
            PAGE_SIGNUP,
            PAGE_FORGOT
        };

        public Window_Login()
        {
            InitializeComponent();

            initPanels();

            AppInfo appInfo = AppInfo.Instance();

        }

        private void initPanels()
        {
            showPage(PAGE_TYPE.PAGE_SIGNIN);

            frame_login.OnLoginClick += onSiginClick;
            frame_login.OnGoForgotClick += onGoForgotClick;
            frame_login.OnGoRegisterClick += onGoRegisterClick;

            frame_forgot.OnSendClick += onForgotSendClick;
            frame_forgot.OnGoBackClick += onForgotBackClick;

            frame_register.OnSignupClick += onSignupClick;
            frame_register.OnGoBackClick += onSignupBackClick;
        }

        private void onSiginClick(object sender, EventArgs e)
        {
            
            //var main_window = new Window_Main();
            //main_window.Show();
            //this.Hide();
        }

        private void onGoRegisterClick(object sender, EventArgs e)
        {
            showPage(PAGE_TYPE.PAGE_SIGNUP);
        }

        private void onGoForgotClick(object sender, EventArgs e)
        {
            showPage(PAGE_TYPE.PAGE_FORGOT);
        }

        private void onSignupClick(object sender, EventArgs e)
        {
            showPage(PAGE_TYPE.PAGE_SIGNIN);
        }

        private void onSignupBackClick(object sender, EventArgs e)
        {
            showPage(PAGE_TYPE.PAGE_SIGNIN);
        }

        private void onForgotSendClick(object sender, EventArgs e)
        {

        }

        private void onForgotBackClick(object sender, EventArgs e)
        {
            showPage(PAGE_TYPE.PAGE_SIGNIN);
        }

        private void showPage(PAGE_TYPE page)
        {
            switch (page)
            {
                case PAGE_TYPE.PAGE_SIGNIN:
                    frame_login.Show();
                    frame_forgot.Hide();
                    frame_register.Hide();
                    break;
                case PAGE_TYPE.PAGE_SIGNUP:
                    frame_login.Hide();
                    frame_forgot.Hide();
                    frame_register.Show();
                    break;
                case PAGE_TYPE.PAGE_FORGOT:
                    frame_login.Hide();
                    frame_forgot.Show();
                    frame_register.Hide();
                    break;

            }
        }

    }
}
