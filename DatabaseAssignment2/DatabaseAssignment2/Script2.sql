CREATE PROCEDURE DeleteOrderRecord

	@CustID int

AS
BEGIN
DELETE FROM D_Sales_Rep WHERE CustID = @CustID
DELETE FROM D_Order WHERE CustID = @CustID
DELETE FROM D_Customer WHERE CustID = @CustID

END
GO

DROP PROCEDURE DeleteOrderRecord
EXECUTE DeleteOrderRecord 2001

SELECT * FROM D_Customer, D_Order