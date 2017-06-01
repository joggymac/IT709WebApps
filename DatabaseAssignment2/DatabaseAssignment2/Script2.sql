CREATE PROCEDURE DeleteOrderRecord

	@OrderID int

AS
BEGIN
DELETE FROM D_Customer_Orders WHERE OrderID = @OrderID
DELETE FROM D_Order WHERE OrderID = @OrderID
END
GO

EXECUTE DeleteOrderRecord 1005