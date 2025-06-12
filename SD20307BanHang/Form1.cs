using Microsoft.EntityFrameworkCore;
using SD20307BanHang.Models;
namespace SD20307BanHang
{
    public partial class Form1 : Form
    {
        BanGiayTheThaoContext db = new BanGiayTheThaoContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadHoaDon()
        {
            dgvHoaDon.DataSource = db.HoaDons
                                    .Include(hd => hd.khachhang)
                                    .Include(hd => hd.nhanvien)
                                    .Where(hd => hd.TrangThaiThanhToan == false).ToList()
                                    .Select((x, index) => new
                                    {
                                        STT = index + 1,
                                        x.MaHoaDon,
                                        TenKhanhHang = (x.khachhang == null) ? "" : x.khachhang.TenKhachHang,
                                        TenNhanVien = (x.nhanvien == null) ? "" : x.nhanvien.TenNhanVien,
                                        x.NgayLap,
                                        x.TongTien
                                    }).ToList();
        }
        private void loadSanPham()
        {
            dgvSanPham.DataSource = db.ChiTietSanPhams.Include(ctsp => ctsp.MaSanPhamNavigation)
                                    .Include(ctsp => ctsp.MaKichCoNavigation)
                                    .Include(ctsp => ctsp.MaMauNavigation)
                                    .Where(ctsp => ctsp.MaSanPhamNavigation.TenSanPham.Contains(txtTimKiem.Text))
                                    .ToList()
                                    .Select((x, index) => new
                                    {
                                        STT = index + 1,
                                        x.MaChiTiet,
                                        x.MaSanPhamNavigation.TenSanPham,
                                        x.MaMauNavigation.TenMau,
                                        Size = x.MaKichCoNavigation.Size,
                                        x.GiaBan,
                                        x.SoLuong
                                    }).ToList();
        }
        private void loadKhachHang()
        {
            cbbKhachHang.DataSource = db.KhachHangs.ToList();
            cbbKhachHang.DisplayMember = "TenKhachHang";
            cbbKhachHang.ValueMember = "MaKhachHang";
        }
        private void loadNhanVien()
        {
            cbbNhanVien.DataSource = db.NhanViens.ToList();
            cbbNhanVien.DisplayMember = "TenNhanVien";
            cbbNhanVien.ValueMember = "MaNhanVien";
        }
        private void loadCTHD(int curMaHD)
        {

            dgvGioHang.DataSource = db.ChiTietHoaDons.Where(cthd => cthd.MaHoaDon == curMaHD)
                                    .Include(cthd => cthd.MaChiTietNavigation)
                                    .ToList().Select((x, index) => new
                                    {
                                        STT = index + 1,
                                        x.MaCthd,
                                        x.MaChiTietNavigation.MaSanPhamNavigation.TenSanPham,
                                        x.MaChiTietNavigation.MaMauNavigation.TenMau,
                                        x.MaChiTietNavigation.MaKichCoNavigation.Size,
                                        x.SoLuong,
                                        x.DonGia,
                                        ThanhTien = x.SoLuong * x.DonGia
                                    }).ToList();

            try
            {
                //update cbbKhachHang
                cbbKhachHang.SelectedValue = db.HoaDons.Where(hd => hd.MaHoaDon == curMaHD).Select(hd => hd.MaKhachHang).FirstOrDefault();

                //update cbbNhanVien
                cbbNhanVien.SelectedValue = db.HoaDons.Where(hd => hd.MaHoaDon == curMaHD).Select(hd => hd.MaNhanVien).FirstOrDefault();
            }
            catch
            {
            }

            TinhTongTien();
        }
        private void TinhTongTien()
        {
            decimal TongTien = 0;
            if (dgvGioHang.Rows.Count > 0)
            {
                foreach (DataGridViewRow r in dgvGioHang.Rows)
                {
                    TongTien = TongTien + decimal.Parse(r.Cells["ThanhTien"].Value.ToString());
                }
            }
            lbTongTien.Text = TongTien.ToString();
        }

        private string UpdateHoaDon(HoaDon newHD)
        {
            var oldHD = db.HoaDons.FirstOrDefault(hd => hd.MaHoaDon == newHD.MaHoaDon);
            if (oldHD != null)
            {
                oldHD.MaKhachHang = (newHD.MaKhachHang == null) ? oldHD.MaKhachHang : newHD.MaKhachHang;
                oldHD.MaNhanVien = (newHD.MaNhanVien == null) ? oldHD.MaNhanVien : newHD.MaNhanVien;
                oldHD.NgayLap = (newHD.NgayLap == null) ? oldHD.NgayLap : newHD.NgayLap;
                oldHD.TongTien = (newHD.TongTien == null) ? oldHD.TongTien : newHD.TongTien;
                oldHD.TrangThaiThanhToan = (newHD.TrangThaiThanhToan == oldHD.TrangThaiThanhToan) ? oldHD.TrangThaiThanhToan : newHD.TrangThaiThanhToan;
                db.SaveChanges();
                return "Update thanh cong";

            }
            return "Khong tim thay hoa don";
        }

        private void AddorUpdateCTHD(ChiTietHoaDon newcthd)
        {
            var oldCTHD = db.ChiTietHoaDons.FirstOrDefault(cthd => cthd.MaCthd == newcthd.MaCthd);
            if (oldCTHD != null)
            {
                if (newcthd.SoLuong > 0)
                {
                    oldCTHD.SoLuong = newcthd.SoLuong;
                    db.SaveChanges();
                }
                else
                {
                    db.ChiTietHoaDons.Remove(oldCTHD);
                    db.SaveChanges();
                }

            }
            else
            {
                db.ChiTietHoaDons.Add(newcthd);
                db.SaveChanges();
            }
        }
        private void UpdateCTSP(ChiTietSanPham ctsp)
        {
            var oldCTSP = db.ChiTietSanPhams.FirstOrDefault(ct => ct.MaChiTiet == ctsp.MaChiTiet);
            if (oldCTSP != null)
            {
                oldCTSP.MaSanPham = (ctsp.MaSanPham == null) ? oldCTSP.MaSanPham : ctsp.MaSanPham;
                oldCTSP.GiaBan = (ctsp.GiaBan == null) ? oldCTSP.GiaBan : ctsp.GiaBan;
                oldCTSP.MaKichCo = (ctsp.MaKichCo == null) ? oldCTSP.MaKichCo : ctsp.MaKichCo;
                oldCTSP.MaMau = (ctsp.MaMau == null) ? oldCTSP.MaMau : ctsp.MaMau;
                oldCTSP.SoLuong = (ctsp.SoLuong == null) ? oldCTSP.SoLuong : ctsp.SoLuong;
                db.SaveChanges();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadHoaDon();
            loadSanPham();
            loadKhachHang();
            loadNhanVien();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int curMaHD = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString());

            dgvHoaDon.ClearSelection();
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (int.Parse(row.Cells[1].Value.ToString()) == curMaHD)
                    row.Selected = true;
            }

            loadCTHD(curMaHD);

        }

        private void txtSoTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal KhachDua = decimal.Parse(txtSoTienKhachDua.Text);
                decimal TongTien = decimal.Parse(lbTongTien.Text);
                txtSoTienCanTra.Text = (KhachDua - TongTien).ToString();
            }
            catch (Exception ex)
            {
                txtSoTienCanTra.Text = "";
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (db.HoaDons.ToList().Count <= 20)
            {
                HoaDon newHD = new HoaDon();
                newHD.NgayLap = DateOnly.FromDateTime(DateTime.Now);
                newHD.TrangThaiThanhToan = false;
                db.HoaDons.Add(newHD);
                db.SaveChanges();
                loadHoaDon();
            }
            else
            {
                MessageBox.Show("Gioi han 20 hoa don cho");
            }

        }

        private void cbbKhachHang_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                int curMaHD = int.Parse(dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString());
                HoaDon hd = new HoaDon();
                hd.MaHoaDon = curMaHD;
                hd.MaKhachHang = int.Parse(cbbKhachHang.SelectedValue.ToString());
                UpdateHoaDon(hd);
                loadHoaDon();
                dgvHoaDon.ClearSelection();
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (int.Parse(row.Cells[1].Value.ToString()) == curMaHD)
                        row.Selected = true;
                }
            }
        }

        private void cbbNhanVien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                int curMaHD = int.Parse(dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString());
                HoaDon hd = new HoaDon();
                hd.MaHoaDon = curMaHD;
                hd.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());

                UpdateHoaDon(hd);
                loadHoaDon();
                dgvHoaDon.ClearSelection();
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (int.Parse(row.Cells[1].Value.ToString()) == curMaHD)
                        row.Selected = true;
                }
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormNhapSoLuong f = new FormNhapSoLuong();
            int soluongmua = 0;
            var kq = f.ShowDialog();
            if (kq == DialogResult.OK)
            {
                soluongmua = f.DuLieuTraVe;

                if (soluongmua > 0)
                {
                    int curMaHD = int.Parse(dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString());
                    int machitietSP = int.Parse(dgvSanPham.Rows[e.RowIndex].Cells["MaChiTiet"].Value.ToString());
                    decimal donGia = decimal.Parse(dgvSanPham.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString());
                    int SoLuongTon = int.Parse(dgvSanPham.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString());

                    if (soluongmua < SoLuongTon)
                    {
                        ChiTietHoaDon cthd = new ChiTietHoaDon();
                        cthd.MaHoaDon = curMaHD;
                        cthd.MaChiTiet = machitietSP;
                        cthd.SoLuong = soluongmua;
                        cthd.DonGia = donGia;
                        AddorUpdateCTHD(cthd);
                        loadCTHD(curMaHD);
                        ChiTietSanPham ctsp = new ChiTietSanPham();
                        ctsp.MaChiTiet = machitietSP;
                        ctsp.SoLuong = SoLuongTon - soluongmua;
                        UpdateCTSP(ctsp);
                        loadSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Khong du so luong");
                    }



                }
                else
                {
                    MessageBox.Show("So luong khong hop le");
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("a iu sua?","Xac nhan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) {
                int curMaHD = int.Parse(dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString());
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHoaDon = curMaHD;
                hoaDon.TrangThaiThanhToan = true;
                UpdateHoaDon(hoaDon);
                loadHoaDon();
            }
            
        }
    }
}
