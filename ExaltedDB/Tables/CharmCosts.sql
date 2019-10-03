CREATE TABLE [dbo].[CharmCosts]
(
    [CharmId] INT NOT NULL, 
    [CostTypeId] INT NOT NULL, 
    [DisplayOrder] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    CONSTRAINT [PK_CharmCosts] PRIMARY KEY ([CharmId], [CostTypeId]) 
)
