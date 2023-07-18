
namespace DoAnLTWF_Code
{
    partial class frmChonSach
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonSach));
            this.panel23 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.pnSearchAdnMethod = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnTKS = new System.Windows.Forms.Panel();
            this.cbTKS = new System.Windows.Forms.ComboBox();
            this.btnTKS = new System.Windows.Forms.Button();
            this.txtTKS = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvMuon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.panel23.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.pnSearchAdnMethod.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnTKS.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMuon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.groupBox4);
            this.panel23.Controls.Add(this.pnSearchAdnMethod);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Padding = new System.Windows.Forms.Padding(10);
            this.panel23.Size = new System.Drawing.Size(476, 436);
            this.panel23.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvSach);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(10, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 328);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dtgvSach
            // 
            this.dtgvSach.AllowUserToAddRows = false;
            this.dtgvSach.AllowUserToDeleteRows = false;
            this.dtgvSach.AllowUserToOrderColumns = true;
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSach.Location = new System.Drawing.Point(3, 19);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.ReadOnly = true;
            this.dtgvSach.RowTemplate.Height = 25;
            this.dtgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSach.Size = new System.Drawing.Size(450, 306);
            this.dtgvSach.TabIndex = 0;
            this.dtgvSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvSach_CellMouseClick);
            // 
            // pnSearchAdnMethod
            // 
            this.pnSearchAdnMethod.Controls.Add(this.groupBox2);
            this.pnSearchAdnMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearchAdnMethod.Location = new System.Drawing.Point(10, 10);
            this.pnSearchAdnMethod.Name = "pnSearchAdnMethod";
            this.pnSearchAdnMethod.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnSearchAdnMethod.Size = new System.Drawing.Size(456, 88);
            this.pnSearchAdnMethod.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnTKS);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 68);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // pnTKS
            // 
            this.pnTKS.Controls.Add(this.cbTKS);
            this.pnTKS.Controls.Add(this.btnTKS);
            this.pnTKS.Controls.Add(this.txtTKS);
            this.pnTKS.Location = new System.Drawing.Point(21, 22);
            this.pnTKS.Name = "pnTKS";
            this.pnTKS.Size = new System.Drawing.Size(377, 39);
            this.pnTKS.TabIndex = 3;
            this.pnTKS.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTKS_Paint);
            // 
            // cbTKS
            // 
            this.cbTKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTKS.FormattingEnabled = true;
            this.cbTKS.Items.AddRange(new object[] {
            "Tác giả",
            "Sách",
            "ID Sách"});
            this.cbTKS.Location = new System.Drawing.Point(3, 9);
            this.cbTKS.Name = "cbTKS";
            this.cbTKS.Size = new System.Drawing.Size(83, 23);
            this.cbTKS.TabIndex = 3;
            // 
            // btnTKS
            // 
            this.btnTKS.Location = new System.Drawing.Point(298, 10);
            this.btnTKS.Name = "btnTKS";
            this.btnTKS.Size = new System.Drawing.Size(75, 23);
            this.btnTKS.TabIndex = 2;
            this.btnTKS.Text = "Tìm kiếm";
            this.btnTKS.UseVisualStyleBackColor = true;
            this.btnTKS.Click += new System.EventHandler(this.btnTKS_Click);
            // 
            // txtTKS
            // 
            this.txtTKS.Location = new System.Drawing.Point(92, 9);
            this.txtTKS.Name = "txtTKS";
            this.txtTKS.Size = new System.Drawing.Size(190, 23);
            this.txtTKS.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(580, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(424, 436);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvMuon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mượn";
            // 
            // dtgvMuon
            // 
            this.dtgvMuon.AllowUserToOrderColumns = true;
            this.dtgvMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMuon.Location = new System.Drawing.Point(3, 19);
            this.dtgvMuon.Name = "dtgvMuon";
            this.dtgvMuon.ReadOnly = true;
            this.dtgvMuon.RowTemplate.Height = 25;
            this.dtgvMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMuon.Size = new System.Drawing.Size(418, 404);
            this.dtgvMuon.TabIndex = 0;
            this.dtgvMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMuon_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnChon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(476, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 436);
            this.panel1.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Image = global::DoAnLTWF_Code.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(10, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Tag = "";
            this.btnSave.Text = "    Lưu và Thoát";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuy.Image = global::DoAnLTWF_Code.Properties.Resources.arrow;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(10, 214);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 23);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Tag = "";
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChon
            // 
            this.btnChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(10, 185);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(88, 23);
            this.btnChon.TabIndex = 0;
            this.btnChon.Tag = "";
            this.btnChon.Text = " Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // frmChonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel23);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "frmChonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonSach";
            this.Load += new System.EventHandler(this.frmChonSach_Load);
            this.panel23.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.pnSearchAdnMethod.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnTKS.ResumeLayout(false);
            this.pnTKS.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.Panel pnSearchAdnMethod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnTKS;
        private System.Windows.Forms.ComboBox cbTKS;
        private System.Windows.Forms.Button btnTKS;
        private System.Windows.Forms.TextBox txtTKS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvMuon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnSave;
    }
}