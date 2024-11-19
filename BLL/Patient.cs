using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Patient
    {
        public static string ThemNguoiKham(int ca,DateTime ngay,string maLeTan,string maBacSi,string maBN)
        {
            if(DateTime.Now.Date > ngay.Date)
            {
                return "";
            }
            else
            {
                return DAL.Patient.ThemNguoiKham(ca, ngay.ToString("MM/dd/yyyy"), maLeTan, maBacSi, maBN);
            }
        }
        public static DTO.BenhNhan TimBenhNhan(string stt)
        {
            return DAL.Patient.TimBenhNhan(stt);
        }
    }
}
