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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.txtBenhNhan = new System.Windows.Forms.TextBox();
            this.btBenhNhan = new System.Windows.Forms.Button();
            this.txtDS_Count = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView3);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1176, 730);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Dịch vụ điều trị";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1176, 730);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hóa đơn";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1176, 730);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lịch Khám";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtDS_Count);
            this.tabPage2.Controls.Add(this.txtBenhNhan);
            this.tabPage2.Controls.Add(this.btBenhNhan);
            this.tabPage2.Controls.Add(this.DgvBenhNhan);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1176, 730);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bệnh nhân";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DgvBenhNhan
            // 
            this.DgvBenhNhan.AllowUserToAddRows = false;
            this.DgvBenhNhan.AllowUserToDeleteRows = false;
            this.DgvBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DgvBenhNhan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBenhNhan.Location = new System.Drawing.Point(0, 288);
            this.DgvBenhNhan.Name = "DgvBenhNhan";
            this.DgvBenhNhan.ReadOnly = true;
            this.DgvBenhNhan.Size = new System.Drawing.Size(1168, 446);
            this.DgvBenhNhan.TabIndex = 0;
            // 
            // txtBenhNhan
            // 
            this.txtBenhNhan.Location = new System.Drawing.Point(109, 25);
            this.txtBenhNhan.Name = "txtBenhNhan";
            this.txtBenhNhan.Size = new System.Drawing.Size(100, 27);
            this.txtBenhNhan.TabIndex = 1;
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
            // txtDS_Count
            // 
            this.txtDS_Count.Location = new System.Drawing.Point(7, 61);
            this.txtDS_Count.Name = "txtDS_Count";
            this.txtDS_Count.Size = new System.Drawing.Size(100, 27);
            this.txtDS_Count.TabIndex = 3;
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
            this.tabPage1.Size = new System.Drawing.Size(1176, 730);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.AllowUserToAddRows = false;
            this.DgvNhanVien.AllowUserToDeleteRows = false;
            this.DgvNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Location = new System.Drawing.Point(0, 288);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.ReadOnly = true;
            this.DgvNhanVien.Size = new System.Drawing.Size(1184, 446);
            this.DgvNhanVien.TabIndex = 2;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(114, 48);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(100, 27);
            this.txtNhanVien.TabIndex = 3;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1184, 762);
            this.tabControl.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 446);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1168, 446);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 288);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(1168, 446);
            this.dataGridView3.TabIndex = 1;
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
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDS_Count;
        private System.Windows.Forms.TextBox txtBenhNhan;
        private System.Windows.Forms.Button btBenhNhan;
        private System.Windows.Forms.DataGridView DgvBenhNhan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.TabControl tabControl;


    }
}