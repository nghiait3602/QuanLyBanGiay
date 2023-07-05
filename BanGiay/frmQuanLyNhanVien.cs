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
    public partial class frmQuanLyNhanVien : Form
    {
        GetDanhSachDAL ds;
        tblNhanVien nv;
        public frmQuanLyNhanVien()
        {
            ds = new GetDanhSachDAL();
            nv = new tblNhanVien();
            InitializeComponent();
        }

        public void SetDataGridView()
        {
            dgvNhanVien.DataSource = ds.GetDanhSachNhanVien();
        }
        public string HamTuSinhMaNhanVien()
        {
            List<string> rand = new List<string>();

            Random n = new Random();
            int j = Convert.ToInt32(n.NextDouble() * 1000) / 10 + Convert.ToInt32(n.NextDouble() * 10);
            string ma = "NV.0" + j;
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {

                var dbMa = db.tblNhanViens.Select(p => p.MaNhanVien).ToList();
                foreach (var i in dbMa)
                {
                    rand.Add(i);
                }
                for (int i = 0; i < rand.Count; i++)
                {
                    if (ma == rand[i])
                    {
                        j = Convert.ToInt32(n.NextDouble() * 10000) / 10 + Convert.ToInt32(n.NextDouble() * 10);
                        ma = "NV.0" + j;
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
        public void SetComBoBox()
        {
            cmbTimKiem.DataSource = ds.GetDanhSachNhanVien();
            cmbTimKiem.ValueMember = "MaNhanVien";
        }
        public void Clear()
        {
            SetComBoBox();
            txtMaNhanVien.Text = HamTuSinhMaNhanVien();
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            mtxtDienThoai.Text = "";
            txtGioiTinh.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
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
            txtMaNhanVien.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nv.MaNhanVien = txtMaNhanVien.Text.Trim();
            nv.TenNhanVien = txtTenNhanVien.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.SoDienThoai = mtxtDienThoai.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.GioiTinh = txtGioiTinh.Text;
            if (txtMaNhanVien.Text == "" || txtTenNhanVien.Text == "" || txtDiaChi.Text == "" || mtxtDienThoai.Text == "" || txtGioiTinh.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    db.tblNhanViens.Add(nv);
                    db.SaveChanges();
                }
                 
                MessageBox.Show("Bạn đã lưu thông tin thành công!!");

            }
            SetDataGridView();
            Clear();
            txtMaNhanVien.ReadOnly = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
            txtMaNhanVien.ReadOnly = false;

            Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow.Index != -1)
            {
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    nv.MaNhanVien = txtMaNhanVien.Text.Trim();
                    nv.TenNhanVien = txtTenNhanVien.Text.Trim();
                    nv.DiaChi = txtDiaChi.Text.Trim();
                    nv.SoDienThoai = mtxtDienThoai.Text;
                    nv.NgaySinh = dtpNgaySinh.Value;
                    nv.GioiTinh = txtGioiTinh.Text;
                    db.Entry(nv).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Bạn đã sửa thông tin thành công!!");

                }

                SetDataGridView();
                Clear();
                btnLuu.Enabled = true;
                txtMaNhanVien.ReadOnly = false;
            }
              
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    db.Entry(nv).State = EntityState.Modified;
                    db.tblNhanViens.Remove(nv);
                    db.SaveChanges();
                }
                
                SetDataGridView();
                Clear();
                txtMaNhanVien.ReadOnly = false;
                btnLuu.Enabled = true;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            nv.MaNhanVien = Convert.ToString(dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value);
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                nv = db.tblNhanViens.Where(p => p.MaNhanVien == nv.MaNhanVien).FirstOrDefault();
                txtMaNhanVien.Text = nv.MaNhanVien;
                txtTenNhanVien.Text = nv.TenNhanVien;
                dtpNgaySinh.Value = (DateTime)nv.NgaySinh;
                txtDiaChi.Text = nv.DiaChi;
                mtxtDienThoai.Text = nv.SoDienThoai;
                txtGioiTinh.Text = nv.GioiTinh;
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNhanVien.ReadOnly = true;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                var mnv = db.tblNhanViens.Where(p => p.MaNhanVien.Equals(cmbTimKiem.Text)).FirstOrDefault();
                if (mnv != null)
                {
                    dgvNhanVien.DataSource = db.tblNhanViens.Where(p => p.MaNhanVien.Contains(mnv.MaNhanVien)).Select(p => new
                    {
                        p.MaNhanVien,
                        p.TenNhanVien,
                        p.SoDienThoai,
                        p.NgaySinh,
                        p.DiaChi,
                        p.GioiTinh
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
