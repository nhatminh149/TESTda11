using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace A_DAL.Models
{
    public partial class CuaHangBanGiay_DA1Context : DbContext
    {
        public CuaHangBanGiay_DA1Context()
        {
        }

        public CuaHangBanGiay_DA1Context(DbContextOptions<CuaHangBanGiay_DA1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<HinhThucThanhToan> HinhThucThanhToans { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<Loai> Loais { get; set; } = null!;
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=IPhone15\\SQLEXPRESS04;Database=CuaHangBanGiay_DA1;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HinhThucThanhToan>(entity =>
            {
                entity.HasKey(e => e.MaThanhToan)
                    .HasName("PK__HinhThuc__D4B25844D6D97F46");

                entity.ToTable("HinhThucThanhToan");

                entity.Property(e => e.MaThanhToan).ValueGeneratedNever();

                entity.Property(e => e.NgayThanhToan).HasColumnType("date");

                entity.Property(e => e.SoTienThanhToan).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TenHinhThuc).HasMaxLength(255);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13B198C92FA");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHoaDon).ValueGeneratedNever();

                entity.Property(e => e.NgayLapHoaDon).HasColumnType("date");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKhachHang)
                    .HasConstraintName("FK__HoaDon__MaKhachH__46E78A0C");

                entity.HasOne(d => d.MaKhuyenMaiNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKhuyenMai)
                    .HasConstraintName("FK__HoaDon__MaKhuyen__48CFD27E");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK__HoaDon__MaNhanVi__47DBAE45");

                entity.HasOne(d => d.MaThanhToanNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaThanhToan)
                    .HasConstraintName("FK__HoaDon__MaThanhT__49C3F6B7");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.MaHoaDon, e.MaSanPham })
                    .HasName("PK__HoaDonCh__4CF2A579D1E5C334");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaHoa__4CA06362");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaSan__4D94879B");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E596E20E5C");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKhachHang).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.QueQuan).HasMaxLength(255);

                entity.Property(e => e.SoDienThoai).HasMaxLength(50);

                entity.Property(e => e.TenKhachHang).HasMaxLength(255);
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.MaKhuyenMai)
                    .HasName("PK__KhuyenMa__6F56B3BD4E494264");

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.MaKhuyenMai).ValueGeneratedNever();

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.Property(e => e.TenKhuyenMai).HasMaxLength(255);
            });

            modelBuilder.Entity<Loai>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__Loai__730A57595FAAE516");

                entity.ToTable("Loai");

                entity.Property(e => e.MaLoai).ValueGeneratedNever();

                entity.Property(e => e.TenLoaiSp)
                    .HasMaxLength(255)
                    .HasColumnName("TenLoaiSP");
            });

            modelBuilder.Entity<NhaSanXuat>(entity =>
            {
                entity.HasKey(e => e.MaNhaSanXuat)
                    .HasName("PK__NhaSanXu__838C17A1FA2F7DDE");

                entity.ToTable("NhaSanXuat");

                entity.Property(e => e.MaNhaSanXuat).ValueGeneratedNever();

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.SoDienThoai).HasMaxLength(50);

                entity.Property(e => e.TenNhaSanXuat).HasMaxLength(255);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA47F24EA034");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNhanVien).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.HoTenNhanVien).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.SoDienThoai).HasMaxLength(50);

                entity.Property(e => e.ViTri).HasMaxLength(255);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442DA2BC039B");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSanPham).ValueGeneratedNever();

                entity.Property(e => e.GiaNhap).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.TenSanPham).HasMaxLength(255);

                entity.Property(e => e.ThuocTinh).HasMaxLength(255);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK__SanPham__MaLoai__4316F928");

                entity.HasOne(d => d.MaNhaCungCapNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaNhaCungCap)
                    .HasConstraintName("FK__SanPham__MaNhaCu__440B1D61");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
