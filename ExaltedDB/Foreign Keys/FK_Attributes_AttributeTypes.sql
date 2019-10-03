ALTER TABLE [dbo].[Attributes]
	ADD CONSTRAINT [FK_Attributes_AttributeTypes]
	FOREIGN KEY (AttributeTypeId)
	REFERENCES [dbo].[AttributeTypes] (Id)
