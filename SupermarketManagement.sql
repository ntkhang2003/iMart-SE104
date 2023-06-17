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
	productName NVARCHAR(100) NOT NULL DEFAULT N'No name' UNIQUE,
	price FLOAT NOT NULL DEFAULT 0,
	idSupplier INT NOT NULL,
	productStatus INT NOT NULL DEFAULT 1 -- 1: used || 0: not used

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
	cashierName NVARCHAR(100) NOT NULL,
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
INSERT INTO dbo.ACCOUNT VALUES (N'admin', N'Admin', N'1962026656160185351301320480154111117132155', 1)
INSERT INTO dbo.ACCOUNT VALUES (N'cashier1', N'Cashier1', N'1962026656160185351301320480154111117132155', 0)
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.ACCOUNT WHERE userName = @userName
END
GO

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

--Product operation
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Bond Bread', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Daves Killer Bread', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Pepsi', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Coca-Cola', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Cameo Creme', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Tiger Milk', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Mr Kipling', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Munchos', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Dutch Lady', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Butterball', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Haywards', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Jiffy mix', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Nescafé', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('McCoys (crisp)', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Indomie', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Samyang', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('ReaLemon', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Monster Munch', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Chocodile Twinkie', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Kettle Foods', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Swiss cheese', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('vanilla ice cream', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('gooseberry', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('apricot pits', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('maple syrup', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('kidney beans', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('mushroom sauce', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('whole pepper', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('mint drops', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('bonbons', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('lollipop', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('King Arthur Baking', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Ralcorp', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Nespresso', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
INSERT INTO dbo.PRODUCT(productName, price, idSupplier, productStatus) VALUES ('Zest-O', FORMAT(RAND()*(80-5)+5, 'N2'), FLOOR(RAND() * 8) + 1, 1)
GO

CREATE PROC USP_GetProductList
AS 
	SELECT idProduct, productName, price, supplierName
	FROM dbo.PRODUCT JOIN dbo.SUPPLIER ON dbo.PRODUCT.idSupplier = dbo.SUPPLIER.idSupplier
	WHERE productStatus = 1
GO

CREATE PROC USP_GetDeletedList
AS
	SELECT idProduct, productName, price, supplierName
	FROM dbo.PRODUCT JOIN dbo.SUPPLIER ON dbo.PRODUCT.idSupplier = dbo.SUPPLIER.idSupplier
	WHERE productStatus = 0
GO

--Bill operation
CREATE PROC USP_InsertBill
@cashierName NVARCHAR(100)
AS
	INSERT INTO dbo.BILL(cashierName) VALUES(@cashierName)
GO

CREATE PROC USP_AddTotalPrice
@idBill INT, @totalPrice FLOAT
AS 
	UPDATE dbo.BILL SET totalPrice = @totalPrice WHERE idBill = @idBill
GO

CREATE PROC USP_GetListBillByDate
@dateBegin DATE, @dateEnd DATE
AS
BEGIN
	SELECT idBill, cashierName, billDate, totalPrice
	FROM dbo.BILL
	WHERE billDate >= @dateBegin AND billDate <= @dateEnd
END
GO

--BillDetail operation
CREATE PROC USP_InsertBillDetail
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
	END
END
GO

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