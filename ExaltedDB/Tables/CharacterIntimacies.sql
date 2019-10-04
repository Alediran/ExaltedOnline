CREATE TABLE [dbo].[CharacterIntimacies]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CharacterId] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [IntensityId] INT NOT NULL, 
    CONSTRAINT [FK_CharacterIntimacies_Characters] FOREIGN KEY (CharacterId) REFERENCES [dbo].[Characters](Id), 
    CONSTRAINT [FK_CharacterIntimacies_IntimaciesIntensity] FOREIGN KEY (IntensityId) REFERENCES [dbo].[IntimaciesIntensity](Id)
)
