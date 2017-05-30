BEGIN TRANSACTION;

INSERT INTO D_Product VALUES (001, 10, 'Puffy Jacket', 18, 'Jackets', 25);
INSERT INTO D_Product VALUES (002, 16, 'Green T-Shirt', 16, 'Mens T-Shirt', 75);
INSERT INTO D_Product VALUES (003, 10, 'Denom Jeans', 17, 'Unisex Pants', 50);
INSERT INTO D_Product VALUES (004, 4, 'Brown Pants', 10, 'Boys Pants', 25);
INSERT INTO D_Product VALUES (005, 25, 'Blue Pants', 10, 'Boys Pants', 25);

INSERT INTO D_Order VALUES (1001, 001, 5, 'On Transit',  10);
INSERT INTO D_Order VALUES (1002, 001, 2, 'Processing',  14);
INSERT INTO D_Order VALUES (1003, 004, 2, 'Processing',  20);
INSERT INTO D_Order VALUES (1003, 004, 2, '',  20);
INSERT INTO D_Order VALUES (1003, 004, 2, 'Processing',  20);

