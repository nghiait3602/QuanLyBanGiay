using BanGiay.Model;
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
    public partial class frmDangNhap : Form
    {
        
        public frmDangNhap()
        {            
            InitializeComponent();
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult okOrCancel = new DialogResult();
            okOrCancel = MessageBox.Show("Bạn có muốn thoát hay không ?", "Đăng Nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (okOrCancel != DialogResult.OK) e.Cancel = true ; // không cho phép event này được thực thi 
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //frmGiaoDien gd = new frmGiaoDien();
            //this.Hide(); // ẩn đi form đăng nhập ;
            //gd.ShowDialog(); // show form giao diện và buộc thực thi trên form giao diện 
            // this.Show(); // hiện lại form đăng nhập 
            using(QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                if (txtTenTaiKhoan.Text != "" || txtMatKhau.Text != "")
                {
                    var ss = db.tblDangNhaps.Where(p => p.TenTaiKhoan.Equals(txtTenTaiKhoan.Text)).FirstOrDefault(); // tìm tài khoản khớp với tài khoản người dùng nhập
                    if (ss != null)
                    {
                        if (ss.MatKhau.Equals(txtMatKhau.Text))
                        {
                            frmDanhMucQuanLy ql = new frmDanhMucQuanLy();
                            this.Hide();
                            ql.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đẫ nhập sai mật khẩu!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đẫ nhập sai Tài khoản!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tài khoản mật khẩu!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }
    }
}
