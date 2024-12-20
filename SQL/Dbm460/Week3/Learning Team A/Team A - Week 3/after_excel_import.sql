USE [master]
GO
/****** Object:  Database [DBM_460_TeamDB_8]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Currency$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Customer$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Customer_Detail$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Customer_X_ADDR$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Exchange_Rate$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Inventory$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Invoice$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Order$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Order_Line$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Product$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Product_Detail$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Sales_Product$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Sales_Rep$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Shipment$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Supplier$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
/****** Object:  Table [dbo].[Warehouse$]    Script Date: 10/10/2016 10:16:47 PM ******/
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
USE [master]
GO
ALTER DATABASE [DBM_460_TeamDB_8] SET  READ_WRITE 
GO
