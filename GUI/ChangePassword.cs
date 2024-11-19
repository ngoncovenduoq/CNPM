using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class ChangePassword : Form
    {
        SqlConnection conn = new SqlConnection(@"");  
        SqlCommand cmd = new SqlCommand();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void eye1_Click(object sender, EventArgs e)
        {
            if (tbPassword1.PasswordChar == '\0')
            {
                eye2.BringToFront();
                tbPassword1.PasswordChar = '*';

            }
        }
        private void eye2_Click(object sender, EventArgs e)
        {
            if (tbPassword1.PasswordChar == '*')
            {
                eye1.BringToFront();
                tbPassword1.PasswordChar = '\0';

            }
        }

        private void eye3_Click(object sender, EventArgs e)
        {
            if (tbPassword2.PasswordChar == '\0')
            {
                eye4.BringToFront();
                tbPassword2.PasswordChar = '*';

            }
        }

        private void eye4_Click(object sender, EventArgs e)
        {
            if (tbPassword2.PasswordChar == '*')
            {
                eye3.BringToFront();
                tbPassword2.PasswordChar = '\0';

            }
        }

        private void comeBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BLL.ChangePassword.Change(tbPassword1.Text, tbPassword2.Text));
            this.Close();
        }
    }
}
