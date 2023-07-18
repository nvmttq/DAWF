using DoAnLTWF_Code.DAO;
using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ZXing;

namespace DoAnLTWF_Code
{
    public partial class frmQuanThu : Form

    {

        public string link = @"Data Source=DESKTOP-5TIPTVB;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        private User user_current = null;
        private string idAccNeed = "";
        private bool check_choose_book = false;
        public frmQuanThu(User u)
        {
            InitializeComponent();
            mnuUser.Text = "Hello, " + u.Fname + " " + u.Lname + "  !!!";
            user_current = u;
        }

        List<Sach> sach = new List<Sach>();
        List<ThanhVien> thanhvien = new List<ThanhVien>();
        List<Sachmuon> muonsach = new List<Sachmuon>();
        int tienphat = 0;
        int idthe;
        int soluongsachtra;
   
    

        private void FMain_Load(object sender, EventArgs e)
        {

            DateTime Ngaymuon = dtpNgaymuon.Value;
            DateTime Ngaytra = Ngaymuon.AddDays(7);

            dtpHantra.Value = Ngaytra;
        }



        private void btnThemS_Click(object sender, EventArgs e)
        {
            try
            {
                string ids = txtMaSach.Text;
                string tens = tbTensach.Text;
                string tentacgia = tbTacgia.Text;
                int sl = Convert.ToInt32(tbSoluong.Text);
                Sachmuon tmp = new Sachmuon(ids, tens, tentacgia, sl);
                muonsach.Add(tmp);
                DanhSachMuon.DataSource = null;
                DanhSachMuon.DataSource = muonsach;
                DanhSachMuon.AutoGenerateColumns = true;
                DanhSachMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch 
            {
                MessageBox.Show("Thêm thiếu dữ liệu");
            }
        }

        private void btnSuaS_Click(object sender, EventArgs e)
        {
            

            tbSoluong.Enabled = true;
            button2.Enabled = false;
            btnSave.Enabled = false;
            btnReset.Enabled = false;
            btnXoaS.Enabled = false;
            btnPrint.Enabled = false;
        }


   

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            Sachmuon sua = muonsach.FirstOrDefault(s => s.idS == txtMaSach.Text);
            //sua.soluongS = Convert.ToInt32(tbSoluong.Text);
            muonsach.Remove(sua);

            DanhSachMuon.DataSource = null;
            DanhSachMuon.DataSource = muonsach;
        }
        private void saveDanhsachmuon()
        {
            SqlConnection sql = new SqlConnection(link);
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string qrthe = "select idThe from TheThuVien where idThe ='" + tbIdThe.Text + "'";
            SqlCommand cmd1 = new SqlCommand(qrthe);
            cmd1.Connection = sql;
            string idthe;
            try
            {
                SqlDataReader read = cmd1.ExecuteReader();
                if (read.Read())
                {
                    idthe = read.GetString(0);
                    read.Close();
                    int sum = 0;
                    foreach (Sachmuon tmp in muonsach)
                    {
                        sum += tmp.soluongS;
                    }
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Danhsachmuon values('" + idthe + "'," + sum + ",0)";

                    cmd.Connection = sql;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        throw new Exception("Save thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    throw new Exception("Thành viên này chưa có thẻ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ctmuonsach()
        {
            SqlConnection sql = new SqlConnection(link);
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string qr = "select MAX(idMuonSach) from DanhSachMuon";
            SqlCommand cmd1 = new SqlCommand(qr);
            cmd1.Connection = sql;

            SqlDataReader read = cmd1.ExecuteReader();
            int idmuon;
            if (read.Read())
            {
                idmuon = read.GetInt32(0);
            }
            else
                idmuon = 0;

            read.Close();
            if (idmuon > 0)
            {
                foreach (Sachmuon tmp in muonsach)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    string muon = dtpNgaymuon.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string tra = dtpHantra.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.CommandText = $"INSERT INTO ChiTietMuonSach VALUES('{idmuon}', '{tmp.idS}', '{tmp.soluongS}', '{muon}', '{tra}', '0')";
                    cmd.Connection = sql;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("save không thành công");


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Xác nhận thêm sách mượn cho : \nId Thẻ : {tbIdThe.Text}.\nHọ Tên : {tbTendocgia.Text}.\nSĐT: {tbSdt.Text}.", "Xác nhận thông tin người mượn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            try
            {
                //if(ListMuonDAO.Instance.countSachMuon(muonsach) > 3)
                //{
                //    throw new Exception("Độc giả không được mượn quá 3 cuốn sách");
                //}

                saveDanhsachmuon();
                Ctmuonsach();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void SaveDanhSachtra()
        {
            SqlConnection sql = new SqlConnection(link);
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string qr = "insert into DanhSachTra values(" + idthe + "," + soluongsachtra + ")";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            try
            {
                cmd.ExecuteNonQuery();
                throw new Exception("Trả thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void upDanhsachmuon()
        {
            SqlConnection sql = new SqlConnection(link);
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string qr = "Update DanhSachMuon set tinhtrang=1 where idMuonSach=" + tbMamuon.Text + "";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            try
            {
                cmd.ExecuteNonQuery();
                //throw new Exception("Update thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTrasach_Click(object sender, EventArgs e)
        {
            SaveDanhSachtra();
            //MessageBox.Show(idthe.ToString());
            upDanhsachmuon();
        }
        private void UdGiahan()
        {
            SqlConnection sql = new SqlConnection(link);
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string qr = "select soLanGiaHan from ChiTietMuonSach where idMuonsach = " + tbIdThe_TS.Text + "";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            int solangiahan;
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                if (read.Read())
                {
                    solangiahan = read.GetInt32(0);
                    read.Close();
                    solangiahan += 1;
                    string qr1 = "Update ChiTietMuonSach set soLanGiaHan=" + solangiahan + " where idmuonsach=" + tbIdThe_TS.Text + "";
                    SqlCommand cmd1 = new SqlCommand(qr1);
                    cmd1.Connection = sql;
                    try
                    {
                        cmd1.ExecuteNonQuery();
                        throw new Exception("Gia hạn thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Gia hạn không thành công");
            }
        }
        private void btnGiahan_Click(object sender, EventArgs e)
        {
            UdGiahan();
        }





        private void CallQLsachmuon(string qr, int check)
        {
            QLDanhsach.Rows.Clear();
            SqlConnection sql = new SqlConnection(link);
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                if (check == 1)
                {
                    while (read.Read())
                    {
                        QLDanhsach.Rows.Add(read.GetInt32(0), read.GetString(1), read.GetInt32(2), read.GetInt32(3));
                    }
                    lbContent.Text = "Danh sách mượn";
                }
                else
                {
                    while (read.Read())
                    {
                        QLDanhsach.Rows.Add(read.GetInt32(0), read.GetString(1), read.GetInt32(2));
                    }
                    lbContent.Text = "Danh sách trả";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Search_sach_Click(object sender, EventArgs e)
        {

        }

        private void QL_Danhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoc.SelectedItem.ToString() == "Phiếu mượn")
            {
                string qr = "select* from danhsachmuon";
                //MessageBox.Show("haha");
                CallQLsachmuon(qr, 1);
            }
            else if (cboLoc.SelectedItem.ToString() == "Phiếu trả")
            {
                string qr = "select* from danhsachtra";
                CallQLsachmuon(qr, 2);
            }
            else if (cboLoc.SelectedItem.ToString() == "Phiếu mượn đã trả")
            {
                string qr = "select* from DanhSachMuon where tinhtrang = 1";
                CallQLsachmuon(qr, 1);
            }
            else if (cboLoc.SelectedItem.ToString() == "Phiếu mượn chưa trả")
            {
                string qr = "select* from DanhSachMuon where tinhtrang = 0";
                CallQLsachmuon(qr, 1);
            }
            else
            {
                string qr = "select ds.idMuonSach,ds.idThe,ds.soLuong,ds.tinhtrang from Danhsachmuon ds, Chitietmuonsach ct where ds.idmuonsach=ct.idmuonsach and ngayHenTra<GETDATE() and tinhtrang=0";
                CallQLsachmuon(qr, 1);
            }

        }




        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if(tbIdThe.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng chọn số thẻ trước khi chọn sách");
        //        return;
        //    }
        //    frmChonSach cs = new frmChonSach(muonsach, idAccNeed);
        //    DialogResult res = cs.ShowDialog();
        //    if (res == DialogResult.OK)
        //    {
        //        muonsach = cs.muonsach;
        //        DanhSachMuon.DataSource = null;
        //        DanhSachMuon.DataSource = muonsach;

        //        check_choose_book = true;
        //    }
        //}

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbSoluong.Enabled = false;
            button2.Enabled = true;
            btnSave.Enabled = true;
            btnReset.Enabled = true;
            btnXoaS.Enabled = true;
            btnPrint.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DanhSachMuon.DataSource = null;
            muonsach.Clear();

            txtMaSach.Text = "";
            tbSoluong.Text = "";
            tbTacgia.Text = "";
            tbTensach.Text = "";
            
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn đăng xuất ? ", "Rời khỏi phần mềm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes) this.Close();
        }

        private void btnTKMM_Click(object sender, EventArgs e)
        {
            muonsach = ListMuonDAO.Instance.getListMuonSach(tbIdMuon.Text, null);
            DanhSachMuon.DataSource = muonsach;

            string idAcc = "";
            foreach (Sachmuon sm in muonsach)
            {
                idAcc = sm.idThe.ToString();
            }

            idAccNeed = idAcc;
            Account acc = AccountDAO.Instance.getAccountWithIdThe(idAcc);
            User u = UserDAO.Instance.getUserWithId(acc.IdThanhVien);
            tbIdThe.Text = u.IdThe;
            tbSdt.Text = u.Phone;
            tbTendg.Text = u.Fname + " " + u.Lname;
        }

        private void mnuInfo_Click(object sender, EventArgs e)
        {
            InfoUser iu = new InfoUser(user_current);
            iu.Show();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Hành động này sẽ chỉnh sửa thông tin hiện có. Bạn có chắc muốn chỉnh sửa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                if (txtMaSach.Text == "") throw new Exception("Vui lòng chọn sách cần chỉnh sửa !!");

                Sachmuon sua = muonsach.FirstOrDefault(s => s.idS == txtMaSach.Text);
                sua.soluongS = Convert.ToInt32(tbSoluong.Text);

                DanhSachMuon.DataSource = null;
                DanhSachMuon.DataSource = muonsach;

                tbSoluong.Enabled = false;
                button2.Enabled = true;
                btnSave.Enabled = true;
                btnReset.Enabled = true;
                btnXoaS.Enabled = true;
                btnPrint.Enabled = true;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTKIDTHE_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.No;
            
            if(check_choose_book == true)
            {
                res = MessageBox.Show("Bạn có muốn giữ lại danh sách sách đã chọn ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if(res == DialogResult.No)
            {
                muonsach = ListMuonDAO.Instance.getListMuonSachIdThe(tbIdThe.Text);
                if(muonsach.Count > 0) DanhSachMuon.DataSource = muonsach;
            }

            Account acc = AccountDAO.Instance.getAccountWithIdThe(tbIdThe.Text);
            if(acc == null)
            {
                MessageBox.Show("Không tìm thấy mã thẻ !!!");
                return;
            }
            idAccNeed = acc.IdThe;
            User u = UserDAO.Instance.getUserWithId(acc.IdThanhVien);
            tbSdt.Text = u.Phone;
            tbTendg.Text = u.Fname + " " + u.Lname;
            txtMaSach.Text = "";
            tbSoluong.Text = "";
            tbTacgia.Text = "";
            tbTensach.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DanhSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                MessageBox.Show(e.RowIndex.ToString());
                DataGridViewRow slRow = DanhSachMuon.Rows[e.RowIndex];

                tbTensach.Text = slRow.Cells["tenS"].Value.ToString();
                tbTacgia.Text = slRow.Cells["tentacgiaS"].Value.ToString();
                tbSoluong.Text = slRow.Cells["soluongS"].Value.ToString();
                txtMaSach.Text = slRow.Cells["idS"].Value.ToString();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //KIET LE 
        private void QLDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = QLDanhsach.Rows[e.RowIndex];
                if (cboLoc.Text == "Phiếu trả")
                {
                    int id = Convert.ToInt32(r.Cells[0].Value);
                    ChiTietMuonTra tmp = new ChiTietMuonTra(id, 0);
                    this.Hide();
                    tmp.ShowDialog();
                    this.Show();
                }
                else
                {
                    int id = Convert.ToInt32(r.Cells[0].Value);
                    ChiTietMuonTra tmp = new ChiTietMuonTra(id, 1);
                    this.Hide();
                    tmp.ShowDialog();
                    this.Show();
                }
            }

        }
        public void savetrasach(string qr)
        {
            SqlConnection sql = new SqlConnection(link);
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            try
            {
                cmd.ExecuteNonQuery();
                throw new Exception("Update thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = data.Rows[e.RowIndex];
                if (row != null)
                {
                    string qr = "Update ChiTietMuonSach set tinhtrang=1 where idMuonSach=" + row.Cells[0].Value + " and idSach='" + row.Cells[1].Value + "'";
                    //MessageBox.Show(row.Cells[0].Value + " " + row.Cells[1].Value);
                    DateTime n = DateTime.Now;
                    if (n > (DateTime)row.Cells[6].Value)
                    {
                        MessageBox.Show("Bạn trả đã trả quá hạn");
                    }
                    savetrasach(qr);
                }
            }
        }

        private void btnSearchTheTra_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.No;

            if (check_choose_book == true)
            {
                res = MessageBox.Show("Bạn có muốn giữ lại danh sách sách đã chọn ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (res == DialogResult.No)
            {
                muonsach = ListMuonDAO.Instance.getListMuonSachIdThe(tbIdThe_TS.Text);
                if (muonsach.Count > 0) DanhSachMuon.DataSource = muonsach;
            }

            Account acc = AccountDAO.Instance.getAccountWithIdThe(tbIdThe_TS.Text);
            if (acc == null)
            {
                MessageBox.Show("Không tìm thấy mã thẻ !!!");
                return;
            }
            idAccNeed = acc.IdThe;
            User u = UserDAO.Instance.getUserWithId(acc.IdThanhVien);
            tbMadg.Text = u.IdThanhVien;
            tbTendocgia.Text = u.Fname + " " + u.Lname;
            tbSdtTra.Text = u.Phone;
        }

        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QLMuon_Click(object sender, EventArgs e)
        {

        }

        private void QLDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lbContent_Click(object sender, EventArgs e)
        {

        }

        private void tb_Search_mas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void TraSach_Click(object sender, EventArgs e)
        {

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void tbMamuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void dNgaytra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dNgaymuon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tbMadg_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTendocgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tbSdtTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdThe_TS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void DkMs_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbTacgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbTensach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tbSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdThe_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpHantra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgaymuon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbTendg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TraCuuSach_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {

        }

        private void tbMaKe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {

        }

        private void tbTang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tbSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvTLXN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuUser_Click(object sender, EventArgs e)
        {

        }
    }
}
