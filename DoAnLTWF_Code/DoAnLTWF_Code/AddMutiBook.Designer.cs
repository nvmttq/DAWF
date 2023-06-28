
namespace DoAnLTWF_Code
{
    partial class AddMutiBook
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
            this.btnDataEX = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDataEX
            // 
            this.btnDataEX.Location = new System.Drawing.Point(109, 23);
            this.btnDataEX.Name = "btnDataEX";
            this.btnDataEX.Size = new System.Drawing.Size(171, 45);
            this.btnDataEX.TabIndex = 0;
            this.btnDataEX.Text = "TẢI DỮ LIỆU MẪU";
            this.btnDataEX.UseVisualStyleBackColor = true;
            this.btnDataEX.Click += new System.EventHandler(this.btnDataEX_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(109, 74);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(171, 45);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "CHỌN FILE TỪ MÁY";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "LƯU Ý : Chọn file Excel , có dạng .xlsx";
            // 
            // AddMutiBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDataEX);
            this.Name = "AddMutiBook";
            this.Text = "AddMutiBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDataEX;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
    }
}