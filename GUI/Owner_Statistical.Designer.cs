namespace Project_CNPM
{
    partial class Owner_Statistical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_Statistical));
            this.panelShow = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cbBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelShow.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.reportViewer1);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 78);
            this.panelShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1112, 788);
            this.panelShow.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1112, 788);
            this.reportViewer1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cbBox);
            this.panelTop.Controls.Add(this.panelLeft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1112, 78);
            this.panelTop.TabIndex = 2;
            // 
            // cbBox
            // 
            this.cbBox.BackColor = System.Drawing.Color.Transparent;
            this.cbBox.BorderRadius = 10;
            this.cbBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBox.ItemHeight = 30;
            this.cbBox.Items.AddRange(new object[] {
            "Tháng",
            "Quý",
            "Năm"});
            this.cbBox.Location = new System.Drawing.Point(41, 18);
            this.cbBox.Margin = new System.Windows.Forms.Padding(4);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(185, 36);
            this.cbBox.TabIndex = 1;
            this.cbBox.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.guna2DateTimePicker1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(717, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(395, 78);
            this.panelLeft.TabIndex = 0;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 10;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.CustomFormat = "yyyy";
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(69, 18);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(267, 44);
            this.guna2DateTimePicker1.TabIndex = 0;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 4, 23, 9, 35, 34, 369);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // Owner_Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 866);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Owner_Statistical";
            this.Text = "Owner_Statistical";
            this.Load += new System.EventHandler(this.Owner_Statistical_Load);
            this.panelShow.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2ComboBox cbBox;
    }
}