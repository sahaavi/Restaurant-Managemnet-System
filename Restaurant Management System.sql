USE [master]
GO
/****** Object:  Database [Restaurant Management System]    Script Date: 13-Dec-19 12:54:26 AM ******/
CREATE DATABASE [Restaurant Management System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Restaurant Management System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Restaurant Management System.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Restaurant Management System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Restaurant Management System_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Restaurant Management System] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Restaurant Management System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Restaurant Management System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Restaurant Management System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Restaurant Management System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Restaurant Management System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Restaurant Management System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Restaurant Management System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Restaurant Management System] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Restaurant Management System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Restaurant Management System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Restaurant Management System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Restaurant Management System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Restaurant Management System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Restaurant Management System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Restaurant Management System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Restaurant Management System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Restaurant Management System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Restaurant Management System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Restaurant Management System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Restaurant Management System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Restaurant Management System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Restaurant Management System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Restaurant Management System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Restaurant Management System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Restaurant Management System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Restaurant Management System] SET  MULTI_USER 
GO
ALTER DATABASE [Restaurant Management System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Restaurant Management System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Restaurant Management System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Restaurant Management System] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Restaurant Management System]
GO
/****** Object:  StoredProcedure [dbo].[popular_item]    Script Date: 13-Dec-19 12:54:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[popular_item]
as
	begin
SELECT COUNT (Item_Id)*1.0/(select count(Item_Id) from [dbo].[Sales])  AS 'Total Sales Unit'
			,Name AS 'Name'
FROM [dbo].Sales
Group by Name

	end
GO
/****** Object:  Table [dbo].[Customer_List]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_List](
	[CusId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NOT NULL,
	[Contact] [nchar](15) NOT NULL,
	[Address] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Customer_List] PRIMARY KEY CLUSTERED 
(
	[CusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Expenses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseName] [varchar](50) NOT NULL,
	[ExpenseAmount] [float] NOT NULL,
	[ExpenseDate] [date] NOT NULL,
 CONSTRAINT [PK_Expense Table] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Quantity] [float] NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Item]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Description] [text] NULL,
	[Category_Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ItemCategory] PRIMARY KEY CLUSTERED 
(
	[Category_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Purchase_Category]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Purchase_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Purchase_List]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_List](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Item_Name] [nchar](20) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Date] [date] NOT NULL,
	[Cat_Id] [int] NOT NULL,
	[Total_Price] [float] NOT NULL,
 CONSTRAINT [PK_Purchase_List] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salary_List]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary_List](
	[Eid] [int] NOT NULL,
	[Name] [nchar](20) NOT NULL,
	[Month] [nchar](10) NOT NULL,
	[Pay] [float] NOT NULL,
	[Salary] [float] NOT NULL,
	[Remain_salary] [float] NOT NULL,
	[Year] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sales]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sales](
	[Sales_Id] [int] IDENTITY(1,1) NOT NULL,
	[Item_Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [int] NULL,
	[Total_Amount] [int] NOT NULL,
	[Payment_Type] [varchar](50) NOT NULL,
	[Sale_Date] [date] NOT NULL,
	[Customer_Id] [int] NULL,
	[Cashier_Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[Sales_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_List]    Script Date: 13-Dec-19 12:54:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_List](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Contact] [int] NOT NULL,
	[NID] [int] NOT NULL,
	[Salary] [float] NOT NULL,
	[User_Name] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[User_Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User_List] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_ItemCategory] FOREIGN KEY([Category_Name])
REFERENCES [dbo].[ItemCategory] ([Category_Name])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_ItemCategory]
GO
ALTER TABLE [dbo].[Purchase_List]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_List_Purchase_Category] FOREIGN KEY([Cat_Id])
REFERENCES [dbo].[Purchase_Category] ([Id])
GO
ALTER TABLE [dbo].[Purchase_List] CHECK CONSTRAINT [FK_Purchase_List_Purchase_Category]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_ItemId] FOREIGN KEY([Item_Id])
REFERENCES [dbo].[Item] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_ItemId]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Sales1] FOREIGN KEY([Sales_Id])
REFERENCES [dbo].[Sales] ([Sales_Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Sales1]
GO
USE [master]
GO
ALTER DATABASE [Restaurant Management System] SET  READ_WRITE 
GO
