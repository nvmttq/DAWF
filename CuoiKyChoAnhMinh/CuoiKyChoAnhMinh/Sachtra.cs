using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKyChoAnhMinh
{
    class Sachtra
    {
        public int id { get; set; }
        public string idsach { get; set; }
        public string tensach { get; set; }
        public int solangiahan { get; set; }
        public int soluong { get; set; }
        public Sachtra(int id,string ids,string ten,int giahan,int sl)
        {
            this.id = id;
            this.idsach = ids;
            this.tensach = ten;
            this.solangiahan = giahan;
            this.soluong = sl;
        }
    }
}
