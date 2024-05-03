using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban
    {
        public string MaBan { get; set; }
        public string HoTenKhach { get; set; }
        public string SoDienThoaiKhach { get; set; }
        public DateTime? NgayDatBan { get; set; }
        public DateTime? NgayNhanBan { get; set; }
        public bool DaCoKhachDat { get; set; }
        public Ban(string maBan, string hoTenKhach, string soDienThoaiKhach, DateTime? ngayDatBan, DateTime? ngayNhanBan, bool daCoKhachDat)
        {
            MaBan = maBan;
            HoTenKhach = hoTenKhach;
            SoDienThoaiKhach = soDienThoaiKhach;
            NgayDatBan = ngayDatBan;
            NgayNhanBan = ngayNhanBan;
            DaCoKhachDat = daCoKhachDat;
        }
    }
}
