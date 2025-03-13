CREATE PROCEDURE [dbo].[SP_Game_GetById]
	@game_id UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [Game_Id], [Name], [Description], [AgeMin], [AgeMax], [NbPlayersMin], [NbPlayersMax], [PlayingTime], [CreatedAt]
	FROM [Game]
	WHERE [Game_Id] = @game_id
END
