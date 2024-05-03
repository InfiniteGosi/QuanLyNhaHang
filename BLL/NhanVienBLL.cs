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
        public List<NhanVien> GetAllEmployee()
        {
            DataTable dt = NhanVienDAO.Instance.GetAllEmployee();
            List<NhanVien> list = new List<NhanVien>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maNhanVien = dt.Rows[i]["maNhanVien"].ToString();
                string matKhau = dt.Rows[i]["matKhau"].ToString();
                int phanQuyen = (int)dt.Rows[i]["phanQuyen"];
                string chucVu = dt.Rows[i]["chucVu"].ToString();
                string hoTen = dt.Rows[i]["hoTen"].ToString();
                bool gioiTinh = (bool)dt.Rows[i]["gioiTinh"];
                list.Add(new NhanVien(maNhanVien, matKhau, phanQuyen, chucVu, hoTen, gioiTinh));
            }
            return list;
        }
    }
}
