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
    public partial class Rec_Check : Form
    {
        public delegate void TruyenBenhNhan(string text);
        public TruyenBenhNhan truyenBenhNhan;
        private DataSet _dataSet;
        public Rec_Check()
        {
            InitializeComponent();
            accept.Visible = false;
        }

        public void ChangeLanguage(string language)
        {
            if(language == "Vietnam")
            {
                btnScheduleAppointment.Text = "Chọn lịch hẹn";
                tbSearch.PlaceholderText = "Tìm kiếm";
                btnAddPatient.Text = "Thêm bệnh nhân mới";
                accept.Text = "Xác nhận";
            }
            else
            {
                btnScheduleAppointment.Text = "Schedule Appointment";
                tbSearch.PlaceholderText = "Search";
                btnAddPatient.Text = "Add New Patient";
                accept.Text = "Confirm";
            }
        }

        public void ChangeColor(Color color, Color color2)
        {
            panel1.BackColor = panelTopRight.BackColor = panelTopLeft.BackColor = color;
            guna2DataGridView1.BackgroundColor = color2;
            if (color2 == Color.FromArgb(50,50,50))
            {
                btnScheduleAppointment.FillColor = btnAddPatient.FillColor = accept.FillColor = color2;
                btnScheduleAppointment.ForeColor = Color.White;
                btnScheduleAppointment.Image = Properties.Resources.timetable11;
                tbSearch.FillColor = color2;

                if (activeForm is Rec_AddPatient addPatientForm)
                {
                    addPatientForm.ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
            }
            else
            {
                btnScheduleAppointment.FillColor = Color.FromArgb(63, 220, 254);
                accept.FillColor = Color.FromArgb(64, 165, 93);
                btnAddPatient.FillColor = Color.FromArgb(64, 165, 93);
                tbSearch.FillColor = Color.White;
                btnScheduleAppointment.ForeColor = Color.Black;
                btnScheduleAppointment.Image = Properties.Resources.timetable1;

                if (activeForm is Rec_AddPatient addPatientForm)
                {
                    addPatientForm.ChangeColor(Color.FromArgb(255, 238, 238), Color.White);
                }
            }
        }
        public void change()
        {
            btnScheduleAppointment.Visible = false;
            accept.Visible = true;
            btnAddPatient.Visible = false;
        }

        private void BS_Treatment_Load(object sender, EventArgs e)
        {
            /*panelScheduleAppointment.Visible = false;
            panelAssignDoctor.Visible = false;
            panelService.Visible = false;*/
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.ClearSelection();
            _dataSet = BLL.Owner_Patient.DanhSachBenhNhan();
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            guna2DataGridView1.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
            guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
            guna2DataGridView1.Columns["gioi_tinh"].HeaderText = "Giới tính";
            guna2DataGridView1.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            guna2DataGridView1.Columns["cccd"].HeaderText = "CCCD";
        }

        private void hideSubMenu(Panel panel)
        {
            if (panel.Visible == true)
                panel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void resetButton()
        {
            //Lên lịch tái khám
            
            if (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)){
                btnScheduleAppointment.FillColor = Color.FromArgb(50, 50, 50);
                btnScheduleAppointment.ForeColor = Color.White;
                btnScheduleAppointment.Image = Properties.Resources.timetable11;
            }
            else
            {
                btnScheduleAppointment.FillColor = Color.FromArgb(63, 220, 254);
                btnScheduleAppointment.ForeColor = Color.Black;
                btnScheduleAppointment.Image = Properties.Resources.timetable1;
            }
            
        }

        private void btnScheduleAppointment_Click(object sender, EventArgs e)
        {
            btnScheduleAppointment.FillColor = Color.FromArgb(7, 125, 4);
            btnScheduleAppointment.ForeColor = Color.White;
            btnScheduleAppointment.Image = Properties.Resources.timetable11;
            Rec_AddAppointment rec_AddAppointment = new Rec_AddAppointment();
            rec_AddAppointment.Show();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelShow.Controls.Add(childForm);
            panelShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void hideChildForm()
        {
            if (activeForm is Rec_AddPatient)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            resetButton();
            Rec_AddPatient addPatient = new Rec_AddPatient();
            if(guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)){
                addPatient.ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            }
            else
            {
                addPatient.ChangeColor(Color.FromArgb(255, 238, 238), Color.White);

            }
            addPatient.rechand = new Rec_AddPatient.Rechand(refesh);
            openChildForm(addPatient);
        }

        public void HandleBtnAddPatientClick(object sender, EventArgs e)
        {
            btnAddPatient_Click(sender, e);
        }


        private void refesh()
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.ClearSelection();
            _dataSet = BLL.Owner_Patient.DanhSachBenhNhan();
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];

            guna2DataGridView1.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
            guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
            guna2DataGridView1.Columns["gioi_tinh"].HeaderText = "Giới tính";
            guna2DataGridView1.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            guna2DataGridView1.Columns["cccd"].HeaderText = "CCCD";
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if(guna2DataGridView1.SelectedRows.Count==1)
            {
                string text = guna2DataGridView1.SelectedRows[0].Cells["HoTen"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có muốn chọn bệnh nhân " + text + "?","Đồng ý",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    text = guna2DataGridView1.SelectedRows[0].Cells["MaBN"].Value.ToString();
                    truyenBenhNhan(text);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bệnh nhân");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
            guna2DataGridView1.DataSource = dataView.ToTable();
        }
    }
}
