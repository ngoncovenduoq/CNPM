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
    public partial class Owner_Staff : Form
    {
        public delegate void TruyenBacSi(string text);
        public TruyenBacSi truyenBacSi;
        private DataSet _dataSet;
        private int trangthai;//0 is doctor

        public Owner_Staff()
        {
            InitializeComponent();
            _dataSet = new DataSet();
            trangthai = 0;
            btnAgree.Visible = false;
        }

        // đổi ngôn ngữ
        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                btnDoctor.Text = "Bác sĩ";
                btnReceptionist.Text = "Lễ tân";
                tbSearch.PlaceholderText = "Tìm kiếm";

                btnAgree.Text = "Đồng ý";
                btnAdd.Text = "Thêm";
                btnUpdate1.Text = "Sửa";
                btnDelete.Text = "Vô hiệu hóa";

            }
            else
            {
                btnDoctor.Text = "Doctor";
                btnReceptionist.Text = "Receptionist";
                tbSearch.PlaceholderText = "Search";

                btnAgree.Text = "Done";
                btnAdd.Text = "Add";
                btnUpdate1.Text = "Edit";
                btnDelete.Text = "Disable";

            }
        }

        // đổi màu nền
        public void ChangeBackgroundColor(Color color, Color color2)
        {
            Datagridview.BackgroundColor = Datagridview.GridColor = color2;
            resetButton();
        }

        public void change()
        {
            btnReceptionist.Visible = false;
            btnAdd.Visible = false;
            btnUpdate1.Visible = false;
            btnDelete.Visible = false;
            btnAgree.Visible = true;
        }

        private void showData()
        {
            Datagridview.ClearSelection();
            Datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            if (trangthai == 0)
            {
                _dataSet = BLL.Owner.Doctor();
                Datagridview.DataSource = _dataSet.Tables[0];
                Datagridview.Columns["Chuyen_nganh"].HeaderText = "Chuyên ngành";

                btnDoctor.FillColor = (Datagridview.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(7, 125, 4);
                btnDoctor.ForeColor = (Datagridview.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;

            }

            else
            {
                _dataSet = BLL.Owner.Rec();
                Datagridview.DataSource = _dataSet.Tables[0];

                btnReceptionist.FillColor = (Datagridview.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(7, 125, 4);
                btnReceptionist.ForeColor = (Datagridview.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            }
            Datagridview.Columns["Ma_nhan_vien"].HeaderText = "Mã nhân viên";
            Datagridview.Columns["Tinh_trang_hoat_dong"].HeaderText = "Tình trạng hoạt động";
            Datagridview.Columns["Gioi_tinh"].HeaderText = "Giới tính";
            Datagridview.Columns["HoTen"].HeaderText = "Họ và tên";

        }

        private void resetButton()
        {
            if (Datagridview.BackgroundColor == Color.FromArgb(50, 50, 50))
            {
                tbSearch.FillColor = btnAgree.FillColor = btnAdd.FillColor = btnUpdate1.FillColor = Color.FromArgb(50, 50, 50);
                //Bac si
                btnDoctor.ForeColor = Color.White;
                btnDoctor.FillColor = Color.FromArgb(50, 50, 50);

                //Le tan
                btnReceptionist.ForeColor = Color.White;
                btnReceptionist.FillColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                tbSearch.FillColor  = Color.White;
                btnUpdate1.FillColor = Color.FromArgb(3, 198, 215);
                btnAgree.FillColor = btnAdd.FillColor = Color.FromArgb(72, 138, 236);
                //Bac si
                btnDoctor.ForeColor = Color.Black;
                btnDoctor.FillColor = Color.FromArgb(63, 220, 254);

                //Le tan
                btnReceptionist.ForeColor = Color.Black;
                btnReceptionist.FillColor = Color.FromArgb(63, 220, 254);
            }

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            resetButton();
            btnDoctor.FillColor = (Datagridview.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(7, 125, 4);
            btnDoctor.ForeColor = (Datagridview.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            trangthai = 0;
            showData();
        }
        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            resetButton();
            btnReceptionist.FillColor = (Datagridview.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.FromArgb(4, 55, 102) : Color.FromArgb(7, 125, 4);
            btnReceptionist.ForeColor = (Datagridview.BackgroundColor == Color.FromArgb(50, 50, 50)) ? Color.White : Color.White;
            trangthai = 1;
            showData();
        }

        private void Owner_Staff_Load(object sender, EventArgs e)
        {
            Datagridview.ColumnHeadersHeight = 40;
            showData();
        }

        // thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (trangthai == 0)
            {
                Owner_Staff_Doc owner_Staff_Doc = new Owner_Staff_Doc();
                owner_Staff_Doc.ChangeLanguage(btnDoctor.Text == "Bác sĩ" ? "Vietnam" : "English");
                owner_Staff_Doc.ShowDialog();
            }
            else
            {
                Owner_Staff_Rec owner_Staff_Rec = new Owner_Staff_Rec();
                owner_Staff_Rec.ChangeLanguage(btnReceptionist.Text == "Lễ tân" ? "Vietnam" : "English");
                owner_Staff_Rec.ShowDialog();
            }
            showData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Datagridview.SelectedRows.Count == 1)
            {
                if (Datagridview.SelectedRows[0].Cells[0].Value.ToString().Equals("Không còn hoạt động"))
                {
                    MessageBox.Show("Tài khoản không còn hoạt động");
                }
                else
                {
                    string text = Datagridview.SelectedRows[0].Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("Bạn có muốn chọn bác sĩ " + text + "?", "Đồng ý", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        truyenBacSi(text);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bác sĩ");
            }
        }

        // sửa
        private void btnUpdate1_Click(object sender, EventArgs e)
        {

            if (Datagridview.SelectedRows.Count == 1)
            {
                if (trangthai == 0)
                {
                    Owner_Staff_Doc owner_Staff_Doc = new Owner_Staff_Doc();
                    owner_Staff_Doc.ChangeLanguage(btnDoctor.Text == "Bác sĩ" ? "Vietnam" : "English");
                    owner_Staff_Doc.GetInfo(Datagridview.SelectedRows[0].Cells[0].Value.ToString());
                    owner_Staff_Doc.ShowDialog();
                }
                else
                {
                    Owner_Staff_Rec owner_Staff_Rec = new Owner_Staff_Rec();
                    owner_Staff_Rec.ChangeLanguage(btnReceptionist.Text == "Lễ tân" ? "Vietnam" : "English");
                    owner_Staff_Rec.GetInfo(Datagridview.SelectedRows[0].Cells[0].Value.ToString());
                    owner_Staff_Rec.ShowDialog();
                }
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên");
            }

        }

        // tìm kiếm
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = _dataSet.Tables[0].DefaultView;
            dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
            Datagridview.DataSource = dataView.ToTable();
        }

        // vô hiệu hóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Datagridview.SelectedRows.Count == 1)
            {
                if (Datagridview.SelectedRows[0].Cells["Tinh_trang_hoat_dong"].Value.ToString().Equals("Không còn hoạt động"))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn kích hoạt tài khoản", "Kích hoạt?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        BLL.Owner.ThayDoiTrangThai(Datagridview.SelectedRows[0].Cells[0].Value.ToString(), 1);
                        MessageBox.Show("Đã kích hoạt");
                        showData();

                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn hủy kích hoạt tài khoản", "Kích hoạt?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        BLL.Owner.ThayDoiTrangThai(Datagridview.SelectedRows[0].Cells[0].Value.ToString(), 0);
                        MessageBox.Show("Đã hủy kích hoạt");
                        showData();

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một người dùng");
            }
        }
    }
}
