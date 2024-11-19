using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public static class Owner_Canlendar
    {
        private static List<Lam_viec> LichLamViec(DateTime Ngay)
        {
            List<Lam_viec> lichLamViec = DAL.Owner_Calendar.LichLamViec(Ngay);
            return lichLamViec;
        }
    }
}