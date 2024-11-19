namespace Project_CNPM
{
    partial class Rec_AddAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rec_AddAppointment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbForm = new System.Windows.Forms.Label();
            this.panelSTT = new System.Windows.Forms.Panel();
            this.dateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.doctor = new Guna.UI2.WinForms.Guna2Button();
            this.ca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.benhnhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.lbDoctor = new System.Windows.Forms.Label();
            this.lbWork = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbPatient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTreatment = new System.Windows.Forms.Panel();
            this.STT = new Guna.UI2.WinForms.Guna2Button();
            this.dichvu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lbSTT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinished = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelSTT.SuspendLayout();
            this.panelTreatment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(776, 430);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbForm
            // 
            this.lbForm.AutoSize = true;
            this.lbForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.lbForm.Location = new System.Drawing.Point(12, 9);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(250, 41);
            this.lbForm.TabIndex = 3;
            this.lbForm.Text = "THÊM LỊCH HẸN";
            // 
            // panelSTT
            // 
            this.panelSTT.BackColor = System.Drawing.Color.White;
            this.panelSTT.Controls.Add(this.dateTime);
            this.panelSTT.Controls.Add(this.doctor);
            this.panelSTT.Controls.Add(this.ca);
            this.panelSTT.Controls.Add(this.benhnhan);
            this.panelSTT.Controls.Add(this.btnDone);
            this.panelSTT.Controls.Add(this.lbDoctor);
            this.panelSTT.Controls.Add(this.lbWork);
            this.panelSTT.Controls.Add(this.lbDate);
            this.panelSTT.Controls.Add(this.lbPatient);
            this.panelSTT.Controls.Add(this.label2);
            this.panelSTT.Location = new System.Drawing.Point(12, 78);
            this.panelSTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSTT.Name = "panelSTT";
            this.panelSTT.Size = new System.Drawing.Size(365, 289);
            this.panelSTT.TabIndex = 4;
            // 
            // dateTime
            // 
            this.dateTime.Checked = true;
            this.dateTime.FillColor = System.Drawing.Color.White;
            this.dateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTime.Location = new System.Drawing.Point(109, 92);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(243, 44);
            this.dateTime.TabIndex = 13;
            this.dateTime.Value = new System.DateTime(2024, 4, 20, 16, 55, 55, 544);
            // 
            // doctor
            // 
            this.doctor.BackColor = System.Drawing.Color.White;
            this.doctor.BorderThickness = 1;
            this.doctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.doctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.doctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.doctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.doctor.FillColor = System.Drawing.Color.White;
            this.doctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.doctor.ForeColor = System.Drawing.Color.Black;
            this.doctor.Location = new System.Drawing.Point(109, 202);
            this.doctor.Margin = new System.Windows.Forms.Padding(4);
            this.doctor.Name = "doctor";
            this.doctor.PressedColor = System.Drawing.Color.White;
            this.doctor.Size = new System.Drawing.Size(243, 39);
            this.doctor.TabIndex = 12;
            this.doctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.doctor.Click += new System.EventHandler(this.doctor_Click);
            // 
            // ca
            // 
            this.ca.BackColor = System.Drawing.Color.Transparent;
            this.ca.BorderColor = System.Drawing.Color.Black;
            this.ca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ca.ItemHeight = 30;
            this.ca.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ca.Location = new System.Drawing.Point(109, 150);
            this.ca.Margin = new System.Windows.Forms.Padding(4);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(241, 36);
            this.ca.TabIndex = 11;
            // 
            // benhnhan
            // 
            this.benhnhan.BackColor = System.Drawing.Color.White;
            this.benhnhan.BorderThickness = 1;
            this.benhnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.benhnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.benhnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.benhnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.benhnhan.FillColor = System.Drawing.Color.White;
            this.benhnhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.benhnhan.ForeColor = System.Drawing.Color.Black;
            this.benhnhan.Location = new System.Drawing.Point(109, 46);
            this.benhnhan.Margin = new System.Windows.Forms.Padding(4);
            this.benhnhan.Name = "benhnhan";
            this.benhnhan.PressedColor = System.Drawing.Color.White;
            this.benhnhan.Size = new System.Drawing.Size(243, 39);
            this.benhnhan.TabIndex = 10;
            this.benhnhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.benhnhan.Click += new System.EventHandler(this.benhnhan_Click);
            // 
            // btnDone
            // 
            this.btnDone.BorderRadius = 7;
            this.btnDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(173)))), ((int)(((byte)(84)))));
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(231, 244);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(123, 42);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "XÁC NHẬN";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lbDoctor
            // 
            this.lbDoctor.AutoSize = true;
            this.lbDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoctor.Location = new System.Drawing.Point(16, 210);
            this.lbDoctor.Name = "lbDoctor";
            this.lbDoctor.Size = new System.Drawing.Size(51, 20);
            this.lbDoctor.TabIndex = 4;
            this.lbDoctor.Text = "Bác sĩ:";
            // 
            // lbWork
            // 
            this.lbWork.AutoSize = true;
            this.lbWork.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWork.Location = new System.Drawing.Point(17, 156);
            this.lbWork.Name = "lbWork";
            this.lbWork.Size = new System.Drawing.Size(30, 20);
            this.lbWork.TabIndex = 3;
            this.lbWork.Text = "Ca:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(17, 106);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(50, 20);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Ngày:";
            // 
            // lbPatient
            // 
            this.lbPatient.AutoSize = true;
            this.lbPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatient.Location = new System.Drawing.Point(17, 54);
            this.lbPatient.Name = "lbPatient";
            this.lbPatient.Size = new System.Drawing.Size(87, 20);
            this.lbPatient.TabIndex = 1;
            this.lbPatient.Text = "Bệnh nhân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "STT";
            // 
            // panelTreatment
            // 
            this.panelTreatment.BackColor = System.Drawing.Color.White;
            this.panelTreatment.Controls.Add(this.STT);
            this.panelTreatment.Controls.Add(this.dichvu);
            this.panelTreatment.Controls.Add(this.btnDelete);
            this.panelTreatment.Controls.Add(this.btnAdd);
            this.panelTreatment.Controls.Add(this.lbSTT);
            this.panelTreatment.Controls.Add(this.label3);
            this.panelTreatment.Location = new System.Drawing.Point(399, 78);
            this.panelTreatment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTreatment.Name = "panelTreatment";
            this.panelTreatment.Size = new System.Drawing.Size(365, 289);
            this.panelTreatment.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.BackColor = System.Drawing.Color.White;
            this.STT.BorderThickness = 1;
            this.STT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.STT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.STT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.STT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.STT.Enabled = false;
            this.STT.FillColor = System.Drawing.Color.White;
            this.STT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.STT.ForeColor = System.Drawing.Color.Black;
            this.STT.Location = new System.Drawing.Point(75, 47);
            this.STT.Margin = new System.Windows.Forms.Padding(4);
            this.STT.Name = "STT";
            this.STT.PressedColor = System.Drawing.Color.White;
            this.STT.Size = new System.Drawing.Size(265, 39);
            this.STT.TabIndex = 13;
            this.STT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dichvu
            // 
            this.dichvu.AllowUserToAddRows = false;
            this.dichvu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dichvu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dichvu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dichvu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dichvu.ColumnHeadersHeight = 4;
            this.dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dichvu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dichvu.GridColor = System.Drawing.Color.White;
            this.dichvu.Location = new System.Drawing.Point(25, 140);
            this.dichvu.Margin = new System.Windows.Forms.Padding(4);
            this.dichvu.Name = "dichvu";
            this.dichvu.ReadOnly = true;
            this.dichvu.RowHeadersVisible = false;
            this.dichvu.RowHeadersWidth = 51;
            this.dichvu.Size = new System.Drawing.Size(315, 122);
            this.dichvu.TabIndex = 15;
            this.dichvu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dichvu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dichvu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dichvu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dichvu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dichvu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dichvu.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dichvu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dichvu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dichvu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dichvu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dichvu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dichvu.ThemeStyle.HeaderStyle.Height = 4;
            this.dichvu.ThemeStyle.ReadOnly = true;
            this.dichvu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dichvu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dichvu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dichvu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dichvu.ThemeStyle.RowsStyle.Height = 22;
            this.dichvu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dichvu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 7;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(241, 92);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 42);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 7;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(25, 92);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 42);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTT.Location = new System.Drawing.Point(27, 54);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(37, 20);
            this.lbSTT.TabIndex = 5;
            this.lbSTT.Text = "STT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhu cầu điều trị";
            // 
            // btnFinished
            // 
            this.btnFinished.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinished.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinished.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinished.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinished.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(173)))), ((int)(((byte)(84)))));
            this.btnFinished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinished.ForeColor = System.Drawing.Color.White;
            this.btnFinished.Location = new System.Drawing.Point(301, 372);
            this.btnFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(160, 49);
            this.btnFinished.TabIndex = 10;
            this.btnFinished.Text = "HOÀN TẤT";
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // Rec_AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 430);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.panelTreatment);
            this.Controls.Add(this.panelSTT);
            this.Controls.Add(this.lbForm);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 477);
            this.MinimumSize = new System.Drawing.Size(794, 477);
            this.Name = "Rec_AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lịch hẹn";
            this.Load += new System.EventHandler(this.Rec_AddAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelSTT.ResumeLayout(false);
            this.panelSTT.PerformLayout();
            this.panelTreatment.ResumeLayout(false);
            this.panelTreatment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbForm;
        private System.Windows.Forms.Panel panelSTT;
        private System.Windows.Forms.Label lbDoctor;
        private System.Windows.Forms.Label lbWork;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTreatment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSTT;
        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2Button btnFinished;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dichvu;
        private Guna.UI2.WinForms.Guna2Button benhnhan;
        private Guna.UI2.WinForms.Guna2ComboBox ca;
        private Guna.UI2.WinForms.Guna2Button doctor;
        private Guna.UI2.WinForms.Guna2Button STT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTime;
    }
}