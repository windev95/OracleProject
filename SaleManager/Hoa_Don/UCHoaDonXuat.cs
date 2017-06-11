using System;
using System.Collections.Generic;
using Business;
using DevExpress.XtraEditors;

namespace SaleManager.Hoa_Don
{
    public partial class UCHoaDonXuat : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly KhachHangBUS _bus = new KhachHangBUS();
        private readonly SanPhamBUS _hh = new SanPhamBUS();
        private List<int> _listMaHangHoa = new List<int>();
        public UCHoaDonXuat()
        {
            InitializeComponent();
        }

        private void UCHoaDonXuat_Load(object sender, EventArgs e)
        {
            gcChonHangHoa.DataSource = _hh.ViewChonHangHoa();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gvChonHangHoa_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            _listMaHangHoa.Clear();
            for(var index = 0; index < gvChonHangHoa.GetSelectedRows().Length; index++)
            {
                var i = gvChonHangHoa.GetSelectedRows()[index];
                var idHangHoa = int.Parse(gvChonHangHoa.GetRowCellValue(Convert.ToInt32(i), "MAHANGHOA").ToString());
                _listMaHangHoa.Add(idHangHoa);
            }
        }

        private void gvChonHangHoa_RowCountChanged(object sender, EventArgs e)
        {
            foreach (var item in _listMaHangHoa)
            {
                var row = gvChonHangHoa.LocateByValue("MAHANGHOA", item);
                gvChonHangHoa.SelectRow(row);
            }
        }
    }
}
