CREATE TRIGGER updateproduct
ON dbo.D_Product
AFTER UPDATE
AS
BEGIN
	UPDATE D_Product SET Unit_Price = Unit_Price + (Unit_Price * 0.15);
END

UPDATE D_Product 
SET Unit_Price = 31 WHERE ProductID = 001

DROP TRIGGER updateproduct

SELECT Unit_Price FROM D_Product