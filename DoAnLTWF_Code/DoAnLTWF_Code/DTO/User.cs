using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DoAnLTWF_Code.DTO
{
    public class User
    {
        private string _idThanhVien, _fname, _lname, _email, _phone, _bank, _mode, _modeRole;
        private DateTime _birthday;

        private string _idThe, _password;
        private DateTime _ngayDangKy, _ngayHetHan;

        public User(string idThanhVien, string fname, string lname, DateTime birthday, string email, string phone, string bank, string mod)
        {
            this.IdThanhVien = idThanhVien;
            this.Fname = fname;
            this.Lname = lname;
            this.Birthday = birthday;
            this.Email = email;
            this.Phone = phone;
            this.Bank = bank;
            this.Mode = mod;
            
        }

        public User(DataRow row)
        {
            this.IdThanhVien = getTextIsNull(row, "idThanhVien");
            this.Fname = getTextIsNull(row, "Fname");
            this.Lname = getTextIsNull(row, "Lname");

            if (row.IsNull("Birthday"))
            {
                this.Birthday = DateTime.MinValue; // or any other default value you prefer
            }
            else
            {
                this.Birthday = Convert.ToDateTime(row["Birthday"]);
            }

            this.Email = getTextIsNull(row, "Email");
            this.Phone = getTextIsNull(row, "Phone");
            this.Bank = getTextIsNull(row, "Bank");
            this.Mode = getTextIsNull(row, "Mode");
            this.ModeRole = getTextIsNull(row, "Role");

            this.IdThe = row["idThe"].ToString();
            this.Password = row["Password"].ToString();
            this.NgayDangKy = Convert.ToDateTime(row["NgayDangKy"]);
            this.NgayHetHan = Convert.ToDateTime(row["NgayHetHan"]);
        }

        public string getTextIsNull(DataRow row, string columnName)
        {
            return row.IsNull(columnName) ? string.Empty : row[columnName].ToString();
        }

   
        #region get,set
        public string IdThanhVien { get => _idThanhVien; set => _idThanhVien = value; }
        public string Fname { get => _fname; set => _fname = value; }
        public string Lname { get => _lname; set => _lname = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Bank { get => _bank; set => _bank = value; }
        public string Mode { get => _mode; set => _mode = value; }
        public string ModeRole { get => _modeRole; set => _modeRole = value; }
        public string IdThe { get => _idThe; set => _idThe = value; }
        public string Password { get => _password; set => _password = value; }
        public DateTime NgayDangKy { get => _ngayDangKy; set => _ngayDangKy = value; }
        public DateTime NgayHetHan { get => _ngayHetHan; set => _ngayHetHan = value; }
        #endregion

    }
}
