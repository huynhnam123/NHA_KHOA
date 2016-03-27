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
        int tb_count=0;
        private SqlCommandBuilder _cb;
        string tabselected = "BENHNHAN";
        int Cbt1 = 0, Cbt2 = 0, Cbt3 = 0, Cbt4 = 0, Cbt5 = 0, Cbt6 = 0, Cbt7 = 0;      
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
   
        public void LoadData()
        {
            string str = @"SELECT * FROM "+ tabselected +"";                   
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