namespace QLVT
{
    partial class FrmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maHDLabel;
            System.Windows.Forms.Label ngayLabel;
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label maKhoLabel;
            System.Windows.Forms.Label maHDLabel1;
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label donGiaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemCTHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCTHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.qLVTDS = new QLVT.QLVTDS();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new QLVT.QLVTDSTableAdapters.HoaDonTableAdapter();
            this.tableAdapterManager = new QLVT.QLVTDSTableAdapters.TableAdapterManager();
            this.cTHoaDonTableAdapter = new QLVT.QLVTDSTableAdapters.CTHoaDonTableAdapter();
            this.hoaDonGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHoaDonGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMaKho = new System.Windows.Forms.ComboBox();
            this.sP_LAYMAKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMK = new QLVT.DSMK();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new System.Windows.Forms.ComboBox();
            this.v_LAYMAKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSKH = new QLVT.DSKH();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaHD = new DevExpress.XtraEditors.TextEdit();
            this.groupBoxCT = new System.Windows.Forms.GroupBox();
            this.txtDG = new DevExpress.XtraEditors.SpinEdit();
            this.btnHuyCT = new System.Windows.Forms.Button();
            this.btnOKCT = new System.Windows.Forms.Button();
            this.txtSL = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaMHCT = new System.Windows.Forms.ComboBox();
            this.v_LAYMAVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMVT = new QLVT.DSMVT();
            this.txtMaHDCT = new DevExpress.XtraEditors.TextEdit();
            this.v_LAYMAKHTableAdapter = new QLVT.DSKHTableAdapters.V_LAYMAKHTableAdapter();
            this.tableAdapterManager1 = new QLVT.DSKHTableAdapters.TableAdapterManager();
            this.sP_LAYMAKHOTableAdapter = new QLVT.DSMKTableAdapters.SP_LAYMAKHOTableAdapter();
            this.tableAdapterManager2 = new QLVT.DSMKTableAdapters.TableAdapterManager();
            this.v_LAYMAVTTableAdapter = new QLVT.DSMVTTableAdapters.V_LAYMAVTTableAdapter();
            this.tableAdapterManager3 = new QLVT.DSMVTTableAdapters.TableAdapterManager();
            maHDLabel = new System.Windows.Forms.Label();
            ngayLabel = new System.Windows.Forms.Label();
            maKHLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            maKhoLabel = new System.Windows.Forms.Label();
            maHDLabel1 = new System.Windows.Forms.Label();
            maMHLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYMAKHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYMAKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).BeginInit();
            this.groupBoxCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYMAVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHDCT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maHDLabel
            // 
            maHDLabel.AutoSize = true;
            maHDLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maHDLabel.Location = new System.Drawing.Point(30, 32);
            maHDLabel.Name = "maHDLabel";
            maHDLabel.Size = new System.Drawing.Size(59, 19);
            maHDLabel.TabIndex = 0;
            maHDLabel.Text = "Ma HD:";
            // 
            // ngayLabel
            // 
            ngayLabel.AutoSize = true;
            ngayLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayLabel.Location = new System.Drawing.Point(44, 70);
            ngayLabel.Name = "ngayLabel";
            ngayLabel.Size = new System.Drawing.Size(45, 19);
            ngayLabel.TabIndex = 2;
            ngayLabel.Text = "Ngay:";
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKHLabel.Location = new System.Drawing.Point(29, 114);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(60, 19);
            maKHLabel.TabIndex = 4;
            maKHLabel.Text = "Ma KH:";
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNVLabel.Location = new System.Drawing.Point(30, 156);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(59, 19);
            maNVLabel.TabIndex = 6;
            maNVLabel.Text = "Ma NV:";
            // 
            // maKhoLabel
            // 
            maKhoLabel.AutoSize = true;
            maKhoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhoLabel.Location = new System.Drawing.Point(25, 199);
            maKhoLabel.Name = "maKhoLabel";
            maKhoLabel.Size = new System.Drawing.Size(64, 19);
            maKhoLabel.TabIndex = 8;
            maKhoLabel.Text = "Ma Kho:";
            // 
            // maHDLabel1
            // 
            maHDLabel1.AutoSize = true;
            maHDLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maHDLabel1.Location = new System.Drawing.Point(51, 42);
            maHDLabel1.Name = "maHDLabel1";
            maHDLabel1.Size = new System.Drawing.Size(59, 19);
            maHDLabel1.TabIndex = 0;
            maHDLabel1.Text = "Ma HD:";
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMHLabel.Location = new System.Drawing.Point(48, 96);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(62, 19);
            maMHLabel.TabIndex = 2;
            maMHLabel.Text = "Ma MH:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongLabel.Location = new System.Drawing.Point(39, 149);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(71, 19);
            soLuongLabel.TabIndex = 4;
            soLuongLabel.Text = "So Luong:";
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            donGiaLabel.Location = new System.Drawing.Point(47, 200);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(63, 19);
            donGiaLabel.TabIndex = 13;
            donGiaLabel.Text = "Don Gia:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemHD,
            this.btnXoaHD,
            this.btnReload,
            this.btnThemCTHD,
            this.btnThoat,
            this.btnXoaCTHD});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemHD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaHD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCTHD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaCTHD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemHD
            // 
            this.btnThemHD.Caption = "Thêm HD";
            this.btnThemHD.Id = 0;
            this.btnThemHD.ImageOptions.Image = global::QLVT.Properties.Resources.Actions_list_add_user_icon_24;
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemHD_ItemClick);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Caption = "Xoá HD";
            this.btnXoaHD.Id = 1;
            this.btnXoaHD.ImageOptions.Image = global::QLVT.Properties.Resources.Delete_2_icon_24;
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaHD_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Refresh";
            this.btnReload.Id = 2;
            this.btnReload.ImageOptions.Image = global::QLVT.Properties.Resources.Button_Refresh_icon_24;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThemCTHD
            // 
            this.btnThemCTHD.Caption = "Thêm CTHD";
            this.btnThemCTHD.Id = 3;
            this.btnThemCTHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCTHD.ImageOptions.Image")));
            this.btnThemCTHD.Name = "btnThemCTHD";
            this.btnThemCTHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCTHD_ItemClick);
            // 
            // btnXoaCTHD
            // 
            this.btnXoaCTHD.Caption = "Xoá CTHD";
            this.btnXoaCTHD.Id = 5;
            this.btnXoaCTHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCTHD.ImageOptions.Image")));
            this.btnXoaCTHD.Name = "btnXoaCTHD";
            this.btnXoaCTHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaCTHD_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.Image = global::QLVT.Properties.Resources.Exit_24_icon;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1332, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 854);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1332, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 793);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1332, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 793);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChinhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 93);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh:";
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(576, 33);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(321, 27);
            this.cmbChinhanh.TabIndex = 0;
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // qLVTDS
            // 
            this.qLVTDS.DataSetName = "QLVTDS";
            this.qLVTDS.EnforceConstraints = false;
            this.qLVTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qLVTDS;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDatHangTableAdapter = null;
            this.tableAdapterManager.CTHoaDonTableAdapter = this.cTHoaDonTableAdapter;
            this.tableAdapterManager.CTPhieuNhapTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = this.hoaDonTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = null;
            this.tableAdapterManager.NhaCCTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTHoaDonTableAdapter
            // 
            this.cTHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // hoaDonGridControl
            // 
            this.hoaDonGridControl.DataSource = this.hoaDonBindingSource;
            this.hoaDonGridControl.Location = new System.Drawing.Point(0, 168);
            this.hoaDonGridControl.MainView = this.gridView1;
            this.hoaDonGridControl.MenuManager = this.barManager1;
            this.hoaDonGridControl.Name = "hoaDonGridControl";
            this.hoaDonGridControl.Size = new System.Drawing.Size(747, 186);
            this.hoaDonGridControl.TabIndex = 7;
            this.hoaDonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHD1,
            this.colNgay,
            this.colMaKH,
            this.colMaNV,
            this.colMaKho});
            this.gridView1.GridControl = this.hoaDonGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaHD1
            // 
            this.colMaHD1.FieldName = "MaHD";
            this.colMaHD1.Name = "colMaHD1";
            this.colMaHD1.OptionsColumn.AllowEdit = false;
            this.colMaHD1.Visible = true;
            this.colMaHD1.VisibleIndex = 0;
            // 
            // colNgay
            // 
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.OptionsColumn.AllowEdit = false;
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.OptionsColumn.AllowEdit = false;
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 2;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.OptionsColumn.AllowEdit = false;
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 3;
            // 
            // colMaKho
            // 
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.AllowEdit = false;
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 4;
            // 
            // cTHoaDonBindingSource
            // 
            this.cTHoaDonBindingSource.DataMember = "FK_CTHoaDon_HoaDon";
            this.cTHoaDonBindingSource.DataSource = this.hoaDonBindingSource;
            // 
            // cTHoaDonGridControl
            // 
            this.cTHoaDonGridControl.DataSource = this.cTHoaDonBindingSource;
            this.cTHoaDonGridControl.Location = new System.Drawing.Point(753, 168);
            this.cTHoaDonGridControl.MainView = this.gridView2;
            this.cTHoaDonGridControl.MenuManager = this.barManager1;
            this.cTHoaDonGridControl.Name = "cTHoaDonGridControl";
            this.cTHoaDonGridControl.Size = new System.Drawing.Size(579, 186);
            this.cTHoaDonGridControl.TabIndex = 7;
            this.cTHoaDonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHD,
            this.colMaMH,
            this.colSoLuong,
            this.colDonGia});
            this.gridView2.GridControl = this.cTHoaDonGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMaHD
            // 
            this.colMaHD.FieldName = "MaHD";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.OptionsColumn.AllowEdit = false;
            this.colMaHD.Visible = true;
            this.colMaHD.VisibleIndex = 0;
            // 
            // colMaMH
            // 
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.OptionsColumn.AllowEdit = false;
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 1;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsColumn.AllowEdit = false;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            // 
            // colDonGia
            // 
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.OptionsColumn.AllowEdit = false;
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnHuy);
            this.groupBox.Controls.Add(this.btnOK);
            this.groupBox.Controls.Add(maKhoLabel);
            this.groupBox.Controls.Add(this.txtMaKho);
            this.groupBox.Controls.Add(maNVLabel);
            this.groupBox.Controls.Add(this.txtMaNV);
            this.groupBox.Controls.Add(maKHLabel);
            this.groupBox.Controls.Add(this.txtMaKH);
            this.groupBox.Controls.Add(ngayLabel);
            this.groupBox.Controls.Add(this.txtNgay);
            this.groupBox.Controls.Add(maHDLabel);
            this.groupBox.Controls.Add(this.txtMaHD);
            this.groupBox.Location = new System.Drawing.Point(12, 362);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(465, 259);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "HoaDon";
            this.groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(327, 137);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 43);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(327, 68);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 40);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "MaKho", true));
            this.txtMaKho.DataSource = this.sP_LAYMAKHOBindingSource;
            this.txtMaKho.DisplayMember = "MaKho";
            this.txtMaKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaKho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKho.FormattingEnabled = true;
            this.txtMaKho.Location = new System.Drawing.Point(95, 196);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(172, 27);
            this.txtMaKho.TabIndex = 9;
            this.txtMaKho.ValueMember = "MaKho";
            // 
            // sP_LAYMAKHOBindingSource
            // 
            this.sP_LAYMAKHOBindingSource.DataMember = "SP_LAYMAKHO";
            this.sP_LAYMAKHOBindingSource.DataSource = this.dSMK;
            // 
            // dSMK
            // 
            this.dSMK.DataSetName = "DSMK";
            this.dSMK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hoaDonBindingSource, "MaNV", true));
            this.txtMaNV.Location = new System.Drawing.Point(95, 153);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(172, 26);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "MaKH", true));
            this.txtMaKH.DataSource = this.v_LAYMAKHBindingSource;
            this.txtMaKH.DisplayMember = "MaKH";
            this.txtMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.FormattingEnabled = true;
            this.txtMaKH.Location = new System.Drawing.Point(95, 111);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(172, 27);
            this.txtMaKH.TabIndex = 5;
            this.txtMaKH.ValueMember = "MaKH";
            // 
            // v_LAYMAKHBindingSource
            // 
            this.v_LAYMAKHBindingSource.DataMember = "V_LAYMAKH";
            this.v_LAYMAKHBindingSource.DataSource = this.dSKH;
            // 
            // dSKH
            // 
            this.dSKH.DataSetName = "DSKH";
            this.dSKH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hoaDonBindingSource, "Ngay", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(95, 67);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Properties.Appearance.Options.UseFont = true;
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(172, 26);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaHD
            // 
            this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hoaDonBindingSource, "MaHD", true));
            this.txtMaHD.Location = new System.Drawing.Point(95, 29);
            this.txtMaHD.MenuManager = this.barManager1;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Properties.Appearance.Options.UseFont = true;
            this.txtMaHD.Size = new System.Drawing.Size(172, 26);
            this.txtMaHD.TabIndex = 1;
            // 
            // groupBoxCT
            // 
            this.groupBoxCT.Controls.Add(donGiaLabel);
            this.groupBoxCT.Controls.Add(this.txtDG);
            this.groupBoxCT.Controls.Add(this.btnHuyCT);
            this.groupBoxCT.Controls.Add(this.btnOKCT);
            this.groupBoxCT.Controls.Add(soLuongLabel);
            this.groupBoxCT.Controls.Add(this.txtSL);
            this.groupBoxCT.Controls.Add(maMHLabel);
            this.groupBoxCT.Controls.Add(this.txtMaMHCT);
            this.groupBoxCT.Controls.Add(maHDLabel1);
            this.groupBoxCT.Controls.Add(this.txtMaHDCT);
            this.groupBoxCT.Location = new System.Drawing.Point(482, 362);
            this.groupBoxCT.Name = "groupBoxCT";
            this.groupBoxCT.Size = new System.Drawing.Size(457, 259);
            this.groupBoxCT.TabIndex = 9;
            this.groupBoxCT.TabStop = false;
            this.groupBoxCT.Text = "CTHoaDon";
            // 
            // txtDG
            // 
            this.txtDG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHoaDonBindingSource, "DonGia", true));
            this.txtDG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDG.Location = new System.Drawing.Point(116, 197);
            this.txtDG.MenuManager = this.barManager1;
            this.txtDG.Name = "txtDG";
            this.txtDG.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDG.Properties.Appearance.Options.UseFont = true;
            this.txtDG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDG.Size = new System.Drawing.Size(158, 26);
            this.txtDG.TabIndex = 14;
            // 
            // btnHuyCT
            // 
            this.btnHuyCT.Location = new System.Drawing.Point(333, 143);
            this.btnHuyCT.Name = "btnHuyCT";
            this.btnHuyCT.Size = new System.Drawing.Size(82, 45);
            this.btnHuyCT.TabIndex = 13;
            this.btnHuyCT.Text = "Huỷ";
            this.btnHuyCT.UseVisualStyleBackColor = true;
            this.btnHuyCT.Click += new System.EventHandler(this.btnHuyCT_Click);
            // 
            // btnOKCT
            // 
            this.btnOKCT.Location = new System.Drawing.Point(333, 70);
            this.btnOKCT.Name = "btnOKCT";
            this.btnOKCT.Size = new System.Drawing.Size(82, 38);
            this.btnOKCT.TabIndex = 12;
            this.btnOKCT.Text = "OK";
            this.btnOKCT.UseVisualStyleBackColor = true;
            this.btnOKCT.Click += new System.EventHandler(this.btnOKCT_Click);
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHoaDonBindingSource, "SoLuong", true));
            this.txtSL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSL.Location = new System.Drawing.Point(116, 146);
            this.txtSL.MenuManager = this.barManager1;
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Properties.Appearance.Options.UseFont = true;
            this.txtSL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSL.Size = new System.Drawing.Size(158, 26);
            this.txtSL.TabIndex = 5;
            // 
            // txtMaMHCT
            // 
            this.txtMaMHCT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTHoaDonBindingSource, "MaMH", true));
            this.txtMaMHCT.DataSource = this.v_LAYMAVTBindingSource;
            this.txtMaMHCT.DisplayMember = "MaMH";
            this.txtMaMHCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaMHCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMHCT.FormattingEnabled = true;
            this.txtMaMHCT.Location = new System.Drawing.Point(116, 93);
            this.txtMaMHCT.Name = "txtMaMHCT";
            this.txtMaMHCT.Size = new System.Drawing.Size(158, 27);
            this.txtMaMHCT.TabIndex = 3;
            this.txtMaMHCT.ValueMember = "MaMH";
            // 
            // v_LAYMAVTBindingSource
            // 
            this.v_LAYMAVTBindingSource.DataMember = "V_LAYMAVT";
            this.v_LAYMAVTBindingSource.DataSource = this.dSMVT;
            // 
            // dSMVT
            // 
            this.dSMVT.DataSetName = "DSMVT";
            this.dSMVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaHDCT
            // 
            this.txtMaHDCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHoaDonBindingSource, "MaHD", true));
            this.txtMaHDCT.Location = new System.Drawing.Point(116, 39);
            this.txtMaHDCT.MenuManager = this.barManager1;
            this.txtMaHDCT.Name = "txtMaHDCT";
            this.txtMaHDCT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDCT.Properties.Appearance.Options.UseFont = true;
            this.txtMaHDCT.Size = new System.Drawing.Size(158, 26);
            this.txtMaHDCT.TabIndex = 1;
            // 
            // v_LAYMAKHTableAdapter
            // 
            this.v_LAYMAKHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.DSKHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_LAYMAKHOTableAdapter
            // 
            this.sP_LAYMAKHOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = QLVT.DSMKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_LAYMAVTTableAdapter
            // 
            this.v_LAYMAVTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = QLVT.DSMVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 874);
            this.Controls.Add(this.groupBoxCT);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cTHoaDonGridControl);
            this.Controls.Add(this.hoaDonGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYMAKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYMAKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).EndInit();
            this.groupBoxCT.ResumeLayout(false);
            this.groupBoxCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYMAVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHDCT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemHD;
        private DevExpress.XtraBars.BarButtonItem btnXoaHD;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThemCTHD;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QLVTDS qLVTDS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private QLVTDSTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private QLVTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl hoaDonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVTDSTableAdapters.CTHoaDonTableAdapter cTHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource cTHoaDonBindingSource;
        private System.Windows.Forms.GroupBox groupBoxCT;
        private System.Windows.Forms.GroupBox groupBox;
        private DevExpress.XtraGrid.GridControl cTHoaDonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHD1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private System.Windows.Forms.ComboBox txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.ComboBox txtMaKH;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtMaHD;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraEditors.SpinEdit txtSL;
        private System.Windows.Forms.ComboBox txtMaMHCT;
        private DevExpress.XtraEditors.TextEdit txtMaHDCT;
        private System.Windows.Forms.Button btnHuyCT;
        private System.Windows.Forms.Button btnOKCT;
        private DSKH dSKH;
        private System.Windows.Forms.BindingSource v_LAYMAKHBindingSource;
        private DSKHTableAdapters.V_LAYMAKHTableAdapter v_LAYMAKHTableAdapter;
        private DSKHTableAdapters.TableAdapterManager tableAdapterManager1;
        private DSMK dSMK;
        private System.Windows.Forms.BindingSource sP_LAYMAKHOBindingSource;
        private DSMKTableAdapters.SP_LAYMAKHOTableAdapter sP_LAYMAKHOTableAdapter;
        private DSMKTableAdapters.TableAdapterManager tableAdapterManager2;
        private DSMVT dSMVT;
        private System.Windows.Forms.BindingSource v_LAYMAVTBindingSource;
        private DSMVTTableAdapters.V_LAYMAVTTableAdapter v_LAYMAVTTableAdapter;
        private DSMVTTableAdapters.TableAdapterManager tableAdapterManager3;
        private DevExpress.XtraBars.BarButtonItem btnXoaCTHD;
        private DevExpress.XtraEditors.SpinEdit txtDG;
    }
}