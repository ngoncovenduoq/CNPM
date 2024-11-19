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
    public partial class Tao_theo_doi : Form
    {
        private string maBN;
        private string theodoi;
        public Tao_theo_doi(string maBN,string theodoi)
        {
            InitializeComponent();
            this.maBN = maBN;
            this.theodoi = theodoi;
            guna2TextBox1.Text = theodoi;
        }

        public void changeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                label1.Text = "Nội dung điều trị";
                guna2Button1.Text = "Xác nhận";
            }
            else
            {
                label1.Text = "Treatment Task";
                guna2Button1.Text = "Agree";
            }
        }

        public void changeColor(Color color, Color color2)
        {
            this.BackColor = color;
            guna2TextBox1.FillColor = color2;
            if(color2 == Color.FromArgb(50,50,50))
            {
                label1.ForeColor = Color.White;
                guna2Button1.FillColor = color2;
            }
            else
            {
                label1.ForeColor = Color.Black;
                guna2Button1.FillColor = Color.FromArgb(68, 197, 229);
            }
        }

        private void Tao_theo_doi_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BLL.BenhAn.TaoTheoDoi(maBN, guna2TextBox1.Text);
            this.Close();
        }

        private void guna2Button1_DoubleClick(object sender, EventArgs e)
        {
            BLL.BenhAn.TaoTheoDoi(maBN, guna2TextBox1.Text);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
