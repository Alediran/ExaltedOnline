CREATE TABLE [dbo].[Charms]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
	[Essence] INT NOT NULL, 
    [TreeTypeId] INT NOT NULL,
	[TypeId] INT NOT NULL,
	[DurationId] INT NOT NULL,
    [Description] NVARCHAR(MAX) NULL, 
    [IsCustomCharm] BIT NULL, 
    [GameId] INT NULL
)
