using Guna.UI2.WinForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class BS_Statistical : Form
    {
        public BS_Statistical()
        {
            InitializeComponent();
        }

        public void ChangeBackgroundColor(Color color, Color color2)
        {
            panelTop.BackColor = panelLeft.BackColor = color;
            reportViewer1.BackColor = color2;
            if (color2 == Color.FromArgb(50, 50, 50))
            {
                guna2DateTimePicker1.FillColor = color2;
                guna2DateTimePicker1.ForeColor = Color.White;
            }
            else
            {
                guna2DateTimePicker1.FillColor = Color.FromArgb(255, 136, 77);
                guna2DateTimePicker1.ForeColor = Color.FromArgb(64, 0, 0);
            }
        }

        private void BS_Statistical_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = DateTime.Now;
            change();
            this.reportViewer1.RefreshReport();
        }
        private void change()
        {
            DataSet list = BLL.Doctor.CalamThang(guna2DateTimePicker1.Value, Static.getUser().GetMaNhanVien());
            reportViewer1.LocalReport.ReportPath = "Calam.rdlc";
            var source = new ReportDataSource("DataSet1", list.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            change();
        }
    }
}
