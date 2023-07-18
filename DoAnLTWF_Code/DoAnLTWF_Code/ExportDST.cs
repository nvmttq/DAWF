using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class ExportDST : Form
    {
        public List<String> headerColumn = new List<string>();
        public ExportDST()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void checkedHeader_SelectedValueChanged(object sender, EventArgs e)
        {
            var s = checkedHeader.SelectedItem.ToString();
            
            if(s == "Tất Cả")
            {
                for (int i = 0; i < checkedHeader.Items.Count; i++)
                {
                    checkedHeader.SetItemChecked(i, true);
                }
            } else
            {
                var a = checkedHeader.SelectedIndex;
                checkedHeader.SetItemChecked(a, !checkedHeader.GetItemChecked(a));
            }
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xác nhận chọn các Column", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            for (int i = 0; i < checkedHeader.Items.Count; i++)
            {
                if(checkedHeader.GetItemChecked(i))
                {
                    string val = checkedHeader.SelectedItem.ToString();
                    if(val != "Tất Cả") headerColumn.Add(val);
                }
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
