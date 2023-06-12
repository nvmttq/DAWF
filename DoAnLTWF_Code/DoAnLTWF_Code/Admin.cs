using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        #region events
        private void typeObject_Click(object sender, EventArgs e)
        {
            string text = "Độc giả";
            Control control = sender as Control;
            Panel pn = null;
            if (!(control is Panel)) pn = control.Parent as Panel;
            else pn = control as Panel;
            foreach(Control ctrl in pn.Controls)
            {
                if(ctrl is Label)
                {
                    text = ctrl.Text;
                }
            }
            lbObject.Text = "Thông tin " + text;
            lbDanhSachObject.Text = "Danh sách " + text;
        }
        #endregion
  

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            for(int i = 30; i >= 1; i--)
            {
                Label cell1 = new Label();
                cell1.Text = i.ToString();
                cell1.TextAlign = ContentAlignment.MiddleRight;
                Label cell2 = new Label();
                cell2.Text = $"Cell {i}";

                tblpnTheLoai.Controls.Add(cell1, 0, tblpnTheLoai.RowCount - 1);
                tblpnTheLoai.Controls.Add(cell2, 1, tblpnTheLoai.RowCount - 1);

                tblpnTheLoai.RowCount++;

            }
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pnContentThonTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdmin_Resize(object sender, EventArgs e)
        {
            Panel pn = pnDanhSachMuon;
            pn.Width = (pn.Parent.Width / 2);
            Panel pndst = pnDanhSachTra;
            pndst.Width = (pn.Parent.Width / 2);
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            var a = 123;
        }
    }
}
