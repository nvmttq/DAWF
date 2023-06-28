using DoAnLTWF_Code.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string thoiHan = cbThoiHan.SelectedItem.ToString();
            string fullName = txtFname.Text + " " + txtLname.Text;
            string role = cbRole.SelectedItem.ToString();

            string idUser = "";
            
            foreach (string item in fullName.Split(' '))
            {
                idUser += item[0];
            }

            idUser += "_";
            foreach (string item in role.Split(' '))
            {
                idUser += item[0];
            }

            


            DialogResult res = MessageBox.Show($"Thêm thông tin người dùng id = {idUser} ?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                try
                {
                    UserDAO.Instance.themUser(idUser, txtFname.Text, txtLname.Text, txtSDT.Text, txtEmail.Text, Convert.ToDateTime(dtpBirth.Value), role, thoiHan);
                    MessageBox.Show($"Thêm người dùng id = {idUser} thành công !!!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
