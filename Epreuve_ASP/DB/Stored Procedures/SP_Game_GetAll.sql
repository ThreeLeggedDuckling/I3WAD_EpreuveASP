CREATE PROCEDURE [dbo].[SP_Game_GetAll]
AS
BEGIN
	SELECT [Game_Id], [Name], [Description], [Age_Min], [Age_Max], [Nb_Players_Min], [Nb_Players_Max], [Playing_Time]
	FROM [Game]
END
