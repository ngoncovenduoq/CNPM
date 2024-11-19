using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Rec_check
    {
        public static DataSet BenhNhan()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd;
            DataSet dataSet = new DataSet();

            cmd = new SqlCommand("SELECT ho+' '+ten as HoTen,gioi_tinh,tuoi FROM Benh_nhan", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            conn.Close();

            return dataSet;
        }
    }
}
