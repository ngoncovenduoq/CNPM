using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ForgotPassword
    {
        private int rand;
        private string user;
        public ForgotPassword()
        {
            this.rand = 0;
            this.user = null;
        }
        private void Random()
        {
            this.rand = new Random().Next(10000, 99999);
        }
        public string KiemTra(string username, string email)
        {
            if (username.Equals("Tên tài khoản") || username.Length == 0)
            {
                return "Vui lòng nhập tài khoản";
            }
            if (email.Equals("Email") || email.Length == 0)
            {
                return "Vui lòng nhập email";
            }


            string check = DAL.ForgotPassword.KiemTra(username, email);
            if (!check.Equals("Thành công"))
            {
                return check;

            }
            this.user = username;
            Random();
            MailMessage message = new MailMessage();
            message.To.Add(new MailAddress(email));
            message.From = new MailAddress("tenpteam@gmail.com");
            message.Subject = "Mail khôi phục mật khẩu";
            message.Body = "Mã xác nhận của bạn là:" + rand.ToString();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential("tenpteam@gmail.com", "lypk tgpj zfko ouwi");
            try
            {
                smtpClient.Send(message);
            }
            catch
            {
                return "Gửi mail không thành công";
            }


            return "Đã gửi email";
        }
        public string Code(string code)
        {
            if (!code.Equals(rand.ToString()))
            {
                return "Nhập sai mã xác nhận";
            }

            DAL.ForgotPassword.Code(user);
            return "Khôi phục mật khẩu thành công";
        }
    }
}
