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
    public partial class BS_Appointment : Form
    {
        public BS_Appointment(string Doctor,string stt)
        {
            InitializeComponent();
            doctor.Text = Doctor;
            benhnhan.Text = stt;
            doctor.Enabled = false;
            benhnhan.Enabled = false;
            dateTime.Value = DateTime.Now;
        }

        private void BS_Appointment_Load(object sender, EventArgs e)
        {

        }

        private void benhnhan_Click(object sender, EventArgs e)
        {
            Rec_Check rec_Check = new Rec_Check();
            rec_Check.change();
            rec_Check.truyenBenhNhan = new Rec_Check.TruyenBenhNhan(LoadBenhNhan);
            rec_Check.ShowDialog();
        }
        private void LoadBenhNhan(string text)
        {
            benhnhan.Text = text;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string result = BLL.Patient.ThemNguoiKham(Int32.Parse(ca.Text), dateTime.Value,"", doctor.Text, benhnhan.Text);
            if (result.Equals(""))
                MessageBox.Show("Thời gian không hợp lệ");
            else
            {
                MessageBox.Show("Thêm lịch thành công");
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
