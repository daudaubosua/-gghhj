namespace QuanLyGiaoVien7
{
    partial class frmQuanLyHoatDongGiaoVien7
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.gbChuyenGiaoCongNghe = new System.Windows.Forms.GroupBox();
            this.cmbgiaovienma = new System.Windows.Forms.ComboBox();
            this.txtdoanhthu = new System.Windows.Forms.TextBox();
            this.dtpngaynhan = new System.Windows.Forms.DateTimePicker();
            this.dtpthoigian = new System.Windows.Forms.DateTimePicker();
            this.txtma = new System.Windows.Forms.TextBox();
            this.lblthoigian = new System.Windows.Forms.Label();
            this.lbldoanhthu = new System.Windows.Forms.Label();
            this.lblngaynhan = new System.Windows.Forms.Label();
            this.lblgiaovienma = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.dgvchuyengiaocongnghe = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.gbtimkiem = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.gbChuyenGiaoCongNghe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchuyengiaocongnghe)).BeginInit();
            this.gbtimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTieuDe.Location = new System.Drawing.Point(170, -1);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(393, 31);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Quản Lý Hoạt Động Giáo Viên7";
            // 
            // gbChuyenGiaoCongNghe
            // 
            this.gbChuyenGiaoCongNghe.Controls.Add(this.cmbgiaovienma);
            this.gbChuyenGiaoCongNghe.Controls.Add(this.txtdoanhthu);
            this.gbChuyenGiaoCongNghe.Controls.Add(this.dtpngaynhan);
            this.gbChuyenGiaoCongNghe.Controls.Add(this.dtpthoigian);
            this.gbChuyenGiaoCongNghe.Controls.Add(this.txtma);
            this.gbChuyenGiaoCongNghe.Controls.Add(this.lblthoigian);
            this.gbChuyenGiaoCongNghe.Controls.Add(this.lbldoanhthu);
            this.gbChuyenGiaoCongNghe.Controls.Add(this.lblngaynhan);
            this.gbChuyenGiaoCongNghe.Controls.Add(this.lblgiaovienma);
            this.gbChuyenGiaoCongNghe.Controls.Add(this.lblma);
            this.gbChuyenGiaoCongNghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChuyenGiaoCongNghe.ForeColor = System.Drawing.Color.Olive;
            this.gbChuyenGiaoCongNghe.Location = new System.Drawing.Point(12, 33);
            this.gbChuyenGiaoCongNghe.Name = "gbChuyenGiaoCongNghe";
            this.gbChuyenGiaoCongNghe.Size = new System.Drawing.Size(742, 131);
            this.gbChuyenGiaoCongNghe.TabIndex = 1;
            this.gbChuyenGiaoCongNghe.TabStop = false;
            this.gbChuyenGiaoCongNghe.Text = "Chuyển Giao Công Nghệ";
            // 
            // cmbgiaovienma
            // 
            this.cmbgiaovienma.FormattingEnabled = true;
            this.cmbgiaovienma.Location = new System.Drawing.Point(115, 61);
            this.cmbgiaovienma.Name = "cmbgiaovienma";
            this.cmbgiaovienma.Size = new System.Drawing.Size(224, 28);
            this.cmbgiaovienma.TabIndex = 12;
            // 
            // txtdoanhthu
            // 
            this.txtdoanhthu.Location = new System.Drawing.Point(477, 32);
            this.txtdoanhthu.Name = "txtdoanhthu";
            this.txtdoanhthu.Size = new System.Drawing.Size(234, 26);
            this.txtdoanhthu.TabIndex = 11;
            // 
            // dtpngaynhan
            // 
            this.dtpngaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaynhan.Location = new System.Drawing.Point(115, 98);
            this.dtpngaynhan.Name = "dtpngaynhan";
            this.dtpngaynhan.Size = new System.Drawing.Size(224, 26);
            this.dtpngaynhan.TabIndex = 10;
            // 
            // dtpthoigian
            // 
            this.dtpthoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpthoigian.Location = new System.Drawing.Point(477, 64);
            this.dtpthoigian.Name = "dtpthoigian";
            this.dtpthoigian.Size = new System.Drawing.Size(234, 26);
            this.dtpthoigian.TabIndex = 9;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(115, 28);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(224, 26);
            this.txtma.TabIndex = 5;
            // 
            // lblthoigian
            // 
            this.lblthoigian.AutoSize = true;
            this.lblthoigian.ForeColor = System.Drawing.Color.Black;
            this.lblthoigian.Location = new System.Drawing.Point(373, 69);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(77, 20);
            this.lblthoigian.TabIndex = 4;
            this.lblthoigian.Text = "Thời Gian";
            // 
            // lbldoanhthu
            // 
            this.lbldoanhthu.AutoSize = true;
            this.lbldoanhthu.ForeColor = System.Drawing.Color.Black;
            this.lbldoanhthu.Location = new System.Drawing.Point(373, 31);
            this.lbldoanhthu.Name = "lbldoanhthu";
            this.lbldoanhthu.Size = new System.Drawing.Size(88, 20);
            this.lbldoanhthu.TabIndex = 3;
            this.lbldoanhthu.Text = "Doanh Thu";
            // 
            // lblngaynhan
            // 
            this.lblngaynhan.AutoSize = true;
            this.lblngaynhan.ForeColor = System.Drawing.Color.Black;
            this.lblngaynhan.Location = new System.Drawing.Point(0, 103);
            this.lblngaynhan.Name = "lblngaynhan";
            this.lblngaynhan.Size = new System.Drawing.Size(87, 20);
            this.lblngaynhan.TabIndex = 2;
            this.lblngaynhan.Text = "Ngày Nhận";
            // 
            // lblgiaovienma
            // 
            this.lblgiaovienma.AutoSize = true;
            this.lblgiaovienma.ForeColor = System.Drawing.Color.Black;
            this.lblgiaovienma.Location = new System.Drawing.Point(0, 64);
            this.lblgiaovienma.Name = "lblgiaovienma";
            this.lblgiaovienma.Size = new System.Drawing.Size(105, 20);
            this.lblgiaovienma.TabIndex = 1;
            this.lblgiaovienma.Text = "Mã Giáo Viên";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.ForeColor = System.Drawing.Color.Black;
            this.lblma.Location = new System.Drawing.Point(6, 28);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(31, 20);
            this.lblma.TabIndex = 0;
            this.lblma.Text = "Mã";
            // 
            // dgvchuyengiaocongnghe
            // 
            this.dgvchuyengiaocongnghe.AllowUserToAddRows = false;
            this.dgvchuyengiaocongnghe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchuyengiaocongnghe.Location = new System.Drawing.Point(2, 260);
            this.dgvchuyengiaocongnghe.Name = "dgvchuyengiaocongnghe";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.dgvchuyengiaocongnghe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvchuyengiaocongnghe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvchuyengiaocongnghe.Size = new System.Drawing.Size(522, 172);
            this.dgvchuyengiaocongnghe.TabIndex = 2;
            this.dgvchuyengiaocongnghe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvchuyengiaocongnghe.Click += new System.EventHandler(this.dgvchuyengiaocongnghe_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = global::QuanLyGiaoVien7.Properties.Resources.THOAT55;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnthoat.Location = new System.Drawing.Point(757, 367);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(72, 65);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackgroundImage = global::QuanLyGiaoVien7.Properties.Resources.HUY;
            this.btnhuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.Navy;
            this.btnhuy.Location = new System.Drawing.Point(646, 367);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(72, 65);
            this.btnhuy.TabIndex = 7;
            this.btnhuy.Text = "HỦY";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackgroundImage = global::QuanLyGiaoVien7.Properties.Resources.xóa;
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Red;
            this.btnluu.Location = new System.Drawing.Point(757, 260);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(72, 65);
            this.btnluu.TabIndex = 6;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImage = global::QuanLyGiaoVien7.Properties.Resources.sua;
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsua.Location = new System.Drawing.Point(530, 367);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(72, 65);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = global::QuanLyGiaoVien7.Properties.Resources.frdxdxd;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnxoa.Location = new System.Drawing.Point(530, 260);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(72, 65);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::QuanLyGiaoVien7.Properties.Resources.add_icon_3;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Red;
            this.btnthem.Location = new System.Drawing.Point(646, 260);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(72, 65);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // gbtimkiem
            // 
            this.gbtimkiem.Controls.Add(this.txttimkiem);
            this.gbtimkiem.Controls.Add(this.btntimkiem);
            this.gbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtimkiem.Location = new System.Drawing.Point(22, 170);
            this.gbtimkiem.Name = "gbtimkiem";
            this.gbtimkiem.Size = new System.Drawing.Size(552, 84);
            this.gbtimkiem.TabIndex = 9;
            this.gbtimkiem.TabStop = false;
            this.gbtimkiem.Text = "tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Yellow;
            this.btntimkiem.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btntimkiem.ForeColor = System.Drawing.Color.Red;
            this.btntimkiem.Location = new System.Drawing.Point(424, 21);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(117, 28);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(76, 28);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(290, 21);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.Text = "nhập vào nội dung cần tìm";
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // frmQuanLyHoatDongGiaoVien7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(837, 456);
            this.Controls.Add(this.gbtimkiem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvchuyengiaocongnghe);
            this.Controls.Add(this.gbChuyenGiaoCongNghe);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmQuanLyHoatDongGiaoVien7";
            this.Text = "Quản Lý Hoạt Động Giáo Viên7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbChuyenGiaoCongNghe.ResumeLayout(false);
            this.gbChuyenGiaoCongNghe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchuyengiaocongnghe)).EndInit();
            this.gbtimkiem.ResumeLayout(false);
            this.gbtimkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox gbChuyenGiaoCongNghe;
        private System.Windows.Forms.TextBox txtdoanhthu;
        private System.Windows.Forms.DateTimePicker dtpngaynhan;
        private System.Windows.Forms.DateTimePicker dtpthoigian;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.Label lbldoanhthu;
        private System.Windows.Forms.Label lblngaynhan;
        private System.Windows.Forms.Label lblgiaovienma;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.DataGridView dgvchuyengiaocongnghe;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox cmbgiaovienma;
        private System.Windows.Forms.GroupBox gbtimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
    }
}

