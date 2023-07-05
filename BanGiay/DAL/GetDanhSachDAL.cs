using BanGiay.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay.DAL
{
    class GetDanhSachDAL
    {
        QLBANGIAYEntities db;
        public GetDanhSachDAL()
        {
            db = new QLBANGIAYEntities();
        }
        public dynamic GetDanhSachDangNhap()
        {
            var tk = db.tblDangNhaps.Select(p => new
            {
                p.TenTaiKhoan,
                p.MatKhau
            }).ToList();
            return tk;
        }
        public dynamic GetDanhSachThuongHieu()
        {
            var th = db.tblThuongHieux.Select(p => new
            {
                p.MaThuongHieu,
                p.TenThuongHieu
            }).ToList();
            return th;
        }
        public dynamic GetDanhSachNhanVien()
        {
            var nv = db.tblNhanViens.Select(p => new
            {
                p.MaNhanVien,
                p.TenNhanVien,
                p.SoDienThoai,
                p.NgaySinh,
                p.GioiTinh,
                p.DiaChi
            }).ToList();
            return nv;
        }
        public dynamic GetDanhSachKhachHang()
        {
            var kh = db.tblKhachHangs.Select(k => new
            {
                k.MaKhachHang,
                k.TenKhachHang,
                k.SoDienThoai,
                k.DiaChi,
                k.NgayDatHang
            }).ToList();
            return kh;
        }
        public dynamic GetDanhSachSanPham()
        {
            var sp = db.tblSanPhams.Select(p => new
            {
                p.MaSanPham,
                p.TenSanPham,
                p.MaThuongHieu,
                p.KichCo,
                p.SoLuong,
                p.NgayNhap,
                p.DonGiaNhap,
                p.DonGiaBan,
                p.GhiChu,
                p.Anh
            }).ToList();
            return sp;
        }
        public dynamic GetDanhSachHoaDon()
        {
            var hd = db.tblHoaDons.Select(p=> new
            {
                p.MaHoaDon,
                p.MaKhachHang,
                p.MaNhanVien,
                p.NgayBan,
                p.TongTien
            }).ToList();
            return hd;
        }
        public dynamic GetDanhSachChiTietHoaDon()
        {
            var cthd = db.tblCTHDs.Select(p => new
            {
                p.MaHoaDon,
                p.MaSanPham,
                p.SoLuong,
                p.DonGia,
                p.GiamGia,
                p.ThanhTien

            }).ToList();
            return cthd;
        }
        public static SqlConnection Con;

        internal static DataTable GetDataToTable(string sql)
        {
            Con = new SqlConnection(); // Khởi tao đối tượng con
            //Đường dẫn kết nối database
            Con.ConnectionString = Properties.Settings.Default.BanGiay;
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            return table;
        }

    }
}
