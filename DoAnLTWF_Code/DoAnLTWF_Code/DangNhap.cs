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
using DoAnLTWF_Code.DAO;
using DoAnLTWF_Code.DTO;

namespace DoAnLTWF_Code
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text;
            string pass = txtMatKhau.Text;

            User sucess = AccountDAO.Instance.login(user, pass);

            if(sucess != null)
            {
                MessageBox.Show("LOGIN SUCESS !!! \n Hello, Have a nice day ♥");
                this.Hide();
                if(sucess.Mode.ToString() == "1")
                {
                    frmAdmin dg = new frmAdmin(sucess);
                    dg.ShowDialog();
                } else if(sucess.Mode.ToString() == "2")
                {
                    //frmQuanThu qt = new frmQuanThu(sucess);
                    //qt.ShowDialog();
                    frmts ts = new frmts(sucess);
                    ts.ShowDialog();
                } else
                {
                    frmSinhVien sv = new frmSinhVien(sucess);
                    sv.ShowDialog();
                }

                
                this.Show();
            } else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu ! Vui lòng nhập lại !", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // txtTaiKhoan.Text = "ENTER";
                
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dk = new frmDangKy();
            dk.Show();
        }

        private void Enter_Login(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnDangNhap.Select();
                btnDangNhap.PerformClick();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            loadColor();
        }

        private void loadColor()
        {
          //  btnDangNhap.BackColor = ColorTranslator.FromHtml("#186db6");
        }
    }
}
