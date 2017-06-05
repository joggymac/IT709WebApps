CREATE TRIGGER Unit_Price on dbo.D_Product

AFTER UPDATE
AS
BEGIN
UPDATE Unit_Price SET Unit_Price = Unit_Price + (Unit_Price * 15);
END	