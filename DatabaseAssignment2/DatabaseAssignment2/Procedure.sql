

CREATE PROCEDURE InsertCustomerRecord
(
@CustID int,
@Lname VARCHAR(20),
@Fname VARCHAR(20)
)
AS
BEGIN 
		INSERT INTO D_Customer (CustID, Lname, Fname)
		VALUES (2006, 'Fletcher', 'Jack')
END

EXECUTE InsertCustomerRecord