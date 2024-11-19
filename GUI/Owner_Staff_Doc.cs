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
    public partial class Owner_Staff_Doc : Form
    {
        private string maBS = "";
        private int trangthai;
        public Owner_Staff_Doc()
        {
            InitializeComponent();
            trangthai = 0;
        }
        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                lbForm.Text = "Thêm Bác Sĩ";
                lbLastName.Text = "Họ";
                lbSex.Text = "Giới tính";
                lbFirstName.Text = "Tên";
                lbBirthday.Text = "Sinh nhật";
                lbFaculty.Text = "Khoa";
                lbHomeTown.Text = "Quê quán";
                btnDone.Text = "XONG";
            }
            else
            {
                lbForm.Text = "Add Doctor";
                lbLastName.Text = "Last Name";
                lbSex.Text = "Gender";
                lbFirstName.Text = "First Name";
                lbBirthday.Text = "Birthday";
                lbFaculty.Text = "Faculty";
                lbHomeTown.Text = "Hometown";
                btnDone.Text = "DONE";

            }
        }
        public void GetInfo(string maBS)
        {
            this.maBS = maBS;
            DTO.User user = BLL.Owner.GetInfo(maBS);
            tbEmail.Text = user.GetEmail();
            tbLastName.Text = user.GetHo();
            tbFirstName.Text = user.GetTen();
            tbCCCD.Text = user.GetCCCD();
            tbHomeTown.Text = user.GetQueQuan();
            cbSex.Text = user.GetGioiTinh();
            tbYear.Text = user.GetNgaySinh().Year.ToString();
            tbMonth.Text = user.GetNgaySinh().Month.ToString();
            tbDay.Text = user.GetNgaySinh().Day.ToString();
            lbFaculty.Visible = false;
            cbFaculty.Visible = false;
            trangthai = 1;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
                    switch (cbFaculty.Text)
                    {
                        case "Chữa răng và nội nha":
                            user.SetMaLuong("BSCRVNN");
                            break;
                        case "Nha chu":
                            user.SetMaLuong("BSNC");
                            break;
                        case "Nhổ răng và tiểu phẫu":
                            user.SetMaLuong("BSNRVTP");
                            break;
                        case "Phục hình":
                            user.SetMaLuong("BSPH");
                            break;
                        case "Răng trẻ em":
                            user.SetMaLuong("BSRTE");
                            break;
                        case "Tổng quát":
                            user.SetMaLuong("BSTQ");
                            break;
                        default:
                            user.SetMaLuong("");
                            break;
                    }
                    string text = BLL.AddUser.Add(user);
                    MessageBox.Show(text);
                    this.Close();
                }
                else
                {
                    DTO.User user = new DTO.User();
                    user.SetMaNhanVien(maBS);
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
            cbFaculty.SelectedIndex = -1;
        }
    }
}
