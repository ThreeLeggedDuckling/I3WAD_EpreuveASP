CREATE PROCEDURE [dbo].[SP_Game_GetAll]
AS
BEGIN
	SELECT [Game_Id], [Name], [Description], [AgeMin], [AgeMax], [NbPlayersMin], [NbPlayersMax], [PlayingTime]
	FROM [Game]
END
