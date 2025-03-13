CREATE PROCEDURE [dbo].[SP_GameTag_Insert]
	@game_id UNIQUEIDENTIFIER,
	@tag NVARCHAR(64)
AS
BEGIN
	INSERT INTO [GameTag] ([Game], [Tag])
	OUTPUT [inserted].[Tag]
	VALUES (@game_id, @tag)
END
