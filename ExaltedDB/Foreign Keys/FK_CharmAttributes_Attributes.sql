ALTER TABLE [dbo].[CharmAttributes]
	ADD CONSTRAINT [FK_CharmAttributes_Attributes]
	FOREIGN KEY (AttributeId)
	REFERENCES [dbo].[Attributes] (Id)
