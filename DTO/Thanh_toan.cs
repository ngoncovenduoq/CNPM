using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thanh_toan
    {
        private String ID;
        private String STT;
        private DateTime Gio;
        private float Tongtien;
        private String Hinhthuc;
        private String Tinhtrang;

        public Thanh_toan() { }

        public Thanh_toan(string iD, string sTT, DateTime gio, float tongtien, string hinhthuc, string tinhtrang)
        {
            ID = iD;
            STT = sTT;
            Gio = gio;
            Tongtien = tongtien;
            Hinhthuc = hinhthuc;
            Tinhtrang = tinhtrang;
        }

        public String getID()
        {
            return ID;
        }
        public String getSTT()
        {
            return STT;
        }
        public DateTime getGio()
        {
            return Gio;
        }
        public float getTongtien()
        {
            return Tongtien;
        }
        public String getHinhthuc()
        {
            return Hinhthuc;
        }
        public String getTinhtrang()
        {
            return Tinhtrang;
        }
    }
}
