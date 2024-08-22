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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCaPhe
{
    public partial class HoaDon : Form
    {
        string strConnectionString = "Data Source=(local);" +
        "Initial Catalog=QuanLiCuaHangThucUong;" +
        "Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtSanPham 
        SqlDataAdapter daHoaDon = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtHoaDon = null;
        // Đối tượng đưa dữ liệu vào để lọc
        SqlDataAdapter daLoc = null;
        // Đối tượng hiển thị dữ liệu lên Form lọc
        DataTable dtLoc = null;
        public HoaDon()
        {
            InitializeComponent();
            conn = new SqlConnection(strConnectionString);
        }

        void Load_Data()
        {
            conn.Open();
            // Lấy dữ liệu từ View
            string query = "SELECT *"
                + "FROM " + "View_HoaDon";
            SqlCommand command = new SqlCommand(query, conn);
            //Truyền dữ liệu vào dgv
            daHoaDon = new SqlDataAdapter(query, conn);
            dtHoaDon = new DataTable();
            dtHoaDon.Clear();
            daHoaDon.Fill(dtHoaDon);

            // Hiển thị dữ liệu lên DataGridView
            dgvHoaDon.DataSource = dtHoaDon;
            // Cấu hình DataGridView theo ý muốn
            dgvHoaDon.AutoResizeColumns();
            // Thêm DataGridView vào Form
            this.Controls.Add(dgvHoaDon);

            conn.Close();
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "Select MaHoaDon, TenHoaDon , NgayGio , TenThucUong, SoLuong, ThanhTien " +
                "From Func_HoaDonTheoNgay( CAST ('"+ txtNgay.Text.ToString()+ "' as date)), View_HoaDon " +
                "Where MaHD = MaHoaDon";
            SqlCommand command = new SqlCommand(query, conn);

            //Truyền dữ liệu vào dgv
            daLoc = new SqlDataAdapter(query, conn);
            dtLoc = new DataTable();
            dtLoc.Clear();
            daLoc.Fill(dtLoc);

            // Hiển thị dữ liệu lên DataGridView
            dgvHoaDon.DataSource = dtLoc;
            // Cấu hình DataGridView theo ý muốn
            dgvHoaDon.AutoResizeColumns();
            // Thêm DataGridView vào Form
            this.Controls.Add(dgvHoaDon);

            /*dtv.RowFilter = "NgayGio='" + cbNgay.SelectedValue.ToString() + "'";
            dgvHoaDon.DataSource = dtv;*/
            // Đóng kết nối
            conn.Close();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
