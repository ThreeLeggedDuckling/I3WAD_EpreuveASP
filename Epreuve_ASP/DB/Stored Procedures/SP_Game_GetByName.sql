CREATE PROCEDURE [dbo].[SP_Game_GetByName]
	@name NVARCHAR(150)
AS
BEGIN
	SELECT [Game_Id], [Name], [Description], [Age_Min], [Age_Max], [Nb_Players_Min], [Nb_Players_Max], [Playing_Time]
	FROM [Game]
	WHERE [Name] LIKE @name		-- ajouter wildcard + protection injection
END
