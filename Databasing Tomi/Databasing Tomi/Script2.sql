/* SELECT LastName, FirstName from M_Customer
inner JOIN M_Booking ON M_customer.CustID = M_Booking.CustID
inner JOIN M_Movie On M_Booking.MovieID = M_Movie.MovieID
WHERE M_Movie.Title = 'Walking Tall'
order by LastName asc */


/* SELECT Title FROM M_Movie
inner JOIN M_Rental ON M_Movie.MovieID = M_Rental.MovieID
inner JOIN M_Customer ON M_Rental.CustID = M_Customer.CustID
WHERE M_Customer.LastName LIKE 'Black' AND M_Customer.FirstName LIKE 'Ray'
ORDER BY M_Movie.Title ASC */

/* SELECT StreetAddress FROM M_Supplier
inner JOIN M_Movie ON M_Supplier.SupplierID = M_Movie.SupplierID
WHERE M_Movie.Title = 'Emma' */

/* SELECT LastName, FirstName, Phone FROM M_Customer
INNER JOIN M_Rental ON M_Customer.CustID = M_Rental.CustID
INNER JOIN M_Movie ON M_Rental.MovieID = M_Movie.MovieID
WHERE M_Movie.Title = 'Apocalypse Now Redux'  */

/* Create view BookingQuery AS
SELECT LastName, Firstname, DateBooked, Title FROM M_customer, M_Booking, M_Movie */

/*Create view ActionQuery AS
SELECT LastName, Firstname, M_Booking.DateBooked, M_Movie.Title FROM M_customer, M_Booking, M_Movie
WHERE M_Movie.Cat = 'ACT' */


/*Create view RentalQuery AS
SELECT LastName, FirstName, M_Movie.MovieID FROM M_Customer
INNER JOIN M_Rental ON M_Customer.CustID = M_Rental.CustID
INNER JOIN M_Movie ON M_Movie.MovieID = M_Rental.MovieID */

/* SELECT LastName, FirstName, COUNT(M_Rental.MovieID) AS Rentals FROM M_Customer
INNER JOIN M_Rental ON M_Customer.CustID = M_Rental.CustID
INNER JOIN M_Movie ON M_Movie.MovieID = M_Rental.MovieID
GROUP BY LastName, Firstname */

/* SELECT DISTINCT LastName, FirstName FROM M_Customer
INNER JOIN M_Rental ON M_Customer.CustID = M_Rental.CustID
ORDER BY LastName ASC */

/* SELECT Cat, Description FROM M_Category
ORDER BY Description ASC */
/*
 SELECT DISTINCT CustID FROM M_Rental */

/* SELECT LastName, FirstName, CustID FROM M_Customer
 WHERE CustID = '8923' */

/* SELECT CustID, MovieID FROM M_Booking
WHERE MovieID = '7' */
/*
 SELECT MovieID FROM M_Booking
WHERE CustID = '8922' */

/* SELECT MovieID, Title FROM M_Movie
WHERE PurchasePrice <= $50 */

/* SELECT MovieID, Title FROM M_Movie
WHERE PurchasePrice BETWEEN '70' AND '75' */
/*
 SELECT CustID, MovieID, CopyID, DueDate FROM M_Rental
ORDER BY DueDate, MovieID */
 /*
SELECT Description FROM M_Category
WHERE Description LIKE 'm%' */

/* SELECT Cat, AVG(PurchasePrice) AS 'Average Purchase Price' FROM M_Movie
GROUP BY Cat */
/*
 SELECT SupplierID, AVG(PurchasePrice) FROM M_Movie
GROUP BY SupplierID */

/* SELECT M_Customer.CustID, M_Customer.LastName, M_Customer.Firstname, COUNT (MovieID) AS 'Movies Booked' FROM M_Booking
INNER JOIN M_Customer ON M_Booking.CustID = M_Customer.CustID
GROUP BY M_Customer.CustID, M_Customer.LastName, M_Customer.Firstname */

/* SELECT StreetAddress FROM M_Supplier
INNER JOIN M_Movie ON M_Supplier.SupplierID = M_Movie.SupplierID
WHERE M_Movie.Title = 'Kill Bill Vol. 1' */

/*  SELECT LastName, FirstName, Phone FROM M_Customer

INNER JOIN M_Rental ON M_Customer.CustID = M_Rental.CustID
INNER JOIN M_Movie ON M_Rental.MovieID = M_Movie.MovieID
WHERE M_Movie.Title = 'Kill Bill Vol. 2' */

/* SELECT ClientOrderID, AVG(Quantity) AS Average FROM Order_Line
GROUP BY ClientOrderID */
/*
 SELECT DISTINCT LastName, FirstName FROM M_Customer
INNER JOIN M_Rental ON M_Customer.CustID = M_Rental.CustID
ORDER BY LastName ASC*/ 

/* SELECT Cat, AVG(PurchasePrice) AS AvgPurchPrice FROM M_Movie
GROUP BY Cat */
 
/* SELECT Cat, AVG(PurchasePrice) AS AvgPurchPrice FROM M_Movie
GROUP BY Cat
ORDER BY AvgPurchPrice */

/* SELECT M_Supplier.SupplierID, AVG (M_Movie.PurchasePrice) AS SuppAvgPurchPrice FROM M_Supplier
INNER JOIN M_Movie ON M_Supplier.SupplierID = M_Movie.SupplierID
GROUP BY M_Supplier.SupplierID */

/* SELECT CustID, COUNT(MovieID) AS MovieBook FROM M_Booking
GROUP BY CustID */

/* SELECT CityCode, CityName, City_pop FROM City
ORDER BY CityName DESC */

/* SELECT WhID, SUM (Capacity - Capacity_used) AS 'Unused Capacity' FROM Warehouse
GROUP BY WhID, CityCode
ORDER BY CityCode */

/* SELECT DISTINCT CityCode AS 'SupplierCity' FROM Supplier */

/* SELECT WhID, WAddress AS 'Warehouse Address', CityCode FROM Warehouse
WHERE CityCode < '3' AND WAddress LIKE '%RD' OR WAddress LIKE '%St' */

/* SELECT Stkname, SellPrice FROM Stockitem
WHERE SellPrice BETWEEN '10' AND '30' AND suppid <= 54 */

/* SELECT WhID, Mgrname FROM Warehouse
WHERE Capacity < 25000 OR Mgrname LIKE '%am%' */

/* SELECT STKNAME, PURCHASEPRICE, WhID FROM StockItem
WHERE PurchasePrice < 15 AND WhID LIKE '%21%' OR WhID LIKE '%24%'OR WhID LIKE '%25%' */

/* SELECT MAX(PurchasePrice) AS 'Highest Purchase Price' FROM StockItem */

/* SELECT AVG(sellprice) AS 'Average Selling Price' FROM StockItem
WHERE WhID = '24' */

/* SELECT Title, SUM (Quantity - QuantityOut) FROM M_Movie
INNER JOIN M_Supplier ON M_Movie.SupplierID = M_Supplier.SupplierID
WHERE SupplierName = 'South Videos' OR SupplierName = 'North Videos' OR SupplierName = 'Central Videos'
GROUP BY Title */ 

/* SELECT LastName, FirstName FROM M_Customer

INNER JOIN M_Booking ON M_Customer.CustID = M_Booking.CustID
INNER JOIN M_Movie ON M_Booking.MovieID = M_Movie.MovieID
WHERE M_Movie.Title = 'Walking Tall' */
/*
 SELECT DISTINCT Title, Cat FROM M_Movie
INNER JOIN M_Rental ON M_Movie.MovieID = M_Rental.MovieID
INNER JOIN M_Customer ON M_Rental.CustID = M_customer.CustID
INNER JOIN M_Supplier ON M_Movie.SupplierID = M_Supplier.SupplierID

WHERE M_Supplier.SupplierName = 'North Videos' AND M_Customer.LastName = 'Jackson' AND M_Customer.FirstName = 'Sam' OR M_Customer.LastName = 'Cole' AND M_Customer.FirstNAme = 'Joe'
*/

/* SELECT (LastName + ' ' + FirstName) AS 'Customer name', COUNT(M_Rental.MovieID) FROM M_Customer 

INNER JOIN M_Rental ON M_Customer.CustID = M_Rental.CustID
INNER JOIN M_Movie ON M_Rental.MovieID = M_Movie.MovieID
INNER JOIN M_Supplier ON M_Movie.SupplierID = M_Supplier.SupplierID
WHERE M_Supplier.SupplierName = 'South Videos'
GROUP BY LastName, Firstname */

/* SELECT M_Supplier.SupplierName, AVG(M_Movie.PurchasePrice) FROM M_Supplier
INNER JOIN M_Movie ON M_Movie.SupplierID = M_Supplier.SupplierID
WHERE M_Movie.QuantityOut <> '1'
GROUP BY M_Supplier.SupplierName  */

/* SELECT Title, RentalPrice FROM M_Movie
GROUP BY Title, RentalPrice
HAVING AVG(RentalPrice) > RentalPrice */


/* SELECT CityCode, MIN(Capacity) FROM Warehouse

GROUP BY CityCode
HAVING MIN(Capacity) >= '20000' */

/* SELECT CityCode, COUNT(suppid) AS 'Number of Suppliers' FROM Supplier
WHERE suppname LIKE 'R%'
GROUP BY CityCode */

SELECT SuppID, AVG(sellprice) FROM Stockitem

WHERE purchaseprice BETWEEN '9' AND '19'
GROUP BY SuppID
HAVING AVG(sellprice) > 20 








