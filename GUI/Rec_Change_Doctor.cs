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
    public partial class Rec_Change_Doctor : Form
    {
        public Rec_Change_Doctor(string stt,string maBS)
        {
            InitializeComponent();
            tbName.Text = stt;
            guna2Button1.Text = maBS;
        }

        private void Rec_Change_Doctor_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Owner_Staff owner_Staff = new Owner_Staff();
            owner_Staff.change();
            owner_Staff.truyenBacSi = new Owner_Staff.TruyenBacSi(LoadBacSi);
            owner_Staff.ShowDialog();
        }
        private void LoadBacSi(string text)
        {
            guna2Button1.Text = text;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Text.Length > 0)
            {
                BLL.Rec_List.DoiBacSi(tbName.Text, guna2Button1.Text);
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
