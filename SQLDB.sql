USE [LaptopPCSale]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 09/26/2021 20:53:29 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (1, N'Nancy', N'Davolio', N'Sales Representative', NULL, N'TP.Hồ Chí Minh', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (2, N'Andrew', N'Fuller', N'Vice President, Sales', NULL, N'TP.Hồ Chí Minh', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (3, N'Janet', N'Leverling', N'Sales Representative', NULL, N'TP.Hồ Chí Minh', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (4, N'Margaret', N'Peacock', N'Sales Representative', NULL, N'TP.Hồ Chí Minh', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (5, N'Steven', N'Buchanan', N'Sales Manager', NULL, N'TP.Hồ Chí Minh', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (6, N'Michael', N'Suyama', N'Sales Representative', NULL, N'TP.Hồ Chí Minh', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (7, N'Robert', N'King', N'Sales Representative', NULL, N'TP.Hồ Chí Minh', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (8, N'Laura', N'Callahan', N'Inside Sales Coordinator', NULL, N'TP.Hồ Chí Minh', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Title], [Address], [City], [Phone], [Photo]) VALUES (9, N'Anne', N'Dodsworth', N'Sales Representative', NULL, N'TP.Hồ Chí Minh', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Employees] OFF
/****** Object:  Table [dbo].[Customers]    Script Date: 09/26/2021 20:53:29 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT [dbo].[Customers] ([CustomerID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (1, N'GearVN', NULL, NULL, NULL, NULL)
INSERT [dbo].[Customers] ([CustomerID], [CompanyName], [ContactName], [Address], [City], [Phone]) VALUES (2, N'xGear', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
/****** Object:  Table [dbo].[Categories]    Script Date: 09/26/2021 20:53:29 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (1, N'Laptop', N'Máy tính xách tay', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (2, N'Case', N'Thùng máy', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (3, N'Màn hình', N'Màn hình máy tính', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (4, N'Graphics Cards', N'Card đồ họa', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (5, N'Gear', N'Phụ kiện (Chuột, bàn phím,...)', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [Picture]) VALUES (6, N'Ram', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Categories] OFF
/****** Object:  Table [dbo].[Suppliers]    Script Date: 09/26/2021 20:53:29 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
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
/****** Object:  Table [dbo].[Products]    Script Date: 09/26/2021 20:53:29 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [UnitPrice], [UnitsInStock], [UnitsOnOrder]) VALUES (1, N'Apple MacBook Pro 13-inch 2020', 6, 1, 0.0000, 0, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [UnitPrice], [UnitsInStock], [UnitsOnOrder]) VALUES (2, N'Apple MacBook Air 2020', 6, 1, 20000000.0000, 10, 2)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [UnitPrice], [UnitsInStock], [UnitsOnOrder]) VALUES (4, N'Apple MacBook Pro MVVK2LL', 6, 1, 0.0000, 0, 0)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [CategoryID], [UnitPrice], [UnitsInStock], [UnitsOnOrder]) VALUES (5, N'Apple MacBook Pro MVVJ2LL', 6, 1, 0.0000, 0, 0)
SET IDENTITY_INSERT [dbo].[Products] OFF
/****** Object:  Table [dbo].[Orders]    Script Date: 09/26/2021 20:53:29 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate]) VALUES (1, 1, 1, CAST(0x0000ADAF010A785C AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate]) VALUES (2, 2, 4, CAST(0x0000ADAF010A7804 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate]) VALUES (3, 1, 1, CAST(0x0000ADAF01349E34 AS DateTime))
SET IDENTITY_INSERT [dbo].[Orders] OFF
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 09/26/2021 20:53:29 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (1, 2, 160000000.0000, 8, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (2, 2, 40000000.0000, 2, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (3, 2, 60000000.0000, 15, 0)
/****** Object:  Trigger [KTSLSamPhamConLaiXoa]    Script Date: 09/26/2021 20:53:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Trigger [dbo].[KTSLSamPhamConLaiXoa]
ON [dbo].[OrderDetails] AFTER UPDATE AS
BEGIN
	UPDATE Products
	SET UnitsInStock = UnitsInStock 
	+ (SELECT Quantity FROM deleted WHERE ProductID = Products.ProductID)
	FROM Products
	JOIN deleted ON Products.ProductID = deleted.ProductID
END
GO
/****** Object:  Trigger [KTSLSamPhamConLaiCapNhat]    Script Date: 09/26/2021 20:53:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Trigger [dbo].[KTSLSamPhamConLaiCapNhat]
ON [dbo].[OrderDetails] AFTER UPDATE AS
BEGIN
	UPDATE Products
	SET UnitsInStock = UnitsInStock 
	- (SELECT Quantity FROM inserted WHERE ProductID = Products.ProductID)
	+ (SELECT Quantity FROM deleted WHERE ProductID = Products.ProductID)
	FROM Products
	JOIN deleted ON Products.ProductID = deleted.ProductID
END
GO
/****** Object:  Trigger [KTSLSamPhamConLai]    Script Date: 09/26/2021 20:53:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Trigger [dbo].[KTSLSamPhamConLai]
ON [dbo].[OrderDetails] AFTER INSERT AS
BEGIN
	UPDATE Products
	SET UnitsInStock = UnitsInStock - (
		SELECT Quantity
		FROM inserted
		WHERE ProductID = Products.ProductID)
	FROM Products
	JOIN inserted ON Products.ProductID = inserted.ProductID
END
GO
/****** Object:  Default [DF_OrderDetails_UnitPrice]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DF_OrderDetails_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_OrderDetails_Quantity]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DF_OrderDetails_Quantity]  DEFAULT ((1)) FOR [Quantity]
GO
/****** Object:  Default [DF_OrderDetails_Discount]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DF_OrderDetails_Discount]  DEFAULT ((0)) FOR [Discount]
GO
/****** Object:  Default [DF_Products_UnitPrice]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_Products_UnitsInStock]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UnitsInStock]  DEFAULT ((0)) FOR [UnitsInStock]
GO
/****** Object:  Default [DF_Products_UnitsOnOrder]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UnitsOnOrder]  DEFAULT ((0)) FOR [UnitsOnOrder]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Orders]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Products]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
/****** Object:  ForeignKey [FK_Orders_Employees]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
/****** Object:  ForeignKey [FK_Orders_Orders]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Orders] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders]
GO
/****** Object:  ForeignKey [FK_Products_Categories]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
/****** Object:  ForeignKey [FK_Products_Suppliers]    Script Date: 09/26/2021 20:53:29 ******/
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
