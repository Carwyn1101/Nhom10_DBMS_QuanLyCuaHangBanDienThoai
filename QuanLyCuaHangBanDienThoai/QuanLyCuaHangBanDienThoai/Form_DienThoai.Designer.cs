namespace QuanLyCuaHangBanDienThoai
{
    partial class Form_DienThoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DienThoai));
            this.btnChuaBan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvNganKe = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvNhaSanXuat = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.btnTimMa = new System.Windows.Forms.Button();
            this.btnTimTen = new System.Windows.Forms.Button();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiDienThoai = new System.Windows.Forms.DataGridView();
            this.btnDaBan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDienThoai = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.txtNhaSanXuat = new System.Windows.Forms.TextBox();
            this.cbxMaLoaiDienThoai = new System.Windows.Forms.ComboBox();
            this.txtTenLoaiDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNganKe = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDienThoai = new System.Windows.Forms.TextBox();
            this.txtMaDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganKe)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaSanXuat)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDienThoai)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChuaBan
            // 
            this.btnChuaBan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChuaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuaBan.Location = new System.Drawing.Point(828, 779);
            this.btnChuaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChuaBan.Name = "btnChuaBan";
            this.btnChuaBan.Size = new System.Drawing.Size(104, 43);
            this.btnChuaBan.TabIndex = 32;
            this.btnChuaBan.Text = "Chưa bán";
            this.btnChuaBan.UseVisualStyleBackColor = false;
            this.btnChuaBan.Click += new System.EventHandler(this.btnChuaBan_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(708, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(466, 52);
            this.label9.TabIndex = 30;
            this.label9.Text = "Thông tin liên quan";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNganKe
            // 
            this.dgvNganKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNganKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganKe.Location = new System.Drawing.Point(13, 23);
            this.dgvNganKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNganKe.Name = "dgvNganKe";
            this.dgvNganKe.RowHeadersWidth = 51;
            this.dgvNganKe.RowTemplate.Height = 24;
            this.dgvNganKe.Size = new System.Drawing.Size(435, 186);
            this.dgvNganKe.TabIndex = 0;
            this.dgvNganKe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganKe_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.dgvNganKe);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(710, 539);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(465, 228);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ngăn kệ";
            // 
            // dgvNhaSanXuat
            // 
            this.dgvNhaSanXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaSanXuat.Location = new System.Drawing.Point(13, 23);
            this.dgvNhaSanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhaSanXuat.Name = "dgvNhaSanXuat";
            this.dgvNhaSanXuat.RowHeadersWidth = 51;
            this.dgvNhaSanXuat.RowTemplate.Height = 24;
            this.dgvNhaSanXuat.Size = new System.Drawing.Size(435, 160);
            this.dgvNhaSanXuat.TabIndex = 0;
            this.dgvNhaSanXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaSanXuat_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.dgvNhaSanXuat);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(710, 323);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(465, 197);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhà sản xuất";
            // 
            // txtThongTin
            // 
            this.txtThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTin.Location = new System.Drawing.Point(13, 166);
            this.txtThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(191, 32);
            this.txtThongTin.TabIndex = 18;
            // 
            // btnTimMa
            // 
            this.btnTimMa.BackColor = System.Drawing.Color.White;
            this.btnTimMa.FlatAppearance.BorderSize = 0;
            this.btnTimMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa.Image = ((System.Drawing.Image)(resources.GetObject("btnTimMa.Image")));
            this.btnTimMa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimMa.Location = new System.Drawing.Point(499, 165);
            this.btnTimMa.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimMa.Name = "btnTimMa";
            this.btnTimMa.Size = new System.Drawing.Size(159, 34);
            this.btnTimMa.TabIndex = 17;
            this.btnTimMa.Text = "Mã";
            this.btnTimMa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimMa.UseVisualStyleBackColor = false;
            this.btnTimMa.Click += new System.EventHandler(this.btnTimMa_Click);
            // 
            // btnTimTen
            // 
            this.btnTimTen.BackColor = System.Drawing.Color.White;
            this.btnTimTen.FlatAppearance.BorderSize = 0;
            this.btnTimTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTen.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTen.Image")));
            this.btnTimTen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimTen.Location = new System.Drawing.Point(271, 165);
            this.btnTimTen.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimTen.Name = "btnTimTen";
            this.btnTimTen.Size = new System.Drawing.Size(159, 34);
            this.btnTimTen.TabIndex = 16;
            this.btnTimTen.Text = "Tên";
            this.btnTimTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimTen.UseVisualStyleBackColor = false;
            this.btnTimTen.Click += new System.EventHandler(this.btnTimTen_Click);
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(13, 23);
            this.dgvThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.RowTemplate.Height = 24;
            this.dgvThongTin.Size = new System.Drawing.Size(644, 124);
            this.dgvThongTin.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.txtThongTin);
            this.groupBox3.Controls.Add(this.btnTimMa);
            this.groupBox3.Controls.Add(this.btnTimTen);
            this.groupBox3.Controls.Add(this.dgvThongTin);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 603);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(672, 219);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm thông tin";
            // 
            // dgvLoaiDienThoai
            // 
            this.dgvLoaiDienThoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiDienThoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDienThoai.Location = new System.Drawing.Point(13, 25);
            this.dgvLoaiDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoaiDienThoai.Name = "dgvLoaiDienThoai";
            this.dgvLoaiDienThoai.RowHeadersWidth = 51;
            this.dgvLoaiDienThoai.RowTemplate.Height = 24;
            this.dgvLoaiDienThoai.Size = new System.Drawing.Size(435, 185);
            this.dgvLoaiDienThoai.TabIndex = 0;
            this.dgvLoaiDienThoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDienThoai_CellClick);
            // 
            // btnDaBan
            // 
            this.btnDaBan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaBan.Location = new System.Drawing.Point(708, 779);
            this.btnDaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDaBan.Name = "btnDaBan";
            this.btnDaBan.Size = new System.Drawing.Size(88, 43);
            this.btnDaBan.TabIndex = 31;
            this.btnDaBan.Text = "Đã bán";
            this.btnDaBan.UseVisualStyleBackColor = false;
            this.btnDaBan.Click += new System.EventHandler(this.btnDaBan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.dgvLoaiDienThoai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(710, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(465, 222);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại điện thoại";
            // 
            // btnReLoad
            // 
            this.btnReLoad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(964, 779);
            this.btnReLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(91, 43);
            this.btnReLoad.TabIndex = 29;
            this.btnReLoad.Text = "ReLoad";
            this.btnReLoad.UseVisualStyleBackColor = false;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã điện thoại";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(674, 52);
            this.label7.TabIndex = 28;
            this.label7.Text = "Thông tin điện thoại";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(156, 304);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 43);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.dgvDienThoai);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 363);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(672, 226);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách điện thoại";
            // 
            // dgvDienThoai
            // 
            this.dgvDienThoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDienThoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienThoai.Location = new System.Drawing.Point(15, 23);
            this.dgvDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDienThoai.Name = "dgvDienThoai";
            this.dgvDienThoai.RowHeadersWidth = 51;
            this.dgvDienThoai.RowTemplate.Height = 24;
            this.dgvDienThoai.Size = new System.Drawing.Size(644, 187);
            this.dgvDienThoai.TabIndex = 0;
            this.dgvDienThoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDienThoai_CellClick);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.txtNhaSanXuat);
            this.panel.Controls.Add(this.cbxMaLoaiDienThoai);
            this.panel.Controls.Add(this.txtTenLoaiDienThoai);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.txtMaNganKe);
            this.panel.Controls.Add(this.txtGiaTien);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtTenDienThoai);
            this.panel.Controls.Add(this.txtMaDienThoai);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(15, 59);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(671, 228);
            this.panel.TabIndex = 16;
            // 
            // txtNhaSanXuat
            // 
            this.txtNhaSanXuat.Location = new System.Drawing.Point(533, 127);
            this.txtNhaSanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhaSanXuat.Name = "txtNhaSanXuat";
            this.txtNhaSanXuat.Size = new System.Drawing.Size(111, 26);
            this.txtNhaSanXuat.TabIndex = 15;
            // 
            // cbxMaLoaiDienThoai
            // 
            this.cbxMaLoaiDienThoai.FormattingEnabled = true;
            this.cbxMaLoaiDienThoai.Location = new System.Drawing.Point(533, 22);
            this.cbxMaLoaiDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaLoaiDienThoai.Name = "cbxMaLoaiDienThoai";
            this.cbxMaLoaiDienThoai.Size = new System.Drawing.Size(111, 28);
            this.cbxMaLoaiDienThoai.TabIndex = 14;
            // 
            // txtTenLoaiDienThoai
            // 
            this.txtTenLoaiDienThoai.Location = new System.Drawing.Point(533, 74);
            this.txtTenLoaiDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoaiDienThoai.Name = "txtTenLoaiDienThoai";
            this.txtTenLoaiDienThoai.Size = new System.Drawing.Size(111, 26);
            this.txtTenLoaiDienThoai.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tên loại điện thoại";
            // 
            // txtMaNganKe
            // 
            this.txtMaNganKe.Location = new System.Drawing.Point(533, 177);
            this.txtMaNganKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNganKe.Name = "txtMaNganKe";
            this.txtMaNganKe.Size = new System.Drawing.Size(111, 26);
            this.txtMaNganKe.TabIndex = 11;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(115, 121);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(179, 26);
            this.txtGiaTien.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã ngăn kệ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã nhà sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã loại điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá tiền";
            // 
            // txtTenDienThoai
            // 
            this.txtTenDienThoai.Location = new System.Drawing.Point(115, 71);
            this.txtTenDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDienThoai.Name = "txtTenDienThoai";
            this.txtTenDienThoai.Size = new System.Drawing.Size(260, 26);
            this.txtTenDienThoai.TabIndex = 3;
            // 
            // txtMaDienThoai
            // 
            this.txtMaDienThoai.Location = new System.Drawing.Point(115, 22);
            this.txtMaDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDienThoai.Name = "txtMaDienThoai";
            this.txtMaDienThoai.Size = new System.Drawing.Size(113, 26);
            this.txtMaDienThoai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên điện thoại";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(576, 304);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 43);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Location = new System.Drawing.Point(439, 304);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(112, 43);
            this.btnHuyBo.TabIndex = 26;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(1083, 779);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(92, 43);
            this.btnTroVe.TabIndex = 25;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(16, 304);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 43);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(296, 304);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(112, 43);
            this.btnCapNhat.TabIndex = 24;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // Form_DienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 833);
            this.Controls.Add(this.btnChuaBan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDaBan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Name = "Form_DienThoai";
            this.Text = "Điện thoại";
            this.Load += new System.EventHandler(this.Form_DienThoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganKe)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaSanXuat)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDienThoai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChuaBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvNganKe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvNhaSanXuat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button btnTimMa;
        private System.Windows.Forms.Button btnTimTen;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvLoaiDienThoai;
        private System.Windows.Forms.Button btnDaBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDienThoai;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtNhaSanXuat;
        private System.Windows.Forms.ComboBox cbxMaLoaiDienThoai;
        private System.Windows.Forms.TextBox txtTenLoaiDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaNganKe;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDienThoai;
        private System.Windows.Forms.TextBox txtMaDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
    }
}