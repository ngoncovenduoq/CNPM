using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public User() { }

        protected string maNhanVien;
        protected string ho;
        protected string ten;
        protected string gioiTinh;
        protected DateTime ngaySinh;
        protected string email;
        protected string queQuan;
        protected string CCCD;
        protected string maLuong;

        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetMaNhanVien()
        {
            return maNhanVien;
        }

        public void SetMaNhanVien(string value)
        {
            maNhanVien = value;
        }

        public string GetHo()
        {
            return ho;
        }

        public void SetHo(string value)
        {
            ho = value;
        }

        public string GetTen()
        {
            return ten;
        }

        public void SetTen(string value)
        {
            ten = value;
        }

        public string GetGioiTinh()
        {
            return gioiTinh;
        }

        public void SetGioiTinh(string value)
        {
            gioiTinh = value;
        }

        public DateTime GetNgaySinh()
        {
            return ngaySinh;
        }

        public void SetNgaySinh(DateTime value)
        {
            ngaySinh = value;
        }

        public string GetQueQuan()
        {
            return queQuan;
        }

        public void SetQueQuan(string value)
        {
            queQuan = value;
        }

        public string GetCCCD()
        {
            return CCCD;
        }

        public void SetCCCD(string value)
        {
            CCCD = value;
        }

        public string GetMaLuong()
        {
            return maLuong;
        }

        public void SetMaLuong(string value)
        {
            maLuong = value;
        }
    }
}
