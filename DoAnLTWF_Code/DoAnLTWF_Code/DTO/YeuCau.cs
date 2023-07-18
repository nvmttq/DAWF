using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DoAnLTWF_Code.DTO
{
    public class YeuCau
    {
        public string idYC { get; set; }
        public string tenSach { get; set; }
        public string tenTacGia { get; set; }
        public int soLuong { get; set; }
        public DateTime ngayYeuCau { get; set; }


        public YeuCau() { }
        public YeuCau(string idYC, string tenSach, string tenTacGia, int soLuong, DateTime ngayYeuCau)
        {
            this.idYC = idYC;
            this.tenSach = tenSach;
            this.tenTacGia = tenTacGia;
            this.soLuong = soLuong;
            this.ngayYeuCau = ngayYeuCau;
        }

        public YeuCau(DataRow row)
        {
            this.idYC = row["idYC"].ToString();
            this.tenSach = row["tenSach"].ToString();
            this.tenTacGia = row["tenTacGia"].ToString();
            this.soLuong = int.Parse(row["soLuong"].ToString());
            this.ngayYeuCau = DateTime.Parse(row["ngayYeuCau"].ToString());

        }
    }
}
