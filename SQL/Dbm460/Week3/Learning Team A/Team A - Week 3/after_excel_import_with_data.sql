USE [master]
GO
/****** Object:  Database [DBM_460_TeamDB_8]    Script Date: 10/10/2016 10:16:11 PM ******/
CREATE DATABASE [DBM_460_TeamDB_8]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBM_460_TeamDB_8', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBM_460_TeamDB_8.mdf' , SIZE = 13312KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBM_460_TeamDB_8_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DBM_460_TeamDB_8_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBM_460_TeamDB_8].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET RECOVERY FULL 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET  MULTI_USER 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBM_460_TeamDB_8', N'ON'
GO
USE [DBM_460_TeamDB_8]
GO
/****** Object:  Table [dbo].[Currency$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currency$](
	[Currency_id] [float] NULL,
	[Effective_dt] [datetime] NULL,
	[Description] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer$](
	[Customer_id] [float] NULL,
	[Customer_Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer_Detail$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Detail$](
	[Customer_id] [float] NULL,
	[Effective_dt] [datetime] NULL,
	[Days_for_payment] [float] NULL,
	[Delivery_way_id] [nvarchar](255) NULL,
	[Finance_group] [nvarchar](255) NULL,
	[Marketing_category] [nvarchar](255) NULL,
	[Type] [nvarchar](255) NULL,
	[Sales_rep_id] [numeric](38, 0) NULL,
	[Default_payment_method] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer_X_ADDR$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_X_ADDR$](
	[Customer_id] [float] NULL,
	[Effective_dt] [datetime] NULL,
	[Street_ADDR_1] [nvarchar](255) NULL,
	[Street_Addr_2] [nvarchar](255) NULL,
	[City] [nvarchar](255) NULL,
	[State] [nvarchar](255) NULL,
	[Region] [nvarchar](255) NULL,
	[Telephone_no] [nvarchar](50) NULL,
	[Zip_cd] [numeric](38, 0) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exchange_Rate$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exchange_Rate$](
	[Currency_id] [float] NULL,
	[Effective_dt] [datetime] NULL,
	[Exchange_Rate_To_US_Dollar] [decimal](38, 0) NULL,
	[End_dt] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory$](
	[Product_id] [float] NULL,
	[Warehouse_id] [float] NULL,
	[Inventory_Effective_dt] [datetime] NULL,
	[Units_on_shelf] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Invoice$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice$](
	[Invoice_id] [float] NULL,
	[Invoice_dt] [datetime] NULL,
	[Book_dt] [datetime] NULL,
	[Due_dt] [datetime] NULL,
	[Invoice_amt] [float] NULL,
	[Customer_id] [float] NULL,
	[Supplier_Id] [float] NULL,
	[Order_id] [float] NULL,
	[Payment_Method] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order$](
	[Order_id] [float] NULL,
	[Order_type_id] [float] NULL,
	[Customer_invoice_id] [float] NULL,
	[Customer_delivery_id] [float] NULL,
	[Days_for_payment] [float] NULL,
	[Delivery_way_id] [nvarchar](255) NULL,
	[Order_status_cd] [float] NULL,
	[Order_dt] [datetime] NULL,
	[Delivery_dt] [datetime] NULL,
	[Booked_dt] [datetime] NULL,
	[Order_discount_percent] [float] NULL,
	[Contact_number] [float] NULL,
	[Inventory_number] [float] NULL,
	[Currency_id] [float] NULL,
	[Customer_id] [float] NULL,
	[Invoice_id] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order_Line$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Line$](
	[Order_id] [float] NULL,
	[Order_line_id] [float] NULL,
	[Unit_id] [float] NULL,
	[Warehouse_id] [float] NULL,
	[Delivery_Request_dt] [datetime] NULL,
	[Delivery_commit_dt] [datetime] NULL,
	[Ordered_quantity] [float] NULL,
	[Allocated_quantity] [float] NULL,
	[Real_quantity] [float] NULL,
	[Invoiced_quantity] [float] NULL,
	[Unit_price_amt] [float] NULL,
	[Unit_cost_amt] [float] NULL,
	[Volume_discount_percentage] [float] NULL,
	[Customer_discount_percentage] [float] NULL,
	[Invoice_id] [float] NULL,
	[Product_id] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product$](
	[Product_Id] [float] NULL,
	[Product_name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Supplier_key] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product_Detail$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Detail$](
	[Product_id] [float] NULL,
	[Product_effective_dt] [datetime] NULL,
	[Status] [nvarchar](255) NULL,
	[Supplier] [nvarchar](255) NULL,
	[Units_per_pallet] [float] NULL,
	[Units_per_package] [float] NULL,
	[Unit_price] [float] NULL,
	[Unit_cost] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sales_Product$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales_Product$](
	[Sales_product_id] [float] NULL,
	[Sales_product_name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[City] [nvarchar](255) NULL,
	[Country] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sales_Rep$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales_Rep$](
	[Sales_rep_id] [float] NULL,
	[Sales_rep_name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Employee_code] [float] NULL,
	[Manager_id] [float] NULL,
	[Sales_product_id] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shipment$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipment$](
	[Order_line_id] [float] NULL,
	[Shipment_dt] [datetime] NULL,
	[Carrier] [nvarchar](255) NULL,
	[Delivery_dt] [datetime] NULL,
	[Warehouse_id] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier$](
	[Supplier_id] [float] NULL,
	[Supplier_name] [nvarchar](255) NULL,
	[City] [nvarchar](255) NULL,
	[Country] [nvarchar](255) NULL,
	[Telephone_number] [nvarchar](50) NULL,
	[Discount_Percentage] [float] NULL,
	[Contact_person_name] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Warehouse$]    Script Date: 10/10/2016 10:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse$](
	[Warehouse_id] [float] NULL,
	[Warehouse_name] [nvarchar](255) NULL,
	[Warehouse_addr_first_line] [nvarchar](255) NULL,
	[Warehouse_addr_second_line] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[City] [nvarchar](255) NULL,
	[Country] [nvarchar](255) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (1, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Argentine Peso')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (2, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Australian Dollar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (3, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Bahraini Dinar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (4, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Botswana Pula')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (5, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Brazilian Real')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (6, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'British Pound')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (7, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Bruneian Dollar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (8, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Bulgarian Lev')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (9, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Canadian Dollar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (10, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Chilean Peso')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (11, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Chinese Yuan Renminbi')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (12, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Colombian Peso')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (13, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Croatian Kuna')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (14, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Czech Koruna')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (15, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Danish Krone')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (16, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Emirati Dirham')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (17, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Euro')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (18, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Hong Kong Dollar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (19, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Hungarian Forint')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Icelandic Krona')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (21, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Indian Rupee')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (22, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Indonesian Rupiah')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (23, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Iranian Rial')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (24, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Israeli Shekel')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (25, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Japanese Yen')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (26, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Kazakhstani Tenge')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (27, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Kuwaiti Dinar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (28, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Latvian Lat')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (29, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Libyan Dinar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (30, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Lithuanian Litas')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (31, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Malaysian Ringgit')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (32, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Mauritian Rupee')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (33, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Mexican Peso')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (34, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Nepalese Rupee')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (35, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'New Zealand Dollar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (36, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Norwegian Krone')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (37, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Omani Rial')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (38, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Pakistani Rupee')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (39, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Philippine Peso')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (40, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Polish Zloty')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (41, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Qatari Riyal')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (42, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Romanian New Leu')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (43, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Russian Ruble')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (44, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Saudi Arabian Riyal')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (45, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Singapore Dollar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (46, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'South African Rand')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (47, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'South Korean Won')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (48, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Sri Lankan Rupee')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (49, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Swedish Krona')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (50, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Swiss Franc')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (51, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Taiwan New Dollar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (52, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Thai Baht')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (53, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Trinidadian Dollar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (54, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Turkish Lira')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (55, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'United States Dollar')
INSERT [dbo].[Currency$] ([Currency_id], [Effective_dt], [Description]) VALUES (56, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'Venezuelan Bolivar')
INSERT [dbo].[Customer$] ([Customer_id], [Customer_Name], [Description]) VALUES (23, N'Geraldine Billingsby', N'Elegance Catering Service')
INSERT [dbo].[Customer$] ([Customer_id], [Customer_Name], [Description]) VALUES (28, N'Stanley Reinholdt', N'Golden Moments Events Center')
INSERT [dbo].[Customer$] ([Customer_id], [Customer_Name], [Description]) VALUES (32, N'William Dorsey', N'Table Mountain Resort')
INSERT [dbo].[Customer$] ([Customer_id], [Customer_Name], [Description]) VALUES (35, N'Janet Carson', N'North Coast Bed and Breakfast')
INSERT [dbo].[Customer$] ([Customer_id], [Customer_Name], [Description]) VALUES (40, N'Allison Jeffries', N'McHenry''s Fine Steakhouse')
INSERT [dbo].[Customer$] ([Customer_id], [Customer_Name], [Description]) VALUES (43, N'James Yoder', N'Yoder Family Delicatessen')
INSERT [dbo].[Customer$] ([Customer_id], [Customer_Name], [Description]) VALUES (52, N'John Grossman', N'Sweet Beginnings')
INSERT [dbo].[Customer_Detail$] ([Customer_id], [Effective_dt], [Days_for_payment], [Delivery_way_id], [Finance_group], [Marketing_category], [Type], [Sales_rep_id], [Default_payment_method]) VALUES (23, CAST(N'2013-06-19 00:00:00.000' AS DateTime), 30, N'Air', N'Cal West', N'Caterer', N'A', CAST(1118 AS Numeric(38, 0)), N'Credit Card')
INSERT [dbo].[Customer_Detail$] ([Customer_id], [Effective_dt], [Days_for_payment], [Delivery_way_id], [Finance_group], [Marketing_category], [Type], [Sales_rep_id], [Default_payment_method]) VALUES (28, CAST(N'2013-08-15 00:00:00.000' AS DateTime), 30, N'Air', N'Edwards Financial', N'Caterer', N'A', CAST(1325 AS Numeric(38, 0)), N'Credit Card')
INSERT [dbo].[Customer_Detail$] ([Customer_id], [Effective_dt], [Days_for_payment], [Delivery_way_id], [Finance_group], [Marketing_category], [Type], [Sales_rep_id], [Default_payment_method]) VALUES (32, CAST(N'2013-10-20 00:00:00.000' AS DateTime), 10, N'Truck', N'Edwards Financial', N'Restauranteur', N'B', CAST(5023 AS Numeric(38, 0)), N'Credit Card')
INSERT [dbo].[Customer_Detail$] ([Customer_id], [Effective_dt], [Days_for_payment], [Delivery_way_id], [Finance_group], [Marketing_category], [Type], [Sales_rep_id], [Default_payment_method]) VALUES (35, CAST(N'2014-01-02 00:00:00.000' AS DateTime), 15, N'Truck', N'Mutual Group', N'Bed & Breakfast', N'C', CAST(4136 AS Numeric(38, 0)), N'Credit Card')
INSERT [dbo].[Customer_Detail$] ([Customer_id], [Effective_dt], [Days_for_payment], [Delivery_way_id], [Finance_group], [Marketing_category], [Type], [Sales_rep_id], [Default_payment_method]) VALUES (40, CAST(N'2014-06-30 00:00:00.000' AS DateTime), 10, N'Air', N'Mutual Group', N'Restauranteur', N'B', CAST(1561 AS Numeric(38, 0)), N'Credit Card')
INSERT [dbo].[Customer_Detail$] ([Customer_id], [Effective_dt], [Days_for_payment], [Delivery_way_id], [Finance_group], [Marketing_category], [Type], [Sales_rep_id], [Default_payment_method]) VALUES (43, CAST(N'2014-09-11 00:00:00.000' AS DateTime), 30, N'Truck', N'Cal West', N'Caterer', N'A', CAST(4447 AS Numeric(38, 0)), N'Credit Card')
INSERT [dbo].[Customer_Detail$] ([Customer_id], [Effective_dt], [Days_for_payment], [Delivery_way_id], [Finance_group], [Marketing_category], [Type], [Sales_rep_id], [Default_payment_method]) VALUES (52, CAST(N'2015-03-07 00:00:00.000' AS DateTime), 20, N'Air', N'Edwards Financial', N'Restauranteur', N'B', CAST(1010 AS Numeric(38, 0)), N'Credit Card')
INSERT [dbo].[Customer_X_ADDR$] ([Customer_id], [Effective_dt], [Street_ADDR_1], [Street_Addr_2], [City], [State], [Region], [Telephone_no], [Zip_cd]) VALUES (23, CAST(N'2013-06-19 00:00:00.000' AS DateTime), N'1197 Green Ash Street', N'', N'Syracuse', N'NY', N'Eastern', N'800-215-4371
', CAST(13210 AS Numeric(38, 0)))
INSERT [dbo].[Customer_X_ADDR$] ([Customer_id], [Effective_dt], [Street_ADDR_1], [Street_Addr_2], [City], [State], [Region], [Telephone_no], [Zip_cd]) VALUES (28, CAST(N'2013-08-15 00:00:00.000' AS DateTime), N'6900 Bissonnett', N'', N'Houston', N'TX', N'Southwest', N'800-275-0639
', CAST(77074 AS Numeric(38, 0)))
INSERT [dbo].[Customer_X_ADDR$] ([Customer_id], [Effective_dt], [Street_ADDR_1], [Street_Addr_2], [City], [State], [Region], [Telephone_no], [Zip_cd]) VALUES (32, CAST(N'2013-10-20 00:00:00.000' AS DateTime), N'8700 Turnpike Dr', N'', N'Arvada', N'CO', N'Southwest', N'519-601-5223
', CAST(80030 AS Numeric(38, 0)))
INSERT [dbo].[Customer_X_ADDR$] ([Customer_id], [Effective_dt], [Street_ADDR_1], [Street_Addr_2], [City], [State], [Region], [Telephone_no], [Zip_cd]) VALUES (35, CAST(N'2014-01-02 00:00:00.000' AS DateTime), N'4000 Fairfield Blvd', N'', N'San Mateo', N'CA', N'Pacific', N'02 503 07 90
', CAST(94403 AS Numeric(38, 0)))
INSERT [dbo].[Customer_X_ADDR$] ([Customer_id], [Effective_dt], [Street_ADDR_1], [Street_Addr_2], [City], [State], [Region], [Telephone_no], [Zip_cd]) VALUES (40, CAST(N'2014-06-30 00:00:00.000' AS DateTime), N'780 North Fern', N'', N'Jersey City', N'NJ', N'Eastern', NULL, CAST(7306 AS Numeric(38, 0)))
INSERT [dbo].[Customer_X_ADDR$] ([Customer_id], [Effective_dt], [Street_ADDR_1], [Street_Addr_2], [City], [State], [Region], [Telephone_no], [Zip_cd]) VALUES (43, CAST(N'2014-09-11 00:00:00.000' AS DateTime), N'7238 Fenton Dr', N'', N'Redmond', N'WA', N'Pacific', N'509-223-7435
', CAST(98052 AS Numeric(38, 0)))
INSERT [dbo].[Customer_X_ADDR$] ([Customer_id], [Effective_dt], [Street_ADDR_1], [Street_Addr_2], [City], [State], [Region], [Telephone_no], [Zip_cd]) VALUES (52, CAST(N'2015-03-07 00:00:00.000' AS DateTime), N'36 Plaza Way', N'Suite 100', N'Kansas City', N'MO', N'Central', N'+91 98222 31235
', CAST(64106 AS Numeric(38, 0)))
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (1, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(9 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (2, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(1 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (3, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(0 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (4, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(9 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (5, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(3 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (6, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(0 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (7, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(1 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (8, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(1 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (9, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(1 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (10, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(632 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (11, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(6 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (12, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(2551 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (13, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(6 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (14, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(24 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (15, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(6 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (16, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(3 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (17, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(0 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (18, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(7 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (19, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(275 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(130 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (21, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(63 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (22, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(13317 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (23, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(29400 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (24, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(3 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (25, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(122 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (26, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(186 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (27, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(0 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (28, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(0 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (29, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(1 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (30, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(3 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (31, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(3 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (32, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(34 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (33, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(15 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (34, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(101 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (35, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(1 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (36, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(7 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (37, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(0 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (38, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(101 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (39, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(44 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (40, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(3 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (41, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(3 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (42, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(3 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (43, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(54 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (44, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(3 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (45, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(1 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (46, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(12 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (47, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(1102 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (48, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(133 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (49, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(8 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (50, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(0 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (51, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(30 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (52, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(33 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (53, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(6 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (54, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(2 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (55, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(1 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Exchange_Rate$] ([Currency_id], [Effective_dt], [Exchange_Rate_To_US_Dollar], [End_dt]) VALUES (56, CAST(N'2015-06-19 00:00:00.000' AS DateTime), CAST(6 AS Decimal(38, 0)), NULL)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (110, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 436)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (115, 10, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 239)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (120, 10, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 52)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (125, 20, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 251)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (130, 20, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 87)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (130, 10, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 40)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (130, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 78)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (130, 40, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 56)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (210, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 62)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (210, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 44)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (210, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 85)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (210, 40, CAST(N'2015-06-15 00:00:00.000' AS DateTime), 90)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (220, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 54)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (220, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 28)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (220, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 60)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (220, 40, CAST(N'2015-06-15 00:00:00.000' AS DateTime), 29)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (222, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 123)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (222, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 292)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (222, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 73)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (222, 40, CAST(N'2015-06-15 00:00:00.000' AS DateTime), 41)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (224, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 159)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (224, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 240)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (224, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 202)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (224, 40, CAST(N'2015-06-15 00:00:00.000' AS DateTime), 18)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (321, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 742)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (325, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 610)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (328, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 238)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (410, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 860)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (415, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 622)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (420, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 520)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (425, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 503)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (430, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 416)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (435, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 315)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (510, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 645)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (510, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 473)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (515, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 610)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (515, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 536)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (520, 10, CAST(N'2015-06-05 00:00:00.000' AS DateTime), 471)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (520, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 362)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (525, 10, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 430)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (530, 10, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 396)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (535, 10, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 350)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (610, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 992)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (610, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 628)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (615, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 780)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (615, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 635)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (620, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 480)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (625, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 745)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (625, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 568)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (630, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 670)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (630, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 493)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (635, 20, CAST(N'2015-06-19 00:00:00.000' AS DateTime), 515)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (710, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 470)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (715, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 383)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (720, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 358)
INSERT [dbo].[Inventory$] ([Product_id], [Warehouse_id], [Inventory_Effective_dt], [Units_on_shelf]) VALUES (725, 30, CAST(N'2015-06-12 00:00:00.000' AS DateTime), 290)
INSERT [dbo].[Invoice$] ([Invoice_id], [Invoice_dt], [Book_dt], [Due_dt], [Invoice_amt], [Customer_id], [Supplier_Id], [Order_id], [Payment_Method]) VALUES (22240, CAST(N'2015-06-08 00:00:00.000' AS DateTime), CAST(N'2015-06-08 00:00:00.000' AS DateTime), CAST(N'2015-06-18 00:00:00.000' AS DateTime), 1137.5, 40, 215, 10227, N'Credit Card')
INSERT [dbo].[Invoice$] ([Invoice_id], [Invoice_dt], [Book_dt], [Due_dt], [Invoice_amt], [Customer_id], [Supplier_Id], [Order_id], [Payment_Method]) VALUES (22241, CAST(N'2015-06-10 00:00:00.000' AS DateTime), CAST(N'2015-06-10 00:00:00.000' AS DateTime), CAST(N'2015-06-20 00:00:00.000' AS DateTime), 806.25, 32, 720, 10228, N'Credit Card')
INSERT [dbo].[Invoice$] ([Invoice_id], [Invoice_dt], [Book_dt], [Due_dt], [Invoice_amt], [Customer_id], [Supplier_Id], [Order_id], [Payment_Method]) VALUES (22242, CAST(N'2015-06-12 00:00:00.000' AS DateTime), CAST(N'2015-06-12 00:00:00.000' AS DateTime), CAST(N'2015-07-12 00:00:00.000' AS DateTime), 175, 23, 650, 10229, N'Credit Card')
INSERT [dbo].[Invoice$] ([Invoice_id], [Invoice_dt], [Book_dt], [Due_dt], [Invoice_amt], [Customer_id], [Supplier_Id], [Order_id], [Payment_Method]) VALUES (22243, CAST(N'2015-06-16 00:00:00.000' AS DateTime), CAST(N'2015-06-16 00:00:00.000' AS DateTime), CAST(N'2015-07-06 00:00:00.000' AS DateTime), 45, 52, 650, 10230, N'Credit Card')
INSERT [dbo].[Invoice$] ([Invoice_id], [Invoice_dt], [Book_dt], [Due_dt], [Invoice_amt], [Customer_id], [Supplier_Id], [Order_id], [Payment_Method]) VALUES (22244, CAST(N'2015-06-18 00:00:00.000' AS DateTime), CAST(N'2015-06-18 00:00:00.000' AS DateTime), CAST(N'2015-07-03 00:00:00.000' AS DateTime), 22.5, 35, 720, 10231, N'Credit Card')
INSERT [dbo].[Invoice$] ([Invoice_id], [Invoice_dt], [Book_dt], [Due_dt], [Invoice_amt], [Customer_id], [Supplier_Id], [Order_id], [Payment_Method]) VALUES (22245, CAST(N'2015-06-20 00:00:00.000' AS DateTime), CAST(N'2015-06-20 00:00:00.000' AS DateTime), CAST(N'2015-07-20 00:00:00.000' AS DateTime), 249, 43, 720, 10232, N'Credit Card')
INSERT [dbo].[Invoice$] ([Invoice_id], [Invoice_dt], [Book_dt], [Due_dt], [Invoice_amt], [Customer_id], [Supplier_Id], [Order_id], [Payment_Method]) VALUES (22246, CAST(N'2015-06-22 00:00:00.000' AS DateTime), CAST(N'2015-06-22 00:00:00.000' AS DateTime), CAST(N'2015-07-22 00:00:00.000' AS DateTime), 180, 28, 215, 10233, N'Credit Card')
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10227, 1, 3572, 391, 10, N'Air', NULL, CAST(N'2015-06-01 00:00:00.000' AS DateTime), CAST(N'2015-06-04 00:00:00.000' AS DateTime), CAST(N'2015-06-08 00:00:00.000' AS DateTime), 0, NULL, 0, 55, 40, 22240)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10228, 1, 32477, 311, 10, N'Truck', NULL, CAST(N'2015-06-03 00:00:00.000' AS DateTime), CAST(N'2015-06-06 00:00:00.000' AS DateTime), CAST(N'2015-06-10 00:00:00.000' AS DateTime), 0, NULL, 0, 55, 32, 22241)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10229, 1, 230515, 2291, 30, N'Air', NULL, CAST(N'2015-06-05 00:00:00.000' AS DateTime), CAST(N'2015-06-08 00:00:00.000' AS DateTime), CAST(N'2015-06-12 00:00:00.000' AS DateTime), 0, NULL, 0, 55, 23, 22242)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10230, 1, 90, 511, 20, N'Air', NULL, CAST(N'2015-06-09 00:00:00.000' AS DateTime), CAST(N'2015-06-12 00:00:00.000' AS DateTime), CAST(N'2015-06-16 00:00:00.000' AS DateTime), 0, NULL, 0, 55, 52, 22243)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10231, 1, 3082, 341, 15, N'Truck', NULL, CAST(N'2015-06-11 00:00:00.000' AS DateTime), CAST(N'2015-06-14 00:00:00.000' AS DateTime), CAST(N'2015-06-18 00:00:00.000' AS DateTime), 0, NULL, 0, 55, 35, 22244)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10232, 1, 80023, 421, 30, N'Truck', NULL, CAST(N'2015-06-13 00:00:00.000' AS DateTime), CAST(N'2015-06-16 00:00:00.000' AS DateTime), CAST(N'2015-06-20 00:00:00.000' AS DateTime), 0, NULL, 0, 55, 43, 22245)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10233, 1, 2440, 271, 30, N'Air', NULL, CAST(N'2015-06-15 00:00:00.000' AS DateTime), CAST(N'2015-06-18 00:00:00.000' AS DateTime), CAST(N'2015-06-22 00:00:00.000' AS DateTime), 0, NULL, 0, 55, 28, 22246)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10234, 1, 4002, 401, 10, N'Air', NULL, CAST(N'2015-06-20 00:00:00.000' AS DateTime), NULL, NULL, 0, NULL, 0, 55, 40, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10235, 1, 32907, 321, 10, N'Truck', NULL, CAST(N'2015-06-20 00:00:00.000' AS DateTime), NULL, NULL, 0, NULL, 0, 55, 32, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10236, 1, 230945, 2301, 30, N'Air', NULL, CAST(N'2015-06-20 00:00:00.000' AS DateTime), NULL, NULL, 0, NULL, 0, 55, 23, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10237, 1, 520, 521, 20, N'Air', NULL, CAST(N'2015-06-20 00:00:00.000' AS DateTime), NULL, NULL, 0, NULL, 0, 55, 52, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10238, 1, 3512, 351, 15, N'Truck', NULL, CAST(N'2015-06-20 00:00:00.000' AS DateTime), NULL, NULL, 0, NULL, 0, 55, 35, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10239, 1, 438, 431, 30, N'Truck', NULL, CAST(N'2015-06-20 00:00:00.000' AS DateTime), NULL, NULL, 0, NULL, 0, 55, 43, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (10240, 1, 2870, 281, 30, N'Air', NULL, CAST(N'2015-06-20 00:00:00.000' AS DateTime), NULL, NULL, 0, NULL, 0, 55, 28, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order$] ([Order_id], [Order_type_id], [Customer_invoice_id], [Customer_delivery_id], [Days_for_payment], [Delivery_way_id], [Order_status_cd], [Order_dt], [Delivery_dt], [Booked_dt], [Order_discount_percent], [Contact_number], [Inventory_number], [Currency_id], [Customer_id], [Invoice_id]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10227, 54175, 0, 10, CAST(N'2015-06-16 00:00:00.000' AS DateTime), CAST(N'2015-06-16 00:00:00.000' AS DateTime), 25, 25, 25, 25, 38.5, 32.5, 0, 0, 22240, 110)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10227, 54176, 0, 10, CAST(N'2015-06-16 00:00:00.000' AS DateTime), CAST(N'2015-06-16 00:00:00.000' AS DateTime), 20, 20, 20, 20, 8.75, 7.25, 0, 0, 22240, 220)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10228, 54177, 0, 30, CAST(N'2015-06-14 00:00:00.000' AS DateTime), CAST(N'2015-06-17 00:00:00.000' AS DateTime), 15, 15, 15, 15, 38.5, 32.5, 0, 0, 22241, 110)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10228, 54178, 0, 30, CAST(N'2015-06-14 00:00:00.000' AS DateTime), CAST(N'2015-06-17 00:00:00.000' AS DateTime), 17, 17, 17, 17, 8.75, 7.25, 0, 0, 22241, 220)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10228, 54179, 0, 30, CAST(N'2015-06-14 00:00:00.000' AS DateTime), CAST(N'2015-06-17 00:00:00.000' AS DateTime), 20, 20, 20, 20, 4, 3.2, 0, 0, 22241, 510)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10229, 54180, 0, 20, CAST(N'2015-06-20 00:00:00.000' AS DateTime), CAST(N'2015-06-20 00:00:00.000' AS DateTime), 35, 35, 35, 35, 5, 4, 0, 0, 22242, 635)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10230, 54181, 0, 30, CAST(N'2015-06-17 00:00:00.000' AS DateTime), CAST(N'2015-06-20 00:00:00.000' AS DateTime), 30, 30, 30, 30, 1.5, 1.37, 0, 0, 22243, 710)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10231, 54182, 0, 30, CAST(N'2015-06-13 00:00:00.000' AS DateTime), CAST(N'2015-06-17 00:00:00.000' AS DateTime), 15, 15, 15, 15, 1.5, 1.37, 0, 0, 22244, 715)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10232, 54183, 0, 30, CAST(N'2015-06-15 00:00:00.000' AS DateTime), CAST(N'2015-06-21 00:00:00.000' AS DateTime), 40, 40, 40, 40, 1.5, 1.37, 0, 0, 22245, 720)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10232, 54184, 0, 30, CAST(N'2015-06-15 00:00:00.000' AS DateTime), CAST(N'2015-06-21 00:00:00.000' AS DateTime), 45, 45, 45, 45, 4.2, 3.36, 0, 0, 22245, 610)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10233, 54185, 0, 20, CAST(N'2015-06-30 00:00:00.000' AS DateTime), CAST(N'2015-07-06 00:00:00.000' AS DateTime), 15, 15, 15, 15, 5, 4, 0, 0, 22246, 625)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10233, 54186, 0, 20, CAST(N'2015-06-30 00:00:00.000' AS DateTime), CAST(N'2015-07-06 00:00:00.000' AS DateTime), 25, 25, 25, 25, 4.2, 3.36, 0, 0, 22246, 615)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10234, 54187, 0, 10, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-01 00:00:00.000' AS DateTime), 20, 20, 20, 20, 38.5, 32.5, 0, 0, 0, 110)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10234, 54188, 0, 10, CAST(N'2015-07-01 00:00:00.000' AS DateTime), CAST(N'2015-07-01 00:00:00.000' AS DateTime), 15, 15, 15, 15, 8.75, 7.25, 0, 0, 0, 220)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10235, 54189, 0, 30, CAST(N'2015-06-29 00:00:00.000' AS DateTime), CAST(N'2015-07-02 00:00:00.000' AS DateTime), 10, 10, 10, 10, 38.5, 32.5, 0, 0, 0, 110)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10235, 54190, 0, 30, CAST(N'2015-06-29 00:00:00.000' AS DateTime), CAST(N'2015-07-02 00:00:00.000' AS DateTime), 12, 12, 12, 12, 8.75, 7.25, 0, 0, 0, 220)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10235, 54191, 0, 30, CAST(N'2015-06-29 00:00:00.000' AS DateTime), CAST(N'2015-07-02 00:00:00.000' AS DateTime), 15, 15, 15, 15, 4, 3.2, 0, 0, 0, 510)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10236, 54192, 0, 20, CAST(N'2015-07-05 00:00:00.000' AS DateTime), CAST(N'2015-07-05 00:00:00.000' AS DateTime), 30, 30, 30, 30, 5, 4, 0, 0, 0, 635)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10237, 54193, 0, 30, CAST(N'2015-07-02 00:00:00.000' AS DateTime), CAST(N'2015-07-05 00:00:00.000' AS DateTime), 25, 25, 25, 25, 1.5, 1.37, 0, 0, 0, 710)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10238, 54194, 0, 30, CAST(N'2015-06-28 00:00:00.000' AS DateTime), CAST(N'2015-07-02 00:00:00.000' AS DateTime), 10, 10, 10, 10, 1.5, 1.37, 0, 0, 0, 715)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10239, 54195, 0, 30, CAST(N'2015-06-30 00:00:00.000' AS DateTime), CAST(N'2015-07-06 00:00:00.000' AS DateTime), 35, 35, 35, 35, 1.5, 1.37, 0, 0, 0, 720)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10239, 54196, 0, 30, CAST(N'2015-06-30 00:00:00.000' AS DateTime), CAST(N'2015-07-06 00:00:00.000' AS DateTime), 40, 40, 40, 40, 4.2, 3.36, 0, 0, 0, 610)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10240, 54197, 0, 20, CAST(N'2015-07-15 00:00:00.000' AS DateTime), CAST(N'2015-07-21 00:00:00.000' AS DateTime), 10, 10, 10, 10, 5, 4, 0, 0, 0, 625)
INSERT [dbo].[Order_Line$] ([Order_id], [Order_line_id], [Unit_id], [Warehouse_id], [Delivery_Request_dt], [Delivery_commit_dt], [Ordered_quantity], [Allocated_quantity], [Real_quantity], [Invoiced_quantity], [Unit_price_amt], [Unit_cost_amt], [Volume_discount_percentage], [Customer_discount_percentage], [Invoice_id], [Product_id]) VALUES (10240, 54198, 0, 20, CAST(N'2015-07-15 00:00:00.000' AS DateTime), CAST(N'2015-07-21 00:00:00.000' AS DateTime), 20, 20, 20, 20, 4.2, 3.36, 0, 0, 0, 615)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (110, N'Wine of the Month Package', N'Featured Wine from Fine Wine Country', 215)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (115, N'Chardonnay Elegance', N'16oz, 6 bottle container', 215)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (120, N'Chardonnay Elegance', N'16 oz, 12 bottle container', 215)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (125, N'Passion Vines Cabernet', N'16 oz, 6 bottle container', 612)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (130, N'Passion Vines Cabernet', N'16 oz, 12 bottle container', 612)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (210, N'Dried Buffalo Jerky', N'12 oz Package', 423)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (220, N'Dried Buffalo Jerky', N'24 oz Package', 423)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (222, N'Canned Figs - Candied', N'12 oz Package', 423)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (224, N'Canned Figs - Candied', N'24 oz Package', 423)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (321, N'10 Piece Cheese Sampler Tray', N'Gouda, and Cheddar', 340)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (325, N'20 Piece Cheese Sampler', N'Gouda, Cheddar, and Brie', 340)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (328, N'50 Piece Cheese Sampler', N'Gouda, Cheddar, Brie, and Havarti', 340)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (410, N'German Beer', N'12 oz, 6 bottle container', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (415, N'German Beer', N'12 oz, 12 bottle container', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (420, N'German Beer', N'12 oz, 24 bottle container', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (425, N'Danish Beer', N'12 oz, 6 bottle container', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (430, N'Danish Beer', N'12 oz, 12 bottle container', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (435, N'Danish Beer', N'12 oz, 24 bottle container', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (510, N'Butter Toffee Belgium Cookies', N'16 oz Package', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (515, N'Butter Toffee Belgium Cookies', N'20 oz Package', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (520, N'Butter Toffee Belgium Cookies', N'24 oz Package', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (525, N'Belgium Chocolate Truffles', N'16 oz Package', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (530, N'Belgium Chocolate Truffles', N'20 oz Package', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (535, N'Belgium Chocolate Truffles', N'24 oz Package', 446)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (610, N'Roasted Almonds', N'16 oz Package', 720)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (615, N'Roasted Almonds', N'20 oz Package', 720)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (620, N'Roasted Almonds', N'24 oz Package', 720)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (625, N'Spicy Cashews', N'16 oz Package', 720)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (630, N'Spicy Cashews', N'20 oz Package', 720)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (635, N'Spicy Cashews', N'24 oz Package', 720)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (710, N'Premium Gala Apples', N'24 oz Package', 650)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (715, N'Premium Gala Apples', N'48 oz Package', 650)
INSERT [dbo].[Product$] ([Product_Id], [Product_name], [Description], [Supplier_key]) VALUES (720, N'Premium Gala Apples', N'48 oz Package', 650)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (110, CAST(N'2014-01-06 00:00:00.000' AS DateTime), N'E', N'215', 200, 1, 34, 28)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (110, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'215', 200, 1, 38.5, 32.5)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (115, CAST(N'2014-01-06 00:00:00.000' AS DateTime), N'A', N'215', 240, 6, 13, 11)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (120, CAST(N'2014-01-06 00:00:00.000' AS DateTime), N'A', N'215', 240, 12, 13, 11)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (125, CAST(N'2014-01-06 00:00:00.000' AS DateTime), N'E', N'612', 240, 6, 27.25, 22)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (125, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'612', 240, 6, 29, 23.1)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (130, CAST(N'2014-01-06 00:00:00.000' AS DateTime), N'E', N'612', 240, 12, 27.25, 22)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (130, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'612', 240, 12, 29, 23.1)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (210, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'423', 2500, 50, 8.75, 7.25)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (220, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'423', 2500, 25, 8.75, 7.25)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (222, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'423', 1200, 4, 18, 15.35)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (224, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'423', 600, 2, 18, 15.35)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (321, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'340', 600, 1, 10.5, 0)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (325, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'340', 300, 1, 19, 0)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (328, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'340', 120, 1, 38, 0)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (410, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 300, 6, 10, 9)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (415, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 300, 12, 20, 18)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (420, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 300, 24, 40, 36)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (425, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 300, 6, 8, 7.2)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (430, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 300, 12, 16, 14.4)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (435, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 300, 24, 32, 28.8)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (510, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 1600, 80, 4, 3.2)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (515, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 1600, 100, 5, 4)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (520, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 1600, 120, 6, 4.8)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (525, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 1000, 40, 8, 6.4)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (530, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 1000, 50, 10, 8)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (535, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'446', 1000, 60, 12, 9.6)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (610, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'720', 1200, 24, 4.2, 3.36)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (615, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'720', 1200, 36, 4.2, 3.36)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (620, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'720', 1200, 48, 4.2, 3.36)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (625, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'720', 1200, 24, 5, 4)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (630, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'720', 1200, 36, 5, 4)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (635, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'720', 1200, 48, 5, 4)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (710, CAST(N'2014-01-06 00:00:00.000' AS DateTime), N'E', N'650', 1200, 24, 1.35, 1.22)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (710, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'650', 1200, 24, 1.5, 1.37)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (715, CAST(N'2014-01-06 00:00:00.000' AS DateTime), N'E', N'650', 1200, 36, 1.35, 1.22)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (715, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'650', 1200, 36, 1.5, 1.37)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (720, CAST(N'2014-01-06 00:00:00.000' AS DateTime), N'E', N'650', 1200, 48, 1.35, 1.22)
INSERT [dbo].[Product_Detail$] ([Product_id], [Product_effective_dt], [Status], [Supplier], [Units_per_pallet], [Units_per_package], [Unit_price], [Unit_cost]) VALUES (720, CAST(N'2015-01-05 00:00:00.000' AS DateTime), N'A', N'650', 1200, 48, 1.5, 1.37)
INSERT [dbo].[Sales_Product$] ([Sales_product_id], [Sales_product_name], [Description], [City], [Country]) VALUES (101, N'Cabernet Sauvignon Wine', N'Full-bodied red wine with fruit flavor', N'Paris', N'France')
INSERT [dbo].[Sales_Product$] ([Sales_product_id], [Sales_product_name], [Description], [City], [Country]) VALUES (226, N'Gourmet Cheese Gift Box', N'Slow aged with farmhouse flavor', N'Stockholm', N'Sweden')
INSERT [dbo].[Sales_Product$] ([Sales_product_id], [Sales_product_name], [Description], [City], [Country]) VALUES (360, N'County Pride Stout Beer', N'The Stout is barrel aged, with selected hops for lingering sweetness', N'Frankfurt', N'Germany')
INSERT [dbo].[Sales_Product$] ([Sales_product_id], [Sales_product_name], [Description], [City], [Country]) VALUES (417, N'Indian Spice Assortment', N'Highest quality herbs and spices from around the world', N'Chenguttai', N'India')
INSERT [dbo].[Sales_Product$] ([Sales_product_id], [Sales_product_name], [Description], [City], [Country]) VALUES (505, N'Moroccan Charmoula', N'Condiment of cilantro, parsley, cumin, and olive oil', N'Rabat', N'Morocco')
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (1010, N'Janet Rogers', N'Fine Foods Expert', 115237, 1877, 101)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (1118, N'William Evans', N'Wine Consultant', 114301, 1877, 505)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (1325, N'Doris Miller', N'Wine Consultant', 120171, 1877, 417)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (1561, N'Gary Taylor', N'Fine Foods Expert', 118214, 1877, 360)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (1877, N'Bernice Lonnigan', N'Director of Sales', 123812, 0, 226)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (2234, N'Walter Hensley', N'Senior Marketing Manager', 154569, 0, 101)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (3061, N'Edward Thomas', N'Exotic Markets', 155295, 0, 417)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (3721, N'Harold Engstrom', N'Wine Master', 155955, 2234, 101)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (4136, N'Judith Fitzgerald', N'Specialty Foods Representative', 156370, 2234, 226)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (4447, N'Jason Clark', N'Foreign Beer Sales', 156681, 3061, 360)
INSERT [dbo].[Sales_Rep$] ([Sales_rep_id], [Sales_rep_name], [Description], [Employee_code], [Manager_id], [Sales_product_id]) VALUES (5023, N'Edith Wainwright', N'Specialty Foods Representative', 157257, 2234, 505)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54175, CAST(N'2015-06-14 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-16 00:00:00.000' AS DateTime), 10)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54176, CAST(N'2015-06-14 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-16 00:00:00.000' AS DateTime), 10)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54177, CAST(N'2015-06-15 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-17 00:00:00.000' AS DateTime), 30)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54178, CAST(N'2015-06-15 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-17 00:00:00.000' AS DateTime), 30)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54179, CAST(N'2015-06-15 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-17 00:00:00.000' AS DateTime), 30)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54180, CAST(N'2015-06-18 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-20 00:00:00.000' AS DateTime), 20)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54181, CAST(N'2015-06-18 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-20 00:00:00.000' AS DateTime), 30)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54182, CAST(N'2015-06-15 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-17 00:00:00.000' AS DateTime), 30)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54183, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-21 00:00:00.000' AS DateTime), 30)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54184, CAST(N'2015-06-19 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-06-21 00:00:00.000' AS DateTime), 30)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54185, CAST(N'2015-07-03 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-07-06 00:00:00.000' AS DateTime), 20)
INSERT [dbo].[Shipment$] ([Order_line_id], [Shipment_dt], [Carrier], [Delivery_dt], [Warehouse_id]) VALUES (54186, CAST(N'2015-07-03 00:00:00.000' AS DateTime), N'UPS', CAST(N'2015-07-06 00:00:00.000' AS DateTime), 20)
INSERT [dbo].[Supplier$] ([Supplier_id], [Supplier_name], [City], [Country], [Telephone_number], [Discount_Percentage], [Contact_person_name]) VALUES (215, N'Napa Gardens & Vinyard, Inc.', N'Napa', N'United States', N'800-215-4371
', 10.125, N'Roger Martinez')
INSERT [dbo].[Supplier$] ([Supplier_id], [Supplier_name], [City], [Country], [Telephone_number], [Discount_Percentage], [Contact_person_name]) VALUES (340, N'Tillamook Cheese Factory', N'Tillamook', N'United States', N'800-275-0639
', 5, N'Barton Lamont')
INSERT [dbo].[Supplier$] ([Supplier_id], [Supplier_name], [City], [Country], [Telephone_number], [Discount_Percentage], [Contact_person_name]) VALUES (423, N'Gourmet Meats', N'London', N'England', N'519-601-5223
', 0, N'Winston Graves')
INSERT [dbo].[Supplier$] ([Supplier_id], [Supplier_name], [City], [Country], [Telephone_number], [Discount_Percentage], [Contact_person_name]) VALUES (446, N'Confectioners Candy Shoppe', N'Brussels', N'Belgium', N'02 503 07 90
', 2.5, N'Moeder Babelutte')
INSERT [dbo].[Supplier$] ([Supplier_id], [Supplier_name], [City], [Country], [Telephone_number], [Discount_Percentage], [Contact_person_name]) VALUES (612, N'Mediterranian Exporters', N'Cairo', N'Egypt', NULL, 0, N'Mounir Kareem')
INSERT [dbo].[Supplier$] ([Supplier_id], [Supplier_name], [City], [Country], [Telephone_number], [Discount_Percentage], [Contact_person_name]) VALUES (650, N'Spokane Orchards', N'Spokane', N'United States', N'509-223-7435
', 15, N'John Southwick')
INSERT [dbo].[Supplier$] ([Supplier_id], [Supplier_name], [City], [Country], [Telephone_number], [Discount_Percentage], [Contact_person_name]) VALUES (720, N'Deshpande Fruit and Nut Company', N'Nagpur', N'India', NULL, 2, N'Indra Deshpande')
INSERT [dbo].[Warehouse$] ([Warehouse_id], [Warehouse_name], [Warehouse_addr_first_line], [Warehouse_addr_second_line], [Description], [City], [Country]) VALUES (10, N'European Warehouse', N'4 Queens Quay', N'Belfast BT3 9QQ, United Kingdom', N'Harland and Wolff partners', N'Belfast', N'Ireland')
INSERT [dbo].[Warehouse$] ([Warehouse_id], [Warehouse_name], [Warehouse_addr_first_line], [Warehouse_addr_second_line], [Description], [City], [Country]) VALUES (20, N'Middle East Warehouse', N'Al Wardiyan Sharq', N'Qesm Mina Al Basal', N'Alexandria Governorate', N'Al Wardiyan', N'Egypt')
INSERT [dbo].[Warehouse$] ([Warehouse_id], [Warehouse_name], [Warehouse_addr_first_line], [Warehouse_addr_second_line], [Description], [City], [Country]) VALUES (30, N'Americas Distribution Center', N'750 N Harbor Blvd', N'', N'Port of Los Angeles', N'San Pedro', N'United States')
INSERT [dbo].[Warehouse$] ([Warehouse_id], [Warehouse_name], [Warehouse_addr_first_line], [Warehouse_addr_second_line], [Description], [City], [Country]) VALUES (40, N'Asian Warehouse Operations', N'10 Bukit Chermin Rd', N'Singapore 109918', N'Malaysian Peninsula', N'Singapore', N'Southeast Asia')
USE [master]
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET  READ_WRITE 
GO
