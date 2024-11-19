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
    public partial class Rec_AddPatient : Form
    {
        public delegate void Rechand();
        public Rechand rechand;
        public Rec_AddPatient()
        {
            InitializeComponent();
        }

        public void ChangeLanguage(string language)
        {
            if(language == "Vietnam")
            {
                labelForm.Text = "THÊM BỆNH NHÂN MỚI";
                lbLastName.Text = "Họ";
                lbFirstName.Text = "Tên";
                lbSex.Text = "Giới tính";
                btnCancel.Text = "HỦY";
                btnDone.Text = "XONG";
            }
            else
            {
                labelForm.Text = "ADD NEW PATIENT";
                lbLastName.Text = "Last Name";
                lbFirstName.Text = "First Name";
                lbSex.Text = "Gender";
                btnCancel.Text = "CANCEL";
                btnDone.Text = "DONE";
            }
        }

        public void ChangeColor(Color color, Color color2)
        {
            panel1.BackColor = panel3.BackColor = panel4.BackColor = panel2.BackColor = color;
            panel5.BackColor = color2;
            if(color2 == Color.FromArgb(50,50,50)) 
            {
                lbCCCD.ForeColor = Color.White;
                labelForm.ForeColor = Color.White;
                lbLastName.ForeColor = Color.White;
                lbFirstName.ForeColor = Color.White;
                lbSex.ForeColor = Color.White;
                btnCancel.ForeColor = Color.White;
                btnCancel.FillColor = Color.FromArgb(50, 50, 50);
                btnDone.FillColor = Color.FromArgb(50, 50, 50);

                tbCCCD.FillColor = Color.FromArgb(50, 50,50);
                tbLastName.FillColor = Color.FromArgb (50, 50, 50);
                tbFirstName.FillColor = cbSex.FillColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                lbCCCD.ForeColor = Color.Black;
                labelForm.ForeColor = Color.Black;
                lbLastName.ForeColor = Color.Black;
                lbFirstName.ForeColor = Color.Black;
                lbSex.ForeColor = Color.Black;
                btnCancel.ForeColor = Color.Black;
                btnCancel.FillColor = Color.Silver;
                btnDone.FillColor = Color.FromArgb(64, 165, 93);

                tbCCCD.FillColor = Color.White;
                tbLastName.FillColor = Color.White;
                tbFirstName.FillColor = cbSex.FillColor = tbYear.FillColor = tbDay.FillColor = tbMonth.FillColor = Color.White;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            if(
                BLL.CheckTextBox.KiemTraSo(tbCCCD.Text)
                && BLL.CheckTextBox.KiemTraTenDacbiet(tbFirstName.Text)
                && BLL.CheckTextBox.KiemTraTenDacbiet(tbLastName.Text)
                && BLL.CheckTextBox.KiemTraTenDacbiet(guna2TextBox1.Text)
                && BLL.CheckTextBox.KiemTraTenDacbiet(guna2TextBox2.Text)
                && BLL.CheckTextBox.KiemTraTenDacbiet(guna2TextBox3.Text)
                && BLL.CheckTextBox.KiemTraSo(tbMonth.Text)
                && BLL.CheckTextBox.KiemTraSo(tbYear.Text)
                && BLL.CheckTextBox.KiemTraSo(tbDay.Text)
                )
            {
                DTO.BenhNhan benh = new DTO.BenhNhan(tbCCCD.Text, tbFirstName.Text, tbLastName.Text, cbSex.Text, guna2TextBox3.Text, guna2TextBox1.Text, guna2TextBox2.Text, new DateTime(Int32.Parse(tbYear.Text), Int32.Parse(tbMonth.Text), Int32.Parse(tbDay.Text)));

                string text = BLL.Rec_AddPatient.ThemBenhNhan(benh);
                MessageBox.Show(text);
                rechand();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
