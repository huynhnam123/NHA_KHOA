using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PhongKham
{
    public partial class BacSi : Form
    {
        public BacSi()
        {
            InitializeComponent();
        }
        const string _cnstr = @"Server= .; Database= QLBanHang; Integrated security = true";
        SqlConnection _cn = new SqlConnection(_cnstr);
        private void connect()
        {
            try
            {
                if (_cn != null && _cn.State == ConnectionState.Closed)
                    _cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: ket noi " + ex.ToString());
            }
        }

        private void disconnect()
        {
            try
            {
                if (_cn != null && _cn.State == ConnectionState.Open)
                    _cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: ket noi " + ex.ToString());
            }
        }
        void loadDaTa()
        {
            string sql = @"SELECT * FROM BacSi";
            SqlCommand cmd = new SqlCommand(sql, _cn);
            connect();
            SqlDataReader dr = cmd.ExecuteReader();
            List<ClassBacSi> list = new List<ClassBacSi>();
            string maBS, tenBS, Dc, Dt, Ns, Gt;
            while (dr.Read())
            {
                maBS = dr.GetString(0);
                tenBS = dr.GetString(1);
                Ns = dr.GetString(2);
                Gt = dr.GetString(3);
                Dc = dr.GetString(4);
                Dt = dr.GetString(5);

                ClassBacSi BS = new ClassBacSi(maBS, tenBS, Ns, Gt, Dc, Dt);
                list.Add(BS);
            }

            dr.Close();
            DataGrviewBS.DataSource = list;
            disconnect();
        }
        private void BacSi_Load(object sender, EventArgs e)
        {
            loadDaTa();
        }

        private void btAddBS_Click(object sender, EventArgs e)
        {
            connect();
            string sql = @"INSERT INTO KhachHang VALUES (@ma,@ten, @ns, @gt, @dc, @dt)";
            SqlCommand cmd = new SqlCommand(sql, _cn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@ma", txtMaBS.Text));
            cmd.Parameters.Add(new SqlParameter("@ten", txtTenBS.Text));
            cmd.Parameters.Add(new SqlParameter("@ns", txtNsBS.Text));
            cmd.Parameters.Add(new SqlParameter("@gt", txtGtBS.Text));
            cmd.Parameters.Add(new SqlParameter("@dc", txtDcBS.Text));
            cmd.Parameters.Add(new SqlParameter("@dt", txtDtBS.Text));
        }

        private void btXoaBS_Click(object sender, EventArgs e)
        {
            string xoa = "DELETE FROM BacSi Where MaBS=@ma";
            connect();
            SqlCommand cmd = new SqlCommand(xoa, _cn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", txtMaBS.Text);
            cmd.ExecuteNonQuery();
            disconnect();
            loadDaTa();
        }

        private void btSuaBS_Click(object sender, EventArgs e)
        {
            string sua = "UPDATE KhachHang SET MaBS = @ma, TenBS = @ten, DiaChi = @dc, DienThoai = @dt, Fax = @f WHERE KhachHang.MaKH='" + DataGrviewBS.CurrentRow.Cells[0].Value.ToString() + "'";
            connect();
            SqlCommand cmd = new SqlCommand(sua, _cn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", txtMaBS.Text);
            cmd.Parameters.AddWithValue("@ten", txtTenBS.Text);
            cmd.Parameters.AddWithValue("@ns", txtNsBS.Text);
            cmd.Parameters.AddWithValue("@gt", txtGtBS.Text);
            cmd.Parameters.AddWithValue("@dc", txtDcBS.Text);
            cmd.Parameters.AddWithValue("@dt", txtDtBS.Text);
            cmd.ExecuteNonQuery();
            disconnect();
            loadDaTa();
        }

        private void btThoatBS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
