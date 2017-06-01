

CREATE PROCEDURE InsertCustomerRecord
(
	@CustID int,
	@Lname VARCHAR(20),
	@Fname VARCHAR(20)
)
AS
BEGIN 
		INSERT INTO dbo.D_Customer (CustID, Lname, Fname)
		VALUES (@CustID, @Lname, @Fname)
END

EXECUTE InsertCustomerRecord 2007, Fredrick, Andy

SELECT * FROM D_Customer

