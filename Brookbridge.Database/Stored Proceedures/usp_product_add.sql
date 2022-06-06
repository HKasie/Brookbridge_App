CREATE PROCEDURE [dbo].[usp_product_add]
	@name NVARCHAR(256),
	@description NVARCHAR(512),
	@code NVARCHAR(256),
	@price DECIMAL(8,2),
	@qty INT,
	@veg BIT,
	@date_added DATETIME

AS
BEGIN
	INSERT INTO products(
		[name],
		[description],
		[code],
		[price],
		[qty],
		[veg],
		[date_added]
		)
	OUTPUT inserted.id
	VALUES (@name,
			@description,
			@code,
			@price,
			@qty,
			@veg,
			@date_added)
END