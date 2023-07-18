using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKyChoAnhMinh
{
    public class ThanhVien
    {
        public string idTv { get; set; }
        public string Hotentv { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Bank { get; set; }
        public ThanhVien(string id,string hoten,DateTime ngaysinh,string email,string phone,string bank)
        {
            this.idTv = id;
            this.Hotentv = hoten;
            this.NgaySinh = ngaysinh;
            this.Email = email;
            this.Phone = phone;
            this.Bank = bank;
        }
    }
}
