using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class ForgotPassword : Form
    {
        private BLL.ForgotPassword forgot;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbAccount_Enter(object sender, EventArgs e)
        {
            if (tbAccount.Text == "Tên tài khoản/ Email")
            {
                tbAccount.Text = string.Empty;

                tbAccount.ForeColor = Color.Black;
            }
        }

        private void tbAccount_Leave(object sender, EventArgs e)
        {
            if (tbAccount.Text == "")
            {
                tbAccount.Text = "Tên tài khoản/ Email";

                tbAccount.ForeColor = Color.Silver;
            }
        }

        private void CCCD_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Tên tài khoản/ Email")
            {
                tbEmail.Text = string.Empty;

                tbEmail.ForeColor = Color.Black;
            }
        }

        private void CCCD_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Tên tài khoản/ Email")
            {
                tbEmail.Text = string.Empty;

                tbEmail.ForeColor = Color.Black;
            }
        }

        private void comeBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            forgot = new BLL.ForgotPassword();
            string check = forgot.KiemTra(tbAccount.Text, tbEmail.Text);
            MessageBox.Show(check);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(forgot == null)
            {
                MessageBox.Show("Vui lòng hoàn thành bước gửi mã");
            }
            else
            {
                string check = forgot.Code(tbCode.Text);
                MessageBox.Show(check);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
