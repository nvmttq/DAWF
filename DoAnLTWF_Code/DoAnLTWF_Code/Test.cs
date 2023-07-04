using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void mnuChooseB_Click(object sender, EventArgs e)
        {
            frmChoose c = new frmChoose();

            c.Show();
        }
    }
}
