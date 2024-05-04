using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance
        {
            get { if (instance == null) instance = new BanDAO(); return instance; }
            private set { instance = value; }
        }
        private BanDAO() { }
        public DataTable GetEmptyTables()
        {
            string query = "select * from Ban where daCoKhachDat = 0";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetOccupiedTables()
        {
            string query = "select * from Ban where daCoKhachDat = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool AddTable(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("SP_DatBan", parameters);
            return result > 0;
        }
    }
}
