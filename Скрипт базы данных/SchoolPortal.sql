USE [master]
GO
/****** Object:  Database [SchoolPortal]    Script Date: 28.02.2022 3:50:52 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'SchoolPortal')
BEGIN
CREATE DATABASE [SchoolPortal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolPortal', FILENAME = N'b:\SQL\MSSQL11.SQLEXPRESS\MSSQL\DATA\SchoolPortal.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SchoolPortal_log', FILENAME = N'b:\SQL\MSSQL11.SQLEXPRESS\MSSQL\DATA\SchoolPortal_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
ALTER DATABASE [SchoolPortal] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolPortal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolPortal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolPortal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolPortal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolPortal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolPortal] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolPortal] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SchoolPortal] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolPortal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolPortal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolPortal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolPortal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolPortal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolPortal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolPortal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolPortal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolPortal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolPortal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolPortal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolPortal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolPortal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolPortal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolPortal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolPortal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolPortal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolPortal] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolPortal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolPortal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolPortal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolPortal] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SchoolPortal]
GO
/****** Object:  Table [dbo].[Algebra_grades]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Algebra_grades]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Algebra_grades](
	[id] [int] NOT NULL,
	[id_Day] [int] NULL,
	[id_Teacher] [int] NULL,
	[id_Student] [int] NULL,
	[Grades] [nvarchar](50) NULL,
 CONSTRAINT [PK_Algebra_grades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Geometry_grades]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Geometry_grades]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Geometry_grades](
	[id] [int] NOT NULL,
	[id_Day] [int] NULL,
	[id_Teacher] [int] NULL,
	[id_Student] [int] NULL,
	[Grades] [nvarchar](50) NULL,
 CONSTRAINT [PK_Geometry_grades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Grades_Students]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Grades_Students]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Grades_Students](
	[id] [int] NOT NULL,
	[id_Day] [int] NULL,
	[id_Student] [int] NULL,
	[Algebra] [nvarchar](50) NULL,
	[Geometry] [nvarchar](50) NULL,
	[Literature] [nvarchar](50) NULL,
	[Physical_education] [nvarchar](50) NULL,
	[Russian_language] [nvarchar](50) NULL,
	[Work_] [nvarchar](50) NULL,
 CONSTRAINT [PK_Grades_Students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Literature_grades]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Literature_grades]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Literature_grades](
	[Id] [int] NOT NULL,
	[id_Day] [int] NOT NULL,
	[id_Teacher] [int] NULL,
	[id_Student] [int] NULL,
	[Grades] [nvarchar](50) NULL,
 CONSTRAINT [PK_Literature_grades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Physical_education_grades]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Physical_education_grades]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Physical_education_grades](
	[id] [int] NOT NULL,
	[id_Day] [int] NOT NULL,
	[id_Teacher] [int] NULL,
	[id_Student] [int] NULL,
	[Grades] [nvarchar](50) NULL,
 CONSTRAINT [PK_Physical_education_grades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Russian_language_grades]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Russian_language_grades]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Russian_language_grades](
	[id] [int] NOT NULL,
	[id_Day] [int] NULL,
	[id_Teacher] [int] NULL,
	[id_Student] [int] NULL,
	[Grades] [nvarchar](50) NULL,
 CONSTRAINT [PK_Russian_language_grades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schedule]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Schedule](
	[id_Day] [int] NOT NULL,
	[Date] [date] NULL,
	[Key_] [nvarchar](50) NULL,
	[Day_of_the_week] [nvarchar](50) NULL,
	[Lesson1] [nvarchar](50) NULL,
	[Lesson2] [nvarchar](50) NULL,
	[Lesson3] [nvarchar](50) NULL,
	[Lesson4] [nvarchar](50) NULL,
	[Lesson5] [nvarchar](50) NULL,
	[Lesson6] [nvarchar](50) NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[id_Day] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Secret_key]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Secret_key]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Secret_key](
	[Key_] [nvarchar](50) NOT NULL,
	[Secret_code] [nvarchar](50) NULL,
 CONSTRAINT [PK_Secret_key] PRIMARY KEY CLUSTERED 
(
	[Key_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Students]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Students]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Students](
	[id_Student] [int] NOT NULL,
	[Key_] [nvarchar](50) NULL,
	[Last_name] [nvarchar](50) NULL,
	[First_name] [nvarchar](50) NULL,
	[Middle_name] [nvarchar](50) NULL,
	[Class] [nvarchar](50) NULL,
	[Number_phone] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[Street_address] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[id_Student] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Teachers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Teachers](
	[id_Teacher] [int] NOT NULL,
	[Key_] [nvarchar](50) NULL,
	[FIO_Teacher] [nvarchar](50) NULL,
	[Subject] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[id_Teacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Work_grades]    Script Date: 28.02.2022 3:50:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Work_grades]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Work_grades](
	[id] [int] NOT NULL,
	[id_Day] [int] NULL,
	[id_Teacher] [int] NULL,
	[id_Student] [int] NULL,
	[Grades] [nvarchar](50) NULL,
 CONSTRAINT [PK_Work_grades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (1, 1, 1, 1, N'4')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (2, 1, 1, 1, N'н')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (3, 3, 1, 1, N'+')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (4, 1, 1, 2, N'4')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (5, 1, 1, 2, N'5')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (6, 3, 1, 2, N'3')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (7, 1, 1, 3, N'5')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (8, 1, 1, 3, N'3')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (9, 3, 1, 3, N'+')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (10, 4, 1, 1, N'3')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (11, 4, 1, 1, N'3')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (12, 4, 1, 2, N'+')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (13, 3, 1, 3, N'+')
INSERT [dbo].[Algebra_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (14, 3, 1, 1, N'+')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (1, 2, 2, 1, N'4')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (2, 2, 2, 1, N'5')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (3, 3, 2, 1, N'5')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (4, 3, 2, 1, N'4')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (5, 2, 2, 2, N'+')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (6, 2, 2, 2, N'н')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (7, 3, 2, 2, N'3')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (8, 3, 2, 2, N'3')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (9, 2, 2, 3, N'б')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (10, 2, 2, 3, N'5')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (11, 3, 2, 3, N'4')
INSERT [dbo].[Geometry_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (12, 3, 2, 3, N'4')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (1, 1, 1, N'4', N'-', N'5', N'-', N'-', N'5')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (2, 1, 1, N'н', N'-', N'5', N'-', N'-', N'4')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (3, 2, 1, N'-', N'4', N'4', N'+', N'4', N'4')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (4, 2, 1, N'-', N'5', N'-', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (5, 3, 1, N'+', N'5', N'4', N'4', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (6, 3, 1, N'-', N'4', N'5', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (7, 1, 2, N'5', N'-', N'4', N'-', N'-', N'5')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (8, 1, 2, N'4', N'-', N'3', N'-', N'-', N'4')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (9, 2, 2, N'-', N'+', N'+', N'5', N'+', N'3')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (10, 2, 2, N'-', N'4', N'-', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (11, 3, 2, N'3', N'3', N'+', N'3', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (12, 3, 2, N'-', N'3', N'2', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (13, 1, 3, N'5', N'-', N'4', N'-', N'-', N'4')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (14, 1, 3, N'3', N'-', N'2', N'-', N'-', N'4')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (15, 2, 3, N'-', N'б', N'+', N'+', N'+', N'5')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (16, 2, 3, N'-', N'5', N'-', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (17, 3, 3, N'+', N'4', N'3', N'+', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (18, 3, 3, N'-', N'4', N'2', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (19, 4, 1, N'3', N'-', N'-', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (20, 4, 1, N'3', N'-', N'-', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (22, 3, 3, N'5', N'-', N'-', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (23, 3, 3, N'+', N'-', N'-', N'-', N'-', N'-')
INSERT [dbo].[Grades_Students] ([id], [id_Day], [id_Student], [Algebra], [Geometry], [Literature], [Physical_education], [Russian_language], [Work_]) VALUES (24, 3, 1, N'+', N'-', N'-', N'-', N'-', N'-')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (1, 1, 4, 1, N'5')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (2, 1, 4, 1, N'5')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (3, 2, 4, 1, N'4')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (4, 3, 4, 1, N'4')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (5, 3, 4, 1, N'5')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (6, 1, 4, 2, N'4')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (7, 1, 4, 2, N'3')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (8, 2, 4, 2, N'+')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (9, 3, 4, 2, N'+')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (10, 3, 4, 2, N'2')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (11, 1, 4, 3, N'4')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (12, 1, 4, 3, N'2')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (13, 2, 4, 3, N'+')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (14, 3, 4, 3, N'3')
INSERT [dbo].[Literature_grades] ([Id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (15, 3, 4, 3, N'2')
INSERT [dbo].[Physical_education_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (1, 2, 5, 1, N'+')
INSERT [dbo].[Physical_education_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (2, 3, 5, 1, N'4')
INSERT [dbo].[Physical_education_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (3, 2, 5, 2, N'5')
INSERT [dbo].[Physical_education_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (4, 3, 5, 2, N'3')
INSERT [dbo].[Physical_education_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (5, 2, 5, 3, N'+')
INSERT [dbo].[Physical_education_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (6, 3, 5, 3, N'+')
INSERT [dbo].[Russian_language_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (1, 2, 3, 1, N'4')
INSERT [dbo].[Russian_language_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (2, 2, 3, 2, N'+')
INSERT [dbo].[Russian_language_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (3, 2, 3, 3, N'+')
INSERT [dbo].[Schedule] ([id_Day], [Date], [Key_], [Day_of_the_week], [Lesson1], [Lesson2], [Lesson3], [Lesson4], [Lesson5], [Lesson6]) VALUES (1, CAST(0x9E430B00 AS Date), N'fok1', N'Monday', N'Algebra ', N'Algebra ', N'Literature', N'Literature', N'Work', N'Work')
INSERT [dbo].[Schedule] ([id_Day], [Date], [Key_], [Day_of_the_week], [Lesson1], [Lesson2], [Lesson3], [Lesson4], [Lesson5], [Lesson6]) VALUES (2, CAST(0x9F430B00 AS Date), N'fok1', N'Tuesday ', N'Literature', N'Russian language', N'Geometry', N'Geometry', N'Work', N'Physical Education')
INSERT [dbo].[Schedule] ([id_Day], [Date], [Key_], [Day_of_the_week], [Lesson1], [Lesson2], [Lesson3], [Lesson4], [Lesson5], [Lesson6]) VALUES (3, CAST(0xA0430B00 AS Date), N'fok1', N'Wednesday ', N'Physical Education', N'Geometry', N'Algebra ', N'Literature', N'Literature', N'Geometry')
INSERT [dbo].[Schedule] ([id_Day], [Date], [Key_], [Day_of_the_week], [Lesson1], [Lesson2], [Lesson3], [Lesson4], [Lesson5], [Lesson6]) VALUES (4, CAST(0xA1430B00 AS Date), N'fok1', N'Thursday ', N'Algebra ', N'Physical Education', N'Literature', N'Work', N'Geometry', N'Physical Education')
INSERT [dbo].[Schedule] ([id_Day], [Date], [Key_], [Day_of_the_week], [Lesson1], [Lesson2], [Lesson3], [Lesson4], [Lesson5], [Lesson6]) VALUES (5, CAST(0xA2430B00 AS Date), N'fok1', N'Friday ', N'Literature', N'Work', N'Work', N'Russian language', N'Algebra ', N'Geometry')
INSERT [dbo].[Secret_key] ([Key_], [Secret_code]) VALUES (N'fok1', N'031113')
INSERT [dbo].[Students] ([id_Student], [Key_], [Last_name], [First_name], [Middle_name], [Class], [Number_phone], [Mail], [Street_address], [Login], [Password]) VALUES (1, N'fok1', N'Алексеев', N'Виктор', N'Васильевич', N'A', N'7 (909) 446-40-63', N'majip64560@sueshaw.com', N'ул. Новомосковская, дом 73, квартира 23', N'stud1', N'111')
INSERT [dbo].[Students] ([id_Student], [Key_], [Last_name], [First_name], [Middle_name], [Class], [Number_phone], [Mail], [Street_address], [Login], [Password]) VALUES (2, N'fok1', N'Канаев', N'Зиновий', N'Викторович', N'A', N'7 (991) 595-41-46', N'gucremeuddouqueu@yopmail.com', N'ул. Дворцовая пл, дом 37, квартира 81', N'stud2', N'222')
INSERT [dbo].[Students] ([id_Student], [Key_], [Last_name], [First_name], [Middle_name], [Class], [Number_phone], [Mail], [Street_address], [Login], [Password]) VALUES (3, N'fok1', N'Охота', N'Ерофей', N'Матвеевич', N'A', N'7 (905) 585-84-40', N'fraulleiveudala@yopmail.com', N'ул. Козловский М. пер, дом 156, квартира 587', N'stud3', N'333')
INSERT [dbo].[Students] ([id_Student], [Key_], [Last_name], [First_name], [Middle_name], [Class], [Number_phone], [Mail], [Street_address], [Login], [Password]) VALUES (4, N'fok1', N'Алексеев', N'Виктор', N'Васильевич', N'A', N'7 (909) 446-35-63', N'fraulleiveudala@mail.com', N'ул. Козловский М. пер, дом 156, квара 587', N'stud4', N'444')
INSERT [dbo].[Teachers] ([id_Teacher], [Key_], [FIO_Teacher], [Subject], [Login], [Password]) VALUES (1, N'fok1', N'Остимчук Анна Платоновна', N'Algebra', N'Teach1', N'1111')
INSERT [dbo].[Teachers] ([id_Teacher], [Key_], [FIO_Teacher], [Subject], [Login], [Password]) VALUES (2, N'fok1', N'Остимчук Анна Платоновна', N'Geometry', N'Teach11', N'1111')
INSERT [dbo].[Teachers] ([id_Teacher], [Key_], [FIO_Teacher], [Subject], [Login], [Password]) VALUES (3, N'fok1', N'Бетрозов Пантелеймон Богданович', N'Russian language', N'Teach2', N'2222')
INSERT [dbo].[Teachers] ([id_Teacher], [Key_], [FIO_Teacher], [Subject], [Login], [Password]) VALUES (4, N'fok1', N'Бетрозов Пантелеймон Богданович', N'Literature', N'Teach12', N'2222')
INSERT [dbo].[Teachers] ([id_Teacher], [Key_], [FIO_Teacher], [Subject], [Login], [Password]) VALUES (5, N'fok1', N'Орлова Мальвина Евгеньевна', N'Physical education', N'Teach3', N'3333')
INSERT [dbo].[Teachers] ([id_Teacher], [Key_], [FIO_Teacher], [Subject], [Login], [Password]) VALUES (6, N'fok1', N'Орлова Мальвина Евгеньевна', N'Work', N'Teach13', N'3333')
INSERT [dbo].[Work_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (1, 1, 6, 1, N'5')
INSERT [dbo].[Work_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (2, 1, 6, 1, N'4')
INSERT [dbo].[Work_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (3, 2, 6, 1, N'4')
INSERT [dbo].[Work_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (4, 1, 6, 2, N'5')
INSERT [dbo].[Work_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (5, 1, 6, 2, N'4')
INSERT [dbo].[Work_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (6, 2, 6, 2, N'3')
INSERT [dbo].[Work_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (7, 1, 6, 3, N'4')
INSERT [dbo].[Work_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (8, 1, 6, 3, N'4')
INSERT [dbo].[Work_grades] ([id], [id_Day], [id_Teacher], [id_Student], [Grades]) VALUES (9, 2, 6, 3, N'5')
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Algebra_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Algebra_grades]'))
ALTER TABLE [dbo].[Algebra_grades]  WITH CHECK ADD  CONSTRAINT [FK_Algebra_grades_Schedule] FOREIGN KEY([id_Day])
REFERENCES [dbo].[Schedule] ([id_Day])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Algebra_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Algebra_grades]'))
ALTER TABLE [dbo].[Algebra_grades] CHECK CONSTRAINT [FK_Algebra_grades_Schedule]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Algebra_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Algebra_grades]'))
ALTER TABLE [dbo].[Algebra_grades]  WITH CHECK ADD  CONSTRAINT [FK_Algebra_grades_Students] FOREIGN KEY([id_Student])
REFERENCES [dbo].[Students] ([id_Student])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Algebra_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Algebra_grades]'))
ALTER TABLE [dbo].[Algebra_grades] CHECK CONSTRAINT [FK_Algebra_grades_Students]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Algebra_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Algebra_grades]'))
ALTER TABLE [dbo].[Algebra_grades]  WITH CHECK ADD  CONSTRAINT [FK_Algebra_grades_Teachers] FOREIGN KEY([id_Teacher])
REFERENCES [dbo].[Teachers] ([id_Teacher])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Algebra_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Algebra_grades]'))
ALTER TABLE [dbo].[Algebra_grades] CHECK CONSTRAINT [FK_Algebra_grades_Teachers]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Geometry_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Geometry_grades]'))
ALTER TABLE [dbo].[Geometry_grades]  WITH CHECK ADD  CONSTRAINT [FK_Geometry_grades_Schedule] FOREIGN KEY([id_Day])
REFERENCES [dbo].[Schedule] ([id_Day])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Geometry_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Geometry_grades]'))
ALTER TABLE [dbo].[Geometry_grades] CHECK CONSTRAINT [FK_Geometry_grades_Schedule]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Geometry_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Geometry_grades]'))
ALTER TABLE [dbo].[Geometry_grades]  WITH CHECK ADD  CONSTRAINT [FK_Geometry_grades_Students] FOREIGN KEY([id_Student])
REFERENCES [dbo].[Students] ([id_Student])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Geometry_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Geometry_grades]'))
ALTER TABLE [dbo].[Geometry_grades] CHECK CONSTRAINT [FK_Geometry_grades_Students]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Geometry_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Geometry_grades]'))
ALTER TABLE [dbo].[Geometry_grades]  WITH CHECK ADD  CONSTRAINT [FK_Geometry_grades_Teachers] FOREIGN KEY([id_Teacher])
REFERENCES [dbo].[Teachers] ([id_Teacher])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Geometry_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Geometry_grades]'))
ALTER TABLE [dbo].[Geometry_grades] CHECK CONSTRAINT [FK_Geometry_grades_Teachers]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Grades_Students_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Grades_Students]'))
ALTER TABLE [dbo].[Grades_Students]  WITH CHECK ADD  CONSTRAINT [FK_Grades_Students_Schedule] FOREIGN KEY([id_Day])
REFERENCES [dbo].[Schedule] ([id_Day])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Grades_Students_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Grades_Students]'))
ALTER TABLE [dbo].[Grades_Students] CHECK CONSTRAINT [FK_Grades_Students_Schedule]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Grades_Students_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Grades_Students]'))
ALTER TABLE [dbo].[Grades_Students]  WITH CHECK ADD  CONSTRAINT [FK_Grades_Students_Students] FOREIGN KEY([id_Student])
REFERENCES [dbo].[Students] ([id_Student])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Grades_Students_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Grades_Students]'))
ALTER TABLE [dbo].[Grades_Students] CHECK CONSTRAINT [FK_Grades_Students_Students]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Literature_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Literature_grades]'))
ALTER TABLE [dbo].[Literature_grades]  WITH CHECK ADD  CONSTRAINT [FK_Literature_grades_Schedule] FOREIGN KEY([id_Day])
REFERENCES [dbo].[Schedule] ([id_Day])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Literature_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Literature_grades]'))
ALTER TABLE [dbo].[Literature_grades] CHECK CONSTRAINT [FK_Literature_grades_Schedule]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Literature_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Literature_grades]'))
ALTER TABLE [dbo].[Literature_grades]  WITH CHECK ADD  CONSTRAINT [FK_Literature_grades_Students] FOREIGN KEY([id_Student])
REFERENCES [dbo].[Students] ([id_Student])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Literature_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Literature_grades]'))
ALTER TABLE [dbo].[Literature_grades] CHECK CONSTRAINT [FK_Literature_grades_Students]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Literature_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Literature_grades]'))
ALTER TABLE [dbo].[Literature_grades]  WITH CHECK ADD  CONSTRAINT [FK_Literature_grades_Teachers] FOREIGN KEY([id_Teacher])
REFERENCES [dbo].[Teachers] ([id_Teacher])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Literature_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Literature_grades]'))
ALTER TABLE [dbo].[Literature_grades] CHECK CONSTRAINT [FK_Literature_grades_Teachers]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Physical_education_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Physical_education_grades]'))
ALTER TABLE [dbo].[Physical_education_grades]  WITH CHECK ADD  CONSTRAINT [FK_Physical_education_grades_Schedule] FOREIGN KEY([id_Day])
REFERENCES [dbo].[Schedule] ([id_Day])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Physical_education_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Physical_education_grades]'))
ALTER TABLE [dbo].[Physical_education_grades] CHECK CONSTRAINT [FK_Physical_education_grades_Schedule]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Physical_education_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Physical_education_grades]'))
ALTER TABLE [dbo].[Physical_education_grades]  WITH CHECK ADD  CONSTRAINT [FK_Physical_education_grades_Students] FOREIGN KEY([id_Student])
REFERENCES [dbo].[Students] ([id_Student])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Physical_education_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Physical_education_grades]'))
ALTER TABLE [dbo].[Physical_education_grades] CHECK CONSTRAINT [FK_Physical_education_grades_Students]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Physical_education_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Physical_education_grades]'))
ALTER TABLE [dbo].[Physical_education_grades]  WITH CHECK ADD  CONSTRAINT [FK_Physical_education_grades_Teachers] FOREIGN KEY([id_Teacher])
REFERENCES [dbo].[Teachers] ([id_Teacher])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Physical_education_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Physical_education_grades]'))
ALTER TABLE [dbo].[Physical_education_grades] CHECK CONSTRAINT [FK_Physical_education_grades_Teachers]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Russian_language_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Russian_language_grades]'))
ALTER TABLE [dbo].[Russian_language_grades]  WITH CHECK ADD  CONSTRAINT [FK_Russian_language_grades_Schedule] FOREIGN KEY([id_Day])
REFERENCES [dbo].[Schedule] ([id_Day])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Russian_language_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Russian_language_grades]'))
ALTER TABLE [dbo].[Russian_language_grades] CHECK CONSTRAINT [FK_Russian_language_grades_Schedule]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Russian_language_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Russian_language_grades]'))
ALTER TABLE [dbo].[Russian_language_grades]  WITH CHECK ADD  CONSTRAINT [FK_Russian_language_grades_Students] FOREIGN KEY([id_Student])
REFERENCES [dbo].[Students] ([id_Student])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Russian_language_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Russian_language_grades]'))
ALTER TABLE [dbo].[Russian_language_grades] CHECK CONSTRAINT [FK_Russian_language_grades_Students]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Russian_language_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Russian_language_grades]'))
ALTER TABLE [dbo].[Russian_language_grades]  WITH CHECK ADD  CONSTRAINT [FK_Russian_language_grades_Teachers] FOREIGN KEY([id_Teacher])
REFERENCES [dbo].[Teachers] ([id_Teacher])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Russian_language_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Russian_language_grades]'))
ALTER TABLE [dbo].[Russian_language_grades] CHECK CONSTRAINT [FK_Russian_language_grades_Teachers]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Students_Secret_key]') AND parent_object_id = OBJECT_ID(N'[dbo].[Students]'))
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Secret_key] FOREIGN KEY([Key_])
REFERENCES [dbo].[Secret_key] ([Key_])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Students_Secret_key]') AND parent_object_id = OBJECT_ID(N'[dbo].[Students]'))
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Secret_key]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Teachers_Secret_key]') AND parent_object_id = OBJECT_ID(N'[dbo].[Teachers]'))
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Secret_key] FOREIGN KEY([Key_])
REFERENCES [dbo].[Secret_key] ([Key_])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Teachers_Secret_key]') AND parent_object_id = OBJECT_ID(N'[dbo].[Teachers]'))
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Secret_key]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Work_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Work_grades]'))
ALTER TABLE [dbo].[Work_grades]  WITH CHECK ADD  CONSTRAINT [FK_Work_grades_Schedule] FOREIGN KEY([id_Day])
REFERENCES [dbo].[Schedule] ([id_Day])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Work_grades_Schedule]') AND parent_object_id = OBJECT_ID(N'[dbo].[Work_grades]'))
ALTER TABLE [dbo].[Work_grades] CHECK CONSTRAINT [FK_Work_grades_Schedule]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Work_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Work_grades]'))
ALTER TABLE [dbo].[Work_grades]  WITH CHECK ADD  CONSTRAINT [FK_Work_grades_Students] FOREIGN KEY([id_Student])
REFERENCES [dbo].[Students] ([id_Student])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Work_grades_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Work_grades]'))
ALTER TABLE [dbo].[Work_grades] CHECK CONSTRAINT [FK_Work_grades_Students]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Work_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Work_grades]'))
ALTER TABLE [dbo].[Work_grades]  WITH CHECK ADD  CONSTRAINT [FK_Work_grades_Teachers] FOREIGN KEY([id_Teacher])
REFERENCES [dbo].[Teachers] ([id_Teacher])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Work_grades_Teachers]') AND parent_object_id = OBJECT_ID(N'[dbo].[Work_grades]'))
ALTER TABLE [dbo].[Work_grades] CHECK CONSTRAINT [FK_Work_grades_Teachers]
GO
USE [master]
GO
ALTER DATABASE [SchoolPortal] SET  READ_WRITE 
GO
