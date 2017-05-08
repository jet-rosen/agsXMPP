namespace Form02.UI.Login.Pages
{
    partial class Frame_Forgotpwd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame_Forgotpwd));
            this.btn_send = new MonoFlat.MonoFlat_Button2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_userid = new MonoFlat.MonoFlat_TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_send.Image = null;
            this.btn_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_send.Location = new System.Drawing.Point(269, 320);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(146, 41);
            this.btn_send.TabIndex = 13;
            this.btn_send.Text = "Send";
            this.btn_send.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // text_userid
            // 
            this.text_userid.BackColor = System.Drawing.Color.Transparent;
            this.text_userid.Font = new System.Drawing.Font("Tahoma", 11F);
            this.text_userid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.text_userid.Image = null;
            this.text_userid.Location = new System.Drawing.Point(220, 190);
            this.text_userid.MaxLength = 32767;
            this.text_userid.Multiline = false;
            this.text_userid.Name = "text_userid";
            this.text_userid.ReadOnly = false;
            this.text_userid.Size = new System.Drawing.Size(282, 41);
            this.text_userid.TabIndex = 9;
            this.text_userid.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_userid.UseSystemPasswordChar = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_back.Location = new System.Drawing.Point(3, 454);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(124, 26);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Frame_Forgotpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_userid);
            this.Name = "Frame_Forgotpwd";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_Button2 btn_send;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MonoFlat.MonoFlat_TextBox text_userid;
        private System.Windows.Forms.Button btn_back;
    }
}
