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
    public partial class Date : UserControl
    {
        public Date(int i)
        {
            InitializeComponent();
            if (i == 8)
            {
                label1.Text = "Chủ nhật";
            }
            else
            {
                label1.Text = "Thứ " + i.ToString();
            }
        }
    }
}
