CREATE TABLE [dbo].[Subcategory]
(
	[SubCategoryId] INT NOT NULL PRIMARY KEY IDENTITY,
	SubcategoryName VARCHAR(20) NOT NULL,
	CategoryId INT,
	CreatedAt DATETIME,
	UpdateAt DATETIME, 
    CONSTRAINT [FK_Subcategory_Category] FOREIGN KEY (CategoryId) REFERENCES Category([CategoryId]),
)
