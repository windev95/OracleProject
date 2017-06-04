using DataTransferObject;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class SanPhamDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        private readonly ViewHangHoa hh = new ViewHangHoa();
        public List<ViewHangHoa> ViewHangHoa()
        {
            var list = new List<ViewHangHoa>();
            foreach(var item in db.VIEWHANGHOAs.ToList())
            {
                list.Add(new ViewHangHoa
                {
                    MAHANGHOA = item.MAHANGHOA,
                    TENHANGHOA = item.TENHANGHOA,
                    MOTA = item.MOTA,
                    GIANHAP = item.GIANHAP,
                    SOLUONGTON = item.SOLUONGTON,
                    TENLOAIHANG = item.TENLOAIHANG,
                    TENNSX = item.TENNSX
                });
            }
            return list;
        }        
        public DbSet ViewDemo()
        {
            return db.VIEWHANGHOAs;
        }
    }
}
