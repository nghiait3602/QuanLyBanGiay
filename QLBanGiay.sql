
CREATE DATABASE QLBANGIAY
go
USE QLBANGIAY
GO
--Tạo bảng khach hang
CREATE  TABLE [tblKhachHang]
(
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[TenKhachHang]  [nvarchar](50),
	[SoDienThoai] [nvarchar](50),
	[DiaChi]  [nvarchar](200) ,
	[NgayDatHang] datetime,
	CONSTRAINT [PK_KhachHang] PRIMARY KEY (MaKhachHang)
)
--Tạo bảng thuong hieu
CREATE TABLE [tblThuongHieu]
(
	[MaThuongHieu]   [nvarchar](50) not null,
	[TenThuongHieu]  [nvarchar](50) ,
	CONSTRAINT [PK_ThuongHieu] PRIMARY KEY (MaThuongHieu)
)
--Tạo bảng Hoa Don
CREATE TABLE [tblHoaDon]
(
	[MaHoaDon] [nvarchar](50) not null,
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[MaNhanVien]  [nvarchar](50) ,
	[TongTien] [float] ,
	[NgayBan] [datetime] ,
	CONSTRAINT [PK_HoaDon] PRIMARY KEY (MaHoaDon)
)
--Tạo bảng CTHD
CREATE TABLE [tblCTHD]
(
	[MaHoaDon][nvarchar](50) not null,
	[MaSanPham] [nvarchar](50)  not NULL,
	[SoLuong] [float] ,
	[DonGia] [float],
	[GiamGia] [float],
	[ThanhTien] [float] 
	CONSTRAINT [PK_CTHD] PRIMARY KEY (MaHoaDon , MaSanPham)
) 
--Tạo bảng SanPham
CREATE TABLE [tblSanPham]
(
	[MaSanPham] [nvarchar](50) not null,
	[MaThuongHieu] [nvarchar](50),
	[TenSanPham] [nvarchar](50) ,
	[KichCo] [int],
	[SoLuong]  [float] ,
	[DonGiaNhap] [float] ,
	[DonGiaBan] [float] ,
	[NgayNhap] datetime , 
	[GhiChu][nvarchar](50),
	[Anh][nvarchar](200) 
	CONSTRAINT [PK_SANPHAM] PRIMARY KEY (MaSanPham)
)
--Tạo bảng Nhan Vien
CREATE TABLE [tblNhanVien]
(
	[MaNhanVien] [nvarchar](50) not null,
	[TenNhanVien] [nvarchar](50) ,
	[GioiTinh] [nvarchar](50)  ,
	[SoDienThoai] [nvarchar](50)  ,
	[NgaySinh] [datetime] ,
	[DiaChi] [nvarchar](200) ,

	CONSTRAINT [PK_NhanVien] PRIMARY KEY (MaNhanVien)
)
--Tạo bảng Dang nhap
CREATE TABLE [tblDangNhap]
(
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	CONSTRAINT [PK_DangNhap] PRIMARY KEY (TenTaiKhoan)
)
--- tạo khóa ngoại 
 ALTER TABLE  [tblHoaDon]  WITH CHECK ADD  
	CONSTRAINT [FK_KhachHang_HoaDon] FOREIGN KEY([MaKhachHang])REFERENCES [tblKhachHang] ([MaKhachHang])
ALTER TABLE [tblHoaDon]  WITH CHECK ADD  
	CONSTRAINT [FK_NhanVien_HoaDon] FOREIGN KEY([MaNhanVien])REFERENCES  [tblNhanVien]([MaNhanVien])
ALTER TABLE  [tblCTHD] WITH CHECK ADD  
	CONSTRAINT [FK_CTHD_HoaDon] FOREIGN KEY([MaHoaDon])REFERENCES [tblHoaDon] ([MaHoaDon])
ALTER TABLE  [tblCTHD] WITH CHECK ADD  
	CONSTRAINT [FK_CTHD_SanPham] FOREIGN KEY([MaSanPham])REFERENCES [tblSanPham] ([MaSanPham])
ALTER TABLE  [tblSanPham] WITH CHECK ADD  
	CONSTRAINT [FK_ThuongHieu_SanPham] FOREIGN KEY([MaThuongHieu])REFERENCES [tblThuongHieu] ([MaThuongHieu])

INSERT INTO tblDangNhap (TenTaiKhoan, MatKhau) VALUES ('admin', 'admin123') 

INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('A145',	N'Ananas')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('A146',	N'Biti’s')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('A147',	N'Đông Thịnh')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('A148',	N'Giày Tâm Anh')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('A149',	N'Hạnh Dung')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('A150',	N'Laforce')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('A151',	N'MWC Shop')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('A152',	N'Vina Giầy')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('B453',	N'Bita’s')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('B454',	N'Đông Hải')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('B455',	N'Giày Long Thành')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('B456',	N'Giày Thượng Đình')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('B457',	N'Juno')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('B458',	N'MIDAZ')
INSERT INTO tblThuongHieu (MaThuongHieu, TenThuongHieu) VALUES ('B459',	N'RieNevan')
--Add dữ liệu vào table Nhan Vien
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.001', N'Nguyễn Diệp	Anh', N'Nữ', '0924608193', '06/10/1999', N'Cầu Giấy, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.002', N'Trần Nam Anh', N'Nam', '0962342550', '09/11/1989', N'Hoàng Mai, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.003', N'Hoàng Ngọc Bách', N'Nam', '0834082001', '08/12/2001', N'Thường Tín, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.004', N'Nguyễn Thị Kim Dung', N'Nữ', '0163533789', '06/14/1999', N'Thanh Xuân, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.005', N'Phạm Hồng Đăng', N'Nam', '0984476509', '05/13/1998', N'Thường Tín, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.006', N'Vũ Việt Hà', N'Nữ', '0973266558', '02/16/2000', N'Quận 2, HCM')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.007', N'Trần Ngọc Hà', N'Nữ', '0924655434', '04/16/1990', N'Thanh Xuân, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.008', N'Đào Minh Hạnh', N'Nữ', '0941688538', '11/15/1997', N'Hoàn Kiếm, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.009', N'Đỗ Quốc Hưng', N'Nam', '0162765429', '06/17/2000', N'Hà Đông, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.010', N'Lê Phương Liên', N'Nữ', '0924655435', '07/11/2000', N'Thanh Xuân, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.011', N'Nguyễn Anh Mai', N'Nữ', '0924655437', '08/04/1988', N'Cầu Giấy, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.012', N'Nguyễn Hoàng Nam', N'Nam', '0924655441', '07/06/1997', N'Thường Tín, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.013', N'Trần Lê	Nguyên', N'Nam', '0924655440', '08/26/1988', N'Thường Tín, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.014', N'NTrịnh Hà Phương', N'Nữ', '0924655436', '08/22/1988', N'Cầu Giấy, Hà Nội')
INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, SoDienThoai, NgaySinh, DiaChi) VALUES (N'NV.015', N'Lê Minh	Tâm', N'Nam', '0924655443', '12/08/1989', N'Thanh Xuân, Hà Nội')
--Add dữ liệu vào table Khach Hang
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A598', N'Trịnh Kim Anh', '0388180294', N'Bản Na Lượng 2, Hữu Kiệm, Kỳ Sơn, Nghệ An', '07/11/2021')
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A599', N'Mai Vân', '0969956165', N'Quán Cơm Vinh, thôn Hiệp Thanh, Cam Thịnh Đông, Cam Ranh, Khánh Hòa', '06/10/2022')
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A600', N'Anh Bảo', '0968593324', N'Thôn Liên Trà, xã Bồng Khê, huyện Con Cuông, tỉnh Nghệ An', '12/03/2021')
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A601', N'Khánh Phượng', '0907775825', N'113/4 Võ Duy Ninh, Phường 22, Quận Bình Thạnh, TPHCM', '07/18/2021')
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A602', N'Trà Doki', '0973841072', N'102 Thái Thịnh, Đống Đa, Hà Nội', '07/02/2019')
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A603', N'Phương Linh Đàm', '0943561881', N'số nhà 45, ngách 11, ngõ 111, Triều Khúc, Thanh Xuân, Hà Nội', '03/22/2020')
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A604', N'Trung Kiên', '0587949561', N'658/10, cmt8, p11, q3, hcm', '07/14/2021')
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A605', N'My Mai', '0356220021', N'shopee(cổng làng đan nhiễm, xã Khánh Hà, Thường Tín, Hà Nội)', '07/07/2022')
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A606', N'Nam Trung', '0347478944', N'37 Tôn Đức Thắng, p. Bến Nghé, Q1 HCM', '05/02/2022')
INSERT INTO tblKhachHang (MaKhachHang, TenKhachHang, SoDienThoai, DiaChi, NgayDatHang) VALUES (N'1A607', N'Đức Tuấn', '0347218137', N'số 18c Hoàng Quốc Việt, Viện Hàn Lâm khoa học vfa công nghệ Việt Nam, Phường Nghĩa Đô, quận Cầu Giấy,HN', '03/09/2022')
--Add dữ liệu vào table San Pham
INSERT INTO tblSanPham (MaSanPham, MaThuongHieu, TenSanPham, KichCo, SoLuong, DonGiaNhap, DonGiaBan, NgayNhap, GhiChu, Anh) 
VALUES (N'GIAY_NAM_001', N'A145', N'Giày nam', 39, 100, 450000, 500000, '12/22/2018', N'Xanh đen', 'D:\online\Nam3\Lap trinh window\BanGiay\Pics\1.jpg')
INSERT INTO tblSanPham (MaSanPham, MaThuongHieu, TenSanPham, KichCo, SoLuong, DonGiaNhap, DonGiaBan, NgayNhap, GhiChu, Anh) 
VALUES (N'GIAY_NAM_002', N'B459', N'Giày nam', 40, 150, 850000, 950000, '10/12/2018', N'Sọc trắng', 'D:\online\Nam3\Lap trinh window\BanGiay\Pics\2.jpg')
INSERT INTO tblSanPham (MaSanPham, MaThuongHieu, TenSanPham, KichCo, SoLuong, DonGiaNhap, DonGiaBan, NgayNhap, GhiChu, Anh) 
VALUES (N'GIAY_NU_001', N'A152', N'Giày nữ', 32, 50, 629000, 750000, '10/12/2018', N'Hồng', 'D:\online\Nam3\Lap trinh window\BanGiay\Pics\3.jpg')
INSERT INTO tblSanPham (MaSanPham, MaThuongHieu, TenSanPham, KichCo, SoLuong, DonGiaNhap, DonGiaBan, NgayNhap, GhiChu, Anh) 
VALUES (N'GIAY_NU_002', N'A151', N'Giày nữ', 35, 110, 572000, 630000, '10/10/2018', N'Trắng', 'D:\online\Nam3\Lap trinh window\BanGiay\Pics\4.jpg')
INSERT INTO tblSanPham (MaSanPham, MaThuongHieu, TenSanPham, KichCo, SoLuong, DonGiaNhap, DonGiaBan, NgayNhap, GhiChu, Anh) 
VALUES (N'GIAY_NU_003', N'B453', N'Giày nữ', 33, 110, 572000, 630000, '01/01/2019', N'Cao gót', 'D:\online\Nam3\Lap trinh window\BanGiay\Pics\5.jpg')

--Add dữ liệu vào table Hoa Don
INSERT INTO tblHoaDon (MaHoaDon, MaKhachHang, MaNhanVien, TongTien, NgayBan) VALUES (N'X209', N'1A598', N'NV.002', 950000, '07/11/2021')
INSERT INTO tblHoaDon (MaHoaDon, MaKhachHang, MaNhanVien, TongTien, NgayBan) VALUES (N'J120', N'1A600', N'NV.005', 500000, '12/03/2021')
INSERT INTO tblHoaDon (MaHoaDon, MaKhachHang, MaNhanVien, TongTien, NgayBan) VALUES (N'X211', N'1A605', N'NV.001', 750000, '07/07/2022')
INSERT INTO tblHoaDon (MaHoaDon, MaKhachHang, MaNhanVien, TongTien, NgayBan) VALUES (N'A221', N'1A601', N'NV.007', 630000, '07/18/2021')
INSERT INTO tblHoaDon (MaHoaDon, MaKhachHang, MaNhanVien, TongTien, NgayBan) VALUES (N'B111', N'1A602', N'NV.015', 750000, '07/02/2019')
--Add dữ liệu vào table CTHD
INSERT INTO tblCTHD (MaHoaDon, MaSanPham, SoLuong, DonGia, GiamGia, ThanhTien) VALUES (N'X209', N'GIAY_NAM_002', '1', 950000, 0, 950000)
INSERT INTO tblCTHD (MaHoaDon, MaSanPham, SoLuong, DonGia, GiamGia, ThanhTien) VALUES (N'J120', N'GIAY_NAM_001', '1', 500000, 0, 500000)
INSERT INTO tblCTHD (MaHoaDon, MaSanPham, SoLuong, DonGia, GiamGia, ThanhTien) VALUES (N'X211', N'GIAY_NU_001', '1', 750000, 0, 750000)
INSERT INTO tblCTHD (MaHoaDon, MaSanPham, SoLuong, DonGia, GiamGia, ThanhTien) VALUES (N'A221', N'GIAY_NU_002', '1', 630000, 0, 630000)
INSERT INTO tblCTHD (MaHoaDon, MaSanPham, SoLuong, DonGia, GiamGia, ThanhTien) VALUES (N'B111', N'GIAY_NU_001', '1', 750000, 0, 750000)


