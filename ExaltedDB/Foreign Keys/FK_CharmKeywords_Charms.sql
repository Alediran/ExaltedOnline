ALTER TABLE [dbo].[CharmKeywords]
	ADD CONSTRAINT [FK_CharmKeywords_Charms]
	FOREIGN KEY (CharmId)
	REFERENCES [dbo].[Charms] (Id)
