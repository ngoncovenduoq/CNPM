using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class Owner_AddService : Form
    {
        private int trangthai;
        private string name;
        public Owner_AddService()
        {
            InitializeComponent();
            trangthai = 0;
        }
        public Owner_AddService(string name)
        {
            InitializeComponent();
            trangthai = 1;
            DTO.Dich_vu dich_vu = BLL.Owner_MedicalInstruments.GetDichVu(name);
            this.name = name;
            tbName.Text = name;
            lbForm.Text = "Sửa Dịch vụ";
            tbName.Enabled = false;
            cbDVT.Text = dich_vu.getDon_vi_tinh();
            tbPrice.Text = dich_vu.getDon_gia().ToString("#");
            tbNote.Text = dich_vu.getGhi_chu();
            cb.Text = dich_vu.getTen_danh_muc();

        }
        private void btnDone_Click(object sender, EventArgs e)
        {

            if(
                BLL.CheckTextBox.KiemTraTenDacbiet(tbNote.Text)
                && BLL.CheckTextBox.KiemTraSo(tbPrice.Text)
                )
            {
                if (trangthai == 0)
                {
                    string text = BLL.Owner_MedicalInstruments.AddDichVu(tbName.Text, cbDVT.Text, tbPrice.Text, tbNote.Text, cb.Text);
                    MessageBox.Show(text);
                }
                else
                {
                    string text = BLL.Owner_MedicalInstruments.EditDichVu(tbName.Text, cbDVT.Text, tbPrice.Text, tbNote.Text, cb.Text);
                    MessageBox.Show(text);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }

        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                lbForm.Text = "Thêm Dịch Vụ";
                lbName.Text = "Tên dụng cụ";
                lbTechnique.Text = "Danh mục kĩ thuật";
                lbNote.Text = "Ghi chú";
                lbUnit.Text = "Đơn vị tính";
                lbPrice.Text = "Đơn giá";
                btnDone.Text = "Xác nhận";
                btnDelete.Text = "Xóa";
            }
            else
            {
                lbForm.Text = "Add Service";
                lbName.Text = "Service Name";
                lbTechnique.Text = "Technical Category";
                lbNote.Text = "Note";
                lbUnit.Text = "Unit";
                lbPrice.Text = "Price";
                btnDone.Text = "Confirm";
                btnDelete.Text = "Delete";

            }
        }

        

        private void Owner_AddService_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbNote.Text = "";
            tbPrice.Text = "";
            cb.SelectedIndex = -1;
            cbDVT.SelectedIndex = -1;
        }
    }
}
