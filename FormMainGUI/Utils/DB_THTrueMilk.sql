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
	Role VARCHAR(50) NOT NULL,
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
--Nhan Vien
INSERT INTO dbo.Employees ( EmployeeID, Name, Phone, Sex, YearOfBirth, Address)
VALUES ('NV05', N'Phạm Thành Trung',  '0126888899', 1, 1994 , N'T.P Hồ Chí Minh')
INSERT INTO dbo.Employees ( EmployeeID, Name, Phone, Sex, YearOfBirth, Address)
VALUES ('NV01', N'Nguyễn Đình Gia Khải',  '0366255164', 1, 2000 , N'53/36 Lê Lai, Cam Lâm, Khánh Hoà')
INSERT INTO dbo.Employees ( EmployeeID, Name, Phone, Sex, YearOfBirth, Address)
VALUES ('NV02', N'Nguyễn Tứ Tấn Tài',  '0365554561', 0, 1995 , N'KTX Giao Thông Vận Tải')
INSERT INTO dbo.Employees ( EmployeeID, Name, Phone, Sex, YearOfBirth, Address)
VALUES ('NV03', N'Lê Mạnh Tài',  '0985362254', 1, 2001 , N'36, Lê Văn Việt, Quận 9, tp.Ho Chi Minh')
INSERT INTO dbo.Employees ( EmployeeID, Name, Phone, Sex, YearOfBirth, Address)
VALUES ('NV04', N'Nguyễn Kim Thiện',  '0977545552', 1, 2000 , N'35/45/9/1 Van Lam, Buon Me Thuoc')
GO

--Tai Khoan
INSERT INTO dbo.Accounts( UserName, PassWord, Role ,EmployeeID )
VALUES  ( 'Admin', '1234', 'admin' ,'NV01')
INSERT INTO dbo.Accounts( UserName, PassWord, Role ,EmployeeID )
VALUES  ( 'staff1', 'staff1', 'member' ,'NV01')
INSERT INTO dbo.Accounts( UserName, PassWord, Role , EmployeeID )
VALUES  ( 'staff2', 'staff2', 'member', 'NV02')
INSERT INTO dbo.Accounts( UserName, PassWord, Role , EmployeeID )
VALUES  ( 'staff3', 'staff3', 'member', 'NV04')
INSERT INTO dbo.Accounts( UserName, PassWord, Role , EmployeeID )
VALUES  ( 'staff4', 'staff4', 'member', 'NV05')
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
VALUES  ( 'SP001', N'Sữa chua TH true YOGURT', 99,  15000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP002', N'Sữa tươi sạch thanh trùng', 150,  7000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP003', N'Sữa chua uống men sống Việt Quất', 200,  9000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP004', N'Sữa tươi có đường 180ml', 300,  5000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP005', N'Sữa tiệc trùng không đường', 300,  5000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP006', N'Nước trái cây TH true JUICE ổi tự nhiên', 50,  10000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP007', N'Nước tinh khiết TH true Water ', 50,  5000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP008', N'Nước trái cây TH true JUICE cam tự nhiên', 50,  10000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP009', N'Nước trái cây TH true JUICE ổi tự nhiên', 50,  10000 )	
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP010', N'Nước trái cây TH true JUICE dâu tự nhiên', 50,  12000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP011', N'Sữa hạt dẻ cười TH true Nut', 60,  50000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP012', N'Sữa hạt và gạo lứt đỏ TH true Nut', 20,  50000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP013', N'Sữa hạt và gấc TH true Nut', 50,  50000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP014', N'Sữa hạt hạnh nhân TH true Nut', 45,  50000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP015', N'Sữa hạt macca TH true Nut', 50,  50000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP016', N'Kem ốc quế Socola nguyên chất', 25,  20000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP017', N'Kem ốc quế Dâu', 20,  20000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP018', N'Kem sandwich Socola nguyên chất', 30,  22000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP019', N'Kem que đâu xanh tự nhiên', 40,  16000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP020', N'Kem que dừa tự nhiên', 50,  16000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP021', N'Kem hộp Socola nguyên chất', 24,  18000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP022', N'Kem hộp Matcha tự nhiên', 50,  50000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP023', N'Bơ lạt tự nhiên', 30,  50000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP024', N'Sữa tươi hương dâu trong bịch giấy', 500,  7000 )
INSERT INTO dbo.Products ( ProductID, Name, Quantity, Price )
VALUES  ( 'SP025', N'Sữa tươi ít đường trong bịch giấy', 500,  7000 )
GO

--Chi tiet hoa don
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD01', 1, null, 'HD01', 'SP001')
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD02', 5, null, 'HD04', 'SP001' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD03', 2, null, 'HD02', 'SP004' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD04', 3, null, 'HD03', 'SP002' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD05', 2, null, 'HD05', 'SP003' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD06', 1, null, 'HD06', 'SP002' )
INSERT INTO dbo.OrdersDetail ( OrderDetailID, Quantity, TotalAmount, OrderID, ProductID )
VALUES  ( 'CTHD07', 1, null, 'HD04', 'SP003' )
GO

--chi tiet san pham
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP01' ,  1 , '20181024' ,  '20201020' ,  '20190101' ,  'SP001' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP02' ,  1 , '20181010' ,  '20241010' ,  '20181212' ,  'SP004' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP03' ,  1 , '20180505' ,  '20221111' ,  '20190101' ,  'SP002' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP04' ,  1 , '20180909' ,  '20220103' ,  '20190303' ,  'SP003' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP05' ,  1 , '20180909' ,  '20230909' ,  '20190909' ,  'SP006' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP06' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP005' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP07' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP007' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP08' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP008' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP09' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP09' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP10' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP010' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP11' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP011' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP12' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP012' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP13' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP013' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP14' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP014' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP15' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP015' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP16' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP016' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP17' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP017' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP18' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP018' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP19' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP019' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP20' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP020' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP21' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP021' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP22' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP022' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP23' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP023' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP24' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP024' )
INSERT INTO dbo.ProductsDetail ( ProductDetailID , Status , MFG , EXP , ProductEntryDate , ProductID )
VALUES  ( 'CTSP25' ,  1 , '20180909' ,  '20231003' ,  '20181010' ,  'SP025' )
GO

UPDATE OrdersDetail 
SET TotalAmount=Quantity* (SELECT PRICE FROM Products 
WHERE OrdersDetail.ProductID = Products.ProductID)

update Orders
set TotalMoney=(SELECT SUM(TotalAmount) AS "Tong tien"
FROM OrdersDetail
WHERE Orders.OrderID = OrderID)

select sum(TotalMoney) as HD
from Orders
group by Month(DateOfOrder)
----------------------------------------------------
