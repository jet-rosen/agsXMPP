namespace Form02
{
    partial class Form1
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
            this.monoFlat_Toggle1 = new MonoFlat.MonoFlat_Toggle();
            this.monoFlat_RadioButton1 = new MonoFlat.MonoFlat_RadioButton();
            this.monoFlat_CheckBox1 = new MonoFlat.MonoFlat_CheckBox();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_TextBox1 = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Button21 = new MonoFlat.MonoFlat_Button2();
            this.SuspendLayout();
            // 
            // monoFlat_Toggle1
            // 
            this.monoFlat_Toggle1.Location = new System.Drawing.Point(177, 388);
            this.monoFlat_Toggle1.Name = "monoFlat_Toggle1";
            this.monoFlat_Toggle1.Size = new System.Drawing.Size(76, 33);
            this.monoFlat_Toggle1.TabIndex = 4;
            this.monoFlat_Toggle1.Text = "monoFlat_Toggle1";
            this.monoFlat_Toggle1.Toggled = false;
            this.monoFlat_Toggle1.Type = MonoFlat.MonoFlat_Toggle._Type.CheckMark;
            // 
            // monoFlat_RadioButton1
            // 
            this.monoFlat_RadioButton1.Checked = false;
            this.monoFlat_RadioButton1.Location = new System.Drawing.Point(32, 315);
            this.monoFlat_RadioButton1.Name = "monoFlat_RadioButton1";
            this.monoFlat_RadioButton1.Size = new System.Drawing.Size(153, 17);
            this.monoFlat_RadioButton1.TabIndex = 3;
            this.monoFlat_RadioButton1.Text = "monoFlat_RadioButton1";
            // 
            // monoFlat_CheckBox1
            // 
            this.monoFlat_CheckBox1.Checked = false;
            this.monoFlat_CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.monoFlat_CheckBox1.Location = new System.Drawing.Point(110, 107);
            this.monoFlat_CheckBox1.Name = "monoFlat_CheckBox1";
            this.monoFlat_CheckBox1.Size = new System.Drawing.Size(148, 16);
            this.monoFlat_CheckBox1.TabIndex = 2;
            this.monoFlat_CheckBox1.Text = "monoFlat_CheckBox1";
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(249, 281);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(175, 73);
            this.monoFlat_Button1.TabIndex = 1;
            this.monoFlat_Button1.Text = "monoFlat_Button1";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // monoFlat_TextBox1
            // 
            this.monoFlat_TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_TextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.monoFlat_TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.monoFlat_TextBox1.Image = null;
            this.monoFlat_TextBox1.Location = new System.Drawing.Point(177, 172);
            this.monoFlat_TextBox1.MaxLength = 32767;
            this.monoFlat_TextBox1.Multiline = false;
            this.monoFlat_TextBox1.Name = "monoFlat_TextBox1";
            this.monoFlat_TextBox1.ReadOnly = false;
            this.monoFlat_TextBox1.Size = new System.Drawing.Size(311, 41);
            this.monoFlat_TextBox1.TabIndex = 0;
            this.monoFlat_TextBox1.Text = "monoFlat_TextBox1";
            this.monoFlat_TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.monoFlat_TextBox1.UseSystemPasswordChar = false;
            // 
            // monoFlat_Button21
            // 
            this.monoFlat_Button21.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button21.Image = null;
            this.monoFlat_Button21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button21.Location = new System.Drawing.Point(430, 281);
            this.monoFlat_Button21.Name = "monoFlat_Button21";
            this.monoFlat_Button21.Size = new System.Drawing.Size(171, 73);
            this.monoFlat_Button21.TabIndex = 5;
            this.monoFlat_Button21.Text = "monoFlat_Button21";
            this.monoFlat_Button21.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.monoFlat_Button21);
            this.Controls.Add(this.monoFlat_Toggle1);
            this.Controls.Add(this.monoFlat_RadioButton1);
            this.Controls.Add(this.monoFlat_CheckBox1);
            this.Controls.Add(this.monoFlat_Button1);
            this.Controls.Add(this.monoFlat_TextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_TextBox monoFlat_TextBox1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private MonoFlat.MonoFlat_CheckBox monoFlat_CheckBox1;
        private MonoFlat.MonoFlat_RadioButton monoFlat_RadioButton1;
        private MonoFlat.MonoFlat_Toggle monoFlat_Toggle1;
        private MonoFlat.MonoFlat_Button2 monoFlat_Button21;
    }
}

