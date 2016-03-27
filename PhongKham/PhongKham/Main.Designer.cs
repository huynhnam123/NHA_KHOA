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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btBenhNhan = new System.Windows.Forms.Button();
            this.txtBenhNhan = new System.Windows.Forms.TextBox();
            this.DgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.txtDS_Count = new System.Windows.Forms.TextBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtDS_Count);
            this.tabPage2.Controls.Add(this.btBenhNhan);
            this.tabPage2.Controls.Add(this.txtBenhNhan);
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
            this.DgvBenhNhan.Location = new System.Drawing.Point(0, 288);
            this.DgvBenhNhan.Name = "DgvBenhNhan";
            this.DgvBenhNhan.ReadOnly = true;
            this.DgvBenhNhan.Size = new System.Drawing.Size(1168, 446);
            this.DgvBenhNhan.TabIndex = 0;
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
            this.DgvNhanVien.Location = new System.Drawing.Point(0, 288);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.ReadOnly = true;
            this.DgvNhanVien.Size = new System.Drawing.Size(1184, 446);
            this.DgvNhanVien.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1184, 762);
            this.tabControl.TabIndex = 0;
            // 
            // txtDS_Count
            // 
            this.txtDS_Count.Location = new System.Drawing.Point(7, 61);
            this.txtDS_Count.Name = "txtDS_Count";
            this.txtDS_Count.Size = new System.Drawing.Size(100, 27);
            this.txtDS_Count.TabIndex = 3;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBenhNhan)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.DataGridView DgvBenhNhan;
        private System.Windows.Forms.TextBox txtBenhNhan;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Button btBenhNhan;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.TextBox txtDS_Count;

    }
}