CREATE TABLE [dbo].[CharmKeywords]
(
	[CharmId] INT NOT NULL , 
    [KeywordId] INT NOT NULL, 
    [DisplayOrder] INT NOT NULL, 
    PRIMARY KEY ([CharmId], [KeywordId])
)
