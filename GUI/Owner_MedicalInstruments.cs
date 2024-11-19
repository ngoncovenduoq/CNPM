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
    public partial class Owner_MedicalInstruments : Form
    {
        private int trangthai;
        private DataSet _dataset;
        public delegate void TruyenDichVu(List<string> text);
        public TruyenDichVu truyenDichVu;
        public TruyenDichVu truyenThuoc;

        public Owner_MedicalInstruments()
        {
            InitializeComponent();
            trangthai = 0;
            _dataset = new DataSet();
            btnSearch.Visible = false;
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                btnMedicine.Text = "Thuốc";
                btnMaterial.Text = "Vật liệu";
                btnService.Text = "Dịch vụ";
                tbSearch.PlaceholderText = "Tìm kiếm";
                btnSearch.Text = "Xác nhận";
                btnAdd.Text = "Thêm";
                btnUpdate1.Text = "Sửa";
            }
            else
            {
                btnMedicine.Text = "Medicine";
                btnMaterial.Text = "Material";
                btnService.Text = "Service";
                tbSearch.PlaceholderText = "Search";
                btnSearch.Text = "Confirm";
                btnAdd.Text = "Add";
                btnUpdate1.Text = "Edit";

            }
        }
        public void ChangeColor(Color color, Color color2)
        {
            panelTopRight.BackColor = panelTop.BackColor = panelTopLeft.BackColor = panelUpdate.BackColor = panel2.BackColor = color;
            guna2DataGridView1.BackgroundColor = color2;
            resetButton();
        }
        public void setTrangThai()
        {
            trangthai = 2;
        }
        public void setThuoc()
        {
            trangthai = 0;
        }

        public void change1()
        {
            btnMedicine.Visible = false;
            btnMaterial.Visible = false;
            btnService.Visible = false;
            panelUpdate.Visible = false;
            btnSearch.Visible = true;
            resetButton();
            btnService.ForeColor = Color.White;
            btnService.FillColor = Color.FromArgb(7, 125, 4);
      
            btnService.Location = new Point(12, 9);
            tbSearch.Location = new Point(3, 7);
        }
        private void resetButton()
        {
            if(guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50))
            {
                btnMedicine.ForeColor = Color.Black;
                btnMedicine.FillColor = Color.White;
              

                btnMaterial.ForeColor = Color.Black;
                btnMaterial.FillColor = Color.White;


                btnService.ForeColor = Color.Black;
                btnService.FillColor = Color.White;
           

                tbSearch.FillColor =  btnAdd.FillColor = btnUpdate1.FillColor = Color.FromArgb(3, 198, 215);
            }
            else
            {
                btnMedicine.ForeColor = Color.Black;
                btnMedicine.FillColor = Color.White;


                btnMaterial.ForeColor = Color.Black;
                btnMaterial.FillColor = Color.White;


                btnService.ForeColor = Color.Black;
                btnService.FillColor = Color.White;


                tbSearch.FillColor = btnUpdate1.FillColor = Color.FromArgb(3, 198, 215);
                btnSearch.FillColor = Color.FromArgb(94, 148, 255);
                btnAdd.FillColor = Color.FromArgb(72, 138, 236);
            }
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            resetButton();
            btnMedicine.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(68, 197, 229) : Color.FromArgb(68, 197, 229);
            btnMedicine.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            
            trangthai = 0;
            change();

        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            resetButton();
            btnMaterial.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(68, 197, 229) : Color.FromArgb(68, 197, 229);
            btnMaterial.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
           
            trangthai = 1;
            change();

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            resetButton();
            btnService.FillColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(68, 197, 229) : Color.FromArgb(68, 197, 229);
            btnService.ForeColor = (guna2DataGridView1.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            
            trangthai = 2;
            change();

        }

        private void Owner_MedicalInstruments_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            change();
        }
        private void change()
        {
            guna2DataGridView1.ClearSelection();
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            if (trangthai == 0)
            {
                _dataset = BLL.Owner_MedicalInstruments.DanhSachThuoc();
                guna2DataGridView1.DataSource = _dataset.Tables[0];
                guna2DataGridView1.Columns["Ten_thuoc"].HeaderText = "Tên thuốc";
                guna2DataGridView1.Columns["DVT"].HeaderText = "Đơn vị tính";
                guna2DataGridView1.Columns["So_luong"].HeaderText = "Số lượng";
                guna2DataGridView1.Columns["Gia_ban"].HeaderText = "Giá bán";
                guna2DataGridView1.Columns["Ham_luong"].HeaderText = "Hàm lượng";
                guna2DataGridView1.Columns["Ghi_chu"].HeaderText = "Ghi chú";
                guna2DataGridView1.Columns["Ten_loai"].HeaderText = "Tên loại";
            }

            else if (trangthai == 1)
            {
                _dataset = BLL.Owner_MedicalInstruments.DanhSachVatLieu();
                guna2DataGridView1.DataSource = _dataset.Tables[0];
                guna2DataGridView1.Columns["Ten_dung_cu"].HeaderText = "Tên dụng cụ";
                guna2DataGridView1.Columns["Mau_sac"].HeaderText = "Màu sắc";
                guna2DataGridView1.Columns["Kich_co"].HeaderText = "Kích cỡ";
                guna2DataGridView1.Columns["DVT"].HeaderText = "Đơn vị tính";
                guna2DataGridView1.Columns["Gia"].HeaderText = "Giá";
                guna2DataGridView1.Columns["So_luong"].HeaderText = "Số lượng";
                guna2DataGridView1.Columns["Ghi_chu"].HeaderText = "Ghi chú";
                guna2DataGridView1.Columns["Loai"].HeaderText = "Tên loại";
            }
            else
            {
                _dataset = BLL.Owner_MedicalInstruments.DanhSachDichVu();
                guna2DataGridView1.DataSource = _dataset.Tables[0];
                guna2DataGridView1.DataSource = _dataset.Tables[0];
                guna2DataGridView1.Columns["Ten_dich_vu"].HeaderText = "Tên dịch vụ";
                guna2DataGridView1.Columns["Don_vi_tinh"].HeaderText = "Đơn vị tính";
                guna2DataGridView1.Columns["Don_gia"].HeaderText = "Đơn giá";
                guna2DataGridView1.Columns["Ghi_chu"].HeaderText = "Ghi chú";
                guna2DataGridView1.Columns["Ten_danh_muc"].HeaderText = "Tên danh mục";
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(guna2DataGridView1.SelectedRows.Count > 0)
            {
                if(trangthai == 2)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow row in guna2DataGridView1.SelectedRows)
                    {
                        list.Add(row.Cells[0].Value.ToString());
                    }
                    
                        truyenDichVu(list);
                        this.Close();
                    
                }
                if(trangthai == 0)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow row in guna2DataGridView1.SelectedRows)
                    {
                        list.Add(row.Cells[0].Value.ToString());
                    }
                   
                        truyenThuoc(list);
                        this.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (trangthai == 0)
            {
                Owner_AddMedicine owner_AddMedicine = new Owner_AddMedicine();
                owner_AddMedicine.ChangeLanguage(btnMedicine.Text == "Thuốc" ? "Vietnam" : "English");
                owner_AddMedicine.ShowDialog();
            }
            else if( trangthai == 1)
            {
                Owner_AddMaterial owner_AddMaterial = new Owner_AddMaterial();
                owner_AddMaterial.ChangeLanguage(btnMedicine.Text == "Thuốc" ? "Vietnam" : "English");
                owner_AddMaterial.ShowDialog();
            }
            else
            {
                Owner_AddService owner_AddService = new Owner_AddService();
                owner_AddService.ChangeLanguage(btnMedicine.Text == "Thuốc" ? "Vietnam" : "English");
                owner_AddService.ShowDialog();
            }
            change();
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            if(guna2DataGridView1.SelectedRows.Count == 1 && guna2DataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                if (trangthai == 0)
                {
                    Owner_AddMedicine owner_AddMedicine = new Owner_AddMedicine(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    owner_AddMedicine.ChangeLanguage(btnMedicine.Text == "Thuốc" ? "Vietnam" : "English");
                    owner_AddMedicine.ShowDialog();
                }
                else if (trangthai == 1)
                {
                    Owner_AddMaterial owner_AddMaterial = new Owner_AddMaterial(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    owner_AddMaterial.ChangeLanguage(btnMedicine.Text == "Thuốc" ? "Vietnam" : "English");
                    owner_AddMaterial.ShowDialog();
                }
                else
                {
                    Owner_AddService owner_AddService = new Owner_AddService(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    owner_AddService.ChangeLanguage(btnMedicine.Text == "Thuốc" ? "Vietnam" : "English");
                    owner_AddService.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 đối tượng");
            }
            change();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (trangthai == 0)
            {
                DataView dataView = _dataset.Tables[0].DefaultView;
                dataView.RowFilter = string.Format("Ten_thuoc like '%{0}%'", tbSearch.Text);
                guna2DataGridView1.DataSource = dataView.ToTable();
            }
            else if (trangthai == 1)
            {
                DataView dataView = _dataset.Tables[0].DefaultView;
                dataView.RowFilter = string.Format("Ten_dung_cu like '%{0}%'", tbSearch.Text);
                guna2DataGridView1.DataSource = dataView.ToTable();
            }
            else
            {
                DataView dataView = _dataset.Tables[0].DefaultView;
                dataView.RowFilter = string.Format("Ten_dich_vu like '%{0}%'", tbSearch.Text);
                guna2DataGridView1.DataSource = dataView.ToTable();
            }
        }
    }
}
