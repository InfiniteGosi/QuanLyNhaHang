using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonAnDAO
    {
        private static MonAnDAO instance;

        public static MonAnDAO Instance
        {
            get { if (instance == null) instance = new MonAnDAO(); return instance; }
            private set { instance = value; }
        }
        private MonAnDAO() { }
        public DataTable GetListMonAnByBanID(string maBan)
        {
            string query = "select m.* from MonAn m" +
                           "inner join Ban_MonAn bm" +
                           "on m.maMonAn = bm.maMonAn" +
                           $"where bm.maBan = '{maBan}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetListMonAn()
        {
            string query = "select * from MonAn";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetMonAnById(string maMonAn)
        {
            string query = $"select * from MonAn where maMonAn = '{maMonAn}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool AddMonAnOfBan(string maBan, List<MonAn> listMonAn)
        {
            bool error = false;
            for (int i = 1; i <= listMonAn.Count; i++)
            {
                string query = $"insert into Ban_MonAn values('{i}', '{maBan}', '{listMonAn[i]}')";
                if (DataProvider.Instance.ExecuteNonQuery(query) <= 0)
                {
                    error = true;
                }
            }
            return error;
        }
        public void InsertMonAn( string tenMonAn, int gia)
        {
            string query = $"exec insertMonAn N'{tenMonAn}' , {gia}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void UpdateMonAn(int maMonAn, string tenMonAn, int gia)
        {
            string query = $"exec updateMonAn {maMonAn} , N'{tenMonAn}' , {gia}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DeleteMonAn(int maMonAn)
        {
            string query = $"exec deleteMonAn {maMonAn}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable GetListMonAnTiengViet() 
        {
            string query = "select  maMonAn as N'Mã món ăn' , tenMonAn as N'Tên món ăn' , gia as N'Giá' from MonAn \r\n ";

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
