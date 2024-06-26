USE [master]
GO
/****** Object:  Database [Nhom11]    Script Date: 08/06/2024 11:41:44 CH ******/
CREATE DATABASE [Nhom11]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Nhom11__Data', FILENAME = N'E:\SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Nhom11_.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Nhom11__Log', FILENAME = N'E:\SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Nhom11_.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Nhom11] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Nhom11].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Nhom11] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Nhom11] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Nhom11] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Nhom11] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Nhom11] SET ARITHABORT OFF 
GO
ALTER DATABASE [Nhom11] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Nhom11] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Nhom11] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Nhom11] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Nhom11] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Nhom11] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Nhom11] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Nhom11] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Nhom11] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Nhom11] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Nhom11] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Nhom11] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Nhom11] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Nhom11] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Nhom11] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Nhom11] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Nhom11] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Nhom11] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Nhom11] SET  MULTI_USER 
GO
ALTER DATABASE [Nhom11] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Nhom11] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Nhom11] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Nhom11] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Nhom11] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Nhom11] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Nhom11] SET QUERY_STORE = ON
GO
ALTER DATABASE [Nhom11] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Nhom11]
GO
/****** Object:  Table [dbo].[tblHopdong]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHopdong](
	[Mahopdong] [nvarchar](10) NOT NULL,
	[Makhachhang] [nvarchar](10) NOT NULL,
	[Manhanvien] [nvarchar](10) NOT NULL,
	[Mabaibao] [nvarchar](10) NOT NULL,
	[Ngaykyket] [date] NULL,
	[Ngaybatdau] [date] NULL,
	[Ngayketthuc] [date] NULL,
	[Tongtien] [float] NULL,
 CONSTRAINT [PK_tblHoadon] PRIMARY KEY CLUSTERED 
(
	[Mahopdong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachhang]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachhang](
	[Makhachhang] [nvarchar](10) NOT NULL,
	[Tenkhachhang] [nvarchar](50) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Dienthoai] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[MaLVHD] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblKhachhang] PRIMARY KEY CLUSTERED 
(
	[Makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanvien](
	[Manhanvien] [nvarchar](10) NOT NULL,
	[Tennhanvien] [nvarchar](50) NOT NULL,
	[Maphongban] [nvarchar](10) NOT NULL,
	[Machucvu] [nvarchar](10) NOT NULL,
	[Matrinhdo] [nvarchar](10) NOT NULL,
	[Machuyenmon] [nvarchar](10) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Gioitinh] [nvarchar](10) NOT NULL,
	[Dienthoai] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Ngaysinh] [date] NULL,
 CONSTRAINT [PK_tblNhanvien] PRIMARY KEY CLUSTERED 
(
	[Manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Thongtinhopdong]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Thongtinhopdong] as
select Mahopdong, Tenkhachhang, Tennhanvien, Ngaykyket, Ngaybatdau, Ngayketthuc
from tblHopdong as a
join tblKhachhang as b
on a.Makhachhang = b.Makhachhang
join tblNhanvien as c
on a.Manhanvien = c.Manhanvien
GO
/****** Object:  Table [dbo].[tblChitiethopdong]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChitiethopdong](
	[Machitiet] [nvarchar](10) NOT NULL,
	[Mahopdong] [nvarchar](10) NOT NULL,
	[Maquangcao] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblChitiethoadon] PRIMARY KEY CLUSTERED 
(
	[Machitiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQuangcao]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuangcao](
	[Maquangcao] [nvarchar](10) NOT NULL,
	[Tenquangcao] [nvarchar](50) NOT NULL,
	[Noidung] [nvarchar](250) NOT NULL,
	[Dongia] [float] NOT NULL,
	[Hinhanh] [nvarchar](255) NULL,
 CONSTRAINT [PK_tblQuangcao] PRIMARY KEY CLUSTERED 
(
	[Maquangcao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Tongtienhopdong]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Tongtienhopdong] as
select a.Mahopdong, SUM(Dongia) as Tongtien
from tblHopdong as a
join tblChitiethopdong as b
on a.Mahopdong = b.Mahopdong
join tblQuangcao as c
on b.Maquangcao = c.Maquangcao
group by a.Mahopdong
GO
/****** Object:  Table [dbo].[tblBaibao]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBaibao](
	[Mabaibao] [nvarchar](10) NOT NULL,
	[Matacgia] [nvarchar](10) NOT NULL,
	[Matheloai] [nvarchar](10) NULL,
	[Manhanvien] [nvarchar](10) NULL,
	[Tieude] [nvarchar](255) NOT NULL,
	[Noidung] [nvarchar](1000) NOT NULL,
	[Mota] [nvarchar](255) NOT NULL,
	[Ngaydang] [date] NOT NULL,
 CONSTRAINT [PK_tblBaibao] PRIMARY KEY CLUSTERED 
(
	[Mabaibao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTheloai]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTheloai](
	[Matheloai] [nvarchar](10) NOT NULL,
	[Tentheloai] [nvarchar](50) NOT NULL,
	[Nhuanbut] [float] NOT NULL,
 CONSTRAINT [PK_tblTheloai] PRIMARY KEY CLUSTERED 
(
	[Matheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Nhuanbuthopdong]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Nhuanbuthopdong] as
select Mahopdong, Nhuanbut
from tblHopdong as a
join tblBaibao as b
on a.Mabaibao = b.Mabaibao
join tblTheloai as c
on b.Matheloai = c.Matheloai
GO
/****** Object:  View [dbo].[Baocaodoanhthu]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Baocaodoanhthu] as
select a.Mahopdong, Tenkhachhang, Tennhanvien, Ngaykyket, Ngaybatdau, Ngayketthuc, DATEDIFF(day, Ngaybatdau, Ngayketthuc) * Tongtien as Doanhthu
from Thongtinhopdong as a
join Tongtienhopdong as b
on a.Mahopdong = b.Mahopdong
GO
/****** Object:  View [dbo].[Baocaoloinhuan]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Baocaoloinhuan] as
select a.Mahopdong, a.Ngaykyket, Doanhthu, Nhuanbut, Doanhthu - Nhuanbut as Loinhuan
from Thongtinhopdong as a
join Nhuanbuthopdong as b
on a.Mahopdong = b.Mahopdong
join Baocaodoanhthu as c
on a.Mahopdong = c.Mahopdong
GO
/****** Object:  View [dbo].[Hopdongquangcao]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SELECT TOP (1000) [Mahopdong]
--      ,[Tenkhachhang]
--      ,[Tennhanvien]
--      ,[Ngaykyket]
--      ,[Ngaybatdau]
--      ,[Ngayketthuc]
--      ,[Doanhthu]
--  FROM [Nhom11_].[dbo].[Baocaodoanhthu]

--select a.Mahopdong, Tenkhachhang, Tennhanvien, Ngaykyket, Ngaybatdau, Ngayketthuc, DATEDIFF(day, Ngaybatdau, Ngayketthuc) * Tongtien as Doanhthu
--from Thongtinhopdong as a
--join Tongtienhopdong as b
--on a.Mahopdong = b.Mahopdong

--select a.Mahopdong, d.Mabaibao, Ngaykyket, c.Manhanvien, b.Makhachhang, DATEDIFF(day, Ngaybatdau, Ngayketthuc) * e.Tongtien as Tongtien
--from tblHopdong as a
--join tblKhachhang as b
--on a.Makhachhang = b.Makhachhang
--join tblNhanvien as c
--on a.Manhanvien = c.Manhanvien
--join tblBaibao as d
--on a.Mabaibao = d.Mabaibao
--join Tongtienhopdong as e
--on a.Mahopdong = e.Mahopdong

--select Machitiet, a.Maquangcao, Noidung, Dongia
--from tblChitiethopdong as a
--join tblHopdong as b
--on a.Mahopdong = b.Mahopdong
--join tblQuangcao as c
--on a.Maquangcao = c.Maquangcao

--select * from Baocaoloinhuan

create view [dbo].[Hopdongquangcao] as
select a.Mahopdong, d.Mabaibao, Ngaykyket, c.Manhanvien, b.Makhachhang, e.Tongtien
from tblHopdong as a
join tblKhachhang as b
on a.Makhachhang = b.Makhachhang
join tblNhanvien as c
on a.Manhanvien = c.Manhanvien
join tblBaibao as d
on a.Mabaibao = d.Mabaibao
join Tongtienhopdong as e
on a.Mahopdong = e.Mahopdong
GO
/****** Object:  View [dbo].[CTHD]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CTHD] AS
SELECT 
    cthd.Machitiet, 
    cthd.Maquangcao, 
    qc.Dongia, 
    (qc.Dongia * DATEDIFF(day, hd.Ngaybatdau, hd.Ngayketthuc)) AS ThanhTien,
    cthd.Mahopdong
FROM 
    tblChitiethopdong cthd
JOIN 
    tblQuangcao qc ON cthd.Maquangcao = qc.Maquangcao
JOIN 
    tblHopdong hd ON cthd.Mahopdong = hd.Mahopdong
GO
/****** Object:  View [dbo].[HopdongTongtien]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HopdongTongtien] AS
SELECT 
    hd.Mahopdong, 
    SUM(cthd.ThanhTien) AS Tongtien
FROM 
    [CTHD] cthd
JOIN 
    tblHopdong hd ON cthd.Mahopdong = hd.Mahopdong
GROUP BY 
    hd.Mahopdong
GO
/****** Object:  View [dbo].[Hopdong]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Hopdong] as
select a.Mahopdong, d.Mabaibao, Ngaykyket, c.Manhanvien, b.Makhachhang, e.Tongtien
from tblHopdong as a
join tblKhachhang as b
on a.Makhachhang = b.Makhachhang
join tblNhanvien as c
on a.Manhanvien = c.Manhanvien
join tblBaibao as d
on a.Mabaibao = d.Mabaibao
join HopdongTongtien as e
on a.Mahopdong = e.Mahopdong
GO
/****** Object:  Table [dbo].[tblChucvu]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChucvu](
	[Machucvu] [nvarchar](10) NOT NULL,
	[Tenchucvu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblChucvu] PRIMARY KEY CLUSTERED 
(
	[Machucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChuyenmon]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChuyenmon](
	[Machuyenmon] [nvarchar](10) NOT NULL,
	[Tenchuyenmon] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblChuyenmon] PRIMARY KEY CLUSTERED 
(
	[Machuyenmon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLVHD]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLVHD](
	[MaLVHD] [nvarchar](10) NOT NULL,
	[TenLVHD] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLVHD] PRIMARY KEY CLUSTERED 
(
	[MaLVHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanbai]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanbai](
	[Manhanbai] [nvarchar](10) NOT NULL,
	[Matacgia] [nvarchar](10) NOT NULL,
	[Mabaibao] [nvarchar](10) NOT NULL,
	[Manhanvien] [nvarchar](10) NOT NULL,
	[Ngaynhanbai] [date] NOT NULL,
	[Nhuanbut] [float] NOT NULL,
 CONSTRAINT [PK_tblNhanbai] PRIMARY KEY CLUSTERED 
(
	[Manhanbai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhongban]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhongban](
	[Maphongban] [nvarchar](10) NOT NULL,
	[Tenphongban] [nvarchar](10) NOT NULL,
	[Dienthoai] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tblPhongban] PRIMARY KEY CLUSTERED 
(
	[Maphongban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTacgia]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTacgia](
	[Matacgia] [nvarchar](10) NOT NULL,
	[Tentacgia] [nvarchar](50) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Dienthoai] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTacgia] PRIMARY KEY CLUSTERED 
(
	[Matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTrinhdo]    Script Date: 08/06/2024 11:41:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTrinhdo](
	[Matrinhdo] [nvarchar](10) NOT NULL,
	[Tentrinhdo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTrinhdo] PRIMARY KEY CLUSTERED 
(
	[Matrinhdo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblBaibao]  WITH CHECK ADD  CONSTRAINT [FK_tblBaibao_tblTacgia] FOREIGN KEY([Matacgia])
REFERENCES [dbo].[tblTacgia] ([Matacgia])
GO
ALTER TABLE [dbo].[tblBaibao] CHECK CONSTRAINT [FK_tblBaibao_tblTacgia]
GO
ALTER TABLE [dbo].[tblBaibao]  WITH CHECK ADD  CONSTRAINT [FK_tblBaibao_tblTheloai] FOREIGN KEY([Matheloai])
REFERENCES [dbo].[tblTheloai] ([Matheloai])
GO
ALTER TABLE [dbo].[tblBaibao] CHECK CONSTRAINT [FK_tblBaibao_tblTheloai]
GO
ALTER TABLE [dbo].[tblChitiethopdong]  WITH CHECK ADD  CONSTRAINT [FK_tblChitiethoadon_tblQuangcao] FOREIGN KEY([Maquangcao])
REFERENCES [dbo].[tblQuangcao] ([Maquangcao])
GO
ALTER TABLE [dbo].[tblChitiethopdong] CHECK CONSTRAINT [FK_tblChitiethoadon_tblQuangcao]
GO
ALTER TABLE [dbo].[tblChitiethopdong]  WITH CHECK ADD  CONSTRAINT [FK_tblChitiethopdong_tblHopdong] FOREIGN KEY([Mahopdong])
REFERENCES [dbo].[tblHopdong] ([Mahopdong])
GO
ALTER TABLE [dbo].[tblChitiethopdong] CHECK CONSTRAINT [FK_tblChitiethopdong_tblHopdong]
GO
ALTER TABLE [dbo].[tblHopdong]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadon_tblBaibao] FOREIGN KEY([Mabaibao])
REFERENCES [dbo].[tblBaibao] ([Mabaibao])
GO
ALTER TABLE [dbo].[tblHopdong] CHECK CONSTRAINT [FK_tblHoadon_tblBaibao]
GO
ALTER TABLE [dbo].[tblHopdong]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadon_tblKhachhang] FOREIGN KEY([Makhachhang])
REFERENCES [dbo].[tblKhachhang] ([Makhachhang])
GO
ALTER TABLE [dbo].[tblHopdong] CHECK CONSTRAINT [FK_tblHoadon_tblKhachhang]
GO
ALTER TABLE [dbo].[tblHopdong]  WITH CHECK ADD  CONSTRAINT [FK_tblHopdong_tblNhanvien] FOREIGN KEY([Manhanvien])
REFERENCES [dbo].[tblNhanvien] ([Manhanvien])
GO
ALTER TABLE [dbo].[tblHopdong] CHECK CONSTRAINT [FK_tblHopdong_tblNhanvien]
GO
ALTER TABLE [dbo].[tblKhachhang]  WITH CHECK ADD  CONSTRAINT [FK_tblKhachhang_tblLVHD] FOREIGN KEY([MaLVHD])
REFERENCES [dbo].[tblLVHD] ([MaLVHD])
GO
ALTER TABLE [dbo].[tblKhachhang] CHECK CONSTRAINT [FK_tblKhachhang_tblLVHD]
GO
ALTER TABLE [dbo].[tblNhanbai]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanbai_tblBaibao] FOREIGN KEY([Mabaibao])
REFERENCES [dbo].[tblBaibao] ([Mabaibao])
GO
ALTER TABLE [dbo].[tblNhanbai] CHECK CONSTRAINT [FK_tblNhanbai_tblBaibao]
GO
ALTER TABLE [dbo].[tblNhanbai]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanbai_tblNhanvien] FOREIGN KEY([Manhanvien])
REFERENCES [dbo].[tblNhanvien] ([Manhanvien])
GO
ALTER TABLE [dbo].[tblNhanbai] CHECK CONSTRAINT [FK_tblNhanbai_tblNhanvien]
GO
ALTER TABLE [dbo].[tblNhanbai]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanbai_tblTacgia] FOREIGN KEY([Matacgia])
REFERENCES [dbo].[tblTacgia] ([Matacgia])
GO
ALTER TABLE [dbo].[tblNhanbai] CHECK CONSTRAINT [FK_tblNhanbai_tblTacgia]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblChucvu] FOREIGN KEY([Machucvu])
REFERENCES [dbo].[tblChucvu] ([Machucvu])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblChucvu]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblChuyenmon] FOREIGN KEY([Machuyenmon])
REFERENCES [dbo].[tblChuyenmon] ([Machuyenmon])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblChuyenmon]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblPhongban] FOREIGN KEY([Maphongban])
REFERENCES [dbo].[tblPhongban] ([Maphongban])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblPhongban]
GO
ALTER TABLE [dbo].[tblNhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanvien_tblTrinhdo] FOREIGN KEY([Matrinhdo])
REFERENCES [dbo].[tblTrinhdo] ([Matrinhdo])
GO
ALTER TABLE [dbo].[tblNhanvien] CHECK CONSTRAINT [FK_tblNhanvien_tblTrinhdo]
GO
USE [master]
GO
ALTER DATABASE [Nhom11] SET  READ_WRITE 
GO
