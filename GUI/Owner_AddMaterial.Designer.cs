namespace Project_CNPM
{
    partial class Owner_AddMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_AddMaterial));
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbForm = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbDVT = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.tbColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.tbSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.tbValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.tbNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDVT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.BorderRadius = 10;
            this.btnDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(229)))));
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(660, 535);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(180, 45);
            this.btnDone.TabIndex = 87;
            this.btnDone.Text = "Xác nhận";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tbName
            // 
            this.tbName.BorderRadius = 5;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Location = new System.Drawing.Point(22, 135);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.Size = new System.Drawing.Size(304, 39);
            this.tbName.TabIndex = 86;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(17, 102);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(130, 28);
            this.lbName.TabIndex = 84;
            this.lbName.Text = "Tên dụng cụ:";
            // 
            // lbForm
            // 
            this.lbForm.AutoSize = true;
            this.lbForm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(197)))), ((int)(((byte)(229)))));
            this.lbForm.Location = new System.Drawing.Point(325, 52);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(250, 45);
            this.lbForm.TabIndex = 83;
            this.lbForm.Text = "Thêm Dụng Cụ";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(17, 267);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(99, 28);
            this.lbQuantity.TabIndex = 88;
            this.lbQuantity.Text = "Số lượng:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.BorderRadius = 5;
            this.tbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuantity.DefaultText = "";
            this.tbQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantity.Location = new System.Drawing.Point(22, 300);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.PasswordChar = '\0';
            this.tbQuantity.PlaceholderText = "";
            this.tbQuantity.SelectedText = "";
            this.tbQuantity.Size = new System.Drawing.Size(304, 39);
            this.tbQuantity.TabIndex = 89;
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.Location = new System.Drawing.Point(17, 183);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(55, 28);
            this.lbDVT.TabIndex = 90;
            this.lbDVT.Text = "ĐVT:";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(17, 362);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(91, 28);
            this.lbColor.TabIndex = 92;
            this.lbColor.Text = "Màu sắc:";
            // 
            // tbColor
            // 
            this.tbColor.BorderRadius = 5;
            this.tbColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbColor.DefaultText = "";
            this.tbColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbColor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbColor.Location = new System.Drawing.Point(22, 395);
            this.tbColor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbColor.Name = "tbColor";
            this.tbColor.PasswordChar = '\0';
            this.tbColor.PlaceholderText = "";
            this.tbColor.SelectedText = "";
            this.tbColor.Size = new System.Drawing.Size(304, 39);
            this.tbColor.TabIndex = 93;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(26, 453);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(82, 28);
            this.lbSize.TabIndex = 94;
            this.lbSize.Text = "Kích cỡ:";
            // 
            // tbSize
            // 
            this.tbSize.BorderRadius = 5;
            this.tbSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSize.DefaultText = "";
            this.tbSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSize.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSize.Location = new System.Drawing.Point(22, 486);
            this.tbSize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbSize.Name = "tbSize";
            this.tbSize.PasswordChar = '\0';
            this.tbSize.PlaceholderText = "";
            this.tbSize.SelectedText = "";
            this.tbSize.Size = new System.Drawing.Size(309, 39);
            this.tbSize.TabIndex = 95;
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValue.Location = new System.Drawing.Point(526, 102);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(71, 28);
            this.lbValue.TabIndex = 96;
            this.lbValue.Text = "Trị giá:";
            // 
            // tbValue
            // 
            this.tbValue.BorderRadius = 5;
            this.tbValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbValue.DefaultText = "";
            this.tbValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbValue.Location = new System.Drawing.Point(531, 135);
            this.tbValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbValue.Name = "tbValue";
            this.tbValue.PasswordChar = '\0';
            this.tbValue.PlaceholderText = "";
            this.tbValue.SelectedText = "";
            this.tbValue.Size = new System.Drawing.Size(309, 39);
            this.tbValue.TabIndex = 98;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(526, 362);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(135, 28);
            this.lbType.TabIndex = 99;
            this.lbType.Text = "Loại dụng cụ:";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(526, 183);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(87, 28);
            this.lbNote.TabIndex = 100;
            this.lbNote.Text = "Ghi chú:";
            // 
            // tbNote
            // 
            this.tbNote.BorderRadius = 5;
            this.tbNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNote.DefaultText = "";
            this.tbNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNote.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNote.Location = new System.Drawing.Point(531, 216);
            this.tbNote.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbNote.Name = "tbNote";
            this.tbNote.PasswordChar = '\0';
            this.tbNote.PlaceholderText = "";
            this.tbNote.SelectedText = "";
            this.tbNote.Size = new System.Drawing.Size(309, 123);
            this.tbNote.TabIndex = 101;
            this.tbNote.TextOffset = new System.Drawing.Point(0, -20);
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.Color.Transparent;
            this.cb.BorderRadius = 5;
            this.cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb.ItemHeight = 30;
            this.cb.Items.AddRange(new object[] {
            "Vật liệu cố định",
            "Vật liệu tiêu hao"});
            this.cb.Location = new System.Drawing.Point(531, 398);
            this.cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(309, 36);
            this.cb.TabIndex = 127;
            // 
            // cbDVT
            // 
            this.cbDVT.BackColor = System.Drawing.Color.Transparent;
            this.cbDVT.BorderRadius = 5;
            this.cbDVT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDVT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDVT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDVT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDVT.ItemHeight = 30;
            this.cbDVT.Items.AddRange(new object[] {
            "Cái",
            "Bộ",
            "Hộp",
            "Ống",
            "Chai"});
            this.cbDVT.Location = new System.Drawing.Point(22, 213);
            this.cbDVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(304, 36);
            this.cbDVT.TabIndex = 128;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(906, 48);
            this.panelTop.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(850, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(468, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 45);
            this.btnDelete.TabIndex = 130;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Owner_AddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 638);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.cbDVT);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbDVT);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(906, 638);
            this.MinimumSize = new System.Drawing.Size(906, 638);
            this.Name = "Owner_AddMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm dụng cụ";
            this.Load += new System.EventHandler(this.Owner_AddMaterial_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbForm;
        private System.Windows.Forms.Label lbQuantity;
        private Guna.UI2.WinForms.Guna2TextBox tbQuantity;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.Label lbColor;
        private Guna.UI2.WinForms.Guna2TextBox tbColor;
        private System.Windows.Forms.Label lbSize;
        private Guna.UI2.WinForms.Guna2TextBox tbSize;
        private System.Windows.Forms.Label lbValue;
        private Guna.UI2.WinForms.Guna2TextBox tbValue;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbNote;
        private Guna.UI2.WinForms.Guna2TextBox tbNote;
        private Guna.UI2.WinForms.Guna2ComboBox cb;
        private Guna.UI2.WinForms.Guna2ComboBox cbDVT;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}