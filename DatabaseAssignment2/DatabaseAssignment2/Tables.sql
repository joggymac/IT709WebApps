﻿DROP TABLE D_Sales_Rep
DROP TABLE D_Order
DROP TABLE D_Customer
DROP TABLE D_Product

CREATE TABLE D_Product (
ProductID			INT NOT NULL PRIMARY KEY,
No_of_Units			INT  NOT NULL,
Description			VARCHAR(20) NOT NULL,
Min_Level			INT NOT NULL,
Cat					VARCHAR(20) NOT NULL,
Unit_Price			MONEY NOT NULL,
Discount			INT
)

CREATE TABLE D_Customer (
CustID				INT PRIMARY KEY,
Lname				VARCHAR(20) NOT NULL,
Fname				VARCHAR(20) NOT NULL,

)

CREATE TABLE D_Order (
OrderID				INT NOT NULL PRIMARY KEY,
ProductID			INT NOT NULL REFERENCES D_Product(ProductID),
CustID				INT REFERENCES D_Customer(CustID),
No_of_Units			INT NOT NULL,
Quoated_Price		MONEY NOT NULL,
Date				DATE DEFAULT GETDATE() NOT NULL,
Order_Status		VARCHAR(10) DEFAULT 'Processing' NOT NULL
)

CREATE TABLE D_Sales_Rep (
CustID				INT NOT NULL REFERENCES D_Customer(CustID),
Lname				VARCHAR(20) NOT NULL,
Fname				VARCHAR(20) NOT NULL,
)

SELECT * FROM D_Product
SELECT * FROM D_Customer
SELECT * FROM D_Order
SELECT * FROM D_Sales_Rep
