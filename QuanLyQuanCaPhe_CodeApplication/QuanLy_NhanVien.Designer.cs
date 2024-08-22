namespace QuanLyQuanCaPhe
{
    partial class Quanly_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanly_NhanVien));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(953, 445);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 34);
            this.btnHuy.TabIndex = 88;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Location = new System.Drawing.Point(501, 445);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(177, 34);
            this.btnXoaNV.TabIndex = 87;
            this.btnXoaNV.Text = "Xóa Nhân Viên";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(165, 152);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(193, 27);
            this.txtChucVu.TabIndex = 86;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(165, 106);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(193, 27);
            this.txtMa.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 84;
            this.label1.Text = "Chức vụ:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Mã nhân viên:";
            this.label2.UseWaitCursor = true;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.Location = new System.Drawing.Point(256, 445);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(177, 34);
            this.btnSuaNV.TabIndex = 82;
            this.btnSuaNV.Text = "Sửa Nhân Viên";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(1092, 445);
            this.btnReLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(129, 34);
            this.btnReLoad.TabIndex = 81;
            this.btnReLoad.Text = "  Cập nhật";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1241, 445);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 34);
            this.btnExit.TabIndex = 80;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Location = new System.Drawing.Point(21, 445);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(177, 34);
            this.btnThemNV.TabIndex = 79;
            this.btnThemNV.Text = "Thêm Nhân Viên";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.BackColor = System.Drawing.Color.Transparent;
            this.lbMa.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMa.Location = new System.Drawing.Point(152, 52);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(81, 22);
            this.lbMa.TabIndex = 77;
            this.lbMa.Text = "ma quan ly";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.BackColor = System.Drawing.Color.Transparent;
            this.lbTen.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(154, 18);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(79, 22);
            this.lbTen.TabIndex = 76;
            this.lbTen.Text = "ten quan ly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 75;
            this.label4.Text = "Mã quản lý:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tên quản lý:";
            this.label3.UseWaitCursor = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.MinimumWidth = 6;
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // Tuoi
            // 
            this.Tuoi.DataPropertyName = "Tuoi";
            this.Tuoi.HeaderText = "Tuổi";
            this.Tuoi.MinimumWidth = 6;
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "HoVaTen";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.SDT,
            this.Tuoi,
            this.DiaChi,
            this.GioiTinh,
            this.QueQuan,
            this.ChucVu});
            this.dgvNhanVien.Location = new System.Drawing.Point(366, 24);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(996, 390);
            this.dgvNhanVien.TabIndex = 78;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // Quanly_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 553);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quanly_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
    }
}