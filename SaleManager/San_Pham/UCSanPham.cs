using DevExpress.XtraEditors;
using Business;
using SaleManager.Model;
using System.Linq;

namespace SaleManager.San_Pham
{
    public partial class UCSanPham : XtraUserControl
    {
        //readonly SanPhamBUS _sanPham = new SanPhamBUS();
        DB db = new DB();

        #region Load From
        public UCSanPham()
        {
            InitializeComponent();
        }

        private void UCSanPham_Load(object sender, System.EventArgs e)
        {

        }

        private void gridControl_Load(object sender, System.EventArgs e)
        {
            gridControl.DataSource = db.VIEWHANGHOAs.ToList();
        }
        #endregion
    }
}
