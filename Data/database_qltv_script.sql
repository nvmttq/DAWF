
CREATE DATABASE QuanLyThuVien
GO

USE [QuanLyThuVien]
GO
/****** Object:  UserDefinedFunction [dbo].[FUC_newIdUser]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE FUNCTION [dbo].[FUC_newIdUser]
(
	-- Add the parameters for the function here
	@idUser varchar(40)
)
RETURNS varchar(40)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @num int = 100

	

	-- Return the result of the function
	RETURN @idUser

END
GO
/****** Object:  Table [dbo].[ChiTietMuonSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietMuonSach](
	[idCTM] [int] IDENTITY(1,1) NOT NULL,
	[idMuonSach] [int] NULL,
	[idSach] [varchar](40) NULL,
	[soLuong] [int] NULL,
	[daTra] [int] NULL,
	[ngayMuon] [datetime] NULL,
	[ngayHenTra] [datetime] NULL,
	[soLanGiaHan] [int] NULL,
	[tinhTrang] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietTheLoai]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietTheLoai](
	[idSach] [varchar](40) NOT NULL,
	[idTheLoai] [varchar](40) NOT NULL,
 CONSTRAINT [PK_ChiTietTheLoai] PRIMARY KEY CLUSTERED 
(
	[idSach] ASC,
	[idTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietTraSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietTraSach](
	[idTraSach] [int] IDENTITY(1,1) NOT NULL,
	[idCTM] [int] NULL,
	[idSach] [varchar](40) NULL,
	[soLuong] [int] NULL,
	[ngayTra] [datetime] NULL,
	[soTienPhat] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGia](
	[idDG] [varchar](40) NULL,
	[idSach] [varchar](40) NULL,
	[Rate] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachMuon]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachMuon](
	[idMuonSach] [int] IDENTITY(1,1) NOT NULL,
	[idThe] [varchar](40) NULL,
	[soLuong] [int] NULL,
	[tinhtrang] [int] NULL,
 CONSTRAINT [PK_DanhSachMuon] PRIMARY KEY CLUSTERED 
(
	[idMuonSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachTra]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachTra](
	[idTraSach] [int] NOT NULL,
	[idThe] [varchar](40) NULL,
	[soLuong] [int] NULL,
 CONSTRAINT [PK_DanhSachTra] PRIMARY KEY CLUSTERED 
(
	[idTraSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KeSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KeSach](
	[maKe] [varchar](40) NOT NULL,
	[tang] [int] NOT NULL,
	[idSach] [varchar](40) NOT NULL,
 CONSTRAINT [PK_KeSach] PRIMARY KEY CLUSTERED 
(
	[maKe] ASC,
	[tang] ASC,
	[idSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mode]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mode](
	[idMode] [varchar](40) NOT NULL,
	[Role] [nvarchar](40) NULL,
 CONSTRAINT [PK_Mod] PRIMARY KEY CLUSTERED 
(
	[idMode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[idSach] [varchar](40) NOT NULL,
	[tenSach] [nvarchar](40) NOT NULL,
	[tenTacGia] [nvarchar](40) NOT NULL,
	[nhaXuatBan] [nvarchar](40) NULL,
	[namXuatBan] [int] NULL,
	[soTrang] [int] NULL,
	[soLuong] [int] NULL,
	[danhGia] [nvarchar](40) NULL,
	[createdAt] [datetime] NULL,
	[modifiedAt] [datetime] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[idSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[idThanhVien] [varchar](40) NOT NULL,
	[Fname] [nvarchar](40) NOT NULL,
	[Lname] [nvarchar](40) NOT NULL,
	[Birthday] [date] NULL,
	[Email] [varchar](40) NULL,
	[Phone] [varchar](40) NULL,
	[Bank] [varchar](40) NULL,
	[Mode] [varchar](40) NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[idThanhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[idTheLoai] [varchar](40) NOT NULL,
	[tenTheLoai] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[idTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheThuVien]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheThuVien](
	[idThe] [varchar](40) NOT NULL,
	[idThanhVien] [varchar](40) NULL,
	[Password] [varchar](40) NULL,
	[NgayDangKy] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
 CONSTRAINT [PK_TheThuVien] PRIMARY KEY CLUSTERED 
(
	[idThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauDuocXacNhan]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauDuocXacNhan](
	[idYCXN] [int] NOT NULL,
	[tenSach] [nvarchar](40) NULL,
	[tenTacGia] [nvarchar](40) NULL,
	[soLuong] [int] NULL,
	[ngayXacNhan] [datetime] NULL,
 CONSTRAINT [PK_YeuCauDuocXacNhan] PRIMARY KEY CLUSTERED 
(
	[idYCXN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauSach](
	[idYC] [int] IDENTITY(1,1) NOT NULL,
	[tenSach] [nvarchar](40) NULL,
	[tenTacGia] [nvarchar](40) NULL,
	[soLuong] [int] NULL,
	[ngayYeuCau] [datetime] NULL,
 CONSTRAINT [PK_YeuCauSach] PRIMARY KEY CLUSTERED 
(
	[idYC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietMuonSach] ON 
GO
INSERT [dbo].[ChiTietMuonSach] ([idCTM], [idMuonSach], [idSach], [soLuong], [daTra], [ngayMuon], [ngayHenTra], [soLanGiaHan], [tinhTrang]) VALUES (2027, 4005, N'aaa1', 1, 1, CAST(N'2023-07-19T00:17:39.837' AS DateTime), CAST(N'2023-07-26T00:17:39.000' AS DateTime), 0, 1)
GO
INSERT [dbo].[ChiTietMuonSach] ([idCTM], [idMuonSach], [idSach], [soLuong], [daTra], [ngayMuon], [ngayHenTra], [soLanGiaHan], [tinhTrang]) VALUES (1034, 3013, N'1984', 1, 0, CAST(N'2023-07-16T14:38:06.313' AS DateTime), CAST(N'2023-07-23T14:38:06.000' AS DateTime), 0, 0)
GO
INSERT [dbo].[ChiTietMuonSach] ([idCTM], [idMuonSach], [idSach], [soLuong], [daTra], [ngayMuon], [ngayHenTra], [soLanGiaHan], [tinhTrang]) VALUES (1035, 3013, N'EI', 1, 0, CAST(N'2023-07-16T14:38:06.320' AS DateTime), CAST(N'2023-07-23T14:38:06.000' AS DateTime), 0, 0)
GO
INSERT [dbo].[ChiTietMuonSach] ([idCTM], [idMuonSach], [idSach], [soLuong], [daTra], [ngayMuon], [ngayHenTra], [soLanGiaHan], [tinhTrang]) VALUES (1033, 3012, N'1984', 3, 5, CAST(N'2023-07-16T14:31:19.293' AS DateTime), CAST(N'2023-07-23T14:31:19.000' AS DateTime), 0, 0)
GO
SET IDENTITY_INSERT [dbo].[ChiTietMuonSach] OFF
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'1984', N'1')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'1984', N'5')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'1984', N'9')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'BCATNT', N'1')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'BNSGDT', N'2')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'CP', N'3')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'DMPK', N'4')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'DMTB', N'5')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'HPSS', N'6')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'LH', N'7')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'MD', N'8')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'PAP', N'9')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'SD', N'1')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TCITR', N'2')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TD', N'3')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TGG', N'4')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TH', N'5')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TK', N'6')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TKAM', N'7')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TLOTR', N'8')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TMÐNN', N'1')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TMÐNN', N'3')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TMÐNN', N'5')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TMÐNN', N'7')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TTHVTCX', N'9')
GO
INSERT [dbo].[ChiTietTheLoai] ([idSach], [idTheLoai]) VALUES (N'TTL', N'1')
GO
SET IDENTITY_INSERT [dbo].[ChiTietTraSach] ON 
GO
INSERT [dbo].[ChiTietTraSach] ([idTraSach], [idCTM], [idSach], [soLuong], [ngayTra], [soTienPhat]) VALUES (2020, 1, N'aaa1', 1, CAST(N'2023-07-19T00:18:20.217' AS DateTime), 0)
GO
INSERT [dbo].[ChiTietTraSach] ([idTraSach], [idCTM], [idSach], [soLuong], [ngayTra], [soTienPhat]) VALUES (2021, 2, N'1984', 0, CAST(N'2023-07-19T00:19:14.617' AS DateTime), 0)
GO
INSERT [dbo].[ChiTietTraSach] ([idTraSach], [idCTM], [idSach], [soLuong], [ngayTra], [soTienPhat]) VALUES (1026, 2, N'1984', 2, CAST(N'2023-07-16T14:31:24.107' AS DateTime), 0)
GO
INSERT [dbo].[ChiTietTraSach] ([idTraSach], [idCTM], [idSach], [soLuong], [ngayTra], [soTienPhat]) VALUES (1027, 1033, N'1984', 1, CAST(N'2023-07-16T14:32:03.900' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[ChiTietTraSach] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhSachMuon] ON 
GO
INSERT [dbo].[DanhSachMuon] ([idMuonSach], [idThe], [soLuong], [tinhtrang]) VALUES (3012, N'11', 3, 0)
GO
INSERT [dbo].[DanhSachMuon] ([idMuonSach], [idThe], [soLuong], [tinhtrang]) VALUES (3013, N'13', 2, 0)
GO
INSERT [dbo].[DanhSachMuon] ([idMuonSach], [idThe], [soLuong], [tinhtrang]) VALUES (4005, N'13', 1, 0)
GO
SET IDENTITY_INSERT [dbo].[DanhSachMuon] OFF
GO
INSERT [dbo].[DanhSachTra] ([idTraSach], [idThe], [soLuong]) VALUES (1, N'1', 2)
GO
INSERT [dbo].[DanhSachTra] ([idTraSach], [idThe], [soLuong]) VALUES (3, N'1', 2)
GO
INSERT [dbo].[DanhSachTra] ([idTraSach], [idThe], [soLuong]) VALUES (4, N'1', 3)
GO
INSERT [dbo].[DanhSachTra] ([idTraSach], [idThe], [soLuong]) VALUES (5, N'9', 3)
GO
INSERT [dbo].[DanhSachTra] ([idTraSach], [idThe], [soLuong]) VALUES (6, N'1', 2)
GO
INSERT [dbo].[KeSach] ([maKe], [tang], [idSach]) VALUES (N'SGK', 1, N'1984')
GO
INSERT [dbo].[KeSach] ([maKe], [tang], [idSach]) VALUES (N'SGK', 1, N'EI')
GO
INSERT [dbo].[KeSach] ([maKe], [tang], [idSach]) VALUES (N'SGK', 1, N'HW')
GO
INSERT [dbo].[KeSach] ([maKe], [tang], [idSach]) VALUES (N'SGK', 1, N'ILV')
GO
INSERT [dbo].[KeSach] ([maKe], [tang], [idSach]) VALUES (N'SGK', 1, N'LH')
GO
INSERT [dbo].[KeSach] ([maKe], [tang], [idSach]) VALUES (N'SGK', 1, N'LND')
GO
INSERT [dbo].[Mode] ([idMode], [Role]) VALUES (N'1', N'ADMIN')
GO
INSERT [dbo].[Mode] ([idMode], [Role]) VALUES (N'2', N'EMPLOYEE')
GO
INSERT [dbo].[Mode] ([idMode], [Role]) VALUES (N'3', N'READER')
GO
INSERT [dbo].[Mode] ([idMode], [Role]) VALUES (N'4', N'TEACHER')
GO
INSERT [dbo].[Mode] ([idMode], [Role]) VALUES (N'5', N'ORTHER')
GO
INSERT [dbo].[Mode] ([idMode], [Role]) VALUES (N'6', N'ORTHER2')
GO
INSERT [dbo].[Mode] ([idMode], [Role]) VALUES (N'7', N'ALL1')
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'1984', N'1984', N'George Orwell', N'Secker & Warburg', 1949, 90, 100, N'5.5', CAST(N'2023-06-21T20:41:18.140' AS DateTime), CAST(N'2023-06-21T20:41:18.140' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'aaa1', N'aaa', N'aaa', N'Toi La AI', 1234, 5, 100, N'', CAST(N'2023-06-26T09:31:30.157' AS DateTime), CAST(N'2023-06-26T09:31:30.157' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'aaa2', N'Toi tu luyen khi 10 ngan nam', N'aaa2221T', N'aaa', 1234, 100, 100, N'5.5', CAST(N'2023-06-26T09:31:30.157' AS DateTime), CAST(N'2023-06-26T09:31:30.157' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'BCATNT', N'Bồ Công Anh Trên Ngực Trái', N'Nguyễn Nhat Anh', N'Kim Đồng', 1992, 51, 100, N'', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'BNSGDT', N'Biên Niên Sử Gia Đình Tôi', N'Nguyễn Huy Thiệp', N'Văn Học', 1995, 75, 100, N'5.5', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'CP', N'Chí Phèo', N'Nam Cao', N'Văn Học', 1941, 45, 100, N'5.5', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'DMPK', N'Dế Mèn Phiêu Lưu Ký', N'Tô Hoài', N'Nhã Nam', 1974, 50, 100, N'5.5', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'DMTB', N'Dế Mèn Tốt Bụng', N'Nguyễn Nhật Ánh', N'Trẻ', 2009, 60, 100, N'5.5', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'EI', N'English III', N'Huỳnh Thị Ngọc Thảo', N'TTNN', 2019, 200, 100, N'0', CAST(N'2023-06-28T10:05:35.057' AS DateTime), CAST(N'2023-06-28T10:05:35.057' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'HPSS', N'Harry Potter and the Sorcerer''s Stone', N'J.K. Rowling', N'Bloomsbury', 1997, 100, 100, N'5.5', CAST(N'2023-06-21T20:41:18.140' AS DateTime), CAST(N'2023-06-21T20:41:18.140' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'LH', N'Lão Hạc', N'Nam Cao', N'Văn Học', 1945, 55, 100, N'5.5', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'LTTKW', N'Lập trình Thiết kế web', N'Trần Cẩm Tú', N'Nhà Giáo Dục', 2019, 222, 100, N'0', CAST(N'2023-06-28T09:52:40.320' AS DateTime), CAST(N'2023-06-28T10:05:33.890' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'LTW', N'Lập trình winform', N'Hồ Thức Thuận', N'Nhà Giáo Dục', 2019, 113, 100, N'0', CAST(N'2023-06-28T09:35:15.130' AS DateTime), CAST(N'2023-06-28T10:01:37.460' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'MD', N'Moby-Dick', N'Herman Melville', N'Harper & Brothers', 1851, 60, 100, N'5.5', CAST(N'2023-06-21T20:41:18.140' AS DateTime), CAST(N'2023-06-21T20:41:18.140' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'PAP', N'Pride and Prejudice', N'Jane Austen', N'T. Egerton, Whitehall', 1813, 120, 100, N'5.5', CAST(N'2023-06-21T20:41:18.140' AS DateTime), CAST(N'2023-06-21T20:41:18.140' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'SD', N'Số Đỏ', N'Vũ Trọng Phụng', N'Đại Nam', 1936, 70, 100, N'5.5', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TD', N'Tắt Đèn1', N'Ngô Tất Tố', N'Văn Học', 1946, 30, 100, N'', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TGG', N'The Great Gatsby', N'F. Scott Fitzgerald', N'Charles Scribners Sons', 1925, 80, 100, N'5.5', CAST(N'2023-06-21T20:41:18.140' AS DateTime), CAST(N'2023-06-21T20:41:18.140' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TH', N'The Hobbit', N'J.R.R. Tolkien', N'Allen & Unwin', 1937, 180, 100, N'5.5', CAST(N'2023-06-21T20:41:18.140' AS DateTime), CAST(N'2023-06-21T20:41:18.140' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TK', N'Truyện Kiều', N'Nguyễn Du', N'N/A', 1820, 65, 100, N'5.5', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TKAM', N'To Kill a Mockingbird', N'Harper Lee', N'J.B. Lippincott & Co.', 1960, 150, 100, N'', CAST(N'2023-06-21T20:41:18.140' AS DateTime), CAST(N'2023-06-21T20:41:18.140' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TLOTR', N'The Lord of the Rings', N'J.R.R. Tolkien', N'George Allen & Unwin', 1954, 200, 100, N'5.5', CAST(N'2023-06-21T20:41:18.140' AS DateTime), CAST(N'2023-06-21T20:41:18.140' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TMÐN', N'Tôi muốn được ngủ', N'Nguyễn Văn Minh', N'Nguyễn Văn Minh', 2003, 100, 100, N'0', CAST(N'2023-07-20T14:07:36.310' AS DateTime), CAST(N'2023-07-20T14:07:36.310' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TMÐNN', N'Tôi Muốn Được Nghỉ Nghơi', N'Nguyễn Văn Minh', N'Nguyễn Văn Minh', 2003, 100, 100, N'0', CAST(N'2023-07-20T14:28:58.383' AS DateTime), CAST(N'2023-07-20T14:28:58.383' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TTHVTCX', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', N'Nguyễn Nhật Ánh', N'Trẻ', 2005, 90, 100, N'5.5', CAST(N'2023-06-21T20:46:52.190' AS DateTime), CAST(N'2023-06-21T20:46:52.190' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'TTL', N'To the Lighthouse', N'Virginia Woolf', N'Hogarth Press', 1927, 70, 100, N'5.5', CAST(N'2023-06-21T20:41:18.140' AS DateTime), CAST(N'2023-06-21T20:41:18.140' AS DateTime))
GO
INSERT [dbo].[Sach] ([idSach], [tenSach], [tenTacGia], [nhaXuatBan], [namXuatBan], [soTrang], [soLuong], [danhGia], [createdAt], [modifiedAt]) VALUES (N'VCAP', N'Vợ chồng A phủ', N'Tô Hoài', N'Nhà Giáo Dục', 2019, 113, 100, N'0', CAST(N'2023-06-28T10:27:01.583' AS DateTime), CAST(N'2023-06-28T10:27:01.583' AS DateTime))
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'1', N'Minh', N'Nguyễn', CAST(N'2003-05-15' AS Date), N'nvmttq@gmail.com', N'2222222222', NULL, N'1')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'123_Nv', N'12 21', N'31', CAST(N'2023-06-26' AS Date), N'312@gmail.com', N'1234267891', NULL, N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'123_SV', N'12 2', N'3', CAST(N'2023-06-26' AS Date), N'3@gmail.com', N'1524557890', NULL, N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'1v_SV', N'1ain', N'van1', CAST(N'2003-05-15' AS Date), N'ral11505@gmail.com', N'0376108472', NULL, N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'2', N'Minh', N'ThuTNguyễn', CAST(N'2002-05-15' AS Date), N'minh1@gmail.com', N'2312312355', N'65001', N'2')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'3', N'MinhReader', N'Nguyễn', CAST(N'2003-05-15' AS Date), N'reader@gmail.com', N'3333333333', N'650011', N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'456_SV', N'4 5', N'6', CAST(N'2023-06-26' AS Date), N'123z@gmail.com', N'09212120640', NULL, N'4')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'av_SV', N'ain', N'van1', CAST(N'2003-05-15' AS Date), N'real11505@gmail.com', N'0376208472', NULL, N'4')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID_9', N'Christopher', N'Moore', CAST(N'1993-07-17' AS Date), N'123@gmail.com', N'2312312321', N'Bank9', N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID1', N'John', N'Doe', CAST(N'1990-01-01' AS Date), N'john.doe@example.com', N'1234567890', N'Bank1', N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID10', N'Amanda1', N'Wilson', CAST(N'1997-11-05' AS Date), N'amanda.wilson@example.com', N'7777777777', N'Bank10', N'4')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID11', N'Matthew', N'Clark', CAST(N'1989-04-14' AS Date), N'matthew.clark@example.com', N'8888888888', N'Bank11', N'5')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID12', N'Olivia', N'Martin', CAST(N'1995-10-22' AS Date), N'olivia.martin@example.com', N'1212121212', N'Bank12', N'6')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID13', N'Daniel', N'Miller', CAST(N'1992-01-03' AS Date), N'daniel.miller@example.com', N'3434343434', N'Bank13', N'1')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID14', N'Sophia', N'Harris', CAST(N'1986-06-18' AS Date), N'sophia.harris@example.com', N'5656565656', N'Bank14', N'2')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID15', N'James', N'Wilson', CAST(N'1999-09-27' AS Date), N'james.wilson@example.com', N'7878787878', N'Bank15', N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID16', N'Elizabeth12', N'King', CAST(N'1988-12-08' AS Date), N'elizabeth.king@example.com', N'9090909090', N'Bank16', N'4')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID2', N'Jane', N'Smith', CAST(N'1992-05-10' AS Date), N'jane.smith@example.com', N'9876543210', N'Bank2', N'2')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID3', N'Michael', N'Johnson', CAST(N'1985-08-15' AS Date), N'michael.johnson@example.com', N'5555555555', N'Bank31', N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID4', N'Emily', N'Brown', CAST(N'1998-12-20' AS Date), N'emily.brown@example.com', N'9999999999', N'Bank4', N'4')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID5', N'David3', N'Taylor', CAST(N'1994-03-25' AS Date), N'david.taylor@example.com', N'1111111111', N'Bank5', N'5')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID6', N'Sarah', N'Wilson', CAST(N'1991-06-12' AS Date), N'sarah.wilson@example.com', N'2222224223', N'Bank6', N'5')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID7', N'Robert', N'Anderson', CAST(N'1987-09-30' AS Date), N'robert.anderson@example.com', N'3334333333', N'Bank7', N'1')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID8', N'Jennifer', N'Lee', CAST(N'1996-02-08' AS Date), N'jennifer.lee@example.com', N'4444444444', N'Bank8', N'2')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'ID9', N'Christopher', N'Moore', CAST(N'1993-07-17' AS Date), N'christopher.moore@example.com', N'6666666666', N'Bank9', N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'mm_SV', N'm m', N'm', CAST(N'2023-06-26' AS Date), N'm@gmail.com', N'09212129640', NULL, N'3')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'mnv_SV', N'minh nguyen', N'van', CAST(N'2003-05-15' AS Date), N'real1505@gmail.com', N'0376208473', NULL, N'4')
GO
INSERT [dbo].[ThanhVien] ([idThanhVien], [Fname], [Lname], [Birthday], [Email], [Phone], [Bank], [Mode]) VALUES (N'mtn_Gv', N'minh thang', N'nguyen', CAST(N'2003-07-01' AS Date), N'thangcdnguyen@gmail.com', N'09212129641', NULL, N'4')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'1', N'Kinh Dị')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'10', N'Tất Cả')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'2', N'Tình Cảm')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'3', N'Hài Hước')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'4', N'Nhân Văn')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'5', N'Kiến thức')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'6', N'SGK')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'7', N'Siêu Nhiên')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'8', N'LightNovel')
GO
INSERT [dbo].[TheLoai] ([idTheLoai], [tenTheLoai]) VALUES (N'9', N'Tâm Lý')
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'1', N'ID1', N'1234567890', CAST(N'1990-01-01T00:00:00.000' AS DateTime), CAST(N'1990-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'10', N'ID3', N'5555555555', CAST(N'1985-08-15T00:00:00.000' AS DateTime), CAST(N'1985-08-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'11', N'ID4', N'9999999999', CAST(N'1998-12-20T00:00:00.000' AS DateTime), CAST(N'1998-12-20T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'12', N'ID5', N'1111111111', CAST(N'1994-03-25T00:00:00.000' AS DateTime), CAST(N'1994-03-25T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'123_SV', N'123_SV', N'123', CAST(N'2023-06-26T22:44:43.000' AS DateTime), CAST(N'2023-06-27T22:44:43.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'13', N'ID6', N'2222224222', CAST(N'1991-06-12T00:00:00.000' AS DateTime), CAST(N'1991-06-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'14', N'ID7', N'3334333333', CAST(N'1987-09-30T00:00:00.000' AS DateTime), CAST(N'1987-09-30T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'15', N'ID8', N'4444444444', CAST(N'1996-02-08T00:00:00.000' AS DateTime), CAST(N'1996-02-08T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'16', N'ID9', N'6666666666', CAST(N'1993-07-17T00:00:00.000' AS DateTime), CAST(N'1993-07-17T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'2', N'ID10', N'7777777777', CAST(N'1997-11-05T00:00:00.000' AS DateTime), CAST(N'1997-11-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'22498', N'3', N'concun123', CAST(N'2023-05-30T20:46:44.100' AS DateTime), CAST(N'3000-12-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'3', N'ID11', N'8888888888', CAST(N'1989-04-14T00:00:00.000' AS DateTime), CAST(N'1989-04-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'4', N'ID12', N'1212121212', CAST(N'1995-10-22T00:00:00.000' AS DateTime), CAST(N'1995-10-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'456_SV', N'456_SV', N'123', CAST(N'2023-06-26T22:46:48.000' AS DateTime), CAST(N'2023-07-03T22:46:48.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'5', N'ID13', N'3434343434', CAST(N'1992-01-03T00:00:00.000' AS DateTime), CAST(N'1992-01-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'6', N'ID14', N'5656565656', CAST(N'1986-06-18T00:00:00.000' AS DateTime), CAST(N'1986-06-18T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'7', N'ID15', N'7878787878', CAST(N'1999-09-27T00:00:00.000' AS DateTime), CAST(N'1999-09-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'8', N'ID16', N'9090909090', CAST(N'1988-12-08T00:00:00.000' AS DateTime), CAST(N'1988-12-08T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'9', N'ID2', N'9876543210', CAST(N'1992-05-10T00:00:00.000' AS DateTime), CAST(N'1992-05-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'admin', N'1', N'admin', CAST(N'2023-05-30T20:47:54.110' AS DateTime), CAST(N'3000-12-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'reader', N'3', N'concun123', CAST(N'2023-05-30T20:46:44.100' AS DateTime), CAST(N'3000-12-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[TheThuVien] ([idThe], [idThanhVien], [Password], [NgayDangKy], [NgayHetHan]) VALUES (N'thuthu', N'2', N'thuthu', CAST(N'2023-05-30T20:48:10.357' AS DateTime), CAST(N'3000-12-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[YeuCauDuocXacNhan] ([idYCXN], [tenSach], [tenTacGia], [soLuong], [ngayXacNhan]) VALUES (1, N'Nội  chiến thế giới', N'Alex', 4, CAST(N'2023-07-10T19:59:30.130' AS DateTime))
GO
INSERT [dbo].[YeuCauDuocXacNhan] ([idYCXN], [tenSach], [tenTacGia], [soLuong], [ngayXacNhan]) VALUES (2, N'Thế chiến Gen Z', N'Huỳnh Khải', 5, CAST(N'2023-07-10T20:04:19.200' AS DateTime))
GO
INSERT [dbo].[YeuCauDuocXacNhan] ([idYCXN], [tenSach], [tenTacGia], [soLuong], [ngayXacNhan]) VALUES (3, N'2016', N'T&J', 2, CAST(N'2023-07-10T20:02:29.070' AS DateTime))
GO
INSERT [dbo].[YeuCauDuocXacNhan] ([idYCXN], [tenSach], [tenTacGia], [soLuong], [ngayXacNhan]) VALUES (5, N'Thế chiến Gen Z', N'Huỳnh Khải', 5, CAST(N'2023-07-10T20:11:53.693' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[YeuCauSach] ON 
GO
INSERT [dbo].[YeuCauSach] ([idYC], [tenSach], [tenTacGia], [soLuong], [ngayYeuCau]) VALUES (4, N'Nội  chiến thế giới', N'Alex', 4, CAST(N'2023-07-10T19:59:30.130' AS DateTime))
GO
INSERT [dbo].[YeuCauSach] ([idYC], [tenSach], [tenTacGia], [soLuong], [ngayYeuCau]) VALUES (6, N'2016', N'T&J', 2, CAST(N'2023-07-10T20:02:29.070' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[YeuCauSach] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DocGia_Email]    Script Date: 7/21/2023 10:54:32 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DocGia_Email] ON [dbo].[ThanhVien]
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DocGia_Phone]    Script Date: 7/21/2023 10:54:32 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DocGia_Phone] ON [dbo].[ThanhVien]
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietMuonSach] ADD  CONSTRAINT [DF_ChiTietMuonSach_soLuong]  DEFAULT ((0)) FOR [soLuong]
GO
ALTER TABLE [dbo].[ChiTietMuonSach] ADD  CONSTRAINT [DF_ChiTietMuonSach_conLai]  DEFAULT ((0)) FOR [daTra]
GO
ALTER TABLE [dbo].[ChiTietMuonSach] ADD  CONSTRAINT [DF_ChiTietMuonSach_ngayMuon]  DEFAULT (getdate()) FOR [ngayMuon]
GO
ALTER TABLE [dbo].[ChiTietMuonSach] ADD  CONSTRAINT [DF_ChiTietMuonSach_soLanGiaHan]  DEFAULT ((0)) FOR [soLanGiaHan]
GO
ALTER TABLE [dbo].[ChiTietTraSach] ADD  CONSTRAINT [DF_ChiTietTraSach_soLuong]  DEFAULT ((0)) FOR [soLuong]
GO
ALTER TABLE [dbo].[ChiTietTraSach] ADD  CONSTRAINT [DF_ChiTietTraSach_ngayTra]  DEFAULT (getdate()) FOR [ngayTra]
GO
ALTER TABLE [dbo].[ChiTietTraSach] ADD  CONSTRAINT [DF_ChiTietTraSach_soTienPhat]  DEFAULT ((0)) FOR [soTienPhat]
GO
ALTER TABLE [dbo].[DanhSachMuon] ADD  CONSTRAINT [DF_DanhSachMuon_soLuong]  DEFAULT ((0)) FOR [soLuong]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_updatedAt]  DEFAULT ((0)) FOR [soTrang]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_updatedAt_1]  DEFAULT ((0)) FOR [soLuong]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_danhGia]  DEFAULT (N'0') FOR [danhGia]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_updatedAt_2]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_updatedAt_3]  DEFAULT (getdate()) FOR [modifiedAt]
GO
ALTER TABLE [dbo].[TheThuVien] ADD  CONSTRAINT [DF_TheThuVien_NgayDangKy]  DEFAULT (getdate()) FOR [NgayDangKy]
GO
ALTER TABLE [dbo].[YeuCauDuocXacNhan] ADD  CONSTRAINT [DF_YeuCauDuocXacNhan_soLuong]  DEFAULT ((0)) FOR [soLuong]
GO
ALTER TABLE [dbo].[YeuCauDuocXacNhan] ADD  CONSTRAINT [DF_YeuCauDuocXacNhan_ngayXacNhan]  DEFAULT (getdate()) FOR [ngayXacNhan]
GO
ALTER TABLE [dbo].[YeuCauSach] ADD  CONSTRAINT [DF_YeuCauSach_soLuong]  DEFAULT ((0)) FOR [soLuong]
GO
ALTER TABLE [dbo].[YeuCauSach] ADD  CONSTRAINT [DF_YeuCauSach_ngayYeuCau]  DEFAULT (getdate()) FOR [ngayYeuCau]
GO
ALTER TABLE [dbo].[DanhSachMuon]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachMuon_TheThuVien] FOREIGN KEY([idThe])
REFERENCES [dbo].[TheThuVien] ([idThe])
GO
ALTER TABLE [dbo].[DanhSachMuon] CHECK CONSTRAINT [FK_DanhSachMuon_TheThuVien]
GO
ALTER TABLE [dbo].[DanhSachTra]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachTra_TheThuVien] FOREIGN KEY([idThe])
REFERENCES [dbo].[TheThuVien] ([idThe])
GO
ALTER TABLE [dbo].[DanhSachTra] CHECK CONSTRAINT [FK_DanhSachTra_TheThuVien]
GO
ALTER TABLE [dbo].[TheThuVien]  WITH CHECK ADD  CONSTRAINT [FK_TheThuVien_DocGia] FOREIGN KEY([idThanhVien])
REFERENCES [dbo].[ThanhVien] ([idThanhVien])
GO
ALTER TABLE [dbo].[TheThuVien] CHECK CONSTRAINT [FK_TheThuVien_DocGia]
GO
ALTER TABLE [dbo].[ChiTietMuonSach]  WITH CHECK ADD  CONSTRAINT [CK_ChiTietMuonSach_soLanGiaHan] CHECK  (([soLanGiaHan]<=(3)))
GO
ALTER TABLE [dbo].[ChiTietMuonSach] CHECK CONSTRAINT [CK_ChiTietMuonSach_soLanGiaHan]
GO
ALTER TABLE [dbo].[DanhSachMuon]  WITH CHECK ADD  CONSTRAINT [CK_DanhSachMuon_soLuong] CHECK  (([soLuong]<=(3)))
GO
ALTER TABLE [dbo].[DanhSachMuon] CHECK CONSTRAINT [CK_DanhSachMuon_soLuong]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [CK_Sach] CHECK  (([soLuong]>=(0)))
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [CK_Sach]
GO
ALTER TABLE [dbo].[ThanhVien]  WITH CHECK ADD  CONSTRAINT [CK_DocGia_Email] CHECK  (([Email] like '%@%'))
GO
ALTER TABLE [dbo].[ThanhVien] CHECK CONSTRAINT [CK_DocGia_Email]
GO
ALTER TABLE [dbo].[ThanhVien]  WITH CHECK ADD  CONSTRAINT [CK_DocGia_Phone] CHECK  ((len([Phone])>=(10) AND len([Phone])<=(11)))
GO
ALTER TABLE [dbo].[ThanhVien] CHECK CONSTRAINT [CK_DocGia_Phone]
GO
/****** Object:  StoredProcedure [dbo].[searchBookWithOption]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[searchBookWithOption]
	@keyWord nvarchar(100), @op nvarchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	IF @op = N'Tác giả'
	BEGIN
		SELECT * FROM Sach s
		WHERE s.tenTacGia like '%'+@keyWord+'%'
	END

	--ELSE IF @op = N'Nhà xuất bản'
	--BEGIN
	--	SELECT * FROM Sach s
	--	WHERE s.nhaXuatBan like '%'+@keyWord+'%'
	--END

	ELSE IF @op = N'Sách'
	BEGIN
		SELECT * FROM Sach s
		WHERE s.tenSach like '%'+@keyWord+'%'
	END

	ELSE IF @op = N'ID Sách'
	BEGIN
		SELECT * FROM Sach s
		WHERE s.idSach like '%'+@keyWord+'%'
	END
	--ELSE IF @op = N'Thể loại'
	--BEGIN
	--	SELECT * FROM Sach s
	--	INNER JOIN ChiTietTheLoai cttl ON cttl.idSach = s.idSach
	--	INNER JOIN TheLoai tl ON tl.idTheLoai = cttl.idTheLoai
	--	WHERE tl.tenTheLoai like '%'+@keyWord+'%'
	--END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_checkExistsBook]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_checkExistsBook]
	@idSach varchar(40), @tenSach nvarchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Sach s WHERE s.idSach = @idSach AND s.tenSach = @tenSach
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ClickTheLoaiShowSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_ClickTheLoaiShowSach]
	@tenTheLoai nvarchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @tenTheLoai = N'Tất Cả'
	BEGIN
		SELECT DISTINCT Sach.idSach, Sach.tenSach, Sach.tenTacGia, Sach.nhaXuatBan, Sach.namXuatBan, Sach.soTrang, Sach.soLuong, Sach.danhGia, Sach.createdAt, Sach.modifiedAt FROM TheLoai INNER JOIN ChiTietTheLoai ON ChiTietTheLoai.idTheLoai = TheLoai.idTheLoai INNER JOIN Sach ON Sach.idSach = ChiTietTheLoai.idSach
	END
	ELSE 
	BEGIN
		SELECT DISTINCT Sach.idSach, Sach.tenSach, Sach.tenTacGia, Sach.nhaXuatBan, Sach.namXuatBan, Sach.soTrang, Sach.soLuong, Sach.danhGia, Sach.createdAt, Sach.modifiedAt FROM TheLoai INNER JOIN ChiTietTheLoai ON ChiTietTheLoai.idTheLoai = TheLoai.idTheLoai INNER JOIN Sach ON Sach.idSach = ChiTietTheLoai.idSach
		WHERE TheLoai.tenTheLoai = @tenTheLoai
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_DoneXacNhanYeuCau]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_DoneXacNhanYeuCau]
	@idYC int, @tenSach nvarchar(40), @tenTacGia nvarchar(40), @soLuong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO YeuCauDuocXacNhan (idYCXN, tenSach, tenTacGia, soLuong) VALUES(@idYC, @tenSach, @tenTacGia, @soLuong)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_EditInfo]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_EditInfo]
	@idTV varchar(40), @Fname nvarchar(40), @Lname nvarchar(40), @Birthday date,
	@Email varchar(40), @Phone varchar(40), @Bank varchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE ThanhVien
	SET Fname = @Fname,
		Lname = @Lname,
		Birthday = @Birthday,
		Email = @Email,
		Phone = @Phone,
		Bank = @Bank
	WHERE idThanhVien = @idTV
END
GO
/****** Object:  StoredProcedure [dbo].[USP_getAccountUser]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_getAccountUser]
	@idThe varchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT tv.idThanhVien, (tv.Fname + tv.Lname) as FullName, tv.Birthday, tv.Email, tv.Phone, tv.Bank, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan, Mode.Role FROM ThanhVien tv
	INNER JOIN TheThuVien ttv ON ttv.idThanhVien = tv.idThanhVien
	INNER JOIN Mode ON Mode.idMode = tv.Mode
	WHERE ttv.idThe = @idThe;
END
GO
/****** Object:  StoredProcedure [dbo].[USP_getIdSachPlaceHolder]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_getIdSachPlaceHolder]
	@idSach varchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Sach
	WHERE idSach LIKE @idSach+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[USP_getListBookUC]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_getListBookUC]
	@condition nvarchar(40), @keyword nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @keyword = ''
	BEGIN
		SELECT * FROM Sach 
		return
	END
    -- Insert statements for procedure here
	if @condition = N'Tên Sách'
	BEGIN
		SELECT * FROM Sach s
		WHERE s.tenSach like '%'+@keyword+'%'
	END
	if @condition = N'Thể Loại'
	BEGIN
		SELECT * FROM Sach s
		INNER JOIN ChiTietTheLoai cttl ON cttl.idSach = s.idSach
		INNER JOIN TheLoai tl ON tl.idTheLoai = cttl.idTheLoai
		WHERE tl.tenTheLoai like '%'+@keyword+'%'
	END

	if @condition = N'Tác Giả'
	BEGIN
		SELECT * FROM Sach s
		WHERE s.tenTacGia like '%'+@keyword+'%'
	END

	if @condition = N'Nhà Xuất Bản'
	BEGIN
		SELECT * FROM Sach s
		WHERE s.nhaXuatBan like '%'+@keyword+'%'
	END

END
GO
/****** Object:  StoredProcedure [dbo].[USP_getListMuonSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_getListMuonSach]
	@idThe varchar(40) = null, @idMuonSach varchar(40) = null
AS
BEGIN

	SELECT dsm.idMuonSach, dsm.idThe, s.idSach, s.tenSach, s.tenTacGia, ctms.soLuong, ctms.ngayMuon, ctms.ngayHenTra FROM ChiTietMuonSach ctms
	INNER JOIN DanhSachMuon dsm ON dsm.idMuonSach = ctms.idMuonSach
	INNER JOIN Sach s ON s.idSach = ctms.idSach
	WHERE dsm.idMuonSach = ISNULL(@idMuonSach, dsm.idMuonSach) AND dsm.idThe = ISNULL(@idThe, dsm.idThe)

END
GO
/****** Object:  StoredProcedure [dbo].[USP_getListMuonTra]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_getListMuonTra]
	@day varchar(40), @month varchar(40), @year varchar(40), @op nvarchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	IF @day = '' SET @day = null
	IF @month = '' SET @month = null
	IF @year = '' SET @year = null
	IF @op = 'MUONSACH'
	BEGIN
		SELECT * FROM ChiTietMuonSach ctms
		INNER JOIN Sach s on s.idSach = ctms.idSach
		WHERE DAY(ctms.ngayMuon) = ISNULL(@day, DAY(ctms.ngayMuon))
			AND MONTH(ctms.ngayMuon) = ISNULL(@month, MONTH(ctms.ngayMuon))
			AND YEAR(ctms.ngayMuon) = ISNULL(@year, YEAR(ctms.ngayMuon))
	END
	ELSE IF @op = 'TRASACH'
	BEGIN
		SELECT * FROM ChiTietTraSach ctts
		INNER JOIN Sach s on s.idSach = ctts.idSach
		WHERE DAY(ctts.ngayTra) = ISNULL(@day, DAY(ctts.ngayTra))
			AND MONTH(ctts.ngayTra) = ISNULL(@month, MONTH(ctts.ngayTra))
			AND YEAR(ctts.ngayTra) = ISNULL(@year, YEAR(ctts.ngayTra))
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_getSachWithId]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_getSachWithId]
	@idSach varchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Sach
	WHERE idSach = @idSach;
END
GO
/****** Object:  StoredProcedure [dbo].[USP_getTheLoaiFromIdSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[USP_getTheLoaiFromIdSach]
	@idSach varchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT tl.idTheLoai, tl.tenTheLoai, cttl.idSach FROM ChiTietTheLoai cttl
	INNER JOIN TheLoai tl ON tl.idTheLoai = cttl.idTheLoai
	WHERE cttl.idSach = @idSach
END
GO
/****** Object:  StoredProcedure [dbo].[USP_getUserWithId]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_getUserWithId]
	-- Add the parameters for the stored procedure here
	@idUser varchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 

	SELECT tv.idThanhVien, tv.Fname, tv.Lname, tv.Birthday, tv.Email, tv.Phone, tv.Bank, tv.Mode, Mode.Role, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan FROM ThanhVien tv
	INNER JOIN TheThuVien ttv ON ttv.idThanhVien = tv.idThanhVien
	INNER JOIN Mode ON Mode.idMode = tv.Mode
	WHERE tv.idThanhVien = @idUser
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBook]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_InsertBook]
	@idSach varchar(40), @tenSach nvarchar(40), @tenTacGia nvarchar(40), @nhaXuatBan nvarchar(40), @namXuatBan int, @soTrang int, @soLuong int, @op nvarchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @op = N'YES'
    BEGIN
		DECLARE @num int = 100
		WHILE EXISTS (SELECT * FROM Sach s WHERE s.idSach = @idSach AND s.tenSach = @tenSach)
		BEGIN
			SET @idSach = @idSach + '' + @num
			SET @num = @num + 1
		END
		INSERT INTO Sach (idSach, tenSach, tenTacGia, nhaXuatBan, namXuatBan, soTrang, soLuong) VALUES (@idSach, @tenSach, @tenTacGia, @nhaXuatBan, @namXuatBan, @soTrang, @soLuong)
	END

	ELSE IF @op = N'NO'
	BEGIN
		UPDATE SACH
		SET tenSach = @tenSach, tenTacGia = @tenTacGia, nhaXuatBan = @nhaXuatBan, namXuatBan = @namXuatBan, soTrang = @soTrang, soLuong = @soLuong, modifiedAt = GETDATE()
		WHERE idSach = @idSach
	END

	ELSE 
	BEGIN
		ROLLBACK TRAN
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ListUserWithMod]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_ListUserWithMod]
	-- Add the parameters for the stored procedure here
	@ModRole nvarchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   if @ModRole = 'ALL1' 
   BEGIN
	 SELECT tv.idThanhVien, tv.Fname, tv.Lname, tv.Birthday, tv.Email, tv.Phone, tv.Bank, tv.Mode, Mode.Role, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan FROM ThanhVien tv
	INNER JOIN TheThuVien ttv ON ttv.idThanhVien = tv.idThanhVien
	INNER JOIN Mode ON Mode.idMode = tv.Mode
   END
   ELSE IF @ModRole = N'EMPLOYEE'
   BEGIN
	SELECT tv.idThanhVien, tv.Fname, tv.Lname, tv.Birthday, tv.Email, tv.Phone, tv.Bank, tv.Mode, Mode.Role, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan FROM ThanhVien tv
	INNER JOIN TheThuVien ttv ON ttv.idThanhVien = tv.idThanhVien
	INNER JOIN Mode ON Mode.idMode = tv.Mode
	WHERE Mode.Role = @ModRole
   END
   else 
   BEGIN
	SELECT tv.idThanhVien, tv.Fname, tv.Lname, tv.Birthday, tv.Email, tv.Phone, tv.Bank, tv.Mode, Mode.Role, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan FROM ThanhVien tv
	INNER JOIN TheThuVien ttv ON ttv.idThanhVien = tv.idThanhVien
	INNER JOIN Mode ON Mode.idMode = tv.Mode
	WHERE Mode.idMode = 5 OR Mode.idMode = 3 OR Mode.idMode = 4
   END

   PRINT 'Hello'
END
GO
/****** Object:  StoredProcedure [dbo].[USP_searchUser]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_searchUser]
	@key nvarchar(100), @op nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    if(@op = N'Theo số thẻ')
	BEGIN

		SELECT tv.idThanhVien, tv.Fname, tv.Lname, tv.Birthday, tv.Email, tv.Phone, tv.Bank, tv.Mode, Mode.Role, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan FROM ThanhVien tv
		INNER JOIN TheThuVien ttv ON ttv.idThanhVien = tv.idThanhVien
		INNER JOIN Mode ON Mode.idMode = tv.Mode
		WHERE ttv.idThe = @key
	END

	ELSE IF (@op = N'Theo quyền truy cập')
	BEGIN
		SELECT tv.idThanhVien, tv.Fname, tv.Lname, tv.Birthday, tv.Email, tv.Phone, tv.Bank, tv.Mode, Mode.Role, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan FROM ThanhVien tv
		INNER JOIN TheThuVien ttv ON ttv.idThanhVien = tv.idThanhVien
		INNER JOIN Mode ON Mode.idMode = tv.Mode
		WHERE tv.Mode = @key
	END

	ELSE IF @op = N'Theo số điện thoại'
	BEGIN
		SELECT tv.idThanhVien, tv.Fname, tv.Lname, tv.Birthday, tv.Email, tv.Phone, tv.Bank, tv.Mode, Mode.Role, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan FROM ThanhVien tv
		INNER JOIN TheThuVien ttv ON ttv.idThanhVien = tv.idThanhVien
		INNER JOIN Mode ON Mode.idMode = tv.Mode
		WHERE tv.Phone = @key
	END

	ELSE IF @op = N'Theo tên'
	BEGIN
		SELECT tv.idThanhVien, tv.Fname, tv.Lname, tv.Birthday, tv.Email, tv.Phone, tv.Bank, tv.Mode, Mode.Role, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan FROM ThanhVien tv
		INNER JOIN TheThuVien ttv ON ttv.idThanhVien = tv.idThanhVien
		INNER JOIN Mode ON Mode.idMode = tv.Mode
		WHERE tv.Fname like '%'+@key+'%' or tv.Lname like '%'+@key+'%'
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SearchXacNhanYeuCauSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_SearchXacNhanYeuCauSach]
	@keyword nvarchar(100), @op nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	IF @op = N'ID Yêu cầu'
	BEGIN
		SELECT * FROM YeuCauDuocXacNhan
		WHERE idYCXN = @keyword
	END
	
	ELSE IF @op = N'Tên sách'
	BEGIN
		SELECT * FROM YeuCauDuocXacNhan ycs
		WHERE ycs.tenSach like '%'+@keyword+'%'
	END
	ELSE IF @op = N'Tác giả'
	BEGIN
		SELECT * FROM YeuCauDuocXacNhan ycs
		WHERE ycs.tenTacGia like '%'+@keyword+'%'
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SearchYeuCauSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_SearchYeuCauSach]
	@keyword nvarchar(100), @op nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	IF @op = N'ID Yêu cầu'
	BEGIN
		SELECT * FROM YeuCauSach
		WHERE idYC = @keyword
	END
	
	ELSE IF @op = N'Tên sách'
	BEGIN
		SELECT * FROM YeuCauSach ycs
		WHERE ycs.tenSach like '%'+@keyword+'%'
	END
	ELSE IF @op = N'Tác giả'
	BEGIN
		SELECT * FROM YeuCauSach ycs
		WHERE ycs.tenTacGia like '%'+@keyword+'%'
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SoSachMuonCuaUser]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_SoSachMuonCuaUser]
	@idThe varchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ctms.idCTM, ctms.idMuonSach, ctms.idSach, s.tenSach, ctms.soLuong, ctms.daTra, ctms.ngayMuon, ctms.ngayHenTra, ctms.soLanGiaHan FROM DanhSachMuon dsm
	INNER JOIN ChiTietMuonSach ctms ON ctms.idMuonSach = dsm.idMuonSach
	INNER JOIN Sach s on s.idSach = ctms.idSach
	WHERE dsm.idThe = @idThe AND ctms.tinhTrang = 0
END
GO
/****** Object:  StoredProcedure [dbo].[USP_TraSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_TraSach]
	@idCTM int, @soLuongTra int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @idSach varchar(40)
	DECLARE @ngayHenTra datetime

	SELECT @idSach = ctms.idSach, @ngayHenTra = ctms.ngayHenTra 
	FROM ChiTietMuonSach ctms
	WHERE ctms.idCTM = @idCTM

	DECLARE @tienPhat int = 0
	IF GETDATE() > @ngayHenTra
	BEGIN
		SET @tienPhat = ABS(DATEDIFF(DAY,GETDATE(), @ngayHenTra)) * 10
	END

	INSERT INTO ChiTietTraSach (idCTM, idSach, soLuong, ngayTra, soTienPhat) VALUES (@idCTM, @idSach, @soLuongTra, GETDATE(), @tienPhat)


END
GO
/****** Object:  StoredProcedure [dbo].[USP_userLogin]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_userLogin]
	-- Add the parameters for the stored procedure here
	@username varchar(40), @pass varchar(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT tv.idThanhVien, tv.Fname, tv.Lname, tv.Birthday, tv.Email, tv.Phone, tv.Bank, tv.Mode, Mode.Role, ttv.idThe, ttv.Password, ttv.NgayDangKy, ttv.NgayHetHan FROM TheThuVien ttv
	INNER JOIN ThanhVien tv ON tv.idThanhVien = ttv.idThanhVien
	INNER JOIN Mode ON Mode.idMode = tv.Mode
	WHERE ttv.idThe = @username AND ttv.Password = @pass

END
GO
/****** Object:  Trigger [dbo].[TRG_MuonSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[TRG_MuonSach]
	ON [dbo].[ChiTietMuonSach]
	AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @idSach varchar(40)
	DECLARE @soLuong int = 0

	SELECT @idSach =i.idSach, @soLuong = i.soLuong FROM inserted i

	UPDATE Sach
	SET soLuong -= @soLuong
	WHERE idSach = @idSach
END
GO
ALTER TABLE [dbo].[ChiTietMuonSach] ENABLE TRIGGER [TRG_MuonSach]
GO
/****** Object:  Trigger [dbo].[TRG_UserTraSach]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TRG_UserTraSach]
ON [dbo].[ChiTietTraSach]
AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @soLuongTra int = 0
	DECLARE @idSach varchar(40)
	DECLARE @idTra int
	SELECT @idSach = i.idSach, @idTra = i.idCTM FROM inserted i

	SELECT @soLuongTra = SUM(ctms.soLuong) FROM ChiTietTraSach ctms
	WHERE ctms.idCTM = @idTra

	UPDATE ChiTietMuonSach
	SET daTra += @soLuongTra
	WHERE idCTM = @idTra

	UPDATE ChiTietMuonSach
	SET tinhTrang = 1
	WHERE daTra = soLuong

	UPDATE Sach
	SET soLuong += @soLuongTra
	WHERE idSach = @idSach
END
GO
ALTER TABLE [dbo].[ChiTietTraSach] ENABLE TRIGGER [TRG_UserTraSach]
GO
/****** Object:  Trigger [dbo].[trg_deleteUser]    Script Date: 7/21/2023 10:54:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_deleteUser]
   ON  [dbo].[ThanhVien]
   INSTEAD OF DELETE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	BEGIN TRY
		DECLARE @idUser varchar(40)

		SELECT @idUser = idThanhVien FROM deleted d
	
		DELETE FROM TheThuVien 
		WHERE idThanhVien = @idUser
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

END
GO
ALTER TABLE [dbo].[ThanhVien] ENABLE TRIGGER [trg_deleteUser]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ThanhVien', @level2type=N'INDEX',@level2name=N'IX_DocGia_Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ThanhVien', @level2type=N'INDEX',@level2name=N'IX_DocGia_Phone'
GO
