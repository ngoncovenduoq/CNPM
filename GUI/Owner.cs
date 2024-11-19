using MetroFramework.Properties;
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

namespace Project_CNPM
{
    public partial class Owner : Form
    {
        private Owner_Home owHomeForm;

        private const int SidebarMinWidth = 45;
        private const int SidebarMaxWidth = 290;
        private bool sidebarExpanded = false;
        private bool isFirstTimeLoad = true;
        private DTO.User user;

        public Owner()
        {
            InitializeComponent();
            owHomeForm = new Owner_Home();
            owHomeForm.ButtonClicked += ownerHomeForm_ButtonClicked;
            owHomeForm.Click += btnHome_Click;
            user = Static.getUser();
        }

        private void hideSubMenu()
        {
            if (panelMenu1.Visible == true)
                panelMenu1.Visible = false;
            if (panelMenu2.Visible == true)
                panelMenu2.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            if (childForm is Owner_Home owHome)
            {
                owHomeForm = owHome;
                owHome.ButtonClicked += ownerHomeForm_ButtonClicked;
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenFormWithMenuAdjustment(Form childForm, Panel subMenu)
        {
            openChildForm(childForm);

            if (!sidebarExpanded)
            {
                while (panelMenu.Width < SidebarMaxWidth)
                {
                    panelMenu.Width += 79;
                    if (isVietnam)
                    {
                        btnHome.Text = "Quản lý phòng khám";
                    }
                    else
                    {
                        btnHome.Text = "Clinic Management";
                    }
                    Application.DoEvents();
                }
                showSubMenu(subMenu);
                sidebarExpanded = true; // Đảm bảo sidebar vẫn mở rộng
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(owHomeForm);
            btnUser.Text = user.GetTen();
        }

        private void Doctor_Shown(object sender, EventArgs e)
        {
            if (isFirstTimeLoad)
            {
                btnHome_Click(sender, e);
                isFirstTimeLoad = false;
            }
        }

        //show form
        private void OpenForm(Form childForm)
        {
            if (!sidebarExpanded)
            {
                while (panelMenu.Width < SidebarMaxWidth)
                {
                    panelMenu.Width += 79;
                    if (isVietnam)
                    {
                        btnHome.Text = "Quản lý phòng khám";
                    }
                    else
                    {
                        btnHome.Text = "Clinic Management";
                    }
                    Application.DoEvents();
                }
                sidebarExpanded = true;
            }

            openChildForm(childForm);
            //showSubMenu(panelMenu1); // Hoặc hiển thị menu theo form bạn muốn mở
        }


        //showpanel
        private void OpenPanel(Panel panel)
        {
            sidebarExpanded = !sidebarExpanded;

            if (!sidebarExpanded)
            {
                while (panelMenu.Width < SidebarMaxWidth)
                {
                    panelMenu.Width += 79;
                    if (isVietnam)
                    {
                        btnHome.Text = "Quản lý phòng khám";
                    }
                    else
                    {
                        btnHome.Text = "Clinic Management";
                    }
                    Application.DoEvents();
                }
                showSubMenu(panel);
            }
            else
            {
                hideSubMenu();
            }
        }

        //Home 
        private void btnHome_Click(object sender, EventArgs e)
        {
            ResetButtonFillColor();
            if (isVietnam)
            {
                labelForm.Text = "Trang chủ";
            }
            else
            {
                labelForm.Text = "Homepage";
            }

            if (!sidebarExpanded)
            {
                while (panelMenu.Width < SidebarMaxWidth)
                {
                    panelMenu.Width += 79;
                    if (isVietnam)
                    {
                        btnHome.Text = "Quản lý phòng khám";
                    }
                    else
                    {
                        btnHome.Text = "Clinic Management";
                    }
                    Application.DoEvents();
                }
                sidebarExpanded = true;
            }

            openChildForm(new Owner_Home());
            if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
            {
                ChangeFormBackgroundColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            }
            else
            {
                ChangeFormBackgroundColor(Color.FromArgb(255, 238, 238), Color.FromArgb(52, 203, 236));
            }

            if (activeForm is Owner_Home homeForm)
            {
                if (isVietnam)
                    homeForm.ChangeLanguage("Vietnam");
                else
                    homeForm.ChangeLanguage("English");
            }
            hideSubMenu();
        }

        //nút show menu
        private void buttonListAll_Click(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                while (panelMenu.Width > SidebarMinWidth)
                {
                    panelMenu.Width -= 79;
                    btnHome.Text = "";
                    Application.DoEvents();
                }
                sidebarExpanded = false;
            }
            else
            {
                while (panelMenu.Width < SidebarMaxWidth)
                {
                    panelMenu.Width += 79;
                    if (isVietnam)
                    {
                        btnHome.Text = "Quản lý phòng khám";
                    }
                    else
                    {
                        btnHome.Text = "Clinic Management";
                    }
                    Application.DoEvents();
                }
                sidebarExpanded = true;
            }
        }

        //màu mặc định
        private void ResetButtonFillColor()
        {
            if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
            {
                // màu nền
                btnInformation.FillColor = Color.FromArgb(50, 50, 50);
                btnStaff.FillColor = Color.FromArgb(50, 50, 50);
                btnPatient.FillColor = Color.FromArgb(50, 50, 50);
                btnCalendar.FillColor = Color.FromArgb(50, 50, 50);
                btnMedicalInstruments.FillColor = Color.FromArgb(50, 50, 50);
                btnTransact.FillColor = Color.FromArgb(50, 50, 50);
                btnIncome.FillColor = Color.FromArgb(50, 50, 50);
                btnSpending.FillColor = Color.FromArgb(50, 50, 50);
                btnStatistical.FillColor = Color.FromArgb(50, 50, 50);
                btnSalary.FillColor = Color.FromArgb(50, 50, 50);
                btnLanguage.FillColor = Color.FromArgb(50, 50, 50);

                panelTop.BackColor = Color.FromArgb(50, 50, 50);
                btnHome.FillColor = Color.FromArgb(50, 50, 50);
                btnTopic.FillColor = Color.FromArgb(50, 50, 50);
                btnUser.FillColor = Color.FromArgb(50, 50, 50);

                // màu chữ
                btnInformation.ForeColor = Color.White;
                btnStaff.ForeColor = Color.White;
                btnPatient.ForeColor = Color.White;
                btnCalendar.ForeColor = Color.White;
                btnMedicalInstruments.ForeColor = Color.White;
                btnTransact.ForeColor = Color.White;
                btnIncome.ForeColor = Color.White;
                btnSpending.ForeColor = Color.White;
                btnStatistical.ForeColor = Color.White;
                btnSalary.ForeColor = Color.White;
                btnHome.ForeColor = Color.White;
                labelForm.ForeColor = Color.White;
                btnLanguage.ForeColor = Color.White;
                btnTopic.ForeColor = Color.White;
                btnUser.ForeColor = Color.White;

                labelBar4.ForeColor = labelBar1.ForeColor = labelBar2.ForeColor = labelBar3.ForeColor
                    = labelBar5.ForeColor = labelBar6.ForeColor = labelBar7.ForeColor = labelBar8.ForeColor
                    = labelBar9.ForeColor  = Color.Cyan;

                labelBar4.BackColor = labelBar1.BackColor = labelBar2.BackColor = labelBar3.BackColor
                    = labelBar5.BackColor = labelBar6.BackColor = labelBar7.BackColor = labelBar8.BackColor
                    = labelBar9.BackColor  = Color.FromArgb(50, 50, 50);

                // ảnh
                btnInformation.Image = Properties.Resources.iconQltt;
                btnCalendar.Image = Properties.Resources.iconQlllv;
                btnMedicalInstruments.Image = Properties.Resources.iconQlvtyt;
                btnTransact.Image = Properties.Resources.iconQltc;
                btnStatistical.Image = Properties.Resources.iconDoanhThu;
                btnSalary.Image = Properties.Resources.iconQllnv;
            }
            else
            {
                // màu nền
                btnInformation.FillColor = Color.FromArgb(68, 197, 229);
                btnStaff.FillColor = Color.FromArgb(68, 197, 229);
                btnPatient.FillColor = Color.FromArgb(68, 197, 229);
                btnCalendar.FillColor = Color.FromArgb(68, 197, 229);
                btnMedicalInstruments.FillColor = Color.FromArgb(68, 197, 229);
                btnTransact.FillColor = Color.FromArgb(68, 197, 229);
                btnIncome.FillColor = Color.FromArgb(68, 197, 229);
                btnSpending.FillColor = Color.FromArgb(68, 197, 229);
                btnStatistical.FillColor = Color.FromArgb(68, 197, 229);
                btnSalary.FillColor = Color.FromArgb(68, 197, 229);
                btnHome.FillColor = Color.FromArgb(68, 197, 229);
                btnTopic.FillColor = Color.FromArgb(217, 217, 217);
                btnUser.FillColor = Color.FromArgb(217, 217, 217);
                btnHome.ForeColor = Color.Black;
                btnLanguage.FillColor = Color.FromArgb(217, 217, 217);

                //màu chữ
                btnInformation.ForeColor = Color.White;
                btnStaff.ForeColor = Color.White;
                btnPatient.ForeColor = Color.White;
                btnCalendar.ForeColor = Color.White;
                btnMedicalInstruments.ForeColor = Color.White;
                btnTransact.ForeColor = Color.White;
                btnIncome.ForeColor = Color.White;
                btnSpending.ForeColor = Color.White;
                btnStatistical.ForeColor = Color.White;
                btnSalary.ForeColor = Color.White;
                btnHome.ForeColor = Color.White;
                panelTop.BackColor = Color.FromArgb(217, 217, 217);
                labelForm.ForeColor = Color.Black;
                btnLanguage.ForeColor = Color.Black;
                btnTopic.ForeColor = Color.Black;
                btnUser.ForeColor = Color.Black;

                //
                labelBar4.BackColor = labelBar1.BackColor = labelBar2.BackColor = labelBar3.BackColor
                    = labelBar5.BackColor = labelBar6.BackColor = labelBar7.BackColor = labelBar8.BackColor
                    = labelBar9.BackColor = Color.FromArgb(68, 197, 229);

                //
                labelBar4.ForeColor = labelBar1.ForeColor = labelBar2.ForeColor = labelBar3.ForeColor
                    = labelBar5.ForeColor = labelBar6.ForeColor = labelBar7.ForeColor = labelBar8.ForeColor
                    = labelBar9.ForeColor = Color.Cyan;

                //ảnh
                btnInformation.Image = Properties.Resources.iconQltt;
                btnCalendar.Image = Properties.Resources.iconQlllv;
                btnMedicalInstruments.Image = Properties.Resources.iconQlvtyt;
                btnTransact.Image = Properties.Resources.iconQltc;
                btnStatistical.Image = Properties.Resources.iconDoanhThu;
                btnSalary.Image = Properties.Resources.iconQllnv;
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            OpenPanel(panelMenu1);
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            OpenPanel(panelMenu2);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenFormWithMenuAdjustment(new Owner_Staff(), panelMenu1);
            if (activeForm is Owner_Staff)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Thông tin nhân viên";
                }
                else
                {
                    labelForm.Text = "Staff information";
                }

                ResetButtonFillColor();
                btnInformation.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnInformation.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                btnInformation.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.iconQltt : Properties.Resources.iconQltt;
                //
                labelBar1.BackColor = labelBar1.ForeColor = Color.FromArgb(6, 127, 238);

                btnStaff.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnStaff.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                //
                labelBar2.BackColor = labelBar2.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(6, 127, 238))
                {
                    ChangeColor(Color.FromArgb(6, 127, 238), Color.FromArgb(6, 127, 238));
                }
                else
                {
                    ChangeColor(Color.FromArgb(6, 127, 238), Color.White);
                }
            }

            if (activeForm is Owner_Staff staffForm)
            {
                if (isVietnam)
                    staffForm.ChangeLanguage("Vietnam");
                else
                    staffForm.ChangeLanguage("English");
            }
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            OpenFormWithMenuAdjustment(new Owner_Patient(), panelMenu1);
            if (activeForm is Owner_Patient)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Thông tin bệnh nhân";
                }
                else
                {
                    labelForm.Text = "Patient information";
                }

                ResetButtonFillColor();
                btnInformation.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnInformation.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                btnInformation.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.iconQltt : Properties.Resources.iconQltt;
                //
                labelBar1.BackColor = labelBar1.ForeColor = Color.FromArgb(6, 127, 238);

                btnPatient.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnPatient.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                //
                labelBar3.BackColor = labelBar3.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }
            }
            if (activeForm is Owner_Patient patientForm)
            {
                if (isVietnam)
                    patientForm.ChangeLanguage("Vietnam");
                else
                    patientForm.ChangeLanguage("English");
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            OpenForm(new Owner_Calendar());
            if (activeForm is Owner_Calendar)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Quản lý lịch làm việc";
                }
                else
                {
                    labelForm.Text = "Schedule management";
                }
                ResetButtonFillColor();
                btnCalendar.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnCalendar.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.Black : Color.White;
                btnCalendar.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.iconQlllv : Properties.Resources.iconQlllv;
                //
                labelBar4.BackColor = labelBar4.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }

            }

        }

        private void btnMedicalInstruments_Click(object sender, EventArgs e)
        {
            OpenForm(new Owner_MedicalInstruments());
            if (activeForm is Owner_MedicalInstruments)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Quản lý vật tư - Vật dụng y tế";
                }
                else
                {
                    labelForm.Text = "Medical supplies management";
                }
                ResetButtonFillColor();
                btnMedicalInstruments.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnMedicalInstruments.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.Black : Color.White;
                btnMedicalInstruments.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.iconQlvtyt : Properties.Resources.iconQlvtyt;
                //
                labelBar5.BackColor = labelBar5.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }
            }
            if (activeForm is Owner_MedicalInstruments medicalInstrumentsForm)
            {
                if (isVietnam)
                    medicalInstrumentsForm.ChangeLanguage("Vietnam");
                else
                    medicalInstrumentsForm.ChangeLanguage("English");
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            OpenFormWithMenuAdjustment(new Owner_Income(), panelMenu2);
            if (activeForm is Owner_Income)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Thu nhập";
                }
                else
                {
                    labelForm.Text = "Income";
                }

                ResetButtonFillColor();
                btnTransact.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnTransact.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                btnTransact.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.iconQltc : Properties.Resources.iconQltc;
                //
                labelBar6.BackColor = labelBar6.ForeColor = Color.FromArgb(6, 127, 238);

                btnIncome.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnIncome.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                //
                labelBar7.BackColor = labelBar7.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }
            }
            if (activeForm is Owner_Income incomeForm)
            {
                if (isVietnam)
                    incomeForm.ChangeLanguage("Vietnam");
                else
                    incomeForm.ChangeLanguage("English");
            }
        }

        private void btnSpending_Click(object sender, EventArgs e)
        {
            OpenFormWithMenuAdjustment(new Owner_Spending(), panelMenu2);
            if (activeForm is Owner_Spending)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Chi tiêu";
                }
                else
                {
                    labelForm.Text = "Spending";
                }

                ResetButtonFillColor();
                btnTransact.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnTransact.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                btnTransact.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.iconQltc : Properties.Resources.iconQltc;
                //
                labelBar6.BackColor = labelBar6.ForeColor = Color.FromArgb(6, 127, 238);

                btnSpending.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnSpending.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                //
                labelBar8.BackColor = labelBar8.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }
            }
            if (activeForm is Owner_Spending spendingForm)
            {
                if (isVietnam)
                    spendingForm.ChangeLanguage("Vietnam");
                else
                    spendingForm.ChangeLanguage("English");
            }
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            OpenForm(new Owner_Statistical());
            if (activeForm is Owner_Statistical)
            {
                labelForm.Text = "Quản lý doanh thu";
                ResetButtonFillColor();
                btnStatistical.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnStatistical.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.Black : Color.White;
                btnStatistical.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.iconDoanhThu : Properties.Resources.iconDoanhThu;
                //
                labelBar9.BackColor = labelBar9.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }

            }
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            OpenForm(new Owner_Salary());
            if (activeForm is Owner_Salary)
            {
                labelForm.Text = "Quản lý lương nhân viên";
                ResetButtonFillColor();
                btnSalary.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnSalary.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.Black : Color.White;
                btnSalary.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.iconQllnv : Properties.Resources.iconQllnv;
                //
                //labelBar10.BackColor = labelBar10.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }
            }
        }

        private void ownerHomeForm_ButtonClicked(object sender, string buttonName)
        {
            switch (buttonName)
            {
                case "Staff":
                    btnStaff_Click(sender, EventArgs.Empty);
                    hideSubMenu();
                    break;
                case "Patient":
                    btnPatient_Click(sender, EventArgs.Empty);
                    hideSubMenu();
                    break;
                case "Calendar":
                    btnCalendar_Click(sender, EventArgs.Empty);
                    break;
                case "MedicalInstruments":
                    btnMedicalInstruments_Click(sender, EventArgs.Empty);
                    break;
                case "Income":
                    btnIncome_Click(sender, EventArgs.Empty);
                    hideSubMenu();
                    break;
                case "Spending":
                    btnSpending_Click(sender, EventArgs.Empty);
                    hideSubMenu();
                    break;
                case "Statistical":
                    btnStatistical_Click(sender, EventArgs.Empty);
                    break;
                case "Salary":
                    btnSalary_Click(sender, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }

        private void btnTopic_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                menuTopic.Show(Cursor.Position);
            }
        }

        private void btnUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                menuUser.Show(Cursor.Position);
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword();
            changePasswordForm.ShowDialog();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            BLL.Login.Luu(new DTO.Account(), false);
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private static bool isExiting = false;
        private void Owner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExiting)
            {
                DialogResult dialog;
                if (isVietnam)
                {
                    dialog = MessageBox.Show("Bạn có chắc chắn muốn đóng không?", "Xác nhận", MessageBoxButtons.YesNo);
                }
                else
                {
                    dialog = MessageBox.Show("Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo);
                }

                if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    isExiting = true;
                    Application.Exit();
                }
            }
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            panelMenu.BackColor = panelHome.BackColor = Color.FromArgb(68, 197, 229);
            ResetButtonFillColor();
            ChangeFormBackgroundColor(Color.FromArgb(255, 238, 238), Color.FromArgb(52, 203, 236));
            ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
            changeCalendar(Color.FromArgb(255, 238, 238), Color.FromArgb(255, 238, 238));
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            panelMenu.BackColor = panelHome.BackColor = Color.FromArgb(50, 50, 50);
            ResetButtonFillColor();
            ChangeFormBackgroundColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            changeCalendar(Color.FromArgb(45, 38, 38), Color.FromArgb(50,50,50));
        }

        private void ChangeFormBackgroundColor(Color color, Color color2)
        {
            if (activeForm is Owner_Home homeForm)
            {
                homeForm.ChangeBackgroundColor(color, color2);
            }
        }

        private void ChangeColor(Color color, Color color2)
        {
            if (activeForm is Owner_Staff staffForm)
            {
                staffForm.ChangeBackgroundColor(color, color2);
            }
            else if (activeForm is  Owner_Patient patientForm)
            {
                patientForm.ChangeBackgroundColor(color, color2);
            }
            else if (activeForm is Owner_MedicalInstruments instrumentForm)
            {
                instrumentForm.ChangeColor(color, color2);
            }
            else if (activeForm is Owner_Income incomeForm)
            {
                incomeForm.ChangeColor(color, color2);
            }
            else if (activeForm is Owner_Spending spendingForm)
            {
                spendingForm.ChangeColor(color, color2);
            }
            else if (activeForm is Owner_Statistical statisticalForm)
            {
                statisticalForm.ChangeBackgroundColor(color, color2);
            }
            else if (activeForm is Owner_Salary salaryForm)
            {
                salaryForm.ChangeColor(color, color2);
            }
        }
        
        public void changeCalendar(Color color, Color color2)
        {
            if (activeForm is Owner_Calendar calendarForm)
            {
                calendarForm.ChangeColor(color, color2);
            }
        }

        private void btnLanguage_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                menuLanguage.Show(Cursor.Position);
            }
        }

        private static bool isVietnam = true;

        private void Vietnam_Click(object sender, EventArgs e)
        {
            if (btnHome.Text == "")
            {
                btnHome.Text = "";
            }
            else
            {
                btnHome.Text = "Quản lý phòng khám";
            }

            if (labelForm.Text == "Homepage")
            {
                labelForm.Text = "Trang chủ";
            }
            else if (labelForm.Text == "Staff information"){
                labelForm.Text = "Thông tin nhân viên";
            }
            else if (labelForm.Text == "Patient information")
            {
                labelForm.Text = "Thông tin bệnh nhân";
            }
            else if (labelForm.Text == "Medical supplies management")
            {
                labelForm.Text = "Quản lý vật tư - Vật dụng y tế";
            }
            else if (labelForm.Text == "Income")
            {
                labelForm.Text = "Thu nhập";
            }
            else if (labelForm.Text == "Spending")
            {
                labelForm.Text = "Chi tiêu";
            }

            btnLanguage.Text = "Ngôn ngữ";
            btnTopic.Text = "Chủ đề";
            Vietnam.Text = "   Việt Nam";
            English.Text = "   Tiếng Anh";
            btnLight.Text = "   Nền sáng";
            btnDark.Text = "   Nền tối";
            btnChangePass.Text = "   Đổi mật khẩu";
            btnLogOut.Text = "   Đăng xuất";

            btnInformation.Text = "Xem tất cả thông tin";
            btnStaff.Text = "Nhân viên";
            btnPatient.Text = "Bệnh nhân";
            btnCalendar.Text = "Quản lý lịch làm việc";
            btnMedicalInstruments.Text = "Quản lý vật tư - Vật dụng y tế";
            btnTransact.Text = "Quản lý thu chi";
            btnIncome.Text = "Thu nhập";
            btnSpending.Text = "Chi tiêu";
            btnStatistical.Text = "Thống kê doanh thu";
            btnSalary.Text = "Quản lý lương nhân viên";
            ChangeLanguage("Vietnam");

            isVietnam = true;
        }

        private void English_Click(object sender, EventArgs e)
        {
            if (btnHome.Text == "")
            {
                btnHome.Text = "";
            }
            else
            {
                btnHome.Text = "Clinic Management";
            }

            if (labelForm.Text == "Trang chủ")
            {
                labelForm.Text = "Homepage";
            }
            else if (labelForm.Text == "Thông tin nhân viên"){
                labelForm.Text = "Staff information";
            }
            else if (labelForm.Text == "Thông tin bệnh nhân")
            {
                labelForm.Text = "Patient information";
            }
            else if (labelForm.Text == "Quản lý vật tư - Vật dụng y tế")
            {
                labelForm.Text = "Medical supplies management";
            }
            else if (labelForm.Text == "Thu nhập")
            {
                labelForm.Text = "Income";
            }
            else if (labelForm.Text == "Chi tiêu")
            {
                labelForm.Text = "Spending";
            }

            btnLanguage.Text = "Language";
            btnTopic.Text = "Topic";
            Vietnam.Text = "   Vietnam";
            English.Text = "   English";
            btnLight.Text = "   Light";
            btnDark.Text = "   Dark";
            btnChangePass.Text = "   Change password";
            btnLogOut.Text = "   Log out";

            btnInformation.Text = "View all information";
            btnStaff.Text = "Staff";
            btnPatient.Text = "Patient";
            btnCalendar.Text = "Schedule management";
            btnMedicalInstruments.Text = "Medical supplies management";
            btnTransact.Text = "Transaction management";
            btnIncome.Text = "Income";
            btnSpending.Text = "Spending";
            btnStatistical.Text = "Revenue statistics";
            btnSalary.Text = "Staff salary management";

            ChangeLanguage("English");
            isVietnam = false;
        }

        private void ChangeLanguage(string language)
        {
            if (activeForm is Owner_Home homeForm)
            {
                homeForm.ChangeLanguage(language);
            }
            else if (activeForm is Owner_Staff staffForm)
            {
                staffForm.ChangeLanguage(language);
            }
            else if (activeForm is Owner_Patient patientForm)
            {
                patientForm.ChangeLanguage(language);
            }
            else if (activeForm is Owner_MedicalInstruments medicalInstrumentsForm)
            {
                medicalInstrumentsForm.ChangeLanguage(language);
            }
            else if (activeForm is Owner_Income incomeForm)
            {
                incomeForm.ChangeLanguage(language);
            }
            else if (activeForm is Owner_Spending spendingForm)
            {
                spendingForm.ChangeLanguage(language);
            }
            else if (activeForm is Owner_Calendar calendarForm)
            {
                calendarForm.changeLanguage(language);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegiFace regiFace = new RegiFace();
            if (btnLanguage.Text == "Ngôn ngữ")
            {
                regiFace.changeLanguage("Vietnam");
            }
            else
            {
                regiFace.changeLanguage("English");
            }

            if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
            {
                regiFace.changeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            }
            else
            {
                regiFace.changeColor(Color.WhiteSmoke, Color.White);
            }

            regiFace.ShowDialog();
        }
    }
}
