# TechnologyAccessories Database Script

This script sets up and configures the TechnologyAccessories database on your SQL Server.

### Requirements
- SQL Server

### Steps to Create the Database

1. **Open SQL Server Management Studio (SSMS)**:
   - Connect to your SQL Server instance.

2. **Open a New Query Window**:
   - Click on `New Query` in the toolbar.

3. **Copy and Paste the Script**:
   - Copy the entire database creation script and paste it into the query window.

4. **Execute the Script**:
   - Click on `Execute` in the toolbar to run the script.

### Here is Script
```sql
USE [master]
GO
CREATE DATABASE [TechnologyAccessories]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechnologyAccessories', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MASTERMOS\MSSQL\DATA\TechnologyAccessories.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TechnologyAccessories_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MASTERMOS\MSSQL\DATA\TechnologyAccessories_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TechnologyAccessories] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
BEGIN
EXEC [TechnologyAccessories].[dbo].[sp_fulltext_database] @action = 'enable'
END
GO
ALTER DATABASE [TechnologyAccessories] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET ARITHABORT OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechnologyAccessories] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TechnologyAccessories] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET ENABLE_BROKER 
GO
ALTER DATABASE [TechnologyAccessories] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechnologyAccessories] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET RECOVERY FULL 
GO
ALTER DATABASE [TechnologyAccessories] SET MULTI_USER 
GO
ALTER DATABASE [TechnologyAccessories] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechnologyAccessories] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechnologyAccessories] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechnologyAccessories] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TechnologyAccessories] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TechnologyAccessories] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TechnologyAccessories', N'ON'
GO
ALTER DATABASE [TechnologyAccessories] SET QUERY_STORE = OFF
GO
USE [TechnologyAccessories]
GO
CREATE TABLE [dbo].[Customer](
    [CustomerID] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](50) NULL,
    [Address] [varchar](50) NULL,
    [Phone] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
    [CustomerID] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Employee](
    [EmployeeID] [int] IDENTITY(1,1) NOT NULL,
    [EmployeeName] [varchar](50) NULL,
    [EmployeeRole] [varchar](50) NULL,
    [EmployeeAddress] [varchar](255) NULL,
    [EmployeePhone] [varchar](15) NULL,
    [Username] [varchar](50) NULL,
    [Password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
    [EmployeeID] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Order](
    [OrderID] [int] IDENTITY(1,1) NOT NULL,
    [OrderProductID] [int] NULL,
    [OrderProductName] [varchar](100) NULL,
    [OrderCustomerID] [int] NULL,
    [OrderCustomerName] [varchar](50) NULL,
    [OrderEmployee] [varchar](50) NULL,
    [OrderDate] [date] NULL,
    [OrderAmount] [int] NULL,
    [OrderPrice] [decimal](10, 2) NULL,
    [OrderBill] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
    [OrderID] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Product](
    [ProductID] [int] IDENTITY(1,1) NOT NULL,
    [ProductName] [varchar](100) NULL,
    [Quantity] [int] NULL,
    [Price] [decimal](10, 2) NULL,
    [ImageFile] [varbinary](max) NULL,
    [PurchasePrice] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
    [ProductID] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE TABLE [dbo].[TempProduct](
    [ProductID] [int] IDENTITY(1,1) NOT NULL,
    [ProductName] [varchar](100) NULL,
    [Quantity] [int] NULL,
    [Price] [decimal](10, 2) NULL,
    [ImageFile] [varbinary](max) NULL,
    [PurchasePrice] [decimal](18, 2) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([OrderCustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([OrderProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
USE [master]
GO
ALTER DATABASE [TechnologyAccessories] SET  READ_WRITE 
GO
