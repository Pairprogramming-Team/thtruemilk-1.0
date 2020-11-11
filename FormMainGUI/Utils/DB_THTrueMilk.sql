CREATE DATABASE THTrueMilk
GO

USE THTrueMilk
GO

--Create table
CREATE TABLE Employees(
	EmployeeID VARCHAR(20) NOT NULL,
	Name NVARCHAR(50),
	Phone VARCHAR(10),
	Sex BIT DEFAULT 1,
	YearOfBirth INT DEFAULT 1990,
	Address NVARCHAR(100),

	PRIMARY KEY (EmployeeID)
)
GO

CREATE TABLE Products(
	ProductID VARCHAR(20) NOT NULL,
	Name NVARCHAR(50),
	Quantity INT DEFAULT 0,
	Price DECIMAL DEFAULT 0,

	PRIMARY KEY (ProductID)
)
GO

CREATE TABLE Orders(
	OrderID VARCHAR(20) NOT NULL,
	DateOfOrder DATE DEFAULT GETDATE(),
	TotalMoney DECIMAL DEFAULT 0,
	EmployeeID VARCHAR(20),

	PRIMARY KEY (OrderID)
)
GO

CREATE TABLE OrdersDetail(
	OrderDetailID VARCHAR(20) NOT NULL,
	Quantity INT DEFAULT 0,
	TotalAmount DECIMAL DEFAULT 0,
	OrderID VARCHAR(20),
	ProductID VARCHAR(20),

	PRIMARY KEY(OrderDetailID)
)
GO

CREATE TABLE ProductsDetail (
	ProductDetailID VARCHAR(20) NOT NULL,
	Status NVARCHAR(100),
	MFG DATE DEFAULT GETDATE(),
	EXP DATE DEFAULT GETDATE(),
	ProductEntryDate DATE DEFAULT GETDATE(),
	ProductID VARCHAR(20),

	PRIMARY KEY (ProductDetailID)
)
GO

CREATE TABLE Accounts (
	UserName VARCHAR(50) NOT NULL,
	PassWord VARCHAR(50) NOT NULL,
	EmployeeID VARCHAR(20),

	PRIMARY KEY (UserName)
)
GO

----------------------------------------------------
--set foreign key
ALTER TABLE dbo.Accounts ADD FOREIGN KEY (EmployeeID) REFERENCES dbo.Employees
ALTER TABLE dbo.Orders ADD FOREIGN KEY (EmployeeID) REFERENCES dbo.Employees
ALTER TABLE dbo.OrdersDetail ADD FOREIGN KEY (OrderID) REFERENCES dbo.Orders
ALTER TABLE dbo.OrdersDetail ADD FOREIGN KEY (ProductID) REFERENCES dbo.Products
ALTER TABLE dbo.ProductsDetail ADD FOREIGN KEY (ProductID) REFERENCES dbo.Products

----------------------------------------------------
--set constraint
ALTER TABLE dbo.Employees ADD CONSTRAINT check_YearOfBirth CHECK (1900 < YearOfBirth AND YearOfBirth < YEAR(GETDATE()))
ALTER TABLE dbo.Products ADD CONSTRAINT check_Quantity_Price CHECK (Quantity >= 0 AND Price > 0)
ALTER TABLE dbo.Orders ADD CONSTRAINT check_DateOfOrder_TotalMoney CHECK (DateOfOrder < GETDATE() AND TotalMoney > 0)
ALTER TABLE dbo.OrdersDetail ADD CONSTRAINT check_Quantity_TotalAmount CHECK (Quantity > 0 AND TotalAmount > 0)
ALTER TABLE dbo.ProductsDetail ADD CONSTRAINT check_MFG_EXP_ProductEntryDate CHECK (MFG < GETDATE() AND ProductEntryDate < GETDATE() AND MFG < EXP AND ProductEntryDate > MFG)

----------------------------------------------------
--Truy van du lieu
SELECT * FROM dbo.Employees
SELECT * FROM dbo.Orders
SELECT * FROM dbo.Products
SELECT * FROM dbo.OrdersDetail
SELECT * FROM dbo.ProductsDetail
SELECT * FROM dbo.Accounts
GO

----------------------------------------------------
--insert data into table
--Tai Khoan
INSERT INTO dbo.Accounts( UserName, PassWord, EmployeeID )
VALUES  ( 'KhaiGia123', '123123akpro', 'NV01')
INSERT INTO dbo.Accounts( UserName, PassWord, EmployeeID )
VALUES  ( 'Khaithat', '1234', 'NV02')
INSERT INTO dbo.Accounts( UserName, PassWord, EmployeeID )
VALUES  ( 'proak', '123456', 'NV03')
INSERT INTO dbo.Accounts( UserName, PassWord, EmployeeID )
VALUES  ( 'tholanpro', 'mattich', 'NV04')
GO

--Nhan Vien
INSERT INTO dbo.Employees ( EmployeeID, Name, Phone, Sex, YearOfBirth, Address)
VALUES ('NV01', N'Nguyễn Đình Gia Khải',  '0366255164', 1, 2000 , N'53/36 Lê Lai, Cam Lâm, Khánh Hoà')
INSERT INTO dbo.Employees ( EmployeeID, Name, Phone, Sex, YearOfBirth, Address)
VALUES ('NV02', N'Nguyễn Tứ Tấn Tài',  '0365554561', 0, 1995 , N'KTX Giao Thông Vận Tải')
INSERT INTO dbo.Employees ( EmployeeID, Name, Phone, Sex, YearOfBirth, Address)
VALUES ('NV03', N'Nguyễn Khải',  '0985362254', 1, 2001 , N'36, Lê Văn Việt, Quận 9, tp.Ho Chi Minh')
INSERT INTO dbo.Employees ( EmployeeID, Name, Phone, Sex, YearOfBirth, Address)
VALUES ('NV04', N'Nguyễn Kim Thiện',  '0977545552', 1, 2000 , N'35/45/9/1 Van Lam, Buon Me Thuoc')
GO

--Hoa Don
INSERT INTO dbo.Orders ( OrderID, DateOfOrder, TotalMoney, EmployeeID )
VALUES  ( 'HD01', '20200912', null, 'NV01' )
INSERT INTO dbo.Orders ( OrderID, DateOfOrder, TotalMoney, EmployeeID )
VALUES  ( 'HD02', '20200527', null, 'NV04' )
INSERT INTO dbo.Orders ( OrderID, DateOfOrder, TotalMoney, EmployeeID )
VALUES  ( 'HD03', '20200712', null, 'NV02' )
INSERT INTO dbo.Orders ( OrderID, DateOfOrder, TotalMoney, EmployeeID )
VALUES  ( 'HD04', '20200112', null, 'NV03' )
INSERT INTO dbo.Orders ( OrderID, DateOfOrder, TotalMoney, EmployeeID )
VALUES  ( 'HD05', '20200101', null, 'NV04' )
INSERT INTO dbo.Orders ( OrderID, DateOfOrder, TotalMoney, EmployeeID )
VALUES  ( 'HD06', '20200405', null, 'NV03' )
GO

--San Pham
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP01', N'Sữa chua TH true YOGURT', 99,  15000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP02', N'Sữa tươi sạch thanh trùng', 150,  7000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP03', N'Sữa chua uống men sống Việt Quất', 200,  9000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP04', N'Sữa có đường 180ml', 50,  5000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP05', N'Sữa tiệc trùng không đường', 50,  5000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP06', N'Nước trái cây TH true JUICE ổi tự nhiên', 50,  5000 )
GO

--Chi tiet hoa don
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD01', 1, null, 'HD01', 'SP01')
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD02', 5, null, 'HD04', 'SP01' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD03', 2, null, 'HD02', 'SP04' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD04', 3, null, 'HD03', 'SP02' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD05', 2, null, 'HD05', 'SP03' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD06', 1, null, 'HD06', 'SP02' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD07', 1, null, 'HD04', 'SP03' )
GO

--chi tiet san pham
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP01' ,  1 , '20181024' ,  '20201020' ,  '20190101' ,  'SP01' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP02' ,  1 , '20181010' ,  '20241010' ,  '20181212' ,  'SP04' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP03' ,  1 , '20180505' ,  '20221111' ,  '20190101' ,  'SP02' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP04' ,  1 , '20180909' ,  '20220103' ,  '20190303' ,  'SP03' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP05' ,  1 , '20180909' ,  '20230909' ,  '20190909' ,  'SP06' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP06' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP05' )
GO

----------------------------------------------------
