CREATE PROCEDURE [dbo].[SP_GameTag_GetByTag]
	@tag NVARCHAR(64)
AS
BEGIN
	SELECT [Game]
	FROM [GameTag]
	WHERE [Tag] = @tag
END
