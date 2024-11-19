using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Owner
    {
        public static DataSet Doctor()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_timbacsi", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }

        public static DTO.User GetInfo(string ma)
        {
            DTO.User user = null;
            string query = "SELECT * FROM Nguoi_dung WHERE Ma_nhan_vien = @Ma";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ma", ma);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Create a new instance of User
                user = new DTO.User();

                // Populate user properties from the database
                user.SetMaNhanVien(reader["Ma_nhan_vien"].ToString());
                user.SetHo(reader["Ho"].ToString());
                user.SetTen(reader["Ten"].ToString());
                user.SetGioiTinh(reader["Gioi_tinh"].ToString());
                user.SetNgaySinh(Convert.ToDateTime(reader["Ngay_sinh"]));
                user.SetEmail(reader["email"].ToString());
                user.SetQueQuan(reader["Que_quan"].ToString());
                user.SetCCCD(reader["CCCD"].ToString());
            }

            reader.Close();
            connection.Close();
            return user;
        }


        public static DataSet Rec()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_timletan", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }
        public static DataSet DichVu()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_chitieudichvu", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }
        public static DataSet Thuoc()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_chitieuthuoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }
        public static DataSet Income()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_income", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }
        public static DataSet Luongs(DateTime date)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlDataReader reader;
            SqlCommand cmd;
            List<DTO.Luong> luongs = new List<DTO.Luong>();

            cmd = new SqlCommand("proc_luong", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nam", date.Year);
            cmd.Parameters.AddWithValue("@thang", date.Month);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    luongs.Add(new DTO.Luong(reader.GetString(0), reader.GetString(1), reader.GetDouble(2).ToString("F0")));
                }
            }
            reader.Close();
            cmd = new SqlCommand("proc_luongcb", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DTO.Luong luong = new DTO.Luong(reader.GetString(0), reader.GetString(1), reader.GetDouble(2).ToString("F0"));
                    bool check = true;
                    foreach (DTO.Luong index in luongs)
                    {
                        if (index.Ma.Equals(luong.Ma))
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        luongs.Add(luong);
                    }
                }
            }
            reader.Close();
            conn.Close();
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Ma_nhan_vien", typeof(string));
            dataTable.Columns.Add("HoTen", typeof(string));
            dataTable.Columns.Add("Tong_luong", typeof(string));

            foreach (Luong luong in luongs)
            {
                DataRow row = dataTable.NewRow();
                row["Ma_nhan_vien"] = luong.Ma;
                row["HoTen"] = luong.Name;
                row["Tong_luong"] = luong.Value;
                dataTable.Rows.Add(row);
            }

            dataSet.Tables.Add(dataTable);

            return dataSet;
        }
        public static void ThayDoiTrangThai(string ma, int hoatdong)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            string sqlUpdate = "UPDATE Nguoi_dung SET Hoatdong = @Hoatdong WHERE Ma_nhan_vien = @Ma_nhan_vien";

            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("@Ma_nhan_vien", ma);
            cmd.Parameters.AddWithValue("@Hoatdong", hoatdong);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet LayChiTieuThuoc()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            DataSet dataSet = new DataSet();

            cmd = new SqlCommand("select * from HD_Thuoc", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;
        }
        public static DataSet LayChiTieuDungCu()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            DataSet dataSet = new DataSet();

            cmd = new SqlCommand("select * from Chi_tieu_dung_cu ", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;
        }
    }
}
