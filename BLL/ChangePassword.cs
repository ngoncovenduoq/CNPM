using Project_CNPM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChangePassword
    {
        public static string Change(string pass, string passnew)
        {
            if (pass.Length < 6 || passnew.Length < 6)
            {
                return "Vui lòng nhập đầy đủ thông tin";
            }
            if (pass.Equals(passnew))
            {
                return "Vui lòng nhập 2 mật khẩu không giống nhau";
            }
            return DAL.ChangePassword.Check(Static.getUser().GetMaNhanVien(), pass, passnew);
        }
    }
}
