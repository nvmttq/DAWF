using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DoAnLTWF_Code.DTO
{
    public class Sachtra
    {
        public string idCTT { get; set; }
        public string idTraSach { get; set; }
        public string idSach { get; set; }
        public int soluongS { get; set; }
        public DateTime ngayTra { get; set; }
        public int soTienPhat { get; set; }

        public Sachtra(string idCTT, string idTraSach, string idSach, int soluongS, DateTime ngayTra, int soTienPhat)
        {
            this.idCTT = idCTT;
            this.idTraSach = idTraSach;
            this.idSach = idSach;
            this.soluongS = soluongS;
            this.ngayTra = ngayTra;
            this.soTienPhat = soTienPhat;
        }

        public Sachtra(DataRow row)
        {
            this.idCTT = row["idCTTraSach"].ToString();
            this.idTraSach = row["idTraSach"].ToString();
            this.idSach = row["idSach"].ToString();
            this.soluongS = int.Parse(row["soLuongS"].ToString());
            this.ngayTra = DateTime.Parse(row["ngayTra"].ToString());
            this.soTienPhat = int.Parse(row["idTraSach"].ToString());
        }

        
    }
}
