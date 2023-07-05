using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay.DAL;
using BanGiay.Model;

namespace BanGiay
{
    public partial class frmTimKiem : Form
    {
        
        public frmTimKiem()
        {
    
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            using(QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                var hd = db.tblHoaDons.Where(p => p.MaHoaDon.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (hd != null)
                {
                    dgvTimKiem.DataSource = db.tblHoaDons.Where(p => p.MaHoaDon.Contains(hd.MaHoaDon)).Select(p => new
                    {
                        p.MaHoaDon,
                        p.MaKhachHang,
                        p.MaNhanVien,
                        p.NgayBan,
                        p.TongTien
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            using(QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                var sp = db.tblSanPhams.Where(p => p.MaSanPham.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (sp != null)
                {
                    dgvTimKiem.DataSource = db.tblSanPhams.Where(p => p.MaSanPham.Contains(sp.MaSanPham)).Select(p => new
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
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
              
        }

        private void btnTimKiemChiTietHoaDon_Click(object sender, EventArgs e)
        {
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                var cthd = db.tblCTHDs.Where(p => p.MaHoaDon.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (cthd != null)
                {
                    dgvTimKiem.DataSource = db.tblCTHDs.Where(p => p.MaHoaDon.Contains(cthd.MaHoaDon)).Select(p => new
                    {
                        p.MaHoaDon,
                        p.MaSanPham,
                        p.SoLuong,
                        p.DonGia,
                        p.GiamGia,
                        p.ThanhTien
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
              
        }

        private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                var kh = db.tblKhachHangs.Where(p => p.MaKhachHang.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (kh != null)
                {
                    dgvTimKiem.DataSource = db.tblKhachHangs.Where(p => p.MaKhachHang.Contains(kh.MaKhachHang)).Select(p => new
                    {
                        p.MaKhachHang,
                        p.TenKhachHang,
                        p.DiaChi,
                        p.SoDienThoai,
                        p.NgayDatHang
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
                
        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                  var nv = db.tblNhanViens.Where(p => p.MaNhanVien.Equals(txtTimKiem.Text)).FirstOrDefault();
            if (nv != null)
            {
                dgvTimKiem.DataSource = db.tblNhanViens.Where(p => p.MaNhanVien.Contains(nv.MaNhanVien)).Select(p => new
                {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.SoDienThoai,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.DiaChi
                }).ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            }
              
        }
    }
}
