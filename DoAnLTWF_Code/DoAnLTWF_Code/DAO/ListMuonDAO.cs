using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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
            string query = $"EXEC USP_getListMuonSach @idThe = '{idThe}', @idMuonSach = '{idDs}'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<Sachmuon> list = new List<Sachmuon>();
            foreach(DataRow row in data.Rows)
            {
                Sachmuon sm = new Sachmuon(row);
                list.Add(sm);

            }

            return list;
        }

    }
}
