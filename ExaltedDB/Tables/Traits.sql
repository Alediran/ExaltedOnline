CREATE TABLE [dbo].[Traits]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ParentId] INT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
	[TraitTypeId] INT NOT NULL,
    [Description] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Traits_TraitTypes] FOREIGN KEY (TraitTypeId) REFERENCES [dbo].[TraitTypes](Id), 
    CONSTRAINT [FK_Traits_ToParentTraits] FOREIGN KEY (ParentId) REFERENCES [dbo].[Traits](Id)
)
