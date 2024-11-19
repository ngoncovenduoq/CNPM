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
    public partial class CaLam : Form
    {
        private int ngay;
        private int thang;
        private int nam;
        private string ma;
        private int trangthai;
        public CaLam(int ngay, int thang, int nam, string ma)
        {
            InitializeComponent();
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
            this.ma = ma;
            trangthai = 0;
        }
        public void LeTan()
        {
            trangthai = 1;

        }
        private void CaLam_Load(object sender, EventArgs e)
        {
            l1.Enabled = false;
            l2.Enabled = false;
            l3.Enabled = false;

            List<DTO.Lam_viec> list = BLL.Doctor.CaLam(new DateTime(nam, thang, ngay), ma);
            foreach (DTO.Lam_viec lam_Viec in list)
            {
                if (lam_Viec.getCa() == 1)
                {
                    if (lam_Viec.getDiemdanh().Equals("Chưa điểm danh"))
                    {
                        if (trangthai == 0 && DateTime.Now.Date == new DateTime(nam, thang, ngay).Date)//tức là bác sĩ sử dụng
                        {
                            l1.Enabled = true;
                        }
                    }
                    l1.Text = lam_Viec.getDiemdanh();
                }
                if (lam_Viec.getCa() == 2)
                {
                    if (lam_Viec.getDiemdanh().Equals("Chưa điểm danh"))
                    {
                        if (trangthai == 0 && DateTime.Now.Date == new DateTime(nam, thang, ngay).Date)//tức là bác sĩ sử dụng
                        {
                            l2.Enabled = true;
                        }
                    }
                    l2.Text = lam_Viec.getDiemdanh();
                }
                if (lam_Viec.getCa() == 3)
                {
                    if (lam_Viec.getDiemdanh().Equals("Chưa điểm danh"))
                    {
                        if (trangthai == 0 && DateTime.Now.Date == new DateTime(nam, thang, ngay).Date)//tức là bác sĩ sử dụng
                        {
                            l3.Enabled = true;
                        }
                    }
                    l3.Text = lam_Viec.getDiemdanh();
                }
            }
            if (trangthai == 1)
            {
                if (l1.Text.Length == 0)
                {
                    l1.Enabled = true;
                }
                if (l2.Text.Length == 0)
                {
                    l2.Enabled = true;
                }
                if (l3.Text.Length == 0)
                {
                    l3.Enabled = true;
                }
            }
        }

        private void l1_Click(object sender, EventArgs e)
        {
            if (trangthai == 1)
            {
                MessageBox.Show(BLL.Doctor.XepCa(new DateTime(nam, thang, ngay), ma, 1));
            }
            else
            {
                MessageBox.Show(BLL.Doctor.Diemdanh(new DateTime(nam, thang, ngay), ma, 1));
            }
            CaLam_Load(sender, e);

        }

        private void l2_Click(object sender, EventArgs e)
        {
            if (trangthai == 1)
            {
                MessageBox.Show(BLL.Doctor.XepCa(new DateTime(nam, thang, ngay), ma, 2));
            }
            else
            {
                MessageBox.Show(BLL.Doctor.Diemdanh(new DateTime(nam, thang, ngay), ma, 2));
            }
            CaLam_Load(sender, e);
        }

        private void l3_Click(object sender, EventArgs e)
        {
            if (trangthai == 1)
            {
                MessageBox.Show(BLL.Doctor.XepCa(new DateTime(nam, thang, ngay), ma, 3));
            }
            else
            {
                MessageBox.Show(BLL.Doctor.Diemdanh(new DateTime(nam, thang, ngay), ma, 3));
            }
            CaLam_Load(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
