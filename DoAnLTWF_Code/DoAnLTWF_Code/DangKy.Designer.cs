
namespace DoAnLTWF_Code
{
    partial class frmDangKy
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbValWho = new System.Windows.Forms.Label();
            this.cbWho = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnHoTen = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbValTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbValHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lbHo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbValTH = new System.Windows.Forms.Label();
            this.cbThoiHan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbValMK2 = new System.Windows.Forms.Label();
            this.txtMatKhau2 = new System.Windows.Forms.TextBox();
            this.lbMatKhau2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbValMK = new System.Windows.Forms.Label();
            this.txtMatKhau1 = new System.Windows.Forms.TextBox();
            this.lbMatKhau1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAutoTK = new System.Windows.Forms.Button();
            this.lbValTK = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnHoTen.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.pnHoTen);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(517, 492);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbValWho);
            this.panel9.Controls.Add(this.cbWho);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(263, 350);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(190, 50);
            this.panel9.TabIndex = 5;
            // 
            // lbValWho
            // 
            this.lbValWho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbValWho.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbValWho.ForeColor = System.Drawing.Color.Red;
            this.lbValWho.Location = new System.Drawing.Point(0, 27);
            this.lbValWho.Name = "lbValWho";
            this.lbValWho.Size = new System.Drawing.Size(190, 23);
            this.lbValWho.TabIndex = 3;
            this.lbValWho.Text = "Không được để trống";
            this.lbValWho.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbValWho.Visible = false;
            // 
            // cbWho
            // 
            this.cbWho.DisplayMember = "0";
            this.cbWho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWho.FormattingEnabled = true;
            this.cbWho.Items.AddRange(new object[] {
            "Sinh Viên",
            "Giảng Viên",
            "Khác"});
            this.cbWho.Location = new System.Drawing.Point(75, 3);
            this.cbWho.Name = "cbWho";
            this.cbWho.Size = new System.Drawing.Size(115, 23);
            this.cbWho.TabIndex = 1;
            this.cbWho.Tag = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bạn là :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnHoTen
            // 
            this.pnHoTen.Controls.Add(this.panel8);
            this.pnHoTen.Controls.Add(this.panel7);
            this.pnHoTen.Location = new System.Drawing.Point(50, 96);
            this.pnHoTen.Name = "pnHoTen";
            this.pnHoTen.Size = new System.Drawing.Size(400, 56);
            this.pnHoTen.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbValTen);
            this.panel8.Controls.Add(this.txtTen);
            this.panel8.Controls.Add(this.lbTen);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(213, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(187, 56);
            this.panel8.TabIndex = 3;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // lbValTen
            // 
            this.lbValTen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbValTen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbValTen.ForeColor = System.Drawing.Color.Red;
            this.lbValTen.Location = new System.Drawing.Point(0, 33);
            this.lbValTen.Name = "lbValTen";
            this.lbValTen.Size = new System.Drawing.Size(187, 23);
            this.lbValTen.TabIndex = 3;
            this.lbValTen.Text = "Không được để trống";
            this.lbValTen.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbValTen.Visible = false;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(72, 7);
            this.txtTen.Name = "txtTen";
            this.txtTen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTen.Size = new System.Drawing.Size(115, 23);
            this.txtTen.TabIndex = 1;
            // 
            // lbTen
            // 
            this.lbTen.Location = new System.Drawing.Point(0, 9);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(69, 23);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Tên :";
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbValHo);
            this.panel7.Controls.Add(this.txtHo);
            this.panel7.Controls.Add(this.lbHo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 56);
            this.panel7.TabIndex = 2;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // lbValHo
            // 
            this.lbValHo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbValHo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbValHo.ForeColor = System.Drawing.Color.Red;
            this.lbValHo.Location = new System.Drawing.Point(0, 33);
            this.lbValHo.Name = "lbValHo";
            this.lbValHo.Size = new System.Drawing.Size(190, 23);
            this.lbValHo.TabIndex = 3;
            this.lbValHo.Text = "Không được để trống";
            this.lbValHo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbValHo.Visible = false;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(75, 9);
            this.txtHo.Name = "txtHo";
            this.txtHo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHo.Size = new System.Drawing.Size(115, 23);
            this.txtHo.TabIndex = 1;
            // 
            // lbHo
            // 
            this.lbHo.Location = new System.Drawing.Point(0, 9);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(69, 23);
            this.lbHo.TabIndex = 0;
            this.lbHo.Text = "Họ : ";
            this.lbHo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbValTH);
            this.panel6.Controls.Add(this.cbThoiHan);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(50, 350);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 50);
            this.panel6.TabIndex = 4;
            // 
            // lbValTH
            // 
            this.lbValTH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbValTH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbValTH.ForeColor = System.Drawing.Color.Red;
            this.lbValTH.Location = new System.Drawing.Point(0, 27);
            this.lbValTH.Name = "lbValTH";
            this.lbValTH.Size = new System.Drawing.Size(190, 23);
            this.lbValTH.TabIndex = 3;
            this.lbValTH.Text = "Không được để trống";
            this.lbValTH.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbValTH.Visible = false;
            // 
            // cbThoiHan
            // 
            this.cbThoiHan.DisplayMember = "0";
            this.cbThoiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiHan.FormattingEnabled = true;
            this.cbThoiHan.Items.AddRange(new object[] {
            "Tuần",
            "Tháng",
            "Năm"});
            this.cbThoiHan.Location = new System.Drawing.Point(75, 3);
            this.cbThoiHan.Name = "cbThoiHan";
            this.cbThoiHan.Size = new System.Drawing.Size(115, 23);
            this.cbThoiHan.TabIndex = 1;
            this.cbThoiHan.Tag = "";
            this.cbThoiHan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời hạn :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbValMK2);
            this.panel5.Controls.Add(this.txtMatKhau2);
            this.panel5.Controls.Add(this.lbMatKhau2);
            this.panel5.Location = new System.Drawing.Point(50, 273);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 63);
            this.panel5.TabIndex = 3;
            // 
            // lbValMK2
            // 
            this.lbValMK2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbValMK2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbValMK2.ForeColor = System.Drawing.Color.Red;
            this.lbValMK2.Location = new System.Drawing.Point(0, 40);
            this.lbValMK2.Name = "lbValMK2";
            this.lbValMK2.Size = new System.Drawing.Size(400, 23);
            this.lbValMK2.TabIndex = 2;
            this.lbValMK2.Text = "Không được để trống";
            this.lbValMK2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbValMK2.Visible = false;
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Location = new System.Drawing.Point(128, 9);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMatKhau2.Size = new System.Drawing.Size(272, 23);
            this.txtMatKhau2.TabIndex = 1;
            // 
            // lbMatKhau2
            // 
            this.lbMatKhau2.Location = new System.Drawing.Point(0, 9);
            this.lbMatKhau2.Name = "lbMatKhau2";
            this.lbMatKhau2.Size = new System.Drawing.Size(111, 23);
            this.lbMatKhau2.TabIndex = 0;
            this.lbMatKhau2.Text = "Nhập lại mật khẩu :";
            this.lbMatKhau2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDangKy);
            this.panel3.Controls.Add(this.btnDangNhap);
            this.panel3.Location = new System.Drawing.Point(165, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 34);
            this.panel3.TabIndex = 3;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDangKy.Location = new System.Drawing.Point(125, 0);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 34);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDangNhap.Location = new System.Drawing.Point(0, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 34);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbValMK);
            this.panel2.Controls.Add(this.txtMatKhau1);
            this.panel2.Controls.Add(this.lbMatKhau1);
            this.panel2.Location = new System.Drawing.Point(50, 214);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 56);
            this.panel2.TabIndex = 2;
            // 
            // lbValMK
            // 
            this.lbValMK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbValMK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbValMK.ForeColor = System.Drawing.Color.Red;
            this.lbValMK.Location = new System.Drawing.Point(0, 33);
            this.lbValMK.Name = "lbValMK";
            this.lbValMK.Size = new System.Drawing.Size(400, 23);
            this.lbValMK.TabIndex = 3;
            this.lbValMK.Text = "Không được để trống";
            this.lbValMK.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbValMK.Visible = false;
            // 
            // txtMatKhau1
            // 
            this.txtMatKhau1.Location = new System.Drawing.Point(128, 10);
            this.txtMatKhau1.Name = "txtMatKhau1";
            this.txtMatKhau1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMatKhau1.Size = new System.Drawing.Size(272, 23);
            this.txtMatKhau1.TabIndex = 1;
            // 
            // lbMatKhau1
            // 
            this.lbMatKhau1.Location = new System.Drawing.Point(0, 10);
            this.lbMatKhau1.Name = "lbMatKhau1";
            this.lbMatKhau1.Size = new System.Drawing.Size(69, 23);
            this.lbMatKhau1.TabIndex = 0;
            this.lbMatKhau1.Text = "Mật khẩu : ";
            this.lbMatKhau1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAutoTK);
            this.panel1.Controls.Add(this.lbValTK);
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Controls.Add(this.lbTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(50, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnAutoTK
            // 
            this.btnAutoTK.Location = new System.Drawing.Point(309, 9);
            this.btnAutoTK.Name = "btnAutoTK";
            this.btnAutoTK.Size = new System.Drawing.Size(88, 23);
            this.btnAutoTK.TabIndex = 4;
            this.btnAutoTK.Text = "Tạo tự động";
            this.btnAutoTK.UseVisualStyleBackColor = true;
            this.btnAutoTK.Click += new System.EventHandler(this.btnAutoTK_Click);
            // 
            // lbValTK
            // 
            this.lbValTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbValTK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbValTK.ForeColor = System.Drawing.Color.Red;
            this.lbValTK.Location = new System.Drawing.Point(0, 33);
            this.lbValTK.Name = "lbValTK";
            this.lbValTK.Size = new System.Drawing.Size(400, 23);
            this.lbValTK.TabIndex = 3;
            this.lbValTK.Text = "Không được để trống";
            this.lbValTK.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbValTK.Visible = false;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(128, 9);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTaiKhoan.Size = new System.Drawing.Size(175, 23);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(69, 33);
            this.lbTaiKhoan.TabIndex = 0;
            this.lbTaiKhoan.Text = "Tài khoản :";
            this.lbTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 492);
            this.Controls.Add(this.panel4);
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnHoTen.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbThoiHan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMatKhau2;
        private System.Windows.Forms.Label lbMatKhau2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMatKhau1;
        private System.Windows.Forms.Label lbMatKhau1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnHoTen;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbValTen;
        private System.Windows.Forms.Label lbValHo;
        private System.Windows.Forms.Label lbValTH;
        private System.Windows.Forms.Label lbValMK2;
        private System.Windows.Forms.Label lbValMK;
        private System.Windows.Forms.Button btnAutoTK;
        private System.Windows.Forms.Label lbValTK;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbValWho;
        private System.Windows.Forms.ComboBox cbWho;
        private System.Windows.Forms.Label label4;
    }
}