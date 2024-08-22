﻿using System;
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
    public partial class Them_ThucUong : Form
    {
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        public Them_ThucUong()
        {
            InitializeComponent();

            //truyền dữ liệu vào ComboBox
            conn = new SqlConnection(strConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT MaNhomThucUong FROM NhomThucUong", conn);
            conn.Open();
            //Lấy dữ liệu vào DataBox
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbMaNhomTU.Items.Add(reader["MaNhomThucUong"].ToString());
            }
            conn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaTU.Text == null || txtMaTU.Text.Equals(""))
            {
                MessageBox.Show("Mã thức uống chưa được nhập");
                return;
            }

            if (txtTenTU.Text == null || txtTenTU.Text.Equals(""))
            {
                MessageBox.Show("Tên thức uống chưa được nhập");
                return;
            }

            if (cbMaNhomTU.Text == null || cbMaNhomTU.Text.Equals(""))
            {
                MessageBox.Show("Mã nhóm thức uống chưa được chọn");
                return;
            }

            if (txtGia.Text == null || txtGia.Text.Equals(""))
            {
                MessageBox.Show("Giá bán chưa được nhập");
                return;
            }

            try
            {
                // Thực hiện lệnh
                conn = new SqlConnection(strConnectionString);
                conn.Open();

                // Tạo đối tượng SqlCommand và chỉ định kiểu CommandType là StoredProcedure
                SqlCommand command = new SqlCommand("spThemThucUong", conn);
                command.CommandType = CommandType.StoredProcedure;


                string MaNhomTU = cbMaNhomTU.SelectedItem.ToString();

                //@MaNhanVien, @HoVaTen, @SDT, @Tuoi, @DiaChi, @GioiTinh, @QueQuan, @ChucVu
                // Thêm các tham số vào đối tượng SqlCommand
                command.Parameters.AddWithValue("@MaThucUong", txtMaTU.Text.ToString());
                command.Parameters.AddWithValue("@TenThucUong", txtTenTU.Text.ToString());
                command.Parameters.AddWithValue("@MaNhomThucUong", MaNhomTU);
                command.Parameters.AddWithValue("@GiaBan", txtGia.Text.ToString());
                // Thực thi Stored Procedure
                command.ExecuteNonQuery();
                //Đóng kết nối
                conn.Close();
                // Thông báo
                MessageBox.Show("Đã thêm Thức uống  " + txtTenTU.Text.ToString() + " xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thêm thức uống!");
            }

            // Đóng kết nối
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
