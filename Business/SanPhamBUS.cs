using DataAccess;
using DataTransferObject;
using System.Collections.Generic;

namespace Business
{
    public class SanPhamBUS
    {
        readonly SanPhamDAL _sanPham = new SanPhamDAL();
        public List<HangHoa> ViewHangHoa()
        {
            return _sanPham.ViewHangHoa();
        }
    }
}
