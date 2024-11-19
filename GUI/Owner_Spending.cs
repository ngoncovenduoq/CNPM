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
    public partial class Owner_Spending : Form
    {
        private int trangthai;
        private DataSet _dataSet;
        public Owner_Spending()
        {
            InitializeComponent();
            trangthai = 0;
            _dataSet = new DataSet();
        }

        public void ChangeLanguage(string language)
        {
            if(language == "Vietnam")
            {
                btnMedicine.Text = "Thuốc";
                btnTool.Text = "Dụng cụ";
                tbSearch.PlaceholderText = "Tìm kiếm";
                btnStatistics.Text = "Thống kê";
            }
            else
            {
                btnMedicine.Text = "Medicine";
                btnTool.Text = "Tool";
                tbSearch.PlaceholderText = "Search";
                btnStatistics.Text = "Statistics";
            }
        }

        public void ChangeColor(Color color, Color color2)
        {
            panelTopRight.BackColor = panelTop.BackColor = panelTopLeft.BackColor = color;
            guna2DataGridView1.BackgroundColor = color2;
            resetButton();
        }
        private void resetButton()
        {
            if (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)){
                btnMedicine.ForeColor = Color.White;
                btnMedicine.FillColor = Color.FromArgb(50, 50, 50);

                btnTool.ForeColor = btnStatistics.ForeColor = Color.White;
                btnTool.FillColor = Color.FromArgb(50, 50, 50);
                tbSearch.FillColor = Color.FromArgb(50, 50, 50);
                btnStatistics.FillColor = Color.FromArgb(50, 50, 50);

            }
            else
            {
                tbSearch.FillColor = Color.White;
                btnMedicine.ForeColor = btnStatistics.ForeColor = Color.Black;
                btnMedicine.FillColor = btnStatistics.FillColor = Color.FromArgb(63, 220, 254);

                btnTool.ForeColor = Color.Black;
                panelTop.BackColor = panelTopLeft.BackColor = panelTopRight.BackColor = Color.FromArgb(241, 241, 241);
                btnTool.FillColor = Color.FromArgb(63, 220, 254);
            }
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            resetButton();
            btnMedicine.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(7, 125, 4);
            btnMedicine.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            trangthai = 0;
            change();
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            resetButton();
            btnTool.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(7, 125, 4);
            btnTool.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            trangthai = 1;
            change();
        }

        private void Owner_Spending_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            change();
        }

        private void change()
        {
            if (trangthai == 0)
            {
                _dataSet = BLL.Owner.Thuoc();
            }
            else
            {
                _dataSet = BLL.Owner.DichVu();
            }
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            guna2DataGridView1.Columns["Ten"].HeaderText = "Tên";
            guna2DataGridView1.Columns["So_luong"].HeaderText = "Số lượng";
            guna2DataGridView1.Columns["Ngay"].HeaderText = "Ngày";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("Ten like '%{0}%'", tbSearch.Text);
            guna2DataGridView1.DataSource = dataView.ToTable();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("Ten like '%{0}%'", tbSearch.Text);
            guna2DataGridView1.DataSource = dataView.ToTable();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ReportOwner report = new ReportOwner(trangthai);
            report.ShowDialog();
        }
    }
}
