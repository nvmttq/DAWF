using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DoAnLTWF_Code.DAO
{
    public class UserDAO
    {

        private static UserDAO instance;

        public static UserDAO Instance
        {
            get
            {
                if (instance == null) instance = new UserDAO();
                return UserDAO.instance;
            }
            set { UserDAO.instance = value; }
        }

        public UserDAO() { }

        public List<User> listUser(string modRole)
        {
            List<User> listUser = new List<User>();

            string query = $"EXEC USP_ListUserWithMod @ModRole = {modRole}";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, null);

            foreach(DataRow item in data.Rows)
            {
                User tl = new User(item);
                
                listUser.Add(tl);
            }

            
            return listUser;
        }

        public User getUserWithId(string id)
        {
            string query = $"EXEC USP_getUserWithId @idUser = '{id}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            User u = null;
            foreach(DataRow row in data.Rows)
            {
                u = new User(row);
            }

            return u;
        }

        public void suaUser(User u)
        {
            string query = $"UPDATE ThanhVien SET Fname = N'{u.Fname}', Lname = N'{u.Lname}', Birthday = '{u.Birthday}', Email = N'{u.Email}', Phone = '{u.Phone}', Bank ='{u.Bank}' WHERE idThanhVien = '{u.IdThanhVien}'";

            int dt = DataProvider.Instance.ExcuteNonQuery(query);
            
        }

        public void xoaUser(string id)
        {
            string query = $"DELETE FROM ThanhVien WHERE idThanhVien = '{id}'";
            int dt = DataProvider.Instance.ExcuteNonQuery(query);

        }

        public void themUser(string id, string Fname, string Lname, string sdt, string email, DateTime birth, string role, string thoiHan)
        {
            int mode = 0;
            DateTime ndk = DateTime.Now;
            DateTime nhh = ndk.AddDays(int.Parse(thoiHan));
            

            if (role == "Giảng viên")
            {
                mode = 4;
            }
            else if (role == "Sinh viên")
            {
                mode = 3;
            }
            else if (role == "Nhân viên")
            {
                mode = 2;
            }
            else if (role == "Bên ngoài")
            {
                mode = 5;
            }
            else if (role == "Admin")
            {
                mode = 1;
            }

          
            string query = $"INSERT INTO ThanhVien (idThanhvien, Fname, Lname, Birthday, Email, Phone, Mode) VALUES ('{id}', N'{Fname}', N'{Lname}', N'{birth}', '{email}', '{sdt}', N'{mode}')";

            


            string query2 = $"INSERT INTO TheThuVien (idThe, idThanhvien, Password, NgayDangKy, NgayHetHan) VALUES ('{id}', '{id}', '123', N'{ndk}', N'{nhh}')";
            int res = DataProvider.Instance.ExcuteNonQuery(query);
            int res2 = DataProvider.Instance.ExcuteNonQuery(query2);
        }

        public List<User> searchUserOp(string key, string op)
        {
            List<User> lists = new List<User>();

            string query = $"EXEC USP_searchUser @key = N'{key}', @op = N'{op}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                User u = new User(item);
                lists.Add(u);
            }

            return lists;
        }


        public void EditInfo(User u)
        {
            string query = $"UPDATE ThanhVien SET Fname = N'{u.Fname}', Lname = N'{u.Lname}', Phone = N'{u.Phone}', Email = N'{u.Email}', Bank = N'{u.Bank}', Birthday = N'{u.Birthday}' WHERE idThanhVien = N'{u.IdThanhVien}'";
            int res = DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
