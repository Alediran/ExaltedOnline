ALTER TABLE [dbo].[CharmTraits]
	ADD CONSTRAINT [FK_CharmTraits_Traits]
	FOREIGN KEY (TraitId)
	REFERENCES [dbo].[Traits] (Id)
