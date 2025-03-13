CREATE PROCEDURE [dbo].[SP_User_Update]
	@user_id UNIQUEIDENTIFIER,
	@username NVARCHAR(64)
AS
BEGIN
	UPDATE [User]
		SET [Username] = @username
		WHERE [User_Id] = @user_id
END
