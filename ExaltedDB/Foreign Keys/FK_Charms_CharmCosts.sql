ALTER TABLE [dbo].[CharmCosts]
	ADD CONSTRAINT [FK_Charms_CharmCosts]
	FOREIGN KEY (CharmId)
	REFERENCES [dbo].[Charms] (Id)
