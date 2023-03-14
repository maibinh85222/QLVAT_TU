namespace QLVT
{
    partial class FrmPhieuNhap
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
            System.Windows.Forms.Label maPNLabel;
            System.Windows.Forms.Label ngayLabel;
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label maDDHLabel;
            System.Windows.Forms.Label maKhoLabel;
            System.Windows.Forms.Label maPNLabel1;
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label donGiaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuNhap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemCTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCTPN = new DevExpress.XtraBars.BarButtonItem();
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
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.QLVTDSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.QLVTDSTableAdapters.TableAdapterManager();
            this.cTPhieuNhapTableAdapter = new QLVT.QLVTDSTableAdapters.CTPhieuNhapTableAdapter();
            this.phieuNhapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPhieuNhapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMaKho = new System.Windows.Forms.ComboBox();
            this.sP_LAYMAKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMK = new QLVT.DSMK();
            this.txtMaDDH = new System.Windows.Forms.ComboBox();
            this.v_DSMADHCHUANHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDH = new QLVT.DSDH();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.groupBoxCT = new System.Windows.Forms.GroupBox();
            this.btnHuyCT = new System.Windows.Forms.Button();
            this.btnOKCT = new System.Windows.Forms.Button();
            this.txtDG = new DevExpress.XtraEditors.TextEdit();
            this.txtSL = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaCTMH = new System.Windows.Forms.ComboBox();
            this.v_LAYMAVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMVT = new QLVT.DSMVT();
            this.txtMaCTPN = new DevExpress.XtraEditors.TextEdit();
            this.sP_LAYMAKHOTableAdapter = new QLVT.DSMKTableAdapters.SP_LAYMAKHOTableAdapter();
            this.tableAdapterManager1 = new QLVT.DSMKTableAdapters.TableAdapterManager();
            this.v_DSMADHCHUANHAPTableAdapter = new QLVT.DSDHTableAdapters.V_DSMADHCHUANHAPTableAdapter();
            this.tableAdapterManager2 = new QLVT.DSDHTableAdapters.TableAdapterManager();
            this.v_LAYMAVTTableAdapter = new QLVT.DSMVTTableAdapters.V_LAYMAVTTableAdapter();
            this.tableAdapterManager3 = new QLVT.DSMVTTableAdapters.TableAdapterManager();
            maPNLabel = new System.Windows.Forms.Label();
            ngayLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            maDDHLabel = new System.Windows.Forms.Label();
            maKhoLabel = new System.Windows.Forms.Label();
            maPNLabel1 = new System.Windows.Forms.Label();
            maMHLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYMAKHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSMADHCHUANHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            this.groupBoxCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYMAVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCTPN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maPNLabel
            // 
            maPNLabel.AutoSize = true;
            maPNLabel.Location = new System.Drawing.Point(41, 38);
            maPNLabel.Name = "maPNLabel";
            maPNLabel.Size = new System.Drawing.Size(58, 19);
            maPNLabel.TabIndex = 0;
            maPNLabel.Text = "Ma PN:";
            // 
            // ngayLabel
            // 
            ngayLabel.AutoSize = true;
            ngayLabel.Location = new System.Drawing.Point(54, 84);
            ngayLabel.Name = "ngayLabel";
            ngayLabel.Size = new System.Drawing.Size(45, 19);
            ngayLabel.TabIndex = 2;
            ngayLabel.Text = "Ngay:";
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(40, 127);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(59, 19);
            maNVLabel.TabIndex = 4;
            maNVLabel.Text = "Ma NV:";
            // 
            // maDDHLabel
            // 
            maDDHLabel.AutoSize = true;
            maDDHLabel.Location = new System.Drawing.Point(29, 173);
            maDDHLabel.Name = "maDDHLabel";
            maDDHLabel.Size = new System.Drawing.Size(70, 19);
            maDDHLabel.TabIndex = 6;
            maDDHLabel.Text = "Ma DDH:";
            // 
            // maKhoLabel
            // 
            maKhoLabel.AutoSize = true;
            maKhoLabel.Location = new System.Drawing.Point(35, 221);
            maKhoLabel.Name = "maKhoLabel";
            maKhoLabel.Size = new System.Drawing.Size(64, 19);
            maKhoLabel.TabIndex = 8;
            maKhoLabel.Text = "Ma Kho:";
            // 
            // maPNLabel1
            // 
            maPNLabel1.AutoSize = true;
            maPNLabel1.Location = new System.Drawing.Point(31, 44);
            maPNLabel1.Name = "maPNLabel1";
            maPNLabel1.Size = new System.Drawing.Size(58, 19);
            maPNLabel1.TabIndex = 0;
            maPNLabel1.Text = "Ma PN:";
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(29, 98);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(62, 19);
            maMHLabel.TabIndex = 2;
            maMHLabel.Text = "Ma MH:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(20, 148);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(71, 19);
            soLuongLabel.TabIndex = 4;
            soLuongLabel.Text = "So Luong:";
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Location = new System.Drawing.Point(28, 197);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(63, 19);
            donGiaLabel.TabIndex = 6;
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
            this.btnThemPN,
            this.btnXoaPN,
            this.btnRefresh,
            this.btnThemCTPN,
            this.btnThoat,
            this.btnXoaCTPN});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaCTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemPN
            // 
            this.btnThemPN.Caption = "Thêm PN";
            this.btnThemPN.Id = 0;
            this.btnThemPN.ImageOptions.Image = global::QLVT.Properties.Resources.Actions_list_add_user_icon_24;
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemPN_ItemClick);
            // 
            // btnXoaPN
            // 
            this.btnXoaPN.Caption = "Xoá PN";
            this.btnXoaPN.Id = 1;
            this.btnXoaPN.ImageOptions.Image = global::QLVT.Properties.Resources.Delete_2_icon_24;
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaPN_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 2;
            this.btnRefresh.ImageOptions.Image = global::QLVT.Properties.Resources.Button_Refresh_icon_24;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThemCTPN
            // 
            this.btnThemCTPN.Caption = "Thêm CTPN";
            this.btnThemCTPN.Id = 3;
            this.btnThemCTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCTPN.ImageOptions.Image")));
            this.btnThemCTPN.Name = "btnThemCTPN";
            this.btnThemCTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCTPN_ItemClick);
            // 
            // btnXoaCTPN
            // 
            this.btnXoaCTPN.Caption = "Xoá CTPN";
            this.btnXoaCTPN.Id = 5;
            this.btnXoaCTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCTPN.ImageOptions.Image")));
            this.btnXoaCTPN.Name = "btnXoaCTPN";
            this.btnXoaCTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaCTPN_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1365, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 861);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1365, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 800);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1365, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 800);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChinhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 80);
            this.panel1.TabIndex = 5;
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
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.qLVTDS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDatHangTableAdapter = null;
            this.tableAdapterManager.CTHoaDonTableAdapter = null;
            this.tableAdapterManager.CTPhieuNhapTableAdapter = this.cTPhieuNhapTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = null;
            this.tableAdapterManager.NhaCCTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTPhieuNhapTableAdapter
            // 
            this.cTPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapGridControl
            // 
            this.phieuNhapGridControl.DataSource = this.phieuNhapBindingSource;
            this.phieuNhapGridControl.Location = new System.Drawing.Point(0, 155);
            this.phieuNhapGridControl.MainView = this.gridView1;
            this.phieuNhapGridControl.MenuManager = this.barManager1;
            this.phieuNhapGridControl.Name = "phieuNhapGridControl";
            this.phieuNhapGridControl.Size = new System.Drawing.Size(680, 194);
            this.phieuNhapGridControl.TabIndex = 6;
            this.phieuNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPN,
            this.colNgay,
            this.colMaNV,
            this.colMaDDH,
            this.colMaKho});
            this.gridView1.GridControl = this.phieuNhapGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaPN
            // 
            this.colMaPN.FieldName = "MaPN";
            this.colMaPN.Name = "colMaPN";
            this.colMaPN.OptionsColumn.AllowEdit = false;
            this.colMaPN.Visible = true;
            this.colMaPN.VisibleIndex = 0;
            // 
            // colNgay
            // 
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.OptionsColumn.AllowEdit = false;
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.OptionsColumn.AllowEdit = false;
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 2;
            // 
            // colMaDDH
            // 
            this.colMaDDH.FieldName = "MaDDH";
            this.colMaDDH.Name = "colMaDDH";
            this.colMaDDH.OptionsColumn.AllowEdit = false;
            this.colMaDDH.Visible = true;
            this.colMaDDH.VisibleIndex = 3;
            // 
            // colMaKho
            // 
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.AllowEdit = false;
            this.colMaKho.Visible = true;
            this.colMaKho.VisibleIndex = 4;
            // 
            // cTPhieuNhapBindingSource
            // 
            this.cTPhieuNhapBindingSource.DataMember = "FK_CTPhieuNhap_PhieuNhap";
            this.cTPhieuNhapBindingSource.DataSource = this.phieuNhapBindingSource;
            // 
            // cTPhieuNhapGridControl
            // 
            this.cTPhieuNhapGridControl.DataSource = this.cTPhieuNhapBindingSource;
            this.cTPhieuNhapGridControl.Location = new System.Drawing.Point(686, 155);
            this.cTPhieuNhapGridControl.MainView = this.gridView2;
            this.cTPhieuNhapGridControl.MenuManager = this.barManager1;
            this.cTPhieuNhapGridControl.Name = "cTPhieuNhapGridControl";
            this.cTPhieuNhapGridControl.Size = new System.Drawing.Size(679, 194);
            this.cTPhieuNhapGridControl.TabIndex = 6;
            this.cTPhieuNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPN1,
            this.colMaMH,
            this.colSoLuong,
            this.colDonGia});
            this.gridView2.GridControl = this.cTPhieuNhapGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMaPN1
            // 
            this.colMaPN1.FieldName = "MaPN";
            this.colMaPN1.Name = "colMaPN1";
            this.colMaPN1.OptionsColumn.AllowEdit = false;
            this.colMaPN1.Visible = true;
            this.colMaPN1.VisibleIndex = 0;
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
            this.groupBox.Controls.Add(maDDHLabel);
            this.groupBox.Controls.Add(this.txtMaDDH);
            this.groupBox.Controls.Add(maNVLabel);
            this.groupBox.Controls.Add(this.txtMaNV);
            this.groupBox.Controls.Add(ngayLabel);
            this.groupBox.Controls.Add(this.txtNgay);
            this.groupBox.Controls.Add(maPNLabel);
            this.groupBox.Controls.Add(this.txtMaPN);
            this.groupBox.Location = new System.Drawing.Point(12, 355);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(503, 274);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "PhieuNhap";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(340, 136);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 43);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(340, 73);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 40);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuNhapBindingSource, "MaKho", true));
            this.txtMaKho.DataSource = this.sP_LAYMAKHOBindingSource;
            this.txtMaKho.DisplayMember = "MaKho";
            this.txtMaKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaKho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKho.FormattingEnabled = true;
            this.txtMaKho.Location = new System.Drawing.Point(105, 218);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(179, 27);
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
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuNhapBindingSource, "MaDDH", true));
            this.txtMaDDH.DataSource = this.v_DSMADHCHUANHAPBindingSource;
            this.txtMaDDH.DisplayMember = "MaDDH";
            this.txtMaDDH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDDH.FormattingEnabled = true;
            this.txtMaDDH.Location = new System.Drawing.Point(105, 170);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(179, 27);
            this.txtMaDDH.TabIndex = 7;
            this.txtMaDDH.ValueMember = "MaDDH";
            // 
            // v_DSMADHCHUANHAPBindingSource
            // 
            this.v_DSMADHCHUANHAPBindingSource.DataMember = "V_DSMADHCHUANHAP";
            this.v_DSMADHCHUANHAPBindingSource.DataSource = this.dSDH;
            // 
            // dSDH
            // 
            this.dSDH.DataSetName = "DSDH";
            this.dSDH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MaNV", true));
            this.txtMaNV.Location = new System.Drawing.Point(105, 124);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(179, 26);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "Ngay", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(105, 81);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Properties.Appearance.Options.UseFont = true;
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(179, 26);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MaPN", true));
            this.txtMaPN.Location = new System.Drawing.Point(105, 35);
            this.txtMaPN.MenuManager = this.barManager1;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Properties.Appearance.Options.UseFont = true;
            this.txtMaPN.Size = new System.Drawing.Size(179, 26);
            this.txtMaPN.TabIndex = 1;
            // 
            // groupBoxCT
            // 
            this.groupBoxCT.Controls.Add(this.btnHuyCT);
            this.groupBoxCT.Controls.Add(this.btnOKCT);
            this.groupBoxCT.Controls.Add(donGiaLabel);
            this.groupBoxCT.Controls.Add(this.txtDG);
            this.groupBoxCT.Controls.Add(soLuongLabel);
            this.groupBoxCT.Controls.Add(this.txtSL);
            this.groupBoxCT.Controls.Add(maMHLabel);
            this.groupBoxCT.Controls.Add(this.txtMaCTMH);
            this.groupBoxCT.Controls.Add(maPNLabel1);
            this.groupBoxCT.Controls.Add(this.txtMaCTPN);
            this.groupBoxCT.Location = new System.Drawing.Point(521, 355);
            this.groupBoxCT.Name = "groupBoxCT";
            this.groupBoxCT.Size = new System.Drawing.Size(507, 275);
            this.groupBoxCT.TabIndex = 8;
            this.groupBoxCT.TabStop = false;
            this.groupBoxCT.Text = "CTPhieuNhap";
            // 
            // btnHuyCT
            // 
            this.btnHuyCT.Location = new System.Drawing.Point(354, 134);
            this.btnHuyCT.Name = "btnHuyCT";
            this.btnHuyCT.Size = new System.Drawing.Size(82, 45);
            this.btnHuyCT.TabIndex = 12;
            this.btnHuyCT.Text = "Huỷ";
            this.btnHuyCT.UseVisualStyleBackColor = true;
            this.btnHuyCT.Click += new System.EventHandler(this.btnHuyCT_Click);
            // 
            // btnOKCT
            // 
            this.btnOKCT.Location = new System.Drawing.Point(354, 73);
            this.btnOKCT.Name = "btnOKCT";
            this.btnOKCT.Size = new System.Drawing.Size(82, 38);
            this.btnOKCT.TabIndex = 11;
            this.btnOKCT.Text = "OK";
            this.btnOKCT.UseVisualStyleBackColor = true;
            this.btnOKCT.Click += new System.EventHandler(this.btnOKCT_Click);
            // 
            // txtDG
            // 
            this.txtDG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPhieuNhapBindingSource, "DonGia", true));
            this.txtDG.Location = new System.Drawing.Point(97, 194);
            this.txtDG.MenuManager = this.barManager1;
            this.txtDG.Name = "txtDG";
            this.txtDG.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDG.Properties.Appearance.Options.UseFont = true;
            this.txtDG.Size = new System.Drawing.Size(183, 26);
            this.txtDG.TabIndex = 7;
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPhieuNhapBindingSource, "SoLuong", true));
            this.txtSL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSL.Location = new System.Drawing.Point(97, 145);
            this.txtSL.MenuManager = this.barManager1;
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Properties.Appearance.Options.UseFont = true;
            this.txtSL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSL.Size = new System.Drawing.Size(183, 26);
            this.txtSL.TabIndex = 5;
            // 
            // txtMaCTMH
            // 
            this.txtMaCTMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTPhieuNhapBindingSource, "MaMH", true));
            this.txtMaCTMH.DataSource = this.v_LAYMAVTBindingSource;
            this.txtMaCTMH.DisplayMember = "MaMH";
            this.txtMaCTMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaCTMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCTMH.FormattingEnabled = true;
            this.txtMaCTMH.Location = new System.Drawing.Point(97, 95);
            this.txtMaCTMH.Name = "txtMaCTMH";
            this.txtMaCTMH.Size = new System.Drawing.Size(183, 27);
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
            this.dSMVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaCTPN
            // 
            this.txtMaCTPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPhieuNhapBindingSource, "MaPN", true));
            this.txtMaCTPN.Location = new System.Drawing.Point(97, 41);
            this.txtMaCTPN.MenuManager = this.barManager1;
            this.txtMaCTPN.Name = "txtMaCTPN";
            this.txtMaCTPN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCTPN.Properties.Appearance.Options.UseFont = true;
            this.txtMaCTPN.Size = new System.Drawing.Size(183, 26);
            this.txtMaCTPN.TabIndex = 1;
            this.txtMaCTPN.EditValueChanged += new System.EventHandler(this.txtMaCTPN_EditValueChanged);
            // 
            // sP_LAYMAKHOTableAdapter
            // 
            this.sP_LAYMAKHOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.DSMKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_DSMADHCHUANHAPTableAdapter
            // 
            this.v_DSMADHCHUANHAPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = QLVT.DSDHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // FrmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 881);
            this.Controls.Add(this.groupBoxCT);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.cTPhieuNhapGridControl);
            this.Controls.Add(this.phieuNhapGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPhieuNhap";
            this.Text = "FrmPhieuNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYMAKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSMADHCHUANHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            this.groupBoxCT.ResumeLayout(false);
            this.groupBoxCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_LAYMAVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCTPN.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private QLVTDS qLVTDS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private QLVTDSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLVTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl phieuNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVTDSTableAdapters.CTPhieuNhapTableAdapter cTPhieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource cTPhieuNhapBindingSource;
        private DevExpress.XtraGrid.GridControl cTPhieuNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.BarButtonItem btnThemPN;
        private DevExpress.XtraBars.BarButtonItem btnXoaPN;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThemCTPN;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKho;
        private System.Windows.Forms.GroupBox groupBoxCT;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox txtMaKho;
        private System.Windows.Forms.ComboBox txtMaDDH;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtMaPN;
        private DevExpress.XtraEditors.TextEdit txtDG;
        private DevExpress.XtraEditors.SpinEdit txtSL;
        private System.Windows.Forms.ComboBox txtMaCTMH;
        private DevExpress.XtraEditors.TextEdit txtMaCTPN;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHuyCT;
        private System.Windows.Forms.Button btnOKCT;
        private DSMK dSMK;
        private System.Windows.Forms.BindingSource sP_LAYMAKHOBindingSource;
        private DSMKTableAdapters.SP_LAYMAKHOTableAdapter sP_LAYMAKHOTableAdapter;
        private DSMKTableAdapters.TableAdapterManager tableAdapterManager1;
        private DSDH dSDH;
        private System.Windows.Forms.BindingSource v_DSMADHCHUANHAPBindingSource;
        private DSDHTableAdapters.V_DSMADHCHUANHAPTableAdapter v_DSMADHCHUANHAPTableAdapter;
        private DSDHTableAdapters.TableAdapterManager tableAdapterManager2;
        private DSMVT dSMVT;
        private System.Windows.Forms.BindingSource v_LAYMAVTBindingSource;
        private DSMVTTableAdapters.V_LAYMAVTTableAdapter v_LAYMAVTTableAdapter;
        private DSMVTTableAdapters.TableAdapterManager tableAdapterManager3;
        private DevExpress.XtraBars.BarButtonItem btnXoaCTPN;
    }
}