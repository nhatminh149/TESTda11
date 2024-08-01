using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaKhachHang { get; set; }
        public string? TenKhachHang { get; set; }
        public string? SoDienThoai { get; set; }
        public string? GioiTinh { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? QueQuan { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
