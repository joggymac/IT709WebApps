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

