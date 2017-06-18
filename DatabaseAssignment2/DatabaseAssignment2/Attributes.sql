BEGIN TRANSACTION;

INSERT INTO D_Product VALUES (001, 10, 'Puffy Jacket', 18, 'Jackets', 25, 10);
INSERT INTO D_Product VALUES (002, 16, 'Green T-Shirt', 16, 'Mens T-Shirt', 75, 15);
INSERT INTO D_Product VALUES (003, 10, 'Denom Jeans', 17, 'Unisex Pants', 50, 0);
INSERT INTO D_Product VALUES (004, 4, 'Brown Pants', 10, 'Boys Pants', 25, 10);
INSERT INTO D_Product VALUES (005, 25, 'Blue Pants', 10, 'Boys Pants', 25, 50);


INSERT INTO D_Customer VALUES (2001, 'Fred', 'Jenkins');
INSERT INTO D_Customer VALUES (2002, 'Johnny', 'Williams');
INSERT INTO D_Customer VALUES (2003, 'James', 'McGarth');
INSERT INTO D_Customer VALUES (2004, 'Lucy', 'Luu');
INSERT INTO D_Customer VALUES (2005, 'Bill', 'Robertson');

INSERT INTO D_Order VALUES (1001, 001, 2001, 5, 10, '2017-06-1', 'Processing');
INSERT INTO D_Order VALUES (1002, 001, 2001, 2, 14, '2017-05-31', 'Processing');
INSERT INTO D_Order VALUES (1003, 005, 2003, 2, 20, '2017-05-28', 'In Transit');
INSERT INTO D_Order VALUES (1004, 003, 2003, 2, 20, '2017-05-28', 'In Transit');
INSERT INTO D_Order VALUES (1005, 004, 2005, 2, 20, '2017-05-20', 'Arrived');

INSERT INTO D_Sales_Rep VALUES (2001, 'Mcgarth', 'Fred');
INSERT INTO D_Sales_Rep VALUES (2001, 'Mcgarth', 'Fred');
INSERT INTO D_Sales_Rep VALUES (2003, 'Carry', 'Jim');
INSERT INTO D_Sales_Rep VALUES (2003, 'Carry', 'Jim');
INSERT INTO D_Sales_Rep VALUES (2005, 'Jeremy', 'Richard');

COMMIT TRANSACTION;
GO