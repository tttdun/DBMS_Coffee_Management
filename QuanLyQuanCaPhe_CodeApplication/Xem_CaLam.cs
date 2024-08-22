using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class Xem_CaLam : Form
    {
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtSanPham 
        SqlDataAdapter daCaLam = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtCaLam = null;

        public Xem_CaLam(string tenNV, string maNV)
        {
            InitializeComponent();
            lbMa.Text = maNV;
            lbTen.Text = tenNV;
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNgayLam == null || txtNgayLam.Equals(""))
            {
                MessageBox.Show("Ngày làm chưa được nhập");
                return;
            }

            if (txtTimeStart.Text == null || txtTimeStart.Text.Equals(""))
            {
                MessageBox.Show("Giờ bắt đầu chưa được nhập");
                return;
            }

            if (txtTimeEnd.Text == null || txtTimeEnd.Text.Equals(""))
            {
                MessageBox.Show("Giờ kết thúc chưa được nhập");
                return;
            }

            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                conn.Open();
                // Câu lệnh SQL
                
                cmd.CommandText = System.String.Concat("INSERT INTO ChamCong (MaNhanVien, ThoiGianBatDau, ThoiGianKetThuc, NgayLam) " +
                    "VALUES('" + lbMa.Text.ToString() + "', '" + txtTimeStart.Text + "', '" + txtTimeEnd.Text +
                    "', CAST('" + txtNgayLam.Text.ToString() + "' AS datetime))");
                MessageBox.Show("Đã đăng ký!");
                // Cập nhật
                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                // Thông báo
                
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Đăng ký không thành công!");
            }
        }
        void LoadData()
        {
            conn = new SqlConnection(strConnectionString);
            // Lấy dữ liệu từ View
            string query = "SELECT NgayLam as N'Ngày làm', ThoiGianBatDau as N'Thời gian bắt đầu', ThoiGianKetThuc as N'Thời gian kết thúc'"
                + "FROM " + "View_CaLam"
                + " where MaNhanVien = '" + lbMa.Text.ToString() + "'";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            //Truyền dữ liệu vào dgv
            daCaLam = new SqlDataAdapter(query, conn);
            dtCaLam = new DataTable();
            dtCaLam.Clear();
            daCaLam.Fill(dtCaLam);

            // Hiển thị dữ liệu lên DataGridView
            dgvCaLam.DataSource = dtCaLam;
            // Cấu hình DataGridView theo ý muốn
            dgvCaLam.AutoResizeColumns();
            // Thêm DataGridView vào Form
            this.Controls.Add(dgvCaLam);

            // Đóng kết nối
            conn.Close();
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
