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
    public partial class frmSinhVien : Form
    {
        private User user_current = null;
        public frmSinhVien(User u)
        {
            InitializeComponent();
            user_current = u;
            mnuUser.Text = "Hello, " + u.Fname;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {

            LoadListBookUC();
        }

        private void LoadListBookUC(string condition = null, string keyword = null)
        {
            flpnSach.Controls.Clear();
            List<Sach> listSachShow = new List<Sach>();
            listSachShow = SachDAO.Instance.listSachUC(condition, keyword);
            ListBookUC[] lists = new ListBookUC[listSachShow.Count];
            for (int i = 0; i < listSachShow.Count; i++)
            {

                // add data here
                List<TheLoai> listTlSach = TheLoaiDAO.Instance.getTheLoaiCuaSach(listSachShow[i].IdSach);
                string tlSach = TheLoaiDAO.Instance.ListTheLoaiToString(listTlSach);

                lists[i] = new ListBookUC();
                lists[i].Tieude = listSachShow[i].TenSach.ToString();
                lists[i].TheLoai = tlSach;
                lists[i].ConLai = listSachShow[i].SoLuong.ToString();
                lists[i].IdSach = listSachShow[i].IdSach;
                lists[i].Margin = new Padding(30, 5, 20, 15);

                flpnSach.Controls.Add(lists[i]);
            }
        }

        private void frmSinhVien_Resize(object sender, EventArgs e)
        {
            pnTimKiem.Left = (pnTimKiem.Parent.Width - pnTimKiem.Width) / 2;
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoUser iu = new InfoUser(user_current);
            if (iu.ShowDialog() == DialogResult.OK)
            {
                user_current = iu.info;
                mnuUser.Text = "Hello, " + user_current.Fname + " " + user_current.Lname + "  !!!";

            }
        }

        private void btnTKTC_Click(object sender, EventArgs e)
        {
            if (txtSearchTC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa trước khi tìm !!!");
                return;
            }

            LoadListBookUC(cbTKSTC.SelectedItem.ToString(), txtSearchTC.Text);
        }
    }
}
