ALTER TABLE [dbo].[CharmCosts]
	ADD CONSTRAINT [FK_CharmCostTypes_CharmCosts]
	FOREIGN KEY (CostTypeId)
	REFERENCES [dbo].[CharmCostTypes] (Id)
