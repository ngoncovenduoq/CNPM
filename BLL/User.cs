using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User
    {
        public static DTO.User GetUser(string taikhoan)
        {
            return DAL.User.GetUser(taikhoan);
        }
    }
}
