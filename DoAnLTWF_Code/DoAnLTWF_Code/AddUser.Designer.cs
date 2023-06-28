
namespace DoAnLTWF_Code
{
    partial class AddUser
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbThoiHan = new System.Windows.Forms.ComboBox();
            this.pnMain.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.panel8);
            this.pnMain.Controls.Add(this.btnThoat);
            this.pnMain.Controls.Add(this.btnAdd);
            this.pnMain.Controls.Add(this.panel6);
            this.pnMain.Controls.Add(this.panel5);
            this.pnMain.Controls.Add(this.panel4);
            this.pnMain.Controls.Add(this.panel3);
            this.pnMain.Controls.Add(this.panel2);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(674, 295);
            this.pnMain.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(374, 228);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 55);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 55);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbRole);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(350, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 37);
            this.panel6.TabIndex = 5;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Giảng viên",
            "Sinh Viên",
            "Nhân viên",
            "Bên ngoài"});
            this.cbRole.Location = new System.Drawing.Point(121, 8);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(158, 23);
            this.cbRole.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quyền truy cập :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSDT);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(45, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 37);
            this.panel5.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(121, 8);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(158, 23);
            this.txtSDT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(350, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 37);
            this.panel4.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpBirth);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(45, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 37);
            this.panel3.TabIndex = 2;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(121, 6);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(158, 23);
            this.dtpBirth.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(350, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 37);
            this.panel2.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(121, 8);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(158, 23);
            this.txtLname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 37);
            this.panel1.TabIndex = 0;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(121, 8);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(158, 23);
            this.txtFname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbThoiHan);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(198, 185);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(279, 37);
            this.panel8.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thời hạn :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbThoiHan
            // 
            this.cbThoiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiHan.FormattingEnabled = true;
            this.cbThoiHan.Items.AddRange(new object[] {
            "7",
            "30",
            "999999"});
            this.cbThoiHan.Location = new System.Drawing.Point(128, 7);
            this.cbThoiHan.Name = "cbThoiHan";
            this.cbThoiHan.Size = new System.Drawing.Size(121, 23);
            this.cbThoiHan.TabIndex = 1;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 295);
            this.Controls.Add(this.pnMain);
            this.MaximizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.pnMain.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbThoiHan;
        private System.Windows.Forms.Label label8;
    }
}