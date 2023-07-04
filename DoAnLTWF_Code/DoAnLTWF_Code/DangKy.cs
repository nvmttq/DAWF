using DoAnLTWF_Code.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        private void DangKy_Load(object sender, EventArgs e)
        {
            cbThoiHan.SelectedIndex = cbThoiHan.Items.IndexOf("Tuần");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string tk = txtTaiKhoan.Text;
            string pass1 = txtMatKhau1.Text;
            string pass2 = txtMatKhau2.Text;
            string day = (cbThoiHan.SelectedItem == null ? "" : cbThoiHan.SelectedItem.ToString());
            string who = (cbWho.SelectedItem == null ? "" : cbWho.SelectedItem.ToString());
            string mode = getMode(who).ToString();

            vis(ho, lbValHo);
            vis(ten, lbValTen);
            vis(tk, lbValTK);
            vis(pass1, lbValMK);
            vis(pass2, lbValMK2);
            vis(day, lbValTH);
            vis(who, lbValWho);

        }

        private void vis(string selec, Label lb)
        {
            if (selec == "")
            {
                lb.Text = "Không được để trống";
                lb.Visible = true;
            }
            else
            {
                if (lb.Name == "lbValMK" && selec.Length < 5)
                {
                    lb.Text = "Mật khẩu quá ngắn";
                    lb.Visible = true;
                }
                else if (lb.Name == "lbValMK2" && selec != txtMatKhau1.Text)
                {
                    lb.Text = "Mật khẩu không khớp";
                    lb.Visible = true;
                }
                else if (lb.Name == "lbValTK" && AccountDAO.Instance.AccountExists(selec) == false)
                {
                    lb.Text = "Tài khoản đã tồn tại";
                    lb.Visible = true;
                }
                else lb.Visible = false;
            }
        }


        private int getMode(string who)
        {
            if (who == "Sinh viên") return 3;
            else if (who == "Giảng viên") return 4;
            else return 5;
        }

        private static Random random = new Random();
        private void btnAutoTK_Click(object sender, EventArgs e)
        {
            if(cbWho.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đối tượng để tạo tài khoản");
                return;
            }
            string randomString = "";
            do
            {
                const string characters = "0123456789";

                // Generate a random string of length 4
                randomString = new string(Enumerable.Repeat(characters, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());

                string who = cbWho.SelectedItem.ToString();

                if (who == "Sinh Viên") randomString = "SV_" + randomString;
                else if (who == "Giảng Viên") randomString = "GV_" + randomString;
                else randomString = "OT_" + randomString;
                // MessageBox.Show(randomString);
                txtTaiKhoan.Text = randomString;
            } while (AccountDAO.Instance.AccountExists(randomString) == false);
            
            
        }
    }
}
