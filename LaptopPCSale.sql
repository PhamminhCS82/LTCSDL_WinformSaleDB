USE [master]
GO
/****** Object:  Database [LaptopPCSale]    Script Date: 01/10/2021 11:49:05 AM ******/
CREATE DATABASE [LaptopPCSale]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LaptopPCSale', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LaptopPCSale.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LaptopPCSale_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LaptopPCSale_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LaptopPCSale] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LaptopPCSale].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LaptopPCSale] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LaptopPCSale] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LaptopPCSale] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LaptopPCSale] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LaptopPCSale] SET ARITHABORT OFF 
GO
ALTER DATABASE [LaptopPCSale] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LaptopPCSale] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LaptopPCSale] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LaptopPCSale] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LaptopPCSale] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LaptopPCSale] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LaptopPCSale] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LaptopPCSale] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LaptopPCSale] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LaptopPCSale] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LaptopPCSale] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LaptopPCSale] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LaptopPCSale] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LaptopPCSale] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LaptopPCSale] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LaptopPCSale] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LaptopPCSale] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LaptopPCSale] SET RECOVERY FULL 
GO
ALTER DATABASE [LaptopPCSale] SET  MULTI_USER 
GO
ALTER DATABASE [LaptopPCSale] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LaptopPCSale] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LaptopPCSale] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LaptopPCSale] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LaptopPCSale] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LaptopPCSale] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LaptopPCSale', N'ON'
GO
ALTER DATABASE [LaptopPCSale] SET QUERY_STORE = OFF
GO
USE [LaptopPCSale]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 01/10/2021 11:49:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 01/10/2021 11:49:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 01/10/2021 11:49:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](10) NULL,
	[LastName] [nvarchar](20) NULL,
	[Title] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
	[Photo] [image] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 01/10/2021 11:49:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[Discount] [real] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 01/10/2021 11:49:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[EmployeeID] [int] NULL,
	[OrderDate] [datetime] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 01/10/2021 11:49:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[SupplierID] [int] NULL,
	[CategoryID] [int] NULL,
	[UnitPrice] [money] NULL,
	[UnitsInStock] [smallint] NULL,
	[UnitsOnOrder] [smallint] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 01/10/2021 11:49:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01/10/2021 11:49:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [varchar](15) NOT NULL,
	[Password] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (1, N'Laptop', N'Máy tính xách tay', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (2, N'Case', N'Thùng máy', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (3, N'Màn hình', N'Màn hình máy tính', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (4, N'Graphics Cards', N'Card đồ họa', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (5, N'Gear', N'Phụ kiện (Chuột, bàn phím,...)', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (6, N'Ram', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (1, N'GearVN', N'Hợp đồng mua bán', N'123 Nguyễn Hữu Cầu', N'TP.Hồ Chí Minh', N'123456')
INSERT [dbo].[Customers] ([CustomerID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (2, N'xGear', N'Hợp đồng mua bán', N'567 Phan Văn Trị', N'TP.Hồ Chí Minh', N'9876556')
INSERT [dbo].[Customers] ([CustomerID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (3, N'MemoryZone', N'Peter Tèo', N'123 Phạm Văn Chí', N'TP. Hải Phòng', N'9876556')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (1, N'Nancy', N'Davolio', N'Sales Representative', N'Hà Nội', N'TP.Hồ Chí Minh', N'12345678', NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (2, N'Andrew', N'Fuller', N'Vice President, Sales', N'Hà Nội', N'TP.Hồ Chí Minh', N'12345678', NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (3, N'Janet', N'Leverling', N'Sales Representative', N'Hà Nội', N'TP.Hồ Chí Minh', N'12345678', NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (4, N'Margaret', N'Peacock', N'Sales Representative', N'Hà Nội', N'TP.Hồ Chí Minh', N'12345678', NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (5, N'Steven', N'Buchanan', N'Sales Manager', N'Hà Nội', N'TP.Hồ Chí Minh', N'12345678', NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (6, N'Michael', N'Suyama', N'Sales Representative', N'Hà Nội', N'TP.Hồ Chí Minh', N'12345678', NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (7, N'Robert', N'King', N'Sales Representative', N'Hà Nội', N'TP.Hồ Chí Minh', N'12345678', NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (8, N'Laura', N'Callahan', N'Inside Sales Coordinator', N'Hà Nội', N'TP.Hồ Chí Minh', N'12345678', NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (9, N'Anne', N'Dodsworth', N'Sales Representative', N'Hà Nội', N'TP.Hồ Chí Minh', N'12345678', NULL)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (1, 1, 30000000.0000, 2, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (1, 2, 100000000.0000, 5, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (2, 1, 75000000.0000, 5, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (2, 2, 100000000.0000, 5, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (2, 4, 200000000.0000, 5, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (2, 5, 150000000.0000, 5, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (4, 4, 400000000.0000, 10, 0)
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate]) VALUES (1, 1, 1, CAST(N'2021-09-26T16:10:11.293' AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate]) VALUES (2, 2, 4, CAST(N'2021-09-26T16:10:11.000' AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate]) VALUES (3, 1, 1, CAST(N'2021-09-26T18:43:38.627' AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate]) VALUES (4, 1, 1, CAST(N'2021-09-30T14:42:21.103' AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate]) VALUES (5, 2, 3, CAST(N'2021-09-30T14:42:21.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [UnitPrice], [UnitsInStock], [UnitsOnOrder]) VALUES (1, N'Apple MacBook Pro 13-inch 2020', 6, 1, 15000000.0000, 13, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [UnitPrice], [UnitsInStock], [UnitsOnOrder]) VALUES (2, N'Apple MacBook Air 2020', 6, 1, 20000000.0000, 18, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [UnitPrice], [UnitsInStock], [UnitsOnOrder]) VALUES (4, N'Apple MacBook Pro MVVK2LL', 6, 1, 40000000.0000, 45, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [UnitPrice], [UnitsInStock], [UnitsOnOrder]) VALUES (5, N'Apple MacBook Pro MVVJ2LL', 6, 1, 30000000.0000, 65, 0)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (1, N'NVIDIA', NULL, NULL, NULL, NULL)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (2, N'AMD', NULL, NULL, NULL, NULL)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (3, N'Intel', NULL, NULL, NULL, NULL)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (4, N'MSI', NULL, NULL, NULL, NULL)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (5, N'Acer', NULL, NULL, NULL, NULL)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (6, N'Apple', NULL, NULL, NULL, NULL)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (7, N'Asus', NULL, NULL, NULL, NULL)
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (8, N'Dell', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
INSERT [dbo].[Users] ([Username], [Password]) VALUES (N'admin', N'E19D5CD5AF0378DA05F63F891C7467AF')
GO
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DF_OrderDetails_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DF_OrderDetails_Quantity]  DEFAULT ((1)) FOR [Quantity]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DF_OrderDetails_Discount]  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UnitsInStock]  DEFAULT ((0)) FOR [UnitsInStock]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UnitsOnOrder]  DEFAULT ((0)) FOR [UnitsOnOrder]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Orders] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
/****** Object:  StoredProcedure [dbo].[LayDSCTDonHang]    Script Date: 01/10/2021 11:49:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSCTDonHang]
AS
BEGIN
	SELECT OrderDetails.*, Products.ProductName
	FROM OrderDetails, Products
	WHERE OrderDetails.ProductID = Products.ProductID
END;
GO
/****** Object:  StoredProcedure [dbo].[LayDSDonHang]    Script Date: 01/10/2021 11:49:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDSDonHang]
AS
BEGIN
	SELECT Orders.OrderID, Employees.FirstName, Employees.LastName, Customers.CompanyName
	FROM Orders, Employees, Customers
	WHERE Orders.CustomerID = Customers.CustomerID
	AND Orders.EmployeeID = Employees.EmployeeID 
END;
GO
/****** Object:  StoredProcedure [dbo].[orderDetail_KTCTDonHang]    Script Date: 01/10/2021 11:49:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[orderDetail_KTCTDonHang] @OrderID int, @ProductID int
as
begin
	SET NOCOUNT ON
	declare @output int
	select @output = COUNT(*) from OrderDetails
	where @OrderID = OrderID
	and @ProductID = ProductID
	select @output as alias
end
GO
/****** Object:  StoredProcedure [dbo].[user_KTDangNhap]    Script Date: 01/10/2021 11:49:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[user_KTDangNhap] @Username VARCHAR(15), @Password VARCHAR(255)
as
begin
	SET NOCOUNT ON
	declare @output int
	select @output = COUNT(*) from Users
	where @Username = Username
	and CONVERT(VARCHAR(32), HashBytes('MD5', @Password), 2) = Password
	select @output as alias
end
GO
USE [master]
GO
ALTER DATABASE [LaptopPCSale] SET  READ_WRITE 
GO
