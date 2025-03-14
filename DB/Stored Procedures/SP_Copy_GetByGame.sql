CREATE PROCEDURE [dbo].[SP_Copy_GetByGame]
	@game UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [Copy_Id],
			[Game],
			[Owner],
			[State]
	FROM [Copy]
	WHERE [Game] = @game
END
