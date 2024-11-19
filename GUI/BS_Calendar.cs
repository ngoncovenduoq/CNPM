using Guna.UI2.WinForms;
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
    public partial class BS_Calendar : Form
    {
        DateTime date;
        DateTime now = DateTime.Now;
        public BS_Calendar()
        {
            InitializeComponent();
        }

        public void ChangeBackgroundColor(Color color, Color color2)
        {
            panel1.BackColor = panel3.BackColor = color;
            if(color2 == Color.FromArgb(50,50,50))
            {
                this.BackColor = color2;
                flowLayoutPanel1.BackColor = color2;
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
                flowLayoutPanel1.BackColor = Color.FromArgb(240, 240, 240);
            }
        }

        private void show()
        {
            flowLayoutPanel1.Controls.Clear();

            DateTime starMonth = new DateTime(date.Year, date.Month, 1);
            //lấy số ngày trong tháng
            int daysofmonth = DateTime.DaysInMonth(date.Year, date.Month);

            int daysofweek = Convert.ToInt32(starMonth.DayOfWeek.ToString("d"));
            for (int i = 0; i < 7; i++)
            {
                Date d = new Date(i + 2);
                flowLayoutPanel1.Controls.Add(d);
            }

            if (daysofweek == 0)
            {
                daysofweek = 7;
            }
            List<string> strings = BLL.Doctor.GetLichLam(Static.getUser().GetMaNhanVien(), date.Month, date.Year);
            for (int i = 1; i < daysofweek; i++)
            {
                Empty empty = new Empty();
                flowLayoutPanel1.Controls.Add(empty);
            }
            for (int i = 0; i < daysofmonth; i++)
            {
                Blank blank = new Blank(i + 1, date.Month, date.Year, Static.getUser().GetMaNhanVien());
                if (strings.Contains((i + 1).ToString()))
                    blank.change();
                flowLayoutPanel1.Controls.Add(blank);
            }
        }

        private void BS_Calendar_Load(object sender, EventArgs e)
        {
            dateTime.Value = DateTime.Now;
            date = now;
            show();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            date = dateTime.Value.Date;
            show();
        }
    }
}
