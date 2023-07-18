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
        public int soLanGiaHan { get; set; }

        public DateTime ngayMuon { get; set; }
        public DateTime ngayHenTra { get; set; }

        public Sachmuon(string id, string tens, string tentg, int soluong)
        {
            this.idS = id;
            this.tenS = tens;
            this.tentacgiaS = tentg;
            this.soluongS = soluong;
        }


        public Sachmuon(string id, string tens, string tentg, int soluong, string idAcc)
        {
            this.idS = id;
            this.tenS = tens;
            this.tentacgiaS = tentg;
            this.soluongS = soluong;
            this.idThe = idAcc;
            this.ngayMuon = DateTime.Now;
            this.ngayHenTra = this.ngayMuon;
            this.ngayMuon.AddDays(7);
        }

        public Sachmuon(DataRow row)
        {
            this.idS = row["idSach"].ToString();
            this.tenS = row["tenSach"].ToString();
            this.tentacgiaS = row["tenTacGia"].ToString();
            this.soluongS = int.Parse(row["soLuong"].ToString());
            this.idThe = row["idThe"].ToString();
            this.ngayMuon = DateTime.Parse(row["ngayMuon"].ToString());
            this.ngayHenTra = DateTime.Parse(row["ngayHenTra"].ToString());
        }
    }
}
