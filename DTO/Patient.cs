using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Patient
    {
        private string STT { get; set; }
        private DateTime Ngay { get; set; }
        private int Ca { get; set; }
        private string MaBN { get; set; }
        private string MaLT { get; set; }
        private string MaBS { get; set; }
        private string TrangThai { get; set; }
        private string GhiChu { get; set; }

        public Patient() { }

        public string GetSTT() { return STT; }
        public DateTime GetNgay() { return Ngay; }
        public int GetCa() { return Ca; }
        public string GetMaBN() { return MaBN; }
        public string GetMaLT() { return MaLT; }
        public string GetMaBS() { return MaBS; }
        public string GetTrangThai() { return TrangThai; }
        public string GetGhiChu() { return GhiChu; }

        public void SetSTT(string stt) { STT = stt; }
        public void SetNgay(DateTime ngay) { Ngay = ngay; }
        public void SetCa(int ca) { Ca = ca; }
        public void SetMaBN(string maBN) { MaBN = maBN; }
        public void SetMaLT(string maLT) { MaLT = maLT; }
        public void SetMaBS(string maBS) { MaBS = maBS; }
        public void SetTrangThai(string trangThai) { TrangThai = trangThai; }
        public void SetGhiChu(string ghiChu) { GhiChu = ghiChu; }
    }
}
