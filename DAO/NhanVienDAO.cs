using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        private NhanVienDAO() { }
        public bool CheckAccountExistence(string maNhanVien)
        {
            string query = $"select * from NhanVien where MaNhanVien = '{maNhanVien}'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool CheckAccountPasword(string maNhanVien, string matKhau)
        {
            string query = $"select * from NhanVien where MaNhanVien = '{maNhanVien}'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return matKhau.Equals(result.Rows[0]["MatKhau"].ToString());
        }
        public DataTable GetAccount(string maNhanVien)
        {
            string query = $"select * from NhanVien where MaNhanVien = '{maNhanVien}'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable GetAllEmployee()
        {
            string query = "select * from NhanVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateStaff(string maNhanVien,int phanQuyen, string chucVu,string hoTen, int getSext)
        { //sua nhan vien
            DataProvider.Instance.ExecuteNonQuery($"exec updateStaff {maNhanVien} , {phanQuyen} , N'{chucVu}' , N'{hoTen}' , {getSext}");
        }
        public void DeleteStaff(string maNhanVien)
        { //sua nhan vien
            DataProvider.Instance.ExecuteNonQuery($"exec deleteStaff {maNhanVien} ");
        }
        public void AddStaff(string maNhanVien, string matKhau, int phanQuyen, string chucVu, string hoTen, int getSext)
        { //sua nhan vien
            DataProvider.Instance.ExecuteNonQuery($"exec addStaff {maNhanVien} , {matKhau} , {phanQuyen} , N'{chucVu}' , N'{hoTen}' , {getSext}");
        }
        public void ResetPassWord(string maNhanVien)
        {
            DataProvider.Instance.ExecuteNonQuery($" exec resetPassWord  {maNhanVien} ");

        }
        public void ChangePassWord(string maNhanVien, string matKhau)
        { //sua nhan vien
            DataProvider.Instance.ExecuteNonQuery($"exec changePassWord {maNhanVien} , {matKhau} ");
        }
    }
}
