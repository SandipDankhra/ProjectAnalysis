USE [master]
GO
/****** Object:  Database [ToyZoneDb]    Script Date: 3/26/2020 6:58:24 PM ******/
CREATE DATABASE [ToyZoneDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ToyZoneDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ToyZoneDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ToyZoneDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ToyZoneDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ToyZoneDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ToyZoneDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ToyZoneDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ToyZoneDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ToyZoneDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ToyZoneDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ToyZoneDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ToyZoneDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ToyZoneDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ToyZoneDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ToyZoneDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ToyZoneDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ToyZoneDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ToyZoneDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ToyZoneDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ToyZoneDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ToyZoneDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ToyZoneDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ToyZoneDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ToyZoneDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ToyZoneDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ToyZoneDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ToyZoneDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ToyZoneDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ToyZoneDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ToyZoneDb] SET  MULTI_USER 
GO
ALTER DATABASE [ToyZoneDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ToyZoneDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ToyZoneDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ToyZoneDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ToyZoneDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ToyZoneDb] SET QUERY_STORE = OFF
GO
USE [ToyZoneDb]
GO
/****** Object:  Table [dbo].[ApplicationObjects]    Script Date: 3/26/2020 6:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationObjects](
	[ApplicationObjectId] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationObjectTypeId] [int] NOT NULL,
	[ApplicationObjectName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ApplicationObjects] PRIMARY KEY CLUSTERED 
(
	[ApplicationObjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationObjectTypes]    Script Date: 3/26/2020 6:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationObjectTypes](
	[ApplicationObjectTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationObjectTypeName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ApplicationObjectTypes] PRIMARY KEY CLUSTERED 
(
	[ApplicationObjectTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorys]    Script Date: 3/26/2020 6:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorys](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Categorys] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 3/26/2020 6:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[MobileNumber] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[address] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 3/26/2020 6:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[ShippingDate] [datetime] NOT NULL,
	[ShippingAddress] [varchar](max) NOT NULL,
	[OrderStatus] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[RequiredDate] [datetime] NOT NULL,
	[OrderId] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/26/2020 6:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 3/26/2020 6:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[ProductDetailId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Size] [varchar](50) NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Available] [bit] NOT NULL,
 CONSTRAINT [PK_ProductDetails] PRIMARY KEY CLUSTERED 
(
	[ProductDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/26/2020 6:58:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ApplicationObjects]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationObjects_ApplicationObjects] FOREIGN KEY([ApplicationObjectId])
REFERENCES [dbo].[ApplicationObjects] ([ApplicationObjectId])
GO
ALTER TABLE [dbo].[ApplicationObjects] CHECK CONSTRAINT [FK_ApplicationObjects_ApplicationObjects]
GO
ALTER TABLE [dbo].[ApplicationObjects]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationObjects_ApplicationObjectTypes] FOREIGN KEY([ApplicationObjectTypeId])
REFERENCES [dbo].[ApplicationObjectTypes] ([ApplicationObjectTypeId])
GO
ALTER TABLE [dbo].[ApplicationObjects] CHECK CONSTRAINT [FK_ApplicationObjects_ApplicationObjectTypes]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_ApplicationObjects] FOREIGN KEY([OrderStatus])
REFERENCES [dbo].[ApplicationObjects] ([ApplicationObjectId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_ApplicationObjects]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products]
GO
ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD  CONSTRAINT [FK_ProductDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[ProductDetails] CHECK CONSTRAINT [FK_ProductDetails_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categorys] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categorys] ([CategoryId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categorys]
GO
USE [master]
GO
ALTER DATABASE [ToyZoneDb] SET  READ_WRITE 
GO
