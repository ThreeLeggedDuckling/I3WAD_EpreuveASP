CREATE PROCEDURE [dbo].[SP_Game_Insert]
	@name NVARCHAR(150),
	@description NVARCHAR(MAX),
	@age_min TINYINT,
	@age_max TINYINT,
	@nb_players_min TINYINT,
	@nb_players_max TINYINT,
	@playing_time INT
AS
BEGIN
	INSERT INTO [Game] ([Name], [Description], [Age_Min], [Age_Max], [Nb_Players_Min], [Nb_Players_Max], [Playing_Time])
	OUTPUT [inserted].[Game_Id]
	VALUES (@name, @description, @age_min, @age_max, @nb_players_min, @nb_players_max, @playing_time)	
END
