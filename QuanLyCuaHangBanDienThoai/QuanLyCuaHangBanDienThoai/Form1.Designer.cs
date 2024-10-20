namespace QuanLyCuaHangBanDienThoai
{
    partial class Form1
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MaNSX = new System.Windows.Forms.TextBox();
            this.txt_TenQG = new System.Windows.Forms.TextBox();
            this.txt_TenNSX = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dtGV_NSX = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_NSX)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(32, 366);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(185, 60);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_MaNSX
            // 
            this.txt_MaNSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNSX.Location = new System.Drawing.Point(67, 80);
            this.txt_MaNSX.Name = "txt_MaNSX";
            this.txt_MaNSX.Size = new System.Drawing.Size(325, 22);
            this.txt_MaNSX.TabIndex = 1;
            // 
            // txt_TenQG
            // 
            this.txt_TenQG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenQG.Location = new System.Drawing.Point(67, 278);
            this.txt_TenQG.Name = "txt_TenQG";
            this.txt_TenQG.Size = new System.Drawing.Size(325, 22);
            this.txt_TenQG.TabIndex = 4;
            // 
            // txt_TenNSX
            // 
            this.txt_TenNSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNSX.Location = new System.Drawing.Point(67, 176);
            this.txt_TenNSX.Name = "txt_TenNSX";
            this.txt_TenNSX.Size = new System.Drawing.Size(325, 22);
            this.txt_TenNSX.TabIndex = 5;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(289, 366);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(185, 60);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(537, 366);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(185, 60);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // dtGV_NSX
            // 
            this.dtGV_NSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_NSX.Location = new System.Drawing.Point(430, 47);
            this.dtGV_NSX.Name = "dtGV_NSX";
            this.dtGV_NSX.RowHeadersWidth = 51;
            this.dtGV_NSX.RowTemplate.Height = 24;
            this.dtGV_NSX.Size = new System.Drawing.Size(341, 264);
            this.dtGV_NSX.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "MaNSX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "TenQG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "TenNSX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGV_NSX);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txt_TenNSX);
            this.Controls.Add(this.txt_TenQG);
            this.Controls.Add(this.txt_MaNSX);
            this.Controls.Add(this.btn_Them);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_NSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_MaNSX;
        private System.Windows.Forms.TextBox txt_TenQG;
        private System.Windows.Forms.TextBox txt_TenNSX;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dtGV_NSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

