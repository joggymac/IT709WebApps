DROP TABLE Stockitem;
DROP TABLE Warehouse;
DROP TABLE Supplier;
DROP TABLE City;

CREATE TABLE City
(
	CityCode		NUMERIC(2)			PRIMARY KEY,
	CityName		NVARCHAR(30),
	City_pop		NUMERIC(7)
)

CREATE TABLE Warehouse
(
	WhID			NUMERIC(2)			PRIMARY KEY,
	Capacity		NUMERIC(7),
	Capacity_used	NUMERIC(7),	
	Mgrname			NVARCHAR(30),
	MgrGender		VARCHAR(1),
	WAddress		NVARCHAR(30),
	CityCode		NUMERIC(2)			NOT NULL REFERENCES City(CityCode)
)

CREATE TABLE Supplier
(
	suppid			NUMERIC(2)		PRIMARY KEY,
	suppname		NVARCHAR(30),
	CityCode		NUMERIC(2)		NOT NULL REFERENCES City(CityCode)
)

CREATE TABLE Stockitem
(
	stkid			NUMERIC(2)		PRIMARY KEY,
	stkname			NVARCHAR(30),
	suppid			NUMERIC(2)		NOT NULL REFERENCES Supplier(suppid),
	sellprice		NUMERIC(6,2),
	purchaseprice	NUMERIC(6,2),
	WhID			NUMERIC(2)		NOT NULL REFERENCES Warehouse(WhID),
)

INSERT INTO City VALUES (1, 'Melbourne',	4168000);
INSERT INTO City VALUES (2, 'Sydney',		4605000);
INSERT INTO City VALUES (3, 'Adelaide',		1259000);
INSERT INTO City VALUES (4, 'Brisbane',		2140000);
INSERT INTO City VALUES (5, 'Darwin',		 135000);

INSERT INTO Warehouse VALUES(21, 40000, 10000, 'Curtis Donovan',	'M', '15 Station Way',		1);
INSERT INTO Warehouse VALUES(22, 32000, 30000,	'Simon Bellamy',	'M', '20 Christie Drive',	2);
INSERT INTO Warehouse VALUES(23, 30000, 15000,	'Alisha Daniels',	'F', '120 High St',			1);
INSERT INTO Warehouse VALUES(24, 15000, 10000,	'Rudy Wade',		'M', '4 Bluff Rd',			3);
INSERT INTO Warehouse VALUES(25, 20000, 17400,	'Nathan Young',		'M', '106‐108 Lois Lane',	1);
INSERT INTO Warehouse VALUES(26, 27500, 5000,	'Seth Jones',		'M', '914 Riverside Rd'		,4);
INSERT INTO Warehouse VALUES(27, 10000, 6500,	'Abbey Smith',		'F', '208 Christie St'		,2);
INSERT INTO Warehouse VALUES(28, 24000, 20000,	'Finn Samson',		'M', '41 Arliss Way'		,4);
INSERT INTO Warehouse VALUES(29, 21500, 8700,	'Tony Morecombe',	'M', '60 Van Der Kleeck St'	,2);

INSERT INTO Supplier VALUES(51, 'SJ Smith Emporium'			,1);
INSERT INTO Supplier VALUES(52, 'Rose Tyler Electrics'		,2);
INSERT INTO Supplier VALUES(53, 'Noble House and Home'		,3);
INSERT INTO Supplier VALUES(54, 'The Pond and River Song'	,4);
INSERT INTO Supplier VALUES(55, 'Martha Jones Market'		,1);
INSERT INTO Supplier VALUES(56, 'Rory Williams Space Savers',2);

INSERT INTO Stockitem VALUES(71, 'Electric Fan'	,52,	15.5,	6.2,	21);--unassigned in revision worksheet
INSERT INTO Stockitem VALUES(74, 'Drill Set'	,55,	26,		9.1,	22);
INSERT INTO Stockitem VALUES(77, 'Sun Lounge'	,53,	38,		19,		23);
INSERT INTO Stockitem VALUES(78, 'Whisk Combo'	,51,	11,		2.75,	23);--conflicts with WhID 21
INSERT INTO Stockitem VALUES(82, 'Solar Pump'	,54,	5.6,	1.68,	24);
INSERT INTO Stockitem VALUES(84, 'Storage Box'	,56,	27.75,	9.72,	25);
INSERT INTO Stockitem VALUES(85, 'Refrigerator'	,52,	40,		22,		27);
INSERT INTO Stockitem VALUES(88, 'DVD player'	,51,	32.5,	18.5,	24);
INSERT INTO Stockitem VALUES(89, 'Garden Tools'	,56,	18,		7.2,	21);