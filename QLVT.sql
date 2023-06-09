USE [QLVT]
GO
/****** Object:  User [HTKN]    Script Date: 02-Dec-19 9:32:15 AM ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [MSmerge_EC58618F67414E6DA8C5663C4B29FB76]    Script Date: 02-Dec-19 9:32:15 AM ******/
CREATE ROLE [MSmerge_EC58618F67414E6DA8C5663C4B29FB76]
GO
/****** Object:  DatabaseRole [MSmerge_FFC3A7F9F16A46C59725EFDC4B82FFC3]    Script Date: 02-Dec-19 9:32:15 AM ******/
CREATE ROLE [MSmerge_FFC3A7F9F16A46C59725EFDC4B82FFC3]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 02-Dec-19 9:32:15 AM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_EC58618F67414E6DA8C5663C4B29FB76]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_FFC3A7F9F16A46C59725EFDC4B82FFC3]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 02-Dec-19 9:32:16 AM ******/
CREATE SCHEMA [MSmerge_PAL_role]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MaCN] [nchar](10) NOT NULL,
	[ChiNhanh] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_BB004D91675D415890AD02C75721D67E]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTDatHang]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDatHang](
	[MaDDH] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F4D58600995647C19C81823FB0EA442A]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CTDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F76FD2B287EE4A8985E95A6FD280DBF6]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CTHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[MaPN] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_18276DD14A894180AE11AE27CAF56C57]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CTPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MaDDH] [nchar](10) NOT NULL,
	[Ngay] [date] NULL,
	[MaNCC] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_CF075E9A01BD4F9E92682C40E61C5F4F]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[Ngay] [date] NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[MaKho] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_A823AB3FA22B42C29342CBD6FAA2504A]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[Ho] [nvarchar](10) NULL,
	[Ten] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nchar](15) NULL,
	[MaCN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_78F76572AE7D4B70A500A29BB9BCBA0E]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kho]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [nchar](10) NOT NULL,
	[TenKho] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MaCN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_2ED72D6C902C4110BE127ACA67002CD9]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[MaLH] [nchar](10) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_D9C5966C28D1405DB60FD4F5340F4FA5]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaMH] [nchar](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[MaLH] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_C2FAF9F4AB474E488BF5E7B9DFD2CFF8]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_MatHang] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[MaNCC] [nchar](10) NOT NULL,
	[Ten] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nvarchar](15) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_2EE51DE0CF594A8597209CF211F83B40]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_NhaCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[Ho] [nvarchar](10) NOT NULL,
	[Ten] [nvarchar](10) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [nchar](15) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[MaCN] [nchar](10) NOT NULL,
	[TrangThaiXoa] [int] NULL,
	[Phai] [nvarchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_63C767B0A14A4274ABCDEA7977A2298E]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [nchar](10) NOT NULL,
	[Ngay] [date] NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[MaDDH] [nchar](10) NOT NULL,
	[MaKho] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_D8196C8CB8564871A85D231D98B41A78]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[SP_LAYMAKHO]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[SP_LAYMAKHO]
AS
	select MaKho from Kho 


GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT  TENCN=PUBS.description, TENSERVER= subscriber_server
   FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server




GO
/****** Object:  View [dbo].[V_DSMADHCHUANHAP]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[V_DSMADHCHUANHAP]
AS
select MaDDH from DatHang where DatHang.MaDDH not in(select MaDDH from PhieuNhap)


GO
/****** Object:  View [dbo].[V_LAYMAKH]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[V_LAYMAKH]
AS
select MaKH from KhachHang


GO
/****** Object:  View [dbo].[V_LAYMANHANVIENLG]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[V_LAYMANHANVIENLG] AS SELECT MaNV, Ho + ' ' + Ten AS HoTen FROM dbo.NhanVien AS NV WHERE TrangThaiXoa = 0 and (LTRIM(RTRIM(STR(MaNV, 10))) NOT IN (SELECT us.name FROM sys.syslogins AS lg INNER JOIN sys.sysusers AS us ON lg.sid = us.sid))



GO
/****** Object:  View [dbo].[V_LAYMAVT]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_LAYMAVT]
AS
select MaMH from MatHang

GO
/****** Object:  View [dbo].[V_NhanVien]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_NhanVien] AS SELECT MaNV, Ho, Ten, DiaChi, SDT, NgaySinh, MACN FROM dbo.NhanVien


GO
INSERT [dbo].[ChiNhanh] ([MaCN], [ChiNhanh], [DiaChi], [SDT], [rowguid]) VALUES (N'CN1       ', N'Chi nhánh 1 TP HCM', N'35 Trần Hưng Đạo P1 Q1', N'999111888', N'3c2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[ChiNhanh] ([MaCN], [ChiNhanh], [DiaChi], [SDT], [rowguid]) VALUES (N'CN2       ', N'Chi nhánh 2 TP Cần Thơ', N'27 Nguyễn Huệ', N'333222111', N'3d2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH01    ', N'MH02      ', 12, 750, N'52bf3391-7212-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH01    ', N'MH05      ', 10, 1000, N'668efa9c-7e07-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH02    ', N'MH01      ', 20, 500, N'7a2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH03    ', N'MH01      ', 10, 600, N'ee39101c-6507-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH03    ', N'MH03      ', 10, 650, N'7b2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH04    ', N'MH03      ', 9, 1200, N'9f02eca3-c00d-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH09    ', N'MH04      ', 10, 800, N'48ddf0c1-ef08-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH10    ', N'MH08      ', 20, 800, N'717d73bc-d40e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH11    ', N'MH06      ', 13, 1000, N'ff64d8f4-d50e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH16    ', N'MH06      ', 10, 1200, N'14c31c1c-0613-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH17    ', N'MH03      ', 12, 1000, N'86f070b8-2f13-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[CTDatHang] ([MaDDH], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'MDDH17    ', N'MH04      ', 3, 690, N'bb306bc6-2f13-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD01      ', N'MH01      ', 10, 600, N'762a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD01      ', N'MH02      ', 15, 700, N'125f0ef9-0df7-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD02      ', N'MH01      ', 15, 500, N'772a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD02      ', N'MH02      ', 15, 550, N'782a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD05      ', N'MH03      ', 20, 2000, N'e84b4717-c00d-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD05      ', N'MH05      ', 16, 197, N'fd5e52c6-09fa-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD06      ', N'MH01      ', 10, 1000, N'92ce3413-0ef7-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD07      ', N'MH01      ', 13, 800, N'61d9af7a-2508-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD07      ', N'MH04      ', 12, 1230, N'd5175424-c00d-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD08      ', N'MH03      ', 12, 1000, N'3d095892-6e07-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD08      ', N'MH04      ', 10, 1200, N'1c4c31e2-5707-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD09      ', N'MH09      ', 20, 900, N'459d276d-d50e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[CTHoaDon] ([MaHD], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'HD10      ', N'MH02      ', 8, 1200, N'8593883f-d60e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN01      ', N'MH02      ', 12, N'750       ', N'75679c14-7012-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN01      ', N'MH05      ', 20, N'2100      ', N'2a974673-c40d-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN02      ', N'MH02      ', 15, N'500       ', N'742a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN03      ', N'MH01      ', 20, N'700       ', N'752a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN04      ', N'MH04      ', 12, N'800       ', N'f5c3ca31-bcf5-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN09      ', N'MH04      ', 9, N'600       ', N'b417dabe-6f12-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN09      ', N'MH05      ', 12, N'450       ', N'40266b12-6e12-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN10      ', N'MH06      ', 12, N'800       ', N'9948991a-d60e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN14      ', N'MH04      ', 2, N'1200      ', N'1a914a43-1608-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN14      ', N'MH07      ', 10, N'400       ', N'71db8a80-6f12-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN15      ', N'MH05      ', 12, N'1200      ', N'ae3a55a2-fe0d-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN16      ', N'MH08      ', 15, N'200       ', N'8099275f-6d12-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN16      ', N'MH09      ', 10, N'1000      ', N'1d2ab11f-d50e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[CTPhieuNhap] ([MaPN], [MaMH], [SoLuong], [DonGia], [rowguid]) VALUES (N'PN17      ', N'MH03      ', 12, N'1000      ', N'df4c2d0e-3013-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH01    ', CAST(N'2019-10-10' AS Date), N'MNCC01    ', N'1         ', N'6e2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH02    ', CAST(N'2019-10-10' AS Date), N'MNCC02    ', N'2         ', N'6f2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH03    ', CAST(N'2019-10-10' AS Date), N'MNCC02    ', N'1         ', N'702a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH04    ', CAST(N'2019-10-11' AS Date), N'MNCC03    ', N'4         ', N'712a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH05    ', CAST(N'2019-10-11' AS Date), N'MNCC01    ', N'5         ', N'722a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH06    ', CAST(N'2019-10-29' AS Date), N'MNCC01    ', N'4         ', N'16806f5b-06fa-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH07    ', CAST(N'2019-11-15' AS Date), N'MNCC02    ', N'4         ', N'd7376f28-5607-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH08    ', CAST(N'2019-11-16' AS Date), N'MNCC03    ', N'2         ', N'0d63450f-c407-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH09    ', CAST(N'2019-11-17' AS Date), N'MNCC02    ', N'4         ', N'e8d468af-ef08-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH10    ', CAST(N'2019-11-24' AS Date), N'MNCC03    ', N'10        ', N'9f470aac-d40e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH11    ', CAST(N'2019-11-24' AS Date), N'MNCC01    ', N'3         ', N'8f6024ea-d50e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH12    ', CAST(N'2019-11-30' AS Date), N'MNCC02    ', N'3         ', N'1d0893eb-0313-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH13    ', CAST(N'2019-11-30' AS Date), N'MNCC03    ', N'3         ', N'925ddd88-0413-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH14    ', CAST(N'2019-11-30' AS Date), N'MNCC01    ', N'3         ', N'6355a227-0513-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH15    ', CAST(N'2019-11-30' AS Date), N'MNCC01    ', N'4         ', N'f90fa897-0513-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH16    ', CAST(N'2019-11-30' AS Date), N'MNCC02    ', N'10        ', N'227e9201-0613-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[DatHang] ([MaDDH], [Ngay], [MaNCC], [MaNV], [rowguid]) VALUES (N'MDDH17    ', CAST(N'2019-11-30' AS Date), N'MNCC02    ', N'10        ', N'42c2a7a3-2f13-ea11-9403-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD01      ', CAST(N'2019-10-10' AS Date), N'KH01      ', N'1         ', N'K1N1      ', N'682a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD02      ', CAST(N'2019-10-10' AS Date), N'KH02      ', N'2         ', N'K1N2      ', N'692a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD03      ', CAST(N'2019-10-10' AS Date), N'KH05      ', N'4         ', N'K1N1      ', N'6a2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD04      ', CAST(N'2019-10-11' AS Date), N'KH01      ', N'5         ', N'K2N2      ', N'6b2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD05      ', CAST(N'2019-10-11' AS Date), N'KH06      ', N'1         ', N'K3N1      ', N'6c2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD06      ', CAST(N'2019-10-11' AS Date), N'KH08      ', N'6         ', N'K3N2      ', N'6d2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD07      ', CAST(N'2019-10-29' AS Date), N'KH11      ', N'4         ', N'K4N2      ', N'60e59da5-00fa-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD08      ', CAST(N'2019-10-29' AS Date), N'KH09      ', N'4         ', N'K2N1      ', N'04a5d5a1-09fa-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD09      ', CAST(N'2019-11-24' AS Date), N'KH01      ', N'10        ', N'K5N1      ', N'c343f55b-d50e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[HoaDon] ([MaHD], [Ngay], [MaKH], [MaNV], [MaKho], [rowguid]) VALUES (N'HD10      ', CAST(N'2019-11-24' AS Date), N'KH10      ', N'3         ', N'K3N3      ', N'4a46c934-d60e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH01      ', N'Nguyễn', N'Quang', N'Quận 5', N'0892336471     ', N'CN1       ', N'442a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH02      ', N'Lê', N'Tài', N'Thủ Đức', N'0287634832     ', N'CN2       ', N'452a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH03      ', N'Trần', N'Thư', N'Quận 1', N'0198632764     ', N'CN1       ', N'462a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH04      ', N'Nguyễn', N'An', N'Quận 9', N'0893271231     ', N'CN2       ', N'472a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH05      ', N'Phạm', N'Trinh', N'Bình Thạnh', N'0173928452     ', N'CN1       ', N'482a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH06      ', N'Huỳnh', N'Tấn', N'Phú Nhuận', N'0983945235     ', N'CN2       ', N'492a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH07      ', N'Hoàng', N'Phi', N'Quận 3', N'0589871435     ', N'CN1       ', N'4a2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH08      ', N'Vương', N'Anh', N'Quận 2', N'0398325617     ', N'CN2       ', N'4b2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH09      ', N'Trần', N'Thi', N'Tân Bình', N'0992121652     ', N'CN1       ', N'4c2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH10      ', N'Trương', N'Phương', N'Tân Phú', N'0973875241     ', N'CN2       ', N'4d2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[KhachHang] ([MaKH], [Ho], [Ten], [DiaChi], [SDT], [MaCN], [rowguid]) VALUES (N'KH11      ', N'Trần', N'Não', N'Củ Chi', N'2452434255     ', N'CN1       ', N'd972fdc7-22f3-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi], [MaCN], [rowguid]) VALUES (N'K1N1      ', N'KHO AB', N'28-30 Ngô Quyền P1 Q5', N'CN1       ', N'4e2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi], [MaCN], [rowguid]) VALUES (N'K1N2      ', N'LONG PHU', N'127 Ngô Thì Nhậm', N'CN2       ', N'4f2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi], [MaCN], [rowguid]) VALUES (N'K2N1      ', N'KHO BF', N'78 Nguyen Trai, TPHCM', N'CN1       ', N'502a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi], [MaCN], [rowguid]) VALUES (N'K2N2      ', N'KHO VT', N'23,Hoàng Diệu 2', N'CN2       ', N'512a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi], [MaCN], [rowguid]) VALUES (N'K3N1      ', N'CONG NGHIEP', N'555 Trần Hưng đạo', N'CN1       ', N'522a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi], [MaCN], [rowguid]) VALUES (N'K3N2      ', N'XI NGHIEP', N'23 Trần Não P6 Q4', N'CN2       ', N'532a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi], [MaCN], [rowguid]) VALUES (N'K3N3      ', N'KHO XD', N'54 Vo Van Ngan', N'CN2       ', N'8a70eeee-dbf3-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi], [MaCN], [rowguid]) VALUES (N'K4N2      ', N'KHO CD', N'123 Nguyễn Trãi', N'CN1       ', N'f0ba6e7f-77f1-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[Kho] ([MaKho], [TenKho], [DiaChi], [MaCN], [rowguid]) VALUES (N'K5N1      ', N'Thăng Bình', N'Quận 9', N'CN1       ', N'22c4823f-990e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[LoaiHang] ([MaLH], [Ten], [rowguid]) VALUES (N'LH01      ', N'Samsung', N'3e2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[LoaiHang] ([MaLH], [Ten], [rowguid]) VALUES (N'LH02      ', N'LG', N'3f2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[LoaiHang] ([MaLH], [Ten], [rowguid]) VALUES (N'LH03      ', N'Panasonic', N'402a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[LoaiHang] ([MaLH], [Ten], [rowguid]) VALUES (N'LH04      ', N'Sony', N'736c8512-fc0d-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[LoaiHang] ([MaLH], [Ten], [rowguid]) VALUES (N'LH05      ', N'Sharp', N'd17ed72c-fc0d-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[MatHang] ([MaMH], [Ten], [DonViTinh], [MaLH], [rowguid]) VALUES (N'MH01      ', N'Ti vi Sam Sung', N'cái', N'LH01      ', N'542a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[MatHang] ([MaMH], [Ten], [DonViTinh], [MaLH], [rowguid]) VALUES (N'MH02      ', N'Máy lạnh LGC', N'cái', N'LH02      ', N'552a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[MatHang] ([MaMH], [Ten], [DonViTinh], [MaLH], [rowguid]) VALUES (N'MH03      ', N'Máy giặt Panasonic', N'cái', N'LH03      ', N'562a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[MatHang] ([MaMH], [Ten], [DonViTinh], [MaLH], [rowguid]) VALUES (N'MH04      ', N'Điện thoại LG', N'cái', N'LH02      ', N'572a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[MatHang] ([MaMH], [Ten], [DonViTinh], [MaLH], [rowguid]) VALUES (N'MH05      ', N'Quạt Panasonic', N'cái', N'LH03      ', N'582a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[MatHang] ([MaMH], [Ten], [DonViTinh], [MaLH], [rowguid]) VALUES (N'MH06      ', N'dien thoai samsung', N'cái', N'LH01      ', N'ed079e6f-26f3-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[MatHang] ([MaMH], [Ten], [DonViTinh], [MaLH], [rowguid]) VALUES (N'MH07      ', N'Ti vi', N'cái', N'LH02      ', N'b3922909-c6f3-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[MatHang] ([MaMH], [Ten], [DonViTinh], [MaLH], [rowguid]) VALUES (N'MH08      ', N'máy ảnh Sony', N'cái', N'LH04      ', N'6885df7d-d40e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[MatHang] ([MaMH], [Ten], [DonViTinh], [MaLH], [rowguid]) VALUES (N'MH09      ', N'máy lạnh Sharp', N'cái', N'LH05      ', N'6375308d-d40e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[NhaCC] ([MaNCC], [Ten], [DiaChi], [SDT], [rowguid]) VALUES (N'MNCC01    ', N'CTY Samsung', N'Thủ Đức', N'0982374234', N'412a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhaCC] ([MaNCC], [Ten], [DiaChi], [SDT], [rowguid]) VALUES (N'MNCC02    ', N'CTY LG', N'Quận 9', N'0937537341', N'422a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhaCC] ([MaNCC], [Ten], [DiaChi], [SDT], [rowguid]) VALUES (N'MNCC03    ', N'CTY Panasonic', N'Quận 3', N'0937526413', N'432a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'1         ', N'Lương', N'Trang', N'Thủ Đức', N'0981189181     ', CAST(N'2000-05-05 00:00:00.000' AS DateTime), N'CN1       ', 0, N'Nữ', N'592a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'10        ', N'Phạm', N'Nhi', N'Tân Bình', N'0987236419     ', CAST(N'1999-05-03 00:00:00.000' AS DateTime), N'CN1       ', 0, N'Nữ', N'5a2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'11        ', N'Trần', N'Quang', N'Quận 9', N'2353465254     ', CAST(N'2019-10-22 00:00:00.000' AS DateTime), N'CN1       ', 0, N'Nam', N'487649c8-d0f0-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'12        ', N'Phan', N'Le', N'Biên Hoà', N'0938423749     ', CAST(N'1999-11-11 00:00:00.000' AS DateTime), N'CN2       ', 0, N'Nữ', N'07f234e9-25f4-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'13        ', N'Phạm', N'Liên', N'76 Lý Thường Kiệt', N'3545768354     ', CAST(N'1996-10-23 00:00:00.000' AS DateTime), N'CN2       ', 0, N'Nữ', N'f61669bb-e0fa-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'14        ', N'Quang', N'Lê', N'45 Hà Huy Giáp', N'7656746354     ', CAST(N'2000-11-11 00:00:00.000' AS DateTime), N'CN1       ', 1, N'Nam', N'15a7c7fd-2bf4-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'15        ', N'Hoàng', N'Quỳnh', N'Quận 10', N'098765434      ', CAST(N'1995-02-08 00:00:00.000' AS DateTime), N'CN1       ', 0, N'Nam', N'199b52f1-2ef4-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'16        ', N'Hoàng', N'Kim', N'Quận 12', N'9834729374     ', CAST(N'1995-06-09 00:00:00.000' AS DateTime), N'CN2       ', 0, N'Nữ', N'10dff2a3-2708-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'17        ', N'Kim', N'Tiên', N'Thủ Đức', N'2736126387     ', CAST(N'1990-06-15 00:00:00.000' AS DateTime), N'CN1       ', 0, N'Nữ', N'b0ea935b-bc0d-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'2         ', N'Vương ', N'Nhơn', N'Đồng Nai', N'0981428298     ', CAST(N'1997-02-08 00:00:00.000' AS DateTime), N'CN2       ', 0, N'Nam', N'5b2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'3         ', N'Trần', N'Trúc', N'Quận 9', N'0987654321     ', CAST(N'1995-09-07 00:00:00.000' AS DateTime), N'CN2       ', 0, N'Nữ', N'5c2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'4         ', N'Lê', N'Hoàng', N'Quận 1', N'1234567890     ', CAST(N'2001-11-05 00:00:00.000' AS DateTime), N'CN1       ', 0, N'Nam', N'5d2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'5         ', N'Hồ', N'Thái', N'Bình Thạnh', N'4891212748     ', CAST(N'2001-02-05 00:00:00.000' AS DateTime), N'CN2       ', 0, N'Nam', N'5e2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'6         ', N'Hà', N'An', N'Gò Vấp', N'8576324139     ', CAST(N'1996-04-06 00:00:00.000' AS DateTime), N'CN1       ', 0, N'Nữ', N'5f2a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'7         ', N'Lê', N'Trà', N'Phú Nhuận', N'0493873139     ', CAST(N'1996-03-07 00:00:00.000' AS DateTime), N'CN2       ', 0, N'Nam', N'602a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [DiaChi], [SDT], [NgaySinh], [MaCN], [TrangThaiXoa], [Phai], [rowguid]) VALUES (N'9         ', N'Nguyễn ', N'Nam', N'Quận 3', N'0498734246     ', CAST(N'2000-02-05 00:00:00.000' AS DateTime), N'CN2       ', 1, N'Nam', N'622a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN01      ', CAST(N'2019-10-10' AS Date), N'1         ', N'MDDH01    ', N'K1N1      ', N'632a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN02      ', CAST(N'2019-10-10' AS Date), N'3         ', N'MDDH02    ', N'K2N1      ', N'642a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN03      ', CAST(N'2019-10-10' AS Date), N'1         ', N'MDDH03    ', N'K1N1      ', N'652a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN04      ', CAST(N'2019-10-11' AS Date), N'4         ', N'MDDH04    ', N'K2N2      ', N'662a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN05      ', CAST(N'2019-10-11' AS Date), N'1         ', N'MDDH05    ', N'K3N1      ', N'672a4695-c7ed-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN09      ', CAST(N'2019-10-29' AS Date), N'4         ', N'MDDH06    ', N'K3N1      ', N'dfd53249-06fa-e911-93fe-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN10      ', CAST(N'2019-11-24' AS Date), N'3         ', N'MDDH11    ', N'K3N3      ', N'9b22060f-d60e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN14      ', CAST(N'2019-11-15' AS Date), N'4         ', N'MDDH07    ', N'K4N2      ', N'870956dd-5207-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN15      ', CAST(N'2019-11-23' AS Date), N'10        ', N'MDDH09    ', N'K3N1      ', N'58fc74d9-fd0d-ea11-9400-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN16      ', CAST(N'2019-11-24' AS Date), N'10        ', N'MDDH10    ', N'K5N1      ', N'e1d20413-d50e-ea11-9401-b8763fc7b1d8')
INSERT [dbo].[PhieuNhap] ([MaPN], [Ngay], [MaNV], [MaDDH], [MaKho], [rowguid]) VALUES (N'PN17      ', CAST(N'2019-11-30' AS Date), N'10        ', N'MDDH17    ', N'K2N1      ', N'71841803-3013-ea11-9403-b8763fc7b1d8')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_PhieuNhap]    Script Date: 02-Dec-19 9:32:16 AM ******/
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [UK_PhieuNhap] UNIQUE NONCLUSTERED 
(
	[MaDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTDatHang]  WITH CHECK ADD  CONSTRAINT [FK_CTDatHang_DatHang] FOREIGN KEY([MaDDH])
REFERENCES [dbo].[DatHang] ([MaDDH])
GO
ALTER TABLE [dbo].[CTDatHang] CHECK CONSTRAINT [FK_CTDatHang_DatHang]
GO
ALTER TABLE [dbo].[CTDatHang]  WITH CHECK ADD  CONSTRAINT [FK_CTDatHang_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[CTDatHang] CHECK CONSTRAINT [FK_CTDatHang_MatHang]
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_MatHang]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_MatHang]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhaCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCC] ([MaNCC])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhaCC]
GO
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Kho]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_ChiNhanh] FOREIGN KEY([MaCN])
REFERENCES [dbo].[ChiNhanh] ([MaCN])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_ChiNhanh]
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_ChiNhanh] FOREIGN KEY([MaCN])
REFERENCES [dbo].[ChiNhanh] ([MaCN])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_ChiNhanh]
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_LoaiHang] FOREIGN KEY([MaLH])
REFERENCES [dbo].[LoaiHang] ([MaLH])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_LoaiHang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MaCN])
REFERENCES [dbo].[ChiNhanh] ([MaCN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuNhap_DatHang] FOREIGN KEY([MaDDH])
REFERENCES [dbo].[DatHang] ([MaDDH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_DatHang]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_Kho1] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_Kho1]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[sp_BangKeCTSLNhap]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_BangKeCTSLNhap]
@FromDate date,
@ToDate date
as
begin
select  pn.Ngay,pn.MaPN,nv.Ho+nv.Ten as NameNV,mh.Ten,ctpn.SoLuong,ctpn.DonGia,ctpn.DonGia*ctpn.SoLuong as TotalMoney 
from MatHang mh
inner join CTPhieuNhap ctpn on mh.MaMH = ctpn.MaMH
inner join PhieuNhap pn on ctpn.MaPN = pn.MaPN
inner join NhanVien nv on pn.MaNV = nv.MaNV
where Ngay>=@FromDate and Ngay <= @ToDate
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BangKeCTSLXuat]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_BangKeCTSLXuat]
@FromDate date,
@ToDate date
as
begin
select  hd.Ngay,hd.MaHD,nv.Ho+nv.Ten as NameNV,mh.Ten,cthd.SoLuong,cthd.DonGia,cthd.DonGia*cthd.SoLuong as TotalMoney 
from MatHang mh
inner join CTHoaDon cthd on mh.MaMH = cthd.MaMH
inner join HoaDon hd on cthd.MaHD = hd.MaHD
inner join NhanVien nv on hd.MaNV = nv.MaNV
where Ngay>=@FromDate and Ngay <= @ToDate
end

GO
/****** Object:  StoredProcedure [dbo].[SP_CHUYENCHINHANH]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHUYENCHINHANH]
@MANV char(10), @HO nvarchar(10), @TEN nvarchar(10), @DIACHI nvarchar(100), @SDT nchar(15),
@NGAYSINH datetime, @MACN nchar(10), @TrangThaiXoa int, @PHAI nvarchar(10)
AS
BEGIN
	insert into NhanVien (MANV,HO,TEN,DIACHI,SDT,NgaySinh,MACN,TrangThaiXoa,Phai)
values(@MANV,@HO,@TEN,@DIACHI,@SDT,@NGAYSINH,@MACN,@TrangThaiXoa,@PHAI) 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DANGNHAP]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DANGNHAP]
	@TENLOGIN  NVARCHAR(10)
AS
DECLARE @TENUSER NCHAR(10)
SELECT @TENUSER= NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
SELECT	USERNAME = @TENUSER,
		HOTEN =(SELECT Ho + ' ' + Ten FROM NhanVien WHERE MaNV = @TENUSER),
		TENNHOM = NAME FROM sys.sysusers WHERE UID = (SELECT GROUPUID FROM sys.sysmembers
														WHERE MEMBERUID = (SELECT UID FROM sys.sysusers
														WHERE NAME = @TENUSER))
GO
/****** Object:  StoredProcedure [dbo].[SP_DSNV]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DSNV]
AS
SELECT MANV, HO + '  ' + TEN AS HOTEN, DIACHI, SDT, NGAYSINH, MACN, Phai
FROM dbo.NhanVien WHERE TrangThaiXoa = 0 ORDER BY TEN, HO

GO
/****** Object:  StoredProcedure [dbo].[SP_DSVT]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DSVT]
AS
SELECT MaMH, Ten, DonViTinh, MaLH
FROM dbo.MatHang  ORDER BY Ten

GO
/****** Object:  StoredProcedure [dbo].[SP_INBANGKECHITIET]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INBANGKECHITIET]
@MANV nchar(10),
@LOAI varchar(50),
@bd datetime,
@kt datetime,
@role nchar(100) 
AS
BEGIN

DECLARE @T TABLE
(
  MAPN nchar(10),
THANGNAM varchar(50)
)
DECLARE @TAM TABLE 
(
	THANGNAM varchar(50),
	TENVT varchar(200),
	TONGSOLUONG int, 
	TONGTRIGIA float
)
DECLARE @TAM1 TABLE 
(
	THANGNAM varchar(50),
	TENVT varchar(200),
	TONGSOLUONG int, 
	TONGTRIGIA float
)

IF(@role = 'CONGTY')
BEGIN 
IF(@LOAI='NHAP')
BEGIN
	INSERT INTO @T(MAPN, THANGNAM) 
	select MAPN,CONCAT(MONTH(NGAY),'-',YEAR(NGAY))as THANGNAM
	from PhieuNhap
	WHERE MONTH(NGAY) BETWEEN MONTH(@bd) and MONTH(@kt) and  YEAR(NGAY) BETWEEN YEAR(@bd) and YEAR(@kt) 
	INSERT INTO @TAM1(THANGNAM,TENVT,TONGSOLUONG,TONGTRIGIA)
	select  TM.THANGNAM,VT.Ten,SUM(CT.SOLUONG),SUM(CT.SOLUONG*CT.DONGIA) 
	from (select MaMH,Ten from MatHang) as VT,@T as TM,(select * from CTPhieuNhap WHERE CTPhieuNhap.MAPN IN (select MAPN from @T)) as CT
	WHERE TM.MAPN = CT.MAPN and VT.MaMH = CT.MaMH GROUP BY VT.Ten, TM.THANGNAM
	INSERT INTO @T(MAPN, THANGNAM) 
	select MAPN,CONCAT(MONTH(NGAY),'-',YEAR(NGAY))as THANGNAM
	from LINK.QLVT.DBO.PhieuNhap
	WHERE MONTH(NGAY) BETWEEN MONTH(@bd) and MONTH(@kt) and  YEAR(NGAY) BETWEEN YEAR(@bd) and YEAR(@kt) 
	INSERT INTO @TAM1(THANGNAM,TENVT,TONGSOLUONG,TONGTRIGIA)
	select  TM.THANGNAM,VT.Ten,SUM(CT.SOLUONG),SUM(CT.SOLUONG*CT.DONGIA) 
	from (select MaMH,Ten from MatHang) as VT,@T as TM,(select * from LINK.QLVT.DBO.CTPhieuNhap WHERE MAPN IN (select MAPN from @T)) as CT
	WHERE TM.MAPN = CT.MAPN and VT.MaMH = CT.MaMH GROUP BY VT.Ten, TM.THANGNAM
	INSERT INTO @TAM(THANGNAM,TENVT,TONGSOLUONG,TONGTRIGIA)
	select  THANGNAM,TENVT,SUM(TONGSOLUONG),SUM(TONGTRIGIA) 
	from @TAM1
	 GROUP BY TENVT, THANGNAM
END
ELSE IF(@LOAI='XUAT')
BEGIN
	INSERT INTO @T(MAPN, THANGNAM) 
	select MaHD,CONCAT(MONTH(NGAY),'-',YEAR(NGAY))as THANGNAM
	from HoaDon
	WHERE MONTH(NGAY) BETWEEN MONTH(@bd) and  MONTH(@kt) and  YEAR(NGAY) BETWEEN YEAR(@bd) and YEAR(@kt) 
	INSERT INTO @TAM1(THANGNAM,TENVT,TONGSOLUONG,TONGTRIGIA)
	select TM.THANGNAM,VT.Ten,SUM(CT.SOLUONG),SUM(CT.SOLUONG*CT.DONGIA) 
	from (select MaMH,Ten from MatHang) as VT,@T as TM,(select * from CTHoaDon WHERE CTHoaDon.MaHD IN (select MaHD from @T)) as CT
	WHERE TM.MAPN = CT.MaHD and VT.MaMH = CT.MaMH GROUP BY VT.Ten, TM.THANGNAM
	INSERT INTO @T(MAPN, THANGNAM) 
	select MaHD,CONCAT(MONTH(NGAY),'-',YEAR(NGAY))as THANGNAM
	from LINK.QLVT.DBO.HoaDon
	WHERE MONTH(NGAY) BETWEEN MONTH(@bd) and  MONTH(@kt) and  YEAR(NGAY) BETWEEN YEAR(@bd) and YEAR(@kt) 
	INSERT INTO @TAM1(THANGNAM,TENVT,TONGSOLUONG,TONGTRIGIA)
	select TM.THANGNAM,VT.Ten,SUM(CT.SOLUONG),SUM(CT.SOLUONG*CT.DONGIA) 
	from (select MaMH,Ten from MatHang) as VT,@T as TM,(select * from  LINK.QLVT.DBO.CTHoaDon WHERE MaHD IN (select MaHD from @T)) as CT
	WHERE TM.MAPN = CT.MaHD and VT.MaMH = CT.MaMH GROUP BY VT.Ten, TM.THANGNAM
	INSERT INTO @TAM(THANGNAM,TENVT,TONGSOLUONG,TONGTRIGIA)
	select  THANGNAM,TENVT,SUM(TONGSOLUONG),SUM(TONGTRIGIA) 
	from @TAM1
	 GROUP BY TENVT, THANGNAM
END

END
ELSE
BEGIN 
IF(@LOAI='NHAP')
BEGIN
	INSERT INTO @T(MAPN, THANGNAM) 
	select MAPN,CONCAT(MONTH(NGAY),'-',YEAR(NGAY))as THANGNAM
	from PhieuNhap
	WHERE MONTH(NGAY) BETWEEN MONTH(@bd) and MONTH(@kt) and  YEAR(NGAY) BETWEEN YEAR(@bd) and YEAR(@kt) and MANV = @MANV
	INSERT INTO @TAM(THANGNAM,TENVT,TONGSOLUONG,TONGTRIGIA)
	select  TM.THANGNAM,VT.Ten,SUM(CT.SOLUONG),SUM(CT.SOLUONG*CT.DONGIA) 
	from (select MaMH,Ten from MatHang) as VT,@T as TM,(select * from CTPhieuNhap WHERE CTPhieuNhap.MAPN IN (select MAPN from @T)) as CT
	WHERE TM.MAPN = CT.MAPN and VT.MaMH = CT.MaMH GROUP BY VT.Ten, TM.THANGNAM
	
END
ELSE IF(@LOAI='XUAT')
BEGIN
	INSERT INTO @T(MAPN, THANGNAM) 
	select MaHD,CONCAT(MONTH(NGAY),'-',YEAR(NGAY))as THANGNAM
	from HoaDon
	WHERE MONTH(NGAY) BETWEEN MONTH(@bd) and  MONTH(@kt) and  YEAR(NGAY) BETWEEN YEAR(@bd) and YEAR(@kt) and MANV = @MANV
	INSERT INTO @TAM(THANGNAM,TENVT,TONGSOLUONG,TONGTRIGIA)
	select TM.THANGNAM,VT.Ten,SUM(CT.SOLUONG),SUM(CT.SOLUONG*CT.DONGIA) 
	from (select MaMH,Ten from MatHang) as VT,@T as TM,(select * from CTHoaDon WHERE CTHoaDon.MaHD IN (select MaHD from @T)) as CT
	WHERE TM.MAPN = CT.MaHD and VT.MaMH = CT.MaMH GROUP BY VT.Ten, TM.THANGNAM

END
END
select * from @TAM
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaCTDDH]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaCTDDH]
@MADDH nchar(10)	, @MAVT nchar(10)
AS
BEGIN
	IF EXISTS(SELECT * FROM DBO.CTDatHang WHERE CTDatHang.MaDDH=@MADDH and CTDatHang.MaMH=@MAVT)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM LINK.QLVT.DBO.CTDatHang WHERE CTDatHang.MaDDH=@MADDH and CTDatHang.MaMH=@MAVT)
	BEGIN
		RETURN 1; 
	END

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaCTHD]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaCTHD]
@MAHD nchar(10)	, @MAMH nchar(10)
AS
BEGIN
	IF EXISTS(SELECT * FROM DBO.CTHoaDon WHERE CTHoaDon.MaHD=@MAHD and CTHoaDon.MaMH=@MAMH)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM LINK.QLVT.DBO.CTHoaDon WHERE CTHoaDon.MaHD=@MAHD and CTHoaDon.MaMH=@MAMH)
	BEGIN
		RETURN 1; 
	END

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaCTPN]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaCTPN]
@MaPN nchar(8)	, @MaMH nchar(8)
AS
BEGIN
	IF EXISTS(SELECT * FROM DBO.CTPhieuNhap WHERE CTPhieuNhap.MaPN=@MAPN and CTPhieuNhap.MaMH=@MaMH)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM LINK.QLVT.DBO.CTPhieuNhap WHERE CTPhieuNhap.MaPN=@MAPN and CTPhieuNhap.MaMH=@MaMH)
	BEGIN
		RETURN 1; 
	END

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaDatHang]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaDatHang]
@MADDH nchar(10)	
AS
BEGIN
	
	IF EXISTS(SELECT * FROM DBO.DatHang WHERE DBO.DatHang.MaDDH=@MADDH)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM LINK.QLVT.DBO.DatHang WHERE DatHang.MaDDH=@MADDH)
	BEGIN
		RETURN 1; 
	END

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaHoaDon]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaHoaDon]
@MAHD nchar(10)	
AS
BEGIN
	
	IF EXISTS(SELECT * FROM DBO.HoaDon WHERE DBO.HoaDon.MaHD=@MAHD)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM LINK.QLVT.DBO.HoaDon WHERE HoaDon.MaHD=@MAHD)
	BEGIN
		RETURN 1; 
	END

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaKhachHangTonTai]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaKhachHangTonTai]
@MaKH nchar(10)
AS
BEGIN
	--kiem tra trong table Kho cua server hien tai
	IF EXISTS (SELECT 1 FROM DBO.Kho WHERE DBO.Kho.MaKho = @MaKH)
	BEGIN 
		RETURN 1; --MaKho ton tai o server hien tai
	END

	--kiem tra trong table NhanVien cua phan manh con lai
	IF EXISTS (SELECT 1 FROM LINK.QLVT.DBO.Kho Kho WHERE Kho.MaKho = @MaKH )
	BEGIN
		RETURN 1;--MaKho ton tai o server con lai
	END
	RETURN 0;--MaKho chua ton tai
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaKho]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaKho]
@MaKho nchar(10)
AS
BEGIN
	--kiem tra trong table Kho cua server hien tai
	IF EXISTS (SELECT * FROM DBO.Kho WHERE DBO.Kho.MaKho = @MaKho)
	BEGIN 
		RETURN 1; --MaKho ton tai o server hien tai
	END

	--kiem tra trong table NhanVien cua phan manh con lai
	IF EXISTS (SELECT * FROM LINK.QLVT.DBO.Kho Kho WHERE Kho.MaKho = @MaKho )
	BEGIN
		RETURN 1;--MaKho ton tai o server con lai
	END
	RETURN 0;--MaKho chua ton tai
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaKhoTonTai]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaKhoTonTai]
@MaKho nchar(10)
AS
BEGIN
	--kiem tra trong table Kho cua server hien tai
	IF EXISTS (SELECT * FROM DBO.Kho WHERE DBO.Kho.MaKho = @MaKho)
	BEGIN 
		RETURN 1; --MaKho ton tai o server hien tai
	END

	--kiem tra trong table NhanVien cua phan manh con lai
	IF EXISTS (SELECT * FROM LINK.QLVT.DBO.Kho Kho WHERE Kho.MaKho = @MaKho )
	BEGIN
		RETURN 1;--MaKho ton tai o server con lai
	END
	RETURN 0;--MaKho chua ton tai
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaMH]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaMH]
@MAMH nchar(10)	
AS
BEGIN
	
	IF EXISTS(SELECT * FROM DBO.MatHang WHERE DBO.MatHang.MaMH=@MAMH)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM LINK.QLVT.DBO.MatHang WHERE MatHang.MaMH=@MAMH)
	BEGIN
		RETURN 1; 
	END

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaNhanVienTonTai]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaNhanVienTonTai]
@MaNV nchar(10)
AS
BEGIN
	--kiem tra trong table NhanVien cua server hien tai
	IF EXISTS (SELECT * FROM DBO.NhanVien WHERE DBO.NhanVien.MaNV = @MaNV)
	BEGIN 
		RETURN 1; --MaNV ton tai o server hien tai
	END

	--kiem tra trong table NhanVien cua phan manh con lai
	IF EXISTS (SELECT * FROM LINK.QLVT.DBO.NhanVien  WHERE NhanVien.MaNV = @MaNV )
	BEGIN
		RETURN 1;--MaNV ton tai o server con lai
	END
	RETURN 0;--MaNV chua ton tai
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaPhieuNhap]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraMaPhieuNhap]
@MaPN nchar(10)	
AS
BEGIN
	
	IF EXISTS(SELECT * FROM DBO.PhieuNhap WHERE DBO.PhieuNhap.MaPN=@MaPN)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM LINK.QLVT.DBO.PhieuNhap WHERE PhieuNhap.MaPN=@MaPN)
	BEGIN
		RETURN 1; 
	END

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraXoaChiTietDonDatHang]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraXoaChiTietDonDatHang]
@MADDH nchar(10),
@MAVT nchar(10)	
AS
BEGIN
	DECLARE @temp nchar(10);
	set @temp=(select MAPN
	from PhieuNhap
	where PhieuNhap.MaDDH=@MADDH)

	IF EXISTS(SELECT * FROM CTPhieuNhap WHERE (CTPhieuNhap.MaPN=@temp and CTPhieuNhap.MaMH=@MAVT))
	BEGIN
		RETURN 1; 
	END

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraXoaHoaDon]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraXoaHoaDon]
@MAHD nchar(10)
AS 
BEGIN 
IF EXISTS(SELECT * FROM DBO.CTHoaDon WHERE DBO.CTHoaDon.MaHD=@MAHD)
	BEGIN 
		RETURN 1; 
	END  
		RETURN 0; 
 END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraXoaMaDonDatHang]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraXoaMaDonDatHang]
@MADDH nchar(10)
AS 
BEGIN 
IF EXISTS(SELECT * FROM DBO.CTDatHang WHERE DBO.CTDatHang.MaDDH=@MADDH)
	BEGIN 
		RETURN 1; 
	END 
 IF EXISTS(SELECT * FROM DBO.PhieuNhap WHERE PhieuNhap.MaDDH=@MADDH) 
	BEGIN 
		RETURN 1;
	END 
		RETURN 0; 
 END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraXoaMaKho]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraXoaMaKho]
@MAKHO nchar(10)	
AS
BEGIN

	IF EXISTS(SELECT * FROM DBO.PhieuNhap WHERE DBO.PhieuNhap.MAKHO=@MAKHO)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM DBO.HoaDon WHERE DBO.HoaDon.MAKHO=@MAKHO)
	BEGIN
		RETURN 1; 
	END
	

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraXoaMaMH]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraXoaMaMH]
@MAMH nchar(10)	
AS
BEGIN
	
	IF EXISTS(SELECT * FROM DBO.CTDatHang WHERE DBO.CTDatHang.MaMH=@MAMH)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM DBO.CTPhieuNhap WHERE DBO.CTPhieuNhap.MaMH=@MAMH)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM DBO.CTHoaDon WHERE DBO.CTHoaDon.MaMH=@MAMH)
	BEGIN
		RETURN 1; 
	END
	

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraXoaMaNhanVien]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraXoaMaNhanVien]
@MANV nchar(8)	
AS
BEGIN
	
	IF EXISTS(SELECT * FROM DBO.DatHang WHERE DBO.DatHang.MaNV=@MANV)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM DBO.PhieuNhap WHERE DBO.PhieuNhap.MANV=@MANV)
	BEGIN
		RETURN 1; 
	END

	IF EXISTS(SELECT * FROM DBO.HoaDon WHERE DBO.HoaDon.MANV=@MANV)
	BEGIN
		RETURN 1; 
	END
	

	RETURN 0; 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraXoaPhieuNhap]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraXoaPhieuNhap]
@MaPN nchar(10)
AS 
BEGIN 
IF EXISTS(SELECT * FROM DBO.CTPhieuNhap WHERE DBO.CTPhieuNhap.MaPN=@MAPN)
	BEGIN 
		RETURN 1; 
	END  
		RETURN 0; 
 END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraXoaPhieuXuat]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KiemTraXoaPhieuXuat]
@MAHD nchar(10)
AS 
BEGIN 
IF EXISTS(SELECT * FROM DBO.CTHoaDon WHERE DBO.CTHoaDon.MaHD=@MAHD)
	BEGIN 
		RETURN 1; 
	END  
		RETURN 0; 
 END

GO
/****** Object:  StoredProcedure [dbo].[SP_LAYSOLUONGDONGIACTPN]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_LAYSOLUONGDONGIACTPN]
@MaMH nchar(10),
@MaDDH nchar(10)	
AS
BEGIN
	select SOLUONG, DONGIA
	from CTDatHang
	where MaMH=@MaMH and MaDDH=@MaDDH
END

GO
/****** Object:  StoredProcedure [dbo].[SP_MADHCHUACOPN]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MADHCHUACOPN]
as
begin
SELECT        MaDDH
FROM            dbo.DatHang
WHERE        MaDDH NOT IN
                             (SELECT        MaDDH
                               FROM            dbo.PhieuNhap)
end

GO
/****** Object:  StoredProcedure [dbo].[SP_MAVTDADH]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MAVTDADH]
@MaPN nchar(10),
@MaDDH nchar(10)
AS
BEGIN
	select MaMH
	from CTDatHang
	where CTDatHang.MaDDH=@MADDH and MaMH not in(
					select MaMH
					from CTPhieuNhap
					where CTPhieuNhap.MaPN=@MaPN)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_MaxMaNV]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaxMaNV] @temp int
	
AS
BEGIN
	DECLARE @MANV1 nchar(10),@MANV2 nchar(10)
	select @MANV1 = max(MANV) from NhanVien
	select @MANV2 = max(MANV) from LINK.QLVT.dbo.NhanVien
	if(@MANV1<@MANV2) return @MANV2
	else return @MANV1
END

GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TaoTaiKhoan]
	@LGNAME nvarchar(10),
	@PASS VARCHAR(50),
	@USERNAME nchar(10),
	@ROLE VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLVT'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  IF @ROLE= 'CONGTY' or @ROLE= 'CHINHANH'
	BEGIN
		--EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
		RETURN 0;
	END

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TONGHOPNHAPXUAT]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TONGHOPNHAPXUAT]
@nbd datetime, 
@nkt datetime
AS
BEGIN

PRINT @nbd
PRINT @nkt

DECLARE @T TABLE
(
 NGAY date,
TONGNHAP int
)
DECLARE @X TABLE
(
  NGAY date,
  TONGXUAT int
)
DECLARE @PN TABLE
(
	MAPN char(10),
	NGAY date
)
DECLARE @PX TABLE
(
	MAPX char(10),
	NGAY date
)
DECLARE @YU TABLE
(
  NGAY date,
  TONGXUAT int,
  TYLEXUAT float,
  TONGNHAP int,
  TYLENHAP float
) 
DECLARE @TSN int
DECLARE @TSX int
	DECLARE @I date =  DATEADD(day,-1,CONVERT(date,@nbd))
	DECLARE @k date = CONVERT(date,@nkt)
	INSERT INTO @PN(MAPN,NGAY) 
	select MAPN,NGAY 
	from PhieuNhap where  NGAY BETWEEN @nbd and @nkt 
	INSERT INTO @PX(MAPX,NGAY) 
	select MaHD,NGAY 
	from HoaDon where  NGAY BETWEEN @nbd and @nkt 
	WHILE @I != @k
	BEGIN
	SET	@I = DATEADD(day,1,@I)
PRINT @I
		if(@I not in(select NGAY from  @PN))
		BEGIN
		INSERT INTO @T(NGAY,TONGNHAP) VALUES(@I,0)
		END
	END
		INSERT INTO @T(NGAY, TONGNHAP) 
		select PN.NGAY,SUM(CT.SOLUONG*CT.DONGIA) as TONGNHAP
		from @PN as PN,(select * from CTPhieuNhap WHERE CTPhieuNhap.MAPN IN (select MAPN from @PN)) 
		as CT where PN.MAPN = CT.MAPN 
		
		group by PN.NGAY
		set @TSN = (select SUM(TONGNHAP) from @T)
		DECLARE @H date = DATEADD(day,-1,CONVERT(date,@nbd))
	DECLARE @M date = CONVERT(date,@nkt)
	WHILE @H != @M
	BEGIN
	SET	@H = DATEADD(day,1,@H)
		if(@H not in(select NGAY from  @PX))
		BEGIN
		INSERT INTO @X(NGAY,TONGXUAT) VALUES(@H,0)
		END
	END
	INSERT INTO @X(NGAY, TONGXUAT) 
	select PX.NGAY,SUM(CT.SOLUONG*CT.DONGIA) as TONGXUAT
	from @PX as PX,(select * from CTHoaDon WHERE CTHoaDon.MaHD IN (select MAPX from @PX)) as CT 
	where PX.MAPX = CT.MaHD 
	group by PX.NGAY
	set @TSX = (select SUM(TONGXUAT) from @X)

INSERT INTO @YU(NGAY, TONGNHAP,TYLENHAP,TONGXUAT,TYLEXUAT) 
select TNN.NGAY,TNN.TONGNHAP, ROUND((CONVERT(float,TNN.TONGNHAP) / nullif(CONVERT(float,@TSN),0))*100,2),TXX.TONGXUAT,
ROUND((CONVERT(float,TXX.TONGXUAT) / nullif(CONVERT(float,@TSX),0))*100,2) from @T as TNN,@X as TXX where TNN.NGAY = TXX.NGAY 
select CONVERT(char(10),NGAY,103) as NGAY,TONGNHAP,CONCAT(TYLENHAP,'%') as TYLENHAP,TONGXUAT,CONCAT(TYLEXUAT,'%') as TYLEXUAT from
@YU where TONGNHAP!=0 or TONGXUAT!=0 ORDER BY NGAY 
END

GO
/****** Object:  StoredProcedure [dbo].[SP_XemCTDDHTheoMa]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XemCTDDHTheoMa]
@MasoDDH	nchar(10)	
as 
BEGIN 
	SET NOCOUNT ON
	select CT.MaDDH,VT.MAMH,VT.Ten as TENVT,CT.SoLuong,CT.DonGia
	 from CTDatHang as CT,
	(select MaMH,Ten from MatHang) as VT where CT.MaMH = VT.MaMH and CT.MaDDH = @MasoDDH
	
END


GO
/****** Object:  StoredProcedure [dbo].[SP_XemDSDDH]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XemDSDDH]
as 
BEGIN 
	SET NOCOUNT ON
	select DH.MaDDH, DH.Ngay, DH.MaNCC,NV.HO+NV.TEN as HOTEN
	from (select MaDDH, Ngay, MaNCC, MaNV from DatHang) as DH,(select MaNV,Ho,Ten from NhanVien) as NV
	where DH.MaNV = NV.MaNV
END



GO
/****** Object:  StoredProcedure [dbo].[Statitiscal_VoucherInfo]    Script Date: 02-Dec-19 9:32:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Statitiscal_VoucherInfo]
@FromDate date,
@ToDate date
as
begin
select  pn.Ngay,pn.MaPN,nv.Ho+nv.Ten as NameNV,mh.Ten,ctpn.SoLuong,ctpn.DonGia,ctpn.DonGia*ctpn.SoLuong as TotalMoney 
from MatHang mh
inner join CTPhieuNhap ctpn on mh.MaMH = ctpn.MaMH
inner join PhieuNhap pn on ctpn.MaPN = pn.MaPN
inner join NhanVien nv on pn.MaNV = nv.MaNV
where Ngay>=@FromDate and Ngay <= @ToDate
end
GO
