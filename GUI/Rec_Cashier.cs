using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class Rec_Cashier : Form
    {
        private int trangthai;
        private DataSet _dataSet;
        private string hinhthuc;
        public Rec_Cashier()
        {
            InitializeComponent();
            trangthai = 0;
        }

        public void ChangeLanguage(string language)
        {
            if(language == "Vietnam") 
            {
                btnUnpaid.Text = "Chưa thanh toán";
                btnWaitForPay.Text = "Đã thanh toán";
                tbSearch.PlaceholderText = "Tìm kiếm";
                guna2Button1.Text = "Thanh toán";
            }
            else
            {
                btnUnpaid.Text = "Unpaid";
                btnWaitForPay.Text = "Paid";
                tbSearch.PlaceholderText = "Search";
                guna2Button1.Text = "Pay";
            }
        }

        public void ChangeColor(Color color, Color color2)
        {
            panelTopRight.BackColor = panelTop.BackColor = panelTopLeft.BackColor = color;
            guna2DataGridView1.BackgroundColor = color2;
            resetButton();
        }

        private void hinhthu(string text)
        {
            hinhthuc = text;
        }

        private void resetButton()
        {
            if (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)){
                btnUnpaid.ForeColor = btnWaitForPay.ForeColor = Color.White;
                btnUnpaid.FillColor = btnWaitForPay.FillColor = Color.FromArgb(50, 50, 50);
                btnUnpaid.Image = btnWaitForPay.Image = Properties.Resources.examination1;

                btnWaitForPay.ForeColor = btnWaitForPay.ForeColor = Color.White;
                btnWaitForPay.FillColor = btnWaitForPay.FillColor = Color.FromArgb(50, 50, 50);
                btnWaitForPay.Image = btnWaitForPay.Image = Properties.Resources.examination1;

                guna2Button1.FillColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                btnUnpaid.ForeColor = btnWaitForPay.ForeColor = Color.Black;
                btnUnpaid.FillColor = btnWaitForPay.FillColor = Color.FromArgb(63, 220, 254);
                btnUnpaid.Image = btnWaitForPay.Image = Properties.Resources.examination;

                btnWaitForPay.ForeColor = btnWaitForPay.ForeColor = Color.Black;
                btnWaitForPay.FillColor = btnWaitForPay.FillColor = Color.FromArgb(63, 220, 254);
                btnWaitForPay.Image = btnWaitForPay.Image = Properties.Resources.examination;

                guna2Button1.FillColor = Color.FromArgb(7, 125, 4);

            }

        }

        private void btnUnpaid_Click(object sender, EventArgs e)
        {
            resetButton();
            btnUnpaid.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(7, 125, 4);
            btnUnpaid.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            btnUnpaid.Image = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Properties.Resources.examination1 : Properties.Resources.examination1;
            trangthai = 0;
            guna2Button1.Visible = true;
            Invoice.Visible = false;
            change();
        }

        private void btnWaitForPay_Click(object sender, EventArgs e)
        {
            resetButton();
            btnWaitForPay.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(7, 125, 4);
            btnWaitForPay.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            btnWaitForPay.Image = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Properties.Resources.examination1 : Properties.Resources.examination1;
            trangthai = 1;
            guna2Button1.Visible = false;
            Invoice.Visible = true;
            change();
        }

        private void Rec_Cashier_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            Invoice.Visible = false;
            change();
        }
        private void change()
        {
            if (trangthai == 0)
            {
                _dataSet = BLL.Rec_Cashier.ChuaThanhToan();
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                guna2DataGridView1.DataSource = _dataSet.Tables[0];
                guna2DataGridView1.Columns["ID"].Visible = false;
                guna2DataGridView1.Columns["STT"].HeaderText = "Số thứ tự";
                guna2DataGridView1.Columns["tinhtrang"].HeaderText = "Tình trạng";
                guna2DataGridView1.Columns["Tongtien"].HeaderText = "Tổng tiền";
            }
            else
            {
                _dataSet = BLL.Rec_Cashier.DaThanhToan();
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                guna2DataGridView1.DataSource = _dataSet.Tables[0];
                guna2DataGridView1.Columns["ID"].Visible = false;
                guna2DataGridView1.Columns["STT"].HeaderText = "Số thứ tự";
                guna2DataGridView1.Columns["Tinhtrang"].HeaderText = "Tình trạng";
                guna2DataGridView1.Columns["Gio"].HeaderText = "Thời gian";
                guna2DataGridView1.Columns["Hinhthuc"].HeaderText = "Hình thức";
                guna2DataGridView1.Columns["Tongtien"].HeaderText = "Tổng tiền";
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("ID like '%{0}%'", tbSearch.Text);
            guna2DataGridView1.DataSource = dataView.ToTable();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 1 && guna2DataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                HinhThuc hinhThuc = new HinhThuc();
                hinhThuc.hinhThucEventHandler = new HinhThuc.HinhThucEventHandler(hinhthu);
                hinhThuc.ShowDialog();
                BLL.Rec_Cashier.Thanhtoan(guna2DataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(),hinhthuc);
                change();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("ID like '%{0}%'", tbSearch.Text);
            guna2DataGridView1.DataSource = dataView.ToTable();
        }

        private void Invoice_Click(object sender, EventArgs e)
        {
            if(guna2DataGridView1.SelectedRows.Count == 1)
            {
                Invoice invoice = new Invoice(guna2DataGridView1.SelectedRows[0].Cells["STT"].Value.ToString());
                invoice.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn");
            }
        }
    }
}
