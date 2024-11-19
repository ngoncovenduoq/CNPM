using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Connection
    {
        private static SqlConnection conn;

        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                string strcon = @"Data Source=DESKTOP-RK3T3GP\NGUYENQUAN;Initial Catalog=QuanLyNhaKhoa;Integrated Security=True";
                conn = new SqlConnection(strcon);
            }
            return conn;
        }
    }
}
