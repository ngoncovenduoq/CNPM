using DTO;
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
    public partial class Rec_AddAppointment : Form
    {
        
        public Rec_AddAppointment()
        {
            InitializeComponent();
        }


        private void LoadBenhNhan(string text)
        {
            benhnhan.Text = text;
        }
        private void LoadBacSi(string text)
        {
            doctor.Text = text;
        }

        private void benhnhan_Click(object sender, EventArgs e)
        {
            Rec_Check rec_Check = new Rec_Check();
            rec_Check.change();
            rec_Check.truyenBenhNhan = new Rec_Check.TruyenBenhNhan(LoadBenhNhan);
            rec_Check.ShowDialog();
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            Owner_Staff owner_Staff = new Owner_Staff();
            owner_Staff.change();
            owner_Staff.truyenBacSi = new Owner_Staff.TruyenBacSi(LoadBacSi);
            owner_Staff.ShowDialog();
        }

        private void Rec_AddAppointment_Load(object sender, EventArgs e)
        {
            dichvu.ColumnHeadersHeight = 20;
            dateTime.Value = DateTime.Now;
            dichvu.Columns.Add("Column", "Tên dịch vụ");
            dichvu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string result = BLL.Patient.ThemNguoiKham(Int32.Parse(ca.Text),dateTime.Value,Static.getUser().GetMaNhanVien(),doctor.Text,benhnhan.Text);
            if (result.Equals(""))
                MessageBox.Show("Thời gian không hợp lệ");
            else
                STT.Text = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (STT.Text.Length != 0)
            {
                Owner_MedicalInstruments owner = new Owner_MedicalInstruments();
                owner.change1();
                owner.truyenDichVu = new Owner_MedicalInstruments.TruyenDichVu(loadDichVu);
                owner.setTrangThai();
                owner.ShowDialog();
            }
        }
        private void loadDichVu(List<string> list)
        {
            foreach (string text in list)
            {
                bool check = true;
                foreach (DataGridViewRow row in dichvu.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(text))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = text;
                    row.Cells.Add(cell);
                    dichvu.Rows.Add(row);
                }
            }
            dichvu.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;

            dichvu.Sort(dichvu.Columns[0], ListSortDirection.Ascending);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(STT.Text.Length != 0)
            {
                if (dichvu.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa những gì muốn chọn?", "Đồng ý", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dichvu.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                dichvu.Rows.Remove(row);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng");
                }
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach(DataGridViewRow row in dichvu.Rows)
            {
                if (!row.IsNewRow)
                {
                    list.Add(row.Cells[0].Value.ToString());
                }
            }
            DialogResult result = MessageBox.Show("Xác nhận?", "Xác nhận", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                BLL.Rec_AddPatient.ThemHoaDonDichVu(STT.Text,list);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
        }
    }
}
