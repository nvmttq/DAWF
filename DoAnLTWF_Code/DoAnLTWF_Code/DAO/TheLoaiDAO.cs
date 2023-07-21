using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code.DAO
{
    public class TheLoaiDAO
    {

        private static TheLoaiDAO instance;

        public static TheLoaiDAO Instance
        {
            get
            {
                if (instance == null) instance = new TheLoaiDAO();
                return TheLoaiDAO.instance;
            }
            set { TheLoaiDAO.instance = value; }
        }

        public TheLoaiDAO() { }

        public List<TheLoai> listTheLoai()
        {
            List<TheLoai> theLoaiList = new List<TheLoai>();

            string query = "SELECT * FROM TheLoai";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, null);

            foreach(DataRow item in data.Rows)
            {
                TheLoai tl = new TheLoai(item);
                theLoaiList.Add(tl);
            }
            return theLoaiList;
        }


        public List<TheLoai> getTheLoaiCuaSach(string idSach)
        {
            List<TheLoai> listTLSach = new List<TheLoai>();
             
            string query = $"EXEC USP_getTheLoaiFromIdSach @idSach = '{idSach}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, null);
            
            foreach (DataRow item in data.Rows)
            {
                TheLoai tl = new TheLoai(item);
                listTLSach.Add(tl);
            }

            
            return listTLSach;
        }

        public string ListTheLoaiToString(List<TheLoai> listTLSach)
        {
            if(listTLSach == null)
            {
                return " ";
            }
            string tlSach = "";
            foreach (TheLoai item in listTLSach)
            {
                tlSach = tlSach + item.TenTheLoai + ",";
            }
            if(tlSach == "")
            {
                return "Chưa cập nhật";
            }
            tlSach = tlSach.Replace(tlSach[tlSach.Length-1], '.');
            return tlSach;
        } 

        public List<Sach> getListSach_ClickTheLoai(string ten)
        {
            string query = $"USP_ClickTheLoaiShowSach @tenTheLoai = N'{ten}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<Sach> lists = new List<Sach>();
            foreach(DataRow row in data.Rows)
            {
                Sach s = new Sach(row);
                lists.Add(s);
            }

            return lists;
        }

        public void ThemTheLoai(string theloai, string idSach)
        {
            string[] ds = theloai.Split(",");
            foreach (string s in ds)
            {
                try
                {
                    string query = $"INSERT INTO ChiTietTheLoai VALUES (N'{idSach}', N'{s}')";
                    int res = DataProvider.Instance.ExcuteNonQuery(query);
                } catch(Exception ex)
                {
                    MessageBox.Show("Lỗi ! Vui lòng kiểm tra lại thể loại đã nhập");
                }
            }
        }
    }
}
