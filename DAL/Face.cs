using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using Project_CNPM;


namespace DAL
{
    public class Face
    {

        public static Image<Gray, byte> ConvertByteArrayToImage(byte[] imageData)
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image image = Image.FromStream(ms);

                Image<Gray, byte> grayImage = new Image<Gray, byte>(new Bitmap(image));

                return grayImage;
            }
        }
        public static List<Image<Gray, byte>> RetrieveFromSql()
        {
            List<Image<Gray, byte>> lists = new List<Image<Gray, byte>>();
            byte[] imageData = null;
            SqlConnection connection = Connection.GetConnection();

            connection.Open();

            using (SqlCommand command = new SqlCommand("proc_layanh", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        imageData = (byte[])(reader["bin"]);
                        lists.Add(ConvertByteArrayToImage(imageData));
                    }
                }
            }
            connection.Close();
            return lists;
        }
        public static List<string> Name()
        {
            List<string> nam = new List<string>();
            SqlConnection connection = Connection.GetConnection();
            connection.Open();

            using (SqlCommand command = new SqlCommand("proc_layanh", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string temp = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        nam.Add(temp);
                    }
                }
            }
            connection.Close();
            return nam;
        }
        public static void SaveToSql(string name, byte[] imageData)
        {

            SqlConnection connection = Connection.GetConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("proc_themanh", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Taikhoan", name);
            command.Parameters.AddWithValue("@bin", imageData);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void XoaFace()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_xoaanh", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Taikhoan", Static.getUser().GetMaNhanVien());

            command.ExecuteNonQuery();
            conn.Close();


        }
    }
}
