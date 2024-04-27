using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
