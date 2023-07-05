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
    public partial class frmDanhMucNhanVien : Form
    {
        public frmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void frmDanhMucNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            frmLienHe lh = new frmLienHe();
            this.Hide();
            lh.ShowDialog();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem tk = new frmTimKiem();
            this.Hide();
            tk.ShowDialog();
            this.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe thongke = new frmThongKe();
            this.Hide();
            thongke.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
