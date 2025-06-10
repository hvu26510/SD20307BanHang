using System;
using System.Collections.Generic;

namespace SD20307BanHang.Models;

public partial class SanPham
{
    public int MaSanPham { get; set; }

    public string? TenSanPham { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
