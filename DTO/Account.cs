using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {

        private string taiKhoan;
        private string matKhau;
        private string maNhanVien;
        private int soLan;

        public Account() { }

        public string getTaiKhoan()
        {
            return taiKhoan;
        }
        public string getMatKhau()
        {
            return matKhau;
        }
        public string getMaNhanVien()
        {
            return maNhanVien;
        }
        public int getSoLan()
        {
            return soLan;
        }

        public void setTaiKhoan(string taiKhoan)
        {
            this.taiKhoan = taiKhoan;
        }
        public void setMatKhau(string matKhau)
        {
            this.matKhau = matKhau;
        }

    }
}
