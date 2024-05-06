using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonAnBLL
    {
        private static MonAnBLL instance;

        public static MonAnBLL Instance
        {
            get { if (instance == null) instance = new MonAnBLL(); return instance; }
            private set { instance = value; }
        }
        private MonAnBLL() { }
        public List<MonAn> GetListMonAnByBanID(string maBan)
        {
            DataTable dt = MonAnDAO.Instance.GetListMonAnByBanID(maBan);
            if (dt.Rows.Count > 0 )
            {
                List<MonAn> list = new List<MonAn>();
                for (int i = 0; i <  dt.Rows.Count; i++)
                {
                    string maMonAn = dt.Rows[i]["maMonAn"].ToString();
                    string tenMonAn = dt.Rows[i]["tenMonAn"].ToString();
                    int gia = (int)dt.Rows[i]["gia"];
                    list.Add(new MonAn(maMonAn, tenMonAn, gia));
                }
                return list;
            }
            return null;
        }
        public List<MonAn> GetListMonAn()
        {
            DataTable dt = MonAnDAO.Instance.GetListMonAn();
            List<MonAn> list = new List<MonAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maMonAn = dt.Rows[i]["maMonAn"].ToString();
                string tenMonAn = dt.Rows[i]["tenMonAn"].ToString();
                int gia = (int)dt.Rows[i]["gia"];
                list.Add(new MonAn(maMonAn, tenMonAn, gia));
            }
            return list;
        }
        public MonAn GetMonAnById(string maMonAn)
        {
            DataTable dt = MonAnDAO.Instance.GetMonAnById(maMonAn);
            string tenMonAn = dt.Rows[0]["tenMonAn"].ToString();
            int gia = (int)dt.Rows[0]["gia"];
            return new MonAn(maMonAn, tenMonAn, gia);
        }
        public string AddMonAnOfBan(string maBan, List<MonAn> listMonAn)
        {
            if (MonAnDAO.Instance.AddMonAnOfBan(maBan, listMonAn))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public bool DeleteMonAnOfBan(string maBan)
        {
            return MonAnDAO.Instance.DeleteMonAnOfBan(maBan);
        }
    }
}
