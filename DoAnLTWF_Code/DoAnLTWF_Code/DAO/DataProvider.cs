using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DoAnLTWF_Code
{
    
    public class DataProvider
    {
        private string ConStr = @"Data Source=DESKTOP-5TIPTVB;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable Data;
        private SqlDataAdapter Sda;

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            set { DataProvider.instance = value; }
        }

        public DataProvider() { }

        public DataTable ExcuteQuery(string query, string parameter = null)
        {
            Data = new DataTable();
            using (Con = new SqlConnection(ConStr))
            {
                Con.Open();
                
               if(parameter != null)
               {

               }

                Cmd = new SqlCommand(query, Con);
                Sda = new SqlDataAdapter(Cmd);
                Sda.Fill(Data);
                Con.Close();
            }

            return Data;
        }

        public int ExcuteNonQuery(string query, string parameter = null)
        {
            int checked_data = 0;
            using (Con = new SqlConnection(ConStr))
            {
                Con.Open();
                Cmd = new SqlCommand(query, Con);

                checked_data = Cmd.ExecuteNonQuery();
                Con.Close();
            }

            return checked_data;
        }


    }
}
