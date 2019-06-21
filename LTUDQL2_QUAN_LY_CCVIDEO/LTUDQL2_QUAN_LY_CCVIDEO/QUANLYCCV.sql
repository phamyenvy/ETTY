/*
 Navicat Premium Data Transfer

 Source Server         : DESKTOP-CCFAEH9
 Source Server Type    : SQL Server
 Source Server Version : 11002100
 Source Catalog        : QuanLyCCV
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 11002100
 File Encoding         : 65001

 Date: 21/06/2019 10:57:04
*/


-- ----------------------------
-- Table structure for CapDoTaiKhoan
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CapDoTaiKhoan]') AND type IN ('U'))
	DROP TABLE [dbo].[CapDoTaiKhoan]
GO

CREATE TABLE [dbo].[CapDoTaiKhoan] (
  [MaCapDo] int  IDENTITY(1,1) NOT NULL,
  [TenCapDo] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [GiaTienDuyTri] int  NULL
)
GO

ALTER TABLE [dbo].[CapDoTaiKhoan] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of CapDoTaiKhoan
-- ----------------------------
SET IDENTITY_INSERT [dbo].[CapDoTaiKhoan] ON
GO

INSERT INTO [dbo].[CapDoTaiKhoan] ([MaCapDo], [TenCapDo], [GiaTienDuyTri]) VALUES (N'1', N'Standard', N'100000')
GO

INSERT INTO [dbo].[CapDoTaiKhoan] ([MaCapDo], [TenCapDo], [GiaTienDuyTri]) VALUES (N'2', N'Premium', N'300000')
GO

INSERT INTO [dbo].[CapDoTaiKhoan] ([MaCapDo], [TenCapDo], [GiaTienDuyTri]) VALUES (N'3', N'VIP', N'1000000')
GO

SET IDENTITY_INSERT [dbo].[CapDoTaiKhoan] OFF
GO


-- ----------------------------
-- Table structure for LoaiVideo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiVideo]') AND type IN ('U'))
	DROP TABLE [dbo].[LoaiVideo]
GO

CREATE TABLE [dbo].[LoaiVideo] (
  [MaLoaiVideo] int  IDENTITY(1,1) NOT NULL,
  [TenLoaiVideo] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[LoaiVideo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of LoaiVideo
-- ----------------------------
SET IDENTITY_INSERT [dbo].[LoaiVideo] ON
GO

INSERT INTO [dbo].[LoaiVideo] ([MaLoaiVideo], [TenLoaiVideo]) VALUES (N'1', N'Action')
GO

INSERT INTO [dbo].[LoaiVideo] ([MaLoaiVideo], [TenLoaiVideo]) VALUES (N'2', N'Animation')
GO

INSERT INTO [dbo].[LoaiVideo] ([MaLoaiVideo], [TenLoaiVideo]) VALUES (N'3', N'Comedy')
GO

INSERT INTO [dbo].[LoaiVideo] ([MaLoaiVideo], [TenLoaiVideo]) VALUES (N'4', N'Fantasy')
GO

INSERT INTO [dbo].[LoaiVideo] ([MaLoaiVideo], [TenLoaiVideo]) VALUES (N'5', N'Horror')
GO

INSERT INTO [dbo].[LoaiVideo] ([MaLoaiVideo], [TenLoaiVideo]) VALUES (N'6', N'Musical')
GO

INSERT INTO [dbo].[LoaiVideo] ([MaLoaiVideo], [TenLoaiVideo]) VALUES (N'7', N'Reenactment of history')
GO

INSERT INTO [dbo].[LoaiVideo] ([MaLoaiVideo], [TenLoaiVideo]) VALUES (N'8', N'Drama')
GO

SET IDENTITY_INSERT [dbo].[LoaiVideo] OFF
GO


-- ----------------------------
-- Table structure for PlayList
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PlayList]') AND type IN ('U'))
	DROP TABLE [dbo].[PlayList]
GO

CREATE TABLE [dbo].[PlayList] (
  [IDProfile] int  NOT NULL,
  [TenPlayList] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [IDVideo] int  NOT NULL,
  [IDPlayList] int  NOT NULL
)
GO

ALTER TABLE [dbo].[PlayList] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of PlayList
-- ----------------------------
INSERT INTO [dbo].[PlayList]  VALUES (N'21', N'MyChill', N'3', N'1')
GO

INSERT INTO [dbo].[PlayList]  VALUES (N'21', N'MyChill', N'5', N'1')
GO

INSERT INTO [dbo].[PlayList]  VALUES (N'21', N'MyChill', N'11', N'1')
GO

INSERT INTO [dbo].[PlayList]  VALUES (N'21', N'mylove', N'12', N'2')
GO

INSERT INTO [dbo].[PlayList]  VALUES (N'21', N'MyChill', N'17', N'1')
GO

INSERT INTO [dbo].[PlayList]  VALUES (N'21', N'mylove', N'17', N'2')
GO

INSERT INTO [dbo].[PlayList]  VALUES (N'21', N'MyChill', N'18', N'1')
GO

INSERT INTO [dbo].[PlayList]  VALUES (N'21', N'mylove', N'19', N'2')
GO


-- ----------------------------
-- Table structure for Profile
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Profile]') AND type IN ('U'))
	DROP TABLE [dbo].[Profile]
GO

CREATE TABLE [dbo].[Profile] (
  [MaProfile] int  IDENTITY(1,1) NOT NULL,
  [TenHienThi] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [AvatarLink] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [TaiKhoan] int  NULL,
  [Status] int  NULL
)
GO

ALTER TABLE [dbo].[Profile] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Profile
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Profile] ON
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'1', N'Vy', N'D:\LTUDQL2\ava1.png', N'2', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'2', N'Truong', N'D:\LTUDQL2\ava2.png', N'2', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'3', N'Thong', N'D:\LTUDQL2\ava3.png', N'2', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'4', N'Xuyen', N'D:\LTUDQL2\ava4.png', N'2', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'5', N'Strangee', N'D:\LTUDQL2\ava1.png', N'9', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'6', N'Steve', N'D:\LTUDQL2\ava2.png', N'9', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'7', N'Scottlang', N'D:\LTUDQL2\ava3.png', N'9', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'8', N'Banner', N'D:\LTUDQL2\ava4.png', N'9', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'9', N'Strange', N'D:\LTUDQL2\ava1.png', N'10', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'10', N'Steve', N'D:\LTUDQL2\ava2.png', N'10', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'11', N'Scottlang', N'D:\LTUDQL2\ava3.png', N'10', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'12', N'Banner', N'D:\LTUDQL2\ava4.png', N'10', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'13', N'Strange', N'D:\LTUDQL2\ava1.png', N'11', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'14', N'Steve', N'D:\LTUDQL2\ava2.png', N'11', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'15', N'Scottlang', N'D:\LTUDQL2\ava3.png', N'11', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'16', N'Banner', N'D:\LTUDQL2\ava4.png', N'11', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'17', N'Strange', N'D:\LTUDQL2\ava1.png', N'12', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'18', N'Steve', N'D:\LTUDQL2\ava2.png', N'12', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'19', N'Scottlang', N'D:\LTUDQL2\ava3.png', N'12', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'20', N'Banner', N'D:\LTUDQL2\ava4.png', N'12', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'21', N'Strange', N'D:\LTUDQL2\ava1.png', N'13', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'22', N'Steve', N'D:\LTUDQL2\ava2.png', N'13', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'23', N'Scottlang', N'D:\LTUDQL2\ava3.png', N'13', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'24', N'Banner', N'D:\LTUDQL2\ava4.png', N'13', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'25', N'Strange', N'D:\LTUDQL2\ava1.png', N'14', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'26', N'Steve', N'D:\LTUDQL2\ava2.png', N'14', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'27', N'Scottlang', N'D:\LTUDQL2\ava3.png', N'14', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'28', N'Banner', N'D:\LTUDQL2\ava4.png', N'14', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'1025', N'Strange', N'D:\LTUDQL2\ava1.png', N'1014', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'1026', N'Steve', N'D:\LTUDQL2\ava2.png', N'1014', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'1027', N'Scottlang', N'D:\LTUDQL2\ava3.png', N'1014', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'1028', N'Banner', N'D:\LTUDQL2\ava4.png', N'1014', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'1029', N'Strange', N'D:\LTUDQL2\ava1.png', N'1015', N'1')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'1030', N'Steve', N'D:\LTUDQL2\ava2.png', N'1015', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'1031', N'Scottlang', N'D:\LTUDQL2\ava3.png', N'1015', N'0')
GO

INSERT INTO [dbo].[Profile] ([MaProfile], [TenHienThi], [AvatarLink], [TaiKhoan], [Status]) VALUES (N'1032', N'Banner', N'D:\LTUDQL2\ava4.png', N'1015', N'0')
GO

SET IDENTITY_INSERT [dbo].[Profile] OFF
GO


-- ----------------------------
-- Table structure for TaiKhoan
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TaiKhoan]') AND type IN ('U'))
	DROP TABLE [dbo].[TaiKhoan]
GO

CREATE TABLE [dbo].[TaiKhoan] (
  [MaTaiKhoan] int  IDENTITY(1,1) NOT NULL,
  [TenTaiKhoan] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [LoaiTaiKhoan] int  NOT NULL,
  [CapDo] int  NULL,
  [NgayHetHan] datetime  NULL,
  [Password] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [TenHienThi] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MaXacNhan] int DEFAULT ((0)) NOT NULL,
  [IDThe] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[TaiKhoan] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of TaiKhoan
-- ----------------------------
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'2', N'mjnhthong1998@gmail.com', N'1', N'1', N'2020-01-30 00:00:00.000', N'68of5XP4iv4=
68of5XP4iv4=
68of5XP4iv4=
68of5XP4iv4=', N'Võ Nguyễn Minh Thông', N'754659', N'0123456789')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'3', N'mjnhthong19981@gmail.com', N'1', N'3', N'2019-05-21 21:54:53.007', N'123', N'Minh Thông', N'0', N'1')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'4', N'mjnhthong19982@gmail.com', N'2', N'2', N'2019-05-21 21:58:13.627', N'123', N'Admin', N'0', N'11233')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'6', N'phamthimylinh@gmail.com', N'1', N'1', N'2019-05-23 18:19:32.987', N'321', N'Linh', N'0', N'21324')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'7', N'a@hd.co', N'1', N'3', N'2019-05-29 09:14:11.083', N'd', N'vy', N'0', N'12')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'8', N'a@ma.com', N'1', N'3', N'2019-05-29 09:22:24.003', N'a', N'aa', N'0', N'21324')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'9', N'loclun@gmail.com', N'1', N'2', N'2019-09-27 19:56:17.600', N'1', N'loc', N'0', N'56')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'10', N'a@gmail.com', N'1', N'2', N'2019-06-01 17:24:38.673', N'xs', N'xs', N'0', N'123344')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'11', N'1660754@students.hcmus.com.vn', N'1', N'3', N'2019-06-04 18:02:55.790', N'1', N'vivi', N'0', N'85236974132')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'12', N'a@amcds.com', N'1', N'3', N'2019-06-04 18:18:13.900', N'a', N'a', N'0', N'123654789528')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'13', N'phamyenvy1998@gmail.com', N'1', N'3', N'2020-02-04 17:00:35.910', N'T1VjQaJFMzA=', N'Vy', N'103966', N'1234554321')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'14', N'admin@gmail.com', N'0', N'1', N'2019-08-14 15:08:12.690', N'68of5XP4iv4=', N'Admin', N'0', N'1234567')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'1014', N'vy@gmail.com', N'1', N'1', N'2019-07-18 19:19:22.207', N'g6zHP7Wbo2g=', N'Vy', N'0', N'123445')
GO

INSERT INTO [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [LoaiTaiKhoan], [CapDo], [NgayHetHan], [Password], [TenHienThi], [MaXacNhan], [IDThe]) VALUES (N'1015', N'test@test.com', N'1', N'3', N'2019-07-20 00:11:19.120', N'68of5XP4iv4=', N'test', N'0', N'12333333')
GO

SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO


-- ----------------------------
-- Table structure for ThanhToan
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ThanhToan]') AND type IN ('U'))
	DROP TABLE [dbo].[ThanhToan]
GO

CREATE TABLE [dbo].[ThanhToan] (
  [MaThanhToan] int  IDENTITY(1,1) NOT NULL,
  [TenThanhToan] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [TaiKhoan] int  NULL,
  [CapDoMua] int  NULL,
  [IDThe] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[ThanhToan] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ThanhToan
-- ----------------------------
SET IDENTITY_INSERT [dbo].[ThanhToan] ON
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'1', N'Võ Nguyễn Minh Thông', N'2', N'1', N'0123456789')
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'2', N'Vy', N'13', N'2', N'44236543')
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'3', N'Admin', N'14', N'1', N'1234567')
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'1003', N'Vy', N'13', N'3', N'3212233')
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'1004', N'Vy', N'13', N'2', N'123331231')
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'1005', N'Vy', N'13', N'3', N'123331231')
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'1006', N'Vy', N'13', N'1', N'123331231')
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'1007', N'Vy', N'13', N'3', N'123331231')
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'1008', N'Vy', N'13', N'2', N'123331231')
GO

INSERT INTO [dbo].[ThanhToan] ([MaThanhToan], [TenThanhToan], [TaiKhoan], [CapDoMua], [IDThe]) VALUES (N'1009', N'Vy', N'13', N'3', N'1234554321')
GO

SET IDENTITY_INSERT [dbo].[ThanhToan] OFF
GO


-- ----------------------------
-- Table structure for The
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[The]') AND type IN ('U'))
	DROP TABLE [dbo].[The]
GO

CREATE TABLE [dbo].[The] (
  [IDCard] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [FirstName] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [LastName] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Code] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[The] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of The
-- ----------------------------
INSERT INTO [dbo].[The]  VALUES (N'', N'', N'', N'')
GO

INSERT INTO [dbo].[The]  VALUES (N'0123456789', N'Vo Nguyen', N'Minh Thong', N'123')
GO

INSERT INTO [dbo].[The]  VALUES (N'098765432', N'vy', N'vy', N'68of5XP4iv4=')
GO

INSERT INTO [dbo].[The]  VALUES (N'1', N'Vo Nguyen', N'Minh Thong', N'1')
GO

INSERT INTO [dbo].[The]  VALUES (N'10041998', N'd', N'd', N'11')
GO

INSERT INTO [dbo].[The]  VALUES (N'11233', N'c', N'cc', N'12')
GO

INSERT INTO [dbo].[The]  VALUES (N'12', N'a', N'a', N'321')
GO

INSERT INTO [dbo].[The]  VALUES (N'123', N'a', N'a', N'1')
GO

INSERT INTO [dbo].[The]  VALUES (N'123331231', N'Pham', N'Vy', N'68of5XP4iv4=')
GO

INSERT INTO [dbo].[The]  VALUES (N'12333333', N'1', N'1', N'g6zHP7Wbo2g=')
GO

INSERT INTO [dbo].[The]  VALUES (N'123344', N'2', N'2', N'12')
GO

INSERT INTO [dbo].[The]  VALUES (N'12341234', N'vy', N'vy', N'68of5XP4iv4=')
GO

INSERT INTO [dbo].[The]  VALUES (N'123445', N'vy', N'vy', N'yDc+b7K4mkY=')
GO

INSERT INTO [dbo].[The]  VALUES (N'1234554321', N'vyvy', N'vvy', N'68of5XP4iv4=')
GO

INSERT INTO [dbo].[The]  VALUES (N'1234567', N'admin', N'admin', N'68of5XP4iv4=')
GO

INSERT INTO [dbo].[The]  VALUES (N'12345675', N'a', N'a', N'12')
GO

INSERT INTO [dbo].[The]  VALUES (N'12345678909', N'vy', N'vy', N'68of5XP4iv4=')
GO

INSERT INTO [dbo].[The]  VALUES (N'1234567898', N'a', N'a', N'258')
GO

INSERT INTO [dbo].[The]  VALUES (N'1236547852', N'vy', N'pham', N'123')
GO

INSERT INTO [dbo].[The]  VALUES (N'123654789528', N'a', N'a', N'123')
GO

INSERT INTO [dbo].[The]  VALUES (N'1258', N'vy', N'd', N'789')
GO

INSERT INTO [dbo].[The]  VALUES (N'21324', N's', N's', N'123')
GO

INSERT INTO [dbo].[The]  VALUES (N'251298', N'v', N'v', N'258')
GO

INSERT INTO [dbo].[The]  VALUES (N'2589632', N'Linh', N'Pham', N'963')
GO

INSERT INTO [dbo].[The]  VALUES (N'258964', N'vy', N'cy', N'12')
GO

INSERT INTO [dbo].[The]  VALUES (N'3212233', N'Vy', N'Vy', N'68of5XP4iv4=')
GO

INSERT INTO [dbo].[The]  VALUES (N'3214', N'qq', N'qq', N'123')
GO

INSERT INTO [dbo].[The]  VALUES (N'321456321', N'v', N'v', N'1')
GO

INSERT INTO [dbo].[The]  VALUES (N'3455', N'123', N'123', N'25')
GO

INSERT INTO [dbo].[The]  VALUES (N'36985147', N'Pham', N'Vy', N'96325871')
GO

INSERT INTO [dbo].[The]  VALUES (N'369852147', N'vyv', N'vy', N'258')
GO

INSERT INTO [dbo].[The]  VALUES (N'44236543', N'vy', N'pham', N'G/5+nACdwGA=')
GO

INSERT INTO [dbo].[The]  VALUES (N'56', N'a', N'a', N'12')
GO

INSERT INTO [dbo].[The]  VALUES (N'657678', N'vy', N'vy', N'68of5XP4iv4=')
GO

INSERT INTO [dbo].[The]  VALUES (N'76543234567876', N'Vy', N'Vy', N'68of5XP4iv4=')
GO

INSERT INTO [dbo].[The]  VALUES (N'789', N'a', N'a', N'1')
GO

INSERT INTO [dbo].[The]  VALUES (N'85236974132', N'vi', N'vu', N'123')
GO

INSERT INTO [dbo].[The]  VALUES (N'85478', N'v', N'v', N'36')
GO

INSERT INTO [dbo].[The]  VALUES (N'9632589632', N'v', N'v', N'112')
GO


-- ----------------------------
-- Table structure for Video
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Video]') AND type IN ('U'))
	DROP TABLE [dbo].[Video]
GO

CREATE TABLE [dbo].[Video] (
  [MaVideo] int  IDENTITY(1,1) NOT NULL,
  [TenVideo] nvarchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [LinkVideo] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MaLoai_Video] int  NULL,
  [LinkImage] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [LinkTrailer] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [CapDoVideo] int  NULL,
  [Like] int DEFAULT ((0)) NOT NULL,
  [Dislike] int DEFAULT ((0)) NOT NULL,
  [NgaySanXuat] datetime  NULL,
  [NgayUpload] datetime  NULL,
  [MoTa] nvarchar(4000) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [LuotXem] int  NULL
)
GO

ALTER TABLE [dbo].[Video] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Video
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Video] ON
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'1', N'Avatar', N'D:\LTUDQL2\1\phim.mp4', N'1', N'D:\Trailer\avatar.jpg', N'D:\LTUDQL2\1\trailer.mp4', N'2', N'3239', N'727', N'2019-04-26 00:00:00.000', N'2009-12-16 00:00:00.000', N'When his brother is killed in a robbery, paraplegic Marine Jake Sully decides to take his place in a mission on the distant world of Pandora. There he learns of greedy corporate figurehead Parker Selfridge''s intentions of driving off the native humanoid "Na''vi" in order to mine for the precious material scattered throughout their rich woodland. In exchange for the spinal surgery that will fix his legs, Jake gathers intel for the cooperating military unit spearheaded by gung-ho Colonel Quaritch, while simultaneously attempting to infiltrate the Na''vi people with the use of an "avatar" identity. While Jake begins to bond with the native tribe and quickly falls in love with the beautiful alien Neytiri, the restless Colonel moves forward with his ruthless extermination tactics, forcing the soldier to take a stand - and fight back in an epic battle for the fate of Pandora.', N'3602555')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'2', N'Men In Black 3', N'D:\LTUDQL2\2\phim.mp4', N'1', N'D:\Trailer\meninblack3.jpg', N'D:\LTUDQL2\2\trailer.mp4', N'1', N'366', N'448', N'2012-01-25 00:00:00.000', N'2012-01-25 00:00:00.000', N'Agent J and Agent K are in charge of protecting the world from the intrigues of extraterrestrial forces. However, Agent J will have to return to the past to collaborate with the young K Agent on a new adventure with breathtaking and risky actions mixed with humorous situations starting ... Star duo Will Smith (Oscar winner) and Tommy Lee Jones, Man in Black 3 have brought audiences love action movies with scenes full of American action. MIB 3 has also received very positive reviews from critics. The film grossed $ 179 million in three months in North American screens.', N'860695')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'3', N'Nerve', N'D:\LTUDQL2\3\phim.mp4', N'1', N'D:\Trailer\nerve.jpg', N'D:\LTUDQL2\3\trailer.mp4', N'1', N'230', N'236', N'2016-07-12 00:00:00.000', N'2016-08-12 00:00:00.000', N'''Nerve'' is about an online dare game, in which people give participants anonymous dares for money. The participants compete with each other to win the grand prize as the dares get tougher. Things get worse when the tasks get increasingly dangerous and lives are at stake.', N'816052')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'4', N'Now You See Me 1', N'D:\LTUDQL2\4\phim.mp4', N'1', N'D:\Trailer\nowyouseeme1.jpg', N'D:\LTUDQL2\4\trailer.mp4', N'2', N'714', N'398', N'2013-05-21 00:00:00.000', N'2013-06-28 00:00:00.000', N'Four magicians each answer a mysterious summons to an obscure address with secrets inside. A year later, they are the Four Horsemen, big time stage illusionists who climax their sold-out Las Vegas show with a bank apparently robbed for real. This puts F.B.I. Agents Dylan Rhodes and Interpol Agent Alma Dray on the case to find out how they did it. However, this mystery proves to be difficult to solve, even with the insights of professional illusion exposer Thaddeus Bradley. What follows is a bizarre investigation where nothing is what it seems to be, with illusions, dark secrets, and hidden agendas galore as all involved are reminded of a great truth in this puzzle: the closer you look, the less you see.', N'3532812')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'5', N'The Matrix', N'D:\LTUDQL2\5\phim.mp4', N'1', N'D:\Trailer\thematrix.jpg', N'D:\LTUDQL2\5\trailer.mp4', N'2', N'3962', N'350', N'1999-03-24 00:00:00.000', N'1999-03-31 00:00:00.000', N'Thomas A. Anderson is a man living two lives. By day he is an average computer programmer and by night a hacker known as Neo. Neo has always questioned his reality, but the truth is far beyond his imagination. Neo finds himself targeted by the police when he is contacted by Morpheus, a legendary computer hacker branded a terrorist by the government. Morpheus awakens Neo to the real world, a ravaged wasteland where most of humanity have been captured by a race of machines that live off of the humans'' body heat and electrochemical energy and who imprison their minds within an artificial reality known as the Matrix. As a rebel against the machines, Neo must return to the Matrix and confront the agents: super-powerful computer programs devoted to snuffing out Neo and the entire human rebellion.', N'3600039')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'6', N'Grave Of The Fireflies', N'D:\LTUDQL2\6\phim.mp4', N'2', N'D:\Trailer\graveofthefireflies.jpg', N'D:\LTUDQL2\6\trailer.mp4', N'2', N'596', N'175', N'1988-04-16 00:00:00.000', N'2017-01-29 00:00:00.000', N'The story of Seita and Satsuko, two young Japanese siblings, living in the declining days of World War II. When an American firebombing separates the two children from their parents, the two siblings must rely completely on one another while they struggle to fight for their survival.', N'4500000')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'7', N'Howl''s Moving Castle', N'D:\LTUDQL2\7\phim.mp4', N'2', N'D:\Trailer\howl''smovingcastle.jpg', N'D:\LTUDQL2\7\trailer.mp4', N'2', N'361', N'234', N'2004-09-05 00:00:00.000', N'2019-02-09 00:00:00.000', N'A love story between an 18-year-old girl named Sophie, cursed by a witch into an old woman''s body, and a magician named Howl. Under the curse, Sophie sets out to seek her fortune, which takes her to Howl''s strange moving castle. In the castle, Sophie meets Howl''s fire demon, named Karishifâ. Seeing that she is under a curse, the demon makes a deal with Sophie--if she breaks the contract he is under with Howl, then Karushifâ will lift the curse that Sophie is under, and she will return to her 18-year-old shape.', N'1958291')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'8', N'My Neighbor Totoro', N'D:\LTUDQL2\8\phim.mp4', N'2', N'D:\Trailer\myneighbortororo.jpg', N'D:\LTUDQL2\8\trailer.mp4', N'2', N'373', N'169', N'1988-04-16 00:00:00.000', N'2013-05-24 00:00:00.000', N'Two young girls, 10-year-old Satsuki and her 4-year-old sister Mei, move into a house in the country with their father to be closer to their hospitalized mother. Satsuki and Mei discover that the nearby forest is inhabited by magical creatures called Totoros (pronounced toe-toe-ro). They soon befriend these Totoros, and have several magical adventures.', N'1489559')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'9', N'Spirited Away', N'D:\LTUDQL2\9\phim.mp4', N'2', N'D:\Trailer\spiritedaway.jpg', N'D:\LTUDQL2\9\trailer.mp4', N'2', N'1047', N'270', N'2001-07-20 00:00:00.000', N'2001-07-20 00:00:00.000', N'Chihiro and her parents are moving to a small Japanese town in the countryside, much to Chihiro''s dismay. On the way to their new home, Chihiro''s father makes a wrong turn and drives down a lonely one-lane road which dead-ends in front of a tunnel. Her parents decide to stop the car and explore the area. They go through the tunnel and find an abandoned amusement park on the other side, with its own little town. When her parents see a restaurant with great-smelling food but no staff, they decide to eat and pay later. However, Chihiro refuses to eat and decides to explore the theme park a bit more. She meets a boy named Haku who tells her that Chihiro and her parents are in danger, and they must leave immediately. She runs to the restaurant and finds that her parents have turned into pigs. In addition, the theme park turns out to be a town inhabited by demons, spirits, and evil gods. At the center of the town is a bathhouse where these creatures go to relax. The owner of the bathhouse is the evil witch Yubaba, who is intent on keeping all trespassers as captive workers, including Chihiro. Chihiro must rely on Haku to save her parents in hopes of returning to their world.', N'2973104')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'10', N'When Marnie Was There', N'D:\LTUDQL2\10\phim.mp4', N'2', N'D:\Trailer\whenmarniewasthere.jpg', N'D:\LTUDQL2\10\trailer.mp4', N'2', N'72', N'167', N'2014-07-19 00:00:00.000', N'2014-07-19 00:00:00.000', N'A 12-year-old girl is sent to the country for health reasons, where she meets an unlikely friend in the form of Marnie, a young girl with long, flowing blonde hair. As the friendship unravels it is possible that Marnie has closer ties to the protagonist than we might expect.', N'313566')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'11', N'Deadpool', N'D:\LTUDQL2\11\phim.mp4', N'3', N'D:\Trailer\deadpool.jpg', N'D:\LTUDQL2\11\trailer.mp4', N'3', N'1372', N'504', N'2016-01-21 00:00:00.000', N'2016-02-12 00:00:00.000', N'This is the origin story of former Special Forces operative turned mercenary Wade Wilson, who after being subjected to a rogue experiment that leaves him with accelerated healing powers, adopts the alter ego Deadpool. Armed with his new abilities and a dark, twisted sense of humor, Deadpool hunts down the man who nearly destroyed his life.', N'12528515')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'12', N'MAMMA MIA 2- Here We Go Again ', N'D:\LTUDQL2\12\phim.mp4', N'3', N'D:\Trailer\mammamia2.jpg', N'D:\LTUDQL2\12\trailer.mp4', N'1', N'675', N'239', N'2018-07-11 00:00:00.000', N'2018-07-20 00:00:00.000', N'Discover Donna''s (Meryl Streep, Lily James) young life, experiencing the fun she had with the three possible dads of Sophie (Amanda Seyfriend). As she reflects on her mom''s journey, Sophie finds herself to be more like her mother than she ever even realized.', N'208953')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'13', N'The Boss Baby ', N'D:\LTUDQL2\13\phim.mp4', N'3', N'D:\Trailer\thebossbaby.jpg', N'D:\LTUDQL2\13\trailer.mp4', N'1', N'208', N'185', N'2017-03-12 00:00:00.000', N'2017-03-31 00:00:00.000', N'7-year-old Tim Templeton has always had an overactive imagination--and for the past seven years--life has been all peaches for him, getting all the love and affection from his caring parents. However, after the arrival of Boss Baby, an unexpected new brother dressed in a black suit complete with a tie and a briefcase, Tim won''t be the centre of attention anymore, as the powerful sibling takes over the whole house, robbing him of all care, little by little. But, soon, Tim and the new Boss in a diaper will need to put differences aside and join forces, as a sneaky scheme involving the head of Puppy Co. threatens to tilt the balance of power towards their insidiously adorable furry antagonists, not to mention that the next Pet Convention is only in two days. Brothers, hurry up.', N'5792412')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'14', N'The Secret Life of Pets 1', N'D:\LTUDQL2\14\phim.mp4', N'3', N'D:\Trailer\thesecretlifeofpet1.jpg', N'D:\LTUDQL2\14\trailer.mp4', N'1', N'291', N'285', N'2016-06-16 00:00:00.000', N'2016-07-01 00:00:00.000', N'In a Manhattan apartment building, Max''s life as a favorite pet is turned upside-down, when his owner brings home sloppy mongrel Duke. They must put their quarrels aside when they learn that adorable white bunny Snowball is building an army of lost pets determined to wreak revenge.', N'4297579')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'15', N'HOME ALONE 2- LOST IN NEW YORK (1992)', N'D:\LTUDQL2\15\phim.mp4', N'3', N'D:\Trailer\homealone2.jpg', N'D:\LTUDQL2\15\trailer.mp4', N'1', N'230', N'51', N'1992-11-20 00:00:00.000', N'1992-11-20 00:00:00.000', N'Kevin McCallister is back. But this time he''s in New York City with enough cash and credit cards to turn the Big Apple into his very own playground. But Kevin won''t be alone for long. The notorious Wet Bandits, Harry and Marv, still smarting from their last encounter with Kevin, are bound for New York too, plotting a huge holiday heist! Kevin''s ready to welcome them with more battery of booby traps the bumbling bandits will never forget!', N'1746627')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'16', N'Avengers- Age of Ultron', N'D:\LTUDQL2\16\phim.mp4', N'4', N'D:\Trailer\avengers_ageofultron.jpg', N'D:\LTUDQL2\16\trailer.mp4', N'2', N'1202', N'676', N'2015-04-13 00:00:00.000', N'2015-04-24 00:00:00.000', N'Tony Stark creates the Ultron Program to protect the world, but when the peacekeeping program becomes hostile, The Avengers go into action to try and defeat a virtually impossible enemy together. Earth''s mightiest heroes must come together once again to protect the world from global extinction.', N'15268165')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'17', N'Avengers- Infinity War', N'D:\LTUDQL2\17\phim.mp4', N'4', N'D:\Trailer\avengers-infinitywar.jpg', N'D:\LTUDQL2\17\trailer.mp4', N'3', N'4007', N'572', N'2018-04-23 00:00:00.000', N'2018-04-25 00:00:00.000', N'As the Avengers and their allies have continued to protect the world from threats too large for any one hero to handle, a new danger has emerged from the cosmic shadows: Thanos. A despot of intergalactic infamy, his goal is to collect all six Infinity Stones, artifacts of unimaginable power, and use them to inflict his twisted will on all of reality. Everything the Avengers have fought for has led up to this moment, the fate of Earth and existence has never been more uncertain.', N'9573757')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'18', N'Captain Marvel', N'D:\LTUDQL2\18\phim.mp4', N'4', N'D:\Trailer\captainmarvel.jpg', N'D:\LTUDQL2\18\trailer.mp4', N'2', N'6299', N'444', N'2019-02-27 00:00:00.000', N'2019-03-08 00:00:00.000', N'After crashing an experimental aircraft, Air Force pilot Carol Danvers is discovered by the Kree and trained as a member of the elite Starforce Military under the command of her mentor Yon-Rogg. Six years later, after escaping to Earth while under attack by the Skrulls, Danvers begins to discover there''s more to her past. With help from S.H.I.E.L.D. agent Nick Fury, they set out to unravel the truth.', N'8005041')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'19', N'Glass', N'D:\LTUDQL2\19\phim.mp4', N'4', N'D:\Trailer\glass.jpg', N'D:\LTUDQL2\19\trailer.mp4', N'1', N'1567', N'362', N'2019-01-07 00:00:00.000', N'2019-01-18 00:00:00.000', N'After pursuing Kevin Wendell Crumb and the multiple identities that reside within. David Dunn finds himself locked in a mental hospital alongside his archenemy, Elijah Price and must contend with a psychiatrist who is out to prove the trio do not actually possess superhuman abilities.', N'1139940')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'20', N'THE AVENGERS', N'D:\LTUDQL2\20\phim.mp4', N'4', N'D:\Trailer\theavengers.jpg', N'D:\LTUDQL2\20\trailer.mp4', N'2', N'1804', N'734', N'2012-04-11 00:00:00.000', N'2012-04-27 00:00:00.000', N'Nick Fury is the director of S.H.I.E.L.D., an international peace-keeping agency. The agency is a who''s who of Marvel Super Heroes, with Iron Man, The Incredible Hulk, Thor, Captain America, Hawkeye and Black Widow. When global security is threatened by Loki and his cohorts, Nick Fury and his team will need all their powers to save the world from disaster which is formed by Loki and his team.', N'5441064')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'21', N'A Quiet Place', N'D:\LTUDQL2\21\phim.mp4', N'5', N'D:\Trailer\aquiteplace.jpg', N'D:\LTUDQL2\21\trailer.mp4', N'2', N'2486', N'519', N'2018-03-09 00:00:00.000', N'2018-04-20 00:00:00.000', N'Two parents do what it takes to keep their children safe in a world full of creatures hunting every sound they can hear. Not a sound can be heard from the family hiding in silence, but all it takes is one noise and everything can go wrong.', N'2596209')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'22', N'Before I Wake', N'D:\LTUDQL2\22\phim.mp4', N'5', N'D:\Trailer\beforeiwake.jpg', N'D:\LTUDQL2\22\trailer.mp4', N'1', N'139', N'122', N'2016-04-07 00:00:00.000', N'2016-04-08 00:00:00.000', N'In this intense and heart pounding supernatural thriller, Jessie (Kate Bosworth) and Mark (Thomas Jane) decide to take in a sweet and loving 8-year-old boy, Cody. Unbeknownst to them, Cody is terrified of falling asleep. At first, they assume his previous unstable homes caused his aversion to sleep, but soon discover why: Cody''s dreams manifest in reality as he sleeps. In one moment they experience the incredible wonder of Cody''s imagination, and in the next, the horrific nature of his night terrors. To save their new family, Jessie and Mark embark on a dangerous hunt to uncover the truth behind Cody''s nightmares.', N'609247')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'23', N'DON''T BREATHE', N'D:\LTUDQL2\23\phim.mp4', N'5', N'D:\Trailer\dontbreathe.jpg', N'D:\LTUDQL2\23\trailer.mp4', N'2', N'545', N'398', N'2016-03-12 00:00:00.000', N'2016-08-26 00:00:00.000', N'Rocky, a young woman wanting to start a better life for her and her sister, agrees to take part in the robbery of a house owned by a wealthy blind man with her boyfriend Money and their friend Alex. But when the blind man turns out to be a more ruthless adversary than he seems, the group must find a way to escape his home before they become his latest victims.

Three Detroit thieves look to rob a blind man''s house with a major cash settlement so the main character, Rocky, can move to California forever. Little do they know of the blind man''s capabilities and hidden secret within the home, as they must find a way out of the house alive, in the dark.

In Detroit, the burglars Money, Rocky and Alex plot a heist in the isolated house of a Blind Man, who received a large amount when his beloved daughter died in a car accident. They have the intention to move to California with the stolen money. They give a spiked candy to the dog and break in the house. Money gases the bedroom of the Blind Man to make him sleep and they seek where the money is hidden. Out of the blue, the Blind Man comes to the place where the trio is. What will happen to them?', N'2291027')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'24', N'Train to Busan', N'D:\LTUDQL2\24\phim.mp4', N'5', N'D:\Trailer\traintobusan.jpg', N'D:\LTUDQL2\24\trailer.mp4', N'2', N'392', N'353', N'2016-05-13 00:00:00.000', N'2016-08-12 00:00:00.000', N'Sok-woo, a father with not much time for his daughter, Soo-ahn, are boarding the KTX, a fast train that shall bring them from Seoul to Busan. But during their journey, the apocalypse begins, and most of the earth''s population become flesh craving zombies. While the KTX is shooting towards Busan, the passenger''s fight for their families and lives against the zombies - and each other.', N'4444509')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'25', N'Warm Bodies', N'D:\LTUDQL2\25\phim.mp4', N'5', N'D:\Trailer\warmbody.jpg', N'D:\LTUDQL2\25\trailer.mp4', N'1', N'354', N'461', N'2013-01-16 00:00:00.000', N'2013-03-08 00:00:00.000', N'With much of the world''s population now an undead horde, R is a young and oddly introspective zombie. While fighting with and feeding on a human scavenger party, R meets Julie and feels an urge to protect her. What happens next is the beginning of a strangely warm relationship that allows R to begin regaining his humanity. As this change spreads through the local undead population like a virus, Julie and R eventually have to face a larger issue when the very nature of their friendship is challenged. Caught between the paranoid human forces and the ferocious "Bonies", zombies who are a mutual threat, R and Julie must find a way to bridge the differences of each side to fight for a better world no one thought possible.', N'619847')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'26', N'CAMP ROCK', N'D:\LTUDQL2\26\phim.mp4', N'6', N'D:\Trailer\camprock.jpg', N'D:\LTUDQL2\26\trailer.mp4', N'1', N'142', N'20', N'2008-06-20 00:00:00.000', N'2008-06-20 00:00:00.000', N'"Camp Rock" centers on a teen girl who desperately wants to spend her summer at a prestigious rock camp but can only attend if she works in the kitchen as one of its cooks. When she''s overheard singing (but not seen) by a teen pop star at the camp, he is completely taken and sets out to find the girl behind the beautiful voice. But first she must confront her fears, step out of the kitchen and into the spotlight.', N'645919')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'27', N'CoCo', N'D:\LTUDQL2\27\phim.mp4', N'6', N'D:\Trailer\coco.jpg', N'D:\LTUDQL2\27\trailer.mp4', N'3', N'846', N'390', N'2017-10-20 00:00:00.000', N'2017-11-24 00:00:00.000', N'Despite his family''s baffling generations-old ban on music, Miguel dreams of becoming an accomplished musician like his idol, Ernesto de la Cruz. Desperate to prove his talent, Miguel finds himself in the stunning and colorful Land of the Dead following a mysterious chain of events. Along the way, he meets charming trickster Hector, and together, they set off on an extraordinary journey to unlock the real story behind Miguel''s family history.', N'3929116')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'28', N'High School Musical', N'D:\LTUDQL2\28\phim.mp4', N'6', N'D:\Trailer\highschoolmusic.png', N'D:\LTUDQL2\28\trailer.mp4', N'1', N'739', N'62', N'2006-01-20 00:00:00.000', N'2006-01-20 00:00:00.000', N'Troy Bolton and Gabriella Montez are two totally different teenagers who meet at a party while singing karaoke on New Year''s Eve. One week later Troy goes back to his high school, East High, in New Mexico to find that Gabriella is a new student there. They quickly become close friends and accidentally audition for the school musical. After getting a callback, drama queen Sharpay Evans and her sidekick brother Ryan are furious. Then Chad, Troy''s best friend and basketball teammate, and Taylor, Gabriella''s new friend on the decathlon team, must find out a way to make Gabriella hate Troy.', N'495035')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'29', N'Our Shining Days', N'D:\LTUDQL2\29\phim.mp4', N'6', N'D:\Trailer\ourshiningday.jpg', N'D:\LTUDQL2\29\trailer.mp4', N'1', N'5', N'3', N'2017-07-20 00:00:00.000', N'2017-07-20 00:00:00.000', N'A youth inspirational film, about how a group of high school students try to revive Chinese orchestra ensemble. They face many challenges along the way to compete nationally, including a rivalry with the more popular Western orchestra club.', N'10169')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'30', N'Pitch Perfect', N'D:\LTUDQL2\30\phim.mp4', N'6', N'D:\Trailer\pitchperfect.jpg', N'D:\LTUDQL2\30\trailer.mp4', N'1', N'299', N'230', N'2012-10-05 00:00:00.000', N'2012-10-05 00:00:00.000', N'The Barden Bellas are a collegiate, all-girls a cappella singing group thriving on female pop songs and their perfect looks. After a disastrous failing at last year''s finals, they are forced to regroup. Among the new recruits is freshman Beca, an independent, aspiring DJ with no interest in the college life. But after she meets Jesse, from the rival all-male a cappella group, Beca has a new outlook and takes it upon herself to help the Bellas find their new look and sound and get back into the competition.', N'559656')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'31', N'USS Indianapolis: Men of Courage', N'D:\LTUDQL2\31\phim.mp4', N'7', N'D:\Trailer\USS Indianapolis- Men of Courage.jpg', N'D:\LTUDQL2\31\trailer.mp4', N'1', N'127', N'33', N'2016-10-07 00:00:00.000', N'2016-10-07 00:00:00.000', N'The harrowing true story of the crew of the USS Indianapolis, who were stranded in the Philippine Sea for five days after delivering the atomic weapons that would eventually end WWII. As they awaited rescue, they endured extreme thirst, hunger, and relentless shark attacks.', N'1444393')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'32', N'Deepwater Horizon', N'D:\LTUDQL2\32\phim.mp4', N'7', N'D:\Trailer\deepwater horizon.jpg', N'D:\LTUDQL2\32\trailer.mp4', N'2', N'255', N'303', N'2016-09-13 00:00:00.000', N'2016-09-30 00:00:00.000', N'In April 2010, there is no oil exploration operation in the Gulf of Mexico to compare with the Deepwater Horizon oil rig with its size or sheer depth of its drilling. However, the project for the BP oil company is beset with technical difficulties to the point where the general operational supervisor, Jimmy Harrell, and his Chief Electrical Engineer, Mike Williams, are concerned potentially dangerous trouble is brewing. Unfortunately, visiting BP executives, frustrated by the project''s long delays, order curtailed site inspections and slanted system tests to make up for lost time even as Harrell, Williams and his team helplessly protest for the sake of proper safety. On April 20, the workers'' fears are realized in the worst possible way when the rig''s various structural and system flaws spark a catastrophic cascade of failures that would create a massive blowout and explosion that threatens them all, even as it also begins the worst environmental disaster in US history.', N'1177773')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'33', N'Operation Mekong', N'D:\LTUDQL2\33\phim.mp4', N'7', N'D:\Trailer\OPERATION-MEKONG.jpg', N'D:\LTUDQL2\33\trailer.mp4', N'2', N'16', N'29', N'2016-09-30 00:00:00.000', N'2016-10-14 00:00:00.000', N'Inspired by the true story known as the Mekong Massacre--two Chinese commercial vessels are ambushed while traveling down the Mekong River in the waters of the Golden Triangle, one of the largest drug-manufacturing regions in the world. 13 sailors are executed at gunpoint, and 900,000 methamphetamine pills are recovered at the scene. Upon discovery, the Chinese government immediately sends a band of elite narcotics officers led by Captain Gao Gang (Zhang Hanyu) to the Golden Triangle to uncover the truth behind the murders. Tea field owner and Golden Triangle-based intelligence officer Fang Xinwu (Eddie Peng) joins the investigation. After it is discovered that the drugs seized on the Chinese ships had been planted by the henchman of a notorious drug cartel leader named Naw Khar, the governments of Thailand, Laos, Myanmar and China launch a joint task force to apprehend the criminal. The road to justice is, however, paved with dangerous and deadly obstacles.

Two Chinese merchant ships were attacked in Mekong river and 13 crews were killed. Thai policemen found 9 hundred thousand crystal meth on the ships. This new shocked China. Gang Gao, the leader of Narcotics Corps in Yun Nan province was assigned to lead a special team to Golden Triangle to investigate. Cooperated with a informer, Fanxin Wu, Gao discovered that 13 crew member were brutally murdered and framed up. Gao and Wu decided to fight for justice out of China no matter what it takes.', N'2190764')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'34', N'Patriots Day', N'D:\LTUDQL2\34\phim.mp4', N'7', N'D:\Trailer\Patriots Day.jpg', N'D:\LTUDQL2\34\trailer.mp4', N'2', N'235', N'296', N'2016-11-17 00:00:00.000', N'2017-01-06 00:00:00.000', N'On April 15, 2013 Boston, Massachusetts, Police Sgt, Tommy Saunders is pulling security duty on the annual Boston Marathon when the Tsarnaev brothers strike with their homemade bombs in an act of terrorism. In the resulting chaos as the wounded are cared for, Saunders and his comrades join forces with the FBI to get to the bottom of this attack. As the investigation continues, the Tsarnaev brothers realize that the authorities are close to identifying them and attempt to flee the city to continue their fanatical mayhem. To stop them, a police manhunt is performed that would have bloody confrontations and a massive dragnet shutting down the City of Boston to make sure there is no escape from the law.', N'933721')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'35', N'PEARL HARBOR ', N'D:\LTUDQL2\35\phim.mp4', N'7', N'D:\Trailer\Pearl-Harbor.jpg', N'D:\LTUDQL2\35\trailer.mp4', N'1', N'1981', N'192', N'2001-05-25 00:00:00.000', N'2001-05-25 00:00:00.000', N'Pearl Harbor is a classic tale of romance set during a war that complicates everything. It all starts when childhood friends Rafe and Danny become Army Air Corps pilots and meet Evelyn, a Navy nurse. Rafe falls head over heels and next thing you know Evelyn and Rafe are hooking up. Then Rafe volunteers to go fight in Britain and Evelyn and Danny get transferred to Pearl Harbor. While Rafe is off fighting everything gets completely whack and next thing you know everybody is in the middle of an air raid we now know as "Pearl Harbor."', N'849613')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'41', N'Call Me By Your Name', N'D:\LTUDQL2\36\phim.mp4', N'8', N'D:\LTUDQL2\36\hinh.jpg', N'D:\LTUDQL2\36\trailer.mp4', N'2', N'719', N'452', N'2018-01-18 00:00:00.000', N'2018-01-18 00:00:00.000', N'CALL ME BY YOUR NAME, the new film by Luca Guadagnino, is a sensual and transcendent tale of first love, based on the acclaimed novel by André Aciman. It''s the summer of 1983 in the north of Italy, and Elio Perlman (Timothée Chalamet), a precocious 17-year-old young man, spends his days in his family''s 17th century villa transcribing and playing classical music, reading, and flirting with his friend Marzia (Esther Garrel). Elio enjoys a close relationship with his father (Michael Stuhlbarg), an eminent professor specializing in Greco-Roman culture, and his mother Annella (Amira Casar), a translator, who favor him with the fruits of high culture in a setting that overflows with natural delights. While Elio''s sophistication and intellectual gifts suggest he is already a fully-fledged adult, there is much that yet remains innocent and unformed about him, particularly about matters of the heart. One day, Oliver (Armie Hammer), a 24-year-old American college graduate student working on his doctorate, arrives as the annual summer intern tasked with helping Elio''s father. Amid the sun-drenched splendor of the setting, Elio and Oliver discover the heady beauty of awakening desire over the course of a summer that will alter their lives forever.', N'1093230')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'42', N'Freaky Friday', N'D:\LTUDQL2\37\phim.mp4', N'8', N'D:\LTUDQL2\37\hinh.jpg', N'D:\LTUDQL2\37\trailer.mp4', N'1', N'278', N'130', N'2003-08-06 00:00:00.000', N'2003-08-06 00:00:00.000', N'The wide generation gap between Tess Coleman and her teenage daughter Anna is more than evident. They simply cannot understand each other''s preferences. On a Thursday night they have a big argument in a Chinese restaurant. Both receive a fortune cookie each from the restaurant owner''s mother which causes them to switch bodies next day. As they adjust with their new personalities, they begin to understand each other more and eventually it''s the mutual self-respect that sorts the things out.', N'123876')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'43', N'La La Land', N'D:\LTUDQL2\38\phim.mp4', N'8', N'D:\LTUDQL2\38\hinh.png', N'D:\LTUDQL2\38\trailer.mp4', N'3', N'1554', N'665', N'2016-08-31 00:00:00.000', N'2016-12-16 00:00:00.000', N'Aspiring actress serves lattes to movie stars in between auditions and jazz musician Sebastian scrapes by playing cocktail-party gigs in dingy bars. But as success mounts, they are faced with decisions that fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.', N'2448451')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'44', N'Me Before You', N'D:\LTUDQL2\39\phim.mp4', N'8', N'D:\LTUDQL2\39\hinh.jpg', N'D:\LTUDQL2\39\trailer.mp4', N'2', N'375', N'220', N'2016-05-23 00:00:00.000', N'2016-06-03 00:00:00.000', N'Lou Clark knows lots of things. She knows how many footsteps there are between the bus stop and home. She knows she likes working in The Buttered Bun tea shop and she knows she might not love her boyfriend Patrick. What Lou doesn''t know is she''s about to lose her job or that knowing what''s coming is what keeps her sane. Will Traynor knows a car accident took away his desire to live. He knows everything feels very small and rather joyless now and he knows exactly how he''s going to put a stop to that. What Will doesn''t know is that Lou is about to burst into his world in a riot of color. And neither of them knows they''re going to change each other for all time.', N'3164400')
GO

INSERT INTO [dbo].[Video] ([MaVideo], [TenVideo], [LinkVideo], [MaLoai_Video], [LinkImage], [LinkTrailer], [CapDoVideo], [Like], [Dislike], [NgaySanXuat], [NgayUpload], [MoTa], [LuotXem]) VALUES (N'45', N'Mean Girls', N'D:\LTUDQL2\40\phim.mp4', N'8', N'D:\LTUDQL2\40\hinh.jpg', N'D:\LTUDQL2\40\trailer.mp4', N'2', N'603', N'147', N'2004-04-30 00:00:00.000', N'2004-04-30 00:00:00.000', N'Lindsay Lohan stars as Cady Heron, a 16 year old homeschooled girl who not only makes the mistake of falling for Aaron Samuels (Jonathan Bennett), the ex-boyfriend of queenbee Regina George (Rachel McAdams), but also unintentionally joins The Plastics, led by Regina herself. Join Cady as she learns that high school life can and will be really tough.', N'2236000')
GO

SET IDENTITY_INSERT [dbo].[Video] OFF
GO


-- ----------------------------
-- Table structure for YeuThich_XemGanDay
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[YeuThich_XemGanDay]') AND type IN ('U'))
	DROP TABLE [dbo].[YeuThich_XemGanDay]
GO

CREATE TABLE [dbo].[YeuThich_XemGanDay] (
  [MaProfile] int  NOT NULL,
  [MaVideo] int  NOT NULL,
  [LoaiLuuTru] int  NOT NULL,
  [ThoiGian] datetime  NULL
)
GO

ALTER TABLE [dbo].[YeuThich_XemGanDay] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of YeuThich_XemGanDay
-- ----------------------------
INSERT INTO [dbo].[YeuThich_XemGanDay]  VALUES (N'21', N'20', N'1', N'2019-06-18 20:44:58.460')
GO

INSERT INTO [dbo].[YeuThich_XemGanDay]  VALUES (N'21', N'16', N'3', N'2019-06-21 09:08:33.847')
GO

INSERT INTO [dbo].[YeuThich_XemGanDay]  VALUES (N'21', N'17', N'3', N'2019-06-21 09:07:55.327')
GO

INSERT INTO [dbo].[YeuThich_XemGanDay]  VALUES (N'21', N'18', N'3', N'2019-06-18 20:30:40.097')
GO

INSERT INTO [dbo].[YeuThich_XemGanDay]  VALUES (N'21', N'20', N'3', N'2019-06-20 22:20:16.287')
GO

INSERT INTO [dbo].[YeuThich_XemGanDay]  VALUES (N'25', N'41', N'3', N'2019-06-18 21:39:16.467')
GO

INSERT INTO [dbo].[YeuThich_XemGanDay]  VALUES (N'1025', N'13', N'3', N'2019-06-19 08:23:56.270')
GO


-- ----------------------------
-- Primary Key structure for table CapDoTaiKhoan
-- ----------------------------
ALTER TABLE [dbo].[CapDoTaiKhoan] ADD CONSTRAINT [PK__CapDoTai__40B881FC36CB296B] PRIMARY KEY CLUSTERED ([MaCapDo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table LoaiVideo
-- ----------------------------
ALTER TABLE [dbo].[LoaiVideo] ADD CONSTRAINT [PK__LoaiVide__6F25D9AF2DEE6514] PRIMARY KEY CLUSTERED ([MaLoaiVideo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table PlayList
-- ----------------------------
ALTER TABLE [dbo].[PlayList] ADD CONSTRAINT [PK__PlayList__E18784D87932BA9F] PRIMARY KEY CLUSTERED ([IDProfile], [IDVideo], [IDPlayList])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Profile
-- ----------------------------
ALTER TABLE [dbo].[Profile] ADD CONSTRAINT [PK__Profile__E703E3339DF2D6DA] PRIMARY KEY CLUSTERED ([MaProfile])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table TaiKhoan
-- ----------------------------
ALTER TABLE [dbo].[TaiKhoan] ADD CONSTRAINT [PK__TaiKhoan__AD7C6529FCA68E73] PRIMARY KEY CLUSTERED ([MaTaiKhoan])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ThanhToan
-- ----------------------------
ALTER TABLE [dbo].[ThanhToan] ADD CONSTRAINT [PK__ThanhToa__D4B258441C61D8E1] PRIMARY KEY CLUSTERED ([MaThanhToan])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table The
-- ----------------------------
ALTER TABLE [dbo].[The] ADD CONSTRAINT [PK__The__43A2A4E26DA4479B] PRIMARY KEY CLUSTERED ([IDCard])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Video
-- ----------------------------
ALTER TABLE [dbo].[Video] ADD CONSTRAINT [PK__Video__BCAAF261F2DF3179] PRIMARY KEY CLUSTERED ([MaVideo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table YeuThich_XemGanDay
-- ----------------------------
ALTER TABLE [dbo].[YeuThich_XemGanDay] ADD CONSTRAINT [PK__YeuThich__E0939C7004A0F4CF] PRIMARY KEY CLUSTERED ([MaProfile], [LoaiLuuTru], [MaVideo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table PlayList
-- ----------------------------
ALTER TABLE [dbo].[PlayList] ADD CONSTRAINT [FK__PlayList__IDProf__4CA06362] FOREIGN KEY ([IDProfile]) REFERENCES [dbo].[Profile] ([MaProfile]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[PlayList] ADD CONSTRAINT [FK__PlayList__IDVide__4F7CD00D] FOREIGN KEY ([IDVideo]) REFERENCES [dbo].[Video] ([MaVideo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Profile
-- ----------------------------
ALTER TABLE [dbo].[Profile] ADD CONSTRAINT [FK__Profile__TaiKhoa__20C1E124] FOREIGN KEY ([TaiKhoan]) REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table TaiKhoan
-- ----------------------------
ALTER TABLE [dbo].[TaiKhoan] ADD CONSTRAINT [FK__TaiKhoan__CapDo__21B6055D] FOREIGN KEY ([CapDo]) REFERENCES [dbo].[CapDoTaiKhoan] ([MaCapDo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[TaiKhoan] ADD CONSTRAINT [FK__TaiKhoan__IDThe__2A4B4B5E] FOREIGN KEY ([IDThe]) REFERENCES [dbo].[The] ([IDCard]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ThanhToan
-- ----------------------------
ALTER TABLE [dbo].[ThanhToan] ADD CONSTRAINT [FK__ThanhToan__IDThe__239E4DCF] FOREIGN KEY ([IDThe]) REFERENCES [dbo].[The] ([IDCard]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ThanhToan] ADD CONSTRAINT [FK__ThanhToan__TaiKh__24927208] FOREIGN KEY ([TaiKhoan]) REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Video
-- ----------------------------
ALTER TABLE [dbo].[Video] ADD CONSTRAINT [FK__Video__CapDoVide__24927208] FOREIGN KEY ([CapDoVideo]) REFERENCES [dbo].[CapDoTaiKhoan] ([MaCapDo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Video] ADD CONSTRAINT [FK__Video__MaLoai_Vi__25869641] FOREIGN KEY ([MaLoai_Video]) REFERENCES [dbo].[LoaiVideo] ([MaLoaiVideo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table YeuThich_XemGanDay
-- ----------------------------
ALTER TABLE [dbo].[YeuThich_XemGanDay] ADD CONSTRAINT [FK__YeuThich___MaPro__276EDEB3] FOREIGN KEY ([MaProfile]) REFERENCES [dbo].[Profile] ([MaProfile]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[YeuThich_XemGanDay] ADD CONSTRAINT [FK__YeuThich___MaVid__276EDEB3] FOREIGN KEY ([MaVideo]) REFERENCES [dbo].[Video] ([MaVideo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

