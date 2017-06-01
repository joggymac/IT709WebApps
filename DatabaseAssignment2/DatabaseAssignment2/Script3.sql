CREATE PROCEDURE ProductDiscountRaise
(
	@ProductID int
)
	AS
	BEGIN
	IF (Discount < 1) OR (Discount > 1)
	UPDATE D_Product SET Discount = @Discount + 1;
	ELSE 
	PRINT 'Error: Value must be greater than 0 and less than 1'
END

EXEC ProductDiscountRaise 