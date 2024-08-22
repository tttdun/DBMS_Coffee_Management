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
    public partial class ThongKe : Form
    {
        string strConnectionString = "Data Source=(local);" +
        "Initial Catalog=QuanLiCuaHangThucUong;" +
        "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtThongKeDoanhThu
        SqlDataAdapter daDoanhThu = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtDoanhThu = null;

        // Đối tượng đưa dữ liệu vào DataTable dtThongKeLuong
        SqlDataAdapter daLuong= null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtLuong = null;

        // Đối tượng đưa dữ liệu vào DataTable dtThongKeLuong
        SqlDataAdapter daChi = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtChi = null;
        public ThongKe()
        {
            InitializeComponent();
            conn = new SqlConnection(strConnectionString);
            conn.Open();

            //dgv Thong Ke Doanh Thu
            // Lấy dữ liệu từ View
            string query = "SELECT NgayGio as 'Ngày giờ', TongTien as 'Tổng tiền'"
                + "FROM " + "View_TinhTongHoaDon";
            SqlCommand command = new SqlCommand(query, conn);
            //Truyền dữ liệu vào dgv
            daDoanhThu = new SqlDataAdapter(query, conn);
            dtDoanhThu = new DataTable();
            dtDoanhThu.Clear();
            daDoanhThu.Fill(dtDoanhThu);

            // Hiển thị dữ liệu lên DataGridView
            dgvDoanhThu.DataSource = dtDoanhThu;
            // Cấu hình DataGridView theo ý muốn
            dgvDoanhThu.AutoResizeColumns();
            // Thêm DataGridView vào Form
            this.Controls.Add(dgvDoanhThu);
            conn.Close();
            Load_Data();
            Load_Data2();
        }

        void Load_Data2()
        {
            conn.Open();
            //dgv Thong Ke Doanh Thu
            // Lấy dữ liệu từ View
            string query1 = "SELECT MaPhieuChi as 'Mã phiếu chi', NgayXuatPhieu as 'Ngày xuất phiếu', SoTienChi as 'Tiền chi'"
                + "FROM " + "View_TienPhieuChi";
            SqlCommand command1 = new SqlCommand(query1, conn);
            //Truyền dữ liệu vào dgv
            daChi = new SqlDataAdapter(query1, conn);
            dtChi = new DataTable();
            dtChi.Clear();
            daChi.Fill(dtChi);

            // Hiển thị dữ liệu lên DataGridView
            dgvChiTieu.DataSource = dtChi;
            // Cấu hình DataGridView theo ý muốn
            dgvChiTieu.AutoResizeColumns();
            // Thêm DataGridView vào Form
            this.Controls.Add(dgvChiTieu);
            conn.Close();

            conn.Close();
        }

        void Load_Data()
        {
            conn.Open();
            string query3 = "SELECT HoVaTen as 'Họ và tên', ChucVu as 'Chức vụ', ThanhTien as 'Lương'"
                + "FROM " + "View_LuongNhanVien";
            SqlCommand command3 = new SqlCommand(query3, conn);
            //Truyền dữ liệu vào dgv
            daLuong = new SqlDataAdapter(query3, conn);
            dtLuong = new DataTable();
            dtLuong.Clear();
            daLuong.Fill(dtLuong);

            // Hiển thị dữ liệu lên DataGridView
            dgvLuong.DataSource = dtLuong;
            // Cấu hình DataGridView theo ý muốn
            dgvLuong.AutoResizeColumns();
            // Thêm DataGridView vào Form
            this.Controls.Add(dgvLuong);

            // Hiển thị dữ liệu lên DataGridView
            dgvChiTieu.DataSource = dtChi;
            // Cấu hình DataGridView theo ý muốn
            dgvChiTieu.AutoResizeColumns();
            // Thêm DataGridView vào Form
            this.Controls.Add(dgvChiTieu);
            conn.Close();
        }
        void Loc_Data()
        {
            conn.Open();

            //dgv Thong Ke Doanh Thu
            // Lấy dữ liệu từ View
            string query = "SELECT HoVaTen as 'Họ và tên', ChucVu as 'Chức vụ', ThanhTien as 'Lương'"
                + "FROM " + "Func_LuongNhanVien ("+ txtThang.Text +","+ txtNam.Text +")";
            SqlCommand command = new SqlCommand(query, conn);
            //Truyền dữ liệu vào dgv
            daLuong = new SqlDataAdapter(query, conn);
            dtLuong= new DataTable();
            dtLuong.Clear();
            daLuong.Fill(dtLuong);

            // Hiển thị dữ liệu lên DataGridView
            dgvLuong.DataSource = dtLuong;
            // Cấu hình DataGridView theo ý muốn
            dgvLuong.AutoResizeColumns();
            // Thêm DataGridView vào Form
            this.Controls.Add(dgvLuong);
            conn.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

            //dgv Thong Ke Luong Theo Thang, Nam
            Loc_Data();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Loc_Data2()
        {
            conn.Open();

            //dgv Thong Ke Doanh Thu
            // Lấy dữ liệu từ Func
            string query = "SELECT TongTien as 'Tổng chi'"
                + "FROM " + "Func_TongTienPhieuChi (" + txtThangChi.Text + "," + txtNamChi.Text + ")";
            SqlCommand command = new SqlCommand(query, conn);
            //Truyền dữ liệu vào dgv
            daChi = new SqlDataAdapter(query, conn);
            dtChi = new DataTable();
            dtChi.Clear();
            daChi.Fill(dtChi);

            // Hiển thị dữ liệu lên DataGridView
            dgvChiTieu.DataSource = dtChi;
            // Cấu hình DataGridView theo ý muốn
            dgvChiTieu.AutoResizeColumns();
            // Thêm DataGridView vào Form
            this.Controls.Add(dgvChiTieu);
            conn.Close();
        }

        private void btnXuatChi_Click(object sender, EventArgs e)
        {
            Loc_Data2();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load_Data2();
        }
    }
}
