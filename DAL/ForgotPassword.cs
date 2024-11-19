using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ForgotPassword
    {
        public static string KiemTra(string username, string email)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            string message = "";
            cmd = new SqlCommand("proc_kiemtraemail", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@taikhoan", username);
            cmd.Parameters.AddWithValue("@email", email);

            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@message";
            outputParameter.SqlDbType = System.Data.SqlDbType.NVarChar;
            outputParameter.Size = 1000;
            outputParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outputParameter);

            cmd.ExecuteNonQuery();
            message = outputParameter.Value.ToString();
            conn.Close();
            return message;
        }
        public static void Code(string username)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_khoiphucmatkhau", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@taikhoan", username);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
