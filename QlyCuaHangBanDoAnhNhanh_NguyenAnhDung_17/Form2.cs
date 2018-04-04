using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QlyCuaHangBanDoAnhNhanh_NguyenAnhDung_17
{
    public partial class Form2 : Form
    {
        string _flag = "";
        string connectionString = @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=NguyenAnhDung_QlyCuaHangBanDoAnNhanh_17;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
            lockcontrolPTT();
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            dgvPTT.Visible = false;
            btndetailadd.Enabled = false;
            loadPTT();
        }
        void loadPTT()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "loadPTT";
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dsKhachHang = new DataSet();
                adapter.Fill(dsKhachHang);
                dgvPTT.DataSource = dsKhachHang.Tables[0];
            }
            catch
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        void getPTT()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "getPTT";
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dsKhachHang = new DataSet();
                adapter.Fill(dsKhachHang);
                dgvPTT.DataSource = dsKhachHang.Tables[0];
            }
            catch
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        void addPTT()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("addPTT", con);
                    command.CommandType = CommandType.StoredProcedure;
                    if (txtnamePTT.Text == "")
                        MessageBox.Show("Bạn Chưa Nhập Tên Người Lập Phiếu ");
                    if (cbbCaPTT.Text == "")
                        MessageBox.Show("Bạn Chưa Nhập Ca Làm");
                    if (txtnamePTT.Text != "" && cbbCaPTT.Text != "")
                    {
                        command.Parameters.AddWithValue("@_idPTT", txtidPTT.Text);
                        command.Parameters.AddWithValue("@_NguoiBan", txtnamePTT.Text);
                        command.Parameters.AddWithValue("@_Ca", cbbCaPTT.Text);
                        command.Parameters.AddWithValue("@_NgayBan", dtpdaysell.Value);
                        command.ExecuteNonQuery();
                        loadPTT();
                        MessageBox.Show("Thêm Thành Công");
                    }
                }
                catch
                {

                }
                finally
                {
                    if (con != null && con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
        void autoidPTT()
        {
            int count = 0;
            count = dgvPTT.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvPTT.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            chuoi = chuoi + chuoi2.ToString();
            chuoi = chuoi + "0";
            if (chuoi2 + 1 < 10)
            {
                txtidPTT.Text = "PTT0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtidPTT.Text = "PTT" + (chuoi2 + 1).ToString();
            }
        }
        void lockcontrolPTT()
        {
            btnaddPTT.Enabled = true;
            btncancelPTT.Enabled = false;
            btnsavePTT.Enabled = false;
        }
        void lockcontrolDPTT()
        {
            btnadddetail.Enabled = true;
            btneditdetail.Enabled = false;
            btndeletedetail.Enabled = false;
            txttotalmoney.ReadOnly = true;
            btnsavedetail.Enabled = false;
            btncanceldetail.Enabled = false;
        }
        void unlockcontrolPTT()
        {
            btnaddPTT.Enabled = false;
            btncancelPTT.Enabled = true;
            btnsavePTT.Enabled = true;
        }
        void unlockcontrolDPTT()
        {
            btnsavedetail.Enabled = false;
            btncanceldetail.Enabled = false;
            btneditdetail.Enabled = true;
            btndeletedetail.Enabled = true;
            btnadddetail.Enabled = true;
        }
        void getdetailsPTT()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "getDPTT";
                command.Parameters.AddWithValue("@_idPTT", cbbidptt.Text);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dsKhachHang = new DataSet();
                adapter.Fill(dsKhachHang);
                dgvPTT.DataSource = dsKhachHang.Tables[0];
            }
            catch
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        void ThanhTienPTT()
        {
            int SoLuong, DonGia;
            SoLuong = Convert.ToInt32(txtnumberptt.Text);
            DonGia = Convert.ToInt32(txtpriceptt.Text);
            int ThanhTien;
            ThanhTien = SoLuong * DonGia;
            txttotalmoney.Text = ThanhTien.ToString();
        }
        void TongTien()
        {
            int Sum = 0;
            for (int i = 0; i < dgvPTT.Rows.Count; ++i)
            {
                Sum += Convert.ToInt32(dgvPTT.Rows[i].Cells[5].Value);
            }
            txttongtien.Text = Sum.ToString();
        }
        void addDPTT()
        {

            int SoLuong, DonGia;
            SoLuong = Convert.ToInt32(txtnumberptt.Text);
            DonGia = Convert.ToInt32(txtpriceptt.Text);
            int ThanhTien;
            ThanhTien = SoLuong * DonGia;
            txttotalmoney.Text = ThanhTien.ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("addDPTT", con);
                    command.CommandType = CommandType.StoredProcedure;
                    {
                        command.Parameters.AddWithValue("@_idPTT", cbbidptt.Text);
                        command.Parameters.AddWithValue("@_idmon", cbbidfood.Text);
                        command.Parameters.AddWithValue("@_SoLuong", txtnumberptt.Text);
                        command.Parameters.AddWithValue("@_DonGia", txtpriceptt.Text);
                        command.Parameters.AddWithValue("@_ThanhTien", txttotalmoney.Text);
                        command.Parameters.AddWithValue("@_TenMon", cbbidMon.Text);
                        command.ExecuteNonQuery();
                        getdetailsPTT();
                        MessageBox.Show("Thêm Thành Công");
                    }
                }
                catch
                {

                }
                finally
                {
                    if (con != null && con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
        void editDPTT()
        {
            int SoLuong, DonGia;
            SoLuong = Convert.ToInt32(txtnumberptt.Text);
            DonGia = Convert.ToInt32(txtpriceptt.Text);
            int ThanhTien;
            ThanhTien = SoLuong * DonGia;
            txttotalmoney.Text = ThanhTien.ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("editDPTT", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_idPTT", cbbidptt.Text);
                    command.Parameters.AddWithValue("@_idMon", cbbidfood.Text);
                    command.Parameters.AddWithValue("@_DonGia", txtpriceptt.Text);
                    command.Parameters.AddWithValue("@_SoLuong", txtnumberptt.Text);
                    command.Parameters.AddWithValue("@_ThanhTien", txttotalmoney.Text);
                    command.Parameters.AddWithValue("@_TenMon", cbbidMon.Text);
                    command.ExecuteNonQuery();
                    getdetailsPTT();
                    MessageBox.Show("Sửa Thành Công");
                }
                catch
                {

                }
                finally
                {
                    if (con != null && con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
        void deleteDPTT()
        {
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "deleteDPTT";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_idMon", cbbidfood.Text);
                    command.Parameters.AddWithValue("@_idPTT", cbbidptt.Text);
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    getdetailsPTT();
                }
                catch
                {
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }
        private void btnaddPTT_Click(object sender, EventArgs e)
        {
            txtidPTT.ReadOnly = true;
            autoidPTT();
            unlockcontrolPTT();
        }
        private void btnsavePTT_Click(object sender, EventArgs e)
        {
            addPTT();
            btndetailadd.Enabled = true;
        }
        private void btncancelPTT_Click(object sender, EventArgs e)
        {
            txtidPTT.Clear();
            txtnamePTT.Clear();
        }
        private void btndetailadd_Click(object sender, EventArgs e)
        {

            getPTT();
            lockcontrolDPTT();
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            dgvPTT.Visible = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet2.PTT' table. You can move, or remove it, as needed.
            this.pTTTableAdapter.Fill(this.nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet2.PTT);
            // TODO: This line of code loads data into the 'nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet1.MonAn' table. You can move, or remove it, as needed.
            this.monAnTableAdapter.Fill(this.nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet1.MonAn);

        }
        private void btnadddetail_Click(object sender, EventArgs e)
        {
            btneditdetail.Enabled = false;
            btndeletedetail.Enabled = false;
            btnadddetail.Enabled = false;
            btnsavedetail.Enabled = true;
            btncanceldetail.Enabled = true;
            cbbidptt.Text = txtidPTT.Text;
            _flag = "add";
        }
        private void btneditdetail_Click(object sender, EventArgs e)
        {
            btneditdetail.Enabled = false;
            btndeletedetail.Enabled = false;
            btnadddetail.Enabled = false;
            btnsavedetail.Enabled = true;
            btncanceldetail.Enabled = true;
            _flag = "edit";
        }
        private void btndeletedetail_Click(object sender, EventArgs e)
        {
            
            deleteDPTT();
        }
        private void btnsavedetail_Click(object sender, EventArgs e)
        {
            if (_flag == "add")
            {
                addDPTT();
            }
            if (_flag == "edit")
            {
                editDPTT();
            }
            TongTien();
            unlockcontrolDPTT();
        }
        private void btncanceldetail_Click(object sender, EventArgs e)
        {
            txtpriceptt.Clear();
            txttotalmoney.Clear();
            txtnumberptt.Clear();
            unlockcontrolDPTT();
        }
        private void dgvPTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpriceptt.Text = dgvPTT.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtnumberptt.Text = dgvPTT.Rows[e.RowIndex].Cells[4].Value.ToString();
            txttotalmoney.Text = dgvPTT.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void cbbidptt_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdetailsPTT();
        }

        private void btnonemore_Click(object sender, EventArgs e)
        {
            lockcontrolPTT();
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            dgvPTT.Visible = false;
            btndetailadd.Enabled = false;
            loadPTT();
        }
    }
}
