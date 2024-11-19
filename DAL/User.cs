using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        public static DTO.User GetUser(string taikhoan)
        {
            DTO.User user = new DTO.User();


            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand("proc_thongtin",conn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@taikhoan", taikhoan);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                user.SetMaNhanVien(reader.GetString(0));
                user.SetHo(reader.GetString(1));
                user.SetTen(reader.GetString(2));
                user.SetGioiTinh(reader.GetString(3));
            }
            reader.Close();
            conn.Close();



            return user;
        }
    }
}
