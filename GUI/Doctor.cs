using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;
using Project_CNPM.Properties;
using System.Resources;
using DTO;
using System.Diagnostics;

namespace Project_CNPM
{
    public partial class Doctor : Form
    {
        private BS_Home bsHomeForm;

        private const int SidebarMinWidth = 45;
        private const int SidebarMaxWidth = 290;
        private bool sidebarExpanded = false;
        private bool isFirstTimeLoad = true;
        private DTO.User user;

        public Doctor()
        {
            InitializeComponent();
            bsHomeForm = new BS_Home();
            bsHomeForm.ButtonClicked += bsHomeForm_ButtonClicked;
            btnHome.Click += btnHome_Click;
            user = Static.getUser();
        }

        private void hideSubMenu()
        {
            if (panelMenu1.Visible == true)  
                panelMenu1.Visible = false;
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

        private void Doctor_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(bsHomeForm);
            btnUser.Text = user.GetTen();
        }

        //Auto Click
        private void Doctor_Shown(object sender, EventArgs e)
        {
            if (isFirstTimeLoad)
            {
                btnHome_Click(sender, e);
                isFirstTimeLoad = false;
            }
        }

        //Open Menu
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
                        btnHome.Text = "Bác Sĩ";
                    }
                    else
                    {
                        btnHome.Text = "Doctor";
                    }
                    Application.DoEvents();
                }
                showSubMenu(subMenu);
                sidebarExpanded = true; // Đảm bảo sidebar vẫn mở rộng
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
                        btnHome.Text = "Bác Sĩ";
                    }
                    else
                    {
                        btnHome.Text = "Doctor";
                    }
                    Application.DoEvents();
                }
                sidebarExpanded = true;
            }

            openChildForm(childForm);
            showSubMenu(panelMenu1);
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
                        btnHome.Text = "Bác Sĩ";
                    }
                    else
                    {
                        btnHome.Text = "Doctor";
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
                        btnHome.Text = "Bác Sĩ";
                    }
                    else
                    {
                        btnHome.Text = "Doctor";
                    }
                    Application.DoEvents();
                }
                sidebarExpanded = true;
            }

            openChildForm(new BS_Home());
            if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
            {
                ChangeFormBackgroundColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            }
            else
            {
                ChangeFormBackgroundColor(Color.FromArgb(255, 238, 238), Color.FromArgb(52, 203, 236));
            }

            if (activeForm is BS_Home homeForm)
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
                        btnHome.Text = "Bác Sĩ";
                    }
                    else
                    {
                        btnHome.Text = "Doctor";
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
                btnCalendar.FillColor = Color.FromArgb(50, 50, 50);
                btnList.FillColor = Color.FromArgb(50, 50, 50);
                btnReceive.FillColor = Color.FromArgb(50, 50, 50);
                btnTreatment.FillColor = Color.FromArgb(50, 50, 50);
                btnSchedule.FillColor = Color.FromArgb(50, 50, 50);
                btnStatistical.FillColor = Color.FromArgb(50, 50, 50);
                btnLanguage.FillColor = Color.FromArgb(50,50,50);
                btnHome.FillColor = Color.FromArgb(50, 50, 50);
                btnTopic.FillColor = Color.FromArgb(50, 50, 50);
                btnUser.FillColor = Color.FromArgb(50, 50, 50);

                btnCalendar.ForeColor = Color.FromArgb(68, 197, 229);
                btnList.ForeColor = Color.FromArgb(68, 197, 229);
                btnReceive.ForeColor = Color.FromArgb(68, 197, 229);
                btnTreatment.ForeColor = Color.FromArgb(68, 197, 229);
                btnSchedule.ForeColor = Color.FromArgb(68, 197, 229);
                btnStatistical.ForeColor = Color.FromArgb(68, 197, 229);
                btnHome.ForeColor = Color.FromArgb(68, 197, 229);

                panelTop.BackColor = Color.FromArgb(50, 50, 50);
                labelBar1.BackColor = Color.FromArgb(50, 50, 50);
                labelBar2.BackColor = Color.FromArgb(50, 50, 50);
                labelBar3.BackColor = Color.FromArgb(50, 50, 50);
                labelBar4.BackColor = Color.FromArgb(50, 50, 50);
                labelBar5.BackColor = Color.FromArgb(50, 50, 50);
                labelBar6.BackColor = Color.FromArgb(50, 50, 50);

                labelBar1.ForeColor = Color.Cyan;
                labelBar2.ForeColor = Color.Cyan;
                labelBar3.ForeColor = Color.Cyan;
                labelBar4.ForeColor = Color.Cyan;
                labelBar5.ForeColor = Color.Cyan;
                labelBar6.ForeColor = Color.Cyan;

                btnCalendar.Image = Resources.Vector;
                btnList.Image = Resources.qlbn;
                btnReceive.Image = Resources.next11;
                btnTreatment.Image = Resources.next11;
                btnSchedule.Image = Resources.Group;
                btnStatistical.Image = Resources.tkcl;
            }
            else
            {
                btnCalendar.FillColor = Color.FromArgb(68, 197, 229);
                btnList.FillColor = Color.FromArgb(68, 197, 229);
                btnReceive.FillColor = Color.FromArgb(68, 197, 229);
                btnTreatment.FillColor = Color.FromArgb(68, 197, 229);
                btnSchedule.FillColor = Color.FromArgb(68, 197, 229);
                btnStatistical.FillColor = Color.FromArgb(68, 197, 229);
                btnHome.FillColor = Color.FromArgb(68, 197, 229);
                btnLanguage.FillColor = Color.FromArgb(217, 217, 217);
                btnTopic.FillColor = Color.FromArgb(217, 217, 217);
                btnUser.FillColor = Color.FromArgb(217, 217, 217);

                //màu
                btnCalendar.ForeColor = Color.White;
                btnList.ForeColor = Color.White;
                btnReceive.ForeColor = Color.White;
                btnTreatment.ForeColor = Color.White;
                btnSchedule.ForeColor = Color.White;
                btnStatistical.ForeColor = Color.White;
                btnHome.ForeColor = Color.White;

                //
                panelTop.BackColor = Color.FromArgb(217, 217, 217);
                labelBar1.BackColor = Color.FromArgb(68, 197, 229);
                labelBar2.BackColor = Color.FromArgb(68, 197, 229);
                labelBar3.BackColor = Color.FromArgb(68, 197, 229);
                labelBar4.BackColor = Color.FromArgb(68, 197, 229);
                labelBar5.BackColor = Color.FromArgb(68, 197, 229);
                labelBar6.BackColor = Color.FromArgb(68, 197, 229);
                //
                labelBar1.ForeColor = Color.Cyan;
                labelBar2.ForeColor = Color.Cyan;
                labelBar3.ForeColor = Color.Cyan;
                labelBar4.ForeColor = Color.Cyan;
                labelBar5.ForeColor = Color.Cyan;
                labelBar6.ForeColor = Color.Cyan;

                //ảnh
                btnCalendar.Image = Resources.Vector;
                btnList.Image = Resources.qlbn;
                btnReceive.Image = Resources.next11;
                btnTreatment.Image = Resources.next11;
                btnSchedule.Image = Resources.Group;
                btnStatistical.Image = Resources.tkcl;
            }
        }

        //Lịch làm việc
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            OpenForm(new BS_Calendar());    
            if (activeForm is BS_Calendar)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Xem lịch làm việc";
                }
                else
                {
                    labelForm.Text = "View work schedule";
                }
                ResetButtonFillColor();
                btnCalendar.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                btnCalendar.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White: Color.White;
                btnCalendar.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.Vector : Resources.Vector;
                //
                labelBar1.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                labelBar1.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeFormBackgroundColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeFormBackgroundColor(Color.FromArgb(255, 238, 238), Color.FromArgb(52, 203, 236));
                }
            }

        }

        //Xem danh sách bệnh nhân
        private void btnList_Click(object sender, EventArgs e)
        {
            OpenPanel (panelMenu1);
        }
        private void Doctor_receive()
        {
            OpenFormWithMenuAdjustment(new BS_Treatment(), panelMenu1);
            hideSubMenu();
            if (activeForm is BS_Treatment)
            {

                if (isVietnam)
                {
                    labelForm.Text = "Điều trị bệnh nhân";
                }
                else
                {
                    labelForm.Text = "Patient treatment";
                }

                ResetButtonFillColor();
                btnList.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                btnList.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                btnList.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.qlbn: Resources.qlbn;
                //
                labelBar2.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                labelBar2.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);


                btnTreatment.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                btnTreatment.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                btnTreatment.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.next11 : Resources.next11;
                //
                labelBar4.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                labelBar4.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeFormList(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeFormList(Color.FromArgb(255, 238, 238), Color.White);
                }
            }

            if (activeForm is BS_Treatment treatmentForm)
            {
                if (isVietnam)
                    treatmentForm.ChangeLanguage("Vietnam");
                else
                    treatmentForm.ChangeLanguage("English");
            }

        }
        //Tiếp nhận
        private void btnReceive_Click(object sender, EventArgs e)
        {
            BS_Receive receive = new BS_Receive();

            receive.receive = new BS_Receive.Receive(Doctor_receive);
            OpenFormWithMenuAdjustment(receive, panelMenu1);
            if(activeForm is BS_Receive)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Tiếp nhận bệnh nhân";
                }
                else
                {
                    labelForm.Text = "Patient admission";
                }

                ResetButtonFillColor();
                btnList.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                btnList.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                btnList.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.qlbn : Resources.qlbn;
                //
                labelBar2.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                labelBar2.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);

                //

                btnReceive.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                btnReceive.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                btnReceive.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.next11 : Resources.next11;
                //
                labelBar3.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                labelBar3.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeFormList(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeFormList(Color.FromArgb(255, 238, 238), Color.White);
                }
            }

            if (activeForm is BS_Receive receiveForm)
            {
                if (isVietnam)
                    receiveForm.ChangeLanguage("Vietnam");
                else
                    receiveForm.ChangeLanguage("English");
            }
        }

        //Điều trị
        private void btnTreatment_Click(object sender, EventArgs e)
        {
            OpenFormWithMenuAdjustment (new BS_Treatment(), panelMenu1);
            if(activeForm is BS_Treatment)
            {

                if (isVietnam)
                {
                    labelForm.Text = "Điều trị bệnh nhân";
                }
                else
                {
                    labelForm.Text = "Patient treatment";
                }

                ResetButtonFillColor();
                btnList.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                btnList.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                btnList.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.qlbn : Resources.qlbn;
                //
                labelBar2.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                labelBar2.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);


                btnTreatment.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                btnTreatment.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                btnTreatment.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.next11 : Resources.next11;
                //
                labelBar4.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                labelBar4.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeFormList(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeFormList(Color.FromArgb(255, 238, 238), Color.White);
                }
            }

            if (activeForm is BS_Treatment treatmentForm)
            {
                if (isVietnam)
                    treatmentForm.ChangeLanguage("Vietnam");
                else
                    treatmentForm.ChangeLanguage("English");
            }
        }

        //Danh sách tái khám
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenForm (new BS_Schedule());
            if (activeForm is BS_Schedule)
            {

                if (isVietnam)
                {
                    labelForm.Text = "Danh sách tái khám";
                }
                else
                {
                    labelForm.Text = "Re-examination list";
                }

                ResetButtonFillColor();
                btnSchedule.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                btnSchedule.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                btnSchedule.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.Group : Resources.Group;
                //
                labelBar5.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                labelBar5.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeFormList(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeFormList(Color.FromArgb(255, 238, 238), Color.White);
                }
            }

            if (activeForm is BS_Schedule scheduleForm)
            {
                if (isVietnam)
                    scheduleForm.ChangeLanguage("Vietnam");
                else
                    scheduleForm.ChangeLanguage("English");
            }
        }

        //Thống kê ca làm
        private void btnStatistical_Click(object sender, EventArgs e)
        {
            OpenForm(new BS_Statistical());
            if(activeForm is BS_Statistical)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Thống kê ca làm";
                }
                else
                {
                    labelForm.Text = "Work shift statistics";
                }

                ResetButtonFillColor();
                btnStatistical.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                btnStatistical.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                btnStatistical.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.tkcl : Resources.tkcl;
                //
                labelBar6.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                labelBar6.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeFormList(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeFormList(Color.FromArgb(255, 238, 238), Color.White);
                }
            }
        }

        //Change Form
        private Form activeForm = null;
        private void openChildForm (Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            if (childForm is BS_Home bsHome)
            {
                bsHomeForm = bsHome;
                bsHome.ButtonClicked += bsHomeForm_ButtonClicked;
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bsHomeForm_ButtonClicked(object sender, string buttonName)
        {
            switch (buttonName)
            {
                case "Calendar":
                    btnCalendar_Click(sender, EventArgs.Empty);
                    break;
                case "Receive":
                    btnReceive_Click(sender, EventArgs.Empty);
                    hideSubMenu();
                    break;
                case "Treatment":
                    btnTreatment_Click(sender, EventArgs.Empty);
                    hideSubMenu();
                    break;
                case "Schedule":
                    btnSchedule_Click(sender, EventArgs.Empty);
                    break;
                case "Statistical":
                    btnStatistical_Click(sender, EventArgs.Empty);
                    break;
                case "Bill":
                    OpenFormWithMenuAdjustment(new BS_Treatment(), panelMenu1);
                    hideSubMenu();
                    if (activeForm is BS_Treatment treatment)
                    {
                        EventArgs eventArgs = new EventArgs();
                        treatment.btnBill_Click(this, eventArgs);

                        if (isVietnam)
                        {
                            labelForm.Text = "Điều trị bệnh nhân";
                        }
                        else
                        {
                            labelForm.Text = "Patient treatment";
                        }
                        ResetButtonFillColor();
                        btnList.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                        btnList.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                        btnList.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.qlbn : Resources.qlbn;
                        //
                        labelBar2.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                        labelBar2.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);


                        btnTreatment.FillColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                        btnTreatment.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                        btnTreatment.Image = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Resources.next11 : Resources.next11;
                        //
                        labelBar4.BackColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                        labelBar4.ForeColor = (panelMenu.BackColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(6, 127, 238);
                    }
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

        private void Doctor_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnDark_Click(object sender, EventArgs e)
        {
            panelMenu.BackColor = panelHome.BackColor = Color.FromArgb(50, 50, 50);
            ResetButtonFillColor();
            ChangeFormBackgroundColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            ChangeFormList(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));

        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            panelMenu.BackColor = panelHome.BackColor = Color.FromArgb(68,197,229);
            ResetButtonFillColor();
            ChangeFormBackgroundColor(Color.FromArgb(255, 238, 238), Color.FromArgb(52, 203, 236));
            ChangeFormList(Color.FromArgb(255, 238, 238), Color.White);
        }

        //Thay đổi màu form 
        private void ChangeFormBackgroundColor(Color color, Color color2)
        {
            if (activeForm is BS_Home homeForm){
                homeForm.ChangeBackgroundColor(color, color2);
            }
            
            else if (activeForm is BS_Calendar calendarForm)
            {
                calendarForm.ChangeBackgroundColor(color, color2);
            }
        }

        private void ChangeFormList(Color color, Color color2) {

            if (activeForm is BS_Receive receiveForm)
            {
                receiveForm.ChangeBackgroundColor(color, color2);
            }
            else if (activeForm is BS_Treatment treatmentForm)
            {
                treatmentForm.ChangeBackgroundColor(color, color2);
            }
            else if(activeForm is BS_Schedule scheduleForm)
            {
                scheduleForm.ChangeBackgroundColor(color, color2);
            }
            else if(activeForm is BS_Statistical statisticalForm)
            {
                statisticalForm.ChangeBackgroundColor(color, color2);
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
                btnHome.Text = "Bác Sĩ";
            }

            if (labelForm.Text == "Homepage")
            {
                labelForm.Text = "Trang chủ";
            }
            else if (labelForm.Text == "View work schedule")
            {
                labelForm.Text = "Xem lịch làm việc";
            }
            else if (labelForm.Text == "Patient admission")
            {
                labelForm.Text = "Tiếp nhận bệnh nhân";
            }
            else if (labelForm.Text == "Patient treatment")
            {
                labelForm.Text = "Điều trị bệnh nhân";
            }
            else if (labelForm.Text == "Re-examination list")
            {
                labelForm.Text = "Danh sách tái khám";
            }
            else if (labelForm.Text == "Work shift statistics")
            {
                labelForm.Text = "Thống kê ca làm";
            }

            btnLanguage.Text = "Ngôn ngữ";
            btnTopic.Text = "Chủ đề";
            Vietnam.Text = "   Việt Nam";
            English.Text = "   Tiếng Anh";
            btnLight.Text = "   Nền sáng";
            btnDark.Text = "   Nền tối";
            btnChangePass.Text = "   Đổi mật khẩu";
            btnLogOut.Text = "   Đăng xuất";

            btnCalendar.Text = "Xem lịch làm việc";
            btnList.Text = "Xem danh sách bệnh nhân";
            btnReceive.Text = "Tiếp nhận";
            btnTreatment.Text = "Điều trị";
            btnSchedule.Text = "Danh sách tái khám";
            btnStatistical.Text = "Thống kê ca làm";


            ChangeLanguage("Vietnam");
            isVietnam = true;

        }

        private void English_Click(object sender, EventArgs e)
        {
            if(btnHome.Text == "")
            {
                btnHome.Text = "";
            }
            else
            {
                btnHome.Text = "Doctor";
            }

            if (labelForm.Text == "Trang chủ")
            {
                labelForm.Text = "Homepage";
            }
            else if (labelForm.Text == "Xem lịch làm việc")
            {
                labelForm.Text = "View work schedule";
            }
            else if (labelForm.Text == "Tiếp nhận bệnh nhân")
            {
                labelForm.Text = "Patient admission";
            }
            else if (labelForm.Text == "Điều trị bệnh nhân")
            {
                labelForm.Text = "Patient treatment";
            }
            else if (labelForm.Text == "Danh sách tái khám")
            {
                labelForm.Text = "Re-examination list";
            }
            else if (labelForm.Text == "Thống kê ca làm")
            {
                labelForm.Text = "Work shift statistics";
            }

            btnLanguage.Text = "Language";
            btnTopic.Text = "Topic";
            Vietnam.Text = "   Vietnam";
            English.Text = "   English";
            btnLight.Text = "   Light";
            btnDark.Text = "   Dark";
            btnChangePass.Text = "   Change password";
            btnLogOut.Text = "   Log out";

            btnCalendar.Text = "View work schedule";
            btnList.Text = "View patient list";
            btnReceive.Text = "Patient admission";
            btnTreatment.Text = "Patient treatment";
            btnSchedule.Text = "Re-examination list";
            btnStatistical.Text = "Work shift statistics";

            ChangeLanguage("English");
            isVietnam = false;
        }

        private void ChangeLanguage(string language)
        {
            if (activeForm is BS_Home homeForm)
            {
                homeForm.ChangeLanguage(language);
            }
            else if (activeForm is BS_Receive receiveForm)
            {
                receiveForm.ChangeLanguage(language);
            }
            else if (activeForm is BS_Treatment treatmentForm)
            {
                treatmentForm.ChangeLanguage(language);
            }
            else if (activeForm is BS_Schedule scheduleForm)
            {
                scheduleForm.ChangeLanguage(language);
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

        private void labelBar3_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Web web = new Web();
            web.ShowDialog();
        }
    }
}
