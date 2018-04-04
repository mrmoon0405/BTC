using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyCuaHangBanDoAnhNhanh_NguyenAnhDung_17
{
    public partial class Form1 : Form
    {
        string _flag = "";
        string connectionString = @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=NguyenAnhDung_QlyCuaHangBanDoAnNhanh_17;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            lockcontrol();
        }
        void lockcontrol()
        {
            btnaddncc.Enabled = false;
            btneditncc.Enabled = false;
            btnsavencc.Enabled = false;
            btncancelncc.Enabled = false;
            btndeletencc.Enabled = false;
            btnfindncc.Enabled = false;
        }
        void unlockcontrol()
        {
            btnaddncc.Enabled = true;
            btneditncc.Enabled = true;
            btndeletencc.Enabled = true;
            btnsavencc.Enabled = false;
            btncancelncc.Enabled = false;
            btnfindncc.Enabled = true;
        }
        void unlocksave()
        {
            btncancelncc.Enabled = true;
            btnsavencc.Enabled = true;
            btnaddncc.Enabled = false;
            btneditncc.Enabled = false;
            btndeletencc.Enabled = false;
        }
        void getNCC()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "getNCC";
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dsKhachHang = new DataSet();
                adapter.Fill(dsKhachHang);
                dgvNCC.DataSource = dsKhachHang.Tables[0];
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
        void autoidNCC()
        {
            int count = 0;
            count = dgvNCC.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvNCC.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            chuoi = chuoi + chuoi2.ToString();
            chuoi = chuoi + "0";
            if (chuoi2 + 1 < 10)
            {
                txtidncc.Text= "NCC0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txtidncc.Text = "NCC" + (chuoi2 + 1).ToString();
            }
        }
        void addNCC()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("addNCC", con);
                    command.CommandType = CommandType.StoredProcedure;
                    if (txtnamencc.Text == "")
                        MessageBox.Show("Bạn Chưa Nhập Tên");
                    if (txtaddressncc.Text == "")
                        MessageBox.Show("Bạn Chưa Nhập Địa Chỉ");
                    if (txttelephonenumberncc.Text == "")
                        MessageBox.Show("Bạn Chưa Nhập SDT");
                    if (txtnamencc.Text != "" && txtaddressncc.Text != "" && txttelephonenumberncc.Text != "")
                    {
                        command.Parameters.AddWithValue("@_idNCC", txtidncc.Text);
                        command.Parameters.AddWithValue("@_tenNCC", txtnamencc.Text);
                        command.Parameters.AddWithValue("@_DC", txtaddressncc.Text);
                        command.Parameters.AddWithValue("@_SDT", txttelephonenumberncc.Text);
                        command.ExecuteNonQuery();
                        getNCC();
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
        void editNCC()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("editNCC", con);
                    command.CommandType = CommandType.StoredProcedure;
                    if (txtnamencc.Text == "")
                        MessageBox.Show("Bạn Chưa Nhập Tên");
                    if (txtaddressncc.Text == "")
                        MessageBox.Show("Bạn Chưa Nhập Địa Chỉ");
                    if (txttelephonenumberncc.Text == "")
                        MessageBox.Show("Bạn Chưa Nhập SDT");
                    if (txtnamencc.Text != "" && txtaddressncc.Text != "" && txttelephonenumberncc.Text != "")
                    {
                        command.Parameters.AddWithValue("@_idNCC", txtidncc.Text);
                        command.Parameters.AddWithValue("@_tenNCC", txtnamencc.Text);
                        command.Parameters.AddWithValue("@_DC", txtaddressncc.Text);
                        command.Parameters.AddWithValue("@_SDT", txttelephonenumberncc.Text);
                        command.ExecuteNonQuery();
                        getNCC();
                        MessageBox.Show("Sửa Thành Công");
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
        void deleteNCC()
        {
            {
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "deleteNCC";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_idNCC", txtidncc.Text);
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    getNCC();
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
        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidncc.Text = dgvNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnamencc.Text = dgvNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtaddressncc.Text = dgvNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
            txttelephonenumberncc.Text = dgvNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void btngetncc_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            getNCC();
        }
        private void btnaddncc_Click(object sender, EventArgs e)
        {
            _flag = "add";
            autoidNCC();
            unlocksave();
            txtidncc.ReadOnly = true;
        }
        private void btneditncc_Click(object sender, EventArgs e)
        {
            editNCC();
            _flag = "edit";
            unlocksave();
        }
        private void btndeletencc_Click(object sender, EventArgs e)
        {
                deleteNCC();
                MessageBox.Show("Xóa Thành Công");
        }
        private void btncancelncc_Click(object sender, EventArgs e)
        {
            txtnamencc.Clear();
            unlockcontrol();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.nguyenAnhDung_QlyCuaHangBanDoAnNhanh_17DataSet.NCC);

        }
        private void btnfindncc_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("findNCC", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@_TenNCC", cbbfindncc.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dshang = new DataSet();
                adapter.Fill(dshang);
                dgvNCC.DataSource = dshang.Tables[0];
                con.Close();
            }
        }
        private void btnsavencc_Click(object sender, EventArgs e)
        {
            if (_flag == "add")
            {
                addNCC();
            }
            if (_flag == "edit")
            {
                editNCC();
            }
            unlockcontrol();
            txtidncc.ReadOnly = true;
        }
}
}
