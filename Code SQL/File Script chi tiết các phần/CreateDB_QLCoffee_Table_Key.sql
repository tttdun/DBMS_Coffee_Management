USE [QuanLiCuaHangThucUong]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[ThoiGianBatDau] [real] NOT NULL,
	[ThoiGianKetThuc] [real] NOT NULL,
	[NgayLam] [date] NOT NULL,
 CONSTRAINT [PK_ChamCong_1] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC,
	[NgayLam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHDCC]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHDCC](
	[MaHDCC] [nchar](10) NOT NULL,
	[MaNguyenLieu] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NULL,
	[STT] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ChiTietHDCC] PRIMARY KEY CLUSTERED 
(
	[MaHDCC] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [nchar](10) NOT NULL,
	[MaThucUong] [nchar](10) NOT NULL,
	[TenThucUong] [nvarchar](100) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NULL,
	[STT] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaThucUong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nchar](10) NOT NULL,
	[TenHoaDon] [nvarchar](50) NOT NULL,
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[NgayGio] [date] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDongCungCap]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDongCungCap](
	[MaHDCC] [nchar](10) NOT NULL,
	[NoiDung] [nvarchar](100) NOT NULL,
	[NgayKiHD] [datetime] NOT NULL,
	[MaNhaCC] [nchar](10) NOT NULL,
 CONSTRAINT [PK_HopDongCungCap] PRIMARY KEY CLUSTERED 
(
	[MaHDCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNguyenLieu]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNguyenLieu](
	[MaLoaiNL] [nchar](10) NOT NULL,
	[TenLoaiNL] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiNguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[ChucVu] [nvarchar](50) NOT NULL,
	[LuongTheoGio] [int] NOT NULL,
	[ThuongTheoDot] [int] NOT NULL,
 CONSTRAINT [PK_Luong] PRIMARY KEY CLUSTERED 
(
	[ChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNguyenLieu] [nchar](10) NOT NULL,
	[TenNguyenLieu] [nvarchar](50) NOT NULL,
	[MaLoaiNL] [nchar](10) NOT NULL,
	[HanSuDung] [datetime] NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCC] [nchar](10) NOT NULL,
	[TenNhaCC] [nvarchar](100) NOT NULL,
	[DiaChiNhaCC] [nvarchar](100) NOT NULL,
	[ChuyenCungCap] [nvarchar](100) NOT NULL,
	[SoDienThoai] [nchar](12) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[HoVaTen] [nvarchar](200) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[Tuoi] [int] NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__NhanVien__77B2CA474E38068A] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomThucUong]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomThucUong](
	[MaNhomThucUong] [nchar](10) NOT NULL,
	[TenNhomThucUong] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_NhomThucUong] PRIMARY KEY CLUSTERED 
(
	[MaNhomThucUong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhaChe]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhaChe](
	[MaNguyenLieu] [nchar](10) NOT NULL,
	[MaThucUong] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PhaChe] PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC,
	[MaThucUong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuChi]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuChi](
	[MaPhieuChi] [nchar](10) NOT NULL,
	[NgayXuatPhieu] [date] NOT NULL,
	[SoTienChi] [int] NULL,
	[NoiDungChi] [nvarchar](100) NULL,
	[MaHDCC] [nchar](10) NOT NULL,
	[STT] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_PhieuChi] PRIMARY KEY CLUSTERED 
(
	[MaPhieuChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC,
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThucUong]    Script Date: 6/2/2023 11:39:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucUong](
	[MaThucUong] [nchar](10) NOT NULL,
	[TenThucUong] [nvarchar](100) NOT NULL,
	[MaNhomThucUong] [nchar](10) NOT NULL,
	[GiaBan] [int] NOT NULL,
 CONSTRAINT [PK_ThucUong] PRIMARY KEY CLUSTERED 
(
	[MaThucUong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'001', 8, 14, CAST(N'2023-05-13' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'001', 9, 13, CAST(N'2023-05-14' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'002', 13, 17, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'002', 13, 20, CAST(N'2023-05-16' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'003', 12, 16, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'003', 15, 20, CAST(N'2023-05-16' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'004', 16, 21, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'004', 16, 22, CAST(N'2023-05-17' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'005', 17, 22, CAST(N'2023-05-15' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'005', 14, 18, CAST(N'2023-05-18' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'006', 15, 20, CAST(N'2023-05-17' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'007', 14, 20, CAST(N'2023-05-01' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'007', 16, 21, CAST(N'2023-05-18' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'008', 13, 18, CAST(N'2023-05-18' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'009', 16, 19, CAST(N'2023-05-01' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'009', 15, 22, CAST(N'2023-05-18' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'010', 15, 22, CAST(N'2023-05-18' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'011', 12, 16, CAST(N'2023-04-20' AS Date))
INSERT [dbo].[ChamCong] ([MaNhanVien], [ThoiGianBatDau], [ThoiGianKetThuc], [NgayLam]) VALUES (N'011', 13, 21, CAST(N'2023-04-30' AS Date))
GO
SET IDENTITY_INSERT [dbo].[ChiTietHDCC] ON 

INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD01      ', N'FLOUR02   ', 30, 330000, 21)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD02      ', N'CREAM01   ', 10, 300000, 22)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD02      ', N'CREAM02   ', 8, 280000, 23)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD02      ', N'SIRUP01   ', 5, 150000, 24)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD02      ', N'SIRUP02   ', 5, 160000, 26)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD02      ', N'SIRUP03   ', 5, 150000, 27)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD03      ', N'FLOUR01   ', 30, 360000, 28)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD03      ', N'FLOUR03   ', 10, 180000, 29)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD03      ', N'FLOUR05   ', 30, 720000, 30)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD04      ', N'FRUIT01   ', 10, 200000, 31)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD04      ', N'FRUIT02   ', 8, 400000, 32)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD05      ', N'FRUIT03   ', 10, 600000, 35)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD05      ', N'TEA02     ', 50, 650000, 37)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD06      ', N'MILK02    ', 13, 455000, 38)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD06      ', N'TEA03     ', 50, 600000, 39)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD06      ', N'TEA04     ', 50, 1250000, 40)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD07      ', N'MILK01    ', 50, 1500000, 41)
INSERT [dbo].[ChiTietHDCC] ([MaHDCC], [MaNguyenLieu], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD07      ', N'MILK02    ', 40, 1400000, 42)
SET IDENTITY_INSERT [dbo].[ChiTietHDCC] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD01      ', N'HT01      ', N'Hồng trà Đài Loan', 3, 45000, 1)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD02      ', N'HT02      ', N'Hồng trà vải', 3, 45000, 2)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD03      ', N'HT01      ', N'Hồng trà Đài Loan', 3, 45000, 3)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD04      ', N'TS03      ', N'Trà sữa Đài Loan', 3, 45000, 4)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD04      ', N'TS04      ', N'Trà sữa trà xanh', 2, 45000, 12)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD04      ', N'TX01      ', N'Trà xanh đá xay', 2, 45000, 11)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD05      ', N'TTC01     ', N'Trà đào', 2, 45000, 13)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD05      ', N'TX02      ', N'Trà xanh kem tươi', 3, 45000, 14)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD06      ', N'TX02      ', N'Trà xanh kem tươi', 2, 45000, 15)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD06      ', N'TX04      ', N'Trà xanh Sữa tươi', 2, 45000, 16)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD07      ', N'TS06      ', N'Trà sữa bí đao', 1, 45000, 17)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaThucUong], [TenThucUong], [SoLuong], [ThanhTien], [STT]) VALUES (N'HD08      ', N'TTC04     ', N'Trà mít', 2, 45000, 18)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD01      ', N'Bán lẻ', N'001', CAST(N'2023-02-07' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD02      ', N'Bán sỉ', N'001', CAST(N'2023-04-12' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD03      ', N'GTGT', N'003', CAST(N'2023-05-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD04      ', N'Nhập kho', N'004', CAST(N'2023-05-12' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD05      ', N'Xuất kho', N'002', CAST(N'2023-04-12' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD06      ', N'Bán lẻ', N'002', CAST(N'2023-03-16' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD07      ', N'Bán lẻ', N'003', CAST(N'2023-04-07' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD08      ', N'Bán sỉ', N'004', CAST(N'2023-05-14' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD09      ', N'Nhập kho', N'007', CAST(N'2023-05-12' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD10      ', N'Bán lẻ', N'010', CAST(N'2023-05-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [TenHoaDon], [MaNhanVien], [NgayGio]) VALUES (N'HD11      ', N'Bán lẻ', N'010', CAST(N'2023-05-15' AS Date))
GO
INSERT [dbo].[HopDongCungCap] ([MaHDCC], [NoiDung], [NgayKiHD], [MaNhaCC]) VALUES (N'HD01      ', N'Nhập nguyên liệu', CAST(N'2023-04-10T00:00:00.000' AS DateTime), N'NCC01     ')
INSERT [dbo].[HopDongCungCap] ([MaHDCC], [NoiDung], [NgayKiHD], [MaNhaCC]) VALUES (N'HD02      ', N'Nhập nguyên liệu', CAST(N'2023-04-01T00:00:00.000' AS DateTime), N'NCC04     ')
INSERT [dbo].[HopDongCungCap] ([MaHDCC], [NoiDung], [NgayKiHD], [MaNhaCC]) VALUES (N'HD03      ', N'Nhập nguyên liệu', CAST(N'2023-03-15T00:00:00.000' AS DateTime), N'NCC03     ')
INSERT [dbo].[HopDongCungCap] ([MaHDCC], [NoiDung], [NgayKiHD], [MaNhaCC]) VALUES (N'HD04      ', N'Nhập nguyên liệu', CAST(N'2023-02-10T00:00:00.000' AS DateTime), N'NCC06     ')
INSERT [dbo].[HopDongCungCap] ([MaHDCC], [NoiDung], [NgayKiHD], [MaNhaCC]) VALUES (N'HD05      ', N'Nhập nguyên liệu', CAST(N'2023-01-01T00:00:00.000' AS DateTime), N'NCC02     ')
INSERT [dbo].[HopDongCungCap] ([MaHDCC], [NoiDung], [NgayKiHD], [MaNhaCC]) VALUES (N'HD06      ', N'Nhập nguyên liệu', CAST(N'2023-05-01T00:00:00.000' AS DateTime), N'NCC05     ')
INSERT [dbo].[HopDongCungCap] ([MaHDCC], [NoiDung], [NgayKiHD], [MaNhaCC]) VALUES (N'HD07      ', N'Nhập nguyên liệu', CAST(N'2022-12-10T00:00:00.000' AS DateTime), N'NCC07     ')
GO
INSERT [dbo].[LoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL]) VALUES (N'CREAM     ', N'Kem')
INSERT [dbo].[LoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL]) VALUES (N'FLOUR     ', N'Bột')
INSERT [dbo].[LoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL]) VALUES (N'FRUIT     ', N'Trái cây')
INSERT [dbo].[LoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL]) VALUES (N'MILK      ', N'Sữa')
INSERT [dbo].[LoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL]) VALUES (N'SIRUP     ', N'Siro')
INSERT [dbo].[LoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL]) VALUES (N'TEA       ', N'Trà')
GO
INSERT [dbo].[Luong] ([ChucVu], [LuongTheoGio], [ThuongTheoDot]) VALUES (N'NhanVien', 27000, 0)
INSERT [dbo].[Luong] ([ChucVu], [LuongTheoGio], [ThuongTheoDot]) VALUES (N'QuanLi', 35000, 0)
GO
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'CREAM01   ', N'Kem béo', N'CREAM     ', CAST(N'2023-10-01T00:00:00.000' AS DateTime), 30000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'CREAM02   ', N'Kem phô mai', N'CREAM     ', CAST(N'2023-12-01T00:00:00.000' AS DateTime), 35000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'FLOUR01   ', N'Bột năng', N'FLOUR     ', CAST(N'2023-08-01T00:00:00.000' AS DateTime), 12000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'FLOUR02   ', N'Bột trà xanh', N'FLOUR     ', CAST(N'2023-09-01T00:00:00.000' AS DateTime), 11000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'FLOUR03   ', N'Bột socola ', N'FLOUR     ', CAST(N'2023-10-01T00:00:00.000' AS DateTime), 18000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'FLOUR04   ', N'Bột trà bí đau', N'FLOUR     ', CAST(N'2023-11-01T00:00:00.000' AS DateTime), 16000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'FLOUR05   ', N'Bột sương sáo', N'FLOUR     ', CAST(N'2023-11-01T00:00:00.000' AS DateTime), 24000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'FRUIT01   ', N'Chanh', N'FRUIT     ', CAST(N'2023-04-13T00:00:00.000' AS DateTime), 20000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'FRUIT02   ', N'Đào', N'FRUIT     ', CAST(N'2023-04-14T00:00:00.000' AS DateTime), 50000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'FRUIT03   ', N'Vải', N'FRUIT     ', CAST(N'2023-04-20T00:00:00.000' AS DateTime), 60000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'MILK01    ', N'Bột sữa bò 01', N'MILK      ', CAST(N'2023-09-01T00:00:00.000' AS DateTime), 30000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'MILK02    ', N'Bột sữa bò ít béo', N'MILK      ', CAST(N'2023-09-01T00:00:00.000' AS DateTime), 35000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'SIRUP01   ', N'Siro Mãng cầu', N'SIRUP     ', CAST(N'2023-11-01T00:00:00.000' AS DateTime), 30000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'SIRUP02   ', N'Siro Việt Quất', N'SIRUP     ', CAST(N'2023-12-01T00:00:00.000' AS DateTime), 32000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'SIRUP03   ', N'Siro Socola', N'SIRUP     ', CAST(N'2023-11-01T00:00:00.000' AS DateTime), 30000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'TEA01     ', N'Trà hoa lài', N'TEA       ', CAST(N'2023-07-01T00:00:00.000' AS DateTime), 10000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'TEA02     ', N'Trà xanh', N'TEA       ', CAST(N'2023-08-01T00:00:00.000' AS DateTime), 13000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'TEA03     ', N'Hồng trà', N'TEA       ', CAST(N'2023-09-01T00:00:00.000' AS DateTime), 12000)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [MaLoaiNL], [HanSuDung], [DonGia]) VALUES (N'TEA04     ', N'Trà bí đao', N'TEA       ', CAST(N'2023-10-01T00:00:00.000' AS DateTime), 25000)
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChiNhaCC], [ChuyenCungCap], [SoDienThoai]) VALUES (N'NCC01     ', N'Thủy Lan Food', N'23 Nguyễn Học', N'Trà xanh', N'0946373742  ')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChiNhaCC], [ChuyenCungCap], [SoDienThoai]) VALUES (N'NCC02     ', N'Hà Thanh Tea', N'21 Gia Định', N'Lá trà', N'0321546788  ')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChiNhaCC], [ChuyenCungCap], [SoDienThoai]) VALUES (N'NCC03     ', N'Bột Mì Thanh Tuấn', N'25 Nguyễn Gia', N'Bột mì', N'0175751211  ')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChiNhaCC], [ChuyenCungCap], [SoDienThoai]) VALUES (N'NCC04     ', N'Ice Sound', N'08 Hiếu Linh', N'Kem và Sirup', N'0327739890  ')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChiNhaCC], [ChuyenCungCap], [SoDienThoai]) VALUES (N'NCC05     ', N'Leaf Lanh', N'Đồng Nai', N'Trà', N'0392345234  ')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChiNhaCC], [ChuyenCungCap], [SoDienThoai]) VALUES (N'NCC06     ', N'Trái Cây Tươi', N'08 Quận 05', N'Trái cây', N'0345732849  ')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChiNhaCC], [ChuyenCungCap], [SoDienThoai]) VALUES (N'NCC07     ', N'Sữa tươi DaLat', N'01 Lý Thường Kiệt', N'Sữa', N'0356214825  ')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'001', N'Trần Văn Bảo', N'0923142326', 18, N'12 Lê Thị Pha', N'Nam', N'Bình Định', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'002', N'Lê Thị Lan', N'0389142638', 20, N'98 Trần Phú', N'Nữ', N'Bảo Lâm', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'003', N'Nguyễn Thị Bé', N'0946372655', 19, N'85 Mai Chí Thọ', N'Nữ', N'Lâm Đồng', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'004', N'Trần Phú Lâm', N'4852588515', 21, N'45 Phan Văn Trí', N'Nam', N'Tiền Giang', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'005', N'Trương Thùy Dương', N'0521818112', 22, N'06 Quận 5', N'Nữ', N'TP Hồ Chí Minh', N'QuanLi')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'006', N'Lý Thông', N'0528914584', 27, N'909 Quốc Lộ 1A', N'Nam', N'Hà Nội', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'007', N'Nguyễn Gia Huy', N'8251452554', 21, N'981 Đồng Nai', N'Nam', N'TP Hồ Chí Minh', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'008', N'Nguyễn Phi Hùng', N'5254815251', 21, N'41 đường 5/1', N'Nam', N'Bảo Lộc', N'QuanLi')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'009', N'Trần Thị Tố Nữ', N'6251481518', 23, N'51 đường số 8', N'Nữ', N'Nghệ An', N'QuanLi')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'010', N'Thái Bảo Nam', N'0587848648', 30, N'520 Nhân Quyền', N'Nam', N'Đà Lạt', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoVaTen], [SDT], [Tuoi], [DiaChi], [GioiTinh], [QueQuan], [ChucVu]) VALUES (N'011', N'Nguyễn Minh Châu', N'0984322198', 19, N'01 Võ Văn Ngân, Thủ Đức', N'Nữ', N'Lâm Đồng', N'NhanVien')
GO
INSERT [dbo].[NhomThucUong] ([MaNhomThucUong], [TenNhomThucUong]) VALUES (N'HT        ', N'Hồng trà')
INSERT [dbo].[NhomThucUong] ([MaNhomThucUong], [TenNhomThucUong]) VALUES (N'TC        ', N'Trà chanh')
INSERT [dbo].[NhomThucUong] ([MaNhomThucUong], [TenNhomThucUong]) VALUES (N'TS        ', N'Trà sữa')
INSERT [dbo].[NhomThucUong] ([MaNhomThucUong], [TenNhomThucUong]) VALUES (N'TTC       ', N'Trà trái cây')
INSERT [dbo].[NhomThucUong] ([MaNhomThucUong], [TenNhomThucUong]) VALUES (N'TX        ', N'Trà xanh')
GO
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'CREAM01   ', N'TS01      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'CREAM01   ', N'TS03      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'CREAM01   ', N'TX02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'CREAM02   ', N'TS07      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR01   ', N'TS01      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR01   ', N'TS02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR01   ', N'TS03      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR01   ', N'TS04      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR01   ', N'TS05      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR01   ', N'TS06      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR02   ', N'TS04      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR03   ', N'TS02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR04   ', N'HT03      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR04   ', N'TC01      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR04   ', N'TS06      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FLOUR05   ', N'TS01      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FRUIT01   ', N'TC01      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FRUIT01   ', N'TC02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FRUIT01   ', N'TC03      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FRUIT02   ', N'HT05      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FRUIT02   ', N'TTC01     ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FRUIT03   ', N'HT02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'FRUIT03   ', N'TTC02     ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'MILK01    ', N'TS01      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'MILK01    ', N'TS02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'MILK01    ', N'TS04      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'MILK01    ', N'TS06      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'MILK01    ', N'TS07      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'MILK02    ', N'TS03      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'MILK02    ', N'TS05      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'SIRUP01   ', N'TTC03     ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'SIRUP02   ', N'TTC04     ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'SIRUP03   ', N'TS02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA01     ', N'TC01      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA01     ', N'TC02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA01     ', N'TC03      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA02     ', N'TX01      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA02     ', N'TX02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA02     ', N'TX03      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA02     ', N'TX04      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA03     ', N'HT01      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA03     ', N'HT02      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA03     ', N'HT03      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA03     ', N'HT04      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA03     ', N'HT05      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA04     ', N'HT03      ')
INSERT [dbo].[PhaChe] ([MaNguyenLieu], [MaThucUong]) VALUES (N'TEA04     ', N'TS06      ')
GO
SET IDENTITY_INSERT [dbo].[PhieuChi] ON 

INSERT [dbo].[PhieuChi] ([MaPhieuChi], [NgayXuatPhieu], [SoTienChi], [NoiDungChi], [MaHDCC], [STT]) VALUES (N'PC01      ', CAST(N'2023-04-01' AS Date), 1040000, NULL, N'HD02      ', 3)
INSERT [dbo].[PhieuChi] ([MaPhieuChi], [NgayXuatPhieu], [SoTienChi], [NoiDungChi], [MaHDCC], [STT]) VALUES (N'PC02      ', CAST(N'2023-01-10' AS Date), 330000, NULL, N'HD01      ', 4)
INSERT [dbo].[PhieuChi] ([MaPhieuChi], [NgayXuatPhieu], [SoTienChi], [NoiDungChi], [MaHDCC], [STT]) VALUES (N'PC03      ', CAST(N'2023-05-23' AS Date), 600000, NULL, N'HD04      ', 5)
INSERT [dbo].[PhieuChi] ([MaPhieuChi], [NgayXuatPhieu], [SoTienChi], [NoiDungChi], [MaHDCC], [STT]) VALUES (N'PC04      ', CAST(N'2022-12-10' AS Date), 1260000, NULL, N'HD03      ', 6)
INSERT [dbo].[PhieuChi] ([MaPhieuChi], [NgayXuatPhieu], [SoTienChi], [NoiDungChi], [MaHDCC], [STT]) VALUES (N'PC05      ', CAST(N'2022-11-29' AS Date), 1250000, NULL, N'HD05      ', 7)
INSERT [dbo].[PhieuChi] ([MaPhieuChi], [NgayXuatPhieu], [SoTienChi], [NoiDungChi], [MaHDCC], [STT]) VALUES (N'PC06      ', CAST(N'2023-02-24' AS Date), 2305000, NULL, N'HD06      ', 8)
INSERT [dbo].[PhieuChi] ([MaPhieuChi], [NgayXuatPhieu], [SoTienChi], [NoiDungChi], [MaHDCC], [STT]) VALUES (N'PC07      ', CAST(N'2023-03-15' AS Date), 2900000, NULL, N'HD07      ', 9)
SET IDENTITY_INSERT [dbo].[PhieuChi] OFF
GO
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'001', N'vanbao', N'001bao')
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'002', N'thilan', N'002lan')
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'003', N'thibe', N'003be')
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'004', N'phulam', N'004lam')
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'005', N'thuydung', N'005dung')
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'006', N'lythong', N'006thong')
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'007 ', N'giahuy', N'007huy')
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'008', N'phihung', N'008hung')
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'009', N'tonu', N'009nu')
INSERT [dbo].[TaiKhoan] ([MaNhanVien], [TenTaiKhoan], [MatKhau]) VALUES (N'010', N'baonam', N'010nam')
GO
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'HT01      ', N'Hồng trà Đài Loan', N'HT        ', 15000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'HT02      ', N'Hồng trà vải', N'HT        ', 17000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'HT03      ', N'Hồng trà bí đao', N'HT        ', 18000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'HT04      ', N'Hồng trà Latte', N'HT        ', 19000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'HT05      ', N'Hồng trà đào', N'HT        ', 17000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TC01      ', N'Trà chanh bí đao', N'TC        ', 12000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TC02      ', N'Trà chanh truyền thống', N'TC        ', 12000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TC03      ', N'Trà chanh đào', N'TC        ', 13000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TS01      ', N'Trà sữa truyền thống', N'TS        ', 15000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TS02      ', N'Trà sữa Socola ', N'TS        ', 16000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TS03      ', N'Trà sữa Đài Loan', N'TS        ', 17000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TS04      ', N'Trà sữa trà xanh', N'TS        ', 18000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TS05      ', N'Trà sữa Latte', N'TS        ', 17000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TS06      ', N'Trà sữa bí đao', N'TS        ', 16000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TS07      ', N'Trà sữa phô mai', N'TS        ', 20000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TTC01     ', N'Trà đào', N'TTC       ', 12000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TTC02     ', N'Trà vải', N'TTC       ', 13000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TTC03     ', N'Trà mãng cầu - thơm', N'TTC       ', 14000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TTC04     ', N'Trà việt quất', N'TTC       ', 15000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TX01      ', N'Trà xanh đá xay', N'TX        ', 15000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TX02      ', N'Trà xanh kem tươi', N'TX        ', 16000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TX03      ', N'Trà xanh Latte', N'TX        ', 17000)
INSERT [dbo].[ThucUong] ([MaThucUong], [TenThucUong], [MaNhomThucUong], [GiaBan]) VALUES (N'TX04      ', N'Trà xanh Sữa tươi', N'TX        ', 18000)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PhieuChi__1419C13BFD99C8C4]    Script Date: 6/2/2023 11:39:17 PM ******/
ALTER TABLE [dbo].[PhieuChi] ADD UNIQUE NONCLUSTERED 
(
	[MaHDCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_ChamCong_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK_ChamCong_NhanVien]
GO
ALTER TABLE [dbo].[ChiTietHDCC]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDCC_HopDongCungCap] FOREIGN KEY([MaHDCC])
REFERENCES [dbo].[HopDongCungCap] ([MaHDCC])
GO
ALTER TABLE [dbo].[ChiTietHDCC] CHECK CONSTRAINT [FK_ChiTietHDCC_HopDongCungCap]
GO
ALTER TABLE [dbo].[ChiTietHDCC]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDCC_NguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
ALTER TABLE [dbo].[ChiTietHDCC] CHECK CONSTRAINT [FK_ChiTietHDCC_NguyenLieu]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_ThucUong] FOREIGN KEY([MaThucUong])
REFERENCES [dbo].[ThucUong] ([MaThucUong])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_ThucUong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HopDongCungCap]  WITH CHECK ADD  CONSTRAINT [FK_HopDongCungCap_NhaCungCap] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[HopDongCungCap] CHECK CONSTRAINT [FK_HopDongCungCap_NhaCungCap]
GO
ALTER TABLE [dbo].[NguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_LoaiNguyenLieu] FOREIGN KEY([MaLoaiNL])
REFERENCES [dbo].[LoaiNguyenLieu] ([MaLoaiNL])
GO
ALTER TABLE [dbo].[NguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_LoaiNguyenLieu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Luong] FOREIGN KEY([ChucVu])
REFERENCES [dbo].[Luong] ([ChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Luong]
GO
ALTER TABLE [dbo].[PhaChe]  WITH CHECK ADD  CONSTRAINT [FK_PhaChe_NguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
ALTER TABLE [dbo].[PhaChe] CHECK CONSTRAINT [FK_PhaChe_NguyenLieu]
GO
ALTER TABLE [dbo].[PhaChe]  WITH CHECK ADD  CONSTRAINT [FK_PhaChe_ThucUong] FOREIGN KEY([MaThucUong])
REFERENCES [dbo].[ThucUong] ([MaThucUong])
GO
ALTER TABLE [dbo].[PhaChe] CHECK CONSTRAINT [FK_PhaChe_ThucUong]
GO
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_PhieuChi_HopDongCungCap] FOREIGN KEY([MaHDCC])
REFERENCES [dbo].[HopDongCungCap] ([MaHDCC])
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [FK_PhieuChi_HopDongCungCap]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[ThucUong]  WITH CHECK ADD  CONSTRAINT [FK_ThucUong_NhomThucUong] FOREIGN KEY([MaNhomThucUong])
REFERENCES [dbo].[NhomThucUong] ([MaNhomThucUong])
GO
ALTER TABLE [dbo].[ThucUong] CHECK CONSTRAINT [FK_ThucUong_NhomThucUong]
GO
