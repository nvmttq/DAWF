using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code.DTO
{
    public class ChiTietSachTra
    {
        public string idTra { get; set; }
        public string idSach { get; set; }
        public int soLuong { get; set; }
        public DateTime ngayTra { get; set; }
        public double soTienPhat { get; set; }

        public ChiTietSachTra() { }

        public ChiTietSachTra(DataRow row)
        {
            this.idTra = row["idTraSach"].ToString();
            this.idSach = row["idSach"].ToString();
            this.soLuong = int.Parse(row["soLuong"].ToString());
            this.soTienPhat = int.Parse(row["soTienPhat"].ToString());
            this.ngayTra = DateTime.Parse(row["ngayTra"].ToString());
        }

        public ChiTietSachTra(DataGridViewRow row)
        {
            this.idTra = row.Cells["idTra"].Value.ToString();
            this.idSach = row.Cells["idSach"].Value.ToString();
            this.soLuong = int.Parse(row.Cells["soLuong"].Value.ToString());
            this.soTienPhat = int.Parse(row.Cells["soTienPhat"].Value.ToString());
            this.ngayTra = DateTime.Parse(row.Cells["ngayTra"].Value.ToString());
        }
    }
}
