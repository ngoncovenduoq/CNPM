using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class Owner_Salary : Form
    {
        private int thang;
        private int nam;
        public Owner_Salary()
        {
            InitializeComponent();
        }

        // đổi màu nền
        public void ChangeColor(Color color, Color color2)
        {
            panelTop.BackColor = Color.FromArgb(241, 241, 241);
            guna2DataGridView1.BackgroundColor = color2;
            if (color2 == Color.FromArgb(50, 50, 50))
            {
                panelTop.BackColor = Color.FromArgb(50, 50, 50);
            }
        }

        private void Owner_Salary_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            tbMonth.Text = DateTime.Now.Month.ToString();
            tbYear.Text = DateTime.Now.Year.ToString();
            thang = DateTime.Now.Month;
            nam = DateTime.Now.Year;
            DateTime date = new DateTime(nam, thang, 1);
            DataSet ds = BLL.Owner.Luongs(date.Date);
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns["ma_nhan_vien"].HeaderText = "Mã nhân viên";
            guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
            guna2DataGridView1.Columns["tong_luong"].HeaderText = "Tổng lương";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (thang == 1)
            {
                thang = 12;
                nam--;
            }
            else
            {
                thang--;
            }
            tbMonth.Text = thang.ToString();
            tbYear.Text = nam.ToString();
            DateTime date = new DateTime(nam, thang, 1);
            DataSet ds = BLL.Owner.Luongs(date.Date);
            if (ds == null)
            {
                MessageBox.Show("Vui lòng nhập thời gian chính xác");
            }
            else
            {
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                guna2DataGridView1.DataSource = ds.Tables[0];
                guna2DataGridView1.Columns["ma_nhan_vien"].HeaderText = "Mã nhân viên";
                guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
                guna2DataGridView1.Columns["tong_luong"].HeaderText = "Tổng lương";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (thang == 12)
            {
                thang = 1;
                nam++;
            }
            else
            {
                thang++;
            }
            tbMonth.Text = thang.ToString();
            tbYear.Text = nam.ToString();
            DateTime date = new DateTime(nam, thang, 1);
            DataSet ds = BLL.Owner.Luongs(date.Date);
            if (ds == null)
            {
                MessageBox.Show("Vui lòng nhập thời gian chính xác");
            }
            else
            {
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                guna2DataGridView1.DataSource = ds.Tables[0];

                guna2DataGridView1.Columns["ma_nhan_vien"].HeaderText = "Mã nhân viên";
                guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
                guna2DataGridView1.Columns["tong_luong"].HeaderText = "Tổng lương";
            }
        }
    }
}
