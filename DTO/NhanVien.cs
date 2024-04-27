using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNhanVien {  get; set; }
        public string MatKhau { get; set; }
        public int PhanQuyen { get; set; }
        public string ChucVu { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public NhanVien(string maNhanVien, string matKhau, int phanQuyen, string chucVu, string hoTen, bool gioiTinh)
        {
            MaNhanVien = maNhanVien;
            MatKhau = matKhau;
            PhanQuyen = phanQuyen;
            ChucVu = chucVu;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
        }
    }
}
