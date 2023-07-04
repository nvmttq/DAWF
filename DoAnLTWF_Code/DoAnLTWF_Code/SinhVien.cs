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
            mnuUser.Text = "Hello, " + u.Fname + " " + u.Lname;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            
            List<Sach> listSach= new List<Sach>();
            listSach = SachDAO.Instance.listSach();
            ListBookUC[] lists = new ListBookUC[listSach.Count];
            for (int i = 0; i < listSach.Count; i++)
            {

                // add data here
                List<TheLoai> listTlSach = TheLoaiDAO.Instance.getTheLoaiCuaSach(listSach[i].IdSach);
                string tlSach = TheLoaiDAO.Instance.ListTheLoaiToString(listTlSach);

                lists[i] = new ListBookUC();
                lists[i].Tieude = listSach[i].TenSach.ToString();
                lists[i].TheLoai = tlSach;
                lists[i].ConLai = listSach[i].SoLuong.ToString();
                lists[i].IdSach = listSach[i].IdSach;
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
    }
}
