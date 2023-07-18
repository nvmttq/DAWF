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
    public partial class frmts : Form
    {
        public string link = @"Data Source=DESKTOP-5TIPTVB;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        private User user_current = null;
        public frmts(User u)
        {
            InitializeComponent();
            user_current = u;
            mnuUser.Text = "Hello, " + u.Fname + " " + u.Lname + "  !!!";
        }

        #region MUONSACH
        List<Sach> sach = new List<Sach>();
        List<ThanhVien> thanhvien = new List<ThanhVien>();
        List<Sachmuon> muonsach = new List<Sachmuon>();
        List<ChiTietSachMuon> SachMuonCuaUser = new List<ChiTietSachMuon>();
        List<ChiTietSachMuon> pending_SachMuonCuaUser = new List<ChiTietSachMuon>();
        private bool check_choose_book = false;
        private string idAccNeed = "";
        private void btnTKIDTHE_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.No;

            if (check_choose_book == true && save_ok == false)
            {
                res = MessageBox.Show("Bạn có muốn giữ lại danh sách sách đã chọn ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (res == DialogResult.No)
            {
              //  muonsach = ListMuonDAO.Instance.getListMuonSachIdThe(tbIdThe.Text);
                SachMuonCuaUser = ListMuonDAO.Instance.SachMuonCuaUser(tbIdThe.Text);
                if (SachMuonCuaUser.Count > 0)
                {
                    DanhSachMuon.DataSource = SachMuonCuaUser;
                    DanhSachMuon.Columns["idCTM"].Visible = false;
                    DanhSachMuon.Columns["idMuon"].Visible = false;
                }
                else DanhSachMuon.DataSource = null;
            } 

            Account acc = AccountDAO.Instance.getAccountWithIdThe(tbIdThe.Text);
            if (acc == null)
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
            txtMaMuon.Text = "";
            tbTacgia.Text = "";
            tbTensach.Text = "";

            save_ok = false;
        }

        private void btnChonSach_Click(object sender, EventArgs e)
        {
            if (tbIdThe.Text == "")
            {
                MessageBox.Show("Vui lòng chọn số thẻ trước khi chọn sách");
                return;
            }
            frmChonSach cs = new frmChonSach(SachMuonCuaUser, idAccNeed);
            if (cs.ShowDialog() == DialogResult.OK)
            {
                SachMuonCuaUser = cs.muonsach;
                DanhSachMuon.DataSource = null;
                DanhSachMuon.DataSource = SachMuonCuaUser;
                DanhSachMuon.Columns["idCTM"].Visible = false;
                DanhSachMuon.Columns["idMuon"].Visible = false;
                DanhSachMuon.Refresh();
                check_choose_book = true;
            }
        }

        private void btnSuaS_Click(object sender, EventArgs e)
        {
            tbSoluong.Enabled = true;
            btnChonSach.Enabled = false;
            btnSave.Enabled = false;
           // btnReset.Enabled = false;
           // btnPrint.Enabled = false;
        }


        private bool save_ok = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Xác nhận thêm sách mượn cho : \nId Thẻ : {tbIdThe.Text}.\nHọ Tên : {tbTendg.Text}.\nSĐT: {tbSdt.Text}.", "Xác nhận thông tin người mượn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            try
            {
                int soLuongMuon = ListMuonDAO.Instance.countSachMuon(SachMuonCuaUser);
                if (soLuongMuon > 3)
                {
                    throw new Exception("Độc giả không được mượn quá 3 cuốn sách");
                }

                
                foreach (ChiTietSachMuon sm in SachMuonCuaUser)
                {
                    if (SachDAO.Instance.soLuongSachConLai(sm.idSach) < sm.soLuong) throw new Exception($"Số lượng sách còn lại của {tbTensach.Text} không đủ");
                }

                saveDanhsachmuon();
                Ctmuonsach();

                SachMuonCuaUser = ListMuonDAO.Instance.SachMuonCuaUser(tbIdThe.Text);
                DanhSachMuon.DataSource = null;
                DanhSachMuon.DataSource = SachMuonCuaUser;
                DanhSachMuon.Columns["idCTM"].Visible = false;
                DanhSachMuon.Columns["idMuon"].Visible = false;

                DanhSachMuon.Refresh();
                save_ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveDanhsachmuon()
        {

            try
            {
                int soLuong = 0;
                foreach(ChiTietSachMuon ctms in SachMuonCuaUser)
                {
                    soLuong += ctms.soLuong;
                }
                ListMuonDAO.Instance.addDanhSachMuon(tbIdThe.Text, soLuong);
                MessageBox.Show("Lưu thành công !!!");
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
                foreach (ChiTietSachMuon tmp in SachMuonCuaUser)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    string muon = dtpNgaymuon.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    DateTime dt = DateTime.Now;
                    dt = dt.AddDays(7);
                    cmd.CommandText = $"INSERT INTO ChiTietMuonSach (idMuonSach,idSach,soLuong, ngayHenTra, tinhTrang) VALUES('{idmuon}', '{tmp.idSach}', '{tmp.soLuong}', '{dt}', '0')";
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

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            //sua.soluongS = Convert.ToInt32(tbSoluong.Text);
            for (int i = 0; i < SachMuonCuaUser.Count; i++)
            {
                if(SachMuonCuaUser[i].idSach == txtMaSach.Text)
                {
                    SachMuonCuaUser.RemoveAt(i);
                    return;
                }
            }

            DanhSachMuon.DataSource = null;
            DanhSachMuon.DataSource = SachMuonCuaUser;
            DanhSachMuon.Columns["idCTM"].Visible = false;
            DanhSachMuon.Columns["idMuon"].Visible = false;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Hành động này sẽ chỉnh sửa thông tin hiện có. Bạn có chắc muốn chỉnh sửa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                if (txtMaSach.Text == "") throw new Exception("Vui lòng chọn sách cần chỉnh sửa !!");

                ChiTietSachMuon sua = SachMuonCuaUser.FirstOrDefault(s => s.idCTM == txtMaMuon.Text);
                sua.soLuong = Convert.ToInt32(tbSoluong.Text);

                DanhSachMuon.DataSource = null;
                DanhSachMuon.DataSource = muonsach;
                // EDITHERE
                tbSoluong.Enabled = false;
                btnChonSach.Enabled = true;
                btnSave.Enabled = true;
              //  btnReset.Enabled = true;
              //  btnPrint.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbSoluong.Enabled = false;
            btnChonSach.Enabled = true;
            btnSave.Enabled = true;
            // btnReset.Enabled = true;
            // btnPrint.Enabled = true;
            btnHuy.Enabled = true;
        }


        private void DanhSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //   MessageBox.Show(e.RowIndex.ToString());
                DataGridViewRow slRow = DanhSachMuon.Rows[e.RowIndex];
                Sach s = SachDAO.Instance.getSachWithId(slRow.Cells["idSach"].Value.ToString());
                if (s == null)
                {
                    MessageBox.Show("Không tìm thấy");
                    return;
                }
                tbTensach.Text = s.TenSach;
                tbTacgia.Text = s.TenTacGia;
                tbSoluong.Text = (slRow.Cells["soLuong"].Value == null ? "" : slRow.Cells["soLuong"].Value.ToString());
                txtMaSach.Text = s.IdSach;

                txtMaMuon.Text = (slRow.Cells["idCTM"].Value == null ? "" : slRow.Cells["idCTM"].Value.ToString());
                dtpNgaymuon.Value = DateTime.Parse(slRow.Cells["ngayMuon"].Value.ToString());
                dtpHantra.Value = DateTime.Parse(slRow.Cells["ngayHenTra"].Value.ToString());
            }
        }


        #endregion

        #region TRASACH

        private int soLuongTra = 0;
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbIdThe.Text == "") throw new Exception("Vui lòng chọn người dùng");
                if (txtMaSach.Text == "") throw new Exception ("Vui lòng chọn sách cần trả !!!");

                back_choose_SLTra:
                ChonSLTra csl = new ChonSLTra();
                
                if(csl.ShowDialog() == DialogResult.OK)
                {
                    soLuongTra = csl.SoLuong;

                    int soLuongDaTra = 0;
                    foreach (ChiTietSachMuon sm in SachMuonCuaUser)
                    {
                        if (sm.idCTM == txtMaMuon.Text) soLuongDaTra = sm.daTra;
                    }

                    if (soLuongTra > int.Parse(tbSoluong.Text) - soLuongDaTra)
                    {
                        MessageBox.Show($"Số sách chọn trả lớn hơn số lượng còn lại !! \nVui lòng xem lại");
                        goto back_choose_SLTra;
                    }
                }

                DialogResult res = MessageBox.Show($"Xác nhận trả {soLuongTra} cuốn sách {tbTensach.Text}", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(res == DialogResult.Yes)
                {
                    ListTraDAO.Instance.UserTraSach(txtMaMuon.Text, soLuongTra);
                    for(int i = 0; i < SachMuonCuaUser.Count; i++)
                    {
                        if(SachMuonCuaUser[i].idCTM == txtMaMuon.Text)
                        {
                            SachMuonCuaUser[i].daTra += soLuongTra;
                            if(SachMuonCuaUser[i].daTra == SachMuonCuaUser[i].soLuong) SachMuonCuaUser.RemoveAt(i);
                            break;
                        }
                    }

                    DanhSachMuon.DataSource = null;
                    DanhSachMuon.DataSource = SachMuonCuaUser;
                    DanhSachMuon.Columns["idCTM"].Visible = false;
                    DanhSachMuon.Columns["idMuon"].Visible = false;
                    txtMaSach.Text = "";
                    tbSoluong.Text = "";
                    txtMaMuon.Text = "";
                    tbTacgia.Text = "";
                    tbTensach.Text = "";
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }


        private void UdGiahan()
        {
            ListMuonDAO.Instance.GiaHanMuon(txtMaMuon.Text);
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            UdGiahan();
        }



        #endregion



        #region MENUTRIP
        private void mnuInfo_Click(object sender, EventArgs e)
        {
            InfoUser iu = new InfoUser(user_current);
            iu.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn đăng xuất ? ", "Rời khỏi phần mềm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes) this.Close();
        }

        private void frmts_Load(object sender, EventArgs e)
        {

        }
        #endregion



        #region DSMUON

        #endregion
    }
}
