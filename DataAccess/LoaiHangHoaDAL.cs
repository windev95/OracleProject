using System.Collections.Generic;
using System.Linq;
using DataTransferObject;

namespace DataAccess
{
    public class LoaiHangHoaDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<LoaiHangHoa> ViewLoaiHang()
        {
            return db.VIEWLOAIHANGs.Select(item => new LoaiHangHoa
            {
                MALOAIHANG = item.MALOAIHANG,
                TENLOAIHANG = item.TENLOAIHANG
            }).ToList();
        }
    }
}
