CREATE TABLE [dbo].[CharmAttributes]
(
	[CharmId] INT NOT NULL, 
    [AttributeId] INT NOT NULL, 
    [DisplayOrder] INT NOT NULL,
    [AttributeLevel] INT NOT NULL,  
    PRIMARY KEY ([CharmId], [AttributeId])
)
