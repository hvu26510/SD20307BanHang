using System;
using System.Collections.Generic;

namespace SD20307BanHang.Models;

public partial class ChiTietHoaDon
{
    public int MaCthd { get; set; }

    public int? MaHoaDon { get; set; }

    public int? MaChiTiet { get; set; }

    public int? SoLuong { get; set; }

    public decimal? DonGia { get; set; }

    public virtual ChiTietSanPham? MaChiTietNavigation { get; set; }

    public virtual HoaDon? MaHoaDonNavigation { get; set; }
}
