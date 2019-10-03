ALTER TABLE [dbo].[Charms]
	ADD CONSTRAINT [FK_Charms_CharmTypes]
	FOREIGN KEY (TypeId)
	REFERENCES [dbo].[CharmTypes] (Id)
