using System;
using System.Collections.Generic;

namespace SD20307BanHang.Models;

public partial class KichCo
{
    public int MaKichCo { get; set; }

    public int? Size { get; set; }

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
