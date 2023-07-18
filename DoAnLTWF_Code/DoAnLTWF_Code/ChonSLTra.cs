using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class ChonSLTra : Form
    {
        public int SoLuong = 0;
        public ChonSLTra()
        {
            InitializeComponent();
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            
            if(int.Parse(txtSL.Text) == -1)
            {
                MessageBox.Show("Số lượng phải >= 0");
                return;
            }
            SoLuong = int.Parse(txtSL.Text);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xác nhận thoát ?", "Xác nhânk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes) this.Close();
        }
    }
}
