using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CuoiKyChoAnhMinh
{
    public partial class FMain : Form
    {
        public string link = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        public FMain()
        {
            InitializeComponent();
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
            while(read.Read())
            {
                string idsach=read.GetString(0);
                string tensach=read.GetString(1);
                string tentacgia=read.GetString(2);
                string nxb=read.GetString(3);
                int namxb=read.GetInt32(4);
                int sotrang=read.GetInt32(5);
                int soluong=read.GetInt32(6);
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
            while(read.Read())
            {
                string id=read.GetString(0);
                string hoten=read.GetString(1)+read.GetString(2);
                DateTime ngaysinh=read.GetDateTime(3);
                string email=read.GetString(4);
                string phone=read.GetString(5);
                string bank=read.GetString(6);
                ThanhVien t = new ThanhVien(id,hoten,ngaysinh,email,phone,bank);
                thanhvien.Add(t);
            }    
            
        }
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void FMain_Load(object sender, EventArgs e)
        {
            CallSach();
            cbMassach.DataSource =sach;
            //MessageBox.Show(sach[0].idSach);
            cbMassach.DisplayMember = "idsach";

            CallThanhvien();
            cbDocGia.DataSource = thanhvien;
            cbDocGia.DisplayMember = "idTv";

            DateTime Ngaymuon = dtpNgaymuon.Value;
            DateTime Ngaytra = Ngaymuon.AddDays(7);

            dtpHantra.Value = Ngaytra;

            

        }

        private void cbMassach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMassach.SelectedItem!=null)
            {
                Sach tmp = (Sach)cbMassach.SelectedItem;
                tbTensach.Text = tmp.tenSach;
                tbTacgia.Text = tmp.tenTacGia;
            }    
        }

        private void cbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDocGia.SelectedItem!=null)
            {
                ThanhVien tmp = (ThanhVien)cbDocGia.SelectedItem;
                tbTendg.Text = tmp.Hotentv;
                tbSdt.Text = tmp.Phone;
            }    
        }

        private void btnThemS_Click(object sender, EventArgs e)
        {
            try
            {
                string ids = cbMassach.Text;
                string tens = tbTensach.Text;
                string tentacgia = tbTacgia.Text;
                int sl = Convert.ToInt32(tbSoluong.Text);
                Sachmuon tmp = new Sachmuon(ids,tens,tentacgia,sl);
                muonsach.Add(tmp);
                DanhSachMuon.DataSource = null;
                DanhSachMuon.DataSource = muonsach;
                DanhSachMuon.AutoGenerateColumns = true;
                DanhSachMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm thiếu dữ liệu");
            }
        }

        private void btnSuaS_Click(object sender, EventArgs e)
        {
            Sachmuon sua = muonsach.FirstOrDefault(s => s.idS == cbMassach.Text);
            sua.soluongS = Convert.ToInt32(tbSoluong.Text);

            DanhSachMuon.DataSource = null;
            DanhSachMuon.DataSource = muonsach;

        }

        private void DanhSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex>=0)
            {
                DataGridViewRow r = DanhSachMuon.Rows[e.RowIndex];
                cbMassach.Text = r.Cells["idS"].Value.ToString();
                tbTensach.Text = r.Cells["tenS"].Value.ToString();
                tbTacgia.Text = r.Cells["tentacgiaS"].Value.ToString();
                tbSoluong.Text = r.Cells["soluongS"].Value.ToString();
            }    
        }

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            Sachmuon sua = muonsach.FirstOrDefault(s => s.idS == cbMassach.Text);
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

            string qrthe = "select idThe from TheThuVien where idThanhvien='"+cbDocGia.Text+"'";
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
            string qr = "select t.idThe, tv.Fname+' '+tv.Lname  as ten,tv.Phone,ds.soLuong,t.idThe from DanhSachMuon ds, TheThuVien t, ThanhVien tv where t.idThe = "+tbThe.Text+" and ds.idThe = t.idThe and tv.idThanhVien = t.idThanhVien";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                if (read.Read())
                {
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        List<Sachtra> st = new List<Sachtra>();
        private void CallDanhsachmuon()
        {
            data.Rows.Clear();
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
            string qr = "select ds.idMuonSach, s.idSach, s.tenSach,ct.soLanGiaHan,ct.soLuong,ct.ngayMuon,ct.ngayHenTra  from Danhsachmuon ds, chitietmuonsach ct, Sach s where ds.idmuonsach = ct.idMuonsach and ct.idSach = s.idSach and ct.tinhtrang = 0 and idthe = " + tbThe.Text+"";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                DataGridViewRow row = (DataGridViewRow)data.Rows[0].Clone();
                row.Cells[0].Value = read.GetInt32(0);
                row.Cells[1].Value = read.GetString(1);
                row.Cells[2].Value = read.GetString(2);
                row.Cells[3].Value = read.GetInt32(3);
                row.Cells[4].Value = read.GetInt32(4);
                row.Cells[5].Value = read.GetDateTime(5);
                row.Cells[6].Value = read.GetDateTime(6);

                /*int id = read.GetInt32(0);
                string idsach = read.GetString(1);
                string tensach = read.GetString(2);
                int giahan = read.GetInt32(3);
                int souong = read.GetInt32(4);*/

                //Sachtra tmp = new Sachtra(id, idsach, tensach, giahan, souong);
                data.Rows.Add(row);
                
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
        private int CallidTrasach()
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
            string qr = "select max(idtrasach) from DanhSachTra";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                return read.GetInt32(0);
            }
            else
                return 0;
        }
        
        private void SaveDanhSachtra()
        {
            

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
            string qr = "Update DanhSachMuon set tinhtrang=1 where idMuonSach="+1+"";
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
            string qr = "select soLanGiaHan from ChiTietMuonSach where idMuonsach = "+tbThe.Text+"";
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
                    string qr1 = "Update ChiTietMuonSach set soLanGiaHan="+solangiahan+" where idmuonsach="+tbThe.Text+"";
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


        


        private void CallQLsachmuon(string qr,int check)
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
                if(check==1)
                {
                    while(read.Read())
                    {                        
                        QLDanhsach.Rows.Add(read.GetInt32(0),read.GetString(1), read.GetInt32(2), read.GetInt32(3));
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
     

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoc.SelectedItem== "Phiếu mượn")
            {
                string qr = "select* from danhsachmuon";
                //MessageBox.Show("haha");
                CallQLsachmuon(qr, 1);
            }    
            else if(cboLoc.SelectedItem== "Phiếu trả")
            {
                string qr = "select* from danhsachtra";
                CallQLsachmuon(qr, 2);
            }  
            else if(cboLoc.SelectedItem=="Phiếu mượn đã trả")
            {
                string qr = "select* from DanhSachMuon where tinhtrang = 1";
                CallQLsachmuon(qr, 1);
            }
            else if (cboLoc.SelectedItem == "Phiếu mượn chưa trả")
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

        private void QLDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow r = QLDanhsach.Rows[e.RowIndex];
                MessageBox.Show("haha");
                /*if(cboLoc.Text== "Phiếu mượn")
                {
                    int id = Convert.ToInt32( r.Cells["Column1"]);
                    //ChitietMuontra tmp = new ChitietMuontra(, 1);
                    MessageBox.Show(id.ToString());

                }*/
           
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {

        }

        private void QLDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = QLDanhsach.Rows[e.RowIndex];
                if (cboLoc.Text == "Phiếu trả")
                {
                    int id = Convert.ToInt32(r.Cells[0].Value);
                    ChitietMuontra tmp = new ChitietMuontra(id, 0);
                    this.Hide();
                    tmp.ShowDialog();
                    this.Show();
                }
                else
                {
                    int id = Convert.ToInt32(r.Cells[0].Value);
                    ChitietMuontra tmp = new ChitietMuontra(id, 1);
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
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = data.Rows[e.RowIndex];
                if(row!=null)
                {
                    string qr = "Update ChiTietMuonSach set tinhtrang=1 where idMuonSach="+row.Cells[0].Value+" and idSach='"+row.Cells[1].Value+"'";
                    //MessageBox.Show(row.Cells[0].Value + " " + row.Cells[1].Value);
                    DateTime n = DateTime.Now;
                    if(n>(DateTime)row.Cells[6].Value)
                    {
                        MessageBox.Show("Bạn trả đã trả quá hạn");
                    }    
                    savetrasach(qr);
                }    
            }    
        }
    }
}
