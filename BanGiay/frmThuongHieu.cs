using BanGiay.DAL;
using BanGiay.Model;
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

namespace BanGiay
{
    public partial class frmThuongHieu : Form
    {
        GetDanhSachDAL ds;
        tblThuongHieu th;
        public frmThuongHieu()
        {
            ds = new GetDanhSachDAL();
            th= new tblThuongHieu();
            InitializeComponent();
        }
        public void SetDataGridView()
        {
            dgvThuongHieu.DataSource = ds.GetDanhSachThuongHieu();
        }
        public void Clear()
        {
            cmbTimKiem.DataSource = ds.GetDanhSachThuongHieu();
            cmbTimKiem.ValueMember = "MaThuongHieu";
            txtMaThuongHieu.Text = txtTenThuongHieu.Text = string.Empty; 
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void frmThuongHieu_Load(object sender, EventArgs e)
        {
            Clear();
            SetDataGridView();
        }

        private void dgvThuongHieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            th.MaThuongHieu = Convert.ToString(dgvThuongHieu.CurrentRow.Cells["colMaThuongHieu"].Value);
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                th = db.tblThuongHieux.Where(p => p.MaThuongHieu == th.MaThuongHieu).FirstOrDefault();
                txtMaThuongHieu.Text = th.MaThuongHieu;
                txtTenThuongHieu.Text = th.TenThuongHieu;
            }
            
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMaThuongHieu.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnDong.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            txtMaThuongHieu.ReadOnly = false;

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
            txtMaThuongHieu.ReadOnly = false;
            Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            th.MaThuongHieu = txtMaThuongHieu.Text.Trim();
            th.TenThuongHieu = txtTenThuongHieu.Text.Trim();
           
            if (txtMaThuongHieu.Text == "" || txtTenThuongHieu.Text == "" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    db.tblThuongHieux.Add(th);
                    db.SaveChanges();
                }
                  
                MessageBox.Show("Bạn đã lưu thông tin thành công!!");

            }
            txtMaThuongHieu.ReadOnly = false;
            SetDataGridView();
            Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            th.MaThuongHieu = txtMaThuongHieu.Text.Trim();
            th.TenThuongHieu = txtTenThuongHieu.Text.Trim();
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {

                db.Entry(th).State = EntityState.Modified;
                db.SaveChanges();
                SetDataGridView();
            }
            Clear();
            btnLuu.Enabled = true;
            txtMaThuongHieu.ReadOnly = false;
            MessageBox.Show("Bạn đã sửa thông tin thành công!!");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                 using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    db.Entry(th).State = EntityState.Modified;
                    db.tblThuongHieux.Remove(th);
                    db.SaveChanges();
                    SetDataGridView();
                }
              
                Clear();
                btnLuu.Enabled = true;
                txtMaThuongHieu.ReadOnly = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                var mth = db.tblThuongHieux.Where(p => p.MaThuongHieu.Equals(cmbTimKiem .Text)).FirstOrDefault();
                if (mth != null)
                {
                    dgvThuongHieu.DataSource = db.tblThuongHieux.Where(p => p.MaThuongHieu.Contains(mth.MaThuongHieu)).Select(p => new
                    {
                        p.MaThuongHieu,
                        p.TenThuongHieu

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
