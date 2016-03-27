namespace PhongKham
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp_AnhBiaBN = new System.Windows.Forms.TabPage();
            this.bt_Thoat_benhnhan = new System.Windows.Forms.Button();
            this.bt_Luu_benhnhan = new System.Windows.Forms.Button();
            this.bt_Sua_benhnhan = new System.Windows.Forms.Button();
            this.bt_Xoa_benhnhan = new System.Windows.Forms.Button();
            this.bt_them_benhnhan = new System.Windows.Forms.Button();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_TenBN = new System.Windows.Forms.Label();
            this.lb_HoBN = new System.Windows.Forms.Label();
            this.lb_Ngaysinh = new System.Windows.Forms.Label();
            this.lb_MaBN = new System.Windows.Forms.Label();
            this.lb1_QLBN = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_GioiTinh = new System.Windows.Forms.TextBox();
            this.txt_Ngaysinh = new System.Windows.Forms.TextBox();
            this.txt_TenBN = new System.Windows.Forms.TextBox();
            this.txt_HoBN = new System.Windows.Forms.TextBox();
            this.txt_MaBN = new System.Windows.Forms.TextBox();
            this.txtDS_Count = new System.Windows.Forms.TextBox();
            this.btBenhNhan = new System.Windows.Forms.Button();
            this.txtBenhNhan = new System.Windows.Forms.TextBox();
            this.DgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tp_AnhBiaBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btNhanVien);
            this.tabPage1.Controls.Add(this.txtNhanVien);
            this.tabPage1.Controls.Add(this.DgvNhanVien);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(835, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btNhanVien
            // 
            this.btNhanVien.Location = new System.Drawing.Point(8, 43);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(100, 35);
            this.btNhanVien.TabIndex = 4;
            this.btNhanVien.Text = "Danh sách";
            this.btNhanVien.UseVisualStyleBackColor = true;
            this.btNhanVien.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(114, 48);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(100, 27);
            this.txtNhanVien.TabIndex = 3;
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.AllowUserToAddRows = false;
            this.DgvNhanVien.AllowUserToDeleteRows = false;
            this.DgvNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Location = new System.Drawing.Point(0, 267);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.ReadOnly = true;
            this.DgvNhanVien.Size = new System.Drawing.Size(1184, 446);
            this.DgvNhanVien.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tp_AnhBiaBN);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(843, 741);
            this.tabControl.TabIndex = 0;
            // 
            // tp_AnhBiaBN
            // 
            this.tp_AnhBiaBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tp_AnhBiaBN.Controls.Add(this.bt_Thoat_benhnhan);
            this.tp_AnhBiaBN.Controls.Add(this.bt_Luu_benhnhan);
            this.tp_AnhBiaBN.Controls.Add(this.bt_Sua_benhnhan);
            this.tp_AnhBiaBN.Controls.Add(this.bt_Xoa_benhnhan);
            this.tp_AnhBiaBN.Controls.Add(this.bt_them_benhnhan);
            this.tp_AnhBiaBN.Controls.Add(this.lb_GioiTinh);
            this.tp_AnhBiaBN.Controls.Add(this.lb_DiaChi);
            this.tp_AnhBiaBN.Controls.Add(this.lb_SDT);
            this.tp_AnhBiaBN.Controls.Add(this.lb_TenBN);
            this.tp_AnhBiaBN.Controls.Add(this.lb_HoBN);
            this.tp_AnhBiaBN.Controls.Add(this.lb_Ngaysinh);
            this.tp_AnhBiaBN.Controls.Add(this.lb_MaBN);
            this.tp_AnhBiaBN.Controls.Add(this.lb1_QLBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_SDT);
            this.tp_AnhBiaBN.Controls.Add(this.txt_DiaChi);
            this.tp_AnhBiaBN.Controls.Add(this.txt_GioiTinh);
            this.tp_AnhBiaBN.Controls.Add(this.txt_Ngaysinh);
            this.tp_AnhBiaBN.Controls.Add(this.txt_TenBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_HoBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_MaBN);
            this.tp_AnhBiaBN.Controls.Add(this.txtDS_Count);
            this.tp_AnhBiaBN.Controls.Add(this.btBenhNhan);
            this.tp_AnhBiaBN.Controls.Add(this.txtBenhNhan);
            this.tp_AnhBiaBN.Controls.Add(this.DgvBenhNhan);
            this.tp_AnhBiaBN.Location = new System.Drawing.Point(4, 28);
            this.tp_AnhBiaBN.Margin = new System.Windows.Forms.Padding(4);
            this.tp_AnhBiaBN.Name = "tp_AnhBiaBN";
            this.tp_AnhBiaBN.Padding = new System.Windows.Forms.Padding(4);
            this.tp_AnhBiaBN.Size = new System.Drawing.Size(835, 709);
            this.tp_AnhBiaBN.TabIndex = 1;
            this.tp_AnhBiaBN.Text = "Bệnh nhân";
            this.tp_AnhBiaBN.UseVisualStyleBackColor = true;
            // 
            // bt_Thoat_benhnhan
            // 
            this.bt_Thoat_benhnhan.Image = global::PhongKham.Properties.Resources._12047665_674658566007901_330066257_n1;
            this.bt_Thoat_benhnhan.Location = new System.Drawing.Point(724, 299);
            this.bt_Thoat_benhnhan.Name = "bt_Thoat_benhnhan";
            this.bt_Thoat_benhnhan.Size = new System.Drawing.Size(69, 56);
            this.bt_Thoat_benhnhan.TabIndex = 30;
            this.bt_Thoat_benhnhan.UseVisualStyleBackColor = true;
            this.bt_Thoat_benhnhan.Click += new System.EventHandler(this.bt_Thoat_benhnhan_Click);
            // 
            // bt_Luu_benhnhan
            // 
            this.bt_Luu_benhnhan.Image = global::PhongKham.Properties.Resources.save;
            this.bt_Luu_benhnhan.Location = new System.Drawing.Point(601, 299);
            this.bt_Luu_benhnhan.Name = "bt_Luu_benhnhan";
            this.bt_Luu_benhnhan.Size = new System.Drawing.Size(69, 56);
            this.bt_Luu_benhnhan.TabIndex = 27;
            this.bt_Luu_benhnhan.UseVisualStyleBackColor = true;
            this.bt_Luu_benhnhan.Click += new System.EventHandler(this.bt_Luu_benhnhan_Click);
            // 
            // bt_Sua_benhnhan
            // 
            this.bt_Sua_benhnhan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Sua_benhnhan.Image = global::PhongKham.Properties.Resources.suachua;
            this.bt_Sua_benhnhan.Location = new System.Drawing.Point(482, 299);
            this.bt_Sua_benhnhan.Name = "bt_Sua_benhnhan";
            this.bt_Sua_benhnhan.Size = new System.Drawing.Size(68, 56);
            this.bt_Sua_benhnhan.TabIndex = 26;
            this.bt_Sua_benhnhan.UseVisualStyleBackColor = true;
            this.bt_Sua_benhnhan.Click += new System.EventHandler(this.bt_Sua_benhnhan_Click);
            // 
            // bt_Xoa_benhnhan
            // 
            this.bt_Xoa_benhnhan.Image = global::PhongKham.Properties.Resources._12516407_674657942674630_991295884_n;
            this.bt_Xoa_benhnhan.Location = new System.Drawing.Point(360, 299);
            this.bt_Xoa_benhnhan.Name = "bt_Xoa_benhnhan";
            this.bt_Xoa_benhnhan.Size = new System.Drawing.Size(69, 56);
            this.bt_Xoa_benhnhan.TabIndex = 29;
            this.bt_Xoa_benhnhan.UseVisualStyleBackColor = true;
            this.bt_Xoa_benhnhan.Click += new System.EventHandler(this.bt_Xoa_benhnhan_Click);
            // 
            // bt_them_benhnhan
            // 
            this.bt_them_benhnhan.Image = global::PhongKham.Properties.Resources._12833244_674657556008002_958393670_n;
            this.bt_them_benhnhan.Location = new System.Drawing.Point(241, 299);
            this.bt_them_benhnhan.Name = "bt_them_benhnhan";
            this.bt_them_benhnhan.Size = new System.Drawing.Size(69, 56);
            this.bt_them_benhnhan.TabIndex = 28;
            this.bt_them_benhnhan.UseVisualStyleBackColor = true;
            this.bt_them_benhnhan.Click += new System.EventHandler(this.bt_them_benhnhan_Click);
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GioiTinh.ForeColor = System.Drawing.Color.Red;
            this.lb_GioiTinh.Location = new System.Drawing.Point(243, 185);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(84, 23);
            this.lb_GioiTinh.TabIndex = 25;
            this.lb_GioiTinh.Text = "Giới Tính";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.ForeColor = System.Drawing.Color.Red;
            this.lb_DiaChi.Location = new System.Drawing.Point(245, 216);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(69, 23);
            this.lb_DiaChi.TabIndex = 24;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.ForeColor = System.Drawing.Color.Red;
            this.lb_SDT.Location = new System.Drawing.Point(241, 250);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(127, 23);
            this.lb_SDT.TabIndex = 23;
            this.lb_SDT.Text = "Số Điện Thoại";
            // 
            // lb_TenBN
            // 
            this.lb_TenBN.AutoSize = true;
            this.lb_TenBN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenBN.ForeColor = System.Drawing.Color.Red;
            this.lb_TenBN.Location = new System.Drawing.Point(241, 118);
            this.lb_TenBN.Name = "lb_TenBN";
            this.lb_TenBN.Size = new System.Drawing.Size(142, 23);
            this.lb_TenBN.TabIndex = 22;
            this.lb_TenBN.Text = "Tên Bệnh Nhân";
            // 
            // lb_HoBN
            // 
            this.lb_HoBN.AutoSize = true;
            this.lb_HoBN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoBN.ForeColor = System.Drawing.Color.Red;
            this.lb_HoBN.Location = new System.Drawing.Point(243, 86);
            this.lb_HoBN.Name = "lb_HoBN";
            this.lb_HoBN.Size = new System.Drawing.Size(133, 23);
            this.lb_HoBN.TabIndex = 21;
            this.lb_HoBN.Text = "Họ Bệnh Nhân";
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.AutoSize = true;
            this.lb_Ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ngaysinh.ForeColor = System.Drawing.Color.Red;
            this.lb_Ngaysinh.Location = new System.Drawing.Point(245, 152);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(97, 24);
            this.lb_Ngaysinh.TabIndex = 20;
            this.lb_Ngaysinh.Text = "Ngày Sinh";
            // 
            // lb_MaBN
            // 
            this.lb_MaBN.AutoSize = true;
            this.lb_MaBN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaBN.ForeColor = System.Drawing.Color.Red;
            this.lb_MaBN.Location = new System.Drawing.Point(241, 53);
            this.lb_MaBN.Name = "lb_MaBN";
            this.lb_MaBN.Size = new System.Drawing.Size(135, 23);
            this.lb_MaBN.TabIndex = 18;
            this.lb_MaBN.Text = "Mã Bệnh Nhân";
            // 
            // lb1_QLBN
            // 
            this.lb1_QLBN.AutoSize = true;
            this.lb1_QLBN.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1_QLBN.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb1_QLBN.Location = new System.Drawing.Point(389, 0);
            this.lb1_QLBN.Name = "lb1_QLBN";
            this.lb1_QLBN.Size = new System.Drawing.Size(216, 25);
            this.lb1_QLBN.TabIndex = 19;
            this.lb1_QLBN.Text = "Quản Lý Bệnh Nhân";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(486, 251);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(307, 26);
            this.txt_SDT.TabIndex = 13;
            this.txt_SDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(486, 218);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(307, 26);
            this.txt_DiaChi.TabIndex = 12;
            this.txt_DiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioiTinh.Location = new System.Drawing.Point(486, 185);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(307, 26);
            this.txt_GioiTinh.TabIndex = 11;
            this.txt_GioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Ngaysinh
            // 
            this.txt_Ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ngaysinh.Location = new System.Drawing.Point(486, 152);
            this.txt_Ngaysinh.Name = "txt_Ngaysinh";
            this.txt_Ngaysinh.Size = new System.Drawing.Size(307, 26);
            this.txt_Ngaysinh.TabIndex = 14;
            this.txt_Ngaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TenBN
            // 
            this.txt_TenBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenBN.Location = new System.Drawing.Point(486, 118);
            this.txt_TenBN.Name = "txt_TenBN";
            this.txt_TenBN.Size = new System.Drawing.Size(307, 26);
            this.txt_TenBN.TabIndex = 17;
            this.txt_TenBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_HoBN
            // 
            this.txt_HoBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoBN.Location = new System.Drawing.Point(486, 82);
            this.txt_HoBN.Name = "txt_HoBN";
            this.txt_HoBN.Size = new System.Drawing.Size(307, 26);
            this.txt_HoBN.TabIndex = 16;
            this.txt_HoBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MaBN
            // 
            this.txt_MaBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaBN.Location = new System.Drawing.Point(486, 49);
            this.txt_MaBN.Name = "txt_MaBN";
            this.txt_MaBN.Size = new System.Drawing.Size(307, 26);
            this.txt_MaBN.TabIndex = 15;
            this.txt_MaBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDS_Count
            // 
            this.txtDS_Count.Location = new System.Drawing.Point(7, 61);
            this.txtDS_Count.Name = "txtDS_Count";
            this.txtDS_Count.Size = new System.Drawing.Size(100, 27);
            this.txtDS_Count.TabIndex = 3;
            // 
            // btBenhNhan
            // 
            this.btBenhNhan.Location = new System.Drawing.Point(3, 20);
            this.btBenhNhan.Name = "btBenhNhan";
            this.btBenhNhan.Size = new System.Drawing.Size(100, 35);
            this.btBenhNhan.TabIndex = 2;
            this.btBenhNhan.Text = "Danh sách";
            this.btBenhNhan.UseVisualStyleBackColor = true;
            this.btBenhNhan.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBenhNhan
            // 
            this.txtBenhNhan.Location = new System.Drawing.Point(109, 25);
            this.txtBenhNhan.Name = "txtBenhNhan";
            this.txtBenhNhan.Size = new System.Drawing.Size(100, 27);
            this.txtBenhNhan.TabIndex = 1;
            // 
            // DgvBenhNhan
            // 
            this.DgvBenhNhan.AllowUserToAddRows = false;
            this.DgvBenhNhan.AllowUserToDeleteRows = false;
            this.DgvBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DgvBenhNhan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBenhNhan.Location = new System.Drawing.Point(-171, 416);
            this.DgvBenhNhan.Name = "DgvBenhNhan";
            this.DgvBenhNhan.ReadOnly = true;
            this.DgvBenhNhan.Size = new System.Drawing.Size(1025, 297);
            this.DgvBenhNhan.TabIndex = 0;
            this.DgvBenhNhan.SelectionChanged += new System.EventHandler(this.DgvBenhNhan_SelectionChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 741);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng khám";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tp_AnhBiaBN.ResumeLayout(false);
            this.tp_AnhBiaBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tp_AnhBiaBN;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.DataGridView DgvBenhNhan;
        private System.Windows.Forms.TextBox txtBenhNhan;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Button btBenhNhan;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.TextBox txtDS_Count;
        private System.Windows.Forms.Button bt_Thoat_benhnhan;
        private System.Windows.Forms.Button bt_Luu_benhnhan;
        private System.Windows.Forms.Button bt_Sua_benhnhan;
        private System.Windows.Forms.Button bt_Xoa_benhnhan;
        private System.Windows.Forms.Button bt_them_benhnhan;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_TenBN;
        private System.Windows.Forms.Label lb_HoBN;
        private System.Windows.Forms.Label lb_Ngaysinh;
        private System.Windows.Forms.Label lb_MaBN;
        private System.Windows.Forms.Label lb1_QLBN;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_GioiTinh;
        private System.Windows.Forms.TextBox txt_Ngaysinh;
        private System.Windows.Forms.TextBox txt_TenBN;
        private System.Windows.Forms.TextBox txt_HoBN;
        private System.Windows.Forms.TextBox txt_MaBN;

    }
}