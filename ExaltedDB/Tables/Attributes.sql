CREATE TABLE [dbo].[Attributes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
	[AttributeTypeId] INT NOT NULL,
    [Description] NVARCHAR(MAX) NULL
)
