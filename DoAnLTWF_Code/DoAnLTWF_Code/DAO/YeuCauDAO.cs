using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code.DAO
{
    public class YeuCauDAO
    {
        private static YeuCauDAO instance;

        public static YeuCauDAO Instance
        {
            get
            {
                if (instance == null) instance = new YeuCauDAO();
                return YeuCauDAO.instance;
            }
            set { YeuCauDAO.instance = value; }
        }

        public YeuCauDAO() { }

        public List<YeuCau> listYeuCauChuaXacNhan()
        {
            List<YeuCau> list = new List<YeuCau>();
            string query = $"SELECT * FROM YeuCauSach";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow row in data.Rows)
            {
                YeuCau yc = new YeuCau(row);
                list.Add(yc);
            }

            return list;
        }

        public List<YeuCau> searchListYeuCau(string keyword, string op)
        {
            List<YeuCau> list = new List<YeuCau>();

            string query = $"EXEC USP_SearchYeuCauSach @keyword = N'{keyword}', @op = N'{op}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                YeuCau yc = new YeuCau(row);
                list.Add(yc);
            }

            return list;
        }

        public List<YeuCau> searchListXacNhanYeuCau(string keyword, string op)
        {
            List<YeuCau> list = new List<YeuCau>();

            string query = $"EXEC USP_SearchXacNhanYeuCauSach @keyword = N'{keyword}', @op = N'{op}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                YeuCau yc = new YeuCau(row["idYCXN"].ToString(), row["tenSach"].ToString(), row["tenTacGia"].ToString(), int.Parse(row["soLuong"].ToString()), DateTime.Parse(row["ngayXacNhan"].ToString()));
                list.Add(yc);
            }

            return list;
        }


        public void doneYeuCau(List<YeuCau> list)
        {
            foreach (YeuCau yc in list)
            {
                try
                {
                    string query = $"USP_DoneXacNhanYeuCau @idYC = N'{yc.idYC}', @tenSach = N'{yc.tenSach}', @tenTacGia = N'{yc.tenTacGia}', @soLuong = N'{yc.soLuong}'";
                    int res = DataProvider.Instance.ExcuteNonQuery(query);

                    string deleteAllYC = $"DELETE FROM YeuCauSach WHERE idYC = '{yc.idYC}'";
                    int done = DataProvider.Instance.ExcuteNonQuery(deleteAllYC);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }
    }

}
