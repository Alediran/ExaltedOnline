ALTER TABLE [dbo].[Castes]
	ADD CONSTRAINT [FK_Castes_TreeTypes]
	FOREIGN KEY (TreeTypeId)
	REFERENCES [dbo].[TreeTypes] (Id)
