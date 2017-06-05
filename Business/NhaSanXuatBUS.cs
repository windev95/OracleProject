using System.Collections.Generic;
using DataTransferObject;
using DataAccess;

namespace Business
{
    public class NhaSanXuatBUS
    {
        private readonly DataAccess.Model.Oracle db = new DataAccess.Model.Oracle();
        private readonly NhaSanXuatDAL _nsx = new NhaSanXuatDAL();
        public List<NhaSanXuat> ViewNhaSanXuat()
        {
            return _nsx.ViewNhaSanXuat();
        }
    }
}
