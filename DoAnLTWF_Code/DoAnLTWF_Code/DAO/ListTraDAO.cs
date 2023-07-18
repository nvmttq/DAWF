using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code.DAO
{
    public class ListTraDAO
    {

        private static ListTraDAO instance;

        public static ListTraDAO Instance
        {
            get
            {
                if (instance == null) instance = new ListTraDAO();
                return ListTraDAO.instance;
            }
            set { ListTraDAO.instance = value; }
        }

        public ListTraDAO() { }


        public List<Sachmuon> getListTraSach(string idDs = null, string idThe = null)
        {
            string query = $"EXEC USP_getListMuonSach @idMuonSach = '{idDs}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Sachmuon> list = new List<Sachmuon>();
            foreach(DataRow row in data.Rows)
            {
                Sachmuon sm = new Sachmuon(row);
                list.Add(sm);

            }

            return list;
        }

    


        public List<ChiTietSachTra> ThongKeSachTra(string day = null, string month = null, string year = null)
        {

            string query = $"EXEC USP_getListMuonTra @day = N'{day}', @month = N'{month}', @year = N'{year}', @op = 'TRASACH'";
            MessageBox.Show(query);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<ChiTietSachTra> list = new List<ChiTietSachTra>();
            foreach (DataRow row in data.Rows)
            {
                ChiTietSachTra sm = new ChiTietSachTra(row);
                list.Add(sm);
            }

            return list;
        }

        public void UserTraSach(string idCTM, int soLuongTra)
        {
            string qr = $"EXEC USP_TraSach @idCTM = '{idCTM}', @soLuongTra = '{soLuongTra}'";
            DataTable res = DataProvider.Instance.ExcuteQuery(qr);
            try
            {
                
                MessageBox.Show("Trả sách thành công !!!");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        
    }
}
