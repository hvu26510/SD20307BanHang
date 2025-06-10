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
                                        TenKhanhHang = (x.khachhang == null) ? "": x.khachhang.TenKhachHang,
                                        TenNhanVien =  (x.nhanvien==null) ? "": x.nhanvien.TenNhanVien,
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
            if (db.HoaDons.ToList().Count <=20) {
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
    }
}
