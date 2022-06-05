CREATE TABLE [dbo].[Category]
(
	[CategoryId] INT NOT NULL PRIMARY KEY IDENTITY,
	[CategoryName] VARCHAR(20) NOT NULL,
    CreatedAt DATETIME,
	UpdatedAt DATETIME
)
