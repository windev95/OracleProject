using System.Collections.Generic;
using DataTransferObject;
using DataAccess;

namespace Business
{
    public class LoaiHangHoaBUS
    {
        private readonly DataAccess.Model.Oracle db = new DataAccess.Model.Oracle();
        private readonly LoaiHangHoaDAL _loaiHang = new LoaiHangHoaDAL();
        public List<LoaiHangHoa> ViewLoaiHang()
        {
            return _loaiHang.ViewLoaiHang();
        }
    }
}
