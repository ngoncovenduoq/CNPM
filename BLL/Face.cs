using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Face
    {
        public static List<string> Name()
        {
            return DAL.Face.Name();
        }
        public static List<Image<Gray, byte>> RetrieveFromSql()
        {
            return DAL.Face.RetrieveFromSql();
        }
        public static void SaveToSql(string name, byte[] imageData)
        {
            DAL.Face.SaveToSql(name, imageData);
        }
        public static void XoaFace()
        {
            DAL.Face.XoaFace();
        }
    }
}
