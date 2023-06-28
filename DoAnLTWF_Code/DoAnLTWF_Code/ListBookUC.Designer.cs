
namespace DoAnLTWF_Code
{
    partial class ListBookUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemCT = new System.Windows.Forms.Button();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.lbIdSach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DoAnLTWF_Code.Properties.Resources.img_small_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(142, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbIdSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXemCT);
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.lbTheLoai);
            this.panel1.Controls.Add(this.lbTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 105);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đánh giá: 5.5";
            // 
            // btnXemCT
            // 
            this.btnXemCT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXemCT.Location = new System.Drawing.Point(0, 76);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(142, 29);
            this.btnXemCT.TabIndex = 3;
            this.btnXemCT.Text = "XEM CHI TIẾT";
            this.btnXemCT.UseVisualStyleBackColor = true;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSoLuong.Location = new System.Drawing.Point(0, 37);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(142, 15);
            this.lbSoLuong.TabIndex = 2;
            this.lbSoLuong.Text = "Còn lại : 100";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoEllipsis = true;
            this.lbTheLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTheLoai.Location = new System.Drawing.Point(0, 21);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(142, 16);
            this.lbTheLoai.TabIndex = 1;
            this.lbTheLoai.Text = "Thể loại : Siêu nhiên, Tình Cảm, Hài hước";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoEllipsis = true;
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(142, 21);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Sách Của Anh";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIdSach
            // 
            this.lbIdSach.AutoSize = true;
            this.lbIdSach.Location = new System.Drawing.Point(114, 52);
            this.lbIdSach.Name = "lbIdSach";
            this.lbIdSach.Size = new System.Drawing.Size(0, 15);
            this.lbIdSach.TabIndex = 5;
            this.lbIdSach.Visible = false;
            // 
            // ListBookUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListBookUC";
            this.Size = new System.Drawing.Size(142, 235);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemCT;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIdSach;
    }
}
