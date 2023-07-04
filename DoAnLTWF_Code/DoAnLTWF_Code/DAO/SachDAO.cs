using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code.DAO
{
    public class SachDAO
    {

        private static SachDAO instance;

        public static SachDAO Instance
        {
            get
            {
                if (instance == null) instance = new SachDAO();
                return SachDAO.instance;
            }
            set { SachDAO.instance = value; }
        }

        public SachDAO() { }

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

        public Sach getSachWithId(string id)
        {
            Sach sach = null;

            string query = $"EXEC USP_getSachWithId @idSach = {id}";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, null);

            foreach (DataRow item in data.Rows)
            {
                sach = new Sach(item);
            }
            return sach;
        }
   
        public List<Sach> timKiemSach(string keywords, string op)
        {

            string query = $"EXEC searchBookWithOption @keyWord = N'{keywords}' , @op = N'{op}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, null);

            List<Sach> listSach = new List<Sach>();

            foreach(DataRow item in data.Rows)
            {
                Sach sach = new Sach(item);
                listSach.Add(sach);
            }

            return listSach;
        }

        public void xoaSach(string id)
        {

            string query = $"DELETE FROM SACH WHERE idSach = N'{id}'";

            int row = DataProvider.Instance.ExcuteNonQuery(query);

            return;
        }

        public void suaSach(Sach s)
        {

            string query = $"UPDATE Sach SET tenSach = N'{s.TenSach}', tenTacGia = N'{s.TenTacGia}', nhaXuatBan = N'{s.NhaXuatBan}', namXuatBan = N'{s.NamXuatBan}', soTrang = N'{s.SoTrang}', soLuong = N'{s.SoLuong}', danhGia = N'{s.DanhGia}' WHERE idSach = N'{s.IdSach}'";

            int row = DataProvider.Instance.ExcuteNonQuery(query);

            return;
        }


        public string createIdBook(string name)
        {
            string id = "";

            foreach(string item in name.Split(" "))
            {
                char tmp = item[0];
                id += tmp;

            }

            return id.ToUpper();
        }

        public void addBookWithExcel(Sach s)
        {
            string q_checkExistId = $"USP_checkExistsBook @idSach = N'{s.IdSach}', @tenSach = N'{s.TenSach}'";

            DataTable check = DataProvider.Instance.ExcuteQuery(q_checkExistId);

            string op = "YES";
            if (check.Rows.Count > 0)
            {
                DialogResult res = MessageBox.Show($"{s.TenSach} đã có trong CSDL \n  * Để thêm dòng mới cho sách này chọn 'YES' \n  * Để chỉnh sửa sách N'{s.TenSach}' thành các dữ liệu tương ứng trong File Excel chọn 'NO' \n  * Chọn Cancel để hủy và không thêm sách N'{s.TenSach} vào CSDL !!!", "XÁC NHẬN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                
                if (res == DialogResult.Cancel) op = "CANCEL";
                else if (res == DialogResult.No) op = "NO";
                
            }

            string query = $"USP_InsertBook @idSach = N'{s.IdSach}', @tenSach = N'{s.TenSach}', @tenTacGia = N'{s.TenTacGia}', @nhaXuatBan = N'{s.NhaXuatBan}', @namXuatBan = N'{s.NamXuatBan}', @soTrang = N'{s.SoTrang}', @soLuong = N'{s.SoLuong}', @op = N'{op}'";

            int dt = DataProvider.Instance.ExcuteNonQuery(query);
        }


        public string getIdBookPlaceholder(string old, string id)
        {
            string query = $"EXEC USP_getIdSachPlaceHolder @idSach ='{id}'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            
            if(dt.Rows.Count > 0)
            {
                Sach s = new Sach(dt.Rows[0]);
                return s.IdSach;
            }

            return old;
        }
    }
}
