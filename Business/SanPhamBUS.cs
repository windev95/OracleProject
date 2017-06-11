using DataAccess;
using DataTransferObject;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class SanPhamBUS
    {
        readonly SanPhamDAL _hangHoa = new SanPhamDAL();
        public List<HangHoa> ViewHangHoa()
        {
            return _hangHoa.ViewHangHoa();
        }
        public List<HangHoa> ViewChonHangHoa()
        {
            return _hangHoa.ViewChonHangHoa();
        }
        public List<string> ViewTenHangHoa()
        {
            return _hangHoa.ViewTenHangHoa();
        }
        public void ThemHangHoa(HangHoa hangHoa)
        {
            _hangHoa.ThemHangHoa(hangHoa);
        }
        public void SuaHangHoa(HangHoa hangHoa)
        {
            _hangHoa.SuaHangHoa(hangHoa);
        }
        public void XoaHangHoa(decimal maHangHoa)
        {
            _hangHoa.XoaHangHoa(maHangHoa);
        }
        /// <summary>
        /// Kiểm tra tên hàng hóa
        /// </summary>
        /// <param name="tenHangHoaMoi">Tên hàng hóa đã nhập</param>
        /// <param name="tenHangHoaCu">Tên hàng hóa đã được lưu (nếu là sửa)</param>
        /// <param name="loai">true là thêm</param>
        /// <returns>true cho phép thêm</returns>
        public bool KiemTraTenHangHoa(string tenHangHoaMoi, string tenHangHoaCu, bool loai)
        {
            if (loai == false && tenHangHoaMoi.Equals(tenHangHoaCu)) return true;
            return ViewTenHangHoa().All(item => !tenHangHoaMoi.Equals(item));
        }
    }
}
