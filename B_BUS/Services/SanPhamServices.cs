using A_DAL.Models;
using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class SanPhamServices
    {
        SanPhamRepos _repo = new SanPhamRepos();
        
        public List<SanPham> GetAll()
        {
            return _repo.GetAll();
        }
        public string Create(SanPham sanPham)
        {
            if (_repo.CreateSP(sanPham))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
    }
}
