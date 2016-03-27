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
        int tb_count = 0;
        private SqlCommandBuilder _cb;
        string tabselected = "BENHNHAN";
        int Cbt1 = 0, Cbt2 = 0, Cbt3 = 0, Cbt4 = 0, Cbt5 = 0, Cbt6 = 0, Cbt7 = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _cn.Open();
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
                tb_count = _ds.Tables.Count;
                txtDS_Count.Text = Convert.ToString(tb_count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu:\n" + ex);
                //  throw;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (Cbt1 == 0)
            {
                Cbt1 = 1;
                tabselected = "NHANVIEN";
                txtNhanVien.Text = tabselected;
                LoadData();
                DgvNhanVien.DataSource = _ds.Tables["NHANVIEN"];
            }
            else
                DgvNhanVien.DataSource = _ds.Tables["NHANVIEN"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cbt2 == 0)
            {
                Cbt2 = 1;
                tabselected = "BENHNHAN";
                txtBenhNhan.Text = tabselected;
                LoadData();
                DgvBenhNhan.DataSource = _ds.Tables["BENHNHAN"];
            }
            else
                DgvBenhNhan.DataSource = _ds.Tables["BENHNHAN"];
        }

        private void bt_them_benhnhan_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = _ds.Tables[0].NewRow();
                dr["MaBN"] = txt_MaBN.Text;
                dr["HoBN"] = txt_HoBN.Text;
                dr["TenBN"] = txt_TenBN.Text;
                dr["Ngaysinh"] = txt_Ngaysinh.Text;
                dr["GioiTinh"] = txt_GioiTinh.Text;
                dr["DiaChi"] = txt_DiaChi.Text;
                dr["SDT"] = txt_SDT.Text;
                _ds.Tables[0].Rows.Add(dr);
            }
            catch (DataException ex)
            {
                MessageBox.Show("Loi them du lieu\n" + ex.ToString());
                throw;
            }
        }

        private void bt_Xoa_benhnhan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection _cn = new SqlConnection(_cnstr);
                _cn.Open();
                int currenindex = DgvBenhNhan.CurrentCell.RowIndex;
                string MaBN = Convert.ToString(DgvBenhNhan.Rows[currenindex].Cells[0].Value.ToString());
                string dltStr = " Xoa Benh Nhan tu MaBN=' " + MaBN + " ' ";
                SqlCommand dltCmd = new SqlCommand(dltStr, _cn);
                dltCmd.CommandType = CommandType.Text;
                dltCmd.ExecuteNonQuery();
                _da.Update(_ds, "BENHNHAN");
                LoadData();
                MessageBox.Show("Bạn đã xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                _cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBenhNhan.CurrentRow != null)
            {
                txt_MaBN.Text = DgvBenhNhan.CurrentRow.Cells["MaBN"].Value.ToString();
                txt_HoBN.Text = DgvBenhNhan.CurrentRow.Cells["HoBN"].Value.ToString();
                txt_TenBN.Text = DgvBenhNhan.CurrentRow.Cells["TenBN"].Value.ToString();
                txt_Ngaysinh.Text = DgvBenhNhan.CurrentRow.Cells["Ngaysinh"].Value.ToString();
                txt_GioiTinh.Text = DgvBenhNhan.CurrentRow.Cells["GioiTinh"].Value.ToString();
                txt_DiaChi.Text = DgvBenhNhan.CurrentRow.Cells["DiaChi"].Value.ToString();
                txt_SDT.Text = DgvBenhNhan.CurrentRow.Cells["SDT"].Value.ToString();
            }
        }

        private void bt_Thoat_benhnhan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Luu_benhnhan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection _cn = new SqlConnection(_cnstr);
                _cn.Open();
                int currentIndex = DgvBenhNhan.CurrentCell.RowIndex;
                string MaBN = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string HoBN = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string TenBN = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string Ngaysinh = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string GioiTinh = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string DiaChi = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string SDT = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string insertStr = " Them vao benh nhan gia tri !'" + MaBN + "'.'" + HoBN + "'.'" + TenBN + "'.'" + Ngaysinh + "'.'" + GioiTinh + "'.'" + DiaChi + "'.'" + SDT + "')";
                SqlCommand insertCmd = new SqlCommand(insertStr, _cn);
                insertCmd.CommandType = CommandType.Text;
                insertCmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã lưu thành công ! ", "THÔNG BÁO", MessageBoxButtons.OK);
                _cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void bt_Sua_benhnhan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection _cn = new SqlConnection(_cnstr);
                _cn.Open();
                int currentIndex = DgvBenhNhan.CurrentCell.RowIndex;
                string MaBN = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string HoBN = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string TenBN = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string Ngaysinh = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string GioiTinh = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string DiaChi = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string SDT = Convert.ToString(DgvBenhNhan.Rows[currentIndex].Cells[0].Value.ToString());
                string updateStr = " Sua thong tin benh nhan MaBN= '" + MaBN + "'.HoBN='" + HoBN + "'.TenBN='" + TenBN + "'.Ngaysinh='" + Ngaysinh + "'.GioiTinh='" + GioiTinh + "'.DiaChi='" + DiaChi + "'.SDT='" + SDT + "')";
                SqlCommand updateCmd = new SqlCommand(updateStr, _cn);
                updateCmd.CommandType = CommandType.Text;
                updateCmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Bạn đã sửa thành công ! ", "THÔNG BÁO", MessageBoxButtons.OK);
                _cn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}


/*
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
        const string _cnstr = "Server = .; Database = NHAKHOA; Integrated Security = true; User id = sa; password= 123123";
        //SqlConnection _cn;
        SqlConnection _cn = new SqlConnection(_cnstr);
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Connect();
            LoadData();
            Disconnect();
        }
        private void Connect()
        {
            try
            {
                if (_cn.State == ConnectionState.Closed)
                    _cn.Open();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở kết nối " + ex);
                //throw;
            }
        }
        private void Disconnect()
        {
            try
            {
                if (_cn.State == ConnectionState.Open)
                    _cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đóng kết nối " + ex);
                //throw;
            }
        }
        public void LoadData()
        {
            try
            {            
                const string _str = @"SELECT * FROM NHANVIEN"; 
                Connect();
                SqlCommand _cmd = new SqlCommand(_str, _cn);
                //_cmd.CommandType = CommandType.Text;
                SqlDataReader _rd = _cmd.ExecuteReader();
                string _maNV, _hoNV ,_tenNV, _gtNV,_dcNV ,_dtNV,_cvNV, _knNV;
                DateTime _nsNV, _nbdlNV;
                decimal _mlNV;
               List<NhanVien> list = new List<NhanVien>();
                while (_rd.Read())
                {                
                   _maNV = _rd.GetString(0);
                   _hoNV = _rd.GetString(1);
                   _tenNV =_rd.GetString(2);
                   _nsNV = _rd.GetDateTime(3);
                   _gtNV = _rd.GetString(4);
                   _dcNV = _rd.GetString(5);           
                   _dtNV = _rd.GetString(6);
                   _cvNV = _rd.GetString(7);
                   _knNV = _rd.GetString(8);
                   _nbdlNV = _rd.GetDateTime(9);
                   _mlNV = _rd.GetDecimal(10);
                  NhanVien NV = new NhanVien(_maNV, _hoNV, _tenNV, _nsNV, _gtNV, _dcNV, _dtNV, _cvNV, _knNV, _nbdlNV, _mlNV);
                  list.Add(NV);
                }
                _rd.Close();
                DGV.DataSource = list;
                Disconnect();        
            }

            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
                throw;
            }
        }
      
    }
}
*/