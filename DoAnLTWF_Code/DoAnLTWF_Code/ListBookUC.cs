using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class ListBookUC : UserControl
    {
        public ListBookUC()
        {
            InitializeComponent();
        }
        private string _tieude { get; set; }
        private string _theLoai { get; set; }
        private string _conlai { get; set; }
        private string _idSach { get; set; }
        private Image _banner { get; set; }

        public string Tieude
        {
            get { return _tieude; }
            set { _tieude = value; lbTieuDe.Text = _tieude; }
        }

        public string TheLoai
        {
            get { return _theLoai; }
            set { _theLoai = value; lbTheLoai.Text = "Thể loại: " + _theLoai; }
        }
        public string ConLai
        {
            get { return _conlai; }
            set { _conlai = value; lbSoLuong.Text = "Còn lại: " + _conlai; }
        }

        public string IdSach
        {
            get { return _idSach; }
            set { _idSach = value; lbIdSach.Text = _idSach; }
        }

        public Image Banner
        {
            get { return _banner; }
            set { _banner = value; }
        }


        private void btnXemCT_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Panel pn = btn.Parent as Panel;
            string idSach = "";
            foreach(Control ctrl in pn.Controls)
            {
                if(ctrl.Name == "lbIdSach")
                {
                    idSach = ctrl.Text;
                    
                }
            }
            ChiTietSach ctSach = new ChiTietSach(idSach);
            ctSach.ShowDialog();
        }
    }
}
