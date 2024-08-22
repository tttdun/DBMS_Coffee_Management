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
    public partial class Quanly_NhanVien : Form
    {
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtSanPham 
        SqlDataAdapter daNhanVien = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtNhanVien = null;
        public Quanly_NhanVien(string tenNV, string maNV)
        {
            InitializeComponent();
            lbMa.Text = maNV;
            lbTen.Text = tenNV;
            LoadData();
            // Không cho thao tác trên các nút Thêm / Xóa / Sửa 
            this.btnHuy.Enabled = false;
            this.btnXoaNV.Enabled = false;
            this.btnSuaNV.Enabled = false;

        }

        void LoadData()
        {
            conn = new SqlConnection(strConnectionString);

            conn.Open();
            //Truyền dữ liệu vào dgv
            daNhanVien = new SqlDataAdapter("SELECT * FROM NHANVIEN", conn);
            dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            daNhanVien.Fill(dtNhanVien);

            // Đưa dữ liệu lên DataGridView  
            dgvNhanVien.DataSource = dtNhanVien;

            // Cấu hình DataGridView theo ý muốn
            dgvNhanVien.AutoResizeColumns();


            // Đóng kết nối
            conn.Close();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            Them_NhanVien FormThemNV = new Them_NhanVien();
            FormThemNV.Show();
            // Không cho thao tác trên các nút Sửa / Xóa / Thoát 
            this.btnSuaNV.Enabled = false;
            this.btnXoaNV.Enabled = false;
            this.btnExit.Enabled = false;
            this.btnHuy.Enabled = true;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            Sua_NhanVien FormSuaNV = new Sua_NhanVien(txtChucVu.Text, txtMa.Text);
            FormSuaNV.Show();
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThemNV.Enabled = false;
            this.btnXoaNV.Enabled = false;
            this.btnExit.Enabled = false;
            this.btnHuy.Enabled = true;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            // Không cho thao tác trên các nút Thêm / Sửa / Thoát 
            this.btnThemNV.Enabled = false;
            this.btnSuaNV.Enabled = false;
            this.btnExit.Enabled = false;
            this.btnHuy.Enabled = true;
            // Mở kết nối 
            conn = new SqlConnection(strConnectionString);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = dgvNhanVien.CurrentCell.RowIndex;
                // Lấy MaNV của record hiện hành 
                string TenNV = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
                string MaNV = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                // Tạo đối tượng SqlCommand và chỉ định kiểu CommandType là StoredProcedure
                SqlCommand command = new SqlCommand("spXoaNhanVien", conn);
                command.CommandType = CommandType.StoredProcedure;
                // Thêm các tham số vào đối tượng SqlCommand
                command.Parameters.AddWithValue("@MaNV", MaNV);
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa dữ liệu nhân viên " + TenNV + " không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    // Thực thi Stored Procedure
                    command.ExecuteNonQuery();
                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa dữ liệu!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi! Không xóa được dữ liệu!");
            }
            // Đóng kết nối 
            conn.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtMa.ResetText();
            this.txtChucVu.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThemNV.Enabled = true;
            this.btnSuaNV.Enabled = true;
            this.btnXoaNV.Enabled = true;
            this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnReLoad.Enabled = false;
            this.btnHuy.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMa.Text =
            dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtChucVu.Text =
            dgvNhanVien.Rows[r].Cells[7].Value.ToString();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThemNV.Enabled = true;
            this.btnSuaNV.Enabled = true;
            this.btnXoaNV.Enabled = true;

            if (txtMa.Text == null || txtMa.Text.Equals("")
                || txtChucVu.Text == null || txtChucVu.Text.Equals(""))
            {
                // Không cho thao tác trên các nút Thêm / Xóa / Sửa 
                this.btnHuy.Enabled = false;
                this.btnXoaNV.Enabled = false;
                this.btnSuaNV.Enabled = false;
            }
        }
    }
}