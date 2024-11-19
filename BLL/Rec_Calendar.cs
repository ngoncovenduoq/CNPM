using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public static class Rec_Calendar
    {
        private static List<Lam_viec> LichLamViec(DateTime Ngay)
        {
            List<Lam_viec> lichLamViec = DAL.Rec_Calendar.LichLamViec(Ngay);
            return lichLamViec;
        }
    }
}
