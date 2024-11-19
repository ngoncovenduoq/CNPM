using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class Login : Form
    {
        private Size formSize;


        public Login()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DTO.Account account = new Account();
            account.setTaiKhoan(textLogin.Text);
            account.setMatKhau(textPassword.Text);
            string kiemtra = BLL.Login.Log(account);
            switch (kiemtra)
            {
                case "Vui lòng nhập tài khoản":
                    MessageBox.Show(kiemtra);
                    textLogin.Focus();
                    break;
                case "Vui lòng nhập mật khẩu":
                    MessageBox.Show(kiemtra);
                    textPassword.Focus();
                    break;
                case "Không tìm thấy tài khoản":
                    MessageBox.Show(kiemtra);
                    textLogin.Focus();
                    break;
                case "Sai mật khẩu":
                    MessageBox.Show(kiemtra);
                    textPassword.Focus();
                    break;
                case "Tài khoản bị vô hiệu hóa do quá nhiều lần thử đăng nhập":
                    MessageBox.Show(kiemtra);
                    break;
                case "Tài khoản không hoạt động":
                    MessageBox.Show(kiemtra);
                    break;
                default:
                    BLL.Login.Luu(account, rememberPas.Checked);
                    char x = textLogin.Text[0];
                    DTO.User user = BLL.User.GetUser(account.getTaiKhoan());
                    Static.changeUser(user);
                    if (x == 'B' || x == 'b')
                    {
                        Doctor doctor = new Doctor();
                        doctor.Show();
                        this.Hide();
                    }
                    else if (x == 'L' || x == 'l')
                    {
                        Receptionist receptionist = new Receptionist();
                        receptionist.Show();
                        this.Hide();
                    }
                    else
                    {
                        Owner owner = new Owner();
                        owner.Show();
                        this.Hide();
                    }
                    break;
            }
        }

        private void eye1_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '\0')
            {
                eye2.BringToFront();
                textPassword.PasswordChar = '*';
            }
        }

        private void eye2_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '*')
            {
                eye1.BringToFront();
                textPassword.PasswordChar = '\0';
            }
        }

        private void resize_Control(Control control, Rectangle rect)
        {
            float xRadio = (float)(this.Width) / (float)(formSize.Width);
            float yRadio = (float)(this.Height) / (float)(formSize.Height);
            int newX = (int)(rect.X * xRadio);
            int newY = (int)(rect.Y * yRadio);

            int newWidth = (int)(rect.Width * xRadio);
            int newHeight = (int)(rect.Height * yRadio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void linkForgotPas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textLogin.Text.Length == 0 || textLogin.Text.Equals("Tên tài khoản/ Email"))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
