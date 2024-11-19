using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhan
    {
        protected string CCCD;
        protected string Ho;
        protected string Ten;
        protected string Gioi_tinh;
        protected string diachi;
        protected string NgheNghiep;
        protected string sdt;
        protected DateTime Tuoi;

        public BenhNhan() { }

        public BenhNhan(string cccd, string ho, string ten, string gioiTinh,string diachi, string ngheNghiep, string sdt, DateTime tuoi)
        {
            CCCD = cccd;
            Ho = ho;
            Ten = ten;
            Gioi_tinh = gioiTinh;
            this.diachi = diachi;
            NgheNghiep = ngheNghiep;
            this.sdt = sdt;
            Tuoi = tuoi;
        }

        public string GetDiaChi()
        {
            return diachi;
        }
        // Phương thức getter và setter cho CCCD
        public string GetCCCD()
        {
            return CCCD;
        }

        public void SetCCCD(string cccd)
        {
            CCCD = cccd;
        }

        // Phương thức getter và setter cho Ho
        public string GetHo()
        {
            return Ho;
        }

        public void SetHo(string ho)
        {
            Ho = ho;
        }

        // Phương thức getter và setter cho Ten
        public string GetTen()
        {
            return Ten;
        }

        public void SetTen(string ten)
        {
            Ten = ten;
        }

        // Phương thức getter và setter cho Gioi_tinh
        public string GetGioiTinh()
        {
            return Gioi_tinh;
        }

        public void SetGioiTinh(string gioiTinh)
        {
            Gioi_tinh = gioiTinh;
        }

        // Phương thức getter và setter cho NgheNghiep
        public string GetNgheNghiep()
        {
            return NgheNghiep;
        }

        public void SetNgheNghiep(string ngheNghiep)
        {
            NgheNghiep = ngheNghiep;
        }

        // Phương thức getter và setter cho SDT
        public string GetSDT()
        {
            return sdt;
        }

        public void SetSDT(string sdt)
        {
            this.sdt = sdt;
        }

        // Phương thức getter và setter cho Tuoi
        public DateTime GetTuoi()
        {
            return Tuoi;
        }

        public void SetTuoi(DateTime tuoi)
        {
            Tuoi = tuoi;
        }
    }
}
