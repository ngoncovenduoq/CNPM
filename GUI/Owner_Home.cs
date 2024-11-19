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
    public partial class Owner_Home : Form
    {
        public event EventHandler<string> ButtonClicked;

        private Size formSize;
        private Rectangle btn1;
        private Rectangle btn2;
        private Rectangle btn3;
        private Rectangle btn4;
        private Rectangle btn5;
        private Rectangle btn6;
        private Rectangle btn7;
        private Rectangle btn8;
        public Owner_Home()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formSize = this.Size;
            btn1 = new Rectangle(btnStaff.Location, btnStaff.Size);
            btn2 = new Rectangle(btnPatient.Location, btnPatient.Size);
            
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                btnStaff.Text = "THÔNG TIN NHÂN VIÊN";
                btnPatient.Text = "THÔNG TIN BỆNH NHÂN";
                
            }
            else
            {
                btnStaff.Text = "STAFF INFORMATION";
                btnPatient.Text = "PATIENT INFORMATION";
                

            }
        }

        public void ChangeBackgroundColor(Color color, Color color2)
        {
            panelChildForm1.BackColor = color;
            if(color2 == Color.FromArgb(50, 50, 50))
            {
                btnStaff.FillColor = btnStaff.FillColor2 = btnPatient.FillColor = btnPatient.FillColor2 = color2; //btnMedicalInstruments.FillColor = btnMedicalInstruments.FillColor2 = btnIncome.FillColor = btnIncome.FillColor2 =
                    //btnSalary.FillColor = btnSalary.FillColor2 =  = btnPatient.FillColor2 = btnCalendar.FillColor = btnCalendar.FillColor2 = btnSpending.FillColor = 
                    //btnSpending.FillColor2 = btnStatistical.FillColor = btnStatistical.FillColor2 = color2;
            }
            else
            {
                panelChildForm1.BackColor = Color.White ;
                btnStaff.FillColor = btnStaff.FillColor2 = color2; //btnMedicalInstruments.FillColor = btnMedicalInstruments.FillColor2 = btnIncome.FillColor = btnIncome.FillColor2 =
                    //btnSalary.FillColor = btnSalary.FillColor2 = color2;
                btnPatient.FillColor = btnPatient.FillColor2 = Color.FromArgb(63, 220, 254); //btnCalendar.FillColor = btnCalendar.FillColor2 = btnSpending.FillColor = btnSpending.FillColor2 =
                    //btnStatistical.FillColor = btnStatistical.FillColor2 = Color.FromArgb(63, 220, 254);
            }
        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            resize_Control(btnStaff, btn1);
            resize_Control(btnPatient, btn2);
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

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Staff");
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Patient");
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Calendar");
        }

        private void btnMedicalInstruments_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "MedicalInstruments");
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Income");
        }

        private void btnSpending_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Spending");
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Statistical");
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, "Salary");
        }
    }
}

