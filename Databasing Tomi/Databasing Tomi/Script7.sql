--SELECT Title, SUM(Quantity - QuantityOut) AS 'QuantityIn' FROM M_Movie, M_Supplier
--WHERE SupplierName IN (SELECT SupplierName FROM M_Supplier WHERE SupplierName = 'South Videos' OR SupplierName = 'North Videos' OR SupplierName = 'Central Videos')
--GROUP BY Title

--SELECT LastName, FirstName FROM M_customer
--INNER JOIN M_Rental ON M_customer.CustID = M_Rental.CustID
--INNER JOIN M_Movie ON M_Movie.MovieID = M_Rental.MovieID

--WHERE M_Movie.Title = 'Walking Tall'

--SELECT DISTINCT Title, Cat FROM M_Movie, M_Supplier, M_Rental
--WHERE M_Movie.SupplierID IN (SELECT SupplierID FROM M_Supplier WHERE SupplierName = 'North Videos') 
--AND M_Rental.CustID IN (SELECT CustID FROM M_customer WHERE LastName = 'Jackson' AND FirstName = 'Sam' OR LastName = 'Cole' AND FirstName = 'Joe')

--SELECT M_Movie.Title, M_Movie.Cat FROM M_Movie
--INNER JOIN M_Supplier ON M_Supplier.SupplierID = M_Movie.SupplierID
--INNER JOIN M_Rental ON M_Movie.MovieID = M_Rental.MovieID
--INNER JOIN M_Customer ON  M_Rental.CustID = M_Customer.CustID
--WHERE M_Supplier.SupplierName = 'North Videos' AND (M_Customer.LastName = 'Cole' AND M_Customer.FirstName = 'Joe' OR M_Customer.LastName = 'Jackson' AND M_Customer.FirstName = 'Sam')

--SELECT Title FROM M_Movie,M_Booking
--WHERE M_Booking.MovieID IN (SELECT MovieID FROM M_Booking WHERE M_Movie.MovieID != M_Booking.MovieID)
--AND M_Movie.MovieID = M_Movie.MovieID

SELECT Cat, Description FROM 