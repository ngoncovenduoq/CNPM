using Guna.UI2.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class Benh_An : Form
    {
        private int trangthai;
        private string stt;
        private DTO.BenhAn[] benhs;
        private int page;
        private int allpage;
        private DTO.BenhNhan benhNhan;
        public Benh_An(string stt)
        {
            InitializeComponent();
            trangthai = 0;
            this.stt = stt;
        }

        public void ChangeColor(Color color, Color color2)
        {
            panel1.BackColor = panelTopLeft.BackColor = panel2.BackColor = panel4.BackColor = panel3.BackColor = color;
            panel5.BackColor = color2;
            if (color2 == Color.FromArgb(50, 50, 50))
            {
                labelForm.ForeColor = label1.ForeColor = label2.ForeColor = label3.ForeColor = label8.ForeColor = label4.ForeColor =
                    label5.ForeColor = Color.White;
            }
            else
            {
                labelForm.ForeColor = label1.ForeColor = label2.ForeColor = label3.ForeColor = label8.ForeColor = label4.ForeColor =
                    label5.ForeColor = Color.Black;
            }
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                labelForm.Text = "XEM BỆNH ÁN";
                guna2Button1.Text = "Trước";
                guna2Button2.Text = "Sau";
            }
            else
            {
                labelForm.Text = "XEM BỆNH ÁN";
                guna2Button1.Text = "Before";
                guna2Button2.Text = "After";
            }
        }

        private void CreateInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void CreateInvoice_Load(object sender, EventArgs e)
        {
            List<DTO.BenhAn> list = BLL.BenhAn.LayBenhAn(stt);
            DTO.Patient patient = BLL.BenhAn.LayThongTin(stt);
            benhNhan = BLL.Patient.TimBenhNhan(stt);
            page = 0;
            allpage = list.Count;
            benhs = new DTO.BenhAn[list.Count];
            int index = 0;
            foreach (DTO.BenhAn b in list)
            {
                benhs[index++] = b;
            }
            guna2Button1.Visible = false;
            if (patient != null)
            {
                guna2TextBox7.Text = patient.GetNgay().ToString("dd/MM/yyyy");
                guna2TextBox8.Text = patient.GetMaBS();
            }
            if (allpage <= 1)
            {
                guna2Button2.Visible = false;

            }
            if (allpage != 0)
            {
                LoadDuLieu();
            }
            guna2TextBox1.Text = benhNhan.GetHo() + " " + benhNhan.GetTen();
            guna2TextBox2.Text = benhNhan.GetGioiTinh();
            guna2TextBox3.Text = benhNhan.GetTuoi().ToString("dd/MM/yyyy");
            guna2TextBox4.Text = benhNhan.GetDiaChi();
            guna2TextBox5.Text = benhNhan.GetNgheNghiep();
            guna2TextBox6.Text = benhNhan.GetSDT();
            HienThi();

        }

        private void LoadDuLieu()
        {
            cbk.Checked = false;
            cbx.Checked = false;
            cbxe.Checked = false;
            cbs.Checked = false;


            guna2TextBox9.Text = benhs[page].LyDoDenKham;
            guna2TextBox10.Text = benhs[page].BenhSu;
            guna2TextBox11.Text = benhs[page].TienSuGiaDinh;
            guna2TextBox12.Text = benhs[page].TienSuNoiKhoa;
            guna2TextBox13.Text = benhs[page].TienSuRangHamMat;
            guna2TextBox14.Text = benhs[page].KhamNgoaiMat;
            guna2TextBox15.Text = benhs[page].TinhTrangVeSinhRangMieng;
            guna2TextBox16.Text = benhs[page].MoMem;
            guna2TextBox17.Text = benhs[page].MoNhaChu;
            guna2TextBox18.Text = benhs[page].KhopCan;
            guna2TextBox19.Text = benhs[page].KetQuaCanLamSang;
            guna2TextBox20.Text = benhs[page].ChuanDoan;
            guna2TextBox21.Text = benhs[page].KeHoachDieuTri;
            switch (benhs[page].CanLamSang)
            {
                case "X-quang":
                    cbx.Checked = true;
                    break;
                case "Siêu âm":
                    cbs.Checked = true;
                    break;
                case "Xét nghiệm máu":
                    cbxe.Checked = true;
                    break;
                default:
                    cbk.Checked = true;
                    break;
            }
        }
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string chuandoan = "";
            if (cbx.Checked)
            {
                chuandoan = "X-quang";
            }
            else if (cbs.Checked)
            {
                chuandoan = "Siêu âm";
            }
            else if (cbxe.Checked)
            {
                chuandoan = "Xét nghiệm máu";
            }
            else if (cbk.Checked)
            {
                chuandoan = "Khác";
            }
            DTO.BenhAn benhAn = new DTO.BenhAn(
                0, guna2TextBox9.Text, guna2TextBox10.Text, guna2TextBox11.Text, guna2TextBox12.Text, guna2TextBox13.Text, guna2TextBox14.Text,
                guna2TextBox15.Text, guna2TextBox16.Text, guna2TextBox17.Text, "", guna2TextBox18.Text, chuandoan, guna2TextBox19.Text, guna2TextBox20.Text,
                guna2TextBox21.Text, "", "", "", "", DateTime.Now, "", "", "");
            BLL.BenhAn.TaoBenhAn(benhAn, stt);
            MessageBox.Show("Đã tạo bệnh án thành công");
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            trangthai = 0;
            HienThi();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            trangthai = 1;
            HienThi();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            trangthai = 2;
            HienThi();
        }

        private void HienThi()
        {

            if (trangthai == 0)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;

                guna2TextBox1.Visible = true;
                guna2TextBox2.Visible = true;
                guna2TextBox3.Visible = true;
                guna2TextBox4.Visible = true;
                guna2TextBox5.Visible = true;
                guna2TextBox6.Visible = true;
                guna2TextBox7.Visible = true;
                guna2TextBox8.Visible = true;
                guna2TextBox9.Visible = true;
                guna2TextBox10.Visible = true;
                guna2TextBox11.Visible = true;
                guna2TextBox12.Visible = true;
                guna2TextBox13.Visible = true;

                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;

                guna2TextBox14.Visible = false;
                guna2TextBox15.Visible = false;
                guna2TextBox16.Visible = false;
                guna2TextBox17.Visible = false;
                guna2TextBox18.Visible = false;
                guna2TextBox19.Visible = false;
                guna2TextBox20.Visible = false;
                guna2TextBox21.Visible = false;

                cbs.Visible = false;
                cbx.Visible = false;
                cbxe.Visible = false;
                cbk.Visible = false;

            }
            else if (trangthai == 1)
            {
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;

                guna2TextBox14.Visible = true;
                guna2TextBox15.Visible = true;
                guna2TextBox16.Visible = true;
                guna2TextBox17.Visible = true;
                guna2TextBox18.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;

                guna2TextBox1.Visible = false;
                guna2TextBox2.Visible = false;
                guna2TextBox3.Visible = false;
                guna2TextBox4.Visible = false;
                guna2TextBox5.Visible = false;
                guna2TextBox6.Visible = false;
                guna2TextBox7.Visible = false;
                guna2TextBox8.Visible = false;
                guna2TextBox9.Visible = false;
                guna2TextBox10.Visible = false;
                guna2TextBox11.Visible = false;
                guna2TextBox12.Visible = false;
                guna2TextBox13.Visible = false;
                guna2TextBox19.Visible = false;
                guna2TextBox20.Visible = false;
                guna2TextBox21.Visible = false;

                cbs.Visible = false;
                cbx.Visible = false;
                cbxe.Visible = false;
                cbk.Visible = false;
            }
            else if (trangthai == 2)
            {
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;

                guna2TextBox19.Visible = true;
                guna2TextBox20.Visible = true;
                guna2TextBox21.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;

                guna2TextBox1.Visible = false;
                guna2TextBox2.Visible = false;
                guna2TextBox3.Visible = false;
                guna2TextBox4.Visible = false;
                guna2TextBox5.Visible = false;
                guna2TextBox6.Visible = false;
                guna2TextBox7.Visible = false;
                guna2TextBox8.Visible = false;
                guna2TextBox9.Visible = false;
                guna2TextBox10.Visible = false;
                guna2TextBox11.Visible = false;
                guna2TextBox12.Visible = false;
                guna2TextBox13.Visible = false;
                guna2TextBox14.Visible = false;
                guna2TextBox15.Visible = false;
                guna2TextBox16.Visible = false;
                guna2TextBox17.Visible = false;
                guna2TextBox18.Visible = false;

                cbs.Visible = true;
                cbx.Visible = true;
                cbxe.Visible = true;
                cbk.Visible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = true;
            if (page != 0)
            {
                page--;
                trangthai = 0;
                LoadDuLieu();
                HienThi();
            }
            if (page == 0)
            {
                guna2Button1.Visible = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button1.Visible = true;
            if (page != allpage - 1)
            {
                page++;
                trangthai = 0;
                LoadDuLieu();
                HienThi();
            }
            if (page == allpage - 1)
            {
                guna2Button2.Visible = false;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            benhNhan = BLL.Patient.TimBenhNhan(stt);
            cbk.Checked = false;
            cbx.Checked = false;
            cbxe.Checked = false;
            cbs.Checked = false;
            guna2Button1.Visible = false;
            guna2Button2.Visible = false;
            guna2Button6.Visible = false;
            guna2Button7.Visible = true;
            guna2Button8.Visible = true;
            guna2TextBox1.Text = benhNhan.GetHo() + benhNhan.GetTen();
            guna2TextBox2.Text = benhNhan.GetGioiTinh();
            guna2TextBox3.Text = benhNhan.GetTuoi().ToString("dd/MM/yyyy");
            guna2TextBox4.Text = benhNhan.GetDiaChi();
            guna2TextBox5.Text = benhNhan.GetNgheNghiep();
            guna2TextBox6.Text = benhNhan.GetSDT();


            guna2TextBox9.Text = "";
            guna2TextBox10.Text = "";
            guna2TextBox11.Text = "";
            guna2TextBox12.Text = "";
            guna2TextBox13.Text = "";
            guna2TextBox14.Text = "";
            guna2TextBox15.Text = "";
            guna2TextBox16.Text = "";
            guna2TextBox17.Text = "";
            guna2TextBox18.Text = "";
            guna2TextBox19.Text = "";
            guna2TextBox20.Text = "";
            guna2TextBox21.Text = "";

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            page = 0;
            guna2Button1.Visible = false;
            guna2Button2.Visible = true;
            guna2Button6.Visible = true;
            guna2Button7.Visible = false;
            guna2Button8.Visible = false;
            if (allpage <= 1)
            {
                guna2Button2.Visible = false;

            }
            if (allpage != 0)
                LoadDuLieu();
            guna2TextBox1.Text = benhNhan.GetHo() + " " + benhNhan.GetTen();
            guna2TextBox2.Text = benhNhan.GetGioiTinh();
            guna2TextBox3.Text = benhNhan.GetTuoi().ToString("dd/MM/yyyy");
            guna2TextBox4.Text = benhNhan.GetDiaChi();
            guna2TextBox5.Text = benhNhan.GetNgheNghiep();
            guna2TextBox6.Text = benhNhan.GetSDT();
            HienThi();
        }


    }
}
