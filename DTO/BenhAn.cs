using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhAn : BenhNhan
    {
        private int _soBenhAn;
        private string _lyDoDenKham;
        private string _benhSu;
        private string _tienSuGiaDinh;
        private string _tienSuNoiKhoa;
        private string _tienSuRangHamMat;
        private string _khamNgoaiMat;
        private string _tinhTrangVeSinhRangMieng;
        private string _moMem;
        private string _moNhaChu;
        private string _rang;
        private string _khopCan;
        private string _canLamSang;
        private string _ketQuaCanLamSang;
        private string _chuanDoan;
        private string _keHoachDieuTri;

        public BenhAn(int soBenhAn, string lyDoDenKham, string benhSu, string tienSuGiaDinh, string tienSuNoiKhoa, string tienSuRangHamMat, string khamNgoaiMat, string tinhTrangVeSinhRangMieng, string moMem, string moNhaChu, string rang, string khopCan, string canLamSang, string ketQuaCanLamSang, string chuanDoan, string keHoachDieuTri, string cCCD, string ho, string ten, string gioiTinh, DateTime ngaySinh, string diaChi, string ngheNghiep, string soDienThoai)
        : base(cCCD, ho, ten, gioiTinh, diaChi, ngheNghiep, soDienThoai, ngaySinh)
        {
            SoBenhAn = soBenhAn;
            LyDoDenKham = lyDoDenKham;
            BenhSu = benhSu;
            TienSuGiaDinh = tienSuGiaDinh;
            TienSuNoiKhoa = tienSuNoiKhoa;
            TienSuRangHamMat = tienSuRangHamMat;
            KhamNgoaiMat = khamNgoaiMat;
            TinhTrangVeSinhRangMieng = tinhTrangVeSinhRangMieng;
            MoMem = moMem;
            MoNhaChu = moNhaChu;
            Rang = rang;
            KhopCan = khopCan;
            CanLamSang = canLamSang;
            KetQuaCanLamSang = ketQuaCanLamSang;
            ChuanDoan = chuanDoan;
            KeHoachDieuTri = keHoachDieuTri;
        }

        public int SoBenhAn
        {
            get { return _soBenhAn; }
            set { _soBenhAn = value; }
        }

        public string LyDoDenKham
        {
            get { return _lyDoDenKham; }
            set { _lyDoDenKham = value; }
        }

        public string BenhSu
        {
            get { return _benhSu; }
            set { _benhSu = value; }
        }

        public string TienSuGiaDinh
        {
            get { return _tienSuGiaDinh; }
            set { _tienSuGiaDinh = value; }
        }

        public string TienSuNoiKhoa
        {
            get { return _tienSuNoiKhoa; }
            set { _tienSuNoiKhoa = value; }
        }

        public string TienSuRangHamMat
        {
            get { return _tienSuRangHamMat; }
            set { _tienSuRangHamMat = value; }
        }

        public string KhamNgoaiMat
        {
            get { return _khamNgoaiMat; }
            set { _khamNgoaiMat = value; }
        }

        public string TinhTrangVeSinhRangMieng
        {
            get { return _tinhTrangVeSinhRangMieng; }
            set { _tinhTrangVeSinhRangMieng = value; }
        }

        public string MoMem
        {
            get { return _moMem; }
            set { _moMem = value; }
        }

        public string MoNhaChu
        {
            get { return _moNhaChu; }
            set { _moNhaChu = value; }
        }

        public string Rang
        {
            get { return _rang; }
            set { _rang = value; }
        }

        public string KhopCan
        {
            get { return _khopCan; }
            set { _khopCan = value; }
        }

        public string CanLamSang
        {
            get { return _canLamSang; }
            set { _canLamSang = value; }
        }

        public string KetQuaCanLamSang
        {
            get { return _ketQuaCanLamSang; }
            set { _ketQuaCanLamSang = value; }
        }

        public string ChuanDoan
        {
            get { return _chuanDoan; }
            set { _chuanDoan = value; }
        }

        public string KeHoachDieuTri
        {
            get { return _keHoachDieuTri; }
            set { _keHoachDieuTri = value; }
        }
    }

}
