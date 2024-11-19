using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Patient
    {
        public static string ThemNguoiKham(int ca, string ngay, string maLeTan, string maBacSi, string maBN)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dr;
            string result;

            //kiểm tra có tồn tại chưa
            cmd = new SqlCommand("proc_timSTT", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ca", ca);
            cmd.Parameters.AddWithValue("@ngay", ngay);
            cmd.Parameters.AddWithValue("@Ma_benh_nhan", maBN);
            cmd.Parameters.AddWithValue("@Ma_le_tan", maLeTan);
            cmd.Parameters.AddWithValue("@Ma_bac_si", maBacSi);

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                result = dr.GetString(0);
                dr.Close();
                conn.Close();
                return result;
            }
            dr.Close();
            if (maLeTan.Equals(""))
            {
                cmd = new SqlCommand("Them_nguoi_kham_bac_si", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ca", ca);
                cmd.Parameters.AddWithValue("@ngay", ngay);
                cmd.Parameters.AddWithValue("@Ma_benh_nhan", maBN);
                cmd.Parameters.AddWithValue("@Ma_bac_si", maBacSi);
            }
            else
            {
                cmd = new SqlCommand("Them_nguoi_kham", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ca", ca);
                cmd.Parameters.AddWithValue("@ngay", ngay);
                cmd.Parameters.AddWithValue("@Ma_benh_nhan", maBN);
                cmd.Parameters.AddWithValue("@Ma_le_tan", maLeTan);
                cmd.Parameters.AddWithValue("@Ma_bac_si", maBacSi);
            }


            cmd.ExecuteNonQuery();
            if (!maLeTan.Equals(""))
            {
                cmd = new SqlCommand("proc_timSTT", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ca", ca);
                cmd.Parameters.AddWithValue("@ngay", ngay);
                cmd.Parameters.AddWithValue("@Ma_benh_nhan", maBN);
                cmd.Parameters.AddWithValue("@Ma_le_tan", maLeTan);
                cmd.Parameters.AddWithValue("@Ma_bac_si", maBacSi);

                dr = cmd.ExecuteReader();
                dr.Read();
                result = dr.GetString(0);
                dr.Close();

            }
            else
            {
                result = "1";
            }
            conn.Close();
            return result;
        }


        public static DTO.BenhNhan TimBenhNhan(string stt)
        {
            DTO.BenhNhan benhNhan = null;
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Benh_nhan WHERE MaBN = @stt", conn))
            {
                command.Parameters.AddWithValue("@stt", stt);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    benhNhan = new BenhNhan(
                        reader["CCCD"].ToString(),
                        reader["Ho"].ToString(),
                        reader["Ten"].ToString(),
                        reader["Gioi_tinh"].ToString(),
                        reader["Dia_chi"].ToString(),
                        reader["Nghe_nghiep"].ToString(),
                        reader["So_dien_thoai"].ToString(),
                        Convert.ToDateTime(reader["NgaySinh"])
                    );
                }
                reader.Close();
            }
            conn.Close();
            return benhNhan;
        }
    }
}
