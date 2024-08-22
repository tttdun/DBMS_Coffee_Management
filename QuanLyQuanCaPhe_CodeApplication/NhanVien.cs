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
    public partial class NhanVien : Form
    {
        string TenDN;
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        public NhanVien(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
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
            label5.Text = HoTen;
            label6.Text = MaNV;
            conn.Close();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ThongTin FormTT = new ThongTin(label5.Text, label6.Text);
            FormTT.Show();
        }

        private void btnChange_Pass_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Change_Pass FormDoiPass = new Change_Pass(label6.Text);
            FormDoiPass.Show();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                Login FormLogin = new Login();
                FormLogin.Show();
            }
        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Xem_CaLam FormXemCa = new Xem_CaLam(label5.Text, label6.Text);
            FormXemCa.Show();

        }
    }
}
