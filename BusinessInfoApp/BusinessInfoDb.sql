USE [master]
GO
/****** Object:  Database [BusinessInfoDb]    Script Date: 3/27/2020 5:26:39 PM ******/
CREATE DATABASE [BusinessInfoDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusinessDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BusinessDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BusinessDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BusinessDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BusinessInfoDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusinessInfoDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BusinessInfoDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BusinessInfoDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BusinessInfoDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BusinessInfoDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BusinessInfoDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BusinessInfoDb] SET  MULTI_USER 
GO
ALTER DATABASE [BusinessInfoDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BusinessInfoDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BusinessInfoDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BusinessInfoDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BusinessInfoDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BusinessInfoDb] SET QUERY_STORE = OFF
GO
USE [BusinessInfoDb]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 3/27/2020 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[EmployeeType] [varchar](50) NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 3/27/2020 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [varchar](50) NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectDetails]    Script Date: 3/27/2020 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectDetails](
	[ProjectDetailId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[ProjectType] [varchar](50) NOT NULL,
	[ProjectDuration] [varchar](50) NOT NULL,
	[ProjectStartDate] [datetime] NOT NULL,
	[ProejctEndDate] [datetime] NOT NULL,
	[ProjectId] [int] NOT NULL,
 CONSTRAINT [PK_ProjectDetails] PRIMARY KEY CLUSTERED 
(
	[ProjectDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[vProjectDetailRecord]    Script Date: 3/27/2020 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vProjectDetailRecord]
AS
SELECT        dbo.Projects.ProjectId, dbo.Projects.ProjectName, dbo.ProjectDetails.ProjectType, dbo.ProjectDetails.ProjectDuration, dbo.ProjectDetails.ProjectStartDate, dbo.ProjectDetails.ProejctEndDate, dbo.Employees.Name, 
                         dbo.Employees.EmployeeId, dbo.ProjectDetails.ProjectDetailId
FROM            dbo.Employees INNER JOIN
                         dbo.Projects ON dbo.Employees.EmployeeId = dbo.Projects.EmployeeId INNER JOIN
                         dbo.ProjectDetails ON dbo.Projects.ProjectId = dbo.ProjectDetails.ProjectId
GO
ALTER TABLE [dbo].[ProjectDetails]  WITH CHECK ADD  CONSTRAINT [FK_ProjectDetails_Projects] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([ProjectId])
GO
ALTER TABLE [dbo].[ProjectDetails] CHECK CONSTRAINT [FK_ProjectDetails_Projects]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_Employees]
GO
/****** Object:  StoredProcedure [dbo].[spAddProject]    Script Date: 3/27/2020 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spAddProject] 
	-- Add the parameters for the stored procedure here
	@ProjectName varchar(50),
	@EmployeeId int,
	@Description varchar(Max),
	@ProjectType varchar(50),
	@ProjectDuration varchar(50),
	@ProjectStartDate datetime,
	@ProjectEndDate datetime
	

AS
BEGIN
	declare @ProjectId int;
	
	SET NOCOUNT ON;
	insert into Projects(ProjectName,EmployeeId)
	values(@ProjectName,@EmployeeId);
	set @ProjectId=@@IDENTITY;

	insert into ProjectDetails(Description,ProjectType,ProjectDuration,ProjectStartDate,ProejctEndDate,ProjectId)
	values(@Description,@ProjectType,@ProjectDuration,@ProjectStartDate,@ProjectEndDate,@ProjectId);
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[10] 4[51] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Employees"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 186
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ProjectDetails"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 196
               Right = 420
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Projects"
            Begin Extent = 
               Top = 6
               Left = 458
               Bottom = 136
               Right = 628
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2520
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vProjectDetailRecord'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vProjectDetailRecord'
GO
USE [master]
GO
ALTER DATABASE [BusinessInfoDb] SET  READ_WRITE 
GO
