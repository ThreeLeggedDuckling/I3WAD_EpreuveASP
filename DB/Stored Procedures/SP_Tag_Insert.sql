CREATE PROCEDURE [dbo].[SP_Tag_Insert]
	@tag NVARCHAR(64)
AS
BEGIN
	INSERT INTO	[Tag] ([Tag_Id])
	OUTPUT [inserted].[Tag_Id]
	VALUES (@tag)
END
