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

        public List<Sach> listSach()
        {
            List<Sach> listSach = new List<Sach>();

            string query = "SELECT * FROM Sach";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, null);

            foreach(DataRow item in data.Rows)
            {
                Sach tl = new Sach(item);
                listSach.Add(tl);
            }
            return listSach;
        }

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

        public void suaAcc(Account u)
        {
            string query = $"UPDATE TheThuVien SET NgayDangKy ='{Convert.ToDateTime(u.NgayDangKy)}', NgayHetHan = '{Convert.ToDateTime(u.NgayHetHan)}' WHERE idThanhVien = '{u.IdThanhVien}'";

            int dt = DataProvider.Instance.ExcuteNonQuery(query);
        }

        public void xoaSach(string id)
        {

            string query = $"DELETE FROM SACH WHERE idSach = '{id}'";

            int row = DataProvider.Instance.ExcuteNonQuery(query);

            return;
        }

        public void suaSach(Sach s)
        {

            string query = $"UPDATE Sach SET tenSach = '{s.TenSach}', tenTacGia = '{s.TenTacGia}', nhaXuatBan = '{s.NhaXuatBan}', namXuatBan = '{s.NamXuatBan}', soTrang = '{s.SoTrang}', soLuong = '{s.SoLuong}', danhGia = '{s.DanhGia}' WHERE idSach = '{s.IdSach}'";

            int row = DataProvider.Instance.ExcuteNonQuery(query);

            return;
        }
    }
}
