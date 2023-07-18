
namespace DoAnLTWF_Code
{
    partial class frmts
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
            this.TabMain = new System.Windows.Forms.TabControl();
            this.DkMs = new System.Windows.Forms.TabPage();
            this.DanhSachMuon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonSach = new System.Windows.Forms.Button();
            this.btnSuaS = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.lbM = new System.Windows.Forms.Label();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTacgia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTensach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSoluong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTKIDTHE = new System.Windows.Forms.Button();
            this.tbIdThe = new System.Windows.Forms.TextBox();
            this.dtpHantra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTendg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.dsm = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TabMain.SuspendLayout();
            this.DkMs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMuon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.DkMs);
            this.TabMain.Controls.Add(this.dsm);
            this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMain.Location = new System.Drawing.Point(0, 0);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(924, 599);
            this.TabMain.TabIndex = 0;
            // 
            // DkMs
            // 
            this.DkMs.Controls.Add(this.DanhSachMuon);
            this.DkMs.Controls.Add(this.panel1);
            this.DkMs.Controls.Add(this.groupBox2);
            this.DkMs.Controls.Add(this.groupBox1);
            this.DkMs.Location = new System.Drawing.Point(4, 24);
            this.DkMs.Name = "DkMs";
            this.DkMs.Padding = new System.Windows.Forms.Padding(3);
            this.DkMs.Size = new System.Drawing.Size(916, 571);
            this.DkMs.TabIndex = 0;
            this.DkMs.Text = "Đăng ký mượn sách";
            this.DkMs.UseVisualStyleBackColor = true;
            // 
            // DanhSachMuon
            // 
            this.DanhSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DanhSachMuon.Location = new System.Drawing.Point(223, 321);
            this.DanhSachMuon.Name = "DanhSachMuon";
            this.DanhSachMuon.ReadOnly = true;
            this.DanhSachMuon.RowTemplate.Height = 25;
            this.DanhSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DanhSachMuon.Size = new System.Drawing.Size(690, 247);
            this.DanhSachMuon.TabIndex = 28;
            this.DanhSachMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhSachMuon_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonSach);
            this.panel1.Controls.Add(this.btnSuaS);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnSaveEdit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 247);
            this.panel1.TabIndex = 27;
            // 
            // btnChonSach
            // 
            this.btnChonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChonSach.Location = new System.Drawing.Point(8, 34);
            this.btnChonSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChonSach.Name = "btnChonSach";
            this.btnChonSach.Size = new System.Drawing.Size(94, 40);
            this.btnChonSach.TabIndex = 18;
            this.btnChonSach.Text = "Chọn/ Hủy  sách";
            this.btnChonSach.UseVisualStyleBackColor = true;
            this.btnChonSach.Click += new System.EventHandler(this.btnChonSach_Click);
            // 
            // btnSuaS
            // 
            this.btnSuaS.Location = new System.Drawing.Point(108, 34);
            this.btnSuaS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaS.Name = "btnSuaS";
            this.btnSuaS.Size = new System.Drawing.Size(94, 40);
            this.btnSuaS.TabIndex = 22;
            this.btnSuaS.Text = "Sửa";
            this.btnSuaS.UseVisualStyleBackColor = true;
            this.btnSuaS.Click += new System.EventHandler(this.btnSuaS_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(108, 146);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 40);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(108, 90);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(94, 40);
            this.btnSaveEdit.TabIndex = 25;
            this.btnSaveEdit.Text = "Lưu chỉnh sửa";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 90);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 40);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu Phiếu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaMuon);
            this.groupBox2.Controls.Add(this.lbM);
            this.groupBox2.Controls.Add(this.btnGiaHan);
            this.groupBox2.Controls.Add(this.btnTraSach);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTacgia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbTensach);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbSoluong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(910, 155);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.Enabled = false;
            this.txtMaMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaMuon.Location = new System.Drawing.Point(108, 108);
            this.txtMaMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.Size = new System.Drawing.Size(112, 26);
            this.txtMaMuon.TabIndex = 25;
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbM.Location = new System.Drawing.Point(14, 108);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(79, 20);
            this.lbM.TabIndex = 24;
            this.lbM.Text = "Mã CTM:";
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiaHan.Location = new System.Drawing.Point(777, 108);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(90, 42);
            this.btnGiaHan.TabIndex = 23;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTraSach.Location = new System.Drawing.Point(672, 108);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(90, 42);
            this.btnTraSach.TabIndex = 22;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaSach.Location = new System.Drawing.Point(108, 31);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(112, 26);
            this.txtMaSach.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách:";
            // 
            // tbTacgia
            // 
            this.tbTacgia.Enabled = false;
            this.tbTacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTacgia.Location = new System.Drawing.Point(510, 31);
            this.tbTacgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTacgia.Name = "tbTacgia";
            this.tbTacgia.Size = new System.Drawing.Size(224, 26);
            this.tbTacgia.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên sách:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(397, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tên Tác giả:";
            // 
            // tbTensach
            // 
            this.tbTensach.Enabled = false;
            this.tbTensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTensach.Location = new System.Drawing.Point(108, 69);
            this.tbTensach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTensach.Name = "tbTensach";
            this.tbTensach.Size = new System.Drawing.Size(253, 26);
            this.tbTensach.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(397, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Số lượng sách mượn:";
            // 
            // tbSoluong
            // 
            this.tbSoluong.Enabled = false;
            this.tbSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSoluong.Location = new System.Drawing.Point(580, 69);
            this.tbSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoluong.Name = "tbSoluong";
            this.tbSoluong.Size = new System.Drawing.Size(154, 26);
            this.tbSoluong.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTKIDTHE);
            this.groupBox1.Controls.Add(this.tbIdThe);
            this.groupBox1.Controls.Add(this.dtpHantra);
            this.groupBox1.Controls.Add(this.dtpNgaymuon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTendg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(910, 163);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnTKIDTHE
            // 
            this.btnTKIDTHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTKIDTHE.Location = new System.Drawing.Point(246, 36);
            this.btnTKIDTHE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTKIDTHE.Name = "btnTKIDTHE";
            this.btnTKIDTHE.Size = new System.Drawing.Size(90, 31);
            this.btnTKIDTHE.TabIndex = 21;
            this.btnTKIDTHE.Text = "Tìm kiếm";
            this.btnTKIDTHE.UseVisualStyleBackColor = true;
            this.btnTKIDTHE.Click += new System.EventHandler(this.btnTKIDTHE_Click);
            // 
            // tbIdThe
            // 
            this.tbIdThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIdThe.Location = new System.Drawing.Point(95, 38);
            this.tbIdThe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIdThe.Name = "tbIdThe";
            this.tbIdThe.Size = new System.Drawing.Size(145, 26);
            this.tbIdThe.TabIndex = 2;
            // 
            // dtpHantra
            // 
            this.dtpHantra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHantra.Location = new System.Drawing.Point(544, 122);
            this.dtpHantra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHantra.Name = "dtpHantra";
            this.dtpHantra.Size = new System.Drawing.Size(270, 23);
            this.dtpHantra.TabIndex = 15;
            // 
            // dtpNgaymuon
            // 
            this.dtpNgaymuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgaymuon.Location = new System.Drawing.Point(544, 83);
            this.dtpNgaymuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaymuon.Name = "dtpNgaymuon";
            this.dtpNgaymuon.Size = new System.Drawing.Size(270, 23);
            this.dtpNgaymuon.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số thẻ : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(412, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày hẹn trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên thành viên:";
            // 
            // tbTendg
            // 
            this.tbTendg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTendg.Location = new System.Drawing.Point(152, 93);
            this.tbTendg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTendg.Name = "tbTendg";
            this.tbTendg.Size = new System.Drawing.Size(154, 26);
            this.tbTendg.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(412, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(412, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Mượn:";
            // 
            // tbSdt
            // 
            this.tbSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSdt.Location = new System.Drawing.Point(544, 38);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(154, 26);
            this.tbSdt.TabIndex = 1;
            // 
            // dsm
            // 
            this.dsm.Location = new System.Drawing.Point(4, 24);
            this.dsm.Name = "dsm";
            this.dsm.Padding = new System.Windows.Forms.Padding(3);
            this.dsm.Size = new System.Drawing.Size(916, 571);
            this.dsm.TabIndex = 1;
            this.dsm.Text = "Danh Sách Mượn";
            this.dsm.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUser,
            this.mnuInfo,
            this.mnuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuUser
            // 
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(78, 20);
            this.mnuUser.Text = "Hello, user!";
            // 
            // mnuInfo
            // 
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(115, 20);
            this.mnuInfo.Text = "Thông tin cá nhân";
            this.mnuInfo.Click += new System.EventHandler(this.mnuInfo_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(73, 20);
            this.mnuLogout.Text = "Đăng xuất";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TabMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 599);
            this.panel2.TabIndex = 15;
            // 
            // frmts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmts";
            this.Text = "Quản Thư";
            this.Load += new System.EventHandler(this.frmts_Load);
            this.TabMain.ResumeLayout(false);
            this.DkMs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage DkMs;
        private System.Windows.Forms.TabPage dsm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTKIDTHE;
        private System.Windows.Forms.TextBox tbIdThe;
        private System.Windows.Forms.DateTimePicker dtpHantra;
        private System.Windows.Forms.DateTimePicker dtpNgaymuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTendg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTacgia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTensach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSoluong;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChonSach;
        private System.Windows.Forms.Button btnSuaS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.DataGridView DanhSachMuon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.Panel panel2;
    }
}