CREATE PROCEDURE [dbo].[SP_User_Insert]
	@email NVARCHAR(320),
	@username NVARCHAR(64),
	@password NVARCHAR(32)
AS
BEGIN
	DECLARE @salt UNIQUEIDENTIFIER
	SET @salt = NEWID()
	INSERT INTO [User] ([Email], [Username], [Password], [Salt])
	OUTPUT [inserted].[User_Id]
	VALUES (@email, @username, [dbo].[SF_SaltAndHash](@password, @salt), @salt)
END
