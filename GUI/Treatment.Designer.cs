namespace Project_CNPM
{
    partial class BS_Treatment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnExamination = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnService = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrescription = new Guna.UI2.WinForms.Guna2Button();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelService = new System.Windows.Forms.Panel();
            this.panelServiceLeft = new System.Windows.Forms.Panel();
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panelPrescription = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbAmount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbMedicine = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panePatient = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnDone1 = new Guna.UI2.WinForms.Guna2Button();
<<<<<<< HEAD
            this.panelTool = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelShow = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
=======
>>>>>>> parent of 7e3bc79 (Update BS_Treatment - Thêm dụng cụ chi tiêu)
            this.panel1.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.panelService.SuspendLayout();
            this.panelServiceLeft.SuspendLayout();
            this.panelPrescription.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.panePatient.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTopRight);
            this.panel1.Controls.Add(this.panelTopLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 77);
            this.panel1.TabIndex = 0;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.btnBill);
            this.panelTopRight.Controls.Add(this.btnExamination);
            this.panelTopRight.Controls.Add(this.btnPatient);
            this.panelTopRight.Controls.Add(this.btnService);
            this.panelTopRight.Controls.Add(this.btnPrescription);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTopRight.Location = new System.Drawing.Point(0, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(930, 77);
            this.panelTopRight.TabIndex = 1;
            // 
            // btnBill
            // 
            this.btnBill.BorderRadius = 10;
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.Black;
            this.btnBill.Image = global::Project_CNPM.Properties.Resources.invoice;
            this.btnBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBill.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBill.Location = new System.Drawing.Point(731, 11);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(164, 59);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Tạo hóa đơn";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnExamination
            // 
            this.btnExamination.BorderRadius = 10;
            this.btnExamination.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExamination.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExamination.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExamination.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExamination.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.btnExamination.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamination.ForeColor = System.Drawing.Color.Black;
            this.btnExamination.Image = global::Project_CNPM.Properties.Resources.timetable1;
            this.btnExamination.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExamination.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExamination.Location = new System.Drawing.Point(550, 11);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(164, 59);
            this.btnExamination.TabIndex = 9;
            this.btnExamination.Text = "Tái khám";
            this.btnExamination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BorderRadius = 10;
            this.btnPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(125)))), ((int)(((byte)(4)))));
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Image = global::Project_CNPM.Properties.Resources.patient;
            this.btnPatient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPatient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPatient.Location = new System.Drawing.Point(3, 11);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(164, 59);
            this.btnPatient.TabIndex = 6;
            this.btnPatient.Text = "Bệnh nhân";
            this.btnPatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnService
            // 
            this.btnService.BorderRadius = 10;
            this.btnService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.btnService.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.Black;
            this.btnService.Image = global::Project_CNPM.Properties.Resources.examination;
            this.btnService.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnService.ImageSize = new System.Drawing.Size(25, 25);
            this.btnService.Location = new System.Drawing.Point(183, 11);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(164, 59);
            this.btnService.TabIndex = 7;
            this.btnService.Text = "Dịch vụ";
            this.btnService.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.BorderRadius = 10;
            this.btnPrescription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrescription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.btnPrescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescription.ForeColor = System.Drawing.Color.Black;
            this.btnPrescription.Image = global::Project_CNPM.Properties.Resources.medicine1;
            this.btnPrescription.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrescription.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrescription.Location = new System.Drawing.Point(366, 11);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(164, 59);
            this.btnPrescription.TabIndex = 8;
            this.btnPrescription.Text = "Kê đơn";
            this.btnPrescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.btnSearch);
            this.panelTopLeft.Controls.Add(this.tbSearch);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopLeft.Location = new System.Drawing.Point(838, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(424, 77);
            this.panelTopLeft.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(306, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 48);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
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
            this.tbSearch.Location = new System.Drawing.Point(5, 22);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbSearch.PlaceholderText = "Tìm kiếm";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(295, 48);
            this.tbSearch.TabIndex = 3;
            // 
            // panelService
            // 
            this.panelService.Controls.Add(this.panelServiceLeft);
            this.panelService.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelService.Location = new System.Drawing.Point(0, 77);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(1262, 62);
            this.panelService.TabIndex = 1;
            // 
            // panelServiceLeft
            // 
            this.panelServiceLeft.Controls.Add(this.btnDone);
            this.panelServiceLeft.Controls.Add(this.btnUpdate);
            this.panelServiceLeft.Controls.Add(this.tbSearch1);
            this.panelServiceLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelServiceLeft.Location = new System.Drawing.Point(666, 0);
            this.panelServiceLeft.Name = "panelServiceLeft";
            this.panelServiceLeft.Size = new System.Drawing.Size(596, 62);
            this.panelServiceLeft.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.BorderRadius = 10;
            this.btnDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Image = global::Project_CNPM.Properties.Resources.check;
            this.btnDone.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDone.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDone.Location = new System.Drawing.Point(438, 11);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(146, 49);
            this.btnDone.TabIndex = 14;
            this.btnDone.Text = "Hoàn tất";
            this.btnDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbSearch1
            // 
            this.tbSearch1.BorderRadius = 10;
            this.tbSearch1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch1.DefaultText = "";
            this.tbSearch1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch1.ForeColor = System.Drawing.Color.Black;
            this.tbSearch1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch1.IconRight = global::Project_CNPM.Properties.Resources.search;
            this.tbSearch1.IconRightOffset = new System.Drawing.Point(10, 0);
            this.tbSearch1.IconRightSize = new System.Drawing.Size(15, 15);
            this.tbSearch1.Location = new System.Drawing.Point(172, 10);
            this.tbSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch1.Name = "tbSearch1";
            this.tbSearch1.PasswordChar = '\0';
            this.tbSearch1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbSearch1.PlaceholderText = "Tìm kiếm dịch vụ";
            this.tbSearch1.SelectedText = "";
            this.tbSearch1.Size = new System.Drawing.Size(255, 49);
            this.tbSearch1.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::Project_CNPM.Properties.Resources.editing;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdate.ImageSize = new System.Drawing.Size(15, 15);
            this.btnUpdate.Location = new System.Drawing.Point(13, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 49);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelPrescription
            // 
            this.panelPrescription.Controls.Add(this.panel3);
            this.panelPrescription.Controls.Add(this.panel2);
            this.panelPrescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrescription.Location = new System.Drawing.Point(0, 139);
            this.panelPrescription.Name = "panelPrescription";
            this.panelPrescription.Size = new System.Drawing.Size(1262, 62);
            this.panelPrescription.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2TextBox1);
            this.panel3.Controls.Add(this.cbAmount);
            this.panel3.Controls.Add(this.cbMedicine);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 62);
            this.panel3.TabIndex = 2;
            // 
            // cbAmount
            // 
            this.cbAmount.BackColor = System.Drawing.Color.Transparent;
            this.cbAmount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAmount.ItemHeight = 30;
            this.cbAmount.Items.AddRange(new object[] {
            "Liều lượng",
            "10",
            "2"});
            this.cbAmount.Location = new System.Drawing.Point(213, 11);
            this.cbAmount.Name = "cbAmount";
            this.cbAmount.Size = new System.Drawing.Size(167, 36);
            this.cbAmount.StartIndex = 0;
            this.cbAmount.TabIndex = 1;
            this.cbAmount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // cbMedicine
            // 
            this.cbMedicine.BackColor = System.Drawing.Color.Transparent;
            this.cbMedicine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicine.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMedicine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMedicine.ItemHeight = 30;
            this.cbMedicine.Items.AddRange(new object[] {
            "Thuốc",
            "Panadon"});
            this.cbMedicine.Location = new System.Drawing.Point(12, 11);
            this.cbMedicine.Name = "cbMedicine";
            this.cbMedicine.Size = new System.Drawing.Size(167, 36);
            this.cbMedicine.StartIndex = 0;
            this.cbMedicine.TabIndex = 0;
            this.cbMedicine.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate1);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(777, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 62);
            this.panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Project_CNPM.Properties.Resources.bin1;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDelete.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDelete.Location = new System.Drawing.Point(325, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 49);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.BorderRadius = 10;
            this.btnUpdate1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate1.FillColor = System.Drawing.Color.White;
            this.btnUpdate1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate1.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate1.Image = global::Project_CNPM.Properties.Resources.editing;
            this.btnUpdate1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdate1.ImageSize = new System.Drawing.Size(15, 15);
            this.btnUpdate1.Location = new System.Drawing.Point(163, 8);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(146, 49);
            this.btnUpdate1.TabIndex = 19;
            this.btnUpdate1.Text = "Sửa";
            this.btnUpdate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Project_CNPM.Properties.Resources.add1;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAdd.Location = new System.Drawing.Point(7, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 49);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.panePatient);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 201);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1262, 729);
            this.panelShow.TabIndex = 3;
            // 
            // panePatient
            // 
            this.panePatient.Controls.Add(this.panelLeft);
            this.panePatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.panePatient.Location = new System.Drawing.Point(0, 0);
            this.panePatient.Name = "panePatient";
            this.panePatient.Size = new System.Drawing.Size(1262, 62);
            this.panePatient.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnDone1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(897, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(365, 62);
            this.panelLeft.TabIndex = 0;
            // 
            // btnDone1
            // 
            this.btnDone1.BorderRadius = 10;
            this.btnDone1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDone1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDone1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDone1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDone1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.btnDone1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone1.ForeColor = System.Drawing.Color.White;
            this.btnDone1.Image = global::Project_CNPM.Properties.Resources.add1;
            this.btnDone1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDone1.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDone1.Location = new System.Drawing.Point(182, 7);
            this.btnDone1.Name = "btnDone1";
            this.btnDone1.Size = new System.Drawing.Size(171, 52);
            this.btnDone1.TabIndex = 22;
            this.btnDone1.Text = "Hoàn tất điều trị";
            this.btnDone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
<<<<<<< HEAD
            // panelTool
            // 
            this.panelTool.Controls.Add(this.panel4);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 263);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(1262, 62);
            this.panelTool.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.guna2Button1);
            this.panel4.Controls.Add(this.btnUpdate2);
            this.panel4.Controls.Add(this.btnAdd1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(777, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 62);
            this.panel4.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Project_CNPM.Properties.Resources.bin1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button1.Location = new System.Drawing.Point(325, 8);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(146, 49);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Xóa";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.BorderRadius = 10;
            this.btnUpdate2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate2.FillColor = System.Drawing.Color.White;
            this.btnUpdate2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate2.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate2.Image = global::Project_CNPM.Properties.Resources.editing;
            this.btnUpdate2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdate2.ImageSize = new System.Drawing.Size(15, 15);
            this.btnUpdate2.Location = new System.Drawing.Point(163, 8);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(146, 49);
            this.btnUpdate2.TabIndex = 19;
            this.btnUpdate2.Text = "Sửa";
            this.btnUpdate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAdd1
            // 
            this.btnAdd1.BorderRadius = 10;
            this.btnAdd1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.btnAdd1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.ForeColor = System.Drawing.Color.White;
            this.btnAdd1.Image = global::Project_CNPM.Properties.Resources.add1;
            this.btnAdd1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd1.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAdd1.Location = new System.Drawing.Point(7, 8);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(146, 49);
            this.btnAdd1.TabIndex = 18;
            this.btnAdd1.Text = "Thêm";
            this.btnAdd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelShow
            // 
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 325);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1262, 605);
            this.panelShow.TabIndex = 7;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(412, 11);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Ghi chú";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(284, 44);
            this.guna2TextBox1.TabIndex = 2;
            // 
=======
>>>>>>> parent of 7e3bc79 (Update BS_Treatment - Thêm dụng cụ chi tiêu)
            // BS_Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 930);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelPrescription);
            this.Controls.Add(this.panelService);
            this.Controls.Add(this.panel1);
            this.Name = "BS_Treatment";
            this.Text = "BS_Treatment";
            this.Load += new System.EventHandler(this.BS_Treatment_Load);
            this.panel1.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            this.panelService.ResumeLayout(false);
            this.panelServiceLeft.ResumeLayout(false);
            this.panelPrescription.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.panePatient.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1; // panel nền phía trên
        private System.Windows.Forms.Panel panelTopLeft; //panel nền phía trên bên trái
        private Guna.UI2.WinForms.Guna2Button btnSearch; // nút tìm kiếm tổng
        private Guna.UI2.WinForms.Guna2TextBox tbSearch; // textbox tìm kiếm tổng
        private Guna.UI2.WinForms.Guna2Button btnExamination; //nút tái khám
        private Guna.UI2.WinForms.Guna2Button btnPrescription; //nút kê đơn
        private Guna.UI2.WinForms.Guna2Button btnService; //nút dịch vụ
        private Guna.UI2.WinForms.Guna2Button btnPatient; //nút bệnh nhân
        private Guna.UI2.WinForms.Guna2Button btnBill; //nút tạo hóa đơn
        private System.Windows.Forms.Panel panelTopRight; 
        private System.Windows.Forms.Panel panelService; //panel của dịch vụ
        private System.Windows.Forms.Panel panelServiceLeft;
        private Guna.UI2.WinForms.Guna2Button btnDone; //nút hoàn tất cả dịch vụ
        private Guna.UI2.WinForms.Guna2TextBox tbSearch1; //textbox tìm kiếm của dịch vụ
        private Guna.UI2.WinForms.Guna2Button btnUpdate; //nút update của dịch vụ
        private System.Windows.Forms.Panel panelPrescription; //kê đơn
        private System.Windows.Forms.Panel panelShow; //panel hiển thị database
        private System.Windows.Forms.Panel panel2; 
        private Guna.UI2.WinForms.Guna2Button btnDelete; //nút xóa của kê đơn
        private Guna.UI2.WinForms.Guna2Button btnUpdate1; //nút update của kê đơn
        private Guna.UI2.WinForms.Guna2Button btnAdd; //nút thêm của kê đơn
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbAmount;
        private Guna.UI2.WinForms.Guna2ComboBox cbMedicine;
        private System.Windows.Forms.Panel panePatient;
        private System.Windows.Forms.Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Button btnDone1;
<<<<<<< HEAD
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate2;
        private Guna.UI2.WinForms.Guna2Button btnAdd1;
        private System.Windows.Forms.Panel panelShow;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
=======
>>>>>>> parent of 7e3bc79 (Update BS_Treatment - Thêm dụng cụ chi tiêu)
    }
}