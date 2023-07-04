using DoAnLTWF_Code.DAO;
using DoAnLTWF_Code.DTO;
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
    public partial class frmChonSach : Form
    {
        private int soLuong = 0;

        private string ids, tentacgia, tens;
        public List<Sachmuon> muonsach = new List<Sachmuon>();
        private int rowRemove = -1;
        public frmChonSach(List<Sachmuon> list)
        {
            InitializeComponent();
            cbTKS.SelectedIndex = 0;
            muonsach = list;
            dtgvMuon.DataSource = muonsach;
        }

        private void pnTKS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int id = -1;
            for (int i = 0; i < muonsach.Count; i++)
            {
                if(muonsach[i].idS == ids)
                {
                    id = i;
                }
            }
            
            if(id > -1)
            {
                DialogResult res = MessageBox.Show("Sách đã tồn tại ! Nếu tiếp tục hệ thống sẽ cập nhật dữ liệu mới cho sách mượn này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No) return;
                else
                {
                    muonsach.RemoveAt(id);
                }
            }


            ChooseSL cl = new ChooseSL();
           
            
            
            if(cl.ShowDialog()== DialogResult.OK)
            {
                soLuong = cl.soLuong;
                Sachmuon tmp = new Sachmuon(ids, tens, tentacgia, soLuong);
                muonsach.Add(tmp);
                dtgvMuon.DataSource = null;
                dtgvMuon.DataSource = muonsach;
                dtgvMuon.ClearSelection();
                dtgvMuon.Columns["idS"].Visible = false;
            }

            try
            {
                //string ids = cbMassach.Text;
                //string tens = tbTensach.Text;
                //string tentacgia = tbTacgia.Text;
                //int sl = Convert.ToInt32(tbSoluong.Text);
                //Sachmuon tmp = new Sachmuon(ids, tens, tentacgia, sl);
                //muonsach.Add(tmp);
                //DanhSachMuon.DataSource = null;
                //DanhSachMuon.DataSource = muonsach;
                //DanhSachMuon.AutoGenerateColumns = true;
                //DanhSachMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch
            {
                MessageBox.Show("Thêm thiếu dữ liệu");
            }
        }

        private void frmChonSach_Load(object sender, EventArgs e)
        {
          
            dtgvSach.DataSource = SachDAO.Instance.listSach();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            if(rowRemove < 0)
            {
                MessageBox.Show("Không tìm thấy dòng cần xóa");
                return;
            }

            DialogResult res = MessageBox.Show($"Xác nhận xóa sách '{muonsach[rowRemove].tenS}' ra khỏi danh sách ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {
                try
                {
                    muonsach.RemoveAt(rowRemove);
                    dtgvMuon.DataSource = null;
                    dtgvMuon.DataSource = muonsach;
                    MessageBox.Show("Xóa thành công");
                } catch (Exception ex)
                {

                }
            }
        }

        private void dtgvMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowRemove = e.RowIndex;
        }


        private void dtgvSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow slRow = dtgvSach.Rows[e.RowIndex];
            ids = isNullRow(slRow, "IdSach");
            tens = isNullRow(slRow, "TenSach");
            tentacgia = isNullRow(slRow, "TenTacGia");
            if (e.Button == MouseButtons.Right)
            {
                dtgvSach.ClearSelection();
                slRow.Selected = true;
                
                

                ContextMenuStrip contextMenu = new ContextMenuStrip();
                ToolStripMenuItem selectItem = new ToolStripMenuItem("Chọn");
                selectItem.Click += btnChon_Click;

                contextMenu.Items.Add(selectItem);

                Point mousePosition = dtgvSach.PointToClient(Cursor.Position);
                contextMenu.Show(dtgvSach, mousePosition);

            }


            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("* Chọn YES để lưu sách đã chọn và thoát \n* Chọn NO để chọn tiếp", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                this.Close(); 
            }
        }

        private void dtgvMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTKS_Click(object sender, EventArgs e)
        {
            string text = txtTKS.Text;
            string op = cbTKS.SelectedItem.ToString();

            List<Sach> listSach = SachDAO.Instance.timKiemSach(text, op);
            dtgvSach.DataSource = listSach;
        }

        private void selectBookWithContextMenu(object sender, EventArgs e)
        {

        }

        private string isNullRow(DataGridViewRow row, string col)
        {
            return (row.Cells[col] == null ? "" : row.Cells[col].Value.ToString());
        }
    }
}
