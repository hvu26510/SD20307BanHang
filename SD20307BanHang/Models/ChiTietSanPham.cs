using System;
using System.Collections.Generic;

namespace SD20307BanHang.Models;

public partial class ChiTietSanPham
{
    public int MaChiTiet { get; set; }

    public int? MaSanPham { get; set; }

    public int? MaMau { get; set; }

    public int? MaKichCo { get; set; }

    public int? SoLuong { get; set; }

    public decimal? GiaBan { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KichCo? MaKichCoNavigation { get; set; }

    public virtual MauSac? MaMauNavigation { get; set; }

    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
