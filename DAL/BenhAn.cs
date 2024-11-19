using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BenhAn
    {
        public static List<DTO.BenhAn> LayBenhAn(string maBenhNhan)
        {
            List<DTO.BenhAn> danhSachBenhAn = new List<DTO.BenhAn>();

            SqlConnection conn = Connection.GetConnection();

            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_LayBenhAn", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBN", maBenhNhan);

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    DTO.BenhAn benhAn = new DTO.BenhAn(
                        0,
                        lyDoDenKham: dr["Ly_do_den_kham"].ToString(),
                        benhSu: dr["Benh_su"].ToString(),
                        tienSuGiaDinh: dr["Tien_su_gia_dinh"].ToString(),
                        tienSuNoiKhoa: dr["Tien_su_noi_khoa"].ToString(),
                        tienSuRangHamMat: dr["Tien_su_rang_ham_mat"].ToString(),
                        khamNgoaiMat: dr["Kham_ngoai_mat"].ToString(),
                        tinhTrangVeSinhRangMieng: dr["Tinh_trang_ve_sinh_rang_mieng"].ToString(),
                        moMem: dr["Mo_mem"].ToString(),
                        moNhaChu: dr["Mo_nha_chu"].ToString(),
                        rang: dr["Rang"].ToString(),
                        khopCan: dr["Khop_can"].ToString(),
                        canLamSang: dr["Can_lam_sang"].ToString(),
                        ketQuaCanLamSang: dr["Ket_qua_can_lam_sang"].ToString(),
                        chuanDoan: dr["Chuan_doan"].ToString(),
                        keHoachDieuTri: dr["Ke_hoach_dieu_tri"].ToString(),
                        cCCD: maBenhNhan,
                        ho: "",
                        ten: "",
                        gioiTinh: "",
                        ngaySinh: DateTime.Now,
                        diaChi: "",
                        ngheNghiep: "",
                        soDienThoai: ""
                    );

                    danhSachBenhAn.Add(benhAn);
                }
            }
            conn.Close();

            return danhSachBenhAn;
        }
        public static DTO.BenhNhan LayBenhNhan(string maBenhNhan)
        {
            SqlConnection conn = Connection.GetConnection();
            DTO.BenhNhan benh = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Ho,Ten,Gioi_tinh,NgaySinh,Dia_chi,Nghe_nghiep,So_dien_thoai\t\r\nfrom Benh_nhan where MaBN = @MaBN", conn);
            cmd.Parameters.AddWithValue("@MaBN", maBenhNhan);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string ho = dr["Ho"].ToString();
                string ten = dr["Ten"].ToString();
                string gioiTinh = dr["Gioi_tinh"].ToString();
                DateTime ngaySinh = (DateTime)dr["NgaySinh"];
                string diaChi = dr["Dia_chi"].ToString();
                string ngheNghiep = dr["Nghe_nghiep"].ToString();
                string soDienThoai = dr["So_dien_thoai"].ToString();

                benh = new DTO.BenhNhan("", ho, ten, gioiTinh, diaChi, ngheNghiep, soDienThoai, ngaySinh);
            }

            dr.Close();
            conn.Close();
            return benh;
        }
        public static void TaoBenhAn(DTO.BenhAn benhAn, string stt)
        {
            string query = @"INSERT INTO Benh_an 
                        (Ly_do_den_kham, Benh_su, Tien_su_gia_dinh, Tien_su_noi_khoa, Tien_su_rang_ham_mat, 
                         Kham_ngoai_mat, Tinh_trang_ve_sinh_rang_mieng, Mo_mem, Mo_nha_chu, Rang, Khop_can,
                         Can_lam_sang, Ket_qua_can_lam_sang, Chuan_doan, Ke_hoach_dieu_tri, MaBN)
                        VALUES 
                        (@Ly_do_den_kham, @Benh_su, @Tien_su_gia_dinh, @Tien_su_noi_khoa, @Tien_su_rang_ham_mat,
                         @Kham_ngoai_mat, @Tinh_trang_ve_sinh_rang_mieng, @Mo_mem, @Mo_nha_chu, @Rang, @Khop_can,
                         @Can_lam_sang, @Ket_qua_can_lam_sang, @Chuan_doan, @Ke_hoach_dieu_tri, @MaBN)";

            SqlConnection conn = Connection.GetConnection();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Ly_do_den_kham", benhAn.LyDoDenKham);
                command.Parameters.AddWithValue("@Benh_su", benhAn.BenhSu);
                command.Parameters.AddWithValue("@Tien_su_gia_dinh", benhAn.TienSuGiaDinh);
                command.Parameters.AddWithValue("@Tien_su_noi_khoa", benhAn.TienSuNoiKhoa);
                command.Parameters.AddWithValue("@Tien_su_rang_ham_mat", benhAn.TienSuRangHamMat);
                command.Parameters.AddWithValue("@Kham_ngoai_mat", benhAn.KhamNgoaiMat);
                command.Parameters.AddWithValue("@Tinh_trang_ve_sinh_rang_mieng", benhAn.TinhTrangVeSinhRangMieng);
                command.Parameters.AddWithValue("@Mo_mem", benhAn.MoMem);
                command.Parameters.AddWithValue("@Mo_nha_chu", benhAn.MoNhaChu);
                command.Parameters.AddWithValue("@Rang", benhAn.Rang);
                command.Parameters.AddWithValue("@Khop_can", benhAn.KhopCan);
                command.Parameters.AddWithValue("@Can_lam_sang", benhAn.CanLamSang);
                command.Parameters.AddWithValue("@Ket_qua_can_lam_sang", benhAn.KetQuaCanLamSang);
                command.Parameters.AddWithValue("@Chuan_doan", benhAn.ChuanDoan);
                command.Parameters.AddWithValue("@Ke_hoach_dieu_tri", benhAn.KeHoachDieuTri);
                command.Parameters.AddWithValue("@MaBN", stt);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }

        }
        public static DataSet LayTheoDoi(string maBenhNhan)
        {
            DataSet dataSet = new DataSet();

            string query = "SELECT Ngay_tao, Cong_viec_dieu_tri FROM Theo_doi_dieu_tri WHERE MaBN = @MaBN";

            SqlConnection conn = Connection.GetConnection();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@MaBN", maBenhNhan);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataSet, "TheoDoi");
                    conn.Close();
                }
                catch (Exception ex)
                {

                }
            }

            return dataSet;
        }
        public static void TaoTheoDoi(string maBenhNhan, string theodoi)
        {
            string ngayHienTai = DateTime.Now.ToString("yyyy-MM-dd");
            string queryCheckExist = "SELECT COUNT(*) FROM Theo_doi_dieu_tri WHERE Ngay_tao = @NgayTao AND MaBN = @MaBN";

            SqlConnection conn = Connection.GetConnection();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            // Kiểm tra xem dữ liệu đã tồn tại hay chưa
            using (SqlCommand commandCheckExist = new SqlCommand(queryCheckExist, conn))
            {
                commandCheckExist.Parameters.AddWithValue("@NgayTao", ngayHienTai);
                commandCheckExist.Parameters.AddWithValue("@MaBN", maBenhNhan);

                int count = (int)commandCheckExist.ExecuteScalar();

                if (count > 0)
                {
                    // Nếu dữ liệu đã tồn tại, thực hiện cập nhật
                    string queryUpdate = "UPDATE Theo_doi_dieu_tri SET Cong_viec_dieu_tri = @TheoDoi WHERE Ngay_tao = @NgayTao AND MaBN = @MaBN";

                    using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, conn))
                    {
                        commandUpdate.Parameters.AddWithValue("@TheoDoi", theodoi);
                        commandUpdate.Parameters.AddWithValue("@NgayTao", ngayHienTai);
                        commandUpdate.Parameters.AddWithValue("@MaBN", maBenhNhan);
                        commandUpdate.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Nếu dữ liệu chưa tồn tại, thực hiện thêm mới
                    string queryInsert = "INSERT INTO Theo_doi_dieu_tri (Ngay_tao, Cong_viec_dieu_tri, MaBN) VALUES (@NgayTao, @TheoDoi, @MaBN)";

                    using (SqlCommand commandInsert = new SqlCommand(queryInsert, conn))
                    {
                        commandInsert.Parameters.AddWithValue("@NgayTao", ngayHienTai);
                        commandInsert.Parameters.AddWithValue("@TheoDoi", theodoi);
                        commandInsert.Parameters.AddWithValue("@MaBN", maBenhNhan);
                        commandInsert.ExecuteNonQuery();
                    }
                }
            }
            conn.Close();
        }
        public static DTO.Patient LayThongTin(string maBenhNhan)
        {
            DTO.Patient patient = null;

            SqlConnection connection = Connection.GetConnection();
            // Mở kết nối
            connection.Open();

            // Tạo đối tượng SqlCommand để thực thi stored procedure
            using (SqlCommand cmd = new SqlCommand("Proc_lankham", connection))
            {
                // Đặt kiểu lệnh là stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Thêm tham số cho stored procedure
                cmd.Parameters.Add("@Mabn", System.Data.SqlDbType.VarChar).Value = maBenhNhan;

                // Thực thi câu lệnh và đọc kết quả
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Đọc dữ liệu từ SqlDataReader
                    if (reader.Read())
                    {
                        // Lấy giá trị từ reader và gán cho thuộc tính của đối tượng patient
                        patient = new DTO.Patient();
                        patient.SetNgay(reader.GetDateTime(0));
                        patient.SetMaBS(reader.GetString(1));
                    }
                }
            }
            connection.Close();
            return patient;
        }
    }
}
