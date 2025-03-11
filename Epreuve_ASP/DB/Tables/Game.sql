CREATE TABLE [dbo].[Game]
(
	[Game_Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[Name] NVARCHAR (150) NOT NULL,
	[Description] NVARCHAR (MAX) NOT NULL,
	[Age_Min] TINYINT NOT NULL,
	[Age_Max] TINYINT NOT NULL,
	[Nb_Players_Min] TINYINT NOT NULL,
	[Nb_Players_Max] TINYINT NOT NULL,
	[Playing_Time] INT,
	[Created_At] DATETIME2 NOT NULL DEFAULT GETDATE(),

	CONSTRAINT [PK_Game] PRIMARY KEY ([Game_Id]),
	CONSTRAINT [CK_Game_AgeDiff] CHECK ([Age_Min] < [Age_Max]),
	CONSTRAINT [CK_Game_NbPlayersDiff] CHECK ([Nb_Players_Min] <= [Nb_Players_Max])
)
