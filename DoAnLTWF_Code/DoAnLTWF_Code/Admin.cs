using DoAnLTWF_Code.DAO;
using DoAnLTWF_Code.DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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



        private void frmAdmin_Load(object sender, EventArgs e)
        {
            listTheLoai();
            listSach();
            listUser("ALL1");

            loadYeuCauSach();
            loadDanhSachMuonTra();

            cbTKS.SelectedIndex = 0;
            cbSearchUser.SelectedIndex = 0;

            foreach (Control ctr in pnInfoSach.Controls)
            {
               if(ctr.Name != "flpnAcion") ctr.Enabled = false;

            }

            foreach (Control ctr in pnInfo.Controls)
            {
                if(ctr.Name != "pnAction") ctr.Enabled = false;

            }


            // HOME 
            List<Sach> listSachShow = new List<Sach>();
            listSachShow = SachDAO.Instance.listSach();
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


            // TABPAGE THONG KE
            List<string> day = new List<string>(), month = new List<string>(), year = new List<string>();
            for(int i = 1; i <= 31; i++)
            {
                cbTKNgay.Items.Add(i.ToString());
                cbTKNam.Items.Add((2000+i).ToString());
                if(i <= 12)
                {
                    cbTKThang.Items.Add(i.ToString());
                }
                
            }

            
            dtgvTKM.DataSource = ListMuonDAO.Instance.ThongKeSachMuon();
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
                        ctr.Enabled = false;
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

        private void mnuInfo_Click(object sender, EventArgs e)
        {
            InfoUser iu = new InfoUser(user_current);
            iu.ShowDialog();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string ngay = (cbTKNgay.SelectedItem == null ? "" : cbTKNgay.SelectedItem.ToString());
            string thang = (cbTKThang.SelectedItem == null ? "" : cbTKThang.SelectedItem.ToString());
            string nam = (cbTKNam.SelectedItem == null ? "" : cbTKNam.SelectedItem.ToString());
            List<ChiTietSachMuon> list1 = ListMuonDAO.Instance.ThongKeSachMuon(ngay, thang, nam);
            List<ChiTietSachTra> list2 = ListMuonDAO.Instance.ThongKeSachTra(ngay, thang, nam);

            dtgvTKM.DataSource = null;
            dtgvTKM.DataSource = list1;
            dtgvTKT.DataSource = null;
            dtgvTKT.DataSource = list2;
        }



        //thong ke 

        private List<String> header = new List<string>();
        #region method
        private void ExcelFileMuon()
        {
            string filepath = "";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            if (save.ShowDialog() == DialogResult.OK) filepath = save.FileName;


            if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ hoặc trống !!");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Worksheets.Add("DanhSachMuon");

                    ExcelWorksheet ws = p.Workbook.Worksheets[1];
                    header = new List<string>() {
                        "ID Mượn",
                        "ID Sách",
                        "Số Lượng",
                        "Ngày Mượn",
                        "Ngày Hẹn Trả",
                        "Số Lần Gia Hạn"
                    };

                    ws.Name = "Danh Sách Mượn";
                    ws.Cells[1, 1].Value = "Thống kê danh sách mượn";
                    ws.Cells[1, 1, 1, header.Count].Merge = true;
                    ws.Cells[1, 1, 1, header.Count].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, header.Count].Style.Font.Size = 20;
                    ws.Cells[1, 1, 1, header.Count].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;


                    int col_index = 1;
                    int row_index = 2;

                    DataGridView dtgv = dtgvTKM;

                    foreach (string s in header)
                    {
                        var cell = ws.Cells[row_index, col_index];

                        cell.Value = s;
                        col_index++;


                    }


                    List<ChiTietSachMuon> sms = new List<ChiTietSachMuon>();
                    foreach (DataGridViewRow row in dtgv.Rows)
                    {
                        ChiTietSachMuon sm = new ChiTietSachMuon(row);
                        sms.Add(sm);
                    }

                    foreach (ChiTietSachMuon sm in sms)
                    {
                        row_index++;
                        col_index = 1;
                        ws.Cells[row_index, col_index++].Value = sm.idMuon;
                        ws.Cells[row_index, col_index++].Value = sm.idSach;
                        ws.Cells[row_index, col_index++].Value = sm.soLuong;
                        ws.Cells[row_index, col_index++].Value = sm.ngayMuon.ToShortDateString();
                    //    ws.Cells[row_index, col_index++].Value = sm.ngayHenTra.ToShortDateString();
                        ws.Cells[row_index, col_index++].Value = sm.soLanGiaHan;

                    }

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filepath, bin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show($"Lưu file thành công vui lòng kiểm tra đường dẫn\n{filepath}");
        }

        private void ExcelFileTra()
        {
            string filepath = "";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            if (save.ShowDialog() == DialogResult.OK) filepath = save.FileName;


            if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ hoặc trống !!");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Worksheets.Add("DanhSachTra");

                    ExcelWorksheet ws = p.Workbook.Worksheets[1];
                    header = new List<string>() {
                        "ID Trả",
                        "ID Sách",
                        "Số Lượng",
                        "Ngày Trả",
                        "Số Tiền Phạt",
                    };

                    ws.Name = "Danh Sách Trả";
                    ws.Cells[1, 1].Value = "Thống kê danh sách trả";
                    ws.Cells[1, 1, 1, header.Count].Merge = true;
                    ws.Cells[1, 1, 1, header.Count].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, header.Count].Style.Font.Size = 20;
                    ws.Cells[1, 1, 1, header.Count].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;


                    int col_index = 1;
                    int row_index = 2;

                    DataGridView dtgv = dtgvTKT;

                    foreach (string s in header)
                    {
                        var cell = ws.Cells[row_index, col_index];

                        cell.Value = s;
                        col_index++;


                    }


                    List<ChiTietSachTra> sms = new List<ChiTietSachTra>();
                    foreach (DataGridViewRow row in dtgv.Rows)
                    {
                        ChiTietSachTra sm = new ChiTietSachTra(row);
                        sms.Add(sm);
                    }

                    foreach (ChiTietSachTra sm in sms)
                    {
                        row_index++;
                        col_index = 1;
                        ws.Cells[row_index, col_index++].Value = sm.idTra;
                        ws.Cells[row_index, col_index++].Value = sm.idSach;
                        ws.Cells[row_index, col_index++].Value = sm.soLuong;
                        ws.Cells[row_index, col_index++].Value = sm.ngayTra.ToShortDateString();
                        ws.Cells[row_index, col_index++].Value = sm.soTienPhat;

                    }

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filepath, bin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MessageBox.Show($"Lưu file thành công vui lòng kiểm tra đường dẫn\n{filepath}");
        }
        #endregion
        #region EVENTS

        private void loadDanhSachMuonTra()
        {
            dtgvTKM.DataSource = ListMuonDAO.Instance.ThongKeSachMuon(null, null, null);
            dtgvTKT.DataSource = ListMuonDAO.Instance.ThongKeSachTra(null, null, null);

        }
        private void btnXuatDST_Click(object sender, EventArgs e)
        {
            //ExportDST exportExcel = new ExportDST();

            //if(exportExcel.ShowDialog() == DialogResult.OK)
            //{
            //    header = exportExcel.headerColumn;
            //}
            ExcelFileTra();
        }
        private void btnXuatDSM_Click(object sender, EventArgs e)
        {
            //ExportDST exportExcel = new ExportDST();

            //if(exportExcel.ShowDialog() == DialogResult.OK)
            //{
            //    header = exportExcel.headerColumn;
            //}
            ExcelFileMuon();
        }
        #endregion

        //dsyeucau
        private int idRowYeuCau = 0;
        private List<YeuCau> listXacNhan = new List<YeuCau>();
        private List<YeuCau> listYC = new List<YeuCau>();
        private YeuCau chooseCurrentYC = null, chooseCurrentXN = null;

        #region method
        // load
        private void loadYeuCauSach()
        {
            listYC = YeuCauDAO.Instance.listYeuCauChuaXacNhan();
            dtgvTLYC.DataSource = listYC;
            dtgvTLYC.Rows[0].Selected = true;
            cbYC.SelectedIndex = 0;
            cbXN.SelectedIndex = 0;

        }
        #endregion
        #region EVENTS

        private void dtgvTLYC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow slRow = dtgvTLYC.Rows[e.RowIndex];
                string idYC = slRow.Cells["idYC"].Value.ToString();
                string tenSach = slRow.Cells["tenSach"].Value.ToString();
                string tenTacGia = slRow.Cells["tenTacGia"].Value.ToString();
                DateTime ngayYC = DateTime.Parse(slRow.Cells["ngayYeucau"].Value.ToString());
                int soLuong = int.Parse(slRow.Cells["soLuong"].Value.ToString());
                chooseCurrentYC = new YeuCau(idYC, tenSach, tenTacGia, soLuong, ngayYC);
            }
        }
        private void dtgvTLXN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow slRow = dtgvTLYC.Rows[e.RowIndex];
                string idYC = slRow.Cells["idYC"].Value.ToString();
                string tenSach = slRow.Cells["tenSach"].Value.ToString();
                string tenTacGia = slRow.Cells["tenTacGia"].Value.ToString();
                DateTime ngayYC = DateTime.Parse(slRow.Cells["ngayYeucau"].Value.ToString());
                int soLuong = int.Parse(slRow.Cells["soLuong"].Value.ToString());
                chooseCurrentXN = new YeuCau(idYC, tenSach, tenTacGia, soLuong, ngayYC);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < listXacNhan.Count; i++)
            {
                if (listXacNhan[i].idYC == chooseCurrentYC.idYC)
                {
                    listYC.Add(listXacNhan[i]);
                    listXacNhan.RemoveAt(i);
                    dtgvTLXN.DataSource = null;
                    dtgvTLXN.DataSource = listXacNhan;
                    dtgvTLYC.DataSource = null;
                    dtgvTLYC.DataSource = listYC;
                    return;
                }

            }

            MessageBox.Show("Không tìm thấy Yêu Cầu cần hủy !!!");

        }

        private void btnTKYC_Click(object sender, EventArgs e)
        {
            List<YeuCau> list = YeuCauDAO.Instance.searchListYeuCau(tbYC.Text, cbYC.SelectedItem.ToString());

            dtgvTLYC.DataSource = null;
            dtgvTLYC.DataSource = list;
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            List<YeuCau> list = YeuCauDAO.Instance.searchListXacNhanYeuCau(tbXN.Text, cbXN.SelectedItem.ToString());

            dtgvTLXN.DataSource = null;
            dtgvTLXN.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Hành đồng này sẽ lưu lại danh xác mà bạn đã xác nhận. Bạn có muốn tiếp tục không ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {
                YeuCauDAO.Instance.doneYeuCau(listXacNhan);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dtgvTLYC.SelectedRows == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần chọn !!");
                return;
            }

            for (int i = 0; i < listYC.Count; i++)
            {
                if (listYC[i].idYC == chooseCurrentYC.idYC)
                {
                    listXacNhan.Add(chooseCurrentYC);
                    listYC.RemoveAt(i);
                    dtgvTLXN.DataSource = null;
                    dtgvTLXN.DataSource = listXacNhan;
                    dtgvTLYC.DataSource = null;
                    dtgvTLYC.DataSource = listYC;


                    return;
                }
            }

            MessageBox.Show("Không tìm thấy Yêu Cầu cần thêm !!!");
        }
        #endregion

        

        //

        

        
    }
}
