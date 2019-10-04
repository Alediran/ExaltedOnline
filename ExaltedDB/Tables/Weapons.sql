CREATE TABLE [dbo].[Weapons]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CharacterId] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Withering] INT NOT NULL, 
    [Decisive] INT NOT NULL, 
    [Damage] INT NOT NULL, 
    CONSTRAINT [FK_Weapons_Characters] FOREIGN KEY (CharacterId) REFERENCES [dbo].[Characters](Id)
)
