using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dich_vu
    {
        private string Ten_dich_vu;
        private string Don_vi_tinh;
        private float Don_gia;
        private string Ghi_chu;
        private string Ten_danh_muc;

        public Dich_vu() { }

        public Dich_vu(string ten_dich_vu, string don_vi_tinh, float don_gia, string ghi_chu, string ten_danh_muc)
        {
            Ten_dich_vu = ten_dich_vu;
            Don_vi_tinh = don_vi_tinh;
            Don_gia = don_gia;
            Ghi_chu = ghi_chu;
            Ten_danh_muc = ten_danh_muc;
        }

        public string getTen_dich_vu()
        {
            return Ten_dich_vu;
        }

        public string getDon_vi_tinh()
        {
            return Don_vi_tinh;
        }

        public float getDon_gia()
        {
            return Don_gia;
        }

        public string getGhi_chu()
        {
            return Ghi_chu;
        }

        public string getTen_danh_muc()
        {
            return Ten_danh_muc;
        }
    }
}
