using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class SanPhamRepos
    {
        CuaHangBanGiay_DA1Context _context = new CuaHangBanGiay_DA1Context();
        public SanPhamRepos()
        {
            _context = new CuaHangBanGiay_DA1Context();
        }
        public List<SanPham> GetAll()
        {
            return _context.SanPhams.ToList();
        }
        public SanPham GetById(int id)
        {
            return _context.SanPhams.Find(id);
        }
        public bool CreateSP(SanPham sp)
        {
            try
            {
                _context.SanPhams.Add(sp); _context.SaveChanges(); return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Remove(SanPham product)
        {
            throw new NotImplementedException();
        }
    
}
}
