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
    public partial class Owner_Statistical : Form
    {
        public Owner_Statistical()
        {
            InitializeComponent();
        }

        public void ChangeBackgroundColor(Color color, Color color2)
        {
            panelTop.BackColor = panelLeft.BackColor = color;
            reportViewer1.BackColor = color2;
            if (color2 == Color.FromArgb(50, 50, 50))
            {
                cbBox.FillColor = color2;
                guna2DateTimePicker1.FillColor = color2;
                guna2DateTimePicker1.ForeColor = cbBox.ForeColor = reportViewer1.ForeColor = Color.White;
                
            }
            else
            {
                cbBox.FillColor = Color.White;
                panelTop.BackColor = panelLeft.BackColor = Color.FromArgb(241, 241, 241);
                guna2DateTimePicker1.FillColor = Color.FromArgb(63, 220, 254);
                guna2DateTimePicker1.ForeColor = cbBox.ForeColor = reportViewer1.ForeColor = Color.Black;
            }
        }

        private void Owner_Statistical_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = DateTime.Now;
            cbBox.Text = "Tháng";
        }
        private void change()
        {
            DataSet list = BLL.Doctor.Thongke(guna2DateTimePicker1.Value,cbBox.Text);
            reportViewer1.LocalReport.ReportPath = "Thongke.rdlc";
            var source = new ReportDataSource("DataSet1", list.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            change();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            change();
        }
    }
}
