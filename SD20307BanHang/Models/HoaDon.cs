using System;
using System.Collections.Generic;

namespace SD20307BanHang.Models;

public partial class HoaDon
{
    public int MaHoaDon { get; set; }

    public DateOnly? NgayLap { get; set; }

    public int? MaKhachHang { get; set; }

    public int? MaNhanVien { get; set; }

    public decimal? TongTien { get; set; }

    public bool TrangThaiThanhToan { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang? khachhang { get; set; }

    public virtual NhanVien? nhanvien { get; set; }
}
