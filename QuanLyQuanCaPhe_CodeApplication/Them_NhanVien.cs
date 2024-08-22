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

namespace QuanLyQuanCaPhe
{
    public partial class Them_NhanVien : Form
    {
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;

        string gioitinh;
        string CV;
        public Them_NhanVien()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == null || txtTenNV.Text.Equals(""))
            {
                MessageBox.Show("Tên nhân viên chưa được nhập");
                return;
            }

            if (txtMaNV.Text == null || txtMaNV.Text.Equals(""))
            {
                MessageBox.Show("Mã nhân viên chưa được nhập");
                return;
            }

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

            if (checkNV.Checked == false && checkQL.Checked == false)
            {
                MessageBox.Show("Chức vụ chưa được nhập");
                return;
            }

            try
            {
                // Thực hiện lệnh
                conn = new SqlConnection(strConnectionString);
                conn.Open();
                // Tạo đối tượng SqlCommand và chỉ định kiểu CommandType là StoredProcedure
                SqlCommand command = new SqlCommand("spThemNhanVien", conn);
                command.CommandType = CommandType.StoredProcedure;

                //@MaNhanVien, @HoVaTen, @SDT, @Tuoi, @DiaChi, @GioiTinh, @QueQuan, @ChucVu
                // Thêm các tham số vào đối tượng SqlCommand
                command.Parameters.AddWithValue("@MaNhanVien", txtMaNV.Text.ToString());
                command.Parameters.AddWithValue("@HoVaTen", txtTenNV.Text.ToString());
                command.Parameters.AddWithValue("@SDT", txtSDT.Text.ToString());
                command.Parameters.AddWithValue("@Tuoi", txtTuoi.Text.ToString());
                command.Parameters.AddWithValue("@DiaChi", txtDC.Text.ToString());
                if (checkNam.Checked == true && checkNu.Checked == false)
                {
                    gioitinh = "Nam";
                }
                if (checkNam.Checked == false && checkNu.Checked == true)
                {
                    gioitinh = "Nữ";
                }
                command.Parameters.AddWithValue("@GioiTinh", gioitinh.ToString());
                command.Parameters.AddWithValue("@QueQuan", txtQue.Text.ToString());
                if (checkNV.Checked == true && checkQL.Checked == false)
                {
                    CV = "NhanVien";
                }
                if (checkNV.Checked == false && checkQL.Checked == true)
                {
                    gioitinh = "QuanLy";
                }
                command.Parameters.AddWithValue("@ChucVu", CV.ToString());
                // Thực thi Stored Procedure
                command.ExecuteNonQuery();
                //Đóng kết nối
                conn.Close();
                // Thông báo
                MessageBox.Show("Đã thêm Nhân viên mới xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thêm nhân viên!");
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
