CREATE TABLE [dbo].[CharmTraits]
(
	[CharmId] INT NOT NULL, 
    [TraitId] INT NOT NULL, 
    [DisplayOrder] INT NOT NULL,
    [AttributeLevel] INT NOT NULL,  
    PRIMARY KEY ([CharmId], [TraitId])
)
