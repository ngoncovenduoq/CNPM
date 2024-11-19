using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Rec_Cashier
    {
        public static DataSet ChuaThanhToan()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            DataSet dataSet = new DataSet();

            cmd = new SqlCommand("SELECT ID,STT,tinhtrang,Tongtien FROM Thanh_toan WHERE Tinhtrang = N'Chưa thanh toán'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;

        }

        public static DataSet DaThanhToan()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            DataSet dataSet = new DataSet();

            cmd = new SqlCommand("SELECT * FROM Thanh_toan WHERE Tinhtrang = N'Đã thanh toán'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;
        }
        public static void Thanhtoan(string id,string hinhthuc)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;

            cmd = new SqlCommand("CapNhatThanhToan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@hinhthuc",hinhthuc);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet LayHDDV(string stt)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            DataSet dataSet = new DataSet();

            cmd = new SqlCommand("select * from HD_Dich_vu where stt = @stt and so_luong>0", conn);
            cmd.Parameters.AddWithValue("@stt", stt);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;
        }
        public static DataSet LayHDThuoc(string stt)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            DataSet dataSet = new DataSet();

            cmd = new SqlCommand("select * from HD_Thuoc where stt = @stt and so_luong>0", conn);
            cmd.Parameters.AddWithValue("@stt", stt);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;
        }
    }
}
