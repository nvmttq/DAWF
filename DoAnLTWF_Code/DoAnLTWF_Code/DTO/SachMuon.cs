using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DoAnLTWF_Code.DTO
{
    public class Sachmuon
    {
        public string idS { get; set; }
        public string tenS { get; set; }
        public string tentacgiaS { get; set; }
        public int soluongS { get; set; }
        public string idThe { get; set; }

        public Sachmuon(string id, string tens, string tentg, int soluong)
        {
            this.idS = id;
            this.tenS = tens;
            this.tentacgiaS = tentg;
            this.soluongS = soluong;
        }

        public Sachmuon(DataRow row)
        {
            this.idS = row["idSach"].ToString();
            this.tenS = row["tenSach"].ToString();
            this.tentacgiaS = row["tenTacGia"].ToString();
            this.soluongS = int.Parse(row["soLuong"].ToString());
            this.idThe = row["idThe"].ToString();
        }
    }
}
