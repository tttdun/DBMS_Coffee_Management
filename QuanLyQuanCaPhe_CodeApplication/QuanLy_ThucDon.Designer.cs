namespace QuanLyQuanCaPhe
{
    partial class QuanLy_ThucDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy_ThucDon));
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuaTU = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThemTU = new System.Windows.Forms.Button();
            this.btnXoaTU = new System.Windows.Forms.Button();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThucUong = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucUong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(643, 449);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 34);
            this.btnHuy.TabIndex = 101;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(185, 111);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(193, 27);
            this.txtMa.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Mã thức uống:";
            this.label2.UseWaitCursor = true;
            // 
            // btnSuaTU
            // 
            this.btnSuaTU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTU.Location = new System.Drawing.Point(236, 449);
            this.btnSuaTU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaTU.Name = "btnSuaTU";
            this.btnSuaTU.Size = new System.Drawing.Size(177, 34);
            this.btnSuaTU.TabIndex = 97;
            this.btnSuaTU.Text = "Sửa Thức Uống";
            this.btnSuaTU.UseVisualStyleBackColor = true;
            this.btnSuaTU.Click += new System.EventHandler(this.btnSuaTU_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(770, 449);
            this.btnReLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(129, 34);
            this.btnReLoad.TabIndex = 96;
            this.btnReLoad.Text = "  Cập nhật";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1261, 449);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 34);
            this.btnExit.TabIndex = 95;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnThemTU
            // 
            this.btnThemTU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTU.Location = new System.Drawing.Point(24, 449);
            this.btnThemTU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTU.Name = "btnThemTU";
            this.btnThemTU.Size = new System.Drawing.Size(177, 34);
            this.btnThemTU.TabIndex = 94;
            this.btnThemTU.Text = "Thêm Thức Uống";
            this.btnThemTU.UseVisualStyleBackColor = true;
            this.btnThemTU.Click += new System.EventHandler(this.btnThemTU_Click);
            // 
            // btnXoaTU
            // 
            this.btnXoaTU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTU.Location = new System.Drawing.Point(438, 449);
            this.btnXoaTU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTU.Name = "btnXoaTU";
            this.btnXoaTU.Size = new System.Drawing.Size(177, 34);
            this.btnXoaTU.TabIndex = 100;
            this.btnXoaTU.Text = "Xóa Thức Uống";
            this.btnXoaTU.UseVisualStyleBackColor = true;
            this.btnXoaTU.Click += new System.EventHandler(this.btnXoaTU_Click);
            // 
            // Tuoi
            // 
            this.Tuoi.DataPropertyName = "GiaBan";
            this.Tuoi.HeaderText = "Giá bán";
            this.Tuoi.MinimumWidth = 6;
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "MaNhomThucUong";
            this.SDT.HeaderText = "Mã nhóm thức uống";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // dgvThucUong
            // 
            this.dgvThucUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenThucUong,
            this.SDT,
            this.Tuoi});
            this.dgvThucUong.Location = new System.Drawing.Point(386, 29);
            this.dgvThucUong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThucUong.Name = "dgvThucUong";
            this.dgvThucUong.RowHeadersWidth = 51;
            this.dgvThucUong.Size = new System.Drawing.Size(661, 390);
            this.dgvThucUong.TabIndex = 93;
            this.dgvThucUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucUong_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaThucUong";
            this.MaNhanVien.HeaderText = "Mã thức uống";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // TenThucUong
            // 
            this.TenThucUong.DataPropertyName = "TenThucUong";
            this.TenThucUong.HeaderText = "Tên thức uống";
            this.TenThucUong.MinimumWidth = 6;
            this.TenThucUong.Name = "TenThucUong";
            this.TenThucUong.Width = 125;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.BackColor = System.Drawing.Color.Transparent;
            this.lbTen.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(174, 22);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(79, 22);
            this.lbTen.TabIndex = 91;
            this.lbTen.Text = "ten quan ly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 90;
            this.label4.Text = "Mã quản lý:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 89;
            this.label3.Text = "Tên quản lý:";
            this.label3.UseWaitCursor = true;
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.BackColor = System.Drawing.Color.Transparent;
            this.lbMa.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMa.Location = new System.Drawing.Point(172, 57);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(81, 22);
            this.lbMa.TabIndex = 92;
            this.lbMa.Text = "ma quan ly";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(918, 449);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 34);
            this.btnClose.TabIndex = 102;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // QuanLy_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 505);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSuaTU);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThemTU);
            this.Controls.Add(this.btnXoaTU);
            this.Controls.Add(this.dgvThucUong);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLy_ThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thực Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucUong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaTU;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThemTU;
        private System.Windows.Forms.Button btnXoaTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridView dgvThucUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucUong;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}