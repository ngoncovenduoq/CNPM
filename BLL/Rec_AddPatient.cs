using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public static class Rec_AddPatient
    {
        public static string ThemBenhNhan(DTO.BenhNhan benh_Nhan)
        {
            return DAL.Rec_AddPatient.ThemBenhNhan(benh_Nhan);
        }

        public static void ThemHoaDonDichVu(string stt,List<string> list)
        {
            DAL.Rec_AddPatient.ThemHoaDonDichVu(stt,list);
        }
    }
}
