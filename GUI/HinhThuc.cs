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
    public partial class HinhThuc : Form
    {
        public delegate void HinhThucEventHandler(string text);
        public HinhThucEventHandler hinhThucEventHandler;
        public HinhThuc()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(guna2ComboBox1 == null)
            {
                MessageBox.Show("Chưa chọn hình thức thanh toán");
            }
            else
            {
                hinhThucEventHandler(guna2ComboBox1.Text);
                MessageBox.Show("Hoàn thành");
                this.Hide();
            }
        }
    }
}
