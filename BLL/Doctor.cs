using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Doctor
    {
        public static DataSet BenhNhan(DateTime date, string maBS)
        {
            return DAL.Doctor.BenhNhan(date.ToString("MM/dd/yyyy"), maBS);
        }
        public static DataSet BenhNhanChuaKham(DateTime date, string maBS)
        {
            return DAL.Doctor.BenhNhanChuaKham(date.ToString("MM/dd/yyyy"), maBS);
        }
        public static void TiepNhan(string maBN)
        {
            DAL.Doctor.TiepNhan(maBN);
        }
        public static DataSet DaTiepNhan(DateTime date, string maBS)
        {
            return DAL.Doctor.DaTiepNhan(date.ToString("MM/dd/yyyy"), maBS);
        }
        public static List<DTO.Lam_viec> CaLam(DateTime date, string ma)
        {
            return DAL.Doctor.CaLam(date.ToString("MM/dd/yyyy"), ma);
        }
        public static string XepCa(DateTime date, string ma, int ca)
        {
            if (date < DateTime.Now.Date)
                return "Không thể xếp ca";
            DAL.Doctor.XepCa(date.ToString("MM/dd/yyyy"), ma, ca);
            return "Đã xếp ca";
        }
        public static string Diemdanh(DateTime date, string ma, int ca)
        {
            if (date.Date != DateTime.Now.Date)
                return "Không thể điểm danh";
            DateTime now = DateTime.Now;
            Tuple<TimeSpan, TimeSpan> shift1 = Tuple.Create(new TimeSpan(6, 0, 0), new TimeSpan(11, 0, 0));
            Tuple<TimeSpan, TimeSpan> shift2 = Tuple.Create(new TimeSpan(11, 0, 0), new TimeSpan(18, 0, 0));
            Tuple<TimeSpan, TimeSpan> shift3 = Tuple.Create(new TimeSpan(18, 0, 0), new TimeSpan(22, 0, 0));

            if (ca == 1 && (now.TimeOfDay < shift1.Item1 || now.TimeOfDay > shift1.Item2))
            {
                return "Không thể điểm danh ca này";
            }
            if (ca == 2 && (now.TimeOfDay < shift2.Item1 || now.TimeOfDay > shift2.Item2))
            {
                return "Không thể điểm danh ca này";
            }
            if (ca == 3 && (now.TimeOfDay < shift3.Item1 || now.TimeOfDay > shift3.Item2))
            {
                return "Không thể điểm danh ca này";
            }
            DAL.Doctor.Diemdanh(date.ToString("MM/dd/yyyy"), ma, ca);
            return "Đã điểm danh";
        }
        public static DataSet CalamThang(DateTime date, string ma)
        {
            return DAL.Doctor.CaLamThang(date, ma);
        }
        public static DataSet Thongke(DateTime date, string kieu)
        {
            return DAL.Doctor.Thongke(date, kieu);
        }
        public static DataSet Dichvu(string stt)
        {
            return DAL.Doctor.Dichvu(stt);
        }
        public static DataSet Thuoc(string stt)
        {
            return DAL.Doctor.Thuoc(stt);
        }
        public static void Doisoluong(DataTable ds, string stt)
        {
            DAL.Doctor.Doisoluong(ds, stt);
        }
        public static void Themthuoc(DataTable ds, string stt)
        {
            DAL.Doctor.Themthuoc(ds, stt);
        }
        public static void TongHD(string stt)
        {
            DAL.Doctor.TongHD(stt);
        }
        public static List<string> DanhSachVatLieu()
        {
            return DAL.Doctor.DanhSachVatLieu();
        }
        public static bool Capnhatvatlieu(DataTable ds, string stt)
        {
            return DAL.Doctor.Capnhatvatlieu(ds, stt);
        }
        public static List<string> GetLichLam(string maBS, int thang, int nam)
        {
            return DAL.Doctor.GetLichLam(maBS, thang, nam);
        }
    }
}
