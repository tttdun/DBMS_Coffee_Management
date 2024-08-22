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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCaPhe
{
    public partial class Change_Pass : Form
    {
        string MaNV;
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        public Change_Pass(string maNV)
        {
            InitializeComponent();
            MaNV = maNV;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            string query = "SELECT MatKhau FROM TaiKhoan" + " where MaNhanVien =@maNV";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maNV", MaNV);
            conn.Open();
            string pass = (string)command.ExecuteScalar();

            if (txtPass.Text == null || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu hiện tại chưa được nhập");
                return;
            }

            if (txtPassNew.Text == null || txtPassNew.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu mới chưa được nhập");
                return;
            }


            if (txtRePass.Text == null || txtRePass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập lại Mật khẩu mới");
                return;
            }

            if (txtPass.Text.ToString() != pass.ToString())
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng");
                return;
            }

            if (txtPassNew.Text != txtRePass.Text)
            {
                // Thông báo
                MessageBox.Show("Nhập lại mật khẩu không đúng!");
                return;
            }

            try
            {
                // Tạo đối tượng SqlCommand và chỉ định kiểu CommandType là StoredProcedure
                SqlCommand command1 = new SqlCommand("spDoiMatKhau", conn);
                command1.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào đối tượng SqlCommand
                command1.Parameters.AddWithValue("@MaNV", MaNV.ToString());
                command1.Parameters.AddWithValue("@MatKhauCu", txtPass.Text.ToString());
                command1.Parameters.AddWithValue("@MatKhauMoi", txtPassNew.Text.ToString());
                // Thực thi Stored Procedure
                command1.ExecuteNonQuery();
                //Đóng kết nối
                // Thông báo
                MessageBox.Show("Đã đổi mật khẩu!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể đổi mật khẩu!");
            }
            conn.Close();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
