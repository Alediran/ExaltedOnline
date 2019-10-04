CREATE TABLE [dbo].[AdditionalAbilities]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CharacterId] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Total] INT NOT NULL, 
    CONSTRAINT [FK_AdditionalAbilities_Character] FOREIGN KEY (CharacterId) REFERENCES [dbo].[Characters](Id)
)
