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
            this.bt_Luu_NhanVien = new System.Windows.Forms.Button();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp_AnhBiaBN = new System.Windows.Forms.TabPage();
            this.bt_Luu_BenhNhan = new System.Windows.Forms.Button();
            this.bt_Sua_BenhNhan = new System.Windows.Forms.Button();
            this.bt_Xoa_BenhNhan = new System.Windows.Forms.Button();
            this.bt_them_BenhNhan = new System.Windows.Forms.Button();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_TenBN = new System.Windows.Forms.Label();
            this.lb_HoBN = new System.Windows.Forms.Label();
            this.lb_Ngaysinh = new System.Windows.Forms.Label();
            this.lb_MaBN = new System.Windows.Forms.Label();
            this.lb1_QLBN = new System.Windows.Forms.Label();
            this.txt_SDTBN = new System.Windows.Forms.TextBox();
            this.txt_DiaChiBN = new System.Windows.Forms.TextBox();
            this.txt_GioiTinhBN = new System.Windows.Forms.TextBox();
            this.txt_NgaysinhBN = new System.Windows.Forms.TextBox();
            this.txt_TenBN = new System.Windows.Forms.TextBox();
            this.txt_HoBN = new System.Windows.Forms.TextBox();
            this.txt_MaBN = new System.Windows.Forms.TextBox();
            this.btBenhNhan = new System.Windows.Forms.Button();
            this.DgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txt_TenNV_HD = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.txt_NgayDT_HD = new System.Windows.Forms.TextBox();
            this.txt_TenBN_HD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Sua_HD = new System.Windows.Forms.Button();
            this.bt_Xoa_HD = new System.Windows.Forms.Button();
            this.bt_Them_HD = new System.Windows.Forms.Button();
            this.bt_DanhSach_HD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tp_AnhBiaBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_Luu_NhanVien);
            this.tabPage1.Controls.Add(this.btNhanVien);
            this.tabPage1.Controls.Add(this.DgvNhanVien);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1176, 730);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_Luu_NhanVien
            // 
            this.bt_Luu_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Luu_NhanVien.Location = new System.Drawing.Point(580, 600);
            this.bt_Luu_NhanVien.Name = "bt_Luu_NhanVien";
            this.bt_Luu_NhanVien.Size = new System.Drawing.Size(80, 30);
            this.bt_Luu_NhanVien.TabIndex = 28;
            this.bt_Luu_NhanVien.Text = "Lưu";
            this.bt_Luu_NhanVien.UseVisualStyleBackColor = true;
            this.bt_Luu_NhanVien.Click += new System.EventHandler(this.bt_Luu_BenhNhan_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.Location = new System.Drawing.Point(3, 3);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(100, 35);
            this.btNhanVien.TabIndex = 4;
            this.btNhanVien.Text = "Danh sách";
            this.btNhanVien.UseVisualStyleBackColor = true;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Location = new System.Drawing.Point(0, 288);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.Size = new System.Drawing.Size(1184, 300);
            this.DgvNhanVien.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tp_AnhBiaBN);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1184, 762);
            this.tabControl.TabIndex = 0;
            // 
            // tp_AnhBiaBN
            // 
            this.tp_AnhBiaBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tp_AnhBiaBN.Controls.Add(this.bt_Luu_BenhNhan);
            this.tp_AnhBiaBN.Controls.Add(this.bt_Sua_BenhNhan);
            this.tp_AnhBiaBN.Controls.Add(this.bt_Xoa_BenhNhan);
            this.tp_AnhBiaBN.Controls.Add(this.bt_them_BenhNhan);
            this.tp_AnhBiaBN.Controls.Add(this.lb_GioiTinh);
            this.tp_AnhBiaBN.Controls.Add(this.lb_DiaChi);
            this.tp_AnhBiaBN.Controls.Add(this.lb_SDT);
            this.tp_AnhBiaBN.Controls.Add(this.lb_TenBN);
            this.tp_AnhBiaBN.Controls.Add(this.lb_HoBN);
            this.tp_AnhBiaBN.Controls.Add(this.lb_Ngaysinh);
            this.tp_AnhBiaBN.Controls.Add(this.lb_MaBN);
            this.tp_AnhBiaBN.Controls.Add(this.lb1_QLBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_SDTBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_DiaChiBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_GioiTinhBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_NgaysinhBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_TenBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_HoBN);
            this.tp_AnhBiaBN.Controls.Add(this.txt_MaBN);
            this.tp_AnhBiaBN.Controls.Add(this.btBenhNhan);
            this.tp_AnhBiaBN.Controls.Add(this.DgvBenhNhan);
            this.tp_AnhBiaBN.Location = new System.Drawing.Point(4, 28);
            this.tp_AnhBiaBN.Margin = new System.Windows.Forms.Padding(4);
            this.tp_AnhBiaBN.Name = "tp_AnhBiaBN";
            this.tp_AnhBiaBN.Padding = new System.Windows.Forms.Padding(4);
            this.tp_AnhBiaBN.Size = new System.Drawing.Size(1176, 730);
            this.tp_AnhBiaBN.TabIndex = 1;
            this.tp_AnhBiaBN.Text = "Bệnh nhân";
            this.tp_AnhBiaBN.UseVisualStyleBackColor = true;
            // 
            // bt_Luu_BenhNhan
            // 
            this.bt_Luu_BenhNhan.Location = new System.Drawing.Point(580, 600);
            this.bt_Luu_BenhNhan.Name = "bt_Luu_BenhNhan";
            this.bt_Luu_BenhNhan.Size = new System.Drawing.Size(80, 30);
            this.bt_Luu_BenhNhan.TabIndex = 27;
            this.bt_Luu_BenhNhan.Text = "Lưu";
            this.bt_Luu_BenhNhan.UseVisualStyleBackColor = true;
            this.bt_Luu_BenhNhan.Click += new System.EventHandler(this.bt_Luu_BenhNhan_Click);
            // 
            // bt_Sua_BenhNhan
            // 
            this.bt_Sua_BenhNhan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Sua_BenhNhan.Location = new System.Drawing.Point(826, 83);
            this.bt_Sua_BenhNhan.Name = "bt_Sua_BenhNhan";
            this.bt_Sua_BenhNhan.Size = new System.Drawing.Size(80, 30);
            this.bt_Sua_BenhNhan.TabIndex = 26;
            this.bt_Sua_BenhNhan.Text = "Sửa";
            this.bt_Sua_BenhNhan.UseVisualStyleBackColor = true;
            this.bt_Sua_BenhNhan.Click += new System.EventHandler(this.bt_Sua_BenhNhan_Click);
            // 
            // bt_Xoa_BenhNhan
            // 
            this.bt_Xoa_BenhNhan.Location = new System.Drawing.Point(826, 118);
            this.bt_Xoa_BenhNhan.Name = "bt_Xoa_BenhNhan";
            this.bt_Xoa_BenhNhan.Size = new System.Drawing.Size(80, 30);
            this.bt_Xoa_BenhNhan.TabIndex = 29;
            this.bt_Xoa_BenhNhan.Text = "Xóa";
            this.bt_Xoa_BenhNhan.UseVisualStyleBackColor = true;
            this.bt_Xoa_BenhNhan.Click += new System.EventHandler(this.bt_Xoa_BenhNhan_Click);
            // 
            // bt_them_BenhNhan
            // 
            this.bt_them_BenhNhan.Location = new System.Drawing.Point(826, 47);
            this.bt_them_BenhNhan.Name = "bt_them_BenhNhan";
            this.bt_them_BenhNhan.Size = new System.Drawing.Size(80, 30);
            this.bt_them_BenhNhan.TabIndex = 28;
            this.bt_them_BenhNhan.Text = "Thêm";
            this.bt_them_BenhNhan.UseVisualStyleBackColor = true;
            this.bt_them_BenhNhan.Click += new System.EventHandler(this.bt_them_BenhNhan_Click);
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_GioiTinh.Location = new System.Drawing.Point(243, 185);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(84, 23);
            this.lb_GioiTinh.TabIndex = 25;
            this.lb_GioiTinh.Text = "Giới Tính";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_DiaChi.Location = new System.Drawing.Point(245, 216);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(69, 23);
            this.lb_DiaChi.TabIndex = 24;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_SDT.Location = new System.Drawing.Point(241, 250);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(127, 23);
            this.lb_SDT.TabIndex = 23;
            this.lb_SDT.Text = "Số Điện Thoại";
            // 
            // lb_TenBN
            // 
            this.lb_TenBN.AutoSize = true;
            this.lb_TenBN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_TenBN.Location = new System.Drawing.Point(241, 118);
            this.lb_TenBN.Name = "lb_TenBN";
            this.lb_TenBN.Size = new System.Drawing.Size(142, 23);
            this.lb_TenBN.TabIndex = 22;
            this.lb_TenBN.Text = "Tên Bệnh Nhân";
            // 
            // lb_HoBN
            // 
            this.lb_HoBN.AutoSize = true;
            this.lb_HoBN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_HoBN.Location = new System.Drawing.Point(243, 86);
            this.lb_HoBN.Name = "lb_HoBN";
            this.lb_HoBN.Size = new System.Drawing.Size(133, 23);
            this.lb_HoBN.TabIndex = 21;
            this.lb_HoBN.Text = "Họ Bệnh Nhân";
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.AutoSize = true;
            this.lb_Ngaysinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ngaysinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Ngaysinh.Location = new System.Drawing.Point(245, 152);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(96, 23);
            this.lb_Ngaysinh.TabIndex = 20;
            this.lb_Ngaysinh.Text = "Ngày Sinh";
            // 
            // lb_MaBN
            // 
            this.lb_MaBN.AutoSize = true;
            this.lb_MaBN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.lb1_QLBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb1_QLBN.Location = new System.Drawing.Point(389, 0);
            this.lb1_QLBN.Name = "lb1_QLBN";
            this.lb1_QLBN.Size = new System.Drawing.Size(216, 25);
            this.lb1_QLBN.TabIndex = 19;
            this.lb1_QLBN.Text = "Quản Lý Bệnh Nhân";
            // 
            // txt_SDTBN
            // 
            this.txt_SDTBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDTBN.Location = new System.Drawing.Point(486, 251);
            this.txt_SDTBN.Name = "txt_SDTBN";
            this.txt_SDTBN.Size = new System.Drawing.Size(307, 26);
            this.txt_SDTBN.TabIndex = 13;
            this.txt_SDTBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DiaChiBN
            // 
            this.txt_DiaChiBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChiBN.Location = new System.Drawing.Point(486, 218);
            this.txt_DiaChiBN.Name = "txt_DiaChiBN";
            this.txt_DiaChiBN.Size = new System.Drawing.Size(307, 26);
            this.txt_DiaChiBN.TabIndex = 12;
            this.txt_DiaChiBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_GioiTinhBN
            // 
            this.txt_GioiTinhBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioiTinhBN.Location = new System.Drawing.Point(486, 185);
            this.txt_GioiTinhBN.Name = "txt_GioiTinhBN";
            this.txt_GioiTinhBN.Size = new System.Drawing.Size(307, 26);
            this.txt_GioiTinhBN.TabIndex = 11;
            this.txt_GioiTinhBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NgaysinhBN
            // 
            this.txt_NgaysinhBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgaysinhBN.Location = new System.Drawing.Point(486, 152);
            this.txt_NgaysinhBN.Name = "txt_NgaysinhBN";
            this.txt_NgaysinhBN.Size = new System.Drawing.Size(307, 26);
            this.txt_NgaysinhBN.TabIndex = 14;
            this.txt_NgaysinhBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btBenhNhan
            // 
            this.btBenhNhan.Location = new System.Drawing.Point(3, 3);
            this.btBenhNhan.Name = "btBenhNhan";
            this.btBenhNhan.Size = new System.Drawing.Size(100, 35);
            this.btBenhNhan.TabIndex = 2;
            this.btBenhNhan.Text = "Danh sách";
            this.btBenhNhan.UseVisualStyleBackColor = true;
            this.btBenhNhan.Click += new System.EventHandler(this.btBenhNhan_Click);
            // 
            // DgvBenhNhan
            // 
            this.DgvBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DgvBenhNhan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBenhNhan.Location = new System.Drawing.Point(0, 288);
            this.DgvBenhNhan.Name = "DgvBenhNhan";
            this.DgvBenhNhan.Size = new System.Drawing.Size(1184, 300);
            this.DgvBenhNhan.TabIndex = 0;
            this.DgvBenhNhan.SelectionChanged += new System.EventHandler(this.DgvBenhNhan_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.DgvHoaDon);
            this.tabPage2.Controls.Add(this.txt_TenNV_HD);
            this.tabPage2.Controls.Add(this.txt_MaHD);
            this.tabPage2.Controls.Add(this.txt_NgayDT_HD);
            this.tabPage2.Controls.Add(this.txt_TenBN_HD);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.l);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bt_Sua_HD);
            this.tabPage2.Controls.Add(this.bt_Xoa_HD);
            this.tabPage2.Controls.Add(this.bt_Them_HD);
            this.tabPage2.Controls.Add(this.bt_DanhSach_HD);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 730);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_Luu_BenhNhan_Click);
            // 
            // DgvHoaDon
            // 
            this.DgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHoaDon.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DgvHoaDon.Location = new System.Drawing.Point(0, 302);
            this.DgvHoaDon.Name = "DgvHoaDon";
            this.DgvHoaDon.Size = new System.Drawing.Size(450, 300);
            this.DgvHoaDon.TabIndex = 38;
            this.DgvHoaDon.SelectionChanged += new System.EventHandler(this.DgvHoaDon_SelectionChanged);
            // 
            // txt_TenNV_HD
            // 
            this.txt_TenNV_HD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV_HD.Location = new System.Drawing.Point(501, 97);
            this.txt_TenNV_HD.Name = "txt_TenNV_HD";
            this.txt_TenNV_HD.Size = new System.Drawing.Size(307, 26);
            this.txt_TenNV_HD.TabIndex = 34;
            this.txt_TenNV_HD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHD.Location = new System.Drawing.Point(501, 66);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(307, 26);
            this.txt_MaHD.TabIndex = 35;
            this.txt_MaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NgayDT_HD
            // 
            this.txt_NgayDT_HD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayDT_HD.Location = new System.Drawing.Point(503, 165);
            this.txt_NgayDT_HD.Name = "txt_NgayDT_HD";
            this.txt_NgayDT_HD.Size = new System.Drawing.Size(307, 26);
            this.txt_NgayDT_HD.TabIndex = 36;
            this.txt_NgayDT_HD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TenBN_HD
            // 
            this.txt_TenBN_HD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenBN_HD.Location = new System.Drawing.Point(503, 136);
            this.txt_TenBN_HD.Name = "txt_TenBN_HD";
            this.txt_TenBN_HD.Size = new System.Drawing.Size(307, 26);
            this.txt_TenBN_HD.TabIndex = 37;
            this.txt_TenBN_HD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(367, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ngày điều trị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(367, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tên bệnh nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(367, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tên bác sĩ";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.Black;
            this.l.Location = new System.Drawing.Point(367, 65);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(110, 23);
            this.l.TabIndex = 33;
            this.l.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(498, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Quản Lý Hóa Đơn";
            // 
            // bt_Sua_HD
            // 
            this.bt_Sua_HD.Location = new System.Drawing.Point(727, 211);
            this.bt_Sua_HD.Name = "bt_Sua_HD";
            this.bt_Sua_HD.Size = new System.Drawing.Size(104, 53);
            this.bt_Sua_HD.TabIndex = 26;
            this.bt_Sua_HD.Text = "Sửa";
            this.bt_Sua_HD.UseVisualStyleBackColor = true;
            // 
            // bt_Xoa_HD
            // 
            this.bt_Xoa_HD.Location = new System.Drawing.Point(599, 211);
            this.bt_Xoa_HD.Name = "bt_Xoa_HD";
            this.bt_Xoa_HD.Size = new System.Drawing.Size(104, 53);
            this.bt_Xoa_HD.TabIndex = 27;
            this.bt_Xoa_HD.Text = "Xóa";
            this.bt_Xoa_HD.UseVisualStyleBackColor = true;
            // 
            // bt_Them_HD
            // 
            this.bt_Them_HD.Location = new System.Drawing.Point(471, 211);
            this.bt_Them_HD.Name = "bt_Them_HD";
            this.bt_Them_HD.Size = new System.Drawing.Size(104, 53);
            this.bt_Them_HD.TabIndex = 28;
            this.bt_Them_HD.Text = "Thêm";
            this.bt_Them_HD.UseVisualStyleBackColor = true;
            // 
            // bt_DanhSach_HD
            // 
            this.bt_DanhSach_HD.Location = new System.Drawing.Point(345, 211);
            this.bt_DanhSach_HD.Name = "bt_DanhSach_HD";
            this.bt_DanhSach_HD.Size = new System.Drawing.Size(104, 53);
            this.bt_DanhSach_HD.TabIndex = 24;
            this.bt_DanhSach_HD.Text = "Danh Sách";
            this.bt_DanhSach_HD.UseVisualStyleBackColor = true;
            this.bt_DanhSach_HD.Click += new System.EventHandler(this.bt_DanhSach_HD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(471, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 300);
            this.dataGridView1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Danh sách hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(467, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Chi tiết hóa đơn";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng khám";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tp_AnhBiaBN.ResumeLayout(false);
            this.tp_AnhBiaBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tp_AnhBiaBN;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.DataGridView DgvBenhNhan;
        private System.Windows.Forms.Button btBenhNhan;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button bt_Luu_BenhNhan;
        private System.Windows.Forms.Button bt_Sua_BenhNhan;
        private System.Windows.Forms.Button bt_Xoa_BenhNhan;
        private System.Windows.Forms.Button bt_them_BenhNhan;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_TenBN;
        private System.Windows.Forms.Label lb_HoBN;
        private System.Windows.Forms.Label lb_Ngaysinh;
        private System.Windows.Forms.Label lb_MaBN;
        private System.Windows.Forms.Label lb1_QLBN;
        private System.Windows.Forms.TextBox txt_SDTBN;
        private System.Windows.Forms.TextBox txt_DiaChiBN;
        private System.Windows.Forms.TextBox txt_GioiTinhBN;
        private System.Windows.Forms.TextBox txt_NgaysinhBN;
        private System.Windows.Forms.TextBox txt_TenBN;
        private System.Windows.Forms.TextBox txt_HoBN;
        private System.Windows.Forms.TextBox txt_MaBN;
        private System.Windows.Forms.Button bt_Luu_NhanVien;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgvHoaDon;
        private System.Windows.Forms.TextBox txt_TenNV_HD;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.TextBox txt_NgayDT_HD;
        private System.Windows.Forms.TextBox txt_TenBN_HD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Sua_HD;
        private System.Windows.Forms.Button bt_Xoa_HD;
        private System.Windows.Forms.Button bt_Them_HD;
        private System.Windows.Forms.Button bt_DanhSach_HD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;

    }
}