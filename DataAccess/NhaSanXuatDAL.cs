using System.Collections.Generic;
using System.Linq;
using DataTransferObject;

namespace DataAccess
{
    public class NhaSanXuatDAL
    {
        private readonly Model.Oracle db = new Model.Oracle();
        public List<NhaSanXuat> ViewNhaSanXuat()
        {
            return db.VIEWNHASANXUATs.Select(item => new NhaSanXuat
            {
                MANSX = item.MANSX,
                TENNSX = item.TENNSX
            }).ToList();
        }
    }
}
