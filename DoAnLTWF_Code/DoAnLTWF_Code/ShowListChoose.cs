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
    public partial class frmChoose : Form
    {
        public frmChoose()
        {
            InitializeComponent();
        }

        private void frmChoose_Load(object sender, EventArgs e)
        {
            List<Sach> s = SachDAO.Instance.listSach();
            dtgv1.DataSource = s;

            DataGridViewButtonColumn btnC = new DataGridViewButtonColumn();

            btnC.HeaderText = "Action";
            btnC.Text = "Chọn";
            
            btnC.UseColumnTextForButtonValue = true;
            dtgv1.Columns.Add(btnC);
        }

        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dtgv1.Rows[e.RowIndex];

            DataGridViewButtonCell a = r.Cells[e.ColumnIndex] as DataGridViewButtonCell;
            
            if (a.Value.ToString() == "Chọn")
            {
                a.Value = "Hủy";
                ChooseSL c = new ChooseSL();
                c.Show();

                if (c.soLuong >= 0)
                {
                    int t = c.soLuong; MessageBox.Show(t.ToString());
                }
            }
            else
            {
                a.Value = "Chọn";
                

            }
            a.UseColumnTextForButtonValue = false;

        }
    }
}
