CREATE TABLE [dbo].[TaggedGame]
(
	[Game] UNIQUEIDENTIFIER NOT NULL,
	[Tag] NVARCHAR (64) NOT NULL,

	-- PK composite
	CONSTRAINT [PK_TaggedGame] PRIMARY KEY ([Game], [Tag]),
	-- FK jeu
	CONSTRAINT [FK_TaggedGame_Game] FOREIGN kEY ([Game])
		REFERENCES [Game]([Game_Id])
		ON DELETE CASCADE,
	-- FK tag
	CONSTRAINT [FK_TaggedGame_Tag] FOREIGN kEY ([Tag])
		REFERENCES [Tag]([Tag])
		ON DELETE CASCADE,
)
GO

-- ajout d'index pour de meilleures performances de requête
CREATE INDEX [IX_TaggedGame_Game] ON [dbo].[TaggedGame] ([Game])
GO
CREATE INDEX [IX_TaggedGame_Tag] ON [dbo].[TaggedGame] ([Tag])
GO
