CREATE TABLE [dbo].[CharacterCharms]
(
	[CharacterId] INT NOT NULL , 
    [CharmId] INT NOT NULL, 
    PRIMARY KEY ([CharacterId], [CharmId]), 
    CONSTRAINT [FK_CharacterCharms_Characters] FOREIGN KEY (CharacterId) REFERENCES [dbo].[Characters](Id), 
    CONSTRAINT [FK_CharacterCharms_Charms] FOREIGN KEY (CharmId) REFERENCES [dbo].[Charms](Id)
)
