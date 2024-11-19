using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Vat_lieu
    {
        private string Ten_dung_cu;
        private string Mau_sac;
        private float Kich_co;
        private string DVT;
        private float Gia;
        private int So_luong;
        private string Ghi_chu;
        private string Loai;
        public Vat_lieu() { }

        public Vat_lieu(string ten_dung_cu, string mau_sac, float kich_co, string dvt, float gia, int so_luong, string ghi_chu, string loai)
        {
            Ten_dung_cu = ten_dung_cu;
            Mau_sac = mau_sac;
            Kich_co = kich_co;
            DVT = dvt;
            Gia = gia;
            So_luong = so_luong;
            Ghi_chu = ghi_chu;
            Loai = loai;
        }

        public string getTen_dung_cu()
        {
            return Ten_dung_cu;
        }

        public string getMau_sac()
        {
            return Mau_sac;
        }

        public float getKich_co()
        {
            return Kich_co;
        }

        public string getDVT()
        {
            return DVT;
        }

        public float getGia()
        {
            return Gia;
        }

        public int getSo_luong()
        {
            return So_luong;
        }

        public string getGhi_chu()
        {
            return Ghi_chu;
        }

        public string getLoai()
        {
            return Loai;
        }
    }
}
