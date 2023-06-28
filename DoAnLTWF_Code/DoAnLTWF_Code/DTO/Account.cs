using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DoAnLTWF_Code.DTO
{
    public class Account
    {
        private string _idThe, _idThanhVien, _password;
        private DateTime _ngayDangKy, _ngayHetHan;



        public Account(string idThe, string idThanhVien, string password, DateTime ngayDangKy, DateTime ngayHetHan)
        {
            this.IdThe = idThe;
            this.IdThanhVien = idThanhVien;
            this.Password = password;
            if (ngayDangKy == null)
            {
                this.NgayDangKy = DateTime.MinValue; // or any other default value you prefer
            }
            else
            {
                this.NgayDangKy = Convert.ToDateTime(ngayDangKy);
            }
            if (NgayHetHan == null)
            {
                this.NgayHetHan = DateTime.MinValue; // or any other default value you prefer
            }
            else
            {
                this.NgayHetHan = Convert.ToDateTime(ngayDangKy);
            }
            this.NgayHetHan = ngayHetHan;
        }

        public Account(string idThe, string idThanhVien, DateTime ngayDangKy, DateTime ngayHetHan)
        {
            this.IdThe = idThe;
            this.IdThanhVien = idThanhVien;
            if (ngayDangKy == null)
            {
                this.NgayDangKy = DateTime.MinValue; // or any other default value you prefer
            }
            else
            {
                this.NgayDangKy = Convert.ToDateTime(ngayDangKy);
            }
            if (NgayHetHan == null)
            {
                this.NgayHetHan = DateTime.MinValue; // or any other default value you prefer
            }
            else
            {
                this.NgayHetHan = Convert.ToDateTime(ngayDangKy);
            }
            this.NgayHetHan = ngayHetHan;
        }

        public Account(DataRow row)
        {
            this.IdThe = row["idThe"].ToString();
            this.IdThanhVien = row["idThanhVien"].ToString();
            this.Password = row["Password"].ToString();
            this.NgayDangKy = Convert.ToDateTime(row["NgayDangKy"]);
            this.NgayHetHan = Convert.ToDateTime(row["NgayHetHan"]);
        }


        #region get,set
        public string IdThe { get => _idThe; set => _idThe = value; }
        public string IdThanhVien { get => _idThanhVien; set => _idThanhVien = value; }
        public string Password { get => _password; set => _password = value; }
        public DateTime NgayDangKy { get => _ngayDangKy; set => _ngayDangKy = value; }
        public DateTime NgayHetHan { get => _ngayHetHan; set => _ngayHetHan = value; }
        #endregion
    }
}
