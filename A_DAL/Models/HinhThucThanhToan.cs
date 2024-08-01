using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class HinhThucThanhToan
    {
        public HinhThucThanhToan()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaThanhToan { get; set; }
        public string? TenHinhThuc { get; set; }
        public decimal? SoTienThanhToan { get; set; }
        public DateTime? NgayThanhToan { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
