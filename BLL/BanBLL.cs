using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class BanBLL
    {
        private static BanBLL instance;

        public static BanBLL Instance
        {
            get { if (instance == null) instance = new BanBLL(); return instance; }
            private set { instance = value; }
        }
        private BanBLL() { }
        public List<Ban> GetEmptyTables()
        {
            DataTable dt = BanDAO.Instance.GetEmptyTables();
            List<Ban> list = new List<Ban>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maBan = dt.Rows[i]["maBan"].ToString();
                string hoTenKhach = dt.Rows[i]["hoTenKhach"].ToString();
                string soDienThoaiKhach = dt.Rows[i]["soDienThoaiKhach"].ToString();
                DateTime? ngayDatBan = dt.Rows[i]["ngayDatBan"] != DBNull.Value
                ? (DateTime)dt.Rows[i]["ngayDatBan"]
                : (DateTime?)null;
                DateTime? ngayNhanBan = dt.Rows[i]["ngayNhanBan"] != DBNull.Value
                ? (DateTime)dt.Rows[i]["ngayNhanBan"]
                : (DateTime?)null;
                list.Add(new Ban(maBan, hoTenKhach, soDienThoaiKhach, ngayDatBan, ngayNhanBan, false));
            }
            return list;
        }
        public List<Ban> GetOccupiedTables()
        {
            DataTable dt = BanDAO.Instance.GetOccupiedTables();
            List<Ban> list = new List<Ban>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maBan = dt.Rows[i]["maBan"].ToString();
                string hoTenKhach = dt.Rows[i]["hoTenKhach"].ToString();
                string soDienThoaiKhach = dt.Rows[i]["soDienThoaiKhach"].ToString();
                DateTime? ngayDatBan = dt.Rows[i]["ngayDatBan"] != DBNull.Value
                ? (DateTime)dt.Rows[i]["ngayDatBan"]
                : (DateTime?)null;
                DateTime? ngayNhanBan = dt.Rows[i]["ngayNhanBan"] != DBNull.Value
                ? (DateTime)dt.Rows[i]["ngayNhanBan"]
                : (DateTime?)null;
                list.Add(new Ban(maBan, hoTenKhach, soDienThoaiKhach, ngayDatBan, ngayNhanBan, true));
            }
            return list;
        }
        public string AddTables(Dictionary<string, object> parameters)
        {
            if (BanDAO.Instance.AddTable(parameters))
            {
                return "Đặt bàn thành công";
            }
            return "Đặt bàn thất bại";
        }
    }
}
