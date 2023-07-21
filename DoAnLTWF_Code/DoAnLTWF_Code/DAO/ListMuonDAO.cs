using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code.DAO
{
    public class ListMuonDAO
    {

        private static ListMuonDAO instance;

        public static ListMuonDAO Instance
        {
            get
            {
                if (instance == null) instance = new ListMuonDAO();
                return ListMuonDAO.instance;
            }
            set { ListMuonDAO.instance = value; }
        }

        public ListMuonDAO() { }


        public List<Sachmuon> getListMuonSach(string idDs = null, string idThe = null)
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

        public List<Sachmuon> getListMuonSachIdThe(string idThe = null)
        {
            string query = $"EXEC USP_getListMuonSach @idThe = '{idThe}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Sachmuon> list = new List<Sachmuon>();
            foreach (DataRow row in data.Rows)
            {
                Sachmuon sm = new Sachmuon(row);
                list.Add(sm);

            }

            return list;
        }

        public int countSachMuon(List<ChiTietSachMuon> list)
        {

       
            int tot = 0;
            foreach(ChiTietSachMuon sm in list)
            {
                if(sm.idCTM != null) tot += int.Parse(sm.soLuong.ToString());
            }

            return tot;
        }

        public List<ChiTietSachMuon> ThongKeSachMuon(string day = null, string month = null, string year = null)
        {

            string query = $"EXEC USP_getListMuonTra @day = '{day}', @month = '{month}', @year = '{year}', @op = 'MUONSACH'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<ChiTietSachMuon> list = new List<ChiTietSachMuon>();
            foreach(DataRow row in data.Rows)
            {
                ChiTietSachMuon sm = new ChiTietSachMuon(row);
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

        public List<ChiTietSachMuon> SachMuonCuaUser(string idThe)
        {
            string query = $"EXEC USP_SoSachMuonCuaUser @idThe = '{idThe}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            List<ChiTietSachMuon> ctsm = new List<ChiTietSachMuon>();
            foreach(DataRow row in data.Rows)
            {
                ChiTietSachMuon ct = new ChiTietSachMuon(row);
                ctsm.Add(ct);
            }

            return ctsm;
        }

        public void GiaHanMuon(string idCTM)
        {
            string query = $"UPDATE ChiTietMuonSach SET ngayHenTra = DATEADD(day, 7, ngayHenTra) WHERE idCTM = '{idCTM}'";

            
            try
            {
                int res = DataProvider.Instance.ExcuteNonQuery(query);
                if (res <= 0) throw new Exception("Gia hạn không thành công , vui lòng kiểm tra lại");
                MessageBox.Show("Gia hạn thành công");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addDanhSachMuon(string idThe, int soLuong)
        {
            string qr = $"insert into Danhsachmuon values('{idThe}', '{soLuong}', '0')";
            try
            {
                int res = DataProvider.Instance.ExcuteNonQuery(qr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     
    }
}
