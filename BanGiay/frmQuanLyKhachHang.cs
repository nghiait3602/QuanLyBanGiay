using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay.DAL;
using BanGiay.Model;

namespace BanGiay
{
    public partial class frmQuanLyKhachHang : Form
    {
        GetDanhSachDAL ds;
        tblKhachHang kh;
        public frmQuanLyKhachHang()
        {
            ds = new GetDanhSachDAL();
            kh = new tblKhachHang();
            InitializeComponent();
        }
        public void SetDataGridView()
        {
            dgvKhachHang.DataSource = ds.GetDanhSachKhachHang();
        }
        public string HamTuSinhMaKhachHang()
        {
            List<string> rand = new List<string>();
           
            Random n = new Random();
            int j = Convert.ToInt32(n.NextDouble() * 1000) / 10 + Convert.ToInt32(n.NextDouble() * 10);
            string ma = "A" + j;
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {

                var dbMa = db.tblKhachHangs.Select(p => p.MaKhachHang).ToList();
                foreach (var i in dbMa)
                {
                    rand.Add(i);
                }
                for (int i = 0; i < rand.Count; i++)
                {
                    if (ma == rand[i])
                    {
                        j = Convert.ToInt32(n.NextDouble() * 10000) / 10 + Convert.ToInt32(n.NextDouble() * 10);
                        ma = "A" + j;
                    }
                    else
                    {
                        rand.Add(ma);
                        break;
                    }

                }
            }


            return ma;
        }
        public void Clear()
        {
            SetComBoBox();
            txtMaKhachHang.Text = HamTuSinhMaKhachHang();
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            mtxtDienThoai.Text = "";
            dtpNgayNhap.Value = DateTime.Now;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
           
        }
        public void SetComBoBox()
        {
            cmbTimKiem.DataSource = ds.GetDanhSachKhachHang();
            cmbTimKiem.ValueMember = "MaKhachHang";
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            SetDataGridView();
            Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnDong.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            txtMaKhachHang.ReadOnly = false;
            Clear();


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kh.MaKhachHang = txtMaKhachHang.Text.Trim();
            kh.TenKhachHang = txtTenKhachHang.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            kh.SoDienThoai = mtxtDienThoai.Text;
            kh.NgayDatHang = dtpNgayNhap.Value;
            if (txtMaKhachHang.Text == "" || txtTenKhachHang.Text == "" || txtDiaChi.Text == "" || mtxtDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    db.tblKhachHangs.Add(kh);
                    db.SaveChanges();
                    SetDataGridView();
                    Clear();
                    txtMaKhachHang.ReadOnly = false;
                }
                  
                MessageBox.Show("Bạn đã lưu thông tin thành công!!");

            }
          

        }

        private void dgvKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kh.MaKhachHang = Convert.ToString(dgvKhachHang.CurrentRow.Cells["colMaKhachHang"].Value);
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                kh = db.tblKhachHangs.Where(p => p.MaKhachHang == kh.MaKhachHang).FirstOrDefault();
                txtMaKhachHang.Text = kh.MaKhachHang;
                txtTenKhachHang.Text = kh.TenKhachHang;
                dtpNgayNhap.Value = (DateTime)kh.NgayDatHang;
                txtDiaChi.Text = kh.DiaChi;
                mtxtDienThoai.Text = kh.SoDienThoai;
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKhachHang.ReadOnly = true;


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kh.MaKhachHang = txtMaKhachHang.Text.Trim();
            kh.TenKhachHang = txtTenKhachHang.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            kh.SoDienThoai = mtxtDienThoai.Text.Trim();
            kh.NgayDatHang = dtpNgayNhap.Value;
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                db.Entry(kh).State = EntityState.Modified;
                db.SaveChanges();
                SetDataGridView();
            }
            Clear();
            btnLuu.Enabled = true;
            MessageBox.Show("Bạn đã sửa thông tin thành công!!");
            txtMaKhachHang.ReadOnly = false;

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
            txtMaKhachHang.ReadOnly = false;

            Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                var mkh = db.tblKhachHangs.Where(p => p.MaKhachHang.Equals(cmbTimKiem.Text)).FirstOrDefault();
                if (mkh != null)
                {
                    dgvKhachHang.DataSource = db.tblKhachHangs.Where(p => p.MaKhachHang.Contains(mkh.MaKhachHang)).Select(p => new
                    {
                        p.MaKhachHang,
                        p.TenKhachHang,
                        p.SoDienThoai,
                        p.NgayDatHang,
                        p.DiaChi
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    db.Entry(kh).State = EntityState.Modified;
                    db.tblKhachHangs.Remove(kh);
                    db.SaveChanges();
                }
                SetDataGridView();
                Clear();
                txtMaKhachHang.ReadOnly = false;
                btnLuu.Enabled = true;
            }
          
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
