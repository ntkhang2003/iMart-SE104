﻿CREATE DATABASE SUPERMARKET
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

INSERT INTO dbo.ACCOUNT VALUES (N'admin', N'Admin', N'123456', 1)
INSERT INTO dbo.ACCOUNT VALUES (N'khang', N'Khang', N'123456', 0)

SELECT * FROM dbo.ACCOUNT

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