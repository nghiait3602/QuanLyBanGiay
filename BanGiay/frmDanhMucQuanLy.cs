using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay
{
    public partial class frmDanhMucQuanLy : Form
    {
        public frmDanhMucQuanLy()
        {
            InitializeComponent();
        }

    

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            frmThuongHieu th = new frmThuongHieu();
            this.Hide();
            th.ShowDialog();
            this.Show();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien nv = new frmQuanLyNhanVien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang kh = new frmQuanLyKhachHang();
            this.Hide();
            kh.ShowDialog();
            this.Show();

        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            frmQuanLyHoaDon hd = new frmQuanLyHoaDon();
            this.Hide();
            hd.ShowDialog();
            this.Show();
        }

        private void btnDanhMucTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem tk = new frmTimKiem();
            this.Hide();
            tk.ShowDialog();
            this.Show();
        }

        private void btnThongKeDanhSach_Click(object sender, EventArgs e)
        {
            frmThongKe thongke = new frmThongKe();
            this.Hide();
            thongke.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            frmLienHe lh = new frmLienHe();
            this.Hide();
           lh.ShowDialog();
            this.Show();
        }

        private void btnThayDoiDangNhap_Click(object sender, EventArgs e)
        {
            frmThayDoiDangNhap dn = new frmThayDoiDangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham sp = new frmQuanLySanPham();
            this.Hide();
            sp.ShowDialog();
            this.Show();
        }
    }
}
