using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public static class Owner_Patient
    {
        public static DataSet DanhSachBenhNhan()
        {
            return DAL.Owner_Patient.DanhSachBenhNhan();
        }
    }
}
