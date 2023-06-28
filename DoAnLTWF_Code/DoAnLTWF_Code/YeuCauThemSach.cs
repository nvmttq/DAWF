using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class YeuCauThemSach : Form
    {
        public YeuCauThemSach()
        {
            InitializeComponent();
        }

     
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // check validtion
            // true close and notice sucess
            // false again
        }
    }
}
