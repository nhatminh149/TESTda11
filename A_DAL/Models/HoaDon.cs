using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int MaHoaDon { get; set; }
        public int? MaKhachHang { get; set; }
        public int? MaNhanVien { get; set; }
        public DateTime? NgayLapHoaDon { get; set; }
        public int? MaKhuyenMai { get; set; }
        public int? MaThanhToan { get; set; }

        public virtual KhachHang? MaKhachHangNavigation { get; set; }
        public virtual KhuyenMai? MaKhuyenMaiNavigation { get; set; }
        public virtual NhanVien? MaNhanVienNavigation { get; set; }
        public virtual HinhThucThanhToan? MaThanhToanNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
