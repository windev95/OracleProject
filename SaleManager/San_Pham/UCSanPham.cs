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
        private bool _loaiLuu;
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
            SetButton(true);
            SetText(true);
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
        private void LoadThongTinHangHoa()
        {
            ClearText();
            if (TENLOAIHANG != null) luLoaiHangHoa.EditValue = luLoaiHangHoa.Properties.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText(TENLOAIHANG));
            if (TENNSX != null) luNhaSanXuat.EditValue = luNhaSanXuat.Properties.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText(TENNSX));
            if (TENHANGHOA != null) txtTenSanPham.Text = gridView.GetFocusedRowCellDisplayText(TENHANGHOA);
            if (MOTA != null) txtMoTa.Text = gridView.GetFocusedRowCellDisplayText(MOTA);
            if (SOLUONGTON != null) txtSoLuongTon.Text = gridView.GetFocusedRowCellDisplayText(SOLUONGTON);
            if (GIANHAP != null) txtGiaNhap.Text = gridView.GetFocusedRowCellDisplayText(GIANHAP);
        }
        #endregion

        #region Thêm, Xóa, Sửa
        private void btnThem_Click(object sender, System.EventArgs e)
        {
            _loaiLuu = true;
            SetButton(false);
            SetText(false);
            ClearText();
        }
        private void btnSua_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _loaiLuu = false;
            SetButton(true);
            SetText(true);
            LoadThongTinHangHoa();            
        }
        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            var tenHangHoa = txtTenSanPham.Text;
            var moTa = txtMoTa.Text;
            var soLuongTon = decimal.Parse(txtSoLuongTon.Text);
            var giaNhap = decimal.Parse(txtGiaNhap.Text);
            var nsx = decimal.Parse(luNhaSanXuat.EditValue.ToString());
            var loaiHang = decimal.Parse(luLoaiHangHoa.EditValue.ToString());
            if (_loaiLuu)
            {
                _sanPham.ThemHangHoa(tenHangHoa, moTa, soLuongTon, giaNhap, nsx, loaiHang);
            }
            else
            {

            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
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
            LoadThongTinHangHoa();
        }
        #endregion

        #region Set Button, Text
        /// <summary>
        /// Set ẩn hoặc hiện Button
        /// </summary>
        /// <param name="type">= True btnThem hiện</param>
        private void SetButton(bool type)
        {
            btnThem.Enabled = type;
            btnLuu.Enabled = !type;
            btnHuy.Enabled = !type;
        }
        /// <summary>
        /// Set ẩn hoặc cho sửa các trường thông tin
        /// </summary>
        /// <param name="type">= true không cho sửa</param>
        private void SetText(bool type)
        {
            txtTenSanPham.Properties.ReadOnly = type;
            txtSoLuongTon.Properties.ReadOnly = type;
            txtGiaNhap.Properties.ReadOnly = type;
            txtMoTa.Properties.ReadOnly = type;
            luLoaiHangHoa.Properties.ReadOnly = type;
            luNhaSanXuat.Properties.ReadOnly = type;
            gridControl.Enabled = type;
        }
        private void ClearText()
        {
            txtTenSanPham.Text = "";
            txtSoLuongTon.Text = "";
            txtMoTa.Text = "";
            txtGiaNhap.Text = "";
            //luLoaiHangHoa.EditValue = null;
            //luNhaSanXuat.EditValue = null;
        }
        #endregion
    }
}
