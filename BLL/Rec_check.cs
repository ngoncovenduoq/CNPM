using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Rec_check
    {
        public static DataSet BenhNhan()
        {
            return DAL.Rec_check.BenhNhan();
        }
    }
}
