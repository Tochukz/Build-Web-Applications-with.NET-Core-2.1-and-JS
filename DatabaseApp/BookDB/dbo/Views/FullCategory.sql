CREATE VIEW [dbo].[FullCategory]
	AS 
	SELECT [sbt].[SubCategoryId], 
	       [sbt].[SubcategoryName], 
		   [sbt].[CategoryId], 		   
	       [cat].[CategoryId] AS CatId, [cat].[CategoryName],
		   [sbt].[CreatedAt], 
		   [sbt].[UpdateAt]
	FROM dbo.Subcategory sbt
	LEFT JOIN dbo.Category cat 
	ON sbt.CategoryId = cat.[CategoryId];
