using System;
using System.Collections.Generic;
using System.Data;
using OfficeOpenXml;
using System.Text;
using DoAnLTWF_Code.DAO;

namespace DoAnLTWF_Code.DTO
{
    public class Sach
    {
        private string _idSach, _tenSach, _tenTacGia, _nhaXuatBan, _danhGia;
        private int _namXuatBan, _soTrang, _soLuong;
        private DateTime _createdAt, _modifiedAt;



        public Sach(string id, string tenSach, string tenTacGia, string nhaXuatBan, int namXB, int soTrang, int soLuong, DateTime createdAt, DateTime modifiedAt, string danhGia)
        {
            this.IdSach = id;
            this.TenSach = tenSach;
            this.TenTacGia = tenTacGia;
            this.NhaXuatBan = nhaXuatBan;
            this.NamXuatBan = namXB;
            this.SoTrang = soTrang;
            this.SoLuong = soLuong;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.DanhGia = danhGia;
        }

        //edit
        public Sach(string id, string tenSach, string tenTacGia, string nhaXuatBan, int namXB, int soTrang, int soLuong, DateTime modifiedAt)
        {
            this.IdSach = id;
            this.TenSach = tenSach;
            this.TenTacGia = tenTacGia;
            this.NhaXuatBan = nhaXuatBan;
            this.NamXuatBan = namXB;
            this.SoTrang = soTrang;
            this.SoLuong = soLuong;
            this.ModifiedAt = modifiedAt;
        }

        public Sach(string id, string tenSach, string tenTacGia, string nhaXuatBan, int namXB, int soTrang, int soLuong)
        {
            this.IdSach = id;
            this.TenSach = tenSach;
            this.TenTacGia = tenTacGia;
            this.NhaXuatBan = nhaXuatBan;
            this.NamXuatBan = namXB;
            this.SoTrang = soTrang;
            this.SoLuong = soLuong;
        }
        public Sach(DataRow row)
        {
            this.IdSach = row["idSach"].ToString();
            this.TenSach = row["tenSach"].ToString();
            this.TenTacGia = row["tenTacGia"].ToString();
            this.NhaXuatBan = row["nhaXuatBan"].ToString();
            this.NamXuatBan = Convert.ToInt32(row["namXuatBan"]);
            this.SoTrang = Convert.ToInt32(row["soTrang"]);
            this.SoLuong = Convert.ToInt32(row["soLuong"]);
            this.DanhGia = row["danhGia"].ToString();
            this.CreatedAt = Convert.ToDateTime(row["createdAt"]);
            this.ModifiedAt = Convert.ToDateTime(row["modifiedAt"]);
        }

        public Sach(ExcelWorksheet ws, int i, int j)
        {
            this.IdSach = SachDAO.Instance.createIdBook(ws.Cells[i, j].Value.ToString());
            this.TenSach = ws.Cells[i, j++].Value.ToString();
            this.TenTacGia = ws.Cells[i, j++].Value.ToString();
            this.NhaXuatBan = ws.Cells[i, j++].Value.ToString();
            this.NamXuatBan = int.Parse(ws.Cells[i, j++].Value.ToString());
            this.SoTrang = int.Parse(ws.Cells[i, j++].Value.ToString());
            this.SoLuong = int.Parse(ws.Cells[i, j++].Value.ToString());
            
        }
        #region get,set
        public string IdSach { get => _idSach; set => _idSach = value; }

        public string TenSach { get => _tenSach; set => _tenSach = value; }

        public string TenTacGia { get => _tenTacGia; set => _tenTacGia = value; }

        public string NhaXuatBan { get => _nhaXuatBan; set => _nhaXuatBan = value; }

        public int SoTrang { get => _soTrang; set => _soTrang = value; }

        public int SoLuong { get => _soLuong; set => _soLuong = value; }

        public int NamXuatBan { get => _namXuatBan; set => _namXuatBan = value; }

        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
        public DateTime ModifiedAt { get => _modifiedAt; set => _modifiedAt = value; }
        public string DanhGia { get => _danhGia; set => _danhGia = value; }
        #endregion
    }
}
