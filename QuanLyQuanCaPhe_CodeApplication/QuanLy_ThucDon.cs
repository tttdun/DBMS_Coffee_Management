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
    public partial class QuanLy_ThucDon : Form
    {
        string strConnectionString = "Data Source=(local);" +
            "Initial Catalog=QuanLiCuaHangThucUong;" +
            "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtSanPham 
        SqlDataAdapter daThucUong = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtThucUong = null;
        public QuanLy_ThucDon(string tenNV, string maNV)
        {

            InitializeComponent();
            lbMa.Text = maNV;
            lbTen.Text = tenNV;
            LoadData();
            // Không cho thao tác trên các nút Thêm / Xóa / Sửa 
            this.btnHuy.Enabled = false;
            this.btnXoaTU.Enabled = false;
            this.btnSuaTU.Enabled = false;

        }

        void LoadData()
        {
            conn = new SqlConnection(strConnectionString);

            conn.Open();
            //Truyền dữ liệu vào dgv
            daThucUong = new SqlDataAdapter("SELECT * FROM THUCUONG", conn);
            dtThucUong = new DataTable();
            dtThucUong.Clear();
            daThucUong.Fill(dtThucUong);

            // Đưa dữ liệu lên DataGridView  
            dgvThucUong.DataSource = dtThucUong;

            // Cấu hình DataGridView theo ý muốn
            dgvThucUong.AutoResizeColumns();
            // Đóng kết nối
            conn.Close();
        }

        private void btnThemTU_Click(object sender, EventArgs e)
        {
            Them_ThucUong FormThemTU = new Them_ThucUong();
            FormThemTU.Show();
            // Không cho thao tác trên các nút Sửa / Xóa / Thoát 
            this.btnSuaTU.Enabled = false;
            this.btnXoaTU.Enabled = false;
            this.btnExit.Enabled = false;
            this.btnHuy.Enabled = true;

        }

        private void btnSuaTU_Click(object sender, EventArgs e)
        {
            Sua_ThucUong FormSuaNV = new Sua_ThucUong(txtMa.Text);
            FormSuaNV.Show();
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThemTU.Enabled = false;
            this.btnXoaTU.Enabled = false;
            this.btnExit.Enabled = false;
            this.btnHuy.Enabled = true;
        }

        private void btnXoaTU_Click(object sender, EventArgs e)
        {
            // Không cho thao tác trên các nút Thêm / Sửa / Thoát 
            this.btnThemTU.Enabled = false;
            this.btnSuaTU.Enabled = false;
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
                int r = dgvThucUong.CurrentCell.RowIndex;
                // Lấy MaNV của record hiện hành 
                string TenTU = dgvThucUong.Rows[r].Cells[1].Value.ToString();
                string MaTU = dgvThucUong.Rows[r].Cells[0].Value.ToString();
                // Tạo đối tượng SqlCommand và chỉ định kiểu CommandType là StoredProcedure
                SqlCommand command = new SqlCommand("spXoaThucUong", conn);
                command.CommandType = CommandType.StoredProcedure;
                // Thêm các tham số vào đối tượng SqlCommand
                command.Parameters.AddWithValue("@MaThucUong", MaTU);
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa dữ liệu nhân viên " + TenTU + " không?", "Trả lời",
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
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThemTU.Enabled = true;
            this.btnSuaTU.Enabled = true;
            this.btnXoaTU.Enabled = true;
            this.btnExit.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnReLoad.Enabled = false;
            this.btnHuy.Enabled = false;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThucUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvThucUong.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMa.Text =
            dgvThucUong.Rows[r].Cells[0].Value.ToString();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThemTU.Enabled = true;
            this.btnSuaTU.Enabled = true;
            this.btnXoaTU.Enabled = true;

            if (txtMa.Text == null || txtMa.Text.Equals(""))
            {
                // Không cho thao tác trên các nút Thêm / Xóa / Sửa 
                this.btnHuy.Enabled = false;
                this.btnXoaTU.Enabled = false;
                this.btnSuaTU.Enabled = false;
            }
        }
    }
}
