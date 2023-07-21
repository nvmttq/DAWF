
namespace DoAnLTWF_Code
{
    partial class ChonSLTra
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnXN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng : ";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(99, 29);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 23);
            this.txtSL.TabIndex = 1;
            this.txtSL.Text = "1";
            // 
            // btnXN
            // 
            this.btnXN.Location = new System.Drawing.Point(30, 68);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(77, 29);
            this.btnXN.TabIndex = 2;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(122, 68);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(77, 29);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ChonSLTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 109);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ChonSLTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonSLTra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button btnXN;
        private System.Windows.Forms.Button btnThoat;
    }
}