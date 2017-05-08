namespace Form02.UI.Login
{
    partial class Window_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frame_register = new Form02.UI.Login.Pages.Frame_Register();
            this.frame_forgot = new Form02.UI.Login.Pages.Frame_Forgotpwd();
            this.frame_login = new Form02.UI.Login.Pages.Frame_Login();
            this.SuspendLayout();
            // 
            // frame_register
            // 
            this.frame_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.frame_register.Location = new System.Drawing.Point(-9, -31);
            this.frame_register.Name = "frame_register";
            this.frame_register.Size = new System.Drawing.Size(700, 500);
            this.frame_register.TabIndex = 2;
            this.frame_register.UseWaitCursor = true;
            // 
            // frame_forgot
            // 
            this.frame_forgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.frame_forgot.Location = new System.Drawing.Point(-9, -31);
            this.frame_forgot.Name = "frame_forgot";
            this.frame_forgot.Size = new System.Drawing.Size(700, 500);
            this.frame_forgot.TabIndex = 1;
            // 
            // frame_login
            // 
            this.frame_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.frame_login.Location = new System.Drawing.Point(-9, -31);
            this.frame_login.Name = "frame_login";
            this.frame_login.Size = new System.Drawing.Size(700, 500);
            this.frame_login.TabIndex = 0;
            // 
            // Window_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.frame_register);
            this.Controls.Add(this.frame_forgot);
            this.Controls.Add(this.frame_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window_Login";
            this.ResumeLayout(false);

        }

        #endregion

        private Pages.Frame_Login frame_login;
        private Pages.Frame_Forgotpwd frame_forgot;
        private Pages.Frame_Register frame_register;
    }
}