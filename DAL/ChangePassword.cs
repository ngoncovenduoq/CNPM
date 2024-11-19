using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChangePassword
    {
        public static string Check(string manhanvien,string matkhau,string matkhaumoi)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dr;

            cmd = new SqlCommand("proc_check", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", manhanvien);
            cmd.Parameters.AddWithValue("@matkhau",matkhau);
            dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                conn.Close();
                return "Nhập sai mật khẩu";
            }
            dr.Close();

            cmd = new SqlCommand("proc_thaydoimatkhau",conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", manhanvien);
            cmd.Parameters.AddWithValue("@matkhaumoi", matkhaumoi);

            cmd.ExecuteNonQuery();
            conn.Close();

            return "Thay đổi thành công";
        }
    }
}
