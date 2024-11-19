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
    public partial class Blank : UserControl
    {
        private int thang;
        private int nam;
        private int ngay;
        private string ma;
        private CaLam caLam;
        public Blank(int i, int thang, int nam, string ma)
        {
            InitializeComponent();
            label1.Text = i.ToString();
            ngay = i;
            this.thang = thang;
            this.nam = nam;
            this.ma = ma;
            caLam = new CaLam(i, thang, nam, ma);
        }

        private void Blank_Click(object sender, EventArgs e)
        {
            caLam.ShowDialog();
        }
        public void change()
        {
            this.BackColor = Color.Green;
            this.ForeColor = Color.Green;
        }

        private void Blank_Load(object sender, EventArgs e)
        {
            if (Static.getUser().GetMaNhanVien()[0] != 'B')
                caLam.LeTan();
        }
    }
}
