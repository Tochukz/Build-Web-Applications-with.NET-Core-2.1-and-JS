CREATE PROCEDURE [dbo].[spSubcategoryByName]
	@Name nvarchar(20)
AS
	SELECT dbo.Subcategory.*
	FROM dbo.Subcategory
	WHERE SubcategoryName = @Name;
RETURN 0
