using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CNPM
{
    public class Static
    {
        private static DTO.User userGoc;
        public static void changeUser(DTO.User user)
        {
            userGoc = user;
        }
        public static DTO.User getUser()
        {
            if (userGoc != null)
            {
                return userGoc;
            }
            return new DTO.User();
        }
    }
}
