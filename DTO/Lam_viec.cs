using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lam_viec
    {
        private DateTime Ngay;
        private int Ca;
        private String Ma_bac_si;
        private String Diemdanh;

        public Lam_viec() { }

        public Lam_viec(DateTime ngay, int ca, string ma_bac_si, string diemdanh)
        {
            Ngay = ngay;
            Ca = ca;
            Ma_bac_si = ma_bac_si;
            Diemdanh = diemdanh;
        }

        public DateTime getNgay()
        {
            return Ngay;
        }
        public int getCa()
        {
            return Ca;
        }
        public String getMa_bac_si()
        {
            return Ma_bac_si;
        }
        public String getDiemdanh()
        {
            return Diemdanh;
        }
        public void setNgay(DateTime ngay)
        {
            this.Ngay = ngay;
        }

        // Setter cho thuộc tính Ca
        public void setCa(int ca)
        {
            this.Ca = ca;
        }

        // Setter cho thuộc tính Ma_bac_si
        public void setMa_bac_si(string ma_bac_si)
        {
            this.Ma_bac_si = ma_bac_si;
        }

        // Setter cho thuộc tính Diemdanh
        public void setDiemdanh(string diemdanh)
        {
            this.Diemdanh = diemdanh;
        }
    }
}
