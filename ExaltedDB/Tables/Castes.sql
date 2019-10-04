CREATE TABLE [dbo].[Castes](
	[Id] [int] NOT NULL,
	[TreeTypeId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL, 
    CONSTRAINT [PK_Castes] PRIMARY KEY ([Id])
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO