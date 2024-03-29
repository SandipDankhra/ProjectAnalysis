USE [master]
GO
/****** Object:  Database [StudentInfoDb]    Script Date: 3/31/2020 2:19:54 PM ******/
CREATE DATABASE [StudentInfoDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentInfoDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StudentInfoDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentInfoDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StudentInfoDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StudentInfoDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentInfoDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentInfoDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentInfoDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentInfoDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentInfoDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentInfoDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentInfoDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentInfoDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentInfoDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentInfoDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentInfoDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentInfoDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentInfoDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentInfoDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentInfoDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentInfoDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentInfoDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentInfoDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentInfoDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentInfoDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentInfoDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentInfoDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentInfoDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentInfoDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentInfoDb] SET  MULTI_USER 
GO
ALTER DATABASE [StudentInfoDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentInfoDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentInfoDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentInfoDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentInfoDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentInfoDb] SET QUERY_STORE = OFF
GO
USE [StudentInfoDb]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 3/31/2020 2:19:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[MobileNumber] [varchar](50) NOT NULL,
	[EmailId] [varchar](50) NOT NULL,
	[Course] [varchar](50) NOT NULL,
	[Enrolle] [bit] NOT NULL,
	[Fees] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteStudent]    Script Date: 3/31/2020 2:19:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[spDeleteStudent] 
	@studentId int
AS
BEGIN
	
	SET NOCOUNT ON;
	
delete from Student where StudentId=@studentId;
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertStudent]    Script Date: 3/31/2020 2:19:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertStudent] 
	@Name varchar(50),
	@MobileNumber varchar(50),
	@EmailId varchar(50),
	@Course varchar(50),
	@Enrolle bit,
	@Fees varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	
	insert into Student(name,Mobilenumber,EmailId,Course,Enrolle,Fees) 
	             values(@Name,@MobileNumber,@EmailId,@Course,@Enrolle,@Fees);
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateStudent]    Script Date: 3/31/2020 2:19:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[spUpdateStudent] 
	@studentId int,
	@Name varchar(50),
	@MobileNumber varchar(50),
	@EmailId varchar(50),
	@Course varchar(50),
	@Enrolle bit,
	@Fees varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	
	update Student set Name=@name,MobileNumber=@MobileNumber,EmailId=@EmailId,Course=@Course,Enrolle=@Enrolle,Fees=@Fees 
	where StudentId=@studentId;
END
GO
USE [master]
GO
ALTER DATABASE [StudentInfoDb] SET  READ_WRITE 
GO
