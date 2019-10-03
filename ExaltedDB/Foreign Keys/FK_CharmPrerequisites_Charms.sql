ALTER TABLE [dbo].[CharmPrerequisites]
	ADD CONSTRAINT [FK_CharmPrerequisites_Charms]
	FOREIGN KEY (CharmId)
	REFERENCES [dbo].[Charms] (Id)
