using DoAnLTWF_Code.DAO;
using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class ChiTietSach : Form
    {
        public string _idSach;

        
        public ChiTietSach(string idSach)
        {
            InitializeComponent();
            _idSach = idSach;
        }

        private void ChiTietSach_Load(object sender, EventArgs e)
        {
            pnHinhSach.Width = pcbSach.Width;
            Sach sach = SachDAO.Instance.getSachWithId(_idSach);
            List<TheLoai> listTlSach = TheLoaiDAO.Instance.getTheLoaiCuaSach(_idSach);
            string tlSach = TheLoaiDAO.Instance.ListTheLoaiToString(listTlSach);

            lbTenSach.Text = sach.TenSach;
            lbDanhGia.Text = sach.DanhGia;
            lbNhaXB.Text = sach.NhaXuatBan;
            lbNamXB.Text = sach.NamXuatBan.ToString();
            lbTacGia.Text = sach.TenTacGia;
            lbTenKhac.Text = "ANOTHER NAME";
            lbTheLoai.Text = tlSach;
            lbSoTrang.Text = sach.SoTrang.ToString();
            lbSoLuong.Text = sach.SoLuong.ToString();
            lbTrangThai.Text = "Đang tiến hành";
        }

        private void ChiTietSach_Resize(object sender, EventArgs e)
        {
           
            pnHinhSach.Width = pcbSach.Width;
        }

        private void btnYCS_Click(object sender, EventArgs e)
        {
            YeuCauThemSach ycts = new YeuCauThemSach();
            ycts.Show();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            SVMuonSach svms = new SVMuonSach();
            svms.Show();
        }
    }
}
