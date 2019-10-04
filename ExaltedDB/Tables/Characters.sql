CREATE TABLE [dbo].[Characters](
	[Id] [int] NOT NULL,
    [GameId] INT NULL, 	
    [OwnerId] INT NOT NULL, 
	[Name] [nvarchar](50) NOT NULL,
	[TreeTypeId] [int] NOT NULL,
	[CasteId] [int] NOT NULL,
	[Concept] NVARCHAR(50) NULL, 
    [Anima] NVARCHAR(50) NULL, 
    [Willpower] INT NULL, 
    [WillpowerCurrent] INT NULL, 
    [Essence] INT NULL, 
    [EssenceCurrentPersonal] INT NULL, 
    [EssenceCurrentPeripheral] NCHAR(10) NULL, 
    [ExperienceCurrent] INT NULL, 
    [ExperienceTotal] INT NULL, 
    [ExperienceTypeCurrent] INT NULL, 
    [ExperienceTypeTotal] INT NULL, 
    [LimitTrigger] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_Characters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO