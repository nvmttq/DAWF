using DoAnLTWF_Code.DAO;
using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class frmQuanThu : Form
    {
        public string link = @"Data Source=DESKTOP-5TIPTVB;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        private User user_current = null;
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
        private void CallSach()
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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Sach";

            cmd.Connection = sql;

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string idsach = read.GetString(0);
                string tensach = read.GetString(1);
                string tentacgia = read.GetString(2);
                string nxb = read.GetString(3);
                int namxb = read.GetInt32(4);
                int sotrang = read.GetInt32(5);
                int soluong = read.GetInt32(6);
                Sach s = new Sach(idsach, tensach, tentacgia, nxb, namxb, sotrang, soluong);
                //MessageBox.Show(idsach);
                sach.Add(s);
            }
        }
        private void CallThanhvien()
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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Thanhvien";

            cmd.Connection = sql;

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string id = read.GetString(0);
                string hoten = read.GetString(1) + read.GetString(2);
                DateTime ngaysinh = read.GetDateTime(3);
                string email = read.GetString(4);
                string phone = read.GetString(5);
                //string bank = (read.GetString(6) == null ? "" : read.GetString(6));
                ThanhVien t = new ThanhVien(id, hoten, ngaysinh, email, phone, "");
                thanhvien.Add(t);
            }

        }
        private void label20_Click(object sender, EventArgs e)
        {

        }


        private void FMain_Load(object sender, EventArgs e)
        {
            CallSach();
           // cbMassach.DataSource = sach;
            //MessageBox.Show(sach[0].idSach);
            //cbMassach.DisplayMember = "idsach";

            //CallThanhvien();

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
            Sachmuon sua = muonsach.FirstOrDefault(s => s.idS == txtMaSach.Text);
            sua.soluongS = Convert.ToInt32(tbSoluong.Text);

            DanhSachMuon.DataSource = null;
            DanhSachMuon.DataSource = muonsach;

            tbSoluong.Enabled = true;
            button2.Enabled = false;
            btnSave.Enabled = false;
            btnReset.Enabled = false;
            btnXoaS.Enabled = false;
            btnPrint.Enabled = false;
        }

        private void DanhSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = DanhSachMuon.Rows[e.RowIndex];
                txtMaSach.Text = r.Cells["idS"].Value.ToString();
                tbTensach.Text = r.Cells["tenS"].Value.ToString();
                tbTacgia.Text = r.Cells["tentacgiaS"].Value.ToString();
                tbSoluong.Text = r.Cells["soluongS"].Value.ToString();
                txtMaSach.Text = r.Cells["idS"].Value.ToString();
            }
        }

        private void DanhSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = DanhSachMuon.Rows[e.RowIndex];
                tbTensach.Text = r.Cells["tenS"].Value.ToString();
                tbTacgia.Text = r.Cells["tentacgiaS"].Value.ToString();
                tbSoluong.Text = r.Cells["soluongS"].Value.ToString();
                txtMaSach.Text = r.Cells["idS"].Value.ToString();
            }
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

            string qrthe = "select idThe from TheThuVien where idThanhvien='" + tbIdThe.Text + "'";
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
                    cmd.CommandText = "insert into chitietmuonsach values('" + tmp.idS + "'," + tmp.soluongS + ",'" + muon + "','" + tra + "',0," + idmuon + ")";
                    cmd.Connection = sql;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        //throw new Exception("Save thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("save lõ");


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveDanhsachmuon();
            Ctmuonsach();
        }

        private void CallMaMuon()
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
            string qr = "select tv.idThanhVien, tv.Fname+' '+tv.Lname  as ten,tv.Phone,ds.soLuong,t.idThe from DanhSachMuon ds, TheThuVien t, ThanhVien tv where idMuonSach = " + tbSeach_Mamuon.Text + " and ds.idThe = t.idThe and tv.idThanhVien = t.idThanhVien";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                if (read.Read())
                {
                    tbMamuon.Text = tbSeach_Mamuon.Text;
                    tbMadg.Text = read.GetString(0);
                    tbTendocgia.Text = read.GetString(1);
                    tbSdtmuon.Text = read.GetString(2);
                    //MessageBox.Show(read.GetInt32(4).ToString());
                    soluongsachtra = read.GetInt32(3);
                    idthe = Convert.ToInt32(read.GetString(4));
                    //string s = read.GetString(4);
                    //MessageBox.Show(idthe.ToString());
                }
                else
                    throw new Exception("Không tìm thấy mã sách");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CallDanhsachmuon()
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
            string qr = "select s.idSach,s.tenSach,s.tenTacGia,ct.soLuong,ct.soLanGiaHan,ct.ngayMuon,ct.ngayHenTra from ChiTietMuonSach ct,Sach s where idMuonsach = " + tbSeach_Mamuon.Text + " and ct.idSach = s.idSach";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem(read.GetString(0));
                item.SubItems.Add(read.GetString(1));
                item.SubItems.Add(read.GetString(2));
                item.SubItems.Add(read.GetInt32(3).ToString());
                item.SubItems.Add(read.GetInt32(4).ToString());
                ltSach.Items.Add(item);
                dNgaymuon.Value = read.GetDateTime(5);
                dNgaytra.Value = read.GetDateTime(6);
                tienphat = read.GetInt32(4) * 100000;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Tìm kiếm phiếu mượn theo mã
            //Gọi thông tin của độc giả
            CallMaMuon();
            //Gọi danh sách các sách mượn của phiếu
            CallDanhsachmuon();

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
            string qr = "select soLanGiaHan from ChiTietMuonSach where idMuonsach = " + tbSeach_Mamuon.Text + "";
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
                    string qr1 = "Update ChiTietMuonSach set soLanGiaHan=" + solangiahan + " where idmuonsach=" + tbSeach_Mamuon.Text + "";
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




        private void button2_Click(object sender, EventArgs e)
        {
            frmChonSach cs = new frmChonSach(muonsach);

            if(cs.ShowDialog() == DialogResult.OK)
            {
                DanhSachMuon.DataSource = cs.muonsach;
            }
        }

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
            muonsach = ListMuonDAO.Instance.getListMuonSach(tbIdMuon.Text, tbIdThe.Text);
            DanhSachMuon.DataSource = muonsach;

            string idAcc = "";
            foreach (Sachmuon sm in muonsach)
            {
                idAcc = sm.idThe.ToString();
            }

            
            Account acc = AccountDAO.Instance.getAccountWithIdThe(idAcc);
            MessageBox.Show(acc.IdThanhVien);
            User u = UserDAO.Instance.getUserWithId(acc.IdThanhVien);
            tbIdThe.Text = u.IdThe;
            tbSdt.Text = u.Phone;
            tbTendg.Text = u.Fname + " " + u.Lname;
        }

 
    }
}
