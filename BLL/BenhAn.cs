using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BenhAn
    {
        public static List<DTO.BenhAn> LayBenhAn(string maBenhNhan)
        {
            return DAL.BenhAn.LayBenhAn(maBenhNhan);
        }
        public static DTO.BenhNhan LayBenhNhan(string maBenhNhan)
        {
            return DAL.BenhAn.LayBenhNhan(maBenhNhan);
        }
        public static DTO.Patient LayThongTin(string maBenhNhan)
        {
            return DAL.BenhAn.LayThongTin(maBenhNhan);
        }
        public static void TaoBenhAn(DTO.BenhAn benhAn,string stt)
        {
            DAL.BenhAn.TaoBenhAn(benhAn,stt);
        }
        public static DataSet LayTheoDoi(string maBenhNhan)
        {
            return DAL.BenhAn.LayTheoDoi(maBenhNhan);
        }
        public static void TaoTheoDoi(string maBenhNhan, string theodoi)
        {
            DAL.BenhAn.TaoTheoDoi(maBenhNhan , theodoi);
        }
    }
}
