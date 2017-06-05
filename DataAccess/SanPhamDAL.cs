using DataTransferObject;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class SanPhamDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<HangHoa> ViewHangHoa()
        {
            return db.VIEWHANGHOAs.Select(item => new HangHoa
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
    }
}
