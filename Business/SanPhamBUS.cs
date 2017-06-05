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
        public void ThemHangHoa(string tenHangHoa, string moTa, decimal soLuongTon, decimal giaNhap, decimal nsx, decimal loaiHang)
        {
            _sanPham.ThemHangHoa(tenHangHoa, moTa, soLuongTon, giaNhap, nsx, loaiHang);
        }
    }
}
