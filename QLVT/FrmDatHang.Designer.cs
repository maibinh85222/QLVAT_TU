namespace QLVT
{
    partial class FrmDatHang
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
            System.Windows.Forms.Label maDDHLabel;
            System.Windows.Forms.Label ngayLabel;
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label maDDHLabel1;
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label donGiaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemCTDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCTDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
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
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVTDSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.QLVTDSTableAdapters.TableAdapterManager();
            this.cTDatHangTableAdapter = new QLVT.QLVTDSTableAdapters.CTDatHangTableAdapter();
            this.datHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDatHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxDH = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNCC = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaDDH = new DevExpress.XtraEditors.TextEdit();
            this.groupBoxCTDH = new System.Windows.Forms.GroupBox();
            this.btnHuyCT = new System.Windows.Forms.Button();
            this.btnOkCT = new System.Windows.Forms.Button();
            this.txtDGDH = new DevExpress.XtraEditors.SpinEdit();
            this.txtSLDH = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaCTMH = new System.Windows.Forms.ComboBox();
            this.v_LAYMAVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMVT = new QLVT.DSMVT();
            this.txtMaCTDDH = new DevExpress.XtraEditors.TextEdit();
            this.v_LAYMAVTTableAdapter = new QLVT.DSMVTTableAdapters.V_LAYMAVTTableAdapter();
            this.tableAdapterManager1 = new QLVT.DSMVTTableAdapters.TableAdapterManager();
            this.nhaCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCCTableAdapter = new QLVT.QLVTDSTableAdapters.NhaCCTableAdapter();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.QLVTDSTableAdapters.PhieuNhapTableAdapter();
            maDDHLabel = new System.Windows.Forms.Label();
            ngayLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            maDDHLabel1 = new System.Windows.Forms.Label();
            maMHLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDatHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBoxDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).BeginInit();
            this.groupBoxCTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYMAVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCTDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maDDHLabel
            // 
            maDDHLabel.AutoSize = true;
            maDDHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maDDHLabel.Location = new System.Drawing.Point(31, 51);
            maDDHLabel.Name = "maDDHLabel";
            maDDHLabel.Size = new System.Drawing.Size(70, 19);
            maDDHLabel.TabIndex = 0;
            maDDHLabel.Text = "Ma DDH:";
            // 
            // ngayLabel
            // 
            ngayLabel.AutoSize = true;
            ngayLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayLabel.Location = new System.Drawing.Point(56, 89);
            ngayLabel.Name = "ngayLabel";
            ngayLabel.Size = new System.Drawing.Size(45, 19);
            ngayLabel.TabIndex = 2;
            ngayLabel.Text = "Ngay:";
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNCCLabel.Location = new System.Drawing.Point(30, 132);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(71, 19);
            maNCCLabel.TabIndex = 4;
            maNCCLabel.Text = "Ma NCC:";
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maNVLabel.Location = new System.Drawing.Point(42, 173);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(59, 19);
            maNVLabel.TabIndex = 6;
            maNVLabel.Text = "Ma NV:";
            // 
            // maDDHLabel1
            // 
            maDDHLabel1.AutoSize = true;
            maDDHLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maDDHLabel1.Location = new System.Drawing.Point(42, 51);
            maDDHLabel1.Name = "maDDHLabel1";
            maDDHLabel1.Size = new System.Drawing.Size(70, 19);
            maDDHLabel1.TabIndex = 0;
            maDDHLabel1.Text = "Ma DDH:";
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMHLabel.Location = new System.Drawing.Point(50, 92);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(62, 19);
            maMHLabel.TabIndex = 2;
            maMHLabel.Text = "Ma MH:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongLabel.Location = new System.Drawing.Point(41, 135);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(71, 19);
            soLuongLabel.TabIndex = 4;
            soLuongLabel.Text = "So Luong:";
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            donGiaLabel.Location = new System.Drawing.Point(49, 173);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(63, 19);
            donGiaLabel.TabIndex = 6;
            donGiaLabel.Text = "Don Gia:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnThemCTDDH,
            this.btnXoaCTDDH,
            this.btnRefresh,
            this.btnUndo,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCTDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaCTDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::QLVT.Properties.Resources.Actions_list_add_user_icon_24;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = global::QLVT.Properties.Resources.Delete_2_icon_24;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnThemCTDDH
            // 
            this.btnThemCTDDH.Caption = "Thêm CTDDH";
            this.btnThemCTDDH.Id = 2;
            this.btnThemCTDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCTDDH.ImageOptions.Image")));
            this.btnThemCTDDH.Name = "btnThemCTDDH";
            this.btnThemCTDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCTDDH_ItemClick);
            // 
            // btnXoaCTDDH
            // 
            this.btnXoaCTDDH.Caption = "Xoá CTDDH";
            this.btnXoaCTDDH.Id = 3;
            this.btnXoaCTDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCTDDH.ImageOptions.Image")));
            this.btnXoaCTDDH.Name = "btnXoaCTDDH";
            this.btnXoaCTDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaCTDDH_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = global::QLVT.Properties.Resources.Button_Refresh_icon_24;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.Image = global::QLVT.Properties.Resources.Undo_icon_24;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1347, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 853);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1347, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 813);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1347, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 813);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChinhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 94);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi nhánh:";
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(414, 31);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(321, 27);
            this.cmbChinhanh.TabIndex = 2;
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // qLVTDS
            // 
            this.qLVTDS.DataSetName = "QLVTDS";
            this.qLVTDS.EnforceConstraints = false;
            this.qLVTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.qLVTDS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDatHangTableAdapter = this.cTDatHangTableAdapter;
            this.tableAdapterManager.CTHoaDonTableAdapter = null;
            this.tableAdapterManager.CTPhieuNhapTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = null;
            this.tableAdapterManager.NhaCCTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTDatHangTableAdapter
            // 
            this.cTDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // datHangGridControl
            // 
            this.datHangGridControl.DataSource = this.datHangBindingSource;
            this.datHangGridControl.Location = new System.Drawing.Point(0, 140);
            this.datHangGridControl.MainView = this.gridView1;
            this.datHangGridControl.MenuManager = this.barManager1;
            this.datHangGridControl.Name = "datHangGridControl";
            this.datHangGridControl.Size = new System.Drawing.Size(677, 220);
            this.datHangGridControl.TabIndex = 6;
            this.datHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDDH,
            this.colNgay,
            this.colMaNCC,
            this.colMaNV});
            this.gridView1.GridControl = this.datHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaDDH
            // 
            this.colMaDDH.FieldName = "MaDDH";
            this.colMaDDH.Name = "colMaDDH";
            this.colMaDDH.Visible = true;
            this.colMaDDH.VisibleIndex = 0;
            // 
            // colNgay
            // 
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            // 
            // colMaNCC
            // 
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 2;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 3;
            // 
            // cTDatHangBindingSource
            // 
            this.cTDatHangBindingSource.DataMember = "FK_CTDatHang_DatHang";
            this.cTDatHangBindingSource.DataSource = this.datHangBindingSource;
            // 
            // cTDatHangGridControl
            // 
            this.cTDatHangGridControl.DataSource = this.cTDatHangBindingSource;
            this.cTDatHangGridControl.Location = new System.Drawing.Point(683, 140);
            this.cTDatHangGridControl.MainView = this.gridView2;
            this.cTDatHangGridControl.MenuManager = this.barManager1;
            this.cTDatHangGridControl.Name = "cTDatHangGridControl";
            this.cTDatHangGridControl.Size = new System.Drawing.Size(641, 220);
            this.cTDatHangGridControl.TabIndex = 7;
            this.cTDatHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDDH1,
            this.colMaMH,
            this.colSoLuong,
            this.colDonGia});
            this.gridView2.GridControl = this.cTDatHangGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMaDDH1
            // 
            this.colMaDDH1.FieldName = "MaDDH";
            this.colMaDDH1.Name = "colMaDDH1";
            this.colMaDDH1.Visible = true;
            this.colMaDDH1.VisibleIndex = 0;
            // 
            // colMaMH
            // 
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 1;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            // 
            // colDonGia
            // 
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            // 
            // groupBoxDH
            // 
            this.groupBoxDH.Controls.Add(this.btnHuy);
            this.groupBoxDH.Controls.Add(this.btnOK);
            this.groupBoxDH.Controls.Add(maNVLabel);
            this.groupBoxDH.Controls.Add(this.txtMaNV);
            this.groupBoxDH.Controls.Add(maNCCLabel);
            this.groupBoxDH.Controls.Add(this.txtMaNCC);
            this.groupBoxDH.Controls.Add(ngayLabel);
            this.groupBoxDH.Controls.Add(this.txtNgay);
            this.groupBoxDH.Controls.Add(maDDHLabel);
            this.groupBoxDH.Controls.Add(this.txtMaDDH);
            this.groupBoxDH.Location = new System.Drawing.Point(-1, 366);
            this.groupBoxDH.Name = "groupBoxDH";
            this.groupBoxDH.Size = new System.Drawing.Size(472, 248);
            this.groupBoxDH.TabIndex = 8;
            this.groupBoxDH.TabStop = false;
            this.groupBoxDH.Text = "DDH";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(336, 135);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 43);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(336, 72);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 40);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MaNV", true));
            this.txtMaNV.Location = new System.Drawing.Point(107, 170);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(169, 26);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MaNCC", true));
            this.txtMaNCC.Location = new System.Drawing.Point(107, 129);
            this.txtMaNCC.MenuManager = this.barManager1;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Properties.Appearance.Options.UseFont = true;
            this.txtMaNCC.Size = new System.Drawing.Size(169, 26);
            this.txtMaNCC.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "Ngay", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(107, 86);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Properties.Appearance.Options.UseFont = true;
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(169, 26);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MaDDH", true));
            this.txtMaDDH.Location = new System.Drawing.Point(107, 48);
            this.txtMaDDH.MenuManager = this.barManager1;
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDDH.Properties.Appearance.Options.UseFont = true;
            this.txtMaDDH.Size = new System.Drawing.Size(169, 26);
            this.txtMaDDH.TabIndex = 1;
            // 
            // groupBoxCTDH
            // 
            this.groupBoxCTDH.Controls.Add(this.btnHuyCT);
            this.groupBoxCTDH.Controls.Add(this.btnOkCT);
            this.groupBoxCTDH.Controls.Add(donGiaLabel);
            this.groupBoxCTDH.Controls.Add(this.txtDGDH);
            this.groupBoxCTDH.Controls.Add(soLuongLabel);
            this.groupBoxCTDH.Controls.Add(this.txtSLDH);
            this.groupBoxCTDH.Controls.Add(maMHLabel);
            this.groupBoxCTDH.Controls.Add(this.txtMaCTMH);
            this.groupBoxCTDH.Controls.Add(maDDHLabel1);
            this.groupBoxCTDH.Controls.Add(this.txtMaCTDDH);
            this.groupBoxCTDH.Location = new System.Drawing.Point(477, 366);
            this.groupBoxCTDH.Name = "groupBoxCTDH";
            this.groupBoxCTDH.Size = new System.Drawing.Size(454, 248);
            this.groupBoxCTDH.TabIndex = 9;
            this.groupBoxCTDH.TabStop = false;
            this.groupBoxCTDH.Text = "CTDDH";
            this.groupBoxCTDH.Enter += new System.EventHandler(this.groupBoxCTDH_Enter);
            // 
            // btnHuyCT
            // 
            this.btnHuyCT.Location = new System.Drawing.Point(344, 132);
            this.btnHuyCT.Name = "btnHuyCT";
            this.btnHuyCT.Size = new System.Drawing.Size(82, 45);
            this.btnHuyCT.TabIndex = 12;
            this.btnHuyCT.Text = "Huỷ";
            this.btnHuyCT.UseVisualStyleBackColor = true;
            this.btnHuyCT.Click += new System.EventHandler(this.btnHuyCT_Click);
            // 
            // btnOkCT
            // 
            this.btnOkCT.Location = new System.Drawing.Point(344, 65);
            this.btnOkCT.Name = "btnOkCT";
            this.btnOkCT.Size = new System.Drawing.Size(82, 43);
            this.btnOkCT.TabIndex = 11;
            this.btnOkCT.Text = "OK";
            this.btnOkCT.UseVisualStyleBackColor = true;
            this.btnOkCT.Click += new System.EventHandler(this.btnOkCT_Click);
            // 
            // txtDGDH
            // 
            this.txtDGDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDatHangBindingSource, "DonGia", true));
            this.txtDGDH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDGDH.Location = new System.Drawing.Point(118, 170);
            this.txtDGDH.MenuManager = this.barManager1;
            this.txtDGDH.Name = "txtDGDH";
            this.txtDGDH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGDH.Properties.Appearance.Options.UseFont = true;
            this.txtDGDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDGDH.Size = new System.Drawing.Size(163, 26);
            this.txtDGDH.TabIndex = 7;
            // 
            // txtSLDH
            // 
            this.txtSLDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDatHangBindingSource, "SoLuong", true));
            this.txtSLDH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSLDH.Location = new System.Drawing.Point(118, 132);
            this.txtSLDH.MenuManager = this.barManager1;
            this.txtSLDH.Name = "txtSLDH";
            this.txtSLDH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLDH.Properties.Appearance.Options.UseFont = true;
            this.txtSLDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSLDH.Size = new System.Drawing.Size(163, 26);
            this.txtSLDH.TabIndex = 5;
            // 
            // txtMaCTMH
            // 
            this.txtMaCTMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDatHangBindingSource, "MaMH", true));
            this.txtMaCTMH.DataSource = this.v_LAYMAVTBindingSource;
            this.txtMaCTMH.DisplayMember = "MaMH";
            this.txtMaCTMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaCTMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCTMH.FormattingEnabled = true;
            this.txtMaCTMH.Location = new System.Drawing.Point(118, 89);
            this.txtMaCTMH.Name = "txtMaCTMH";
            this.txtMaCTMH.Size = new System.Drawing.Size(163, 27);
            this.txtMaCTMH.TabIndex = 3;
            this.txtMaCTMH.ValueMember = "MaMH";
            // 
            // v_LAYMAVTBindingSource
            // 
            this.v_LAYMAVTBindingSource.DataMember = "V_LAYMAVT";
            this.v_LAYMAVTBindingSource.DataSource = this.dSMVT;
            // 
            // dSMVT
            // 
            this.dSMVT.DataSetName = "DSMVT";
            this.dSMVT.EnforceConstraints = false;
            this.dSMVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaCTDDH
            // 
            this.txtMaCTDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDatHangBindingSource, "MaDDH", true));
            this.txtMaCTDDH.Location = new System.Drawing.Point(118, 48);
            this.txtMaCTDDH.MenuManager = this.barManager1;
            this.txtMaCTDDH.Name = "txtMaCTDDH";
            this.txtMaCTDDH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCTDDH.Properties.Appearance.Options.UseFont = true;
            this.txtMaCTDDH.Size = new System.Drawing.Size(163, 26);
            this.txtMaCTDDH.TabIndex = 1;
            // 
            // v_LAYMAVTTableAdapter
            // 
            this.v_LAYMAVTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.DSMVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhaCCBindingSource
            // 
            this.nhaCCBindingSource.DataMember = "NhaCC";
            this.nhaCCBindingSource.DataSource = this.qLVTDS;
            // 
            // nhaCCTableAdapter
            // 
            this.nhaCCTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.qLVTDS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 873);
            this.Controls.Add(this.groupBoxCTDH);
            this.Controls.Add(this.groupBoxDH);
            this.Controls.Add(this.cTDatHangGridControl);
            this.Controls.Add(this.datHangGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDatHang";
            this.Text = "FormDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDatHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBoxDH.ResumeLayout(false);
            this.groupBoxDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDDH.Properties)).EndInit();
            this.groupBoxCTDH.ResumeLayout(false);
            this.groupBoxCTDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYMAVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCTDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnThemCTDDH;
        private DevExpress.XtraBars.BarButtonItem btnXoaCTDDH;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private QLVTDS qLVTDS;
        private QLVTDSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLVTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl datHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVTDSTableAdapters.CTDatHangTableAdapter cTDatHangTableAdapter;
        private System.Windows.Forms.BindingSource cTDatHangBindingSource;
        private System.Windows.Forms.GroupBox groupBoxCTDH;
        private System.Windows.Forms.GroupBox groupBoxDH;
        private DevExpress.XtraGrid.GridControl cTDatHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtMaNCC;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtMaDDH;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraEditors.SpinEdit txtDGDH;
        private DevExpress.XtraEditors.SpinEdit txtSLDH;
        private System.Windows.Forms.ComboBox txtMaCTMH;
        private DevExpress.XtraEditors.TextEdit txtMaCTDDH;
        private System.Windows.Forms.Button btnHuyCT;
        private System.Windows.Forms.Button btnOkCT;
        private DSMVT dSMVT;
        private System.Windows.Forms.BindingSource v_LAYMAVTBindingSource;
        private DSMVTTableAdapters.V_LAYMAVTTableAdapter v_LAYMAVTTableAdapter;
        private DSMVTTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource nhaCCBindingSource;
        private QLVTDSTableAdapters.NhaCCTableAdapter nhaCCTableAdapter;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private QLVTDSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
    }
}