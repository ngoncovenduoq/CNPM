namespace Project_CNPM
{
    partial class Rec_Check
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rec_Check));
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.accept = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnScheduleAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelTopLeft.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.accept);
            this.panelTopLeft.Controls.Add(this.btnAddPatient);
            this.panelTopLeft.Controls.Add(this.tbSearch);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopLeft.Location = new System.Drawing.Point(418, 0);
            this.panelTopLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(969, 78);
            this.panelTopLeft.TabIndex = 0;
            // 
            // accept
            // 
            this.accept.BorderRadius = 10;
            this.accept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.accept.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.ForeColor = System.Drawing.Color.White;
            this.accept.Image = global::Project_CNPM.Properties.Resources._checked;
            this.accept.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.accept.Location = new System.Drawing.Point(775, 13);
            this.accept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(182, 59);
            this.accept.TabIndex = 11;
            this.accept.Text = "Xác nhận";
            this.accept.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BorderRadius = 10;
            this.btnAddPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Image = global::Project_CNPM.Properties.Resources.add1;
            this.btnAddPatient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddPatient.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAddPatient.Location = new System.Drawing.Point(738, 13);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(219, 59);
            this.btnAddPatient.TabIndex = 10;
            this.btnAddPatient.Text = "Thêm bệnh nhân mới";
            this.btnAddPatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.IconRight = global::Project_CNPM.Properties.Resources.search;
            this.tbSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.tbSearch.IconRightSize = new System.Drawing.Size(15, 15);
            this.tbSearch.Location = new System.Drawing.Point(390, 13);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbSearch.PlaceholderText = "Tìm kiếm";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(329, 57);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnScheduleAppointment
            // 
            this.btnScheduleAppointment.BorderRadius = 10;
            this.btnScheduleAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScheduleAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScheduleAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScheduleAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScheduleAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.btnScheduleAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnScheduleAppointment.Image = global::Project_CNPM.Properties.Resources.timetable1;
            this.btnScheduleAppointment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnScheduleAppointment.ImageSize = new System.Drawing.Size(25, 25);
            this.btnScheduleAppointment.Location = new System.Drawing.Point(12, 9);
            this.btnScheduleAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScheduleAppointment.Name = "btnScheduleAppointment";
            this.btnScheduleAppointment.Size = new System.Drawing.Size(179, 59);
            this.btnScheduleAppointment.TabIndex = 7;
            this.btnScheduleAppointment.Text = "Chọn lịch hẹn";
            this.btnScheduleAppointment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnScheduleAppointment.Click += new System.EventHandler(this.btnScheduleAppointment_Click);
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.btnScheduleAppointment);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTopRight.Location = new System.Drawing.Point(0, 0);
            this.panelTopRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(203, 78);
            this.panelTopRight.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTopRight);
            this.panel1.Controls.Add(this.panelTopLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 78);
            this.panel1.TabIndex = 4;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.guna2DataGridView1);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 78);
            this.panelShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1387, 852);
            this.panelShow.TabIndex = 11;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1387, 852);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Rec_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 930);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rec_Check";
            this.Text = "Rec_Check";
            this.Load += new System.EventHandler(this.BS_Treatment_Load);
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopLeft;
        private Guna.UI2.WinForms.Guna2Button btnScheduleAppointment;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
        private System.Windows.Forms.Panel panelShow;
        private Guna.UI2.WinForms.Guna2Button accept;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
    }
}