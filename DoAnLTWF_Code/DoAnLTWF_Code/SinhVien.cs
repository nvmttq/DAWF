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
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            ListBookUC[] lists = new ListBookUC[20];
            List<Sach> listSach= new List<Sach>();
            listSach = SachDAO.Instance.listSach();

            for (int i = 0; i < listSach.Count; i++)
            {

                // add data here
                List<TheLoai> listTlSach = TheLoaiDAO.Instance.getTheLoaiCuaSach(lists[i].IdSach);
                string tlSach = TheLoaiDAO.Instance.ListTheLoaiToString(listTlSach);

                lists[i] = new ListBookUC();
                lists[i].Tieude = listSach[i].TenSach;
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
    }
}
