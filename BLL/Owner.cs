using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Owner
    {
        public static DataSet Doctor()
        {
            return DAL.Owner.Doctor();
        }
        public static DTO.User GetInfo(string ma)
        {
            return DAL.Owner.GetInfo(ma);
        }

        public static DataSet Rec()
        {
            return DAL.Owner.Rec();
        }

        public static DataSet DichVu()
        {
            return DAL.Owner.DichVu();
        }
        public static DataSet Thuoc()
        {
            return DAL.Owner.Thuoc();
        }
        public static DataSet Income()
        {
            return DAL.Owner.Income();
        }
        public static DataSet Luongs(DateTime date)
        {
            if(date > DateTime.Now)
            {
                return null;
            }
            return DAL.Owner.Luongs(date);
        }
        public static void ThayDoiTrangThai(string ma,int trangthai)
        {
            DAL.Owner.ThayDoiTrangThai(ma, trangthai);
        }
        public static DataSet LayChiTieuThuoc()
        {
            return DAL.Owner.LayChiTieuThuoc();
        }
        public static DataSet LayChiTieuDungCu()
        {
            return DAL.Owner.LayChiTieuDungCu();
        }
    }
}
