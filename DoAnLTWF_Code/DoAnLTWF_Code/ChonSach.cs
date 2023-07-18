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
        private int max_soLuong = 0;
        private string ids, tentacgia, tens;
        public List<ChiTietSachMuon> muonsach = new List<ChiTietSachMuon>();
        private int current_row_choose = -1;
        private string idThe = "";
        public frmChonSach(List<ChiTietSachMuon> list, string idAccNeed)
        {
            InitializeComponent();
            cbTKS.SelectedIndex = 0;
            muonsach = list;
            if(muonsach.Count > 0)
            {
                dtgvMuon.DataSource = muonsach;
                dtgvMuon.Columns["idCTM"].Visible = false;
                dtgvMuon.Columns["idMuon"].Visible = false;
            }
            idThe = idAccNeed;
            max_soLuong = ListMuonDAO.Instance.countSachMuon(list);
            
        }

        private void pnTKS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int id = -1;
            for (int i = 0; i < muonsach.Count; i++)
            {
                if(muonsach[i].idSach == ids)
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
           
            back_Exception:
            
            if(cl.ShowDialog()== DialogResult.OK)
            {
                soLuong = cl.soLuong;
                if(max_soLuong + soLuong > 3)
                {
                    MessageBox.Show("Tổng sách mượn không được vượt quá 3");
                    goto back_Exception;
                }
                int remaning = SachDAO.Instance.soLuongSachConLai(ids);
                if (soLuong > remaning)
                {
                    MessageBox.Show($"Số sách còn lại không đủ !\nSố sách còn lại là: {remaning}");
                    goto back_Exception;
                }
                max_soLuong += soLuong;
                ChiTietSachMuon tmp = new ChiTietSachMuon(ids, soLuong);
                muonsach.Add(tmp);
                dtgvMuon.DataSource = null;
                dtgvMuon.DataSource = muonsach;
                dtgvMuon.Columns["idCTM"].Visible = false;
                dtgvMuon.Columns["idMuon"].Visible = false;
            }

          
        }

        private void frmChonSach_Load(object sender, EventArgs e)
        {
          
            dtgvSach.DataSource = SachDAO.Instance.listSach();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            if(current_row_choose < 0)
            {
                MessageBox.Show("Không tìm thấy dòng cần xóa");
                return;
            }

            DialogResult res = MessageBox.Show($"Xác nhận xóa sách ra khỏi danh sách ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {
                try
                {
                    muonsach.RemoveAt(current_row_choose);
                    dtgvMuon.DataSource = null;
                    dtgvMuon.DataSource = muonsach;
                    dtgvMuon.Columns["idCTM"].Visible = false;
                    dtgvMuon.Columns["idMuon"].Visible = false;
                    MessageBox.Show("Xóa thành công");
                } catch (Exception ex)
                {

                }
            }
        }

        private void dtgvMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            current_row_choose = e.RowIndex;
        }


        private void dtgvSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow slRow = dtgvSach.Rows[e.RowIndex];
            ids = isNullRow(slRow, "idSach");
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
