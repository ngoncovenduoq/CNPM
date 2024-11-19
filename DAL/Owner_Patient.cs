using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Owner_Patient
    {
        public static DataSet DanhSachBenhNhan()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            DataSet ds = new DataSet();

            List<BenhNhan> danhSachBenhNhan = new List<BenhNhan>();

            cmd = new SqlCommand("SELECT MaBN,ho+' '+ten as HoTen,gioi_tinh,ngaysinh,cccd from Benh_nhan", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            
            conn.Close();

            return ds;
        }
    }
}
