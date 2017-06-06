CREATE TRIGGER  deletedprouduct ON dbo.D_Product
INSTEAD OF DELETE
AS
	DECLARE @ProductID int;

	
	SELECT @ProductID=d.ProductID FROM DELETED d

	BEGIN
			DELETE FROM D_Order WHERE ProductID = @ProductID
			DELETE FROM D_Product WHERE ProductID = @ProductID
	END;

	DROP TRIGGER deletedprouduct

	DELETE FROM D_Product WHERE ProductID = 005



SELECT * FROM D_Product