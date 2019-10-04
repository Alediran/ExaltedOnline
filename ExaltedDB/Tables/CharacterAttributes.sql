CREATE TABLE [dbo].[CharacterAttributes]
(
	[CharacterId] INT NOT NULL , 
    [AttributeId] INT NOT NULL, 
    [IsFavored] BIT NULL DEFAULT 0, 
    [IsSupernal] INT NULL DEFAULT 0, 
    PRIMARY KEY ([CharacterId], [AttributeId]), 
    CONSTRAINT [FK_CharacterAttributes_Characters] FOREIGN KEY (CharacterId) REFERENCES [dbo].[Characters](Id), 
    CONSTRAINT [FK_CharacterAttributes_Attributes] FOREIGN KEY (AttributeId) REFERENCES [dbo].[Traits](Id)
)
