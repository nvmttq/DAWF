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
    public partial class InfoUser : Form
    {
        public  User info = null;
        public InfoUser(User u)
        {
            InitializeComponent();
            info = u;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát trang xem thông tin ?" , "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes) this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach(Control ctr in (sender as Button).Parent.Controls)
            {
                
                if(ctr is TextBox && ctr.Name != "tbTK" && ctr.Name != "tbNHH" && ctr.Name != "tbConlai" && ctr.Name != "tbNDK")
                {
                    ctr.Enabled = true;
                    continue;
                }
                if (ctr.Name == "dtpkNS" || ctr is Label || ctr is Button)
                {
                    ctr.Enabled = true;
                    continue;
                }

                ctr.Enabled = false;
            }
        }

        private void InfoUser_Load(object sender, EventArgs e)
        {
            
            foreach (Control ctr in tbBank.Parent.Controls)
            {
                if (ctr is Label) continue;
                if (ctr is TextBox || ctr is DateTimePicker)
                {
                    ctr.Enabled = false;
                }
            }

            tbBank.Text = info.Bank;
            tbEmail.Text = info.Email;
            tbHoTen.Text = info.Fname + " " + info.Lname;
            tbSdt.Text = info.Phone;
            tbTK.Text = info.IdThe;
            tbMK.Text = info.Password;
            dtpkNS.Value = DateTime.Parse(info.Birthday.ToString());
            dtpkNDK.Value = info.NgayDangKy;
            dtpkNHH.Value = info.NgayHetHan;
            TimeSpan difference = dtpkNHH.Value - dtpkNDK.Value;
            tbConlai.Text = Math.Abs(difference.Days).ToString() + " ngày";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in (sender as Button).Parent.Controls)
            {

                if (ctr is Label || ctr is Button) continue;

                ctr.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int first_space = 0;
            for(int i = 0; i < tbHoTen.Text.Length; i++)
            {
                if(tbHoTen.Text[i] == ' ')
                {
                    first_space = i;
                    break;
                }
            }

            string Fname = tbHoTen.Text.Substring(0, first_space);
            string Lname = tbHoTen.Text.Substring(first_space + 1);
            User u = new User(info.IdThanhVien,Fname, Lname, DateTime.Parse(dtpkNS.Value.ToString()), tbEmail.Text, tbSdt.Text, tbBank.Text, info.Mode);
            DialogResult res = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin !!!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                try
                {
                    UserDAO.Instance.EditInfo(u);

                    MessageBox.Show("Cập nhật thành công !!!");
                    u.NgayDangKy = info.NgayDangKy;
                    u.NgayHetHan = info.NgayHetHan;
                    u.Password = info.Password;
                    u.IdThe = info.IdThe;
                    info = u;
                    DialogResult = DialogResult.OK;
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
