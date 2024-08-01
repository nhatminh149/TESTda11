using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Loai
    {
        public Loai()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaLoai { get; set; }
        public string? TenLoaiSp { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
