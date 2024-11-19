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
    public class Rec_AddPatient
    {
        public static String ThemBenhNhan(DTO.BenhNhan benh_nhan)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dr;

            // Kiểm tra xem bệnh nhân đã tồn tại trong cơ sở dữ liệu chưa
            cmd = new SqlCommand("SELECT COUNT(*) FROM Benh_nhan WHERE CCCD = @CCCD", conn);
            cmd.Parameters.AddWithValue("@CCCD", benh_nhan.GetCCCD());
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int count = dr.GetInt32(0);
                if (count > 0)
                {
                    dr.Close();
                    conn.Close();
                    return "Bệnh nhân đã tồn tại";
                }
            }
            dr.Close();

            // Thêm bệnh nhân mới vào cơ sở dữ liệu
            cmd = new SqlCommand("ThemBenhNhan", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CCCD", benh_nhan.GetCCCD());
            cmd.Parameters.AddWithValue("@Ho", benh_nhan.GetHo());
            cmd.Parameters.AddWithValue("@Ten", benh_nhan.GetTen());
            cmd.Parameters.AddWithValue("@Gioitinh", benh_nhan.GetGioiTinh());
            cmd.Parameters.AddWithValue("@DiaChi", benh_nhan.GetDiaChi());
            cmd.Parameters.AddWithValue("@NgaySinh", benh_nhan.GetTuoi());
            cmd.Parameters.AddWithValue("@NgheNghiep", benh_nhan.GetNgheNghiep());
            cmd.Parameters.AddWithValue("@SoDienThoai", benh_nhan.GetSDT());

            cmd.ExecuteNonQuery();
            conn.Close();

            return "Thêm bệnh nhân thành công";

        }

        public static void ThemHoaDonDichVu(string stt, List<string> list)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            List<string> lst = new List<string>();
            SqlCommand cmd;

            //những dịch vụ đã chọn trước đó
            cmd = new SqlCommand("select Ten_dich_vu from HD_Dich_vu where @STT = stt", conn);
            cmd.Parameters.AddWithValue("@STT", stt);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lst.Add(dr.GetString(0));
                }
            }
            dr.Close();


            foreach (string dichvu in list)
            {
                if (!lst.Contains(dichvu))
                {
                    cmd = new SqlCommand("Them_dich_vu_LT", conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@STT", stt);
                    cmd.Parameters.AddWithValue("@Ten_dich_vu", dichvu);
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
    }
}
