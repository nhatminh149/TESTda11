using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaKhuyenMai { get; set; }
        public string? TenKhuyenMai { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string? MoTa { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
