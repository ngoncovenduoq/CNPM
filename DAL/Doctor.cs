using DTO;
using Project_CNPM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Doctor
    {
        public static DataSet BenhNhan(string date, string maBS)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();


            SqlCommand cmd = new SqlCommand("proc_timbenhnhan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngay", date);
            cmd.Parameters.AddWithValue("@maBS", maBS);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }


        public static DataSet BenhNhanChuaKham(string date, string maBS)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();


            SqlCommand cmd = new SqlCommand("proc_timbenhnhanchuakham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngay", date);
            cmd.Parameters.AddWithValue("@maBS", maBS);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }

        public static DataSet DaTiepNhan(string date, string maBS)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();


            SqlCommand cmd = new SqlCommand("proc_timbenhnhandatiepnhan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngay", date);
            cmd.Parameters.AddWithValue("@maBS", maBS);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }

        public static void TiepNhan(string maBN)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_tiepnhan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maBN", maBN);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static List<DTO.Lam_viec> CaLam(string date, string ma)
        {
            List<DTO.Lam_viec> list = new List<DTO.Lam_viec>();

            SqlConnection conn = Connection.GetConnection();
            conn.Open();


            SqlCommand cmd = new SqlCommand("proc_lichlam", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngay", date);
            cmd.Parameters.AddWithValue("@maBS", ma);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DTO.Lam_viec lam_Viec = new DTO.Lam_viec();
                    lam_Viec.setCa(reader.GetInt32(0));
                    lam_Viec.setDiemdanh(reader.GetString(1));
                    list.Add(lam_Viec);
                }
            }
            conn.Close();

            return list;
        }
        public static void XepCa(string date, string ma, int ca)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();


            SqlCommand cmd = new SqlCommand("ThemCongViec", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ngay", date);
            cmd.Parameters.AddWithValue("@Ma_bac_si", ma);
            cmd.Parameters.AddWithValue("@Ca", ca);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Diemdanh(string date, string ma, int ca)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();


            SqlCommand cmd = new SqlCommand("DiemDanh", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ngay", date);
            cmd.Parameters.AddWithValue("@Ma_bac_si", ma);
            cmd.Parameters.AddWithValue("@Ca", ca);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataSet CaLamThang(DateTime date, string ma)
        {

            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            DataSet dataSet = new DataSet();


            SqlCommand cmd = new SqlCommand("proc_lichlamthang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nam", date.Year);
            cmd.Parameters.AddWithValue("@thang", date.Month);
            cmd.Parameters.AddWithValue("@maBS", ma);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;
        }

        public static DataSet Thongke(DateTime date, string kieu)
        {

            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            DataSet dataSet = new DataSet();
            SqlCommand cmd;
            switch (kieu)
            {
                case "Tháng":
                    cmd = new SqlCommand("ThongKeTheoThang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    break;
                case "Quý":
                    cmd = new SqlCommand("ThongKeTheoQuy", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    break;
                case "Năm":
                    cmd = new SqlCommand("ThongKeTheoNam", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    break;
                default:
                    cmd = new SqlCommand("ThongKeTheoThang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    break;
            }

            cmd.Parameters.AddWithValue("@nam", date.Year);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;
        }

        public static DataSet Dichvu(string stt)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd;

            cmd = new SqlCommand("select Ten_dich_vu,so_luong from HD_Dich_vu where @STT = stt", conn);
            cmd.Parameters.AddWithValue("@STT", stt);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            return ds;
        }
        public static DataSet Thuoc(string stt)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd;

            cmd = new SqlCommand("select Ten_thuoc, So_luong,Ghi_chu from HD_Thuoc where @STT = stt", conn);
            cmd.Parameters.AddWithValue("@STT", stt);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            return ds;
        }
        public static void Doisoluong(DataTable ds, string stt)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            // Lấy danh sách dịch vụ từ cơ sở dữ liệu
            List<string> sqlDichVu = new List<string>();
            SqlCommand cmdSelect = new SqlCommand("SELECT Ten_dich_vu FROM HD_Dich_vu WHERE STT = @STT", conn);
            cmdSelect.Parameters.AddWithValue("@STT", stt);
            using (SqlDataReader reader = cmdSelect.ExecuteReader())
            {
                while (reader.Read())
                {
                    sqlDichVu.Add(reader.GetString(0));
                }
            }

            // Xóa dịch vụ có trong SQL nhưng không có trong DataRow
            foreach (string sqlTenDichVu in sqlDichVu)
            {
                DataRow[] rows = ds.Select("Ten_dich_vu = '" + sqlTenDichVu + "'");

                // Nếu không tìm thấy dòng nào, tiến hành xóa dịch vụ khỏi SQL
                if (rows.Length == 0)
                {
                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM HD_Dich_vu WHERE Ten_dich_vu = @ten AND STT = @STT", conn);
                    cmdDelete.Parameters.AddWithValue("@ten", sqlTenDichVu);
                    cmdDelete.Parameters.AddWithValue("@STT", stt);
                    cmdDelete.ExecuteNonQuery();
                }
            }

            // Thêm mới hoặc cập nhật dữ liệu từ DataRow
            foreach (DataRow dr in ds.Rows)
            {
                if (dr.RowState != DataRowState.Deleted)
                {
                    string tenDichVu = dr["Ten_dich_vu"].ToString();
                    int soLuong = Convert.ToInt32(dr["so_luong"]);
                    //thêm dịch vụ nếu dịch vụ chưa có trong csdl
                    if (!sqlDichVu.Contains(tenDichVu))
                    {
                        SqlCommand cmdInsert = new SqlCommand("Them_dich_vu_LT", conn);
                        cmdInsert.CommandType = CommandType.StoredProcedure;
                        cmdInsert.Parameters.AddWithValue("@STT", stt);
                        cmdInsert.Parameters.AddWithValue("@Ten_dich_vu", tenDichVu);
                        cmdInsert.ExecuteNonQuery();
                    }

                    //update số lượng dịch vụ
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE HD_Dich_vu SET so_luong = @soluong WHERE Ten_dich_vu = @ten AND STT = @STT", conn);
                    cmdUpdate.Parameters.AddWithValue("@ten", tenDichVu);
                    cmdUpdate.Parameters.AddWithValue("@soluong", soLuong);
                    cmdUpdate.Parameters.AddWithValue("@STT", stt);
                    cmdUpdate.ExecuteNonQuery();
                }
            }

            conn.Close();
        }
        public static void Themthuoc(DataTable ds, string stt)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            // Retrieve list of medications from the database
            List<string> sqlMedications = new List<string>();
            SqlCommand cmdSelect = new SqlCommand("SELECT Ten_thuoc, So_luong FROM HD_Thuoc WHERE STT = @STT", conn);
            cmdSelect.Parameters.AddWithValue("@STT", stt);
            using (SqlDataReader reader = cmdSelect.ExecuteReader())
            {
                while (reader.Read())
                {
                    sqlMedications.Add(reader.GetString(0));
                }
            }

            // Delete medications that are in the database but not in the DataTable
            foreach (string sqlMedication in sqlMedications)
            {
                bool found = false;
                foreach (DataRow dr in ds.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted && dr["Ten_thuoc"].ToString() == sqlMedication)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    int quantityToDelete = 0;

                    SqlCommand cmdSelectQuantity = new SqlCommand("SELECT So_luong FROM HD_Thuoc WHERE Ten_thuoc = @Ten_thuoc AND STT = @STT", conn);
                    cmdSelectQuantity.Parameters.AddWithValue("@Ten_thuoc", sqlMedication);
                    cmdSelectQuantity.Parameters.AddWithValue("@STT", stt);
                    quantityToDelete = Convert.ToInt32(cmdSelectQuantity.ExecuteScalar());

                    // Delete medication from HD_Thuoc
                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM HD_Thuoc WHERE Ten_thuoc = @Ten_thuoc AND STT = @STT", conn);
                    cmdDelete.Parameters.AddWithValue("@Ten_thuoc", sqlMedication);
                    cmdDelete.Parameters.AddWithValue("@STT", stt);
                    cmdDelete.ExecuteNonQuery();

                    // Update quantity of medication in inventory
                    SqlCommand cmdUpdateInventory = new SqlCommand("UPDATE Thuoc SET So_luong = So_luong + @QuantityToDelete WHERE Ten_thuoc = @Ten_thuoc", conn);
                    cmdUpdateInventory.Parameters.AddWithValue("@QuantityToDelete", quantityToDelete);
                    cmdUpdateInventory.Parameters.AddWithValue("@Ten_thuoc", sqlMedication);
                    cmdUpdateInventory.ExecuteNonQuery();
                }
            }

            // Add new medications or update existing ones
            foreach (DataRow dr in ds.Rows)
            {
                if (dr.RowState != DataRowState.Deleted)
                {
                    string tenThuoc = dr["Ten_thuoc"].ToString();
                    int soLuong = Convert.ToInt32(dr["So_luong"]);
                    string ghiChu = dr["Ghi_chu"].ToString();

                    // Add medication if it doesn't exist in the database
                    if (!sqlMedications.Contains(tenThuoc))
                    {
                        SqlCommand cmdInsert = new SqlCommand("Them_hoadon_thuoc", conn);
                        cmdInsert.CommandType = CommandType.StoredProcedure;
                        cmdInsert.Parameters.AddWithValue("@STT", stt);
                        cmdInsert.Parameters.AddWithValue("@Ten_thuoc", tenThuoc);
                        cmdInsert.Parameters.AddWithValue("@So_luong", soLuong);
                        cmdInsert.Parameters.AddWithValue("@Ghi_chu", ghiChu);
                        cmdInsert.ExecuteNonQuery();
                    }
                    else
                    {
                        // Calculate quantity difference
                        SqlCommand cmd = new SqlCommand("CapNhatThuocVoiChenhLech", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TenThuoc", tenThuoc);
                        cmd.Parameters.AddWithValue("@STT", stt);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            conn.Close();
        }



        public static void TongHD(string stt)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TongTienHD", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@STT", stt);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static List<string> DanhSachVatLieu()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            List<string> lst = new List<string>();


            cmd = new SqlCommand("SELECT Ten_dung_cu from Vat_lieu", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lst.Add(dr.GetString(0));
                }
            }
            dr.Close();
            conn.Close();

            return lst;
        }
        public static bool Capnhatvatlieu(DataTable ds, string stt)
        {
            // Open connection to the database
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmdSelect;
            try
            {

                // Check if the requested quantity in DataRow is less than in Vat_lieu table
                foreach (DataRow dr in ds.Rows)
                {
                    string tenDungCu = dr["Tên vật liệu"].ToString();
                    int soLuong = Convert.ToInt32(dr["Số lượng"]);

                    if (soLuong < 0)
                    {
                        // If quantity is zero or negative, return false
                        return false;
                    }
                    if (soLuong > 0)
                    {
                        // Check if requested quantity is less than available quantity
                        SqlCommand cmdCheckQuantity = new SqlCommand("SELECT So_luong FROM Vat_lieu WHERE Ten_dung_cu = @Ten_dung_cu", conn);
                        cmdCheckQuantity.Parameters.AddWithValue("@Ten_dung_cu", tenDungCu);
                        int availableQuantity = Convert.ToInt32(cmdCheckQuantity.ExecuteScalar());

                        if (soLuong > availableQuantity)
                        {
                            // If requested quantity is more than available quantity, return false
                            return false;
                        }
                    }
                    
                }

                // Retrieve data from the Chi_tieu_dung_cu table
                List<string> expenditures = new List<string>();
                cmdSelect = new SqlCommand("SELECT Ten_dung_cu, So_luong FROM Chi_tieu_dung_cu WHERE id = @stt", conn);
                cmdSelect.Parameters.AddWithValue("@stt", stt);
                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        expenditures.Add(reader.GetString(0));
                    }
                }

                // Check if there are any DataRow with quantity equal to 0 but quantity in database > 0
                foreach (DataRow dr in ds.Rows)
                {
                    string tenDungCu = dr["Tên vật liệu"].ToString();
                    int soLuong = Convert.ToInt32(dr["Số lượng"]);

                    if (soLuong == 0 && expenditures.Contains(tenDungCu))
                    {
                        // Delete expenditure associated with the material
                        SqlCommand cmdDeleteExpenditure = new SqlCommand("DELETE FROM Chi_tieu_dung_cu WHERE Ten_dung_cu = @Ten_dung_cu", conn);
                        cmdDeleteExpenditure.Parameters.AddWithValue("@Ten_dung_cu", tenDungCu);
                        cmdDeleteExpenditure.ExecuteNonQuery();

                        // Update quantity of material in inventory
                        SqlCommand cmdUpdateInventory = new SqlCommand("UPDATE Vat_lieu SET So_luong = So_luong + (SELECT So_luong FROM deleted WHERE Ten_dung_cu = @Ten_dung_cu) WHERE Ten_dung_cu = @Ten_dung_cu", conn);
                        cmdUpdateInventory.Parameters.AddWithValue("@Ten_dung_cu", tenDungCu);
                        cmdUpdateInventory.ExecuteNonQuery();
                    }
                }

                // Check if there are any DataRow with quantity > 0 but not in expenditures
                foreach (DataRow dr in ds.Rows)
                {
                    string tenDungCu = dr["Tên vật liệu"].ToString();
                    int soLuong = Convert.ToInt32(dr["Số lượng"]);

                    if (soLuong > 0 && !expenditures.Contains(tenDungCu))
                    {
                        // Add new expenditure
                        SqlCommand cmdInsert = new SqlCommand("them_chiTieuDungCu", conn);
                        cmdInsert.CommandType = CommandType.StoredProcedure;
                        cmdInsert.Parameters.AddWithValue("@STT", stt);
                        cmdInsert.Parameters.AddWithValue("@Ten_dung_cu", tenDungCu);
                        cmdInsert.Parameters.AddWithValue("@So_luong", soLuong);
                        cmdInsert.ExecuteNonQuery();
                    }
                    else if (soLuong > 0 && expenditures.Contains(tenDungCu))
                    {
                        // Update existing expenditure
                        SqlCommand cmdUpdateExpenditure = new SqlCommand("UPDATE Chi_tieu_dung_cu SET So_luong = @So_luong WHERE Ten_dung_cu = @Ten_dung_cu", conn);
                        cmdUpdateExpenditure.Parameters.AddWithValue("@So_luong", soLuong);
                        cmdUpdateExpenditure.Parameters.AddWithValue("@Ten_dung_cu", tenDungCu);
                        cmdUpdateExpenditure.ExecuteNonQuery();

                        // Calculate quantity difference
                        SqlCommand cmdCalcDifference = new SqlCommand("SELECT So_luong FROM Chi_tieu_dung_cu WHERE Ten_dung_cu = @Ten_dung_cu AND id = @stt", conn);
                        cmdCalcDifference.Parameters.AddWithValue("@Ten_dung_cu", tenDungCu);
                        cmdCalcDifference.Parameters.AddWithValue("@stt", stt);
                        int dbQuantity = Convert.ToInt32(cmdCalcDifference.ExecuteScalar());
                        int quantityDifference = soLuong - dbQuantity;

                        // Update quantity of material in inventory
                        SqlCommand cmdUpdateInventory = new SqlCommand("UPDATE Vat_lieu SET So_luong = So_luong + @QuantityDifference WHERE Ten_dung_cu = @Ten_dung_cu", conn);
                        cmdUpdateInventory.Parameters.AddWithValue("@QuantityDifference", quantityDifference);
                        cmdUpdateInventory.Parameters.AddWithValue("@Ten_dung_cu", tenDungCu);
                        cmdUpdateInventory.ExecuteNonQuery();
                    }
                }

                // If all operations succeed, return true
                return true;
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }
        public static List<string> GetLichLam(string maBS, int thang, int nam)
        {
            List<string> lichLam = new List<string>();
            SqlConnection connection = Connection.GetConnection();
            // Mở kết nối
            connection.Open();

            // Chuỗi truy vấn SQL để lấy ngày làm việc
            string query = "Lay_ngay_ra";

            // Tạo đối tượng SqlCommand
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh truy vấn
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mabacsi", maBS);
                command.Parameters.AddWithValue("@thang", thang);
                command.Parameters.AddWithValue("@nam", nam);

                // Thực thi truy vấn và đọc kết quả
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lichLam.Add(reader.GetInt32(0).ToString());
                    }
                }
            }
            connection.Close();

            return lichLam;
        }
    }
}
