using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DoAnLTWF_Code.DTO
{
    public class TheLoai
    {
        private string idTheLoai;
        private string tenTheLoai;


        public TheLoai(string id, string ten)
        {
            this.idTheLoai = id;
            this.tenTheLoai = ten;
        }

        public TheLoai(DataRow row)
        {
            this.idTheLoai = (string)row["idTheLoai"];
            this.tenTheLoai = (string)row["tenTheLoai"];
        }


        

        #region get,set
        public string IdTheLoai { get => idTheLoai; set => idTheLoai = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }
        #endregion
    }
}
