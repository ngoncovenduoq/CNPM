using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project_CNPM
{
    public partial class BS_Home : Form
    {
        public event EventHandler<string> ButtonClicked;

        private Size formSize;
        private Rectangle btn1;
        private Rectangle btn2;
        private Rectangle btn3;
        private Rectangle btn4;
        private Rectangle btn5;
        private Rectangle btn6;

        public BS_Home()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formSize = this.Size;
            btn1 = new Rectangle(btnCalendar1.Location, btnCalendar1.Size);
            btn2 = new Rectangle(btnReceive1.Location, btnReceive1.Size);
            btn3 = new Rectangle(btnTreatment1.Location, btnTreatment1.Size);
            btn4 = new Rectangle(btnSchedule1.Location, btnSchedule1.Size);
            btn5 = new Rectangle(btnStatistical1.Location, btnStatistical1.Size);
        }

        public void ChangeBackgroundColor(Color color, Color color2)
        {
            panelChildForm1.BackColor = color;
            if(color2 == Color.FromArgb(50,50,50))
            {
                btnCalendar1.FillColor = color2;
                btnCalendar1.FillColor2 = color2;

                btnReceive1.FillColor = color2;
                btnReceive1.FillColor2 = color2;

                btnTreatment1.FillColor = color2;
                btnTreatment1.FillColor2 = color2;

                btnSchedule1.FillColor = color2;
                btnSchedule1.FillColor2 = color2;

                btnStatistical1.FillColor = color2;
                btnStatistical1.FillColor2 = color2;

            }
            else
            {
                btnCalendar1.FillColor = color2;
                btnCalendar1.FillColor2 = color2;

                btnReceive1.FillColor = Color.FromArgb(63, 220, 254);
                btnReceive1.FillColor2 = Color.FromArgb(63, 220, 254);

                btnTreatment1.FillColor = Color.FromArgb(63, 220, 254);
                btnTreatment1.FillColor2 = Color.FromArgb(63, 220, 254);

                btnSchedule1.FillColor = color2;
                btnSchedule1.FillColor2 = color2;

                btnStatistical1.FillColor = color2;
                btnStatistical1.FillColor2 = color2;

            }
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                btnCalendar1.Text = "XEM LỊCH LÀM VIỆC";
                btnReceive1.Text = "TIẾP NHẬN";
                btnTreatment1.Text = "ĐIỀU TRỊ";
                btnSchedule1.Text = "DANH SÁCH TÁI KHÁM";
                btnStatistical1.Text = "THỐNG KÊ CA LÀM";
            }
            else
            {
                btnCalendar1.Text = "VIEW WORK SCHEDULE";
                btnReceive1.Text = "PATIENT ADMISSION";
                btnTreatment1.Text = "PATIENT TREATMENT";
                btnSchedule1.Text = "RE-EXAMINATION LIST";
                btnStatistical1.Text = "WORK SHIFT STATISTICS";
            }
        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnCalendar1, btn1);
            resize_Control(btnReceive1, btn2);
            resize_Control(btnTreatment1, btn3);
            resize_Control(btnSchedule1, btn4);
            resize_Control(btnStatistical1, btn5);
        }

        private void resize_Control(Control control, Rectangle rect)
        {
            float xRadio = (float)(this.Width) / (float)(formSize.Width);
            float yRadio = (float)(this.Height) / (float)(formSize.Height);
            int newX = (int)(rect.X * xRadio);
            int newY = (int)(rect.Y * yRadio);

            int newWidth = (int)(rect.Width * xRadio);
            int newHeight = (int)(rect.Height * yRadio);
            
            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void btnCalendar1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Calendar");
        }

        private void btnReceive1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Receive");
        }

        private void btnTreatment1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Treatment");
        }

        private void btnSchedule1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Schedule");
        }

        private void btnStatistical1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Statistical");
        }

        private void btnBill1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Bill");
        }
    }
}
