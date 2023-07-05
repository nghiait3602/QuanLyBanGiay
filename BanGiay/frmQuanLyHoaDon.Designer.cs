
namespace BanGiay
{
    partial class frmQuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.tblSanPhambindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtxtDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.tblKhachHangbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.cmbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.cmbMaSanPham = new System.Windows.Forms.ComboBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.tblNhanVienbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSanPhambindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1212, 609);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHoaDon,
            this.colMaSanPham,
            this.colSoLuong,
            this.colDonGia,
            this.colGiamGia,
            this.colThanhTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(26, 429);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(1160, 158);
            this.dgvHoaDon.TabIndex = 12;
            this.dgvHoaDon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoaDon_CellMouseClick);
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaHoaDon.DataPropertyName = "MaHoaDon";
            this.colMaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.colMaHoaDon.MinimumWidth = 6;
            this.colMaHoaDon.Name = "colMaHoaDon";
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã Sản Phẩm";
            this.colMaSanPham.MinimumWidth = 6;
            this.colMaSanPham.Name = "colMaSanPham";
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            // 
            // colGiamGia
            // 
            this.colGiamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiamGia.DataPropertyName = "GiamGia";
            this.colGiamGia.HeaderText = "Giảm Giá";
            this.colGiamGia.MinimumWidth = 6;
            this.colGiamGia.Name = "colGiamGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTimKiem);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.mtxtDienThoai);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenKhachHang);
            this.panel1.Controls.Add(this.cmbMaKhachHang);
            this.panel1.Controls.Add(this.txtTenSanPham);
            this.panel1.Controls.Add(this.cmbMaSanPham);
            this.panel1.Controls.Add(this.txtTenNhanVien);
            this.panel1.Controls.Add(this.cmbMaNhanVien);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnInHoaDon);
            this.panel1.Controls.Add(this.btnHuyHoaDon);
            this.panel1.Controls.Add(this.btnLuuHoaDon);
            this.panel1.Controls.Add(this.btnThemHoaDon);
            this.panel1.Controls.Add(this.dtpNgayBan);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtGiamGia);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtMaHoaDon);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 309);
            this.panel1.TabIndex = 3;
            // 
            // cmbTimKiem
            // 
            this.cmbTimKiem.FormattingEnabled = true;
            this.cmbTimKiem.Location = new System.Drawing.Point(183, 199);
            this.cmbTimKiem.Name = "cmbTimKiem";
            this.cmbTimKiem.Size = new System.Drawing.Size(789, 28);
            this.cmbTimKiem.TabIndex = 16;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSanPhambindingSource, "DonGiaBan", true));
            this.txtDonGia.Location = new System.Drawing.Point(926, 89);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(189, 27);
            this.txtDonGia.TabIndex = 13;
            // 
            // tblSanPhambindingSource
            // 
            this.tblSanPhambindingSource.DataSource = typeof(BanGiay.Model.tblSanPham);
            // 
            // mtxtDienThoai
            // 
            this.mtxtDienThoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKhachHangbindingSource, "SoDienThoai", true));
            this.mtxtDienThoai.Location = new System.Drawing.Point(926, 52);
            this.mtxtDienThoai.Mask = "(999) 000-0000";
            this.mtxtDienThoai.Name = "mtxtDienThoai";
            this.mtxtDienThoai.ReadOnly = true;
            this.mtxtDienThoai.Size = new System.Drawing.Size(189, 27);
            this.mtxtDienThoai.TabIndex = 12;
            // 
            // tblKhachHangbindingSource
            // 
            this.tblKhachHangbindingSource.DataSource = typeof(BanGiay.Model.tblKhachHang);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKhachHangbindingSource, "DiaChi", true));
            this.txtDiaChi.Location = new System.Drawing.Point(926, 13);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(189, 27);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKhachHangbindingSource, "TenKhachHang", true));
            this.txtTenKhachHang.Location = new System.Drawing.Point(562, 54);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(189, 27);
            this.txtTenKhachHang.TabIndex = 7;
            // 
            // cmbMaKhachHang
            // 
            this.cmbMaKhachHang.DataSource = this.tblKhachHangbindingSource;
            this.cmbMaKhachHang.DisplayMember = "MaKhachHang";
            this.cmbMaKhachHang.FormattingEnabled = true;
            this.cmbMaKhachHang.Location = new System.Drawing.Point(562, 16);
            this.cmbMaKhachHang.Name = "cmbMaKhachHang";
            this.cmbMaKhachHang.Size = new System.Drawing.Size(189, 28);
            this.cmbMaKhachHang.TabIndex = 6;
            this.cmbMaKhachHang.ValueMember = "MaKhachHang";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSanPhambindingSource, "TenSanPham", true));
            this.txtTenSanPham.Location = new System.Drawing.Point(183, 162);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.ReadOnly = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(189, 27);
            this.txtTenSanPham.TabIndex = 5;
            // 
            // cmbMaSanPham
            // 
            this.cmbMaSanPham.DataSource = this.tblSanPhambindingSource;
            this.cmbMaSanPham.DisplayMember = "MaSanPham";
            this.cmbMaSanPham.FormattingEnabled = true;
            this.cmbMaSanPham.Location = new System.Drawing.Point(183, 125);
            this.cmbMaSanPham.Name = "cmbMaSanPham";
            this.cmbMaSanPham.Size = new System.Drawing.Size(189, 28);
            this.cmbMaSanPham.TabIndex = 4;
            this.cmbMaSanPham.ValueMember = "MaSanPham";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblNhanVienbindingSource, "TenNhanVien", true));
            this.txtTenNhanVien.Location = new System.Drawing.Point(183, 91);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(189, 27);
            this.txtTenNhanVien.TabIndex = 3;
            // 
            // tblNhanVienbindingSource
            // 
            this.tblNhanVienbindingSource.DataSource = typeof(BanGiay.Model.tblNhanVien);
            // 
            // cmbMaNhanVien
            // 
            this.cmbMaNhanVien.DataSource = this.tblNhanVienbindingSource;
            this.cmbMaNhanVien.DisplayMember = "MaNhanVien";
            this.cmbMaNhanVien.FormattingEnabled = true;
            this.cmbMaNhanVien.Location = new System.Drawing.Point(183, 52);
            this.cmbMaNhanVien.Name = "cmbMaNhanVien";
            this.cmbMaNhanVien.Size = new System.Drawing.Size(189, 28);
            this.cmbMaNhanVien.TabIndex = 2;
            this.cmbMaNhanVien.ValueMember = "MaNhanVien";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.OldLace;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(912, 248);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(200, 53);
            this.btnDong.TabIndex = 22;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.OldLace;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(978, 192);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(137, 41);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.OldLace;
            this.btnInHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(696, 248);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(200, 53);
            this.btnInHoaDon.TabIndex = 21;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.BackColor = System.Drawing.Color.OldLace;
            this.btnHuyHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuyHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyHoaDon.Image")));
            this.btnHuyHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyHoaDon.Location = new System.Drawing.Point(480, 248);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(200, 53);
            this.btnHuyHoaDon.TabIndex = 20;
            this.btnHuyHoaDon.Text = "Hủy Hóa Đơn";
            this.btnHuyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyHoaDon.UseVisualStyleBackColor = false;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnHuyHoaDon_Click);
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.BackColor = System.Drawing.Color.OldLace;
            this.btnLuuHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuuHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuHoaDon.Image")));
            this.btnLuuHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHoaDon.Location = new System.Drawing.Point(264, 248);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(200, 53);
            this.btnLuuHoaDon.TabIndex = 19;
            this.btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            this.btnLuuHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuHoaDon.UseVisualStyleBackColor = false;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.BackColor = System.Drawing.Color.OldLace;
            this.btnThemHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHoaDon.Image")));
            this.btnThemHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHoaDon.Location = new System.Drawing.Point(48, 248);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(200, 53);
            this.btnThemHoaDon.TabIndex = 18;
            this.btnThemHoaDon.Text = "Thêm Hóa Đơn";
            this.btnThemHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHoaDon.UseVisualStyleBackColor = false;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(562, 91);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(189, 27);
            this.dtpNgayBan.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(788, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Điện Thoại";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(926, 157);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(189, 27);
            this.txtThanhTien.TabIndex = 15;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(926, 122);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(189, 27);
            this.txtTongTien.TabIndex = 14;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(562, 159);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(189, 27);
            this.txtGiamGia.TabIndex = 10;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(412, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên Khách Hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(45, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Mã Nhân Viên";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(562, 124);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(189, 27);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(412, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số Lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(45, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Mã Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(411, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(788, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Thành Tiền";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(788, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Địa Chỉ";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(183, 18);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(189, 27);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(788, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(411, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(788, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tổng Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(411, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giảm Giá (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1160, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giao Diện Hóa Đơn";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1236, 633);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmQuanLyHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSanPhambindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.BindingSource tblNhanVienbindingSource;
        private System.Windows.Forms.BindingSource tblSanPhambindingSource;
        private System.Windows.Forms.BindingSource tblKhachHangbindingSource;
        private System.Windows.Forms.MaskedTextBox mtxtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.ComboBox cmbMaKhachHang;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.ComboBox cmbMaSanPham;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.ComboBox cmbMaNhanVien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cmbTimKiem;
    }
}