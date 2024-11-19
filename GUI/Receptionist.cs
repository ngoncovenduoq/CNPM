using OpenTK.Graphics.ES11;
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
    public partial class Receptionist : Form
    {
        private Rec_Home recHomeForm;

        private const int SidebarMinWidth = 45;
        private const int SidebarMaxWidth = 290;
        private bool sidebarExpanded = false;
        private bool isFirstTimeLoad = true;
        private DTO.User user;

        public Receptionist()
        {
            InitializeComponent();
            recHomeForm = new Rec_Home();
            recHomeForm.ButtonClicked += recHomeForm_ButtonClicked;
            recHomeForm.Click += btnHome_Click;
            user = Static.getUser();
        }

        private void hideSubMenu()
        {
            if (panelMenu1.Visible == true)
                panelMenu1.Visible = false;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(recHomeForm);
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
            if (childForm is Rec_Home recHome)
            {
                recHomeForm = recHome;
                recHome.ButtonClicked += recHomeForm_ButtonClicked;
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
            sidebarExpanded = false;
            openChildForm(childForm);

            if (sidebarExpanded)
            {
                hideSubMenu();
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

                showSubMenu(subMenu);

            }

            while (panelMenu.Width > SidebarMinWidth)
            {
                panelMenu.Width -= 79;
                btnHome.Text = "";
                Application.DoEvents();
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
            else
            {
                openChildForm(childForm);
                hideSubMenu();

                while (panelMenu.Width > SidebarMinWidth)
                {
                    panelMenu.Width -= 79;
                    btnHome.Text = "";
                    Application.DoEvents();
                }
                sidebarExpanded = false;
                return;
            }

            hideSubMenu();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
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

            openChildForm(new Rec_Home());

            if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
            {
                ChangeFormBackgroundColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            }
            else
            {
                ChangeFormBackgroundColor(Color.FromArgb(255, 238, 238), Color.FromArgb(52, 203, 236));
            }

            if (activeForm is Rec_Home homeForm)
            {
                if (isVietnam)
                    homeForm.ChangeLanguage("Vietnam");
                else
                    homeForm.ChangeLanguage("English");
            }

            hideSubMenu();
        }
        private void ResetButtonFillColor()
        {
            if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
            {
                btnReceive.FillColor = Color.FromArgb(50, 50, 50);
                btnCheck.FillColor = Color.FromArgb(50, 50, 50);
                btnList.FillColor = Color.FromArgb(50, 50, 50);
                btnCalendar.FillColor = Color.FromArgb(50, 50, 50);
                btnCashier.FillColor = Color.FromArgb(50, 50, 50);

                btnReceive.ForeColor = Color.White;
                btnCheck.ForeColor = Color.White;
                btnList.ForeColor = Color.White;
                btnCalendar.ForeColor = Color.White;
                btnCashier.ForeColor = Color.White;
                btnHome.ForeColor = Color.White;

                panelTop.BackColor = Color.FromArgb(50, 50, 50);
                btnHome.FillColor = Color.FromArgb(50, 50, 50);
                btnTopic.FillColor = Color.FromArgb(50, 50, 50);
                btnHelp.FillColor = Color.FromArgb(50, 50, 50);
                btnReport.FillColor = Color.FromArgb(50, 50, 50);
                btnUser.FillColor = Color.FromArgb(50, 50, 50);

                labelBar1.BackColor = Color.FromArgb(50, 50, 50);
                labelBar2.BackColor = Color.FromArgb(50, 50, 50);
                labelBar3.BackColor = Color.FromArgb(50, 50, 50);
                labelBar4.BackColor = Color.FromArgb(50, 50, 50);
                labelBar6.BackColor = Color.FromArgb(50, 50, 50);
                btnLanguage.FillColor = Color.FromArgb(50, 50, 50);

                labelBar1.ForeColor = Color.Cyan;
                labelBar2.ForeColor = Color.Cyan;
                labelBar3.ForeColor = Color.Cyan;
                labelBar4.ForeColor = Color.Cyan;
                labelBar6.ForeColor = Color.Cyan;

                btnReceive.Image = Properties.Resources.add11;
                btnCheck.Image = Properties.Resources.next11;
                btnList.Image = Properties.Resources.next11;
                btnCalendar.Image = Properties.Resources.calendar;
                btnCashier.Image = Properties.Resources.cashier1;

            }
            else
            {

                panelTop.BackColor = Color.FromArgb(6, 127, 238);
                btnHome.FillColor = Color.White;
                btnTopic.FillColor = Color.FromArgb(6, 127, 238);
                btnHelp.FillColor = Color.FromArgb(6, 127, 238);
                btnReport.FillColor = Color.FromArgb(6, 127, 238);
                btnUser.FillColor = Color.FromArgb(6, 127, 238);
                btnHome.ForeColor = Color.FromArgb(97, 177, 221);
                btnLanguage.FillColor = Color.FromArgb(6, 127, 238);

                btnReceive.FillColor = Color.White;
                btnCheck.FillColor = Color.White;
                btnList.FillColor = Color.White;
                btnCalendar.FillColor = Color.White;
                btnCashier.FillColor = Color.White;

                //màu
                btnReceive.ForeColor = Color.Black;
                btnCheck.ForeColor = Color.Black;
                btnList.ForeColor = Color.Black;
                btnCalendar.ForeColor = Color.Black;
                btnCashier.ForeColor = Color.Black;

                //
                labelBar1.BackColor = Color.White;
                labelBar2.BackColor = Color.White;
                labelBar3.BackColor = Color.White;
                labelBar4.BackColor = Color.White;
                labelBar6.BackColor = Color.White;
                //
                labelBar1.ForeColor = Color.Cyan;
                labelBar2.ForeColor = Color.Cyan;
                labelBar3.ForeColor = Color.Cyan;
                labelBar4.ForeColor = Color.Cyan;
                labelBar6.ForeColor = Color.Cyan;

                //ảnh
                btnReceive.Image = Properties.Resources.add2;
                btnCheck.Image = Properties.Resources.next1;
                btnList.Image = Properties.Resources.next1;
                btnCalendar.Image = Properties.Resources.calendar1;
                btnCashier.Image = Properties.Resources.cashier;
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            OpenPanel(panelMenu1);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ResetButtonFillColor();
            OpenFormWithMenuAdjustment(new Rec_Check(), panelMenu1);
            if (activeForm is Rec_Check)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Tiếp nhận bệnh nhân";
                }
                else
                {
                    labelForm.Text = "Receive Patient";
                }
                ResetButtonFillColor();
                btnReceive.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnReceive.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                btnReceive.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.add11 : Properties.Resources.add11 ;
                //
                labelBar1.BackColor = labelBar1.ForeColor = Color.FromArgb(6, 127, 238);

                btnCheck.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnCheck.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                btnCheck.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.next11 : Properties.Resources.next11;
                labelBar2.BackColor = labelBar2.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }
            }
            if (activeForm is Rec_Check checkForm)
            {
                if (isVietnam)
                    checkForm.ChangeLanguage("Vietnam");
                else
                    checkForm.ChangeLanguage("English");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ResetButtonFillColor();
            OpenFormWithMenuAdjustment(new Rec_List(), panelMenu1);
            if (activeForm is Rec_List)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Danh sách tiếp nhận bệnh nhân";
                }
                else
                {
                    labelForm.Text = "Reception List";
                }
                ResetButtonFillColor();
                btnReceive.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnReceive.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                btnReceive.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.add11 : Properties.Resources.add11;
                //
                labelBar1.BackColor = labelBar1.ForeColor = Color.FromArgb(6, 127, 238);

                btnList.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnList.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                btnList.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.next11 : Properties.Resources.next11;
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

            if (activeForm is Rec_List listForm)
            {
                if (isVietnam)
                    listForm.ChangeLanguage("Vietnam");
                else
                    listForm.ChangeLanguage("English");
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            OpenForm(new Rec_Calendar());
            if (activeForm is Rec_Calendar)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Xem lịch làm việc của bác sĩ";
                }
                else
                {
                    labelForm.Text = "View Doctor's Work Schedule";
                }
                ResetButtonFillColor();
                btnCalendar.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnCalendar.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.Black : Color.White;
                btnCalendar.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.calendar : Properties.Resources.calendar;
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

        private void btnScheduled_Click(object sender, EventArgs e)
        {
            OpenForm(new Rec_Scheduled());
            if (activeForm is Rec_Scheduled)
            {
                if (isVietnam)
                {
                    labelForm.Text = "Xếp lịch làm việc cho bác sĩ";
                }
                else
                {
                    labelForm.Text = "Schedule appointments for doctors";
                }

                ResetButtonFillColor();
            }

            if (activeForm is Rec_Calendar calendarForm)
            {
                if (isVietnam)
                    calendarForm.ChangeLanguage("Vietnam");
                else
                    calendarForm.ChangeLanguage("English");
            }
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            OpenForm(new Rec_Cashier());
            if (activeForm is Rec_Cashier)
            {
                
                if (isVietnam)
                {
                    labelForm.Text = "Thu ngân";
                }
                else
                {
                    labelForm.Text = "Cashier";
                }

                ResetButtonFillColor();
                btnCashier.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                btnCashier.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.Black : Color.White;
                btnCashier.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.cashier1 : Properties.Resources.cashier1;
                labelBar6.BackColor = labelBar6.ForeColor = Color.FromArgb(6, 127, 238);

                if (panelMenu.BackColor == Color.FromArgb(50, 50, 50))
                {
                    ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }
            }
            if (activeForm is Rec_Cashier cashierForm)
            {
                if (isVietnam)
                    cashierForm.ChangeLanguage("Vietnam");
                else
                    cashierForm.ChangeLanguage("English");
            }
        }

        private void recHomeForm_ButtonClicked(object sender, string buttonName)
        {
            switch (buttonName)
            {
                case "Check":
                    btnCheck_Click(sender, EventArgs.Empty);
                    hideSubMenu();
                    break;
                case "List":
                    btnList_Click(sender, EventArgs.Empty);
                    hideSubMenu();
                    break;
                case "Calendar":
                    btnCalendar_Click(sender, EventArgs.Empty);
                    break;
                case "Scheduled":
                    btnScheduled_Click(sender, EventArgs.Empty);
                    break;
                case "Cashier":
                    btnCashier_Click(sender, EventArgs.Empty);
                    break;
                case "AddPatients":
                    OpenFormWithMenuAdjustment(new Rec_Check(), panelMenu1);
                    hideSubMenu();
                    if (activeForm is Rec_Check checkForm)
                    {
                        checkForm.HandleBtnAddPatientClick(this, EventArgs.Empty);

                        if (isVietnam)
                        {
                            labelForm.Text = "Tiếp nhận bệnh nhân";
                        }
                        else
                        {
                            labelForm.Text = "Receive Patient";
                        }

                        ResetButtonFillColor();
                        btnReceive.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                        btnReceive.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                        btnReceive.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.add11 : Properties.Resources.add11;
                        labelBar1.BackColor = labelBar1.ForeColor = Color.FromArgb(6, 127, 238);
                        btnCheck.FillColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.FromArgb(6, 127, 238);
                        btnCheck.ForeColor = (panelMenu.BackColor == Color.Black) ? Color.DimGray : Color.White;
                        btnCheck.Image = (panelMenu.BackColor == Color.Black) ? Properties.Resources.next11 : Properties.Resources.next11;
                        labelBar2.BackColor = labelBar2.ForeColor = Color.FromArgb(6, 127, 238);
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

        public static bool isExiting = false;

        private void Receptionist_FormClosing(object sender, FormClosingEventArgs e)
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
            panelMenu.BackColor = panelHome.BackColor = Color.White;
            ResetButtonFillColor();
            ChangeFormBackgroundColor(Color.FromArgb(255, 238, 238), Color.FromArgb(52, 203, 236));
            ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            panelMenu.BackColor = panelHome.BackColor = Color.FromArgb(50, 50, 50);
            ResetButtonFillColor();
            ChangeFormBackgroundColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
        }

        private void ChangeFormBackgroundColor(Color color, Color color2)
        {
            if (activeForm is Rec_Home homeForm)
            {
                homeForm.ChangeColor(color, color2);
            }
        }

        private void ChangeColor(Color color, Color color2)
        {
            if (activeForm is Rec_Check checkForm)
            {
                checkForm.ChangeColor(color, color2);
            }
            else if (activeForm is Rec_List listForm){
                listForm.ChangeColor(color, color2);
            }
            else if (activeForm is Rec_Calendar calendarForm)
            {
                calendarForm.ChangeColor(color, color2);
            }
            else if (activeForm is Rec_Cashier cashierForm)
            {
                cashierForm.ChangeColor(color, color2);
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
            else if (labelForm.Text == "Receive Patient")
            {
                labelForm.Text = "Tiếp nhận bệnh nhân";
            }
            else if (labelForm.Text == "Reception List")
            {
                labelForm.Text = "Danh sách tiếp nhận bệnh nhân";
            }
            else if (labelForm.Text == "View Doctor's Work Schedule")
            {
                labelForm.Text = "Xem lịch làm việc của bác sĩ";
            }
            else if (labelForm.Text == "Cashier")
            {
                labelForm.Text = "Thu ngân";
            }

            btnLanguage.Text = "Ngôn ngữ";
            btnTopic.Text = "Chủ đề";
            btnHelp.Text = "Hỗ trợ";
            btnReport.Text = "Báo cáo";
            Vietnam.Text = "   Việt Nam";
            English.Text = "   Tiếng Anh";
            btnLight.Text = "   Nền sáng";
            btnDark.Text = "   Nền tối";
            btnChangePass.Text = "   Đổi mật khẩu";
            btnLogOut.Text = "   Đăng xuất";

            btnReceive.Text = "Tiếp nhận bệnh nhân";
            btnCheck.Text = "Tiếp nhận";
            btnList.Text = "Danh sách tiếp nhận";
            btnCalendar.Text = "Xem lịch làm việc của bác sĩ";
            btnCashier.Text = "Thu ngân";

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
            else if (labelForm.Text == "Tiếp nhận bệnh nhân")
            {
                labelForm.Text = "Receive Patient";
            }
            else if (labelForm.Text == "Danh sách tiếp nhận bệnh nhân")
            {
                labelForm.Text = "Reception List";
            }
            else if (labelForm.Text == "Xem lịch làm việc của bác sĩ")
            {
                labelForm.Text = "View Doctor's Work Schedule";
            }
            else if (labelForm.Text == "Thu ngân")
            {
                labelForm.Text = "Cashier";
            }


            btnLanguage.Text = "Language";
            btnTopic.Text = "Topic";
            btnHelp.Text = "Help";
            btnReport.Text = "Report";
            Vietnam.Text = "   Vietnam";
            English.Text = "   English";
            btnLight.Text = "   Light";
            btnDark.Text = "   Dark";
            btnChangePass.Text = "   Change password";
            btnLogOut.Text = "   Log out";

            btnReceive.Text = "Receive Patient";
            btnCheck.Text = "Check In";
            btnList.Text = "Reception List";
            btnCalendar.Text = "View Doctor's Work Schedule";
            btnCashier.Text = "Cashier";

            ChangeLanguage("English");
            isVietnam = false;
        }

        private void ChangeLanguage(string  language)
        {
            if (activeForm is Rec_Home homeForm)
            {
                homeForm.ChangeLanguage(language);
            }
            else if (activeForm is Rec_Check checkForm)
            {
                checkForm.ChangeLanguage(language);
            }
            else if (activeForm is Rec_List listForm)
            {
                listForm.ChangeLanguage(language);
            }
            else if (activeForm is Rec_Calendar calendarForm)
            {
                calendarForm.ChangeLanguage(language);
            }
            else if (activeForm is Rec_Cashier cashierForm)
            {
                cashierForm.ChangeLanguage(language);
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            Web web = new Web();
            web.ShowDialog();
        }
    }
}
