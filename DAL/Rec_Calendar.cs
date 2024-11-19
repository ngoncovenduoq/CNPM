using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Rec_Calendar
    {
        public static List<Lam_viec> LichLamViec(DateTime ngay)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dr;

            List<Lam_viec> lichLamViec = new List<Lam_viec>();

            cmd = new SqlCommand("SELECT * FROM Lam_viec WHERE Ngay = @ngay", conn);
            cmd.Parameters.AddWithValue("@ngay", ngay);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DateTime Ngay = Convert.ToDateTime(dr["Ngay"]);
                int Ca = (int)dr["Ca"];
                String Ma_bac_si = dr["Ma_bac_si"].ToString();
                String Diemdanh = dr["Diemdanh"].ToString();

                Lam_viec lv = new Lam_viec(Ngay, Ca, Ma_bac_si, Diemdanh);
                lichLamViec.Add(lv);
            }

            dr.Close();
            conn.Close();

            return lichLamViec;
        }
    }
}
