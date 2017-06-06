CREATE TRIGGER  deletedprouduct ON dbo.D_Product
INSTEAD OF DELETE
AS
	DECLARE @ProductID int;
	DECLARE @OrderID int;


	SELECT @ProductID=d.ProductID FROM DELETED d;
	SELECT @OrderID=d.OrderID FROM DELETED d;

	BEGIN 
			DELETE FROM D_Customer_Orders WHERE OrderID = @OrderID
			DELETE FROM D_Order WHERE OrderID = @OrderID;
			DELETE FROM D_Product WHERE ProductID = @ProductID
	END


