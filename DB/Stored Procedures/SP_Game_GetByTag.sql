CREATE PROCEDURE [dbo].[SP_Game_GetByTag]
	@tag NVARCHAR(64)
AS
BEGIN
	SELECT [Game_Id],
			[Name],
			[Description],
			[AgeMin],
			[AgeMax],
			[NbPlayersMin],
			[NbPlayersMax],
			[PlayingTime],
			[CreatedAt]
	FROM [Game] g
	INNER JOIN [GameTag] gt ON g.[Game_Id] = gt.[Game]
	WHERE [Tag] = @tag
END
