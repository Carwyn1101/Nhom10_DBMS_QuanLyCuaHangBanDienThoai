namespace QuanLyCuaHangBanDienThoai
{
    partial class Form_Nhap
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
            this.btnHoaDonNhap = new System.Windows.Forms.Button();
            this.btnChiTietHDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.Location = new System.Drawing.Point(36, 27);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(232, 62);
            this.btnHoaDonNhap.TabIndex = 0;
            this.btnHoaDonNhap.Text = "Hóa đơn nhập";
            this.btnHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // btnChiTietHDN
            // 
            this.btnChiTietHDN.Location = new System.Drawing.Point(321, 27);
            this.btnChiTietHDN.Name = "btnChiTietHDN";
            this.btnChiTietHDN.Size = new System.Drawing.Size(232, 58);
            this.btnChiTietHDN.TabIndex = 1;
            this.btnChiTietHDN.Text = "Chi tiết hóa đơn";
            this.btnChiTietHDN.UseVisualStyleBackColor = true;
            this.btnChiTietHDN.Click += new System.EventHandler(this.btnChiTietHDN_Click);
            // 
            // Form_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 112);
            this.Controls.Add(this.btnChiTietHDN);
            this.Controls.Add(this.btnHoaDonNhap);
            this.Name = "Form_Nhap";
            this.Text = "Danh sách hóa đơn nhập";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHoaDonNhap;
        private System.Windows.Forms.Button btnChiTietHDN;
    }
}