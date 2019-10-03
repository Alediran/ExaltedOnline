ALTER TABLE [dbo].[CharmPrerequisites]
	ADD CONSTRAINT [FK_CharmPrerequisites_Charms1]
	FOREIGN KEY (CharmPrerequisiteId)
	REFERENCES [dbo].[Charms] (Id)
