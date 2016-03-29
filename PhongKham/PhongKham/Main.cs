using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhongKham
{
    public partial class Main : Form
    {
        public const string _cnstr = "Server = .; Database = NHAKHOA; Integrated Security = true; User id = sa; password= 123123";
        //SqlConnection _cn;
        private SqlConnection _cn = new SqlConnection(_cnstr);
        private SqlDataAdapter _da;
        private DataSet _ds = new DataSet();
      //  int tb_count = 0;
        private SqlCommandBuilder _cb;
        string tabselected = "";
        int Cbt1 = 0, Cbt2 = 0, Cbt3 = 0, Cbt4 = 0, Cbt5 = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        //    _cn.Open();
        }

        public void LoadData()
        {
            string str = @"SELECT * FROM " + tabselected + "";
            try
            {
                _da = new SqlDataAdapter(str, _cn);
                _cb = new SqlCommandBuilder(_da);
                _ds.Tables.Add(tabselected);
                _da.Fill(_ds, tabselected);
               // tb_count = _ds.Tables.Count;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu:\n" + ex);
                //  throw;
            }
        }



        private void btNhanVien_Click(object sender, EventArgs e)
        {
            if (Cbt1 == 0)
            {
                Cbt1 = 1;
                tabselected = "NHANVIEN";
                //txtNhanVien.Text = tabselected;
                LoadData();
                DgvNhanVien.DataSource = _ds.Tables[tabselected];
            }
            else
                DgvNhanVien.DataSource = _ds.Tables[tabselected];
        }

        private void btBenhNhan_Click(object sender, EventArgs e)
        {
            if (Cbt2 == 0)
            {
                Cbt2 = 1;
                tabselected = "BENHNHAN";
              //  txtBenhNhan.Text = tabselected;
                LoadData();
                DgvBenhNhan.DataSource = _ds.Tables[tabselected];
            }
            else
                DgvBenhNhan.DataSource = _ds.Tables[tabselected];
        }

        private void bt_them_BenhNhan_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = _ds.Tables[tabselected].NewRow();
                dr["MaBN"] = txt_MaBN.Text;
                dr["HoBN"] = txt_HoBN.Text;
                dr["TenBN"] = txt_TenBN.Text;
                dr["Ngaysinh"] = txt_NgaysinhBN.Text;
                dr["GioiTinh"] = txt_GioiTinhBN.Text;
                dr["DiaChi"] = txt_DiaChiBN.Text;
                dr["SDT"] = txt_SDTBN.Text;
                _ds.Tables[0].Rows.Add(dr);
            }
            catch (DataException ex)
            {
                MessageBox.Show("Loi them du lieu\n" + ex.ToString());
                throw;
            }
        }

        private void bt_Xoa_BenhNhan_Click(object sender, EventArgs e)
        {
            try
            {                
               int RowIndex =  DgvBenhNhan.CurrentRow.Index;
               DataGridViewRow curRow = DgvBenhNhan.Rows[RowIndex];
               DialogResult dialog = MessageBox.Show("Ban chac chan muon xoa MaKH: " + curRow.Cells[0].Value.ToString() +" ?", "Xoa hang:", MessageBoxButtons.YesNo);
               if (dialog == DialogResult.Yes)
               {
                   if (DgvBenhNhan.Rows.Count > 0)
                   {                        
                       DgvBenhNhan.Rows.Remove(curRow);
                   }
               }           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi~: them  " + ex.ToString());
                //   throw;
            }
        }

        private void DgvBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBenhNhan.CurrentRow != null)
            {
                txt_MaBN.Text = DgvBenhNhan.CurrentRow.Cells["MaBN"].Value.ToString();
                txt_HoBN.Text = DgvBenhNhan.CurrentRow.Cells["HoBN"].Value.ToString();
                txt_TenBN.Text = DgvBenhNhan.CurrentRow.Cells["TenBN"].Value.ToString();
                txt_NgaysinhBN.Text = DgvBenhNhan.CurrentRow.Cells["Ngaysinh"].Value.ToString();
                txt_GioiTinhBN.Text = DgvBenhNhan.CurrentRow.Cells["GioiTinh"].Value.ToString();
                txt_DiaChiBN.Text = DgvBenhNhan.CurrentRow.Cells["DiaChi"].Value.ToString();
                txt_SDTBN.Text = DgvBenhNhan.CurrentRow.Cells["SDT"].Value.ToString();
            }
        }
        private void bt_Luu_BenhNhan_Click(object sender, EventArgs e)
        {
            try
            {
                _da.Update(_ds.Tables[tabselected]);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bt_Sua_BenhNhan_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dr in _ds.Tables[tabselected].Rows)
                {
                    if (dr[0].ToString() == txt_MaBN.Text.ToString())
                    {
                        dr[0] = Convert.ToInt32(txt_MaBN.Text.ToString());
                        dr[1] = txt_HoBN.Text;
                        dr[2] = txt_TenBN.Text;
                        dr[3] = txt_NgaysinhBN.Text;
                        dr[4] = txt_GioiTinhBN.Text;
                        dr[5] = txt_DiaChiBN.Text;
                        dr[6] = txt_SDTBN.Text;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     
    }
}
