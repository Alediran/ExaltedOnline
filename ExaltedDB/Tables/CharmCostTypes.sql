CREATE TABLE [dbo].[CharmCostTypes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [DisplayFormat] NVARCHAR(5) NOT NULL
)
