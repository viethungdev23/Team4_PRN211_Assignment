DROP DATABASE FStore

CREATE DATABASE FStore
Go

USE FStore
GO



CREATE TABLE Category(
	CategoryId INT NOT NULL PRIMARY KEY,
	CategoryName VARCHAR(40) NOT NULL
);
go

CREATE TABLE Member
(
  MemberId INT NOT NULL PRIMARY KEY,
  Email  VARCHAR(100) NOT NULL,
  CompanyName VARCHAR(40) NOT NULL,
  City VARCHAR(15) NOT NULL,
  Country VARCHAR(15) NOT NULL,
  [Password] VARCHAR(30) NOT NULL,
);
go

CREATE TABLE [Order]
(
  OrderId INT NOT NULL PRIMARY KEY,
  OrderDate DATETIME NOT NULL,
  MemberId int not null,
  RequiredDate DATETIME NULL,
  ShippedDate DATETIME NULL,
  Freight MONEY NULL,
);
go

CREATE TABLE Product
(
  ProductId INT NOT NULL PRIMARY KEY,
  CategoryId INT NOT NULL,
  ProductName VARCHAR(40) NOT NULL,
  [Weight] VARCHAR(20) NOT NULL,
  UnitPrice MONEY NOT NULL,
  UnitsInStock INT NOT NULL,
);
go

CREATE TABLE OrderDetail
(
  ProductId INT NOT NULL,
  OrderId INT NOT NULL,
  UnitPrice MONEY NOT NULL,
  Quantity INT NOT NULL,
  Discount FLOAT NOT NULL,
  PRIMARY KEY (ProductId,OrderId)
);
go

ALTER TABLE Product
ADD FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)

ALTER TABLE [Order]
ADD FOREIGN KEY (MemberId) REFERENCES Member(MemberId)

ALTER TABLE OrderDetail
ADD FOREIGN KEY (ProductId) REFERENCES Product(ProductId)

ALTER TABLE OrderDetail
ADD FOREIGN KEY (OrderId) REFERENCES [Order](OrderId)

-- INSERT DATA --

SET IDENTITY_INSERT Category ON
INSERT INTO Category(CategoryId,CategoryName)
VALUES (1,'category 1');
INSERT INTO Category(CategoryId,CategoryName)
VALUES (2,'category 2');
SET IDENTITY_INSERT Category OFF


SET IDENTITY_INSERT Member ON
INSERT INTO Member(MemberId,Email,CompanyName,City,Country,[Password])
VALUES (1,'member1@gmail.com','FPT Software','HCM','US',123);
INSERT INTO Member(MemberId,Email,CompanyName,City,Country,[Password])
VALUES (2,'member2@gmail.com','ABC Software','HA NOI','Canada',123);
INSERT INTO Member(MemberId,Email,CompanyName,City,Country,[Password])
VALUES (3,'member3@gmail.com','KMS','HCM','VN',123);
SET IDENTITY_INSERT Member OFF

SET IDENTITY_INSERT Product ON
INSERT INTO Product(ProductId,CategoryId,ProductName,[Weight],UnitPrice,UnitsInStock)
VALUES (1,1,'Product 1','3,6kg',100000,100)
INSERT INTO Product(ProductId,CategoryId,ProductName,[Weight],UnitPrice,UnitsInStock)
VALUES (2,2,'Product 2','5,8kg',200000,100)
INSERT INTO Product(ProductId,CategoryId,ProductName,[Weight],UnitPrice,UnitsInStock)
VALUES (3,1,'Product 3','2,0kg',300000,100)
INSERT INTO Product(ProductId,CategoryId,ProductName,[Weight],UnitPrice,UnitsInStock)
VALUES (4,2,'Product 4','1,2kg',400000,100)
INSERT INTO Product(ProductId,CategoryId,ProductName,[Weight],UnitPrice,UnitsInStock)
VALUES (5,1,'Product 5','4,4kg',500000,100)
SET IDENTITY_INSERT Product OFF
