CREATE DATABASE SUPERMARKET
GO

USE SUPERMARKET
GO

--SUPPLIER
--PRODUCT
--ACCOUNT
--BILL
--BILLDETAIL

CREATE TABLE SUPPLIER
(
	idSupplier INT IDENTITY PRIMARY KEY,
	supplierName NVARCHAR(100) NOT NULL DEFAULT N'No name'
)
GO

CREATE TABLE PRODUCT
(
	idProduct INT IDENTITY PRIMARY KEY,
	productName NVARCHAR(100) NOT NULL DEFAULT N'No name',
	price FLOAT NOT NULL DEFAULT 0,
	idSupplier INT NOT NULL

	FOREIGN KEY (idSupplier) REFERENCES dbo.SUPPLIER(idSupplier)
)
GO

CREATE TABLE ACCOUNT
(
	userName NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100) NOT NULL DEFAULT N'User',
	passWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	accountType INT NOT NULL DEFAULT 0 -- 1: admin || 0: cashier
)
GO

CREATE TABLE BILL
(
	idBill INT IDENTITY PRIMARY KEY,
	billDate DATE NOT NULL DEFAULT GETDATE(),
	totalPrice FLOAT NOT NULL DEFAULT 0
)
GO

CREATE TABLE BILLDETAIL
(
	idBillDetail INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idProduct INT NOT NULL,
	quantity INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.BILL(idBill),
	FOREIGN KEY (idProduct) REFERENCES dbo.PRODUCT(idProduct)
)
GO

--Account operation
INSERT INTO dbo.ACCOUNT VALUES (N'admin', N'Admin', N'1', 1)
INSERT INTO dbo.ACCOUNT VALUES (N'khang', N'Khang', N'1', 0)
GO

SELECT * FROM dbo.ACCOUNT
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE userName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'admin'
DROP PROC dbo.USP_GetAccountByUserName

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE userName = @userName AND passWord = @passWord
END
GO

--Supplier operation
INSERT INTO dbo.SUPPLIER(supplierName) VALUES ('Sa ltd.')
INSERT INTO dbo.SUPPLIER(supplierName) VALUES ('Sb ltd.')
INSERT INTO dbo.SUPPLIER(supplierName) VALUES ('Sc ltd.')
INSERT INTO dbo.SUPPLIER(supplierName) VALUES ('Sd ltd.')
INSERT INTO dbo.SUPPLIER(supplierName) VALUES ('Se com.')
INSERT INTO dbo.SUPPLIER(supplierName) VALUES ('Sf com.')
INSERT INTO dbo.SUPPLIER(supplierName) VALUES ('Sg com.')
INSERT INTO dbo.SUPPLIER(supplierName) VALUES ('Sh com.')
GO

SELECT * FROM dbo.SUPPLIER
GO

--Product operation
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Bond Bread', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Daves Killer Bread', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Pepsi', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Coca-Cola', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Cameo Creme', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Tiger Milk', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Mr Kipling', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Munchos', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Dutch Lady', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Butterball', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Haywards', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Jiffy mix', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Nescafé', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('McCoys (crisp)', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Indomie', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Samyang', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('ReaLemon', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Monster Munch', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Chocodile Twinkie', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Kettle Foods', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('Swiss cheese', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('vanilla ice cream', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('gooseberry', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('apricot pits', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('maple syrup', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('kidney beans', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('mushroom sauce', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('whole pepper', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('mint drops', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('bonbons', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier) VALUES ('lollipop', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1)

GO

SELECT * FROM dbo.PRODUCT
GO

SELECT idProduct FROM dbo.PRODUCT WHERE productName = 'Cameo Creme'
GO

ALTER TABLE dbo.PRODUCT ADD UNIQUE(productName)
GO

CREATE PROC USP_GetProductList
AS 
	SELECT idProduct, productName, price, supplierName
	FROM dbo.PRODUCT JOIN dbo.SUPPLIER ON dbo.PRODUCT.idSupplier = dbo.SUPPLIER.idSupplier
GO

--Bill operation
CREATE PROC USP_InsertBill
AS 
	INSERT INTO dbo.BILL(billDate) VALUES(GETDATE())
GO

SELECT MAX(idBill) FROM dbo.BILL
GO
SELECT * FROM dbo.BILL
TRUNCATE TABLE dbo.BILLDETAIL
GO
DELETE FROM dbo.BILL
GO
DBCC CHECKIDENT ('BILL', RESEED, 0)

ALTER PROC USP_AddTotalPrice
@idBill INT, @totalPrice FLOAT
AS 
	UPDATE dbo.BILL SET totalPrice = @totalPrice WHERE idBill = @idBill
GO

--BillDetail operation
ALTER PROC USP_InsertBillDetail
@idBill INT, @idProduct INT, @quantity INT
AS
BEGIN
	DECLARE @isExitsBillDetail INT
	DECLARE @newCount INT = 1
	SELECT @isExitsBillDetail = idBillDetail, @newCount = quantity 
	FROM dbo.BILLDETAIL 
	WHERE idBill = @idBill AND idProduct = @idProduct

	IF (@isExitsBillDetail > 0 OR @quantity <= 0)
	BEGIN
		DECLARE @temp INT = @newCount + @quantity
		IF (@temp > 0)
			UPDATE dbo.BILLDETAIL SET quantity = @newCount + @quantity WHERE idProduct = @idProduct AND idBill = @idBill
		ELSE
			DELETE dbo.BILLDETAIL WHERE idBill = @idBill AND idProduct = @idProduct
	END
	ELSE
	BEGIN
		INSERT INTO dbo.BILLDETAIL(idBill, idProduct, quantity) VALUES (@idBill, @idProduct, @quantity)

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayname NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0

	SELECT @isRightPass = COUNT (*) FROM dbo.ACCOUNT WHERE userName = @userName AND passWord = @password

	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.ACCOUNT SET displayName = @displayname WHERE userName = @userName
		END
		ELSE
			UPDATE dbo.ACCOUNT SET displayName = @displayname, passWord = @newPassword WHERE userName = @userName
	END
END
GO
