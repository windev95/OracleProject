using DevExpress.XtraEditors;
using Business;
using DevExpress.XtraEditors.Controls;

namespace SaleManager.San_Pham
{
    public partial class UCSanPham : XtraUserControl
    {
        #region Khai báo biến
        private readonly SanPhamBUS _sanPham = new SanPhamBUS();
        private readonly NhaSanXuatBUS _nsx = new NhaSanXuatBUS();
        private readonly LoaiHangHoaBUS _loaiHang = new LoaiHangHoaBUS();
        #endregion

        #region Load From
        public UCSanPham()
        {
            InitializeComponent();
        }

        private void UCSanPham_Load(object sender, System.EventArgs e)
        {
            LoadNhaSanXuat();
            LoadLoaiHang();
        }

        private void gridControl_Load(object sender, System.EventArgs e)
        {
            gridControl.DataSource = _sanPham.ViewHangHoa();
        }
        private void LoadNhaSanXuat()
        {
            luNhaSanXuat.Properties.DataSource = _nsx.ViewNhaSanXuat();
            luNhaSanXuat.Properties.ValueMember = "MANSX";
            luNhaSanXuat.Properties.DisplayMember = "TENNSX";
        }
        private void LoadLoaiHang()
        {
            luLoaiHangHoa.Properties.DataSource = _loaiHang.ViewLoaiHang();
            luLoaiHangHoa.Properties.ValueMember = "MALOAIHANG";
            luLoaiHangHoa.Properties.DisplayMember = "TENLOAIHANG";
        }
        #endregion

        #region Thêm, Xóa, Sửa
        private void btnThem_Click(object sender, System.EventArgs e)
        {
            XtraMessageBox.Show("Thêm");
        }
        private void btnSua_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            XtraMessageBox.Show("Sửa");
        }
        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            XtraMessageBox.Show("Lưu");
        }
        private void btnXoa_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            XtraMessageBox.Show("Xóa");
        }
        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            XtraMessageBox.Show("Hủy");
        }
        private void gridControl_Click(object sender, System.EventArgs e)
        {
            if (TENLOAIHANG != null) luLoaiHangHoa.EditValue = gridView.GetFocusedRowCellDisplayText(TENLOAIHANG);
            if (TENNSX != null) luNhaSanXuat.EditValue = gridView.GetFocusedRowCellDisplayText(TENNSX);
            if (TENHANGHOA != null) txtTenSanPham.Text = gridView.GetFocusedRowCellDisplayText(TENHANGHOA);
            if (MOTA != null) txtMoTa.Text = gridView.GetFocusedRowCellDisplayText(MOTA);
            if (SOLUONGTON != null) txtSoLuongTon.Text = gridView.GetFocusedRowCellDisplayText(SOLUONGTON);
            if (GIANHAP != null) txtGiaNhap.Text = gridView.GetFocusedRowCellDisplayText(GIANHAP);
        }
        #endregion
    }
}
