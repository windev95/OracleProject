namespace SaleManager.San_Pham
{
    partial class UCSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSanPham));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHANGHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENHANGHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIANHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAIHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.XOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.luLoaiHangHoa = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.luNhaSanXuat = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuongTon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.gbTuyChon = new System.Windows.Forms.GroupBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luLoaiHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luNhaSanXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            this.gbTuyChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(0, 178);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSua,
            this.btnXoa});
            this.gridControl.Size = new System.Drawing.Size(1000, 320);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.Load += new System.EventHandler(this.gridControl_Load);
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHANGHOA,
            this.TENHANGHOA,
            this.MOTA,
            this.SOLUONGTON,
            this.GIANHAP,
            this.TENLOAIHANG,
            this.TENNSX,
            this.SUA,
            this.XOA});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView.OptionsView.ShowDetailButtons = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // MAHANGHOA
            // 
            this.MAHANGHOA.Caption = "Mã Sản Phẩm";
            this.MAHANGHOA.FieldName = "MAHANGHOA";
            this.MAHANGHOA.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.MAHANGHOA.Name = "MAHANGHOA";
            this.MAHANGHOA.OptionsColumn.AllowEdit = false;
            this.MAHANGHOA.OptionsColumn.ReadOnly = true;
            this.MAHANGHOA.Visible = true;
            this.MAHANGHOA.VisibleIndex = 0;
            // 
            // TENHANGHOA
            // 
            this.TENHANGHOA.Caption = "Tên Sản Phẩm";
            this.TENHANGHOA.FieldName = "TENHANGHOA";
            this.TENHANGHOA.Name = "TENHANGHOA";
            this.TENHANGHOA.OptionsColumn.AllowEdit = false;
            this.TENHANGHOA.OptionsColumn.ReadOnly = true;
            this.TENHANGHOA.Visible = true;
            this.TENHANGHOA.VisibleIndex = 1;
            // 
            // MOTA
            // 
            this.MOTA.Caption = "Mô Tả";
            this.MOTA.FieldName = "MOTA";
            this.MOTA.Name = "MOTA";
            this.MOTA.OptionsColumn.AllowEdit = false;
            this.MOTA.OptionsColumn.ReadOnly = true;
            this.MOTA.Visible = true;
            this.MOTA.VisibleIndex = 2;
            // 
            // SOLUONGTON
            // 
            this.SOLUONGTON.Caption = "Số Lượng Tồn";
            this.SOLUONGTON.FieldName = "SOLUONGTON";
            this.SOLUONGTON.Name = "SOLUONGTON";
            this.SOLUONGTON.OptionsColumn.AllowEdit = false;
            this.SOLUONGTON.OptionsColumn.ReadOnly = true;
            this.SOLUONGTON.Visible = true;
            this.SOLUONGTON.VisibleIndex = 3;
            // 
            // GIANHAP
            // 
            this.GIANHAP.Caption = "Gía Nhập";
            this.GIANHAP.FieldName = "GIANHAP";
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.OptionsColumn.AllowEdit = false;
            this.GIANHAP.OptionsColumn.ReadOnly = true;
            this.GIANHAP.Visible = true;
            this.GIANHAP.VisibleIndex = 4;
            // 
            // TENLOAIHANG
            // 
            this.TENLOAIHANG.Caption = "Loại Hàng Hóa";
            this.TENLOAIHANG.FieldName = "TENLOAIHANG";
            this.TENLOAIHANG.Name = "TENLOAIHANG";
            this.TENLOAIHANG.OptionsColumn.AllowEdit = false;
            this.TENLOAIHANG.OptionsColumn.ReadOnly = true;
            this.TENLOAIHANG.Visible = true;
            this.TENLOAIHANG.VisibleIndex = 5;
            // 
            // TENNSX
            // 
            this.TENNSX.Caption = "Nhà Sản Xuất";
            this.TENNSX.FieldName = "TENNSX";
            this.TENNSX.Name = "TENNSX";
            this.TENNSX.OptionsColumn.AllowEdit = false;
            this.TENNSX.OptionsColumn.ReadOnly = true;
            this.TENNSX.Visible = true;
            this.TENNSX.VisibleIndex = 6;
            // 
            // SUA
            // 
            this.SUA.Caption = "Sửa";
            this.SUA.ColumnEdit = this.btnSua;
            this.SUA.FieldName = "btnSua";
            this.SUA.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.SUA.Name = "SUA";
            this.SUA.OptionsColumn.ReadOnly = true;
            this.SUA.Visible = true;
            this.SUA.VisibleIndex = 7;
            // 
            // btnSua
            // 
            this.btnSua.AppearanceReadOnly.Image = global::SaleManager.Properties.Resources.edit;
            this.btnSua.AppearanceReadOnly.Options.UseImage = true;
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.BottomCenter, global::SaleManager.Properties.Resources.edit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnSua.Name = "btnSua";
            this.btnSua.ReadOnly = true;
            this.btnSua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSua.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSua_ButtonClick);
            // 
            // XOA
            // 
            this.XOA.Caption = "Xóa";
            this.XOA.ColumnEdit = this.btnXoa;
            this.XOA.FieldName = "btnXoa";
            this.XOA.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.XOA.Name = "XOA";
            this.XOA.OptionsColumn.ReadOnly = true;
            this.XOA.Visible = true;
            this.XOA.VisibleIndex = 8;
            // 
            // btnXoa
            // 
            this.btnXoa.AppearanceReadOnly.Image = global::SaleManager.Properties.Resources.delete;
            this.btnXoa.AppearanceReadOnly.Options.UseImage = true;
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SaleManager.Properties.Resources.delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ReadOnly = true;
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoa_ButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.luLoaiHangHoa);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.luNhaSanXuat);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(123, 75);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(342, 20);
            this.txtGiaNhap.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Location = new System.Drawing.Point(18, 76);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 16);
            this.labelControl6.TabIndex = 81;
            this.labelControl6.Text = "Gía Nhập";
            // 
            // luLoaiHangHoa
            // 
            this.luLoaiHangHoa.Location = new System.Drawing.Point(123, 101);
            this.luLoaiHangHoa.Name = "luLoaiHangHoa";
            this.luLoaiHangHoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luLoaiHangHoa.Properties.NullText = "Vui Lòng Chọn Loại Hàng Hóa";
            this.luLoaiHangHoa.Size = new System.Drawing.Size(342, 20);
            this.luLoaiHangHoa.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Location = new System.Drawing.Point(18, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 16);
            this.labelControl4.TabIndex = 79;
            this.labelControl4.Text = "Loại Hàng Hóa";
            // 
            // luNhaSanXuat
            // 
            this.luNhaSanXuat.Location = new System.Drawing.Point(123, 130);
            this.luNhaSanXuat.Name = "luNhaSanXuat";
            this.luNhaSanXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luNhaSanXuat.Properties.NullText = "Vui Lòng Chọn Nhà Sản Xuất";
            this.luNhaSanXuat.Size = new System.Drawing.Size(342, 20);
            this.luNhaSanXuat.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(18, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 16);
            this.labelControl3.TabIndex = 77;
            this.labelControl3.Text = "Nhà Sản Xuất";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(123, 49);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(342, 20);
            this.txtSoLuongTon.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(18, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 16);
            this.labelControl2.TabIndex = 73;
            this.labelControl2.Text = "Số Lượng Tồn";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(123, 23);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(342, 20);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(18, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 16);
            this.labelControl1.TabIndex = 71;
            this.labelControl1.Text = "Tên Sản Phẩm";
            // 
            // gb
            // 
            this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb.Controls.Add(this.labelControl5);
            this.gb.Controls.Add(this.txtMoTa);
            this.gb.Controls.Add(this.gbTuyChon);
            this.gb.Location = new System.Drawing.Point(502, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(495, 172);
            this.gb.TabIndex = 83;
            this.gb.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Location = new System.Drawing.Point(24, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 16);
            this.labelControl5.TabIndex = 69;
            this.labelControl5.Text = "Mô Tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.Location = new System.Drawing.Point(86, 20);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(391, 72);
            this.txtMoTa.TabIndex = 6;
            // 
            // gbTuyChon
            // 
            this.gbTuyChon.Controls.Add(this.btnHuy);
            this.gbTuyChon.Controls.Add(this.btnThem);
            this.gbTuyChon.Controls.Add(this.btnLuu);
            this.gbTuyChon.Location = new System.Drawing.Point(86, 98);
            this.gbTuyChon.Name = "gbTuyChon";
            this.gbTuyChon.Size = new System.Drawing.Size(282, 52);
            this.gbTuyChon.TabIndex = 67;
            this.gbTuyChon.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(188, 12);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 34);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = global::SaleManager.Properties.Resources.add2;
            this.btnThem.Location = new System.Drawing.Point(6, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(97, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 34);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // UCSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl);
            this.Name = "UCSanPham";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UCSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luLoaiHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luNhaSanXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            this.gbTuyChon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn MAHANGHOA;
        private DevExpress.XtraGrid.Columns.GridColumn TENHANGHOA;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn MOTA;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONGTON;
        private DevExpress.XtraGrid.Columns.GridColumn GIANHAP;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIHANG;
        private DevExpress.XtraGrid.Columns.GridColumn TENNSX;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.TextEdit txtGiaNhap;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit luLoaiHangHoa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit luNhaSanXuat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSoLuongTon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox gb;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtMoTa;
        private System.Windows.Forms.GroupBox gbTuyChon;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn SUA;
        private DevExpress.XtraGrid.Columns.GridColumn XOA;
    }
}
