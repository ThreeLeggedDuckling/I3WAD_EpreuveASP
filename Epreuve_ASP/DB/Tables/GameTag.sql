CREATE TABLE [dbo].[GameTag]
(
	[Game] UNIQUEIDENTIFIER NOT NULL,
	[Tag] NVARCHAR (64) NOT NULL,

	-- PK composite
	CONSTRAINT [PK_GameTag] PRIMARY KEY ([Game], [Tag]),
	-- FK jeu
	CONSTRAINT [FK_GameTag_Game] FOREIGN kEY ([Game])
		REFERENCES [Game]([Game_Id])
		ON DELETE CASCADE,
	-- FK tag
	CONSTRAINT [FK_GameTag_Tag] FOREIGN kEY ([Tag])
		REFERENCES [Tag]([Tag])
		ON DELETE CASCADE,
)
