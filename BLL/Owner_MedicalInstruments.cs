using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public static class Owner_MedicalInstruments
    {
        public static DataSet DanhSachVatLieu()
        {
            return DAL.Owner_MedicalInstruments.DanhSachVatLieu(); ;
        }

        public static DataSet DanhSachThuoc()
        {
            return DAL.Owner_MedicalInstruments.DanhSachThuoc();
        }

        public static DataSet DanhSachDichVu()
        {
            return DAL.Owner_MedicalInstruments.DanhSachDichVu(); ;
        }

        public static DTO.Thuoc GetThuoc(string id)
        {
            return DAL.Owner_MedicalInstruments.GetThuoc(id);
        }
        public static DTO.Dich_vu GetDichVu(string id)
        {
            return DAL.Owner_MedicalInstruments.GetDichVu(id);
        }

        public static DTO.Vat_lieu GetVatLieu(string id)
        {
            return DAL.Owner_MedicalInstruments.GetVatLieu(id);
        }

        public static string AddVatLieu(string ten,string mausac, string kichco,string dvt,string gia,string soluong,string ghichu,string loai)
        {
            return DAL.Owner_MedicalInstruments.AddVatLieu(ten, mausac, kichco, dvt, gia, soluong, ghichu, loai);
        }
        public static string AddDichVu(string ten,string dtv, string dongia,string ghichu,string tendanhmuc)
        {
            return DAL.Owner_MedicalInstruments.AddDichVu(ten, dtv, dongia, ghichu, tendanhmuc);
        }
        public static string AddThuoc(string ten,string dvt,string soluong,string giaban,string hamluong,string ghichu,string loai)
        {
            return DAL.Owner_MedicalInstruments.AddThuoc(ten, dvt, soluong, giaban, hamluong, ghichu,loai); 
        }

        public static string EditVatLieu(string ten, string mausac, string kichco, string dvt, string gia, string soluong, string ghichu, string loai)
        {
            return DAL.Owner_MedicalInstruments.EditVatLieu(ten, mausac, kichco, dvt, gia, soluong, ghichu, loai);
        }
        public static string EditDichVu(string ten, string dtv, string dongia, string ghichu, string tendanhmuc)
        {
            return DAL.Owner_MedicalInstruments.EditDichVu(ten, dtv, dongia, ghichu, tendanhmuc);
        }
        public static string EditThuoc(string ten, string dvt, string soluong, string giaban, string hamluong, string ghichu, string loai)
        {
            return DAL.Owner_MedicalInstruments.EditThuoc(ten, dvt, soluong, giaban, hamluong, ghichu, loai);
        }
    }
}
