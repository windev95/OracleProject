using DataTransferObject;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class SanPhamDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<HangHoa> ViewHangHoa()
        {
            return db.VIEW_HANG_HOA.Select(item => new HangHoa
            {
                MAHANGHOA = item.MAHANGHOA,
                TENHANGHOA = item.TENHANGHOA,
                MOTA = item.MOTA,
                GIANHAP = item.GIANHAP,
                SOLUONGTON = item.SOLUONGTON,
                TENLOAIHANG = item.TENLOAIHANG,
                TENNSX = item.TENNSX
            }).ToList();
        }
        public List<HangHoa> ViewChonHangHoa()
        {
            return db.VIEW_HANG_HOA.Select(item => new HangHoa
            {
                MAHANGHOA = item.MAHANGHOA,
                TENHANGHOA = item.TENHANGHOA,
                GIANHAP = (item.GIANHAP * 110)/100,
                SOLUONGTON = item.SOLUONGTON,
                TENNSX = item.TENNSX
            }).ToList();
        }
        public List<string> ViewTenHangHoa()
        {
            return db.VIEW_TEN_HANG_HOA.Select(item => item.TENHANGHOA).ToList();
        }
        public bool ThemHangHoa(HangHoa hangHoa)
        {
            var item = db.THEM_HANG_HOA(hangHoa.TENHANGHOA, hangHoa.MOTA, hangHoa.SOLUONGTON, hangHoa.GIANHAP, hangHoa.MANSX, hangHoa.MALOAIHANG);
            return true;
        }
        public bool SuaHangHoa(HangHoa hangHoa)
        {
            var item = db.SUA_HANG_HOA(hangHoa.MAHANGHOA, hangHoa.TENHANGHOA, hangHoa.MOTA, hangHoa.SOLUONGTON, hangHoa.GIANHAP, hangHoa.MANSX, hangHoa.MALOAIHANG);
            return true;
        }
        public bool XoaHangHoa(decimal maHangHoa)
        {
            var item = db.XOA_HANG_HOA(maHangHoa);
            return true;
        }
    }
}
