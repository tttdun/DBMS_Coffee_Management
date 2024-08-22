using System;
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
    public partial class QuanLy : Form
    {
        string TenDN;
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        public QuanLy(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;

            // Khởi động connection 
            conn = new SqlConnection(strConnectionString);
            string query1 = "SELECT HoVaTen FROM TaiKhoan join NhanVien on TaiKhoan.MaNhanVien = NhanVien.MaNhanVien" +
                    " where TenTaiKhoan =@TenDangNhap";
            SqlCommand command = new SqlCommand(query1, conn);
            command.Parameters.AddWithValue("@TenDangNhap", TenDN);

            string query2 = "SELECT NhanVien.MaNhanVien FROM TaiKhoan join NhanVien on TaiKhoan.MaNhanVien = NhanVien.MaNhanVien" +
                    " where TenTaiKhoan =@TenDangNhap";
            SqlCommand command1 = new SqlCommand(query2, conn);
            command1.Parameters.AddWithValue("@TenDangNhap", TenDN);

            conn.Open();
            string HoTen = (string)command.ExecuteScalar();
            string MaNV = (string)command1.ExecuteScalar();
            lbTenNV.Text = HoTen;
            lbMaNV.Text = MaNV;
            conn.Close();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ThongTin FormTT = new ThongTin(lbTenNV.Text, lbMaNV.Text);
            FormTT.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //this.Hide();
            HoaDon FormTT = new HoaDon();
            FormTT.Show();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            Quanly_NhanVien FormQuanLyNV = new Quanly_NhanVien(lbTenNV.Text, lbMaNV.Text);
            FormQuanLyNV.Show();
        }

            private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                Login FormLogin = new Login();
                FormLogin.Show();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ThongKe FormTK = new ThongKe();
            FormTK.Show();
        }

        private void btnQuanLyTD_Click(object sender, EventArgs e)
        {
            QuanLy_ThucDon FormQuanLyTD = new QuanLy_ThucDon(lbTenNV.Text, lbMaNV.Text);
            FormQuanLyTD.Show();
        }
    }
}
