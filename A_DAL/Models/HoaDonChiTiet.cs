using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class HoaDonChiTiet
    {
        public int MaHoaDon { get; set; }
        public int MaSanPham { get; set; }
        public int? SoLuong { get; set; }
        public decimal? GiaBan { get; set; }

        public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;
        public virtual SanPham MaSanPhamNavigation { get; set; } = null!;
    }
}
