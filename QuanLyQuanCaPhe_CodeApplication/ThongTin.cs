﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class ThongTin : Form
    {
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        string GT;
        public ThongTin(string tenNV, string maNV)
        {
            InitializeComponent();
            lbTen.Text = tenNV;
            lbma.Text = maNV;

            conn = new SqlConnection(strConnectionString);
            string query1 = "SELECT QueQuan FROM NhanVien" +
                    " where MaNhanVien =@maNV";
            SqlCommand command = new SqlCommand(query1, conn);
            command.Parameters.AddWithValue("@maNV", maNV);

            string query2 = "SELECT SDT FROM NhanVien" +
                    " where MaNhanVien =@maNV";
            SqlCommand command1 = new SqlCommand(query2, conn);
            command1.Parameters.AddWithValue("@maNV", maNV);

            string query3 = "SELECT Tuoi FROM NhanVien" +
                " where MaNhanVien =@maNV";
            SqlCommand command2 = new SqlCommand(query3, conn);
            command2.Parameters.AddWithValue("@maNV", maNV);

            string query4 = "SELECT GioiTinh FROM NhanVien" +
                    " where MaNhanVien =@maNV";
            SqlCommand command3 = new SqlCommand(query4, conn);
            command3.Parameters.AddWithValue("@maNV", maNV);

            string query5 = "SELECT DiaChi FROM NhanVien" +
                    " where MaNhanVien =@maNV";
            SqlCommand command4 = new SqlCommand(query5, conn);
            command4.Parameters.AddWithValue("@maNV", maNV);

            conn.Open();
            string que = (string)command.ExecuteScalar();
            string sdt = (string)command1.ExecuteScalar();
            int Tuoi = (int)command2.ExecuteScalar();
            string gioitinh = (string)command3.ExecuteScalar();
            string DC = (string)command4.ExecuteScalar();

            txtQue.Text = que;
            txtSDT.Text = sdt;
            txtTuoi.Text = Tuoi.ToString();
            if (gioitinh == "Nam")
            {
                checkNam.Checked = true;
                checkNu.Checked = false;
            }
            if (gioitinh == "Nữ")
            {
                checkNam.Checked = false;
                checkNu.Checked = true;
            }
            txtDC.Text = DC;
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtQue.Text == null || txtQue.Text.Equals(""))
            {
                MessageBox.Show("Quê quán chưa được nhập");
                return;
            }

            if (txtSDT.Text == null || txtSDT.Text.Equals(""))
            {
                MessageBox.Show("Số điện thoại chưa được nhập");
                return;
            }

            if (txtTuoi.Text == null || txtTuoi.Text.Equals(""))
            {
                MessageBox.Show("Tuổi chưa được nhập");
                return;
            }

            if (checkNam.Checked == false && checkNu.Checked == false)
            {
                MessageBox.Show("Giới tính chưa được nhập");
                return;
            }

            if (txtDC.Text == null || txtDC.Text.Equals(""))
            {
                MessageBox.Show("Địa chỉ chưa được nhập");
                return;
            }

            try
            {
                // Thực hiện lệnh
                conn = new SqlConnection(strConnectionString);
                conn.Open();
                // Tạo đối tượng SqlCommand và chỉ định kiểu CommandType là StoredProcedure
                SqlCommand command = new SqlCommand("spCapNhatNhanVien", conn);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào đối tượng SqlCommand
                command.Parameters.AddWithValue("@MaNhanVien", lbma.Text.ToString());
                command.Parameters.AddWithValue("@HoVaTen", lbTen.Text.ToString());
                command.Parameters.AddWithValue("@SDT", txtSDT.Text.ToString());
                command.Parameters.AddWithValue("@Tuoi", txtTuoi.Text.ToString());
                command.Parameters.AddWithValue("@DiaChi", txtDC.Text.ToString());
                if (checkNam.Checked == true && checkNu.Checked == false)
                {
                    GT = "Nam";
                }
                if (checkNam.Checked == false && checkNu.Checked == true)
                {
                    GT = "Nữ";
                }
                command.Parameters.AddWithValue("@GioiTinh", GT.ToString());
                command.Parameters.AddWithValue("@QueQuan", txtQue.Text.ToString());
                // Thực thi Stored Procedure
                command.ExecuteNonQuery();
                //Đóng kết nối
                conn.Close();
                // Thông báo
                MessageBox.Show("Đã sửa thông tin xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể cập nhật!");
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
