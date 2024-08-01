using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class NhaSanXuat
    {
        public NhaSanXuat()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaNhaSanXuat { get; set; }
        public string? TenNhaSanXuat { get; set; }
        public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
