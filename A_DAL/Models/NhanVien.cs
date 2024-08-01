using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaNhanVien { get; set; }
        public string? HoTenNhanVien { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public string? ViTri { get; set; }
        public string? Password { get; set; }
        public string? GioiTinh { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
