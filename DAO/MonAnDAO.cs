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
            for (int i = 1; i <= listMonAn.Count; i++)
            {
                string query = $"insert into Ban_MonAn values('{i}', '{maBan}', '{listMonAn[i]}')";
                if (DataProvider.Instance.ExecuteNonQuery(query) <= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
