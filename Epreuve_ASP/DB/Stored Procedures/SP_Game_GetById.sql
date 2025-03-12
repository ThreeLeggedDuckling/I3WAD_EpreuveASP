CREATE PROCEDURE [dbo].[SP_Game_GetById]
	@game_id UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [Game_Id], [Name], [Description], [Age_Min], [Age_Max], [Nb_Players_Min], [Nb_Players_Max], [Playing_Time], [Created_At]
	FROM [Game]
	WHERE [Game_Id] = @game_id
END
