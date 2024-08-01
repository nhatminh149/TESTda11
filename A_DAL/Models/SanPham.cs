using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int MaSanPham { get; set; }
        public string? TenSanPham { get; set; }
        public int? SoLuong { get; set; }
        public decimal? GiaNhap { get; set; }
        public string? MoTa { get; set; }
        public string? ThuocTinh { get; set; }
        public int? MaLoai { get; set; }
        public int? MaNhaCungCap { get; set; }

        public virtual Loai? MaLoaiNavigation { get; set; }
        public virtual NhaSanXuat? MaNhaCungCapNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
