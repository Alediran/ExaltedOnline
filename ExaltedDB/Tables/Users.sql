CREATE TABLE [dbo].[Users]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [PasswordHash] VARBINARY(1024) NOT NULL, 
	[PasswordSalt] VARBINARY(1024) NOT NULL, 
	[UserRole] INT NOT NULL,
    [SignatureFirst] NVARCHAR(50) NULL
)
