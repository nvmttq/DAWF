using DoAnLTWF_Code.DAO;
using DoAnLTWF_Code.DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTWF_Code
{
    public partial class AddMutiBook : Form
    {
        public int complete = 0;
        public List<Sach> dsExcel = new List<Sach>();
        public AddMutiBook()
        {
            InitializeComponent();
        }

        private void btnDataEX_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "mauThemSach.xlsx";
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string a = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mauThemSach.xlsx";
                string filePath = saveFileDialog.FileName;
                
                using (ExcelPackage p = new ExcelPackage(new FileInfo(a)))
                {
                    try
                    {
                        Byte[] bin = p.GetAsByteArray();
                        File.WriteAllBytes(filePath, bin);
                        MessageBox.Show($"Check Directory fllowing : \n {filePath}");
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            List<Sach> sachList = new List<Sach>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
            //    MessageBox.Show(filePath);

                ExcelPackage p = new ExcelPackage(new FileInfo(filePath));

                ExcelWorksheet ws = p.Workbook.Worksheets[1];

                for(int i = ws.Dimension.Start.Row+1; i <= ws.Dimension.End.Row; i++)
                {
                    try
                    {
                      //  MessageBox.Show(ws.Cells[i,1].Value.ToString());
                        Sach s = new Sach(ws,i,1);
                        SachDAO.Instance.addBookWithExcel(s);
                        dsExcel.Add(s);
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                complete = 1;
                MessageBox.Show($"SUCESS ADDING ALL DATA FROM EXCEL IN DIRECTORY \n \n{filePath}");
            }
        }
    }
}
