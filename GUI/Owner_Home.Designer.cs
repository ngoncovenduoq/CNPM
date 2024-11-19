namespace Project_CNPM
{
    partial class Owner_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_Home));
            this.panelChildForm1 = new System.Windows.Forms.Panel();
            this.btnPatient = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnStaff = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panelChildForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm1
            // 
            this.panelChildForm1.AutoScroll = true;
            this.panelChildForm1.Controls.Add(this.btnPatient);
            this.panelChildForm1.Controls.Add(this.btnStaff);
            this.panelChildForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm1.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm1.Name = "panelChildForm1";
            this.panelChildForm1.Size = new System.Drawing.Size(1116, 731);
            this.panelChildForm1.TabIndex = 10;
            // 
            // btnPatient
            // 
            this.btnPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatient.BackColor = System.Drawing.Color.White;
            this.btnPatient.BorderRadius = 5;
            this.btnPatient.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatient.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.btnPatient.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnPatient.Image = global::Project_CNPM.Properties.Resources.picTtbn;
            this.btnPatient.ImageOffset = new System.Drawing.Point(0, 20);
            this.btnPatient.ImageSize = new System.Drawing.Size(130, 120);
            this.btnPatient.Location = new System.Drawing.Point(223, 372);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPatient.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.btnPatient.Size = new System.Drawing.Size(668, 216);
            this.btnPatient.TabIndex = 21;
            this.btnPatient.Text = "THÔNG TIN BỆNH NHÂN";
            this.btnPatient.TextOffset = new System.Drawing.Point(0, 10);
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStaff.BackColor = System.Drawing.SystemColors.Control;
            this.btnStaff.BorderRadius = 5;
            this.btnStaff.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(203)))), ((int)(((byte)(236)))));
            this.btnStaff.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(203)))), ((int)(((byte)(236)))));
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnStaff.Image = global::Project_CNPM.Properties.Resources.picTtnv;
            this.btnStaff.ImageOffset = new System.Drawing.Point(0, 20);
            this.btnStaff.ImageSize = new System.Drawing.Size(130, 120);
            this.btnStaff.Location = new System.Drawing.Point(223, 85);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStaff.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.btnStaff.Size = new System.Drawing.Size(668, 211);
            this.btnStaff.TabIndex = 20;
            this.btnStaff.Text = "THÔNG TIN NHÂN VIÊN";
            this.btnStaff.TextOffset = new System.Drawing.Point(0, 10);
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // Owner_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 731);
            this.Controls.Add(this.panelChildForm1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Owner_Home";
            this.Text = "Owner_Home";
            this.panelChildForm1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnPatient;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnStaff;
    }
}