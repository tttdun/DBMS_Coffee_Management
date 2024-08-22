using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;

namespace QuanLyQuanCaPhe
{
    public partial class Login : Form
    {
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        public Login()
        {
            InitializeComponent();
        }

        //Nút Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string PassWord = txtPassWord.Text;
            string UserName = txtUserName.Text;
            if (UserName == null || UserName.Equals(""))
            {
                MessageBox.Show("Chưa nhập Username");
                return;
            }
            if (PassWord == null || PassWord.Equals(""))
            {
                MessageBox.Show("Chưa nhập Password");
                return;
            }
            // login success
            // Khởi động connection 
            conn = new SqlConnection(strConnectionString);
            string query = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan =@TenDangNhap AND MatKhau=@MatKhau";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text);
            command.Parameters.AddWithValue("@MatKhau", txtPassWord.Text);

            string chucvu = "SELECT ChucVu FROM TaiKhoan join NhanVien on TaiKhoan.MaNhanVien = NhanVien.MaNhanVien" +
                " where TenTaiKhoan =@TenDangNhap";
            SqlCommand command2 = new SqlCommand(chucvu, conn);
            command2.Parameters.AddWithValue("@TenDangNhap", txtUserName.Text);

            conn.Open();
            string CV = (string)command2.ExecuteScalar();
            bool checkCV = false;
            if (CV == "NhanVien")
                checkCV = true;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                // Đăng nhập thành công
                reader.Close();
                //check chucvu
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.HasRows)
                {
                    // Chuyển hướng đến trang chính của ứng dụng

                    if (checkBox2.Checked == true && checkBox1.Checked == true)
                    {
                        MessageBox.Show("Vui lòng chọn đúng chức vụ");
                    }
                    else if (checkBox2.Checked == true)
                    {
                        if (checkCV == true)
                        {
                            this.Hide();
                            NhanVien FormNV = new NhanVien(txtUserName.Text);
                            FormNV.Show();

                        }
                        else
                            MessageBox.Show("Vui lòng chọn đúng chức vụ");
                    }
                    else if (checkBox1.Checked == true)
                    {
                        if (checkCV == false)
                        {
                            this.Hide();
                            QuanLy FormQL = new QuanLy(txtUserName.Text);
                            FormQL.Show();
                        }
                        else
                            MessageBox.Show("Vui lòng chọn đúng chức vụ");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn chức vụ");
                    }
                }
            }
            else
            {
                // Đăng nhập không thành công
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại thông tin đăng nhập.");
            }
            conn.Close();
        }
        //Nút Thoát

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

