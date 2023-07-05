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
    public partial class frmGiaoDien : Form
    {
        public frmGiaoDien()
        {
            InitializeComponent();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Show();
        }

        private void frmGiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult okOrCancel = new DialogResult();
            okOrCancel = MessageBox.Show("Bạn có muốn thoát hay không ?", "Đăng Nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (okOrCancel != DialogResult.OK) e.Cancel = true; // không cho phép event này được thực thi 
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmDanhMucNhanVien nv = new frmDanhMucNhanVien();
            this.Hide();
            nv.ShowDialog();
            this.Show();
        }
    }
}
