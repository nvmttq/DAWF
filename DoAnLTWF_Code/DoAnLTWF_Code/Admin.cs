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
    public partial class frmAdmin : Form
    {
        private User user_current = null;
        public frmAdmin(User u)
        {
            InitializeComponent();
            user_current = u;
            mnuUser.Text = u.Fname + " " + u.Lname;
        }
        #region events_MAIN

        private void frmAdmin_Resize(object sender, EventArgs e)
        {
            Panel pn = pnDanhSachMuon;
            pn.Width = (pn.Parent.Width / 2);
            Panel pndst = pnDanhSachTra;
            pndst.Width = (pn.Parent.Width / 2);
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            listTheLoai();
            listSach();
            listUser("ALL1");

            cbTKS.SelectedIndex = 0;
            cbSearchUser.SelectedIndex = 0;

            foreach (Control ctr in pnInfoSach.Controls)
            {
               if(ctr.Name != "flpnAcion") ctr.Enabled = true;

            }

            foreach (Control ctr in pnInfoSach.Controls)
            {
                ctr.Enabled = false;

            }
        }

        private void typeObject_Click(object sender, EventArgs e)
        {
            string text = "Độc giả";
            Control control = sender as Control;
            Panel pn = null;
            if (!(control is Panel)) pn = control.Parent as Panel;
            else pn = control as Panel;
            foreach(Control ctrl in pn.Controls)
            {
                if(ctrl is Label)
                {
                    text = ctrl.Text;
                }
            }
            lbObject.Text = "Thông tin " + text;
            lbDanhSachObject.Text = "Danh sách " + text;

            if (text == "Độc giả")
            {
                listUser("READER");
            }
            else if (text == "Nhân viên")
            {
                listUser("EMPLOYEE"); 
            }
            else
            {
                listUser("ALL1"); 
            }
        }

 

        #endregion




        #region tab_DanhMuc
        #region panelTheLoai
        private void listTheLoai()
        {
            List<TheLoai> listTL = TheLoaiDAO.Instance.listTheLoai();
            dtgvTheLoai.DataSource = listTL;
        }
        #endregion

        #region ds Sach

        #region EVENTS

        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow slRow = dtgvSach.Rows[e.RowIndex];
                slRow.Selected = true;

                txtIdSach.Text = slRow.Cells["IdSach"].Value.ToString();
                txtTieuDe.Text = slRow.Cells["TenSach"].Value.ToString();
                txtTacGia.Text = slRow.Cells["TenTacGia"].Value.ToString();
                txtNhaXB.Text = slRow.Cells["NhaXuatBan"].Value.ToString();
                txtNamXB.Text = slRow.Cells["NamXuatBan"].Value.ToString();
                //  txtTheLoai.Text = slRow.Cells["Email"].Value.ToString();
                txtSoLuong.Text = slRow.Cells["SoLuong"].Value.ToString();
                txtSoTrang.Text = slRow.Cells["SoTrang"].Value.ToString();
                txtDanhGia.Text = "Đánh giá : " + slRow.Cells["DanhGia"].Value.ToString() + " || 146";

                cbTheLoai.DataSource = TheLoaiDAO.Instance.getTheLoaiCuaSach(slRow.Cells["IdSach"].Value.ToString());
                cbTheLoai.DisplayMember = "TenTheLoai";
            }
        }
        private void btnTKS_Click(object sender, EventArgs e)
        {
            string text = txtTKS.Text;
            string op = cbTKS.SelectedItem.ToString();

            List<Sach> listSach = SachDAO.Instance.timKiemSach(text, op);
            dtgvSach.DataSource = listSach;
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Xóa thông tin của sách với id = {txtIdSach.Text} ?", "Xác nhận xóa thông tin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    SachDAO.Instance.xoaSach(txtIdSach.Text);
                    MessageBox.Show($"XÓa sách với id = {txtIdSach.Text} thành công !!!", "Thành công!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvSach.DataSource = SachDAO.Instance.listSach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in pnInfoSach.Controls)
            {
                ctr.Enabled = true;

            }

            txtDanhGia.Enabled = false;
            book_setButtonEndbel((sender as Button).Name, "TRUESENDER");
        }

        private void edit_Book()
        {
            DialogResult res = MessageBox.Show($"Chỉnh sửa thông tin của sách với id = {txtIdSach.Text} ?", "Xác nhận sửa thông tin !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    Sach sach = new Sach(txtIdSach.Text, txtTieuDe.Text, txtTacGia.Text, txtNhaXB.Text, int.Parse(txtNamXB.Text), int.Parse(txtSoTrang.Text), int.Parse(txtSoLuong.Text), DateTime.Now);
                    SachDAO.Instance.suaSach(sach);
                    MessageBox.Show($"Chỉnh sửa thông tin sách với id = {txtIdSach.Text} thành công !!!", "Thành công!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvSach.DataSource = SachDAO.Instance.listSach();

                    book_setButtonEndbel("", "ALLTRUE");
                    foreach (Control ctr in pnInfoSach.Controls)
                    {
                        ctr.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThemHL_Click(object sender, EventArgs e)
        {
            AddMutiBook addMuti = new AddMutiBook();
            addMuti.ShowDialog();
            dtgvSach.DataSource = SachDAO.Instance.listSach();
        }

        private void dtgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow slRow = dtgvTheLoai.Rows[e.RowIndex];
                slRow.Selected = true;

                //    MessageBox.Show(slRow.Cells["TenTheLoai"].Value.ToString());
                List<Sach> lists = TheLoaiDAO.Instance.getListSach_ClickTheLoai(slRow.Cells["TenTheLoai"].Value.ToString());

                dtgvSach.DataSource = lists;
            }
        }

        private void book_setButtonEndbel(string name, string op)
        {
            if (op == "TRUESENDER")
            {
                foreach (Control ctr in flpnAcion.Controls)
                {
                    if (ctr.Name != name && ctr.Name != "btnSaveBook" && ctr.Name != "btnCancelBook")
                    {
                        ctr.Enabled = !ctr.Enabled;
                    }
                }
            }
            else if (op == "ALLTRUE")
            {
                foreach (Control ctr in flpnAcion.Controls)
                {
                    ctr.Enabled = true;
                }
            }
        }


        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            

            if(btnSuaSach.Enabled == true)
            {
                edit_Book();
            }
            

        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            book_setButtonEndbel("", "ALLTRUE");
            foreach (Control ctr in pnInfoSach.Controls)
            {
                ctr.Enabled = false;
            }
        }


        #endregion
        private void listSach()
        {
            List<Sach> listSach = SachDAO.Instance.listSach();
            dtgvSach.DataSource = listSach;
        }

        #endregion

        #endregion




        #region tab_User

        #region EVENTS
        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow slRow = dtgvUser.Rows[e.RowIndex];
                slRow.Selected = true;
                txtIdUser.Text = slRow.Cells["IdThanhVien"].Value.ToString();
                txtFname.Text = slRow.Cells["Fname"].Value.ToString();
                txtLname.Text = slRow.Cells["Lname"].Value.ToString();
                txtEmail.Text = slRow.Cells["Email"].Value.ToString();
                dtpNgaySinh.Text = slRow.Cells["Birthday"].Value.ToString();
                txtPhone.Text = slRow.Cells["Phone"].Value.ToString();
                txtBank.Text = slRow.Cells["Bank"].Value.ToString();
                dtpNgayDK.Value = Convert.ToDateTime(slRow.Cells["NgayDangKy"].Value);
                dtpNgayHH.Value = Convert.ToDateTime(slRow.Cells["NgayDangKy"].Value);
                txtIdThe.Text = slRow.Cells["IdThe"].Value.ToString();
                txtRole.Text = slRow.Cells["Mode"].Value.ToString(); // = moderole

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //allow edit 
            foreach (Control ctr in pnInfo.Controls)
            {
                ctr.Enabled = true;

            }

            pnIdUser.Enabled = false;
            pnIdThe.Enabled = false;
            setButtonEndbel((sender as Button).Name, "TRUESENDER");


        }

        private void editUser()
        {
            string id = txtIdUser.Text;
            DialogResult res = MessageBox.Show($"Chỉnh sửa thông tin của user với id = {id} ?", "Xác nhận chỉnh sửa thông tin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    User u = new User(txtIdUser.Text, txtFname.Text, txtLname.Text, Convert.ToDateTime(dtpNgaySinh.Value), txtEmail.Text, txtPhone.Text, txtBank.Text, txtRole.Text);
                    UserDAO.Instance.suaUser(u);
                    MessageBox.Show($"Chỉnh sửa thông tin user id = {id} thành công !!!", "Thành công!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvUser.DataSource = UserDAO.Instance.listUser("ALL1");

                    setButtonEndbel("", "ALLTRUE");
                    foreach (Control ctr in pnInfo.Controls)
                    {
                        if (ctr.Name != "pnAction") ctr.Enabled = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnXoaUser_Click(object sender, EventArgs e)
        {
            string id = txtIdUser.Text;


            DialogResult res = MessageBox.Show($"Xóa thông tin của người dùng với id = {id} ?", "Xác nhận xóa thông tin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    UserDAO.Instance.xoaUser(id);
                    MessageBox.Show($"Xóa người dùng id = {id} thành công !!!", "Thành công!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvUser.DataSource = UserDAO.Instance.listUser("ALL1");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.Show();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string key = txtKeySearch.Text;
            string op = cbSearchUser.SelectedItem.ToString();

            List<User> list = UserDAO.Instance.searchUserOp(key, op);

            dtgvUser.DataSource = list;
        }

        private void setButtonEndbel(string name, string op)
        {
            if (op == "TRUESENDER")
            {
                foreach (Control ctr in pnAction.Controls)
                {
                    if (ctr.Name != name && ctr.Name != "btnSave" && ctr.Name != "btnCancel")
                    {
                        ctr.Enabled = !ctr.Enabled;
                    }
                }
            }
            else if (op == "ALLTRUE")
            {
                foreach (Control ctr in pnAction.Controls)
                {
                    ctr.Enabled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setButtonEndbel("", "ALLTRUE");

            foreach (Control ctr in pnInfo.Controls)
            {
                if (ctr.Name != "pnAction") ctr.Enabled = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSua.Enabled == true)
            {
                editUser();
            }
            
                
        }

        

        #endregion

        #region METHOD
        private void listUser(string modRole)
            {
                List<User> listUser = UserDAO.Instance.listUser(modRole);
                dtgvUser.DataSource = listUser;
            }
            #endregion

        #endregion


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pnContentThonTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
