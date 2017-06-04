using DevExpress.XtraEditors;
using Business;

namespace SaleManager.San_Pham
{
    public partial class UCSanPham : XtraUserControl
    {
        readonly SanPhamBUS _sanPham = new SanPhamBUS();

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
            gridControl.DataSource = _sanPham.ViewHangHoa();
        }
        #endregion
    }
}
