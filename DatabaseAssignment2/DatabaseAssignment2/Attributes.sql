﻿BEGIN TRANSACTION;

INSERT INTO D_Product VALUES (001, 10, 'Puffy Jacket', 18, 'Jackets', 25, 10);
INSERT INTO D_Product VALUES (002, 16, 'Green T-Shirt', 16, 'Mens T-Shirt', 75, 15);
INSERT INTO D_Product VALUES (003, 10, 'Denom Jeans', 17, 'Unisex Pants', 50, 5);
INSERT INTO D_Product VALUES (004, 4, 'Brown Pants', 10, 'Boys Pants', 25, 10);
INSERT INTO D_Product VALUES (005, 25, 'Blue Pants', 10, 'Boys Pants', 25, 50);

INSERT INTO D_Order VALUES (1001, 001, 5, 10);
INSERT INTO D_Order VALUES (1002, 001, 2, 14);
INSERT INTO D_Order VALUES (1003, 005, 2, 20);
INSERT INTO D_Order VALUES (1004, 003, 2, 20);
INSERT INTO D_Order VALUES (1005, 004, 2, 20);

INSERT INTO D_Customer VALUES (2001, 'Fred', 'Jenkins');
INSERT INTO D_Customer VALUES (2002, 'Johnny', 'Williams');
INSERT INTO D_Customer VALUES (2003, 'James', 'McGarth');
INSERT INTO D_Customer VALUES (2004, 'Lucy', 'Luu');
INSERT INTO D_Customer VALUES (2005, 'Bill', 'Robertson');

INSERT INTO D_Customer_Orders VALUES (1001, 31-05-2017, 2001, 'Processing');
INSERT INTO D_Customer_Orders VALUES (1002, 01-06-2017, 2001, 'Processing');
INSERT INTO D_Customer_Orders VALUES (1003, 28-05-2017, 2003, 'In Transit');
INSERT INTO D_Customer_Orders VALUES (1004, 21-05-2017, 2005, 'Arrived');
INSERT INTO D_Customer_Orders VALUES (1005, 01-06-2017, 2004, 'Processing');

INSERT INTO D_Sales_Rep