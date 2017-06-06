﻿CREATE PROCEDURE ProductDiscountRaise
(
	@Discount int
)
	AS
	BEGIN
	IF EXISTS (Select ProductID FROM D_Product WHERE Discount > 0 OR Discount < 1)
	Update D_Product SET Discount = @Discount + 1;
	ELSE 
	PRINT 'Error: Value must be greater than 0 and less than 1'
END

DROP PROCEDURE ProductDiscountRaise;

EXEC ProductDiscountRaise 0

SELECT Discount FROM D_Product