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
    public partial class frmThongKe : Form
    {
        GetDanhSachDAL ds; 
        public frmThongKe()
        {
            ds = new GetDanhSachDAL();
            InitializeComponent();
        }

       

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachNhanVien();
            
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachHoaDon();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachKhachHang();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachSanPham();

        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = ds.GetDanhSachChiTietHoaDon();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
