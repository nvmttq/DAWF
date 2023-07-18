
namespace DoAnLTWF_Code
{
    partial class ExportDST
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
            this.checkedHeader = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedHeader
            // 
            this.checkedHeader.FormattingEnabled = true;
            this.checkedHeader.Items.AddRange(new object[] {
            "Tất Cả",
            "ID Mượn",
            "ID Sách",
            "Số Lượng",
            "Ngày Mượn",
            "Ngày Hẹn Trả",
            "Số Lần Gia Hạn"});
            this.checkedHeader.Location = new System.Drawing.Point(68, 35);
            this.checkedHeader.Name = "checkedHeader";
            this.checkedHeader.Size = new System.Drawing.Size(136, 130);
            this.checkedHeader.TabIndex = 0;
            this.checkedHeader.SelectedValueChanged += new System.EventHandler(this.checkedHeader_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn các cột cần hiển thị";
            // 
            // btnXN
            // 
            this.btnXN.Location = new System.Drawing.Point(42, 179);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(75, 23);
            this.btnXN.TabIndex = 2;
            this.btnXN.Text = "Xác Nhận";
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(149, 179);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ExportDST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 219);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedHeader);
            this.Name = "ExportDST";
            this.Text = "ExportDST";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXN;
        private System.Windows.Forms.Button btnThoat;
    }
}