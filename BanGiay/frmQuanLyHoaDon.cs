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
using COMExcel = Microsoft.Office.Interop.Excel;


namespace BanGiay
{
    public partial class frmQuanLyHoaDon : Form
    {

        GetDanhSachDAL ds;
        tblCTHD ct;
        tblHoaDon hd;
       
        List<string> rand = new List<string>();
        public frmQuanLyHoaDon()
        {
            ds = new GetDanhSachDAL();
            ct = new tblCTHD();
            hd = new tblHoaDon();
            InitializeComponent();
        }
        public void SetDataGridView()
        {
           
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = ds.GetDanhSachChiTietHoaDon();
            using (QLBANGIAYEntities db = new QLBANGIAYEntities()) {
                tblKhachHangbindingSource.DataSource = db.tblKhachHangs.ToList();
                tblNhanVienbindingSource.DataSource = db.tblNhanViens.ToList();
                tblSanPhambindingSource.DataSource = db.tblSanPhams.ToList();
            }
              
        }
        public void Reset()
        {
            txtMaHoaDon.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            txtSoLuong.Text = "0";
            txtGiamGia.Text = "0";
            dtpNgayBan.Value = DateTime.Now;
            txtTongTien.Text = "0";
            txtThanhTien.Text = "0";
            txtMaHoaDon.ReadOnly = false;
            SetCombobox();

        }
        public void SetCombobox()
        {
            //cmbMaKhachHang.DataSource = ds.GetDanhSachKhachHang();
            //cmbMaNhanVien.DataSource = ds.GetDanhSachNhanVien();
            //cmbMaSanPham.DataSource = ds.GetDanhSachSanPham();
            ////cmbMaKhachHang.DisplayMember = "MaKhacHang";
            //cmbMaKhachHang.ValueMember = "MaKhachHang";
            //cmbMaNhanVien.ValueMember = "MaNhanVien";
            //cmbMaSanPham.ValueMember = "MaSanPham";

            cmbTimKiem.DataSource = ds.GetDanhSachHoaDon();
            cmbTimKiem.ValueMember = "MaHoaDon";
        }
        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            Reset();
            // 
            btnHuyHoaDon.Enabled = false;
            btnInHoaDon.Enabled = false;
            SetDataGridView();
        }

        private void dgvHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            ct.MaHoaDon = Convert.ToString(dgvHoaDon.CurrentRow.Cells["colMaHoaDon"].Value);
            if(dgvHoaDon.CurrentRow.Index != -1)
            {
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    ct = db.tblCTHDs.Where(p => p.MaHoaDon == ct.MaHoaDon).FirstOrDefault();
                    hd = db.tblHoaDons.Where(p => p.MaHoaDon == ct.MaHoaDon).FirstOrDefault();


                    txtMaHoaDon.Text = ct.MaHoaDon;
                    cmbMaNhanVien.SelectedValue = ct.tblHoaDon.tblNhanVien.MaNhanVien;
                    txtTenNhanVien.Text = ct.tblHoaDon.tblNhanVien.TenNhanVien;
                    cmbMaSanPham.SelectedValue = ct.MaSanPham;
                    txtTenSanPham.Text = ct.tblSanPham.TenSanPham;
                    cmbMaKhachHang.SelectedValue = ct.tblHoaDon.tblKhachHang.MaKhachHang;
                    txtTenKhachHang.Text = ct.tblHoaDon.tblKhachHang.TenKhachHang;
                    dtpNgayBan.Value = (DateTime)ct.tblHoaDon.NgayBan;
                    txtSoLuong.Text = ct.SoLuong.ToString();
                    txtGiamGia.Text = ct.GiamGia.ToString();
                    txtDiaChi.Text = ct.tblHoaDon.tblKhachHang.DiaChi;
                    mtxtDienThoai.Text = ct.tblHoaDon.tblKhachHang.SoDienThoai;
                    txtDonGia.Text = ct.DonGia.ToString();
                    txtTongTien.Text = ct.tblHoaDon.TongTien.ToString();
                    txtThanhTien.Text = ct.ThanhTien.ToString();
                }
                 
            }
            btnDong.Enabled = true;
            btnHuyHoaDon.Enabled = true;
            btnLuuHoaDon.Enabled = false;
            btnInHoaDon.Enabled = true;
            btnThemHoaDon.Enabled = true;
            btnInHoaDon.Enabled = true;
            txtMaHoaDon.ReadOnly = true; 


        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            btnDong.Enabled = false;
            btnHuyHoaDon.Enabled = false;
            btnInHoaDon.Enabled = false;
            btnLuuHoaDon.Enabled = true;
            txtMaHoaDon.ReadOnly = false;

            Reset();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            ct.MaHoaDon = txtMaHoaDon.Text.Trim();
            ct.SoLuong = float.Parse(txtSoLuong.Text.Trim());
            ct.GiamGia = float.Parse(txtGiamGia.Text.Trim());
            ct.MaSanPham = cmbMaSanPham.Text;
            ct.DonGia = float.Parse(txtDonGia.Text.Trim());
            ct.ThanhTien = float.Parse(txtThanhTien.Text.Trim());
            hd.MaHoaDon = txtMaHoaDon.Text.Trim();
            hd.MaKhachHang = cmbMaKhachHang.Text.Trim();
            hd.MaNhanVien = cmbMaNhanVien.Text;
            hd.NgayBan = dtpNgayBan.Value;
            hd.TongTien = float.Parse(txtTongTien.Text.Trim());

            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                if (txtSoLuong.Text == "0"  || 
                txtGiamGia.Text == "" ||
                txtTenNhanVien.Text == "" ||
                txtTenSanPham.Text == "" ||
                txtTenKhachHang.Text == "" || txtDiaChi.Text == "" ||
                mtxtDienThoai.Text == "" ||
                txtDonGia.Text == "0" ||
                txtTongTien.Text == "0" ||
                txtThanhTien.Text == "0" )
                {
                    MessageBox.Show("Bạn cần nhập thông tin đầy đủ!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else
                {
                    db.tblCTHDs.Add(ct);
                    db.tblHoaDons.Add(hd);
                    db.SaveChanges();
                    MessageBox.Show("Bạn đã lưu thông tin thành công!!");
                }
            }
            SetDataGridView();
            Reset();
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn hủy hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                hd.MaHoaDon = txtMaHoaDon.Text.Trim();
                hd.MaKhachHang = cmbMaKhachHang.Text.Trim();
                hd.MaNhanVien = cmbMaNhanVien.Text.Trim();
                hd.NgayBan = dtpNgayBan.Value;
                hd.TongTien = float.Parse(txtTongTien.Text.Trim());


                ct.MaHoaDon = txtMaHoaDon.Text.Trim();
                ct.SoLuong = float.Parse(txtSoLuong.Text.Trim());
                ct.GiamGia = float.Parse(txtGiamGia.Text.Trim());
                ct.MaSanPham = cmbMaSanPham.Text.Trim();
                ct.DonGia = float.Parse(txtDonGia.Text.Trim());
                ct.ThanhTien = float.Parse(txtThanhTien.Text.Trim());
                using (QLBANGIAYEntities db = new QLBANGIAYEntities())
                {
                    db.Entry(ct).State = EntityState.Modified;
                    db.Entry(hd).State = EntityState.Modified;
                    db.tblHoaDons.Remove(hd);
                    db.tblCTHDs.Remove(ct);
                    db.SaveChanges();
                }

                SetDataGridView();
                Reset();
                btnLuuHoaDon.Enabled = true;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
            txtTongTien.Text = tt.ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
            txtTongTien.Text = tt.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLBANGIAYEntities db = new QLBANGIAYEntities())
            {
                var h = db.tblCTHDs.Where(kh => kh.MaHoaDon.Equals(cmbTimKiem.Text)).FirstOrDefault();
                if (h != null)
                {
               
                    dgvHoaDon.DataSource = db.tblCTHDs.Where(ct => ct.MaHoaDon.Contains(h.MaHoaDon))
                    .Select(c => new
                    {
                        c.MaHoaDon,
                        c.MaSanPham,
                        c.SoLuong,
                        c.DonGia,
                        c.GiamGia,
                        c.ThanhTien
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }


            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop Bán giầy Hoang Phuc";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Quận 1 -- TP.HCM";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 19006941";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán;
            sql = "SELECT a.MaHoaDon, a.NgayBan, a.TongTien, b.TenKhachHang, b.DiaChi, b.SoDienThoai, c.TenNhanVien FROM tblHoaDon AS a, tblKhachHang AS b, tblNhanVien AS c WHERE a.MaHoaDon = N'" + txtMaHoaDon.Text + "' AND a.MaKhachHang = b.MaKhachHang AND a.MaNhanVien = c.MaNhanVien";
            tblThongtinHD = GetDanhSachDAL.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenSanPham, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien " +
                  "FROM tblCTHD AS a , tblSanPham AS b WHERE a.MaHoaDon = N'" +
                  txtMaHoaDon.Text + "' AND a.MaSanPham = b.MaSanPham";
            tblThongtinHang = GetDanhSachDAL.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }
    }
}
