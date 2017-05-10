/*--------------------------------------------------*/
/*   CREATED BY                          */ 
/*   DATE  20/03/2016                                */
/*   PURPOSE: creates and populates MOVIE database  */
/*--------------------------------------------------*/

/* --------  create tables -----------------      */


CREATE TABLE M_customer
(CustID 	INT	     PRIMARY KEY,
 LastName	VARCHAR(25) NOT NULL,
 FirstName	VARCHAR(25) NOT NULL,
 StreetAddress	VARCHAR(25)  NOT NULL,
 Phone		VARCHAR(8),
 Discount	INT
);

CREATE TABLE M_Category
(Cat		VARCHAR(3)  PRIMARY KEY,
 Description	VARCHAR(20) NOT NULL
);

CREATE TABLE M_Supplier
(SupplierID	VARCHAR(5)   PRIMARY KEY,
 SupplierName	VARCHAR(25)  NOT NULL,	
 StreetAddress	VARCHAR(25)  NOT NULL,
 Phone		VARCHAR(8)
);

CREATE TABLE M_Movie
(MovieID	INT     PRIMARY KEY,
 Title		VARCHAR(40)  NOT NULL,
 Cat		VARCHAR(3)   NOT NULL REFERENCES M_Category(Cat),
 Quantity	INT,
 QuantityOut	INT,
 PurchasePrice	MONEY,
 RentalPrice	MONEY,
 SupplierID	VARCHAR(5)   NOT NULL REFERENCES M_Supplier(supplierID)
);

CREATE TABLE M_Rental
(CustID  	INT  REFERENCES M_Customer(CustID),
 MovieID	INT  REFERENCES M_Movie(MovieID),
 CopyID		INT,
 DueDate	DATE       NOT NULL,
 PRIMARY KEY (CustID, MovieID, CopyID)
);

CREATE TABLE M_Booking
(CustID		INT  REFERENCES M_customer(CustID),
 MovieID	INT  REFERENCES M_Movie(MovieID),
 DateRequired	DATE,
 DateBooked	DATE       NOT NULL,
 DateReturned	DATE       NOT NULL,
 PRIMARY KEY(CustID, MovieID,DateRequired)
);

BEGIN TRANSACTION;

/* --------  populate tables -----------------      */

INSERT INTO M_Customer VALUES (8920, 'Simpson',	'Sara',	'45 King Street',	'315-4883', 11);
INSERT INTO M_Customer VALUES (8921, 'Black',		'Ray',	'55 Queen Street',	'325-4464', 12);
INSERT INTO M_Customer VALUES (8922, 'Knight',	'Alan',	'11 Ohio Street',	'345-3454', 15);
INSERT INTO M_Customer VALUES (8923, 'Strain',	'Ian',	'21 Missisippi Road',	'767-6566', 5);
INSERT INTO M_Customer VALUES (8924, 'Cole',		'Joe',	'34 North Road',	'445-5814', 13);
INSERT INTO M_Customer VALUES (8925, 'Grant',		'Jo',	'42 South Road',	'465-5564', 7);
INSERT INTO M_Customer VALUES (8926, 'White',		'Cass', '12 Young Street',	'477-5884', 14);
INSERT INTO M_Customer VALUES (8927, 'Green',		'Alan', '76 Western Avenue',	'465-5464', 12);
INSERT INTO M_Customer VALUES (8928, 'Jackson',	'Sam',	'31 Alaska Drive',	'415-5744', 10);
INSERT INTO M_Customer VALUES (8929, 'Smith',		'Jeff', '99 Elliot Drive',	'414-5577', 8);


INSERT INTO M_Category VALUES ('DRA', 'Drama');
INSERT INTO M_Category VALUES ('WES', 'Western');
INSERT INTO M_Category VALUES ('COM', 'Comedy');
INSERT INTO M_Category VALUES ('CHI', 'Children');
INSERT INTO M_category VALUES ('CLA', 'Classic');
INSERT INTO M_category VALUES ('MUS', 'Music');
INSERT INTO M_Category VALUES ('ACT', 'Action');
INSERT INTO M_Category VALUES ('SFI', 'Science Fiction');


INSERT INTO M_Supplier VALUES ('SP001',	'Mid-City Videos',	'111 Midcity Plaza',	'123-4567');
INSERT INTO M_Supplier VALUES ('SP002',	'South Videos',		'2 Duncan Street',	'987-6543');
INSERT INTO M_Supplier VALUES ('SP003',	'North Videos',		'99 Lucky Lane',	'007-1442');
INSERT INTO M_Supplier VALUES ('SP004',	'Central Videos',	'45 Sampson Close',	'022-3312');
INSERT INTO M_Supplier VALUES ('SP005',	'Kilburn Videos',	'49 Langdon Lane',	'032-1299');


INSERT INTO M_Movie VALUES (0001,'Kill Bill Vol. 1',	'ACT', 2, 2, 70.00, 8.50, 'SP001');                                                                                    
INSERT INTO M_Movie VALUES (0002,'Kill Bill Vol. 2',	'ACT', 4, 4, 80.00, 9.00, 'SP002');                                                                                 
INSERT INTO M_Movie VALUES (0003,'Heavenly Creatures',	'DRA', 2, 0, 60.00, 5.00, 'SP002');                                                                                 
INSERT INTO M_Movie VALUES (0004,'School of Rock',		'COM', 4, 1, 70.00, 7.00, 'SP003');                                                                                    
INSERT INTO M_Movie VALUES (0005,'Captain Scarlet: Vol 1',	'CHI', 1, 1, 30.00, 3.50, 'SP002');                                                                                    
INSERT INTO M_Movie VALUES (0006,'Bambi',			'CHI', 3 ,0, 45.00, 4.00, 'SP004');                                                                                  
INSERT INTO M_Movie VALUES (0007,'Walking Tall',		'ACT', 2, 2, 80.00, 9.00, 'SP003');                                                                                    
INSERT INTO M_Movie VALUES (0008,'Wuthering Heights',	'CLA', 6, 1, 45.00, 4.50, 'SP004');                                                                                  
INSERT INTO M_Movie VALUES (0009,'Emma',			'CLA', 1, 0, 40.00, 5.50, 'SP002');                                                                                  
INSERT INTO M_Movie VALUES (0010,'The White Stripes Live',	'MUS', 2, 2, 75.00, 8.00, 'SP003');
INSERT INTO M_Movie VALUES (0011,'21 Grams',		'DRA', 3, 1, 80.00, 8.00, 'SP001');
INSERT INTO M_Movie VALUES (0012,'The Unforgiven',		'WES', 2, 2, 60.00, 6.00, 'SP003');
INSERT INTO M_Movie VALUES (0013,'The Wild Bunch',		'WES', 1, 0, 70.00, 5.00, 'SP004');
INSERT INTO M_Movie VALUES (0014,'Mystic River',		'DRA', 2, 2, 75.00, 8.00, 'SP004');
INSERT INTO M_Movie VALUES (0015,'The Hives Dead/Live',	'MUS', 3, 1, 60.00, 8.00, 'SP001');
INSERT INTO M_Movie VALUES (0016,'Apocalypse Now Redux',	'ACT', 4, 2, 70.00, 8.00, 'SP001');


INSERT INTO M_Rental VALUES (8921, 0001, 1, '2011-04-09');
INSERT INTO M_Rental VALUES (8921, 0002, 1, '2011-04-08');
INSERT INTO M_Rental VALUES (8921, 0015, 1, '2011-04-09');
INSERT INTO M_Rental VALUES (8922, 0001, 2, '2011-04-09');
INSERT INTO M_Rental VALUES (8922, 0002, 2, '2011-04-08');
INSERT INTO M_Rental VALUES (8924, 0010, 1, '2011-04-10');
INSERT INTO M_Rental VALUES (8925, 0004, 1, '2011-04-11');
INSERT INTO M_Rental VALUES (8925, 0014, 1, '2011-04-11');
INSERT INTO M_Rental VALUES (8925, 0016, 1, '2011-04-11');
INSERT INTO M_Rental VALUES (8926, 0005, 1, '2011-04-11');
INSERT INTO M_Rental VALUES (8926, 0002, 3, '2011-04-11');
INSERT INTO M_Rental VALUES (8927, 0002, 4, '2011-04-11');
INSERT INTO M_Rental VALUES (8927, 0007, 1, '2011-04-12');
INSERT INTO M_Rental VALUES (8928, 0007, 2, '2011-04-12');
INSERT INTO M_Rental VALUES (8928, 0008, 1, '2011-04-13');
INSERT INTO M_Rental VALUES (8928, 0010, 2, '2011-04-14');
INSERT INTO M_Rental VALUES (8928, 0011, 1, '2011-04-14');
INSERT INTO M_Rental VALUES (8928, 0012, 1, '2011-04-14');
INSERT INTO M_Rental VALUES (8929, 0012, 2, '2011-04-14');
INSERT INTO M_Rental VALUES (8929, 0014, 2, '2011-04-14');
INSERT INTO M_Rental VALUES (8929, 0016, 2, '2011-04-14');


INSERT INTO M_Booking VALUES (8922, 0007, '2011-04-11', '2011-04-13', '2011-04-14');
INSERT INTO M_Booking VALUES (8922, 0003, '2011-04-11', '2011-04-13', '2011-04-14');
INSERT INTO M_Booking VALUES (8924, 0007, '2011-04-11', '2011-04-14', '2011-04-15');

-- Permanently save the data

COMMIT TRANSACTION;

GO
CREATE VIEW RentalQuery AS
SELECT LastName, FirstName, MovieID
FROM M_Customer, M_Rental
WHERE M_Customer.CustID = M_Rental.CustID;
GO