﻿CREATE PROCEDURE [dbo].[SP_Game_GetByName]
	@name NVARCHAR(150)
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
	FROM [Game]
	WHERE [Name] LIKE '%' + @name + '%'
END
