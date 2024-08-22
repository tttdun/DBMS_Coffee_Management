namespace QuanLyQuanCaPhe
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.label2 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.dgvChiTieu = new System.Windows.Forms.DataGridView();
            this.txtNamChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThangChi = new System.Windows.Forms.TextBox();
            this.btnXuatChi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(55, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thống Kê Lương Nhân Viên";
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(108, 371);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(86, 27);
            this.txtThang.TabIndex = 36;
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(399, 366);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(76, 35);
            this.btnXuat.TabIndex = 35;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tháng:";
            this.label3.UseWaitCursor = true;
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(293, 371);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(87, 27);
            this.txtNam.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(216, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Năm:";
            this.label4.UseWaitCursor = true;
            // 
            // dgvLuong
            // 
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Location = new System.Drawing.Point(26, 429);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.Size = new System.Drawing.Size(435, 184);
            this.dgvLuong.TabIndex = 39;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(764, 230);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 52);
            this.btnClose.TabIndex = 103;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(609, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(575, 374);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(332, 242);
            this.dgvDoanhThu.TabIndex = 1;
            // 
            // dgvChiTieu
            // 
            this.dgvChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTieu.Location = new System.Drawing.Point(17, 119);
            this.dgvChiTieu.Name = "dgvChiTieu";
            this.dgvChiTieu.RowHeadersWidth = 51;
            this.dgvChiTieu.RowTemplate.Height = 24;
            this.dgvChiTieu.Size = new System.Drawing.Size(499, 184);
            this.dgvChiTieu.TabIndex = 110;
            // 
            // txtNamChi
            // 
            this.txtNamChi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamChi.Location = new System.Drawing.Point(315, 62);
            this.txtNamChi.Name = "txtNamChi";
            this.txtNamChi.Size = new System.Drawing.Size(75, 27);
            this.txtNamChi.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(244, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 108;
            this.label5.Text = "Năm:";
            this.label5.UseWaitCursor = true;
            // 
            // txtThangChi
            // 
            this.txtThangChi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThangChi.Location = new System.Drawing.Point(156, 62);
            this.txtThangChi.Name = "txtThangChi";
            this.txtThangChi.Size = new System.Drawing.Size(71, 27);
            this.txtThangChi.TabIndex = 107;
            // 
            // btnXuatChi
            // 
            this.btnXuatChi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatChi.Location = new System.Drawing.Point(432, 61);
            this.btnXuatChi.Name = "btnXuatChi";
            this.btnXuatChi.Size = new System.Drawing.Size(69, 35);
            this.btnXuatChi.TabIndex = 106;
            this.btnXuatChi.Text = "Xuất";
            this.btnXuatChi.UseVisualStyleBackColor = true;
            this.btnXuatChi.Click += new System.EventHandler(this.btnXuatChi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(72, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 105;
            this.label6.Text = "Tháng:";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(153, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 27);
            this.label7.TabIndex = 104;
            this.label7.Text = "Thống Kê Chi Tiêu";
            // 
            // btnReLoad
            // 
            this.btnReLoad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(444, 619);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(122, 40);
            this.btnReLoad.TabIndex = 111;
            this.btnReLoad.Text = "Show All";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(531, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 112;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.dgvChiTieu);
            this.Controls.Add(this.txtNamChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThangChi);
            this.Controls.Add(this.btnXuatChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridView dgvChiTieu;
        private System.Windows.Forms.TextBox txtNamChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThangChi;
        private System.Windows.Forms.Button btnXuatChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button button1;
    }
}