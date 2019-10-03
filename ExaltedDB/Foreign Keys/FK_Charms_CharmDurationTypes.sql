ALTER TABLE [dbo].[Charms]
	ADD CONSTRAINT [FK_Charms_CharmDurationTypes]
	FOREIGN KEY (DurationId)
	REFERENCES [dbo].[CharmDurationTypes] (Id)
