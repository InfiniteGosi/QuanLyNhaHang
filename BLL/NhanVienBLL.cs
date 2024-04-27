using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        private static NhanVienBLL instance;

        public static NhanVienBLL Instance
        {
            get { if (instance == null) instance = new NhanVienBLL(); return instance; }
            private set { instance = value; }
        }
        private NhanVienBLL() { }
        public bool CheckAccountExistence(string maNhanVien)
        {
            return NhanVienDAO.Instance.CheckAccountExistence(maNhanVien);
        }
        public bool CheckAccountPasword(string maNhanVien, string matKhau)
        {
            return NhanVienDAO.Instance.CheckAccountPasword(maNhanVien, matKhau);
        }
        public NhanVien GetAccount(string maNhanVien)
        {
            DataTable dt = NhanVienDAO.Instance.GetAccount(maNhanVien);
            string matKhau = dt.Rows[0]["matKhau"].ToString();
            int phanQuyen = (int)dt.Rows[0]["phanQuyen"];
            string chucVu = dt.Rows[0]["chucVu"].ToString();
            string hoTen = dt.Rows[0]["hoTen"].ToString();
            bool gioiTinh = (bool)dt.Rows[0]["gioiTinh"];
            return new NhanVien(maNhanVien, matKhau, phanQuyen, chucVu, hoTen, gioiTinh);
        }
    }
}
