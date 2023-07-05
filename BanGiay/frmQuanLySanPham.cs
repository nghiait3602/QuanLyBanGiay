using BanGiay.DAL;
using BanGiay.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BanGiay
{
    public partial class frmQuanLySanPham : Form
    {
        GetDanhSachDAL ds;
        tblSanPham sp = new tblSanPham();

        public frmQuanLySanPham()
        {
            ds = new GetDanhSachDAL();
            InitializeComponent();
        }
        public void SetDataGridView()
        {
            dgvSanPham.DataSource = ds.GetDanhSachSanPham();
        }
        public bool KiemTraMA(string s)
        {
            List<string> rand = new List<string>();
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {

                var dbMa = db.tblSanPhams.Select(p => p.MaSanPham).ToList();
                foreach (var i in dbMa)
                {
                    rand.Add(i);
                }
                for (int i = 0; i < rand.Count; i++)
                {
                    if (s == rand[i])
                    {
                        MessageBox.Show("Mã đã trùng vui lòng nhập lại!");
                        return false;
                    }


                }
            }
            return true;

        }
        public void SetCombobox()
        {
            cmbTimKiem.DataSource = ds.GetDanhSachSanPham();
            cmbTimKiem.ValueMember = "MaSanPham";
            cmbMaThuongHieu.DataSource = ds.GetDanhSachThuongHieu();
            cmbMaThuongHieu.DisplayMember = "TenThuongHieu";
            cmbMaThuongHieu.ValueMember = "MaThuongHieu";
        }
        public void Clear()
        {
            SetCombobox();
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            dtpNgayNhap.Value = DateTime.Now;
            txtKichCo.Text = "0";
            txtGiaBan.Text = "0";
            txtGiaNhap.Text = "0";
            txtSoLuong.Text = "0";
            txtHinhAnh.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            Clear();
            SetCombobox();
            SetDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnDong.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            txtMaSanPham.ReadOnly = false;
            Clear();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
            txtMaSanPham.ReadOnly = false;
            Clear();
        }

        private void dgvSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sp.MaSanPham = Convert.ToString(dgvSanPham.CurrentRow.Cells["colMaSanPham"].Value);
            if (dgvSanPham.CurrentRow.Index != -1)
            {
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    sp = db.tblSanPhams.Where(p => p.MaSanPham == sp.MaSanPham).FirstOrDefault();
                    txtMaSanPham.Text = sp.MaSanPham;
                    txtTenSanPham.Text = sp.TenSanPham;
                    cmbMaThuongHieu.SelectedValue = sp.MaThuongHieu;
                    dtpNgayNhap.Value = (DateTime)sp.NgayNhap;
                    txtGhiChu.Text = sp.GhiChu;
                    txtKichCo.Text = Convert.ToString(sp.KichCo);
                    txtGiaNhap.Text = Convert.ToString(sp.DonGiaNhap);
                    txtGiaBan.Text = Convert.ToString(sp.DonGiaBan);
                    txtHinhAnh.Text = sp.Anh;
                    txtSoLuong.Text = Convert.ToString(sp.SoLuong);
                     ptbAnh.Image = Image.FromFile(txtHinhAnh.Text.Trim());
                    txtGhiChu.Text = sp.GhiChu;
                }

            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMaSanPham.ReadOnly = true;

        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            sp.MaSanPham = txtMaSanPham.Text.Trim();
           if(KiemTraMA(txtMaSanPham.Text.Trim()))
            {
                sp.TenSanPham = txtTenSanPham.Text.Trim();
                sp.MaThuongHieu = cmbMaThuongHieu.SelectedValue.ToString();
                sp.NgayNhap = dtpNgayNhap.Value;
                sp.KichCo = Int32.Parse(txtKichCo.Text.Trim());
                sp.GhiChu = txtGhiChu.Text;
                sp.DonGiaBan = float.Parse(txtGiaBan.Text.Trim());
                sp.DonGiaNhap = float.Parse(txtGiaNhap.Text.Trim());
                sp.SoLuong = float.Parse(txtSoLuong.Text.Trim());
                sp.Anh = txtHinhAnh.Text.Trim();

                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    if (txtMaSanPham.Text == "" || txtTenSanPham.Text == "" || txtKichCo.Text == "" || txtHinhAnh.Text == "" || txtGiaNhap.Text == "" ||
                       txtGiaBan.Text == "" || txtSoLuong.Text == "" || txtGhiChu.Text == "")
                    {
                        MessageBox.Show("Bạn cần nhập thông tin đầy đủ!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {

                        db.tblSanPhams.Add(sp);
                        db.SaveChanges();
                        MessageBox.Show("Bạn đã lưu thông tin thành công!!");

                    }

                }
                SetDataGridView();
                Clear();
                txtMaSanPham.ReadOnly = false;
            }

          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    db.Entry(sp).State = EntityState.Modified;
                    db.tblSanPhams.Remove(sp);
                    db.SaveChanges();
                    SetDataGridView();
                }

                Clear();
                txtMaSanPham.ReadOnly = false;
                btnLuu.Enabled = true;
            }
        }

        private void btnMoAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            oFile.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.Image = Image.FromFile(oFile.FileName);
                txtHinhAnh.Text = oFile.FileName;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow.Index != -1)
            {
                sp.MaSanPham = txtMaSanPham.Text.Trim();
                sp.TenSanPham = txtTenSanPham.Text.Trim();
                sp.MaThuongHieu = cmbMaThuongHieu.SelectedValue.ToString();
                sp.NgayNhap = dtpNgayNhap.Value;
                sp.KichCo = Int32.Parse(txtKichCo.Text.Trim());
                sp.GhiChu = txtGhiChu.Text;
                sp.DonGiaBan = float.Parse(txtGiaBan.Text.Trim());
                sp.DonGiaNhap = float.Parse(txtGiaNhap.Text.Trim());
                sp.SoLuong = float.Parse(txtSoLuong.Text.Trim());
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    db.Entry(sp).State = EntityState.Modified;
                    db.SaveChanges();
                    SetDataGridView();
                }

                Clear();
                btnLuu.Enabled = true;
                MessageBox.Show("Bạn đã sửa thông tin thành công!!");
                txtMaSanPham.ReadOnly = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                sp = db.tblSanPhams.Where(kh => kh.MaSanPham.Equals(cmbTimKiem.Text)).FirstOrDefault();
                if (sp != null)
                {
                    dgvSanPham.DataSource = db.tblSanPhams.Where(p => p.MaSanPham.Contains(sp.MaSanPham))
                    .Select(s => new
                    {
                        s.MaSanPham,
                        s.TenSanPham,
                        s.MaThuongHieu,
                        s.KichCo,
                        s.SoLuong,
                        s.NgayNhap,
                        s.DonGiaNhap,
                        s.DonGiaBan,
                        s.GhiChu,
                        s.Anh
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
