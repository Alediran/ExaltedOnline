ALTER TABLE [dbo].[CharmAttributes]
	ADD CONSTRAINT [FK_CharmAtttributes_Charms]
	FOREIGN KEY (CharmId)
	REFERENCES [dbo].[Charms] (Id)
