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
    public partial class Owner_Patient : Form
    {
        private DataSet _dataSet;
        public Owner_Patient()
        {
            InitializeComponent();
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam") 
            {
                tbSearch.PlaceholderText = "Tìm kiếm";
            }
            else
            {
                tbSearch.PlaceholderText = "Search";
            }
        }

        public void ChangeBackgroundColor(Color color, Color color2)
        {
            panelTop.BackColor = panelTopLeft.BackColor = panel2.BackColor = Color.FromArgb(241, 241, 241);
            guna2DataGridView1.BackgroundColor = guna2DataGridView1.GridColor = color2;
            if (color2 == Color.FromArgb(50, 50, 50))
            {
                tbSearch.FillColor  = color2;
            }
            else
            {
                tbSearch.FillColor =  Color.White;
                
            }
        }

        private void Owner_Patient_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ClearSelection();
            _dataSet = BLL.Owner_Patient.DanhSachBenhNhan();
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];

            guna2DataGridView1.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
            guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
            guna2DataGridView1.Columns["gioi_tinh"].HeaderText = "Giới tính";
            guna2DataGridView1.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            guna2DataGridView1.Columns["cccd"].HeaderText = "CCCD";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
            guna2DataGridView1.DataSource = dataView.ToTable();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
            guna2DataGridView1.DataSource = dataView.ToTable();
        }
    }
}
