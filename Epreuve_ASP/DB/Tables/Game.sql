CREATE TABLE [dbo].[Game]
(
	[Game_Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[Name] NVARCHAR (150) NOT NULL,
	[Description] NVARCHAR (MAX) NOT NULL,
	[AgeMin] TINYINT NOT NULL,
	[AgeMax] TINYINT NOT NULL,
	[NbPlayersMin] TINYINT NOT NULL,
	[NbPlayersMax] TINYINT NOT NULL,
	[PlayingTime] INT,
	[CreatedAt] DATETIME2 NOT NULL DEFAULT GETDATE(),

	CONSTRAINT [PK_Game] PRIMARY KEY ([Game_Id]),
	CONSTRAINT [CK_Game_AgeDiff] CHECK ([AgeMin] < [AgeMax]),
	CONSTRAINT [CK_Game_NbPlayersDiff] CHECK ([NbPlayersMin] <= [NbPlayersMax])
)
