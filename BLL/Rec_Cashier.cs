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
    public static class Rec_Cashier
    {
        public static DataSet ChuaThanhToan()
        {
            return DAL.Rec_Cashier.ChuaThanhToan(); ;
        }

        public static DataSet DaThanhToan()
        {
            return DAL.Rec_Cashier.DaThanhToan();
        }
        public static void Thanhtoan(string id,string hinhthuc)
        {
            DAL.Rec_Cashier.Thanhtoan(id,hinhthuc);
        }
        public static DataSet LayHDDV(string stt)
        {
            return DAL.Rec_Cashier.LayHDDV(stt);
        }
        public static DataSet LayHDThuoc(string stt)
        {
            return DAL.Rec_Cashier.LayHDThuoc(stt);
        }
    }
}
