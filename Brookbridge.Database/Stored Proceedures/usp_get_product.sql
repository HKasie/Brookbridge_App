CREATE PROCEDURE [dbo].[usp_get_product]
	@id INT 

AS
BEGIN
	SELECT * FROM products
	WHERE id = @id
END