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
    public class Rec_List
    {
        public static List<BenhNhan> DanhSachBenhNhan()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Benh_nhan", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            List<BenhNhan> danhSachBenhNhan = new List<BenhNhan>();

            while (dr.Read())
            {
                string CCCD = dr["CCCD"].ToString();
                string Ho = dr["Ho"].ToString();
                string Ten = dr["Ten"].ToString();
                string GioiTinh = dr["Gioi_tinh"].ToString();
                DateTime NgaySinh = (DateTime)dr["NgaySinh"];
                string DiaChi = dr["Dia_chi"].ToString();
                string NgheNghiep = dr["Nghe_nghiep"].ToString();
                string SoDienThoai = dr["So_dien_thoai"].ToString();

                BenhNhan benhNhan = new BenhNhan(CCCD, Ho, Ten, GioiTinh,DiaChi,NgheNghiep, SoDienThoai,NgaySinh);

                danhSachBenhNhan.Add(benhNhan);
            }

            dr.Close();
            conn.Close();

            return danhSachBenhNhan;
        }


        public static DataSet Tiepnhan(string date)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();


            SqlCommand cmd = new SqlCommand("proc_timtatcabenhnhan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngay", date);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }
        public static void DoiBacSi(string stt, string maBS)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            string query = "UPDATE Nguoi_kham SET Ma_bac_si = @maBS WHERE STT = @stt";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maBS", maBS);
            cmd.Parameters.AddWithValue("@stt", stt);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
