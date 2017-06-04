using DataAccess;
using DataTransferObject;
using System.Collections.Generic;
using System.Data.Entity;

namespace Business
{
    public class SanPhamBUS
    {
        readonly SanPhamDAL _sanPham = new SanPhamDAL();
        readonly ViewHangHoa hh = new ViewHangHoa();
        public List<ViewHangHoa> ViewHangHoa()
        {
            return _sanPham.ViewHangHoa();
        }
        public DbSet ViewDemo()
        {
            return _sanPham.ViewDemo();
        }
    }
}
