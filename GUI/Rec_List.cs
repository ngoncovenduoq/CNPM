using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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
    public partial class Rec_List : Form
    {
        private DataSet _dataSet;
        public Rec_List()
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

        public void ChangeColor(Color color, Color color2)
        {
            panel1.BackColor = panelTopRight.BackColor = panelTopLeft.BackColor = color;
            guna2DataGridView1.BackgroundColor = color2;
            if (color2 == Color.FromArgb(50, 50, 50))
            {

            }
            else
            {
                tbSearch.FillColor = Color.White;
            }

        }

        private void Rec_List_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            reset();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
            guna2DataGridView1.DataSource = dataView.ToTable();

        }
        private void reset()
        {
            DateTime date = DateTime.Now;
            _dataSet = BLL.Rec_List.Tiepnhan(date);
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];

            guna2DataGridView1.Columns["STT"].HeaderText = "Số thứ tự";
            guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            guna2DataGridView1.Columns["Ma_bac_si"].HeaderText = "Mã bác sĩ";
            guna2DataGridView1.Columns["Gioi_tinh"].HeaderText = "Giới tính";
            guna2DataGridView1.Columns["Ghi_chu"].HeaderText = "Ghi chú";
        }

        private void accept_Click(object sender, EventArgs e)
        {
            Rec_AddAppointment rec_AddAppointment = new Rec_AddAppointment();
            rec_AddAppointment.ShowDialog();
            reset();
        }

        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string stt = stt = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string maBS = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Rec_Change_Doctor rec_Change_Doctor = new Rec_Change_Doctor(stt, maBS);
                rec_Change_Doctor.ShowDialog();
                reset();
            }
        }
    }
}
