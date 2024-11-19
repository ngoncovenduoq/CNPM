using System.Windows.Forms;

namespace Project_CNPM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.eye2 = new System.Windows.Forms.PictureBox();
            this.eye1 = new System.Windows.Forms.PictureBox();
            this.linkForgotPas = new System.Windows.Forms.LinkLabel();
            this.rememberPas = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.textPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textLogin = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.eye2);
            this.panelForm.Controls.Add(this.eye1);
            this.panelForm.Controls.Add(this.linkForgotPas);
            this.panelForm.Controls.Add(this.rememberPas);
            this.panelForm.Controls.Add(this.buttonLogin);
            this.panelForm.Controls.Add(this.textPassword);
            this.panelForm.Controls.Add(this.textLogin);
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(832, 477);
            this.panelForm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 37;
            this.label1.Text = "Đăng nhập";
            // 
            // eye2
            // 
            this.eye2.Image = ((System.Drawing.Image)(resources.GetObject("eye2.Image")));
            this.eye2.Location = new System.Drawing.Point(669, 282);
            this.eye2.Margin = new System.Windows.Forms.Padding(4);
            this.eye2.Name = "eye2";
            this.eye2.Size = new System.Drawing.Size(53, 23);
            this.eye2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eye2.TabIndex = 35;
            this.eye2.TabStop = false;
            this.eye2.Click += new System.EventHandler(this.eye2_Click);
            // 
            // eye1
            // 
            this.eye1.Image = ((System.Drawing.Image)(resources.GetObject("eye1.Image")));
            this.eye1.Location = new System.Drawing.Point(669, 282);
            this.eye1.Margin = new System.Windows.Forms.Padding(4);
            this.eye1.Name = "eye1";
            this.eye1.Size = new System.Drawing.Size(53, 23);
            this.eye1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eye1.TabIndex = 34;
            this.eye1.TabStop = false;
            this.eye1.Click += new System.EventHandler(this.eye1_Click);
            // 
            // linkForgotPas
            // 
            this.linkForgotPas.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkForgotPas.AutoSize = true;
            this.linkForgotPas.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkForgotPas.LinkColor = System.Drawing.Color.Black;
            this.linkForgotPas.Location = new System.Drawing.Point(611, 338);
            this.linkForgotPas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkForgotPas.Name = "linkForgotPas";
            this.linkForgotPas.Size = new System.Drawing.Size(122, 16);
            this.linkForgotPas.TabIndex = 33;
            this.linkForgotPas.TabStop = true;
            this.linkForgotPas.Text = "Khôi phục mật khẩu";
            this.linkForgotPas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPas_LinkClicked);
            // 
            // rememberPas
            // 
            this.rememberPas.AutoSize = true;
            this.rememberPas.Location = new System.Drawing.Point(452, 338);
            this.rememberPas.Margin = new System.Windows.Forms.Padding(4);
            this.rememberPas.Name = "rememberPas";
            this.rememberPas.Size = new System.Drawing.Size(111, 20);
            this.rememberPas.TabIndex = 31;
            this.rememberPas.Text = "Nhớ mật khẩu";
            this.rememberPas.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BorderRadius = 12;
            this.buttonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(452, 378);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(281, 45);
            this.buttonLogin.TabIndex = 28;
            this.buttonLogin.Text = "ĐĂNG NHẬP";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textPassword
            // 
            this.textPassword.BorderColor = System.Drawing.Color.Gray;
            this.textPassword.BorderRadius = 12;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.DefaultText = "";
            this.textPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPassword.ForeColor = System.Drawing.Color.Black;
            this.textPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.Location = new System.Drawing.Point(453, 272);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textPassword.PlaceholderText = "Mật khẩu";
            this.textPassword.SelectedText = "";
            this.textPassword.Size = new System.Drawing.Size(281, 48);
            this.textPassword.TabIndex = 27;
            // 
            // textLogin
            // 
            this.textLogin.BorderColor = System.Drawing.Color.Gray;
            this.textLogin.BorderRadius = 12;
            this.textLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLogin.DefaultText = "";
            this.textLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textLogin.ForeColor = System.Drawing.Color.Black;
            this.textLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLogin.Location = new System.Drawing.Point(452, 216);
            this.textLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textLogin.Name = "textLogin";
            this.textLogin.PasswordChar = '\0';
            this.textLogin.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textLogin.PlaceholderText = "Tên đăng nhập/ Email";
            this.textLogin.SelectedText = "";
            this.textLogin.Size = new System.Drawing.Size(282, 48);
            this.textLogin.TabIndex = 25;
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(832, 477);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye1)).EndInit();
            this.ResumeLayout(false);

        }
        private PictureBox pictureBox1;
        private Panel panelForm;
        private PictureBox eye1;
        private LinkLabel linkForgotPas;
        private CheckBox rememberPas;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
        private Guna.UI2.WinForms.Guna2TextBox textPassword;
        private Guna.UI2.WinForms.Guna2TextBox textLogin;
        private PictureBox eye2;
        private Label label1;

        #endregion
        //ẩn mật khẩu
    }
}

