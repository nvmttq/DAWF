using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DoAnLTWF_Code.DAO
{
    public class AccountDAO
    {

        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            set { AccountDAO.instance = value; }
        }

        public AccountDAO() { }



        public Account getAccountWithId(string id)
        {
            Account acc = null;

            string query = $"SELECT * FROM Account WHERE idThanhVien = '{id}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, null);

            foreach (DataRow item in data.Rows)
            {
                acc = new Account(item);
            }

            return acc;
        }

        public Account getAccountWithIdThe(string id)
        {
            Account acc = null;

            string query = $"SELECT * FROM TheThuVien WHERE idThe = '{id}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, null);

            foreach (DataRow item in data.Rows)
            {
                acc = new Account(item);
            }

            return acc;
        }

        public void suaAcc(Account u)
        {
            string query = $"UPDATE TheThuVien SET NgayDangKy ='{Convert.ToDateTime(u.NgayDangKy)}', NgayHetHan = '{Convert.ToDateTime(u.NgayHetHan)}' WHERE idThanhVien = '{u.IdThanhVien}'";

            int dt = DataProvider.Instance.ExcuteNonQuery(query);
        }

        
        public User login(string user, string pass)
        {
            string query = $"USP_userLogin @username = N'{user}', @pass = N'{pass}'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            if(dt.Rows.Count > 0)
            {
                return new User(dt.Rows[0]);
            }

            return null;
        }


        public User resigter(User u)
        {
            return u;
        }

        public bool AccountExists(string tk)
        {
            if (tk == "") return false;
            string query = $"SELECT * FROM TheThuVien WHERE idThe = '{tk}'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);

            if (dt.Rows.Count > 0) return false;

            return true;
        }
    }
}
