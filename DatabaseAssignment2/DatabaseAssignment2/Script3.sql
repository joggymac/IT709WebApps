CREATE PROCEDURE ProductDiscountRaise
(
	@Discount int
)
	AS
	BEGIN
	IF EXISTS (Select Discount FROM D_Product WHERE Discount >= 0 AND Discount < 1 AND No_of_Units >= (Min_Level * 2))
	BEGIN
	Update D_Product SET Discount = @Discount + 1;
	END
	ELSE 
	PRINT 'Error: Value must be greater than 0 and less than 1'
END

DROP PROCEDURE ProductDiscountRaise;

EXEC ProductDiscountRaise 0

SELECT Discount FROM D_Product