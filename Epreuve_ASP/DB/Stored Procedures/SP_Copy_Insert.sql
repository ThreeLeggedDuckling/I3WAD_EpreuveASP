CREATE PROCEDURE [dbo].[SP_Copy_Insert]
	@game_id UNIQUEIDENTIFIER,
	@user_id UNIQUEIDENTIFIER,
	@state NVARCHAR(10)
AS
BEGIN
	INSERT INTO [Copy] ([Game], [Owner], [State])
	OUTPUT [inserted].[Copy_Id]
	VALUES (@game_id, @user_id, @state)
END
