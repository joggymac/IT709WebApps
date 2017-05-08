-- Script to create and populate the tables for the Computer Sales system

-- Drop the tables if they exist already

DROP TABLE Order_Line;
DROP TABLE Product;
DROP TABLE ClientOrder;
DROP TABLE Client;

-- Create the database tables

-- Create the Client table

CREATE TABLE Client
(ClientID      INT    PRIMARY KEY,
 LastName      VARCHAR(20) NOT NULL,
 FirstName     VARCHAR(20),
 StreetAddress VARCHAR(40) NOT NULL,
 Suburb        VARCHAR(20) NOT NULL,
 City          VARCHAR(20) NOT NULL,
 PhoneNumber   VARCHAR(10)
);

-- Create the ClientOrder table

CREATE TABLE ClientOrder
(ClientOrderID   INT  PRIMARY KEY,
 OrderDate       DATE,
 ClientID        INT  REFERENCES Client(ClientID),
 Status          CHAR(1)    CHECK (Status IN ('U','N','P'))
);

-- Create the Product table

CREATE TABLE Product
(ProductID       INT    PRIMARY KEY,
 Description     VARCHAR(30) NOT NULL,
 InStock         INT,
 Price           MONEY
);

--- Create the Order_Line table

CREATE TABLE Order_Line
(ClientOrderID  INT    REFERENCES ClientOrder(ClientOrderID),
 ProductID      INT    REFERENCES Product(ProductID),
                             PRIMARY KEY (ClientOrderID,ProductID),
 Quantity       INT
);

BEGIN TRANSACTION ;

-- Populate the tables with sample data

-- Insert records into the Client table

INSERT INTO Client
 VALUES(1,	'Smith',	'Frank', '12 King Street',	'Avondale',	'Auckland',	'566-1234');
INSERT INTO Client
 VALUES(2,	'Jones',	'Sarah', '20 High Street',	'East',		'Christchurch',	'345-6565');
INSERT INTO Client
 VALUES(3,	'Connors',	'Fred',	 '34 Queen Street',	'Mt Roskill',	'Auckland',	'566-3333');
INSERT INTO Client
 VALUES(4,	'Headon',	'Jill',	 '103 King Street',	'Petoni',	'Wellington',	'333-2323');
INSERT INTO Client
 VALUES(5,	'Smith',	'Ben',	 '14 Princess Road',	'Kirkbridie',	'Wellington',	'454-8986');
INSERT INTO Client
 VALUES(6,	'Foster',	'Mike',	 '20 Viper Road',	'Mt Albert',	'Auckland',	'566-3433');
INSERT INTO Client
 VALUES(7,	'Edwards', 	'Steve', '31 Laleham',  	'Ponsonby',	'Wellington',	'444-3456');
INSERT INTO Client
 VALUES(8,	'Bentall', 	'Karen', '1 Jade Road', 	'South',	'Dunedin',	'332-2311');
INSERT INTO Client
 VALUES(9,	'Leech',	'Mick',	 '99 King Street',	'East',		'Christchurch',	'345-4343');
INSERT INTO Client
 VALUES(10,	'Gordon',	'Jo',	 '39 South Street',	'Avondale',	'Auckland',	'566-7777');


-- Insert records into the ClientOrder table

INSERT INTO ClientOrder
 VALUES (101, 	'2010-02-20',	1,	'U');
INSERT INTO ClientOrder
 VALUES (102, 	'2010-02-21',	2,	'U');
INSERT INTO ClientOrder
 VALUES (103,	'2010-02-22',	3,	'U');
INSERT INTO ClientOrder
 VALUES (104,	'2010-02-23',	4,	'U');
INSERT INTO ClientOrder
 VALUES (105,	'2010-02-23',	6, 	'U');
INSERT INTO ClientOrder
 VALUES (106,	'2010-02-23',	8,	'U');
INSERT INTO ClientOrder
 VALUES (107,	'2010-02-24', 	1,	'U');
INSERT INTO ClientOrder
 VALUES (108,	'2010-02-24',	9,	'U');
INSERT INTO ClientOrder
 VALUES (109,	'2010-02-24',	2,	'U');
INSERT INTO ClientOrder
 VALUES (110,	'2010-02-25',	1,	'U');

-- Insert records into the Product table

INSERT INTO Product
 VALUES (1,	'Sound Card',   	10,	75.50);
INSERT INTO Product
 VALUES (2,	'Network Card', 	12,	50.00);
INSERT INTO Product
 VALUES (3,	'RS232 Interface',	20,	20.00);
INSERT INTO Product
 VALUES (4,	'RJ45 Lead',    	34,	14.99);
INSERT INTO Product
 VALUES (5,	'I/O Card',     	50,	45.00);
INSERT INTO Product
 VALUES (6,	'10g Hard Drive',	25,	200.00);
INSERT INTO Product
 VALUES (7,	'15g Hard Drive',	24,	250.00);
INSERT INTO Product
 VALUES (8,	'Floppy Drive', 	2,	100.00);
INSERT INTO Product
 VALUES (9,	'Motherboard V1',	30,	275.00);
INSERT INTO Product
 VALUES (10,	'Motherboard V2',	40,	300.00);


-- Insert records into the Order_Line table

INSERT INTO Order_Line
 VALUES (101,	1,	2);
INSERT INTO Order_Line
 VALUES (101,	8,	1);
INSERT INTO Order_Line
 VALUES (102,	2,	4);
INSERT INTO Order_Line
 VALUES (102,	3,	5);
INSERT INTO Order_Line
 VALUES (102,	6,	2);
INSERT INTO Order_Line
 VALUES (102,	7,	1);
INSERT INTO Order_Line
 VALUES (103,	4,	4);
INSERT INTO Order_Line
 VALUES (103,	5,	2);
INSERT INTO Order_Line
 VALUES (104,	8,	1);
INSERT INTO Order_Line
 VALUES (105,	3,	1);
INSERT INTO Order_Line
 VALUES (105,	4,	2);
INSERT INTO Order_Line
 VALUES (105,	5,	3);
INSERT INTO Order_Line
 VALUES (106,	1,	2);
INSERT INTO Order_Line
 VALUES (106,	2,	1);
INSERT INTO Order_Line
 VALUES (107,	2,	3);
INSERT INTO Order_Line
 VALUES (107,	3,	1);
INSERT INTO Order_Line
 VALUES (108,	2,	2);
INSERT INTO Order_Line
 VALUES (109,	3,	2);
INSERT INTO Order_Line
 VALUES (109,	8,	2);
INSERT INTO Order_Line
 VALUES (110,	5,	4);


-- Permanently save all records inserted into the tables

COMMIT TRANSACTION ;
