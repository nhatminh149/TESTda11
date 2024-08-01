using A_DAL.Models;
using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class NhanVienServices
    {
        NhanVienRepos _repos;
        public NhanVienServices()
        {
            _repos = new NhanVienRepos();
        }
        public List<NhanVien> CNShow()
        {
            return _repos.GetAll();
        }
        public NhanVien CNTim(string ten)
        {
            return _repos.GetById(ten);
        }
        public string CNThem(int ma,string ten, string sdt, string email, string vitri, string pass, string gioitinh)
        {
            NhanVien nv = new NhanVien()
            {
                MaNhanVien = ma,
                HoTenNhanVien = ten,
                SoDienThoai = sdt,
                Email = email,
                ViTri = vitri,
                Password = pass,
                GioiTinh = gioitinh
            };

            if (_repos.Create(nv))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string CNSua(int ma, string ten, string sdt, string email, string vitri, string pass, string gioitinh)
        {
            
            NhanVien nv = new NhanVien()
            {
                MaNhanVien = ma,
                HoTenNhanVien = ten,
                SoDienThoai = sdt,
                Email = email,
                ViTri = vitri,
                Password = pass
            };
            if (_repos.Edit(nv))
            {
                return "Sửa thành công";
            }return "Sửa thất bại";
        }
        public string CNXoa(int id)
        {
            if (_repos.Delete(id))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
    }
}
