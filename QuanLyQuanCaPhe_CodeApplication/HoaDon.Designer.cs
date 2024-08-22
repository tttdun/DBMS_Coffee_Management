namespace QuanLyQuanCaPhe
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.txtNgay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahoadon,
            this.TenHoaDon,
            this.NgayGio,
            this.TenThucUong,
            this.SoLuong,
            this.ThanhTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(51, 79);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(777, 252);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // Mahoadon
            // 
            this.Mahoadon.DataPropertyName = "MaHoaDon";
            this.Mahoadon.HeaderText = "Mã hóa đơn";
            this.Mahoadon.MinimumWidth = 6;
            this.Mahoadon.Name = "Mahoadon";
            this.Mahoadon.Width = 125;
            // 
            // TenHoaDon
            // 
            this.TenHoaDon.DataPropertyName = "TenHoaDon";
            this.TenHoaDon.HeaderText = "Tên Hóa Đơn";
            this.TenHoaDon.MinimumWidth = 6;
            this.TenHoaDon.Name = "TenHoaDon";
            this.TenHoaDon.Width = 125;
            // 
            // NgayGio
            // 
            this.NgayGio.DataPropertyName = "NgayGio";
            this.NgayGio.HeaderText = "Ngày giờ";
            this.NgayGio.MinimumWidth = 6;
            this.NgayGio.Name = "NgayGio";
            this.NgayGio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NgayGio.Width = 125;
            // 
            // TenThucUong
            // 
            this.TenThucUong.DataPropertyName = "TenThucUong";
            this.TenThucUong.HeaderText = "Tên thức uống";
            this.TenThucUong.MinimumWidth = 6;
            this.TenThucUong.Name = "TenThucUong";
            this.TenThucUong.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(170, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày:";
            this.label3.UseWaitCursor = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(527, 15);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(88, 35);
            this.btnXuat.TabIndex = 22;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(706, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(558, 362);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(122, 40);
            this.btnReLoad.TabIndex = 32;
            this.btnReLoad.Text = "Show All";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(257, 20);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(233, 27);
            this.txtNgay.TabIndex = 120;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 425);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtNgay;
    }
}