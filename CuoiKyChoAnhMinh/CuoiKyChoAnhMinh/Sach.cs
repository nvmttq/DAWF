using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKyChoAnhMinh
{
    public class Sach
    {
        public string idSach { get; set; }
        public string tenSach { get; set; }
        public string tenTacGia { get; set; }
        public string nhaXuatBan { get; set; }
        public int namXb { get; set; }
        public int soTrang { get; set; }
        public int soLuong { get; set; }
        public Sach(string idsach,string tensach,string tentacgia,string nxb,int namxb,int sotrang,int soluong)
        {
            this.idSach = idsach;
            this.tenSach = tensach;
            this.tenTacGia = tentacgia;
            this.nhaXuatBan = nxb;
            this.namXb = namxb;
            this.soTrang = sotrang;
            this.soLuong = soluong;
        }
    }
}
