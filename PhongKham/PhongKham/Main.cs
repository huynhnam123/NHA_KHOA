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

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {        
        }

        public void LoadData(string tab)
        {
            string str = @"SELECT * FROM " + tab + "";
            try
            {
                _da = new SqlDataAdapter(str, _cn);
                _cb = new SqlCommandBuilder(_da);
                _ds.Tables.Add(tab);
                _da.Fill(_ds, tab);
                if (tab == "LICHKHAM")
                {
                    DataColumn[] MyKey = new DataColumn[2];
                    MyKey[0] = _ds.Tables[tab].Columns[0];
                    MyKey[0] = _ds.Tables[tab].Columns[1];
                    _ds.Tables[tab].PrimaryKey = MyKey;
                }
                else
                {
                    DataColumn[] MyKey = new DataColumn[1];
                    MyKey[0] = _ds.Tables[tab].Columns[0];
                    _ds.Tables[tab].PrimaryKey = MyKey;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu:\n" + ex);
                //  throw;
            }
        }


        /// <summary>
        /// LoadData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNhanVien_Click(object sender, EventArgs e)
        {
            tabselected = "NHANVIEN";             
            if (_ds.Tables.Contains("NHANVIEN") == false)
            {                
                LoadData(tabselected);
                DgvNhanVien.DataSource = _ds.Tables[tabselected];
            }
            else
                DgvNhanVien.DataSource = _ds.Tables[tabselected];
        }

        private void btBenhNhan_Click(object sender, EventArgs e)
        {
            tabselected = "BENHNHAN";
            if (_ds.Tables.Contains("BENHNHAN") == false)
            {                           
                LoadData(tabselected);
                DgvBenhNhan.DataSource = _ds.Tables[tabselected];
            }
            else
                DgvBenhNhan.DataSource = _ds.Tables[tabselected];
        }
        private void bt_DanhSach_HD_Click(object sender, EventArgs e)
        {
            tabselected = "HOADONDIEUTRI";
            if (_ds.Tables.Contains("HOADONDIEUTRI") == false)
            {              
                LoadData(tabselected);

                if (_ds.Tables.Contains("NHANVIEN") == false)
                {
                    LoadData("NHANVIEN");
                }
                if (_ds.Tables.Contains("BENHNHAN") == false)
                {
                    LoadData("BENHNHAN");
                }
                if (_ds.Tables.Contains("CHITET_HD_DIEUTRI") == false)
                {
                    LoadData("CHITET_HD_DIEUTRI");                  
                    DgvCTHD.DataSource = _ds.Tables["CHITET_HD_DIEUTRI"];
                }
                DgvHoaDon.DataSource = _ds.Tables[tabselected];
            }
            else
                DgvHoaDon.DataSource = _ds.Tables[tabselected];
        }
        private void bt_DanhSach_LichKham_Click(object sender, EventArgs e)
        {
            tabselected = "LICHKHAM";
            if (_ds.Tables.Contains("LICHKHAM") == false)
            {
                LoadData(tabselected);
                if (_ds.Tables.Contains("NHANVIEN") == false)
                {
                    LoadData("NHANVIEN");
                }
                if (_ds.Tables.Contains("BENHNHAN") == false)
                {
                    LoadData("BENHNHAN");                    
                }               
                DgvLichKham.DataSource = _ds.Tables[tabselected];                
            }
            else
                DgvLichKham.DataSource = _ds.Tables[tabselected];
        }
        private void bt_CTHD_HD_Click(object sender, EventArgs e)
        {
            tabselected = "CHITET_HD_DIEUTRI";
            if (_ds.Tables.Contains(tabselected) == false)
            {
                LoadData(tabselected);
                DgvCTHD.DataSource = _ds.Tables[tabselected];
            }
            else
                DgvCTHD.DataSource = _ds.Tables[tabselected];
        }
        /// <summary>
        /// Them Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_them_BenhNhan_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = _ds.Tables[tabselected].NewRow();
                dr[0] = txt_MaBN.Text;
                dr[1] = txt_HoBN.Text;
                dr[2] = txt_TenBN.Text;
                dr[3] = txt_NgaysinhBN.Text;
                dr[4] = txt_GioiTinhBN.Text;
                dr[5] = txt_DiaChiBN.Text;
                dr[6] = txt_SDTBN.Text;
                _ds.Tables[tabselected].Rows.Add(dr);
            }
            catch (DataException ex)
            {
                MessageBox.Show("Loi them du lieu\n" + ex.ToString());
                throw;
            }
        }
        /// <summary>
        /// Xoa data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// DGV selectionchanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBenhNhan.CurrentRow != null)
            {
                txt_MaBN.Text = DgvBenhNhan.CurrentRow.Cells[0].Value.ToString();
                txt_HoBN.Text = DgvBenhNhan.CurrentRow.Cells[1].Value.ToString();
                txt_TenBN.Text = DgvBenhNhan.CurrentRow.Cells[2].Value.ToString();
                txt_NgaysinhBN.Text = DgvBenhNhan.CurrentRow.Cells[3].Value.ToString();                
                txt_GioiTinhBN.Text = DgvBenhNhan.CurrentRow.Cells[4].Value.ToString();
                txt_DiaChiBN.Text = DgvBenhNhan.CurrentRow.Cells[5].Value.ToString();
                txt_SDTBN.Text = DgvBenhNhan.CurrentRow.Cells[6].Value.ToString();
                
            }
        }
        private void DgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(DgvHoaDon.CurrentRow != null)
            {   
                string sNV = DgvHoaDon.CurrentRow.Cells["MaNV"].Value.ToString();
                DataRow foundRowNV = _ds.Tables["NHANVIEN"].Rows.Find(sNV);
                string sBN = DgvHoaDon.CurrentRow.Cells["MaBN"].Value.ToString();
                DataRow foundRowBN = _ds.Tables["BENHNHAN"].Rows.Find(sBN);
                
                txt_MaHD.Text = DgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
                txt_TenNV_HD.Text = foundRowNV[1].ToString() + " " + foundRowNV[2].ToString();
                txt_TenBN_HD.Text = foundRowBN[1].ToString() + " " + foundRowBN[2].ToString();
                txt_NgayDT_HD.Text = DgvHoaDon.CurrentRow.Cells["NgayDT"].Value.ToString();
            }
        }    
        /// <summary>
        /// Luu DATA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Luu_BenhNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabselected != "")
                { 
                    DialogResult rs = MessageBox.Show("Bạn có muốn lưu?", "Lưu", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        _da.Update(_ds.Tables[tabselected]);
                    }                    
                 }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
        
        /// <summary>
        /// Sua DATA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void bt_Sua_HD_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_Them_HD_Click(object sender, EventArgs e)
        {

        }
        //DS trong ngay
        private void button2_Click(object sender, EventArgs e)
        {
            if (_ds.Tables.Contains(tabselected) == false)
                bt_DanhSach_LichKham.PerformClick();
            if (_ds.Tables.Contains("DSKHAMHIENTAI") == false)
            { 
                DateTime dt = DateTime.Now;
                //DateTime dt2 = new DateTime(2016, 3, 30);               
                SqlCommand sqlComm = new SqlCommand("DSKHAM_HIENTAI", _cn);
                sqlComm.Parameters.AddWithValue("@date", dt);
                sqlComm.CommandType = CommandType.StoredProcedure;               
                _da.SelectCommand = sqlComm;
                _da.Fill(_ds,"DSKHAMHIENTAI");
                DgvLichKham.DataSource = _ds.Tables["DSKHAMHIENTAI"];
            }
            else
                DgvLichKham.DataSource = _ds.Tables["DSKHAMHIENTAI"];
        }
    }
}


