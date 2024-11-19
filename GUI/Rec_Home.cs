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
    public partial class Rec_Home : Form
    {
        public event EventHandler<string> ButtonClicked;

        private Size formSize;
        private Rectangle btn1;
        private Rectangle btn2;
        private Rectangle btn3;
        private Rectangle btn4;
        private Rectangle btn5;
        private Rectangle btn6;

        public Rec_Home()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formSize = this.Size;
            btn1 = new Rectangle(btnCheck.Location, btnCheck.Size);
            btn2 = new Rectangle(btnList.Location, btnList.Size);
            btn3 = new Rectangle(btnCalendar.Location, btnCalendar.Size);
            btn5 = new Rectangle(btnCashier.Location, btnCashier.Size);
            btn6 = new Rectangle(btnAddPatients.Location, btnAddPatients.Size);
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                btnCheck.Text = "TIẾP NHẬN BỆNH NHÂN";
                btnList.Text = "DANH SÁCH TIẾP NHẬN BỆNH NHÂN";
                btnCalendar.Text = "XEM LỊCH LÀM VIỆC CỦA BÁC SĨ";
                btnCashier.Text = "THU NGÂN";
                btnAddPatients.Text = "THÊM BỆNH NHÂN MỚI";
            }
            else
            {
                btnCheck.Text = "RECEIVE PATIENT";
                btnList.Text = "RECEPTIONIST'S PATIENT LIST";
                btnCalendar.Text = "VIEW DOCTOR'S WORK SCHEDULE";
                btnCashier.Text = "CASHIER";
                btnAddPatients.Text = "ADD NEW PATIENT";
            }
        }

        public void ChangeColor(Color color, Color color2)
        {
            panelChildForm1.BackColor = color;
            if(color2 == Color.FromArgb(50,50,50))
            {
                btnCheck.FillColor = btnCheck.FillColor2 = btnList.FillColor = btnList.FillColor2 = btnCalendar.FillColor = btnCalendar.FillColor2 =
                btnCashier.FillColor = btnCashier.FillColor2 = btnAddPatients.FillColor = btnAddPatients.FillColor2 = color2;
            }
            else
            {
                btnCheck.FillColor = btnCheck.FillColor2 = btnCashier.FillColor = btnCashier.FillColor2 = color2;
                btnList.FillColor = btnList.FillColor2 = btnCalendar.FillColor = btnCalendar.FillColor2 = btnAddPatients.FillColor = btnAddPatients.FillColor2 = Color.FromArgb(63, 220, 254);
            }
        }

/*        public void ChangeBackgroundColor(Color color)
        {
            this.BackColor = color;
        }
*/
        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnCheck, btn1);
            resize_Control(btnList, btn2);
            resize_Control(btnCalendar, btn3);
            resize_Control(btnCashier, btn5);
            resize_Control(btnAddPatients, btn6);
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Check");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "List");
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Calendar");
        }

        private void btnScheduled_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Scheduled");
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Cashier");
        }

        private void btnAddPatients_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "AddPatients");
        }
    }
}
