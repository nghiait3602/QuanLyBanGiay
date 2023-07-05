
namespace BanGiay
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiemNhanVien = new System.Windows.Forms.Button();
            this.btnTimKiemHoaDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemKhachHang = new System.Windows.Forms.Button();
            this.btnTimKiemSanPham = new System.Windows.Forms.Button();
            this.btnTimKiemChiTietHoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(211, 101);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(316, 49);
            this.txtTimKiem.TabIndex = 1;
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiem.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Location = new System.Drawing.Point(0, 327);
            this.dgvTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.RowHeadersWidth = 51;
            this.dgvTimKiem.RowTemplate.Height = 24;
            this.dgvTimKiem.Size = new System.Drawing.Size(1024, 303);
            this.dgvTimKiem.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.OldLace;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(653, 103);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 50);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiemNhanVien
            // 
            this.btnTimKiemNhanVien.BackColor = System.Drawing.Color.OldLace;
            this.btnTimKiemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemNhanVien.Location = new System.Drawing.Point(270, 99);
            this.btnTimKiemNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemNhanVien.Name = "btnTimKiemNhanVien";
            this.btnTimKiemNhanVien.Size = new System.Drawing.Size(195, 50);
            this.btnTimKiemNhanVien.TabIndex = 6;
            this.btnTimKiemNhanVien.Text = "Tìm Kiếm Nhân Viên";
            this.btnTimKiemNhanVien.UseVisualStyleBackColor = false;
            this.btnTimKiemNhanVien.Click += new System.EventHandler(this.btnTimKiemNhanVien_Click);
            // 
            // btnTimKiemHoaDon
            // 
            this.btnTimKiemHoaDon.BackColor = System.Drawing.Color.OldLace;
            this.btnTimKiemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemHoaDon.Location = new System.Drawing.Point(31, 26);
            this.btnTimKiemHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemHoaDon.Name = "btnTimKiemHoaDon";
            this.btnTimKiemHoaDon.Size = new System.Drawing.Size(211, 50);
            this.btnTimKiemHoaDon.TabIndex = 2;
            this.btnTimKiemHoaDon.Text = "Tìm Kiếm Hóa Đơn";
            this.btnTimKiemHoaDon.UseVisualStyleBackColor = false;
            this.btnTimKiemHoaDon.Click += new System.EventHandler(this.btnTimKiemHoaDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTimKiemKhachHang);
            this.groupBox1.Controls.Add(this.btnTimKiemHoaDon);
            this.groupBox1.Controls.Add(this.btnTimKiemNhanVien);
            this.groupBox1.Controls.Add(this.btnTimKiemSanPham);
            this.groupBox1.Controls.Add(this.btnTimKiemChiTietHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(211, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(768, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnTimKiemKhachHang
            // 
            this.btnTimKiemKhachHang.BackColor = System.Drawing.Color.OldLace;
            this.btnTimKiemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemKhachHang.Location = new System.Drawing.Point(31, 99);
            this.btnTimKiemKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemKhachHang.Name = "btnTimKiemKhachHang";
            this.btnTimKiemKhachHang.Size = new System.Drawing.Size(211, 50);
            this.btnTimKiemKhachHang.TabIndex = 5;
            this.btnTimKiemKhachHang.Text = "Tìm Kiếm Khách Hàng";
            this.btnTimKiemKhachHang.UseVisualStyleBackColor = false;
            this.btnTimKiemKhachHang.Click += new System.EventHandler(this.btnTimKiemKhachHang_Click);
            // 
            // btnTimKiemSanPham
            // 
            this.btnTimKiemSanPham.BackColor = System.Drawing.Color.OldLace;
            this.btnTimKiemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemSanPham.Location = new System.Drawing.Point(270, 28);
            this.btnTimKiemSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemSanPham.Name = "btnTimKiemSanPham";
            this.btnTimKiemSanPham.Size = new System.Drawing.Size(195, 50);
            this.btnTimKiemSanPham.TabIndex = 3;
            this.btnTimKiemSanPham.Text = "Tìm Kiếm Sản Phẩm";
            this.btnTimKiemSanPham.UseVisualStyleBackColor = false;
            this.btnTimKiemSanPham.Click += new System.EventHandler(this.btnTimKiemSanPham_Click);
            // 
            // btnTimKiemChiTietHoaDon
            // 
            this.btnTimKiemChiTietHoaDon.BackColor = System.Drawing.Color.OldLace;
            this.btnTimKiemChiTietHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemChiTietHoaDon.Location = new System.Drawing.Point(475, 26);
            this.btnTimKiemChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemChiTietHoaDon.Name = "btnTimKiemChiTietHoaDon";
            this.btnTimKiemChiTietHoaDon.Size = new System.Drawing.Size(272, 50);
            this.btnTimKiemChiTietHoaDon.TabIndex = 4;
            this.btnTimKiemChiTietHoaDon.Text = "Tìm Kiếm Chi Tiết Hóa Đơn";
            this.btnTimKiemChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btnTimKiemChiTietHoaDon.Click += new System.EventHandler(this.btnTimKiemChiTietHoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(535, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập mã để tìm kiếm !!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(100, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm Kiếm ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1024, 82);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tìm Kiếm Danh Sách";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-4, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "VD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(42, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã NV:NV.001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(87, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(41, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã SP:GIAY_NU_002";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(42, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã KH:1A598";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(42, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã HD:X209";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1022, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiemNhanVien;
        private System.Windows.Forms.Button btnTimKiemHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiemKhachHang;
        private System.Windows.Forms.Button btnTimKiemSanPham;
        private System.Windows.Forms.Button btnTimKiemChiTietHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}