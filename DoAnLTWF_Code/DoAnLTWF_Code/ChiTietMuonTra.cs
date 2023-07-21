using DoAnLTWF_Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class ChiTietMuonTra : Form
    {
        int id;
        int check;
        public string link = _variable.link_connection;
        public ChiTietMuonTra(int i, int c)
        {
            InitializeComponent();
            this.id = i;
            this.check = c;

        }

        List<Sachmuon> muon = new List<Sachmuon>();
        //Gọi mượn
        private void CallMuon()
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
            string qr = "select ds.idThe,tv.Fname+' '+tv.Lname as Hoten ,tv.Phone from DanhSachMuon ds, TheThuVien t, ThanhVien tv  where ds.idThe=t.idThe and t.idThanhVien=tv.idThanhVien and ds.idMuonSach=" + id + "";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    tbId.Text = id.ToString();
                    tbMaThe.Text = read.GetString(0);
                    tbTendg.Text = read.GetString(1);
                    tbSdt.Text = read.GetString(2);
                }
                else
                    throw new Exception("Không thấy dữ liệu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CallDanhsach()
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
            string qr = "select s.idSach,s.tenSach,s.tenTacGia,ct.soLuong,ct.soLanGiaHan,ct.ngayMuon,ct.ngayHenTra from ChiTietMuonSach ct,Sach s where idMuonsach = " + id + " and ct.idSach = s.idSach";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string ids = read.GetString(0);
                string tens = read.GetString(1);
                string tentacgia = read.GetString(2);
                int sl = read.GetInt32(3);
                Sachmuon tmp = new Sachmuon(ids, tens, tentacgia, sl);
                muon.Add(tmp);
                tbGiahan.Text = read.GetInt32(4).ToString();
                dtpNgaymuon.Value = read.GetDateTime(5);
                dtpHantra.Value = read.GetDateTime(6);
            }
        }
        private void CallTra()
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
            string qr = "select ds.idThe,tv.Fname+' '+tv.Lname as Hoten ,tv.Phone from DanhSachTra ds, TheThuVien t, ThanhVien tv  where ds.idThe=t.idThe and t.idThanhVien=tv.idThanhVien and ds.idTraSach=" + id + "";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    tbId.Text = id.ToString();
                    tbMaThe.Text = read.GetString(0);
                    tbTendg.Text = read.GetString(1);
                    tbSdt.Text = read.GetString(2);
                }
                else
                    throw new Exception("Không thấy dữ liệu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CallDanhsachtra()
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
            string qr = "select s.idSach,s.tenSach,s.tenTacGia,ct.soLuong,ct.ngayTra,ct.soTienPhat from ChiTietTraSach ct,Sach s  where idTraSach = " + id + " and ct.idSach = s.idSach";
            SqlCommand cmd = new SqlCommand(qr);
            cmd.Connection = sql;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string ids = read.GetString(0);
                string tens = read.GetString(1);
                string tentacgia = read.GetString(2);
                int sl = read.GetInt32(3);
                Sachmuon tmp = new Sachmuon(ids, tens, tentacgia, sl);
                muon.Add(tmp);
                label7.Text = "Số tiền phạt: ";
                dtpHantra.Value = read.GetDateTime(4);
                tbGiahan.Text = read.GetInt32(5).ToString();
                //MessageBox.Show(read.GetString(1));
                label5.Hide();
                dtpNgaymuon.Hide();
                label6.Text = "Ngày trả";
            }
        }

        private void ChitietMuontra_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(id.ToString());
            if (check == 0)
            {
                CallTra();
                CallDanhsachtra();
                dtChitiet.DataSource = muon;
            }
            else
            {
                CallMuon();
                CallDanhsach();
                dtChitiet.DataSource = muon;
            }

        }
    }
}
