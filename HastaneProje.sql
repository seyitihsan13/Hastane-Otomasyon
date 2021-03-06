USE [master]
GO
/****** Object:  Database [HastaneProje]    Script Date: 3.09.2021 20:42:29 ******/
CREATE DATABASE [HastaneProje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HastaneOtomasyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HastaneOtomasyon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HastaneOtomasyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HastaneOtomasyon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HastaneProje] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HastaneProje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HastaneProje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HastaneProje] SET ARITHABORT OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HastaneProje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HastaneProje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HastaneProje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HastaneProje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HastaneProje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HastaneProje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HastaneProje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HastaneProje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HastaneProje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HastaneProje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HastaneProje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HastaneProje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HastaneProje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HastaneProje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HastaneProje] SET RECOVERY FULL 
GO
ALTER DATABASE [HastaneProje] SET  MULTI_USER 
GO
ALTER DATABASE [HastaneProje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HastaneProje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HastaneProje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HastaneProje] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HastaneProje] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HastaneProje] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HastaneProje', N'ON'
GO
ALTER DATABASE [HastaneProje] SET QUERY_STORE = OFF
GO
USE [HastaneProje]
GO
/****** Object:  Table [dbo].[Tbl_Branslar]    Script Date: 3.09.2021 20:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Branslar](
	[Bransid] [tinyint] IDENTITY(1,1) NOT NULL,
	[BransAd] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Doktorlar]    Script Date: 3.09.2021 20:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Doktorlar](
	[Doktorid] [tinyint] IDENTITY(1,1) NOT NULL,
	[DoktorAd] [varchar](10) NULL,
	[DoktorSoyad] [varchar](10) NULL,
	[DoktorBrans] [varchar](30) NULL,
	[DoktorTC] [char](11) NULL,
	[DoktorSifre] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Duyurular]    Script Date: 3.09.2021 20:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Duyurular](
	[Duyuruid] [smallint] IDENTITY(1,1) NOT NULL,
	[Duyuru] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Hastalar]    Script Date: 3.09.2021 20:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Hastalar](
	[Hastaid] [smallint] IDENTITY(1,1) NOT NULL,
	[HastaAd] [varchar](10) NULL,
	[HastaSoyad] [varchar](10) NULL,
	[HastaTC] [char](11) NULL,
	[HastaTelefon] [varchar](15) NULL,
	[HastaSifre] [varchar](10) NULL,
	[HastaCinsiyet] [varchar](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Randevular]    Script Date: 3.09.2021 20:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Randevular](
	[Randevuid] [int] IDENTITY(1,1) NOT NULL,
	[RandevuTarih] [varchar](10) NULL,
	[RandevuSaat] [varchar](5) NULL,
	[RandevuBrans] [varchar](30) NULL,
	[RandevuDoktor] [varchar](20) NULL,
	[RandevuDurum] [bit] NULL,
	[HastaTC] [char](11) NULL,
	[HastaSikayet] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Sekreter]    Script Date: 3.09.2021 20:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sekreter](
	[Sekreterid] [tinyint] IDENTITY(1,1) NOT NULL,
	[SekreterAdSoyad] [varchar](20) NULL,
	[SekreterTc] [char](11) NULL,
	[SekreterSifre] [varchar](10) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Branslar] ON 

INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (1, N'Dahiliye')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (2, N'Göz')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (3, N'Kulak Burun Boğaz')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (4, N'Cilt Hastalıkları')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (5, N'')
SET IDENTITY_INSERT [dbo].[Tbl_Branslar] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Doktorlar] ON 

INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (1, N'Umut', N'Elkatmış', N'Cilt Hastalıkları', N'77777777777', N'7777')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (2, N'Burak', N'Akış', N'Dahiliye', N'88888888888', N'8888')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (3, N'İbrahim', N'Bayramoğlu', N'Kulak Burun Boğaz', N'99999999999', N'9999')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (4, N'Hakan', N'Köse', N'Göz', N'44444444444', N'4444')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (5, N'Ahmet', N'Geçgeloğlu', N'Göz', N'66666666666', N'6666')
SET IDENTITY_INSERT [dbo].[Tbl_Doktorlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Duyurular] ON 

INSERT [dbo].[Tbl_Duyurular] ([Duyuruid], [Duyuru]) VALUES (1, N'Saat 10:00''da Toplantı Yapılacaktır .')
INSERT [dbo].[Tbl_Duyurular] ([Duyuruid], [Duyuru]) VALUES (2, N'Yarın Saat 14:00''da Tüm Doktorlar Konferans Salonunda olmalıdır.')
SET IDENTITY_INSERT [dbo].[Tbl_Duyurular] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Hastalar] ON 

INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaTC], [HastaTelefon], [HastaSifre], [HastaCinsiyet]) VALUES (1, N'Seyit ', N'Elkatmış', N'11111111111', N'(534) 646-4846', N'1111', N'Erkek')
INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaTC], [HastaTelefon], [HastaSifre], [HastaCinsiyet]) VALUES (2, N'Ayşe', N'Elkatmış', N'13333333333', N'(456) 464-8964', N'1234', N'Kadın')
SET IDENTITY_INSERT [dbo].[Tbl_Hastalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Randevular] ON 

INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTC], [HastaSikayet]) VALUES (1, N'12.05.2021', N'12:00', N'Göz', N'Hakan Köse', 0, NULL, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTC], [HastaSikayet]) VALUES (2, N'12.12.2012', N'12:34', N'Cilt Hastalıkları', N'Umut Elkatmış', 0, NULL, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTC], [HastaSikayet]) VALUES (3, N'04.09.2021', N'12:00', N'Cilt Hastalıkları', N'Umut Elkatmış', 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Randevular] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Sekreter] ON 

INSERT [dbo].[Tbl_Sekreter] ([Sekreterid], [SekreterAdSoyad], [SekreterTc], [SekreterSifre]) VALUES (1, N'Zehra Bayramoğlu', N'55555555555', N'5555')
SET IDENTITY_INSERT [dbo].[Tbl_Sekreter] OFF
GO
ALTER TABLE [dbo].[Tbl_Randevular] ADD  CONSTRAINT [DF_TblRandevular_RandevuDurum]  DEFAULT ((0)) FOR [RandevuDurum]
GO
USE [master]
GO
ALTER DATABASE [HastaneProje] SET  READ_WRITE 
GO
