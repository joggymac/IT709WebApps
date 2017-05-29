CREATE TABLE D_Product (
ProductID			INT PRIMARY KEY,
Description			VARCHAR(20) NOT NULL,
No_of_Units			INT NOT NULL,
Min_Level			INT NOT NULL,
Cat					VARCHAR(20),
Unit_Price			MONEY,
Discount			INT
)

CREATE TABLE D_Order (
OrderID				INT PRIMARY KEY,
ProductID			INT PRIMARY KEY REFERENCES Product(ProductID),
No_of_Units			INT REFERENCES Product(No_of_Units),
Order_Date			DATE NOT NULL,
Order_Status		VARCHAR(20) NOT NULL,
Quoated_Price		MONEY NOT NULL
)

CREATE TABLE D_Customer (
CustID				INT PRIMARY KEY,
OrderID				INT PRIMARY KEY REFERENCES D_Order(OrderID),
Lname				VARCHAR(20) NOT NULL,
Fname				VARCHAR(20) NOT NULL,
Order_Date			DATE REFERENCES D_Order(Order_Date)
)

CREATE TABLE D_Sales_Rep (
SalesrepID			INT PRIMARY KEY,
CustID				INT PRIMARY KEY REFERENCES D_Customer(CustID),
Lname				VARCHAR(20) NOT NULL,
Fname				VARCHAR(20) NOT NULL,
)