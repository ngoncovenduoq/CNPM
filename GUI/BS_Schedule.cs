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
    public partial class BS_Schedule : Form
    {
        private DataSet _dataSet;
        private DTO.User User;
        public BS_Schedule()
        {
            InitializeComponent();
            _dataSet = new DataSet();
            User = Static.getUser();
        }

        public void ChangeBackgroundColor(Color color, Color color2)
        {
            panelTop.BackColor = panelTopLeft.BackColor = color;
            guna2DataGridView1.BackgroundColor = tbSearch.FillColor = color2;
            if (color2 == Color.FromArgb(50, 50, 50))
            {
                tbSearch.FillColor = color2;
            }
            else
            {
                tbSearch.FillColor = Color.White;
            }
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

        private void BS_Schedule_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            DateTime date = DateTime.Now;
            _dataSet = BLL.Doctor.BenhNhanChuaKham(date, User.GetMaNhanVien());
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];

            guna2DataGridView1.Columns["STT"].HeaderText = "Số thứ tự";
            guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            guna2DataGridView1.Columns["Gioi_tinh"].HeaderText = "Giới tính";
            guna2DataGridView1.Columns["Ghi_chu"].HeaderText = "Ghi chú";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (DataView dataView = _dataSet.Tables[0].DefaultView)
            {
                dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
                guna2DataGridView1.DataSource = dataView.ToTable();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
            guna2DataGridView1.DataSource = dataView.ToTable();
        }
    }
}
