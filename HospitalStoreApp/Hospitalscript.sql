USE [master]
GO
/****** Object:  Database [HospitalDepartmentDb]    Script Date: 3/25/2020 6:09:48 PM ******/
CREATE DATABASE [HospitalDepartmentDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HospitalDepartmentDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HospitalDepartmentDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HospitalDepartmentDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HospitalDepartmentDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HospitalDepartmentDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HospitalDepartmentDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HospitalDepartmentDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HospitalDepartmentDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HospitalDepartmentDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HospitalDepartmentDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HospitalDepartmentDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HospitalDepartmentDb] SET  MULTI_USER 
GO
ALTER DATABASE [HospitalDepartmentDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HospitalDepartmentDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HospitalDepartmentDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HospitalDepartmentDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HospitalDepartmentDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HospitalDepartmentDb] SET QUERY_STORE = OFF
GO
USE [HospitalDepartmentDb]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 3/25/2020 6:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 3/25/2020 6:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorId] [int] IDENTITY(1,1) NOT NULL,
	[DoctorName] [varchar](50) NOT NULL,
	[Speciality] [varchar](50) NOT NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[DoctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Doctors] UNIQUE NONCLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientDrugsDeatils]    Script Date: 3/25/2020 6:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientDrugsDeatils](
	[PatientDrugsId] [int] IDENTITY(1,1) NOT NULL,
	[Morning] [varchar](50) NOT NULL,
	[AfterNoon] [varchar](50) NOT NULL,
	[Night] [varchar](50) NOT NULL,
	[PatientId] [int] NOT NULL,
 CONSTRAINT [PK_PatientDrugsDeatils] PRIMARY KEY CLUSTERED 
(
	[PatientDrugsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 3/25/2020 6:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[PatientName] [varchar](50) NOT NULL,
	[PatientType] [varchar](50) NOT NULL,
	[DoctorId] [int] NOT NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Doctors_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([DepartmentId])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [FK_Doctors_Departments]
GO
ALTER TABLE [dbo].[PatientDrugsDeatils]  WITH CHECK ADD  CONSTRAINT [FK_PatientDrugsDeatils_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([PatientId])
GO
ALTER TABLE [dbo].[PatientDrugsDeatils] CHECK CONSTRAINT [FK_PatientDrugsDeatils_Patients]
GO
ALTER TABLE [dbo].[Patients]  WITH CHECK ADD  CONSTRAINT [FK_Patients_Patients] FOREIGN KEY([DoctorId])
REFERENCES [dbo].[Doctors] ([DoctorId])
GO
ALTER TABLE [dbo].[Patients] CHECK CONSTRAINT [FK_Patients_Patients]
GO
USE [master]
GO
ALTER DATABASE [HospitalDepartmentDb] SET  READ_WRITE 
GO
