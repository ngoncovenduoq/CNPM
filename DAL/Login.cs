using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Login
    {
        public static string Log(DTO.Account account)
        {
            string message = "";

            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_check_login", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@taikhoan", account.getTaiKhoan());
            cmd.Parameters.AddWithValue("@matkhau", account.getMatKhau());

            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@message";
            outputParameter.SqlDbType = SqlDbType.NVarChar;
            outputParameter.Size = 1000;
            outputParameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParameter);

            cmd.ExecuteNonQuery();

            message = outputParameter.Value.ToString();
            conn.Close();
            return message;
        }
        
    }
}
