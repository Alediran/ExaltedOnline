ALTER TABLE [dbo].[Charms]
	ADD CONSTRAINT [FK_Charms_TreeTypes]
	FOREIGN KEY (TreeTypeId)
	REFERENCES [dbo].[TreeTypes] (Id)
