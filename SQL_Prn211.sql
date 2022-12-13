DROP DATABASE SaleManagement

CREATE DATABASE SaleManagement
Go

USE SaleManagement
GO

CREATE TABLE Member
(
  MemberId INT NOT NULL PRIMARY KEY,
  Email  VARCHAR(100) NOT NULL,
  CompanyName VARCHAR(40) NOT NULL,
  City VARCHAR(15) NOT NULL,
  Country VARCHAR(15) NOT NULL,
  [Password] VARCHAR(30) NOT NULL,
);

CREATE TABLE [Order]
(
  OrderId INT NOT NULL PRIMARY KEY,
  OrderDate DATETIME NOT NULL,
  MemberId int not null,
  RequiredDate DATETIME NULL,
  ShippedDate DATETIME NULL,
  Freight MONEY NULL,
);

CREATE TABLE Product
(
  ProductId INT NOT NULL PRIMARY KEY,
  Category INT NOT NULL,
  ProductName VARCHAR(40) NOT NULL,
  [Weight] VARCHAR(20) NOT NULL,
  UnitPrice MONEY NOT NULL,
  UnitsInStock INT NOT NULL,
);

CREATE TABLE OrderDetail
(
  ProductId INT NOT NULL,
  OrderId INT NOT NULL,
  UnitPrice MONEY NOT NULL,
  Quantity INT NOT NULL,
  Discount FLOAT NOT NULL,
  PRIMARY KEY (ProductId,OrderId)
);

ALTER TABLE [Order]
ADD FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
ALTER TABLE OrderDetail
ADD FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
ALTER TABLE OrderDetail
ADD FOREIGN KEY (OrderId) REFERENCES [Order](OrderId)

-- INSERT DATA --

INSERT INTO Member
VALUES(1,'member1@gmail.com','FPT Company','TP HCM','VN', '123'),
(2,'member2@gmail.com','Vietinbank Company','TP HCM','VN', '123'),
(3,'member3@gmail.com','Vinamilk Company','TP HCM','VN', '123'),
(4,'member4@gmail.com','Habeco Company','TP HCM','VN', '123'),
(5,'member5@gmail.com','MobiFone Company','TP HCM','VN', '123')

INSERT INTO Product
VALUES(1,1,'Product 1','4,3kg',10000000,100),
(2,1,'Product 2','2,1kg',20000000,100),
(3,1,'Product 3','1,3kg',18000,100),
(4,1,'Product 4','100g',4000,100),
(5,1,'Product 5','300kg',5000,100)

INSERT INTO [dbo].[Order]
VALUES(1, N'2022-05-05T00:00:00.000',1 , N'2022-05-07T00:00:00.000', N'2022-05-07T00:00:00.000' , 15000.0000),
(2, N'2022-05-05T00:00:00.000',2 , N'2022-05-07T00:00:00.000', N'2022-05-07T00:00:00.000' , 16000.0000),
(3, N'2022-05-05T00:00:00.000',3 , N'2022-05-07T00:00:00.000', N'2022-05-07T00:00:00.000' , 123500.0000),
(4, N'2022-05-05T00:00:00.000',4 , N'2022-05-07T00:00:00.000', N'2022-05-07T00:00:00.000' , 153420.0000),
(5, N'2022-05-05T00:00:00.000',5 , N'2022-05-07T00:00:00.000', N'2022-05-07T00:00:00.000' , 4464.0000)

INSERT INTO [dbo].[OrderDetail]
VALUES(1, 1, 10000.0000, 1, 1),
(1, 4, 15000.0000, 4, 3),
(2, 3, 15000.0000, 1, 3),
(4, 1, 20000.0000, 2, 2)