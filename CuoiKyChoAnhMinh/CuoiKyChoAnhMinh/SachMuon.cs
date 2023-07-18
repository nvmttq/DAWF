using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKyChoAnhMinh
{
    public class Sachmuon
    {
        public string idS { get; set; }
        public string tenS { get; set; }
        public string tentacgiaS { get; set; }
        public int soluongS { get; set; }
        //public int solangiahan { get; set; }
        public Sachmuon(string id, string tens, string tentg, int soluong)
        {
            this.idS = id;
            this.tenS = tens;
            this.tentacgiaS = tentg;
            this.soluongS = soluong;
            //this.solangiahan = solangh;
        }
        public Sachmuon()
        {

        }
    }
}
