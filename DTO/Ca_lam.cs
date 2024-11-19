using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ca_lam
    {
        private int Ca;
        private DateTime Gio_bat_dau;
        private DateTime Gio_ket_thuc;

        public Ca_lam() { }

        public Ca_lam(int ca, DateTime gio_bat_dau, DateTime gio_ket_thuc)
        {
            Ca = ca;
            Gio_bat_dau = gio_bat_dau;
            Gio_ket_thuc = gio_ket_thuc;
        }

        public int getCa()
        {
            return Ca;
        }
        public DateTime getGio_bat_dau()
        {
            return Gio_bat_dau;
        }
        public DateTime getGio_ket_thuc()
        {
            return Gio_ket_thuc;
        }
    }
}
