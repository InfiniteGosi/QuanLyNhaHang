using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn
    {
        public string MaMonAn {  get; set; }
        public string TenMonAn { get; set; }
        public int Gia {  get; set; }
        public MonAn(string maMonAn, string tenMonAn, int gia)
        {
            MaMonAn = maMonAn;
            TenMonAn = tenMonAn;
            Gia = gia;
        }
        public override string ToString()
        {
            return $"{MaMonAn} - {TenMonAn}";
        }
    }
}
