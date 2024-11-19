using Guna.UI2.WinForms;
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
    public partial class BS_Receive : Form
    {
        public delegate void Receive();
        public Receive receive;
        private DataSet _dataSet;
        private DTO.User User;
        public BS_Receive()
        {
            InitializeComponent();
            _dataSet = new DataSet();
            User = Static.getUser();
        }

        public void ChangeBackgroundColor(Color color, Color color2)
        {
            panelTop.BackColor = panelLeft.BackColor = color;
            DataGridView.BackgroundColor = color2;
            if (color2 == Color.FromArgb(50, 50, 50))
            {
                tbSearch.FillColor = btnReceive.FillColor = color2;
            }
            else
            {
                tbSearch.FillColor = Color.White;
                btnReceive.FillColor = Color.FromArgb(3, 198, 215);
            }
            
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                tbSearch.PlaceholderText = "Tìm kiếm";
                btnReceive.Text = "Tiếp nhận";
            }
            else
            {
                tbSearch.PlaceholderText = "Search";
                btnReceive.Text = "Admission";
            }
        }
        private void BS_Receive_Load(object sender, EventArgs e)
        {
            DataGridView.ColumnHeadersHeight = 40;
            DateTime date = DateTime.Now;
            _dataSet = BLL.Doctor.BenhNhan(date, User.GetMaNhanVien());
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridView.DataSource = _dataSet.Tables[0];
            DataGridView.Columns["STT"].HeaderText = "Số thứ tự";
            DataGridView.Columns["HoTen"].HeaderText = "Họ tên";
            DataGridView.Columns["Gioi_tinh"].HeaderText = "Giới tính";
            DataGridView.Columns["Ghi_chu"].HeaderText = "Ghi chú";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (DataView dataView = _dataSet.Tables[0].DefaultView)
            {
                dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
                DataGridView.DataSource = dataView.ToTable();
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if(DataGridView.SelectedRows.Count==1 && DataGridView.SelectedRows[0].Cells[0].Value!=null)
            {

                BLL.Doctor.TiepNhan(DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("Đã tiếp nhận bệnh nhân " + DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                receive();
              
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 bệnh nhân");
            }
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string stt = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string maBS = Static.getUser().GetMaNhanVien();
                Rec_Change_Doctor rec_Change_Doctor = new Rec_Change_Doctor(stt, maBS);
                rec_Change_Doctor.ShowDialog();
                DataGridView.ColumnHeadersHeight = 40;
                DateTime date = DateTime.Now;
                _dataSet = BLL.Doctor.BenhNhan(date, User.GetMaNhanVien());
                DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DataGridView.DataSource = _dataSet.Tables[0];

                DataGridView.Columns["STT"].HeaderText = "Số thứ tự";
                DataGridView.Columns["HoTen"].HeaderText = "Họ tên";
                DataGridView.Columns["Gioi_tinh"].HeaderText = "Giới tính";
                DataGridView.Columns["Ghi_chu"].HeaderText = "Ghi chú";
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            using (DataView dataView = _dataSet.Tables[0].DefaultView)
            {
                dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
                DataGridView.DataSource = dataView.ToTable();
            }
        }
    }
}
