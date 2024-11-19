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
    public partial class Theo_doi : Form
    {
        private string stt;
        private string hoten;
        public Theo_doi(string stt, string hoten)
        {
            InitializeComponent();
            this.stt = stt;
            this.hoten = hoten;
            label4.Text = stt;
            label2.Text = hoten;
        }

        public void ChangeLanguage(string language)
        {
            if(language == "Vietnam")
            {
                label1.Text = "Họ tên";
                label3.Text = "Mã bệnh nhân";
                guna2Button1.Text = "Lưu";
            }
            else
            {
                label1.Text = "Full Name";
                label3.Text = "Patient ID";
                guna2Button1.Text = "Save";
            }
        }

        public void changeColor(Color color, Color color2)
        {
            this.BackColor = color;
            guna2DataGridView1.BackgroundColor = color2;
            if(color2 == Color.FromArgb(50, 50, 50))
            {
                label1.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                guna2Button1.FillColor = color2;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                guna2Button1.FillColor = Color.LightGray;
            }
        }

        private void Theo_doi_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;

            DataSet ds = BLL.BenhAn.LayTheoDoi(stt);
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = ds.Tables[0];


            guna2DataGridView1.Columns["Ngay_tao"].HeaderText = "Ngày tạo";
            guna2DataGridView1.Columns["Cong_viec_dieu_tri"].HeaderText = "Nội dung";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Tao_theo_doi tao_Theo_Doi = new Tao_theo_doi(stt, "");
            if (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50))
            {
                tao_Theo_Doi.changeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            }
            else
            {
                tao_Theo_Doi.changeColor(Color.White, Color.WhiteSmoke);
            }

            if (label1.Text == "Full Name")
            {
                tao_Theo_Doi.changeLanguage("English");
            }
            else
            {
                tao_Theo_Doi.changeLanguage("Vietnam");
            }

            tao_Theo_Doi.ShowDialog();
            DataSet ds = BLL.BenhAn.LayTheoDoi(stt);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if ((DateTime)guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value == DateTime.Now.Date)
                {
                    Tao_theo_doi tao_Theo_Doi = new Tao_theo_doi(stt, guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    if (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50))
                    {
                        tao_Theo_Doi.changeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                    }
                    else
                    {
                        tao_Theo_Doi.changeColor(Color.White, Color.WhiteSmoke);
                    }

                    if (label1.Text == "Full Name")
                    {
                        tao_Theo_Doi.changeLanguage("English");
                    }
                    else
                    {
                        tao_Theo_Doi.changeLanguage("Vietnam");
                    }

                    tao_Theo_Doi.ShowDialog();
                }
            }
            
        }
    }
}
