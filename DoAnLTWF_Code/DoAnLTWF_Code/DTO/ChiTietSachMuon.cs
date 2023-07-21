﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code.DTO
{
    public class ChiTietSachMuon
    {
        public string idCTM { get; set; }
        public string idMuon { get; set; }
        public string idSach { get; set; }
        public string tenSach { get; set; }
        public int soLuong { get; set; }
        public int daTra { get; set; }
        public DateTime ngayMuon { get; set; }
        public DateTime ngayHenTra { get; set; }
        public int soLanGiaHan { get; set; }

        public ChiTietSachMuon() { }


        public ChiTietSachMuon(string idSach, int soLuong, string tenSach)
        {
            this.idSach = idSach;
            this.soLuong = soLuong;
            //this.ngayMuon = DateTime.Now;
            //this.ngayHenTra = this.ngayMuon;
            //this.ngayHenTra.AddDays(7);
            this.daTra = 0;
            this.soLanGiaHan = 0;
            this.tenSach = tenSach;
        }
        public ChiTietSachMuon(DataRow row)
        {
            this.idCTM = row["idCTM"].ToString();
            this.idMuon = row["idMuonSach"].ToString();
            this.idSach = row["idSach"].ToString();
            this.tenSach = row["tenSach"].ToString();
            this.soLuong = int.Parse(row["soLuong"].ToString());
            this.daTra = int.Parse(row["daTra"].ToString());
            this.soLanGiaHan = int.Parse(row["soLanGiaHan"].ToString());
            this.ngayMuon = DateTime.Parse(row["ngayMuon"].ToString());
            this.ngayHenTra = DateTime.Parse(row["ngayHenTra"].ToString());
        }

        public ChiTietSachMuon(DataGridViewRow row)
        {
            this.idMuon = rowIsNull(row, "idMuon");
            this.idCTM = rowIsNull(row, "idCTM");
            this.idSach = row.Cells["idSach"].Value.ToString();
            this.soLuong = int.Parse(row.Cells["soLuong"].Value.ToString());
            this.daTra = int.Parse(row.Cells["daTra"].Value.ToString());
            this.soLanGiaHan = int.Parse(row.Cells["soLanGiaHan"].Value.ToString());
            this.ngayMuon = DateTime.Parse(row.Cells["ngayMuon"].Value.ToString());
            this.ngayHenTra = DateTime.Parse(row.Cells["ngayHenTra"].Value.ToString());
        //    this.tenSach = rowIsNull(row, "TenSach")
          
        }


        private string rowIsNull(DataGridViewRow row, string nameCell)
        {
            return (row.Cells[nameCell].Value == null ? "" : row.Cells[nameCell].Value.ToString());
        }
    }
}
