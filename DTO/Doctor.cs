using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Doctor : User
    {
        private String Ma_bac_si;
        private String Chuyen_nganh;
        public Doctor() { }

        public Doctor(string ma_bac_si, string chuyen_nganh)
        {
            Ma_bac_si = ma_bac_si;
            Chuyen_nganh = chuyen_nganh;
        }

        public String getMa_bac_si()
        {
            return Ma_bac_si;
        }
        public String getChuyen_nganh()
        {
            return Chuyen_nganh;
        }

        public void setChuyen_nganh(String chuyen_nganh)
        {
            this.Chuyen_nganh = chuyen_nganh;
        }
        public void setMaBS(string mabs)
        {
            this.Ma_bac_si = mabs;
        }
    }
}
