using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class NhanVienRepos
    {
        CuaHangBanGiay_DA1Context _context;
        public NhanVienRepos()
        {
            _context = new CuaHangBanGiay_DA1Context();
        }
        public List<NhanVien> GetAll()
        {
            return _context.NhanViens.ToList();
        }
        public NhanVien GetById(string ten)
        {
            return _context.NhanViens.Find(ten);
        }
        public bool Create(NhanVien nhanVien)
        {
            try
            {
                _context.NhanViens.Add(nhanVien);
                _context.SaveChanges();
                Console.WriteLine("Mã NV mới: " + nhanVien.MaNhanVien);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool Edit(NhanVien nhanVien)
        {
            try
            {
                var editItem = _context.NhanViens.Find(nhanVien.MaNhanVien);
                if (editItem != null)
                {
                    editItem.HoTenNhanVien = nhanVien.HoTenNhanVien;
                    editItem.Email = nhanVien.Email;
                    editItem.SoDienThoai = nhanVien.SoDienThoai;
                    editItem.Email = nhanVien.Email;
                    editItem.ViTri = nhanVien.ViTri;
                    editItem.Password = nhanVien.Password;
                    editItem.GioiTinh = nhanVien.GioiTinh;
                    _context.NhanViens.Update(editItem);
                    _context.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                var deleteItem = _context.NhanViens.Find(id);
                if (deleteItem != null)
                {
                    _context.NhanViens.Remove(deleteItem);
                    _context.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
