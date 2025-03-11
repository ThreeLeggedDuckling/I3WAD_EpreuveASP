CREATE TABLE [dbo].[Copy]
(
	[Copy_Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[Game] UNIQUEIDENTIFIER NOT NULL,	-- jeux insupprimable
	[Owner] UNIQUEIDENTIFIER NOT NULL,	-- besoin trace
	[State] NVARCHAR (10) NOT NULL,

	CONSTRAINT [PK_Copy] PRIMARY KEY ([Copy_Id]),
	-- FK jeu
	CONSTRAINT [FK_Copy_Game] FOREIGN KEY ([Game])
		REFERENCES [Game]([Game_Id])
		ON DELETE CASCADE,
	-- FK propriétaire
	CONSTRAINT [FK_Copy_Owner] FOREIGN KEY ([Owner])
		REFERENCES [User]([User_Id])
		ON DELETE CASCADE,
	-- FK état
	CONSTRAINT [CK_Copy_State] CHECK ([State] in ('New', 'Damaged', 'Incomplete'))
)
