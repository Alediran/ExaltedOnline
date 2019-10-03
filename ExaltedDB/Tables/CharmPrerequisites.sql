CREATE TABLE [dbo].[CharmPrerequisites]
(
	[CharmId] INT NOT NULL , 
    [CharmPrerequisiteId] INT NOT NULL, 
    PRIMARY KEY ([CharmId], [CharmPrerequisiteId])
)
