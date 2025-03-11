CREATE PROCEDURE [dbo].[SP_User_GetById]
	@user_id UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [User_Id],
			[Email],
			[Created_At],
			[Disabled_At]
	FROM [User]
	WHERE [User_Id] = @user_id
END
