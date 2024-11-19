using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AddUser
    {
        public static string Add(DTO.User user)
        {
            DAL.AddUser.Add(user);
            return "Thêm nhân viên thành công";
        }
        public static void EditUser(DTO.User user)
        {
            DAL.AddUser.EditUser(user);
        }
    }
}
