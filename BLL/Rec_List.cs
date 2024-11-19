using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public static class Rec_List
    {
        private static List<BenhNhan> DanhSachBenhNhan()
        {
            List<BenhNhan> danhSachBenhNhan = DAL.Rec_List.DanhSachBenhNhan();
            return danhSachBenhNhan;
        }
        public static DataSet Tiepnhan(DateTime date)
        {
            return DAL.Rec_List.Tiepnhan(date.ToString("MM/dd/yyyy"));
        }
        public static void DoiBacSi(string stt, string maBS)
        {
            DAL.Rec_List.DoiBacSi(stt, maBS);
        }
    }
}
