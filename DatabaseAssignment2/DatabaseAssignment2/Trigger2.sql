CREATE Trigger DeletedProduct
on db.D_Product
INSTEAD OF DELETE
AS
BEGIN 
DELETE FROM D_Order WHERE 
