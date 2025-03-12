CREATE TABLE [dbo].[User]
(
	[User_Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[Email] NVARCHAR (320) NOT NULL,
	[Username] NVARCHAR (64) NOT NULL,
	[Password] VARBINARY (64) NOT NULL,
	[Salt] UNIQUEIDENTIFIER NOT NULL,	-- ajout salt pour sécurisation mdp
	[CreatedAt] DATETIME2 NOT NULL DEFAULT GETDATE(),
	[DisabledAt] DATETIME2,

	CONSTRAINT [PK_User] PRIMARY KEY ([User_Id]),
	CONSTRAINT [UK_User_Email] UNIQUE ([Email]),
	CONSTRAINT [UK_User_Username] UNIQUE ([Username])
)
