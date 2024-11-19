using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class Owner_Staff_Rec : Form
    {
        private string maLT = "";
        private int trangthai;
        public Owner_Staff_Rec()
        {
            InitializeComponent();
            trangthai = 0;
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                lbForm.Text = "Thêm Lễ Tân";
                lbLastName.Text = "Họ";
                lbSex.Text = "Giới tính";
                lbFirstName.Text = "Tên";
                lbBirthday.Text = "Sinh nhật";
                lbHomeTown.Text = "Quê quán";
                btnDone.Text = "XONG";
            }
            else
            {
                lbForm.Text = "Add Receptionist";
                lbLastName.Text = "Last Name";
                lbSex.Text = "Gender";
                lbFirstName.Text = "First Name";
                lbBirthday.Text = "Birthday";
                lbHomeTown.Text = "Hometown";
                btnDone.Text = "DONE";

            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (
                BLL.CheckTextBox.KiemTraTenDacbiet(tbLastName.Text)
                && BLL.CheckTextBox.KiemTraTenDacbiet(tbFirstName.Text)
                && BLL.CheckTextBox.KiemTraTenDacbiet(tbCCCD.Text)
                && BLL.CheckTextBox.KiemTraTenDacbiet(tbHomeTown.Text)
                && BLL.CheckTextBox.KiemTraSo(tbMonth.Text)
                && BLL.CheckTextBox.KiemTraSo(tbYear.Text)
                && BLL.CheckTextBox.KiemTraSo(tbDay.Text)

                )
            {
                if (trangthai == 0)
                {
                    DTO.User user = new DTO.User();
                    user.SetEmail(tbEmail.Text);
                    user.SetHo(tbLastName.Text);
                    user.SetTen(tbFirstName.Text);
                    user.SetCCCD(tbCCCD.Text);
                    user.SetQueQuan(tbHomeTown.Text);
                    user.SetGioiTinh(cbSex.Text);
                    user.SetNgaySinh(new DateTime(Int32.Parse(tbYear.Text), Int32.Parse(tbMonth.Text), Int32.Parse(tbDay.Text)));
                    user.SetMaLuong("LT");
                    string text = BLL.AddUser.Add(user);
                    MessageBox.Show(text);
                    this.Close();
                }
                else
                {
                    DTO.User user = new DTO.User();
                    user.SetMaNhanVien(maLT);
                    user.SetEmail(tbEmail.Text);
                    user.SetHo(tbLastName.Text);
                    user.SetTen(tbFirstName.Text);
                    user.SetCCCD(tbCCCD.Text);
                    user.SetQueQuan(tbHomeTown.Text);
                    user.SetGioiTinh(cbSex.Text);
                    user.SetNgaySinh(new DateTime(Int32.Parse(tbYear.Text), Int32.Parse(tbMonth.Text), Int32.Parse(tbDay.Text)));
                    BLL.AddUser.EditUser(user);
                    MessageBox.Show("Chỉnh sửa thông tin thành công");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
        }

        private void Owner_Staff_Rec_Load(object sender, EventArgs e)
        {

        }
        public void GetInfo(string maLT)
        {
            this.maLT = maLT;
            DTO.User user = BLL.Owner.GetInfo(maLT);
            tbEmail.Text = user.GetEmail();
            tbLastName.Text = user.GetHo();
            tbFirstName.Text = user.GetTen();
            tbCCCD.Text = user.GetCCCD();
            tbHomeTown.Text = user.GetQueQuan();
            cbSex.Text = user.GetGioiTinh();
            tbYear.Text = user.GetNgaySinh().Year.ToString();
            tbMonth.Text = user.GetNgaySinh().Month.ToString();
            tbDay.Text = user.GetNgaySinh().Day.ToString();
            trangthai = 1;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbCCCD.Text = "";
            tbDay.Text = "";
            tbMonth.Text = "";
            tbYear.Text = "";
            tbEmail.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbHomeTown.Text = "";
            cbSex.SelectedIndex = -1;
        }
    }
}
