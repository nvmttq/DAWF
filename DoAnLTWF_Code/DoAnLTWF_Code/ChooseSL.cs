using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class ChooseSL : Form
    {

        public int soLuong = -1;
        public ChooseSL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                soLuong = int.Parse(textBox1.Text);
                if(soLuong <= 0)
                {
                    throw new Exception("Số lượng sách được chọn phải ít nhất 1 cuốn !!!");
                }
                DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
