using MetroFramework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_CNPM.Properties;
using System.Resources;
using System.Collections;
using DTO;
using Guna.UI2.WinForms;

namespace Project_CNPM
{
    public partial class BS_Treatment : Form
    {
        DataSet _dataSet;
        private int trangthai;
        private string stt;
        DataTable table;
        private string name;
        private string maBN;
        public BS_Treatment()
        {
            InitializeComponent();
            trangthai = 0;
        }

        public void ChangeBackgroundColor(Color color, Color color2)
        {
            panelTopRight.BackColor = panel5.BackColor = panelService.BackColor = panelServiceLeft.BackColor = panel3.BackColor = panel2.BackColor = panePatient.BackColor = panelLeft.BackColor = panelTool.BackColor = panel4.BackColor = color;
            guna2DataGridView1.BackgroundColor = color2;
            resetButton();

            if (activeForm is Benh_An createInvoice)
            {
                if (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50))
                {
                    createInvoice.ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
                }
                else
                {
                    createInvoice.ChangeColor(Color.White, Color.WhiteSmoke);
                }
            }
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                btnPatient.Text = "Bệnh nhân";
                btnService.Text = "Dịch vụ";
                btnPrescription.Text = "Kê đơn";
                btnTool.Text = "Chi tiêu";
                guna2Button2.Text = guna2Button3.Text = guna2Button4.Text = guna2Button5.Text = "Trở về";
                guna2Button6.Text = btnAdd.Text = "Thêm";
                btnUpdate.Text = "Chỉnh sửa";
                btnDone.Text = guna2Button7.Text = guna2Button8.Text = "Hoàn tất";
                btnUpdate1.Text = btnUpdate2.Text = "Chỉnh sửa";
                guna2Button9.Text = btnDelete.Text = "Xóa";
                btnDone1.Text = "Hoàn tất điều trị";
                guna2Button10.Text = "Theo dõi điều trị";
                btnBill.Text = "Bệnh án";

                if (activeForm is Benh_An createInvoice)
                {
                    createInvoice.ChangeLanguage(language);
                }
            }
            else
            {
                btnPatient.Text = "Patient";
                btnService.Text = "Service";
                btnPrescription.Text = "Prescription";
                btnTool.Text = "Expense Tool";
                guna2Button2.Text = guna2Button3.Text = guna2Button4.Text = guna2Button5.Text = "Back";
                guna2Button6.Text = btnAdd.Text = "Add";
                btnUpdate.Text = "Update";
                btnDone.Text = guna2Button7.Text = guna2Button8.Text = "Done";
                btnUpdate1.Text = btnUpdate2.Text = "Edit";
                guna2Button9.Text = btnDelete.Text = "Delete";
                btnDone1.Text = "Treatment Done";
                guna2Button10.Text = "Treatment Follow-up Form";
                btnBill.Text = "View Medical Records";
            }
        }

        private void BS_Treatment_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;

            _dataSet = BLL.Doctor.DaTiepNhan(DateTime.Now, Static.getUser().GetMaNhanVien());
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            panelPrescription.Visible = false;
            panelService.Visible = false;
            panelTool.Visible = false;
            panePatient.Visible = false;
            btnBill.Visible = false;
            guna2Button10.Visible = false;

            guna2DataGridView1.Columns["STT"].HeaderText = "Số thứ tự";
            guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            guna2DataGridView1.Columns["Gioi_tinh"].HeaderText = "Giới tính";
            guna2DataGridView1.Columns["Ma_benh_nhan"].HeaderText = "Mã bệnh nhân";
            guna2DataGridView1.Columns["Ghi_chu"].HeaderText = "Ghi chú";
        }

        private void HideSubMenu(Panel panel)
        {
            if (panel.Visible == true)
                panel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void resetButton()
        {

            if (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50))
            {
                btnPatient.FillColor = Color.FromArgb(50, 50, 50);
                btnPatient.ForeColor = Color.White;
           

                //Dịch vụ
                btnService.FillColor = Color.FromArgb(50, 50, 50);
                btnService.ForeColor = Color.White;
                

                //Kê đơn
                btnPrescription.FillColor = Color.FromArgb(50, 50, 50);
                btnPrescription.ForeColor = Color.White;
                


                //Tạo hóa đơn
                btnBill.FillColor = Color.FromArgb(50, 50, 50);
                btnBill.ForeColor = Color.White;
              

                guna2Button10.FillColor = Color.FromArgb(50, 50, 50);
                guna2Button10.ForeColor = Color.White;
     


                //Dụng cụ
                btnTool.ForeColor = Color.White;
                btnTool.FillColor = Color.FromArgb(50, 50, 50);
               

                 btnDelete.FillColor = Color.FromArgb(230, 34, 34);
                guna2Button7.FillColor = Color.FromArgb(0, 171, 43);
                guna2Button4.FillColor = btnDone1.FillColor =  Color.FromArgb(50, 50, 50);
                 guna2Button8.FillColor = Color.FromArgb(0, 171, 43);
                btnUpdate.FillColor = Color.FromArgb(3, 198, 215);
                btnAdd.FillColor = Color.FromArgb(72, 138, 236);
                btnUpdate1.FillColor = Color.FromArgb(3, 198, 215);
                btnDone.FillColor = Color.FromArgb(0, 171, 43);
                guna2Button3.FillColor = Color.FromArgb(0, 171, 43);
                btnUpdate2.FillColor = Color.FromArgb(3, 198, 215);
                guna2Button5.FillColor = Color.FromArgb(0, 171, 43);
            }
            else
            {
                //Bệnh nhân
                btnPatient.FillColor = Color.FromArgb(255, 255, 255);
                btnPatient.ForeColor = Color.Black;
                

                //Dịch vụ
                btnService.FillColor = Color.FromArgb(255, 255, 255);
                btnService.ForeColor = Color.Black;
              

                //Kê đơn
                btnPrescription.FillColor = Color.FromArgb(255, 255, 255);
                btnPrescription.ForeColor = Color.Black;
             


                //Tạo hóa đơn
                btnBill.FillColor = Color.FromArgb(255, 255, 255);
                btnBill.ForeColor = Color.Black;
              

                guna2Button10.FillColor = Color.FromArgb(255, 255, 255);
                guna2Button10.ForeColor = Color.Black;
               

                //Dụng cụ
                btnTool.ForeColor = Color.Black;
                btnTool.FillColor = Color.FromArgb(255, 255, 255);
                guna2Button7.FillColor = Color.FromArgb(0, 171, 43); 

                guna2Button2.FillColor =   guna2Button3.FillColor = 
                guna2Button4.FillColor = btnDone1.FillColor = guna2Button5.FillColor = Color.FromArgb(0, 171, 43);
                guna2Button6.FillColor = Color.FromArgb(72, 138, 236);
                btnUpdate.FillColor = Color.FromArgb(3, 198, 215);
                btnDelete.FillColor  = Color.FromArgb(230, 34, 34);
                btnAdd.FillColor = Color.FromArgb(72, 138, 236);
                btnUpdate1.FillColor = Color.FromArgb(3, 198, 215);
                btnDone.FillColor = Color.FromArgb(0, 171, 43);
                btnUpdate2.FillColor = Color.FromArgb(3, 198, 215);
            }

        }

        //Thay đổi form

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
            if (activeForm is Benh_An)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            resetButton();
            showSubMenu(panePatient);
            HideSubMenu(panelTool);
            HideSubMenu(panelPrescription);
            HideSubMenu(panelService);
            hideChildForm();
            btnPatient.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnPatient.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            HideSubMenu(panePatient);
            showSubMenu(panelService);
            HideSubMenu(panelTool);
            HideSubMenu(panelPrescription);
            resetButton();
            hideChildForm();
            btnService.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnService.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            HideSubMenu(panePatient);
            showSubMenu(panelPrescription);
            HideSubMenu(panelTool);
            HideSubMenu(panelService);
            resetButton();
            hideChildForm();
            btnPrescription.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnPrescription.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {

        }

        public void btnBill_Click(object sender, EventArgs e)
        {
            Benh_An createInnovaForm = new Benh_An(maBN);

            if (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50))
            {
                createInnovaForm.ChangeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            }
            else
            {
                createInnovaForm.ChangeColor(Color.White, Color.WhiteSmoke);
            }

            if (btnPatient.Text == "Pantient")
            {
                createInnovaForm.ChangeLanguage("English");
            }
            else
            {
                createInnovaForm.ChangeLanguage("Vietnam");
            }
            createInnovaForm.ShowDialog();
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            resetButton();
            HideSubMenu(panePatient);
            HideSubMenu(panelPrescription);
            showSubMenu(panelTool);
            HideSubMenu(panelService);
            hideChildForm();
            btnTool.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnTool.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                BS_Treatment_Update updateForm = new BS_Treatment_Update(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                updateForm.ChangeLanguage(btnPatient.Text == "Bệnh nhân" ? "Vietnam" : "English");
                updateForm.bS_Treatment_UpdateEventHandler = new BS_Treatment_Update.BS_Treatment_UpdateEventHandler(doi);

                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ");
            }
        }

        private void doi(string text1, string text2)
        {
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == text1)
                {
                    row.Cells[1].Value = text2;
                    break;
                }
            }
        }
        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (trangthai == 0)
            {
                stt = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                name = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                maBN = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                HideSubMenu(panePatient);
                showSubMenu(panelService);
                HideSubMenu(panelTool);
                HideSubMenu(panelPrescription);
                resetButton();
                hideChildForm();
                btnService.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
                btnService.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
                

                _dataSet = BLL.Doctor.Dichvu(stt);
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                guna2DataGridView1.DataSource = _dataSet.Tables[0];
                guna2DataGridView1.Columns["Ten_dich_vu"].HeaderText = "Tên dịch vụ";
                guna2DataGridView1.Columns["so_luong"].HeaderText = "Số lượng";
                btnBill.Visible = true;
                btnBill.Enabled = true;
                guna2Button10.Visible = true;
                guna2Button10.Enabled = true;
                trangthai = 1;
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            resetButton();
            HideSubMenu(panePatient);
            HideSubMenu(panelTool);
            HideSubMenu(panelPrescription);
            HideSubMenu(panelService);
            hideChildForm();
            btnPatient.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnPatient.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
           
            _dataSet = BLL.Doctor.DaTiepNhan(DateTime.Now, Static.getUser().GetMaNhanVien());
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            guna2DataGridView1.Columns["STT"].HeaderText = "Số thứ tự";
            guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            guna2DataGridView1.Columns["Gioi_tinh"].HeaderText = "Giới tính";
            guna2DataGridView1.Columns["Ma_benh_nhan"].HeaderText = "Mã bệnh nhân";
            guna2DataGridView1.Columns["Ghi_chu"].HeaderText = "Ghi chú";
            btnBill.Visible = false;
            guna2Button10.Visible = false;
            trangthai = 0;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DataTable data = guna2DataGridView1.DataSource as DataTable;
            BLL.Doctor.Doisoluong(data, stt);
            HideSubMenu(panePatient);
            showSubMenu(panelPrescription);
            HideSubMenu(panelTool);
            HideSubMenu(panelService);
            resetButton();
            hideChildForm();
            btnPrescription.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnPrescription.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
          
            trangthai = 2;
            _dataSet = BLL.Doctor.Thuoc(stt);
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            guna2DataGridView1.Columns["Ten_thuoc"].HeaderText = "Tên thuốc";
            guna2DataGridView1.Columns["So_luong"].HeaderText = "Số lượng";
            guna2DataGridView1.Columns["Ghi_chu"].HeaderText = "Ghi chú";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            HideSubMenu(panePatient);
            showSubMenu(panelService);
            HideSubMenu(panelTool);
            HideSubMenu(panelPrescription);
            resetButton();
            hideChildForm();
            btnService.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnService.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
           

            _dataSet = BLL.Doctor.Dichvu(stt);
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            guna2DataGridView1.Columns["Ten_dich_vu"].HeaderText = "Tên dịch vụ";
            guna2DataGridView1.Columns["so_luong"].HeaderText = "Số lượng";
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            trangthai = 1;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Owner_MedicalInstruments owner = new Owner_MedicalInstruments();
            owner.ChangeLanguage(btnPatient.Text == "Bệnh nhân" ? "Vietnam" : "English");
            owner.change1();
            owner.truyenDichVu = new Owner_MedicalInstruments.TruyenDichVu(loadDichVu);
            owner.setTrangThai();
            owner.ShowDialog();
        }
        private void loadDichVu(List<string> list)
        {
            foreach (string text in list)
            {
                bool check = true;
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(text))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    DataRow newRow = _dataSet.Tables[0].NewRow();
                    newRow[0] = text;
                    newRow[1] = "0";
                    _dataSet.Tables[0].Rows.Add(newRow);
                }
            }
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            guna2DataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;

            guna2DataGridView1.Sort(guna2DataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Owner_MedicalInstruments owner = new Owner_MedicalInstruments();
            owner.ChangeLanguage(btnPatient.Text == "Bệnh nhân" ? "Vietnam" : "English");
            owner.change1();
            owner.truyenThuoc = new Owner_MedicalInstruments.TruyenDichVu(loadThuoc);
            owner.setThuoc();
            owner.ShowDialog();
        }
        private void loadThuoc(List<string> list)
        {
            foreach (string text in list)
            {
                bool check = true;
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(text))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    DataRow newRow = _dataSet.Tables[0].NewRow();
                    newRow[0] = text;
                    newRow[1] = "0";
                    newRow[2] = "";
                    _dataSet.Tables[0].Rows.Add(newRow);
                }
            }
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            guna2DataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;

            guna2DataGridView1.Sort(guna2DataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            DataTable data = guna2DataGridView1.DataSource as DataTable;
            BLL.Doctor.Themthuoc(data, stt);
            table = new DataTable();
            table.Columns.Add("Tên vật liệu", typeof(string));
            table.Columns.Add("Số lượng", typeof(int));
            guna2DataGridView1.DataSource = table;
            resetButton();
            HideSubMenu(panePatient);
            HideSubMenu(panelPrescription);
            showSubMenu(panelTool);
            HideSubMenu(panelService);
            hideChildForm();
            btnTool.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnTool.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            

            List<string> list = new List<string>();
            list = BLL.Doctor.DanhSachVatLieu();

            foreach (string text in list)
            {
                bool check = true;
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(text))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    DataRow newRow = table.NewRow();
                    newRow[0] = text;
                    newRow[1] = 0;
                    table.Rows.Add(newRow);
                }
            }

            trangthai = 4;
        }

        private void btnDone1_Click(object sender, EventArgs e)
        {
            BLL.Doctor.TongHD(stt);
            MessageBox.Show("Hoàn thành điều trị");
            guna2DataGridView1.Visible = true;
            btnBill.Visible = false;
            guna2Button10.Visible = false;
            resetButton();
            HideSubMenu(panePatient);
            HideSubMenu(panelPrescription);
            HideSubMenu(panelTool);
            HideSubMenu(panelService);
            hideChildForm();
            btnPatient.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnPatient.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            
            _dataSet = BLL.Doctor.DaTiepNhan(DateTime.Now, Static.getUser().GetMaNhanVien());
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                BS_Treatment_Update updateForm = new BS_Treatment_Update(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                updateForm.ChangeLanguage(btnPatient.Text == "Bệnh nhân" ? "Vietnam" : "English");
                updateForm.bS_Treatment_UpdateEvent = new BS_Treatment_Update.BS_Treatment_UpdateEvent(thuoc);
                updateForm.change();
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ");
            }
        }
        private void thuoc(string text1, string text2, string text3)
        {
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == text1)
                {
                    row.Cells[1].Value = Int32.Parse(text2);
                    row.Cells[2].Value = text3;
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                guna2DataGridView1.Rows.RemoveAt(guna2DataGridView1.SelectedRows[0].Index);
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            DataTable ds = guna2DataGridView1.DataSource as DataTable;
            bool check = BLL.Doctor.Capnhatvatlieu(ds, stt);
            if (check)
            {
                guna2DataGridView1.Visible = false;
                resetButton();
                showSubMenu(panePatient);
                HideSubMenu(panelPrescription);
                HideSubMenu(panelTool);
                HideSubMenu(panelService);
                hideChildForm();
                guna2DataGridView1.Controls.Clear();
                trangthai = 3;
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ");
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                BS_Treatment_Update updateForm = new BS_Treatment_Update(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString(), guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                updateForm.bS_Treatment_UpdateEventHandler = new BS_Treatment_Update.BS_Treatment_UpdateEventHandler(vatlieu);
                updateForm.ChangeLanguage(btnPatient.Text == "Bệnh nhân" ? "Vietnam" : "English");
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một vật liệu");
            }
        }
        private void vatlieu(string text1, string text2)
        {
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == text1)
                {
                    row.Cells[1].Value = Int32.Parse(text2);
                    break;
                }
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in guna2DataGridView1.SelectedRows)
            {
                guna2DataGridView1.Rows.Remove(row);
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Theo_doi theo_Doi = new Theo_doi(maBN, name);
            theo_Doi.ShowDialog();

            if (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50))
            {
                theo_Doi.changeColor(Color.FromArgb(45, 38, 38), Color.FromArgb(50, 50, 50));
            }
            else
            {
                theo_Doi.changeColor(Color.WhiteSmoke, Color.White);
            }

            if (btnPatient.Text == "Pantient")
            {
                theo_Doi.ChangeLanguage("English");
            }
            else
            {
                theo_Doi.ChangeLanguage("Vietnam");
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Visible = true;
            trangthai = 4;
            resetButton();
            HideSubMenu(panePatient);
            HideSubMenu(panelPrescription);
            showSubMenu(panelTool);
            HideSubMenu(panelService);
            hideChildForm();
            btnTool.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnTool.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
           

        }

        private void panelTopRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            BS_Appointment rec_AddAppointment = new BS_Appointment(Static.getUser().GetMaNhanVien(), maBN);
            rec_AddAppointment.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            HideSubMenu(panePatient);
            showSubMenu(panelPrescription);
            HideSubMenu(panelTool);
            HideSubMenu(panelService);
            resetButton();
            hideChildForm();
            btnPrescription.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(3, 198, 215);
            btnPrescription.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            
            trangthai = 2;
            _dataSet = BLL.Doctor.Thuoc(stt);
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            guna2DataGridView1.Columns["Ten_thuoc"].HeaderText = "Tên thuốc";
            guna2DataGridView1.Columns["So_luong"].HeaderText = "Số lượng";
            guna2DataGridView1.Columns["Ghi_chu"].HeaderText = "Ghi chú";
        }

    }
}
