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
    public partial class ThemSach : Form
    {
        public ThemSach()
        {
            InitializeComponent();
        }

        private void lbNote_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Bạn có chắc muốn thêm sách mới ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No) return;

                foreach(Control ctr in pnInfoSach.Controls)
                {
                    if (ctr is TextBox && ctr.Text == "") throw new Exception("Không được để trống bất kỳ trường dữ liệu nào !\nVui lòng xem lại !");
                }
                foreach(char c in txtTL.Text)
                {
                    if (!char.IsDigit(c) && c != ',') throw new Exception("Sai định dạng !\n Chỉ được chứa số và mỗi thể loại cách nhau một dấu phẩy (,) ");
                }

                string idSach = SachDAO.Instance.createIdBook(txtTieuDe.Text);
                Sach check = SachDAO.Instance.getSachWithId(idSach);

                if(check != null) throw new Exception("Sách đã tồn tại trên hệ thống!!!");
                TheLoaiDAO.Instance.ThemTheLoai(txtTL.Text, idSach);
                Sach s = new Sach(idSach, txtTieuDe.Text, txtTacGia.Text, txtNhaXB.Text, int.Parse(txtNamXB.Text), int.Parse(txtSoTrang.Text), int.Parse(txtSoLuong.Text));
                SachDAO.Instance.ThemSach(s);
                MessageBox.Show("Thêm sách thành công");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemSach_Load(object sender, EventArgs e)
        {
            dtgvTheLoai.DataSource = TheLoaiDAO.Instance.listTheLoai();
        }
    }
}
